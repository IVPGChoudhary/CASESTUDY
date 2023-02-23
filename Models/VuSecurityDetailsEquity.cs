using System;
using System.Collections.Generic;

namespace caseStudy.Models
{
    public partial class VuSecurityDetailsEquity
    {
        public string? IsAdrFlag { get; set; }
        public string? AdrUnderlyingTicker { get; set; }
        public string? SharesPerAdr { get; set; }
        public string? IpoDate { get; set; }
        public string? PricingCurrency { get; set; }
        public int? SettleDays { get; set; }
        public double? TotalSharesOutstanding { get; set; }
        public double? VotingRightsPerShare { get; set; }
    }
}
