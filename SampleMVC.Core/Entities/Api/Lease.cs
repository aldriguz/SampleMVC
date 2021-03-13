using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMVC.Core.Entities.Api
{
    public class Lease
    {
        public LeaseSummary leaseSummary { get; set; }
        public UtilitiesOwnership utilitiesOwnership { get; set; }
        public ApplianceOwnership applianceOwnership { get; set; }
    }
}
