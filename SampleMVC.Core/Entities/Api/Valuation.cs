using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMVC.Core.Entities.Api
{
    public class Valuation
    {
        public object avmBpoValue { get; set; }
        public object avmBpoAdjValue { get; set; }
        public object avmBpoDate { get; set; }
        public int? rsAvmValue { get; set; }
        public object rsAvmDate { get; set; }
        public int? rsBpoMergeValue { get; set; }
    }
}
