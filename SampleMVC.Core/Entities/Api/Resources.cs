using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMVC.Core.Entities.Api
{
    public class Resources
    {
        public List<Photo> photos { get; set; }
        public List<FloorPlan> floorPlans { get; set; }
        public List<ThreeDRendering> threeDRenderings { get; set; }
        public List<object> audios { get; set; }
    }
}
