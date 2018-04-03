using System;

namespace Scheduler
{
    class Order
    {
        public string AutolivPartNum { get; set; }
        public string CustomerPartNum { get; set; }
        public string Destination { get; set; }
        public DateTime DueDate { get; set; }
        public int Quantity { get; set; }

    }
}
