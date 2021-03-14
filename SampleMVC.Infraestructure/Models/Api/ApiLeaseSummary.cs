using System;

namespace SampleMVC.Infraestructure.Models.Api
{
    public class ApiLeaseSummary
    {
        public string occupancy { get; set; }
        public object leasingStatus { get; set; }
        public object marketedRent { get; set; }
        public string paymentStatus { get; set; }
        public DateTime? leaseStartDate { get; set; }
        public DateTime? leaseEndDate { get; set; }
        public double monthlyRent { get; set; }
        public double? securityDepositAmount { get; set; }
        public object hasPet { get; set; }
        public object petFeeAmount { get; set; }
        public bool isPetsDeposit { get; set; }
        public double? petsDepositAmount { get; set; }
        public object isLeaseConcessions { get; set; }
        public bool isRentersInsuranceRequired { get; set; }
        public bool isSection8 { get; set; }
        public bool isTenantBackgroundChecked { get; set; }
        public bool isTenantIncomeAbove3x { get; set; }
        public object isTenantMayTerminateEarly { get; set; }
        public object isTenantPurchaseOption { get; set; }
    }
}
