﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMVC.Core.Entities.Api
{
    public class ThreeDRendering
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
        public object urlMedium { get; set; }
        public object urlSmall { get; set; }
        public object textContent { get; set; }
    }
}
