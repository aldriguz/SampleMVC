using System;

namespace SampleMVC.WebApp.Dtos
{
    [Serializable]
    public class PropertyDto
    {
        public string Address { get; set; }
        public string YearBuilt { get; set; }
        public double? ListPrice { get; set; }
        public double? MonthlyRent { get; set; }
        public double? GrossYield { get; set; }
    }
}
