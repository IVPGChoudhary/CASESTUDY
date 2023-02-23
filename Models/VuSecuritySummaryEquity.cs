using System;
using System.Collections.Generic;

namespace caseStudy.Models
{
    public partial class VuSecuritySummaryEquity
    {
        public string? SecurityDescription { get; set; }
        public string SecurityName { get; set; } = null!;
        public string? HasPosition { get; set; }
        public string? IsActiveSecurity { get; set; }
        public double? LotSize { get; set; }
        public string? BbgUniqueName { get; set; }
    }
}
