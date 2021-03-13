using SmapleMVC.SharedKernel.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMVC.Core.Entities
{
    public class PropertyList : BaseEntity
    {
        public List<Property> properties { get; set; }
    }
}
