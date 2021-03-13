using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMVC.Core.Entities.Api
{
    public class GoogleMapOption
    {
        public bool hasStreetView { get; set; }
        public int povHeading { get; set; }
        public int povPitch { get; set; }
        public double povLatitude { get; set; }
        public double povLongitude { get; set; }
    }
}
