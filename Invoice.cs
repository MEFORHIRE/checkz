using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckCasher
{
    public class Invoice
    {
        public Invoice()
        {
            lines = new List<LineItem>();
            cust = new Customer();
            scust = new Customer();
            
        }
        public double total { get; set; }
        public double paid { get; set; }
        public List<LineItem> lines { get; set; }
        public int id { get; set; }
        public Customer cust { get; set; }
        public Customer scust { get; set; }
        public Customer biller { get; set; }
    }
}