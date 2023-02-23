using System;
using System.Collections.Generic;

namespace caseStudy.Models
{
    public partial class Bond
    {
        public int BondId { get; set; }
        public string? SecurityDescription { get; set; }
        public string SecurityName { get; set; } = null!;
        public string? AssetType { get; set; }
        public string? InvestmentType { get; set; }
        public double? TradingFactor { get; set; }
        public double? PricingFactor { get; set; }
        public string? Isin { get; set; }
        public string? BbgTicker { get; set; }
        public string? BbgUniqueId { get; set; }
        public string? Cusip { get; set; }
        public string? Sedol { get; set; }
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
        public double? MacaulayDuration { get; set; }
        public double? Volatility30days { get; set; }
        public double? Volatility90days { get; set; }
        public double? Convexity { get; set; }
        public double? AvgVolume30days { get; set; }
        public string? PfAssetClass { get; set; }
        public string? PfCountry { get; set; }
        public string? PfCreditRating { get; set; }
        public string? PfCurrency { get; set; }
        public string? PfInstrument { get; set; }
        public string? PfLiquidityProfile { get; set; }
        public string? PfMaturity { get; set; }
        public string? PfNaicsCode { get; set; }
        public string? PfRegion { get; set; }
        public string? PfSector { get; set; }
        public string? PfSubAssetClass { get; set; }
        public string? BbgIndustryGroup { get; set; }
        public string? BbgIndustrySubGroup { get; set; }
        public string? BbgIndustrySector { get; set; }
        public string? IssueCountry { get; set; }
        public string? IssueCurrency { get; set; }
        public string? Issuer { get; set; }
        public string? RiskCurrency { get; set; }
        public double? PutDate { get; set; }
        public double? PutPrice { get; set; }
        public double? AskPrice { get; set; }
        public double? HighPrice { get; set; }
        public double? LowPrice { get; set; }
        public double? OpenPrice { get; set; }
        public double? Volume { get; set; }
        public double? BidPrice { get; set; }
        public double? LastPrice { get; set; }
        public string? CallDate { get; set; }
        public double? CallPrice { get; set; }
    }
}
