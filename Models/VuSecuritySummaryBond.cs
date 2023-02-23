using System;
using System.Collections.Generic;

namespace caseStudy.Models
{
    public partial class VuSecuritySummaryBond
    {
        public string? SecurityDescription { get; set; }
        public string SecurityName { get; set; } = null!;
        public string? AssetType { get; set; }
        public string? InvestmentType { get; set; }
        public double? TradingFactor { get; set; }
        public double? PricingFactor { get; set; }
    }
}
