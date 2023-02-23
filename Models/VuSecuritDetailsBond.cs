using System;
using System.Collections.Generic;

namespace caseStudy.Models
{
    public partial class VuSecuritDetailsBond
    {
        public string? FirstCouponDate { get; set; }
        public string? CouponCap { get; set; }
        public string? CouponFloor { get; set; }
        public double? CouponFrequency { get; set; }
        public double? CouponRate { get; set; }
        public string? CouponType { get; set; }
        public string? FloatSpread { get; set; }
        public string? IsCallable { get; set; }
        public string? IsFixToFloat { get; set; }
        public string? IsPutable { get; set; }
        public string? IssueDate { get; set; }
        public string? LastResetDate { get; set; }
        public string? Maturity { get; set; }
        public double? MaxCallNoticeDays { get; set; }
        public double? MaxPutNoticeDays { get; set; }
        public string? PenultimateCouponDate { get; set; }
        public string? ResetFrequency { get; set; }
        public string? HasPosition { get; set; }
    }
}
