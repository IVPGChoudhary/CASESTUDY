﻿using System;
using System.Collections.Generic;

namespace caseStudy.Models
{
    public partial class AuditBond
    {
        public string? Username { get; set; }
        public string? Xndate { get; set; }
        public string? XnAction { get; set; }
        public int? BondId { get; set; }
        public string? OldSecurityDescription { get; set; }
        public string? NewSecurityDescription { get; set; }
        public string? OldSecurityName { get; set; }
        public string? NewSecurityName { get; set; }
        public string? OldAssetType { get; set; }
        public string? NewAssetType { get; set; }
        public string? OldInvestmentType { get; set; }
        public string? NewInvestmentType { get; set; }
        public double? OldTradingFactor { get; set; }
        public double? NewTradingFactor { get; set; }
        public double? OldPricingFactor { get; set; }
        public double? NewPricingFactor { get; set; }
        public string? OldIsin { get; set; }
        public string? NewIsin { get; set; }
        public string? OldBbgTicker { get; set; }
        public string? NewBbgTicker { get; set; }
        public string? OldBbgUniqueId { get; set; }
        public string? NewBbgUniqueId { get; set; }
        public string? OldCusip { get; set; }
        public string? NewCusip { get; set; }
        public string? OldSedol { get; set; }
        public string? NewSedol { get; set; }
        public string? OldFirstCouponDate { get; set; }
        public string? NewFirstCouponDate { get; set; }
        public string? OldCouponCap { get; set; }
        public string? NewCouponCap { get; set; }
        public string? OldCouponFloor { get; set; }
        public string? NewCouponFloor { get; set; }
        public double? OldCouponFrqeuency { get; set; }
        public double? NewCouponFrqeuency { get; set; }
        public double? OldCouponRate { get; set; }
        public double? NewCouponRate { get; set; }
        public string? OldCouponType { get; set; }
        public string? NewCouponType { get; set; }
        public string? OldFloatSpread { get; set; }
        public string? NewFloatSpread { get; set; }
        public string? OldIsCallable { get; set; }
        public string? NewIsCallable { get; set; }
        public string? OldIsFixToFloat { get; set; }
        public string? NewIsFixToFloat { get; set; }
        public string? OldIsPutable { get; set; }
        public string? NewIsPutable { get; set; }
        public string? OldIssueDate { get; set; }
        public string? NewIssueDate { get; set; }
        public string? OldLastResetDate { get; set; }
        public string? NewLastResetDate { get; set; }
        public string? OldMaturity { get; set; }
        public string? NewMaturity { get; set; }
        public double? OldMaxCallNoticeDays { get; set; }
        public double? NewMaxCallNoticeDays { get; set; }
        public double? OldMaxPutNoticeDays { get; set; }
        public double? NewMaxPutNoticeDays { get; set; }
        public string? OldPenultimateCouponDate { get; set; }
        public string? NewPenultimateCouponDate { get; set; }
        public string? OldResetFrequency { get; set; }
        public string? NewResetFrequency { get; set; }
        public string? OldHasPosition { get; set; }
        public string? NewHasPosition { get; set; }
        public double? OldMacaulayDuration { get; set; }
        public double? NewMacaulayDuration { get; set; }
        public double? OldVolatility30days { get; set; }
        public double? NewVolatility30days { get; set; }
        public double? OldVolatility90days { get; set; }
        public double? NewVolatility90days { get; set; }
        public double? OldConvexity { get; set; }
        public double? NewConvexity { get; set; }
        public double? OldAvgVolume30days { get; set; }
        public double? NewAvgVolume30days { get; set; }
        public string? OldPfAssetClass { get; set; }
        public string? NewPfAssetClass { get; set; }
        public string? OldPfCountry { get; set; }
        public string? NewPfCountry { get; set; }
        public string? OldPfCreditRating { get; set; }
        public string? NewPfCreditRating { get; set; }
        public string? OldPfCurrency { get; set; }
        public string? NewPfCurrency { get; set; }
        public string? OldPfInstrument { get; set; }
        public string? NewPfInstrument { get; set; }
        public string? OldPfLiquidityProfile { get; set; }
        public string? NewPfLiquidityProfile { get; set; }
        public string? OldPfMaturity { get; set; }
        public string? NewPfMaturity { get; set; }
        public string? OldPfNaicsCode { get; set; }
        public string? NewPfNaicsCode { get; set; }
        public string? OldPfRegion { get; set; }
        public string? NewPfRegion { get; set; }
        public string? OldPfSector { get; set; }
        public string? NewPfSector { get; set; }
        public string? OldPfSubAssetClass { get; set; }
        public string? NewPfSubAssetClass { get; set; }
        public string? OldBbgIndustryGroup { get; set; }
        public string? NewBbgIndustryGroup { get; set; }
        public string? OldBbgIndustrySubGroup { get; set; }
        public string? NewBbgIndustrySubGroup { get; set; }
        public string? OldBbgIndustrySector { get; set; }
        public string? NewBbgIndustrySector { get; set; }
        public string? OldIssueCountry { get; set; }
        public string? NewIssueCountry { get; set; }
        public string? OldIssueCurrency { get; set; }
        public string? NewIssueCurrency { get; set; }
        public string? OldIssuer { get; set; }
        public string? NewIssuer { get; set; }
        public string? OldRiskCurrency { get; set; }
        public string? NewRiskCurrency { get; set; }
        public string? OldPutDate { get; set; }
        public string? NewPutDate { get; set; }
        public double? OldPutPrice { get; set; }
        public double? NewPutPrice { get; set; }
        public double? OldAskPrice { get; set; }
        public double? NewAskPrice { get; set; }
        public double? OldHighPrice { get; set; }
        public double? NewHighPrice { get; set; }
        public double? OldLowPrice { get; set; }
        public double? NewLowPrice { get; set; }
        public double? OldOpenPrice { get; set; }
        public double? NewOpenPrice { get; set; }
        public double? OldVolume { get; set; }
        public double? NewVolume { get; set; }
        public double? OldBidPrice { get; set; }
        public double? NewBidPrice { get; set; }
        public double? OldLastPrice { get; set; }
        public double? NewLastPrice { get; set; }
        public string? OldCallDate { get; set; }
        public string? NewCallDate { get; set; }
        public double? OldCallPrice { get; set; }
        public double? NewCallPrice { get; set; }
    }
}