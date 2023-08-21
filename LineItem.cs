using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckCasher
{
    public class LineItem
    {
        
        public  string item { get; set; }
        public string item_code { get; set; }        
        public double qty { get; set; }
        public double unitqty { get; set; }        
        public double pricesell{ get; set; }  
    
        public double amount { get; set; }
    }
}