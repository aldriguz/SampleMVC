namespace SampleMVC.Infraestructure.Models.Api
{
    public class ApiLease
    {
        public ApiLeaseSummary leaseSummary { get; set; }
        public ApiUtilitiesOwnership utilitiesOwnership { get; set; }
        public ApiApplianceOwnership applianceOwnership { get; set; }
    }
}
