using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_test.api.Models
{
    public class CustomerViewModel
    {
        public Double? id { get; set; }
        public String firstname { get; set; }
        public String lastname { get; set; }
        public String email { get; set; }
        public DateTime birth { get; set; }
        public String address { get; set; }
        public String country { get; set; }
        public double phone { get; set; }
        public bool saveinfo { get; set; }
        public String typepayment { get; set; }
        public String cardname { get; set; }
        public double cardnumber { get; set; }
    }
}
