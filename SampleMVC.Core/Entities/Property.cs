using SmapleMVC.Core.Enities;

namespace SampleMVC.Core.Entities
{    
    public class Property : BaseEntity
    {
        //new public int? Id { get; set; }
        public string Address { get; set; }
        public string YearBuilt { get; set; }
        public double? ListPrice { get; set; }
        public double? MonthlyRent { get; set; }
        public double? GrossYield { get; set; }
    }
}
