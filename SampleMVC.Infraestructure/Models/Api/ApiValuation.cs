using System;

namespace SampleMVC.Infraestructure.Models.Api
{
    public class ApiValuation
    {
        public double? avmBpoValue { get; set; }
        public double? avmBpoAdjValue { get; set; }
        public DateTime? avmBpoDate { get; set; }
        public double? rsAvmValue { get; set; }
        public DateTime? rsAvmDate { get; set; }
        public double? rsBpoMergeValue { get; set; }
    }
}
