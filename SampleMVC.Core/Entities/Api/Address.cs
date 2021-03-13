using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMVC.Core.Entities.Api
{
    public class Address
    {
        public string address1 { get; set; }
        public object address2 { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string county { get; set; }
        public object district { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string zipPlus4 { get; set; }
    }
}
