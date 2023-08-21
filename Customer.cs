using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckCasher
{
    public class Customer
    {
        
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string phone { get; set; }
        

        
        public override string ToString()
        {
            string str = name + "\r\n";
            str = str + address + "\r\n";
            str = str + city + "\r\n";
            str = str + state + "\r\n";
            str = str + phone + "\r\n";
            return str;
        }
        
    }
}
