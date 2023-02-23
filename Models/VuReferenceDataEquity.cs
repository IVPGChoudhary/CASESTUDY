using System;
using System.Collections.Generic;

namespace caseStudy.Models
{
    public partial class VuReferenceDataEquity
    {
        public string? CountryOfIssuance { get; set; }
        public string? Exchange { get; set; }
        public string? Issuer { get; set; }
        public string? IssueCurrency { get; set; }
        public string? TradingCurrency { get; set; }
        public string? BbgIndustrySubGroup { get; set; }
        public string? BloombergIndustryGroup { get; set; }
        public string? BloombergSector { get; set; }
        public string? RiskCurrency { get; set; }
    }
}
