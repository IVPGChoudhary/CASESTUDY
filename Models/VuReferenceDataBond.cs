using System;
using System.Collections.Generic;

namespace caseStudy.Models
{
    public partial class VuReferenceDataBond
    {
        public string? BbgIndustryGroup { get; set; }
        public string? BbgIndustrySubGroup { get; set; }
        public string? BbgIndustrySector { get; set; }
        public string? IssueCountry { get; set; }
        public string? IssueCurrency { get; set; }
        public string? Issuer { get; set; }
        public string? RiskCurrency { get; set; }
    }
}
