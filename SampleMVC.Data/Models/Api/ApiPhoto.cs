namespace SampleMVC.Infraestructure.Models.Api
{
    public class ApiPhoto
    {
        public int id { get; set; }
        public string guid { get; set; }
        public string resourceType { get; set; }
        public bool isPublic { get; set; }
        public object description { get; set; }
        public string filename { get; set; }
        public object sizeInByte { get; set; }
        public string contentType { get; set; }
        public string url { get; set; }
        public string urlMedium { get; set; }
        public string urlSmall { get; set; }
        public object textContent { get; set; }
    }
}
