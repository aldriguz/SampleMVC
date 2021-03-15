using System.Collections.Generic;

namespace SampleMVC.Infraestructure.Models.Api
{
    public class ApiResources
    {
        public List<ApiPhoto> photos { get; set; }
        public List<ApiFloorPlan> floorPlans { get; set; }
        public List<ApiThreeDRendering> threeDRenderings { get; set; }
        public List<object> audios { get; set; }
    }
}
