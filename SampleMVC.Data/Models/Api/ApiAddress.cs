namespace SampleMVC.Infraestructure.Models.Api
{
    public class ApiAddress
    {
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string county { get; set; }
        public string district { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string zipPlus4 { get; set; }

        public override string ToString()
        {
            return $"{address1} {address2}, {city}, {zip}  {country} ";
        }
    }
}
