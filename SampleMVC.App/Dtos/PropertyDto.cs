using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleMVC.App.Dtos
{
    public class PropertyDto
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string YearBuilt { get; set; }
        public decimal ListPrice { get; set; }
        public decimal MonthlyRent { get; set; }
        public decimal GrossYield { get; set; }
    }
}