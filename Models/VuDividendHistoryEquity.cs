using System;
using System.Collections.Generic;

namespace caseStudy.Models
{
    public partial class VuDividendHistoryEquity
    {
        public string? DividendDeclaredDate { get; set; }
        public string? DividendExDate { get; set; }
        public string? DividendRecordDate { get; set; }
        public string? DividendPayDate { get; set; }
        public double? DividendAmount { get; set; }
        public string? Frequency { get; set; }
        public string? DividendType { get; set; }
    }
}
