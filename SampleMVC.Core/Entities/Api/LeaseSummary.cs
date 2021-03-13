using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMVC.Core.Entities.Api
{
    public class LeaseSummary
    {
        public string occupancy { get; set; }
        public object leasingStatus { get; set; }
        public object marketedRent { get; set; }
        public string paymentStatus { get; set; }
        public DateTime leaseStartDate { get; set; }
        public DateTime leaseEndDate { get; set; }
        public int monthlyRent { get; set; }
        public int securityDepositAmount { get; set; }
        public object hasPet { get; set; }
        public object petFeeAmount { get; set; }
        public bool isPetsDeposit { get; set; }
        public int? petsDepositAmount { get; set; }
        public object isLeaseConcessions { get; set; }
        public bool isRentersInsuranceRequired { get; set; }
        public bool isSection8 { get; set; }
        public bool isTenantBackgroundChecked { get; set; }
        public bool isTenantIncomeAbove3x { get; set; }
        public object isTenantMayTerminateEarly { get; set; }
        public object isTenantPurchaseOption { get; set; }
    }
}
