using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMVC.Core.Entities.Api
{
    public class Score
    {
        public object conditionScore { get; set; }
        public string crimeScore { get; set; }
        public int? neighborhoodScore { get; set; }
        public object overallScore { get; set; }
        public object qualityScore { get; set; }
        public string schoolScore { get; set; }
        public string charterSchoolScore { get; set; }
        public object floodRiskScore { get; set; }
        public object walkabilityScore { get; set; }
    }
}
