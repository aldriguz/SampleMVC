using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMVC.Core.Entities.Api
{
    public class Physical
    {
        public int? bathRooms { get; set; }
        public int? bedRooms { get; set; }
        public string parcelNumber { get; set; }
        public bool? isPool { get; set; }
        public int? lotSize { get; set; }
        public int? squareFeet { get; set; }
        public object stories { get; set; }
        public object units { get; set; }
        public int? yearBuilt { get; set; }
        public object zipYearBuilt { get; set; }
    }
}
