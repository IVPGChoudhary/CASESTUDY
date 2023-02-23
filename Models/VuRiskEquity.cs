using System;
using System.Collections.Generic;

namespace caseStudy.Models
{
    public partial class VuRiskEquity
    {
        public double? AverageVolume20d { get; set; }
        public double? Beta { get; set; }
        public double? ShortInterest { get; set; }
        public double? ReturnYtd { get; set; }
        public double? Volatility90d { get; set; }
    }
}
