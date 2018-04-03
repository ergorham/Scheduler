using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Scheduler
{
    public partial class Form1 : Form
    {
        private List<Order> _orders = new List<Order>();
        private const string OrderListName = "NB_Order_List.csv";
        private const string DefaultWorkbookPath = "S:\\AECCommon\\MP&L\\AEC PRIORITY SHEETS\\AEC RADAR\\2018\\";
        private DateTime earliestDate = DateTime.Now.AddDays(10);
        private Color _backColor = Color.White;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetCurr_Click(object sender, EventArgs e)
        {
            //assumes the file is a serialization of the orders list
            //future improvement would be to use something like JSON
            //for now it's just csv
            //format is APN, DEST, DueDate, Qty
            //Only one order per dest/APN allowed

            LoadOrdersFromFile();
            UpdateList();
        }

        private void LoadOrdersFromFile()
        {
            var sread = new StreamReader(OrderListName);
            while (!sread.EndOfStream)
            {
                try
                {
                    var newLine = sread.ReadLine().Split(',');
                    var newOrd = new Order()
                    {
                        AutolivPartNum = newLine[0],
                        Destination = newLine[1],
                        DueDate = DateTime.Parse(newLine[2]),
                        Quantity = Convert.ToInt32(newLine[3]),
                        CustomerPartNum = newLine[4]
                    };
                    _orders.Add(newOrd);
                    if (newOrd.DueDate < earliestDate)
                        earliestDate = newOrd.DueDate;
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void UpdateList()
        {
            dgvList.EnableHeadersVisualStyles = false;
            _backColor = Color.White;
            dgvList.Rows.Clear();
            var dateList = new List<string>();
            for (var i = 0; i < dgvList.ColumnCount - 2; i++)
            {
                var tempDate = earliestDate.AddDays(i);
                var formattedDate = tempDate.ToString("M/dd/yy");
                dgvList.Columns[2 + i].HeaderText = formattedDate;
                if (tempDate.DayOfWeek == DayOfWeek.Saturday ||
                    tempDate.DayOfWeek == DayOfWeek.Sunday)
                    dgvList.Columns[2 + i].HeaderCell.Style = new DataGridViewCellStyle() { BackColor = Color.Gray };
                dateList.Add(formattedDate);
            }

            var sorted = _orders.OrderBy(x => x.AutolivPartNum).ThenBy(x => x.Destination).ThenBy(x => x.DueDate);
            var prevPn = "";
            var prevDest = "";
            var index = -1;

            foreach (var item in sorted)
            {
                if (item.AutolivPartNum != prevPn || item.Destination != prevDest)
                {
                    index = dgvList.Rows.Add(item.AutolivPartNum, item.Destination);
                    prevPn = item.AutolivPartNum;
                    prevDest = item.Destination;
                }

                try
                {
                    var idx = dateList.FindIndex(x => x.Equals(item.DueDate.ToString("M/dd/yy")));
                    if (idx > -1)
                        dgvList.Rows[index].Cells[2 + idx].Value = item.Quantity;
                }
                catch (Exception ex) { }
            }
            _backColor = Color.RoyalBlue;
        }

        private void dgvList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var cellStyle = dgvList.Rows[e.RowIndex].Cells[e.ColumnIndex].Style;
            cellStyle.BackColor = Color.RoyalBlue;
            dgvList.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = cellStyle;
        }

        private void dgvList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var cellStyle = dgvList.Rows[e.RowIndex].Cells[e.ColumnIndex].Style;
            cellStyle.BackColor = _backColor;
            dgvList.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = cellStyle;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Get the latest priority sheet
            var dirInfo = new DirectoryInfo(DefaultWorkbookPath);
            var latestPriSheet = (from f in dirInfo.GetFiles() orderby f.LastWriteTime descending select f).First();
            var xlApp = new Microsoft.Office.Interop.Excel.Application();

            xlApp.Workbooks.Open(latestPriSheet.DirectoryName + "\\" + latestPriSheet.Name);
            Worksheet sheet = xlApp.ActiveWorkbook.Sheets["Sheet1"];

            // get the dates from the header line
            var range = sheet.Range[sheet.Cells[6, 1], sheet.Cells[sheet.UsedRange.Rows.Count, 20]];
            var orderDates = new List<DateTime>();
            var dateRow = sheet.Rows[5];
            for (var j = 5; j < 15; j++)
            {
                orderDates.Add(dateRow.Cells[1, j].Value);
            }

            //get the list of orders
            var priSheetOrders = new List<Order>();
            try
            {


                foreach (Range row in range.Rows)
                {
                    if (row.Cells[1, 2].Value2 == null || row.Cells[1, 2].Value.ToString().Length != 10)
                        continue;
                    for (var j = 0; j <= 10; j++)
                    {
                        if (row.Cells[1, 5 + j].Value2 == null)
                            continue;
                        var order = new Order()
                        {
                            AutolivPartNum = row.Cells[1, 2].Value.ToString(),
                            Destination = row.Cells[1, 3].Value.ToString(),
                            DueDate = orderDates[j],
                            Quantity = Convert.ToInt32(row.Cells[1, 5 + j].Value)
                        };
                        priSheetOrders.Add(order);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception caught: " + ex.Message);
            }
            xlApp.Workbooks.Close();

            //compare list of orders with current list
            if (orderDates[0] < earliestDate)
                earliestDate = orderDates[0];
            if (_orders.Count == 0)
                _orders = priSheetOrders;
            else
                UpdateOrders(priSheetOrders, orderDates[0]);
            UpdateList();
        }

        private void UpdateOrders(ICollection<Order> newOrders, DateTime earliestDate, bool pruneOldOrders = false)
        {

            // modify existing orders with new quantity
            foreach (var newOrd in newOrders)
            {
                foreach (var t in _orders)
                {
                    if (t.AutolivPartNum != newOrd.AutolivPartNum || t.Destination != newOrd.Destination || t.DueDate != newOrd.DueDate)
                        continue;
                    t.Quantity = newOrd.Quantity;
                    break;
                }
            }

            // remove duplicate orders in new Orders list
            // if flag is set, delete old orders (before today's date)
            foreach (var ord in _orders)
            {
                if (pruneOldOrders && ord.DueDate.Date < earliestDate.Date)
                    _orders.Remove(ord);
                if (newOrders.Contains(ord))
                    newOrders.Remove(ord);
            }

            // add new orders to the list
            _orders.AddRange(newOrders);
            _orders = _orders.OrderBy(x => x.AutolivPartNum).ThenBy(x => x.Destination).ThenBy(x => x.DueDate).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var sw = new StreamWriter(OrderListName);
            foreach (var ord in _orders)
            {
                sw.WriteLine($"{ord.AutolivPartNum},{ord.Destination},{ord.DueDate},{ord.Quantity},{ord.CustomerPartNum}");
            }
            sw.Close();
            MessageBox.Show("Updates Saved to File");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadOrdersFromFile();
            UpdateList();
        }
    }
}
