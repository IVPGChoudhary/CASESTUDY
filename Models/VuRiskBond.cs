using System;
using System.Collections.Generic;

namespace caseStudy.Models
{
    public partial class VuRiskBond
    {
        public double? MacaulayDuration { get; set; }
        public double? Volatility30days { get; set; }
        public double? Volatility90days { get; set; }
        public double? Convexity { get; set; }
        public double? AvgVolume30days { get; set; }
    }
}
