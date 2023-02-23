using System;
using System.Collections.Generic;

namespace caseStudy.Models
{
    public partial class VuSecurityIdentifierEquity
    {
        public string? Cusip { get; set; }
        public string? Isin { get; set; }
        public string? Sedol { get; set; }
        public string? BloombergTicker { get; set; }
        public string? BloombergUniqueId { get; set; }
        public string? BbgGlobalId { get; set; }
        public string? TickerAndExchange { get; set; }
    }
}
