using System;
using System.Collections.Generic;

namespace caseStudy.Models
{
    public partial class VuSecurityIdentifierBond
    {
        public string? Isin { get; set; }
        public string? BbgTicker { get; set; }
        public string? BbgUniqueId { get; set; }
        public string? Cusip { get; set; }
        public string? Sedol { get; set; }
    }
}
