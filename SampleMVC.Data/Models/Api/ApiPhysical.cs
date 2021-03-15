namespace SampleMVC.Infraestructure.Models.Api
{
    public class ApiPhysical
    {
        public double? bathRooms { get; set; }
        public double? bedRooms { get; set; }
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
