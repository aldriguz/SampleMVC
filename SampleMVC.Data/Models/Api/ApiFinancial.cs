using System;

namespace SampleMVC.Infraestructure.Models.Api
{    
    public class ApiFinancial
    {
        private const int monthsNumber = 12;

        public object capRate { get; set; }
        public string occupancy { get; set; }
        public bool? isSection8 { get; set; }
        public DateTime? leaseStartDate { get; set; }
        public DateTime? leaseEndDate { get; set; }
        public double? listPrice { get; set; }
        public double? salePrice { get; set; }
        public object marketValue { get; set; }
        public object monthlyHoa { get; set; }
        public object monthlyManagementFees { get; set; }
        public double? monthlyRent { get; set; }
        public double? netYield { get; set; }
        public double? turnOverFee { get; set; }
        public double? rehabCosts { get; set; }
        public DateTime? rehabDate { get; set; }
        public double? yearlyInsuranceCost { get; set; }
        public double? yearlyPropertyTaxes { get; set; }
        public bool? isCashOnly { get; set; }

        public double GetGrossYield()
        {
            return (monthlyRent ?? 0 * monthsNumber) / listPrice ?? 1;
        }
    }

    
}
