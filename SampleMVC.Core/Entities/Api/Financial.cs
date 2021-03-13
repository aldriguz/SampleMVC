using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMVC.Core.Entities.Api
{
    public class Financial
    {
        public object capRate { get; set; }
        public string occupancy { get; set; }
        public bool? isSection8 { get; set; }
        public DateTime? leaseStartDate { get; set; }
        public DateTime? leaseEndDate { get; set; }
        public int? listPrice { get; set; }
        public object salePrice { get; set; }
        public object marketValue { get; set; }
        public object monthlyHoa { get; set; }
        public object monthlyManagementFees { get; set; }
        public int? monthlyRent { get; set; }
        public object netYield { get; set; }
        public object turnOverFee { get; set; }
        public object rehabCosts { get; set; }
        public object rehabDate { get; set; }
        public int? yearlyInsuranceCost { get; set; }
        public int? yearlyPropertyTaxes { get; set; }
        public bool? isCashOnly { get; set; }
    }
}
