namespace Scheduler
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnGetCurr = new System.Windows.Forms.Button();
            this.AutolivPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AutolivPN,
            this.Destination,
            this.Date1,
            this.Date2,
            this.Date3,
            this.Date4,
            this.Date5,
            this.Date6,
            this.Date7,
            this.Date8,
            this.Date9,
            this.Date10,
            this.Date11,
            this.Date12,
            this.Date13,
            this.Date14});
            this.dgvList.Location = new System.Drawing.Point(12, 59);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.Size = new System.Drawing.Size(1208, 423);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellValueChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(12, 523);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(244, 29);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update from Priority Sheet";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(785, 523);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 29);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(891, 523);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.Location = new System.Drawing.Point(1052, 523);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(168, 29);
            this.btnSchedule.TabIndex = 1;
            this.btnSchedule.Text = "Schedule Back End";
            this.btnSchedule.UseVisualStyleBackColor = true;
            // 
            // btnGetCurr
            // 
            this.btnGetCurr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGetCurr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetCurr.Location = new System.Drawing.Point(12, 488);
            this.btnGetCurr.Name = "btnGetCurr";
            this.btnGetCurr.Size = new System.Drawing.Size(244, 29);
            this.btnGetCurr.TabIndex = 1;
            this.btnGetCurr.Text = "Get Current Orders";
            this.btnGetCurr.UseVisualStyleBackColor = true;
            this.btnGetCurr.Click += new System.EventHandler(this.btnGetCurr_Click);
            // 
            // AutolivPN
            // 
            this.AutolivPN.HeaderText = "Autoliv PN";
            this.AutolivPN.Name = "AutolivPN";
            this.AutolivPN.ReadOnly = true;
            // 
            // Destination
            // 
            this.Destination.HeaderText = "Destination";
            this.Destination.Name = "Destination";
            this.Destination.ReadOnly = true;
            // 
            // Date1
            // 
            this.Date1.HeaderText = "Date1";
            this.Date1.Name = "Date1";
            this.Date1.Width = 75;
            // 
            // Date2
            // 
            this.Date2.HeaderText = "Date2";
            this.Date2.Name = "Date2";
            this.Date2.Width = 75;
            // 
            // Date3
            // 
            this.Date3.HeaderText = "Date3";
            this.Date3.Name = "Date3";
            this.Date3.Width = 75;
            // 
            // Date4
            // 
            this.Date4.HeaderText = "Date4";
            this.Date4.Name = "Date4";
            this.Date4.Width = 75;
            // 
            // Date5
            // 
            this.Date5.HeaderText = "Date5";
            this.Date5.Name = "Date5";
            this.Date5.Width = 75;
            // 
            // Date6
            // 
            this.Date6.HeaderText = "Date6";
            this.Date6.Name = "Date6";
            this.Date6.Width = 75;
            // 
            // Date7
            // 
            this.Date7.HeaderText = "Date7";
            this.Date7.Name = "Date7";
            this.Date7.Width = 75;
            // 
            // Date8
            // 
            this.Date8.HeaderText = "Date8";
            this.Date8.Name = "Date8";
            this.Date8.Width = 75;
            // 
            // Date9
            // 
            this.Date9.HeaderText = "Date9";
            this.Date9.Name = "Date9";
            this.Date9.Width = 75;
            // 
            // Date10
            // 
            this.Date10.HeaderText = "Date10";
            this.Date10.Name = "Date10";
            this.Date10.Width = 75;
            // 
            // Date11
            // 
            this.Date11.HeaderText = "Date11";
            this.Date11.Name = "Date11";
            this.Date11.Width = 75;
            // 
            // Date12
            // 
            this.Date12.HeaderText = "Date12";
            this.Date12.Name = "Date12";
            this.Date12.Width = 75;
            // 
            // Date13
            // 
            this.Date13.HeaderText = "Date13";
            this.Date13.Name = "Date13";
            this.Date13.Width = 75;
            // 
            // Date14
            // 
            this.Date14.HeaderText = "Date14";
            this.Date14.Name = "Date14";
            this.Date14.Width = 75;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 589);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnGetCurr);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvList);
            this.Name = "Form1";
            this.Text = "Orders Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnGetCurr;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutolivPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date14;
    }
}

