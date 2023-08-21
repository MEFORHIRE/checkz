using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckCasher
{
    class Txn
    {
        
        public  string item { get; set; }
        public string item_code { get; set; }
        public string vendor { get; set; }
        public string barcode { get; set; }       
        public double qty { get; set; }
        public double pricebuy { get; set; }
        public double pricesell { get; set; }
        public string unit { get; set; }
        public double unitval { get; set; }
    }
}