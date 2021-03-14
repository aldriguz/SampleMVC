using SmapleMVC.SharedKernel.Enities;

namespace SampleMVC.Core.Entities
{
    public class Property : BaseEntity
    {
        public string Address { get; set; }
        public string YearBuilt { get; set; }
        public decimal ListPrice { get; set; }
        public decimal MonthlyRent { get; set; }
        public decimal GrossYield { get; set; }
    }
}
