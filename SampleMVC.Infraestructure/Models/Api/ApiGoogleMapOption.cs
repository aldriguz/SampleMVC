namespace SampleMVC.Infraestructure.Models.Api
{
    public class ApiGoogleMapOption
    {
        public bool hasStreetView { get; set; }
        public int? povHeading { get; set; }
        public int? povPitch { get; set; }
        public double? povLatitude { get; set; }
        public double? povLongitude { get; set; }
    }
}
