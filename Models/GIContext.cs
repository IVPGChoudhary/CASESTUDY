using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace caseStudy.Models
{
    public partial class GIContext : DbContext
    {
        public GIContext()
        {
        }

        public GIContext(DbContextOptions<GIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AuditBond> AuditBonds { get; set; } = null!;
        public virtual DbSet<AuditEquity> AuditEquities { get; set; } = null!;
        public virtual DbSet<Bond> Bonds { get; set; } = null!;
        public virtual DbSet<Equity> Equities { get; set; } = null!;
        public virtual DbSet<VuCallScheduleBond> VuCallScheduleBonds { get; set; } = null!;
        public virtual DbSet<VuDividendHistoryEquity> VuDividendHistoryEquities { get; set; } = null!;
        public virtual DbSet<VuPricingDetailsEquity> VuPricingDetailsEquities { get; set; } = null!;
        public virtual DbSet<VuPricingandAnalyticsBond> VuPricingandAnalyticsBonds { get; set; } = null!;
        public virtual DbSet<VuPutScheduleBond> VuPutScheduleBonds { get; set; } = null!;
        public virtual DbSet<VuReferenceDataBond> VuReferenceDataBonds { get; set; } = null!;
        public virtual DbSet<VuReferenceDataEquity> VuReferenceDataEquities { get; set; } = null!;
        public virtual DbSet<VuRegulatoryDetailsBond> VuRegulatoryDetailsBonds { get; set; } = null!;
        public virtual DbSet<VuRegulatoryDetailsEquity> VuRegulatoryDetailsEquities { get; set; } = null!;
        public virtual DbSet<VuRiskBond> VuRiskBonds { get; set; } = null!;
        public virtual DbSet<VuRiskEquity> VuRiskEquities { get; set; } = null!;
        public virtual DbSet<VuSecuritDetailsBond> VuSecuritDetailsBonds { get; set; } = null!;
        public virtual DbSet<VuSecurityDetailsEquity> VuSecurityDetailsEquities { get; set; } = null!;
        public virtual DbSet<VuSecurityIdentifierBond> VuSecurityIdentifierBonds { get; set; } = null!;
        public virtual DbSet<VuSecurityIdentifierEquity> VuSecurityIdentifierEquities { get; set; } = null!;
        public virtual DbSet<VuSecuritySummaryBond> VuSecuritySummaryBonds { get; set; } = null!;
        public virtual DbSet<VuSecuritySummaryEquity> VuSecuritySummaryEquities { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=192.168.0.13\\sqlexpress,58264; Database=GI;Trusted_Connection=True;User Id=sa;Password=sa@12345678;Integrated Security=false;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuditBond>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Audit_Bond");

                entity.Property(e => e.BondId).HasColumnName("Bond_id");

                entity.Property(e => e.NewAskPrice).HasColumnName("New_Ask_Price");

                entity.Property(e => e.NewAssetType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_Asset_type");

                entity.Property(e => e.NewAvgVolume30days).HasColumnName("New_AvgVolume_30days");

                entity.Property(e => e.NewBbgIndustryGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_BBG_Industry_Group");

                entity.Property(e => e.NewBbgIndustrySector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_BBG_Industry_Sector");

                entity.Property(e => e.NewBbgIndustrySubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_BBG_Industry_SubGroup");

                entity.Property(e => e.NewBbgTicker)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_BBG_Ticker");

                entity.Property(e => e.NewBbgUniqueId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_BBG_UniqueID");

                entity.Property(e => e.NewBidPrice).HasColumnName("New_Bid_Price");

                entity.Property(e => e.NewCallDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("New_CallDate");

                entity.Property(e => e.NewCallPrice).HasColumnName("New_CallPrice");

                entity.Property(e => e.NewConvexity).HasColumnName("New_Convexity");

                entity.Property(e => e.NewCouponCap)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_Coupon_Cap");

                entity.Property(e => e.NewCouponFloor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_Coupon_Floor");

                entity.Property(e => e.NewCouponFrqeuency).HasColumnName("New_Coupon_frqeuency");

                entity.Property(e => e.NewCouponRate).HasColumnName("New_Coupon_Rate");

                entity.Property(e => e.NewCouponType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_Coupon_Type");

                entity.Property(e => e.NewCusip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_CUSIP");

                entity.Property(e => e.NewFirstCouponDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("New_First_couponDate");

                entity.Property(e => e.NewFloatSpread)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_Float_Spread");

                entity.Property(e => e.NewHasPosition)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_Has_Position");

                entity.Property(e => e.NewHighPrice).HasColumnName("New_High_Price");

                entity.Property(e => e.NewInvestmentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_Investment_type");

                entity.Property(e => e.NewIsCallable)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_IS_Callable");

                entity.Property(e => e.NewIsFixToFloat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_IsFixToFloat");

                entity.Property(e => e.NewIsPutable)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_IsPutable");

                entity.Property(e => e.NewIsin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_ISIN");

                entity.Property(e => e.NewIssueCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_Issue_Country");

                entity.Property(e => e.NewIssueCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_Issue_Currency");

                entity.Property(e => e.NewIssueDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("New_IssueDate");

                entity.Property(e => e.NewIssuer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_Issuer");

                entity.Property(e => e.NewLastPrice).HasColumnName("New_Last_Price");

                entity.Property(e => e.NewLastResetDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("New_LastResetDate");

                entity.Property(e => e.NewLowPrice).HasColumnName("New_Low_Price");

                entity.Property(e => e.NewMacaulayDuration).HasColumnName("New_Macaulay_Duration");

                entity.Property(e => e.NewMaturity)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("New_Maturity");

                entity.Property(e => e.NewMaxCallNoticeDays).HasColumnName("New_MaxCallNoticeDays");

                entity.Property(e => e.NewMaxPutNoticeDays).HasColumnName("New_MaxPutNoticeDays");

                entity.Property(e => e.NewOpenPrice).HasColumnName("New_Open_Price");

                entity.Property(e => e.NewPenultimateCouponDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("New_Penultimate_CouponDate");

                entity.Property(e => e.NewPfAssetClass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_PF_AssetClass");

                entity.Property(e => e.NewPfCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_PF_Country");

                entity.Property(e => e.NewPfCreditRating)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_PF_CreditRating");

                entity.Property(e => e.NewPfCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_PF_Currency");

                entity.Property(e => e.NewPfInstrument)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_PF_Instrument");

                entity.Property(e => e.NewPfLiquidityProfile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_PF_LiquidityProfile");

                entity.Property(e => e.NewPfMaturity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_PF_Maturity");

                entity.Property(e => e.NewPfNaicsCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_PF_NAICS_Code");

                entity.Property(e => e.NewPfRegion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_PF_Region");

                entity.Property(e => e.NewPfSector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_PF_Sector");

                entity.Property(e => e.NewPfSubAssetClass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_PF_SubAssetClass");

                entity.Property(e => e.NewPricingFactor).HasColumnName("New_Pricing_factor");

                entity.Property(e => e.NewPutDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("New_Put_Date");

                entity.Property(e => e.NewPutPrice).HasColumnName("New_Put_Price");

                entity.Property(e => e.NewResetFrequency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_ResetFrequency");

                entity.Property(e => e.NewRiskCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_Risk_Currency");

                entity.Property(e => e.NewSecurityDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_Security_Description");

                entity.Property(e => e.NewSecurityName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_Security_Name");

                entity.Property(e => e.NewSedol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_SEDOL");

                entity.Property(e => e.NewTradingFactor).HasColumnName("New_Trading_factor");

                entity.Property(e => e.NewVolatility30days).HasColumnName("New_Volatility_30Days");

                entity.Property(e => e.NewVolatility90days).HasColumnName("New_Volatility_90Days");

                entity.Property(e => e.NewVolume).HasColumnName("New_Volume");

                entity.Property(e => e.OldAskPrice).HasColumnName("Old_Ask_Price");

                entity.Property(e => e.OldAssetType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_Asset_type");

                entity.Property(e => e.OldAvgVolume30days).HasColumnName("Old_AvgVolume_30days");

                entity.Property(e => e.OldBbgIndustryGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_BBG_Industry_Group");

                entity.Property(e => e.OldBbgIndustrySector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_BBG_Industry_Sector");

                entity.Property(e => e.OldBbgIndustrySubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_BBG_Industry_SubGroup");

                entity.Property(e => e.OldBbgTicker)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_BBG_Ticker");

                entity.Property(e => e.OldBbgUniqueId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_BBG_UniqueID");

                entity.Property(e => e.OldBidPrice).HasColumnName("Old_Bid_Price");

                entity.Property(e => e.OldCallDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Old_CallDate");

                entity.Property(e => e.OldCallPrice).HasColumnName("Old_CallPrice");

                entity.Property(e => e.OldConvexity).HasColumnName("Old_Convexity");

                entity.Property(e => e.OldCouponCap)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_Coupon_Cap");

                entity.Property(e => e.OldCouponFloor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_Coupon_Floor");

                entity.Property(e => e.OldCouponFrqeuency).HasColumnName("Old_Coupon_frqeuency");

                entity.Property(e => e.OldCouponRate).HasColumnName("Old_Coupon_Rate");

                entity.Property(e => e.OldCouponType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_Coupon_Type");

                entity.Property(e => e.OldCusip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_CUSIP");

                entity.Property(e => e.OldFirstCouponDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Old_First_couponDate");

                entity.Property(e => e.OldFloatSpread)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_Float_Spread");

                entity.Property(e => e.OldHasPosition)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_Has_Position");

                entity.Property(e => e.OldHighPrice).HasColumnName("Old_High_Price");

                entity.Property(e => e.OldInvestmentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_Investment_type");

                entity.Property(e => e.OldIsCallable)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_IS_Callable");

                entity.Property(e => e.OldIsFixToFloat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_IsFixToFloat");

                entity.Property(e => e.OldIsPutable)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_IsPutable");

                entity.Property(e => e.OldIsin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_ISIN");

                entity.Property(e => e.OldIssueCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_Issue_Country");

                entity.Property(e => e.OldIssueCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_Issue_Currency");

                entity.Property(e => e.OldIssueDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Old_IssueDate");

                entity.Property(e => e.OldIssuer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_Issuer");

                entity.Property(e => e.OldLastPrice).HasColumnName("Old_Last_Price");

                entity.Property(e => e.OldLastResetDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Old_LastResetDate");

                entity.Property(e => e.OldLowPrice).HasColumnName("Old_Low_Price");

                entity.Property(e => e.OldMacaulayDuration).HasColumnName("Old_Macaulay_Duration");

                entity.Property(e => e.OldMaturity)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Old_Maturity");

                entity.Property(e => e.OldMaxCallNoticeDays).HasColumnName("Old_MaxCallNoticeDays");

                entity.Property(e => e.OldMaxPutNoticeDays).HasColumnName("Old_MaxPutNoticeDays");

                entity.Property(e => e.OldOpenPrice).HasColumnName("Old_Open_Price");

                entity.Property(e => e.OldPenultimateCouponDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Old_Penultimate_CouponDate");

                entity.Property(e => e.OldPfAssetClass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_PF_AssetClass");

                entity.Property(e => e.OldPfCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_PF_Country");

                entity.Property(e => e.OldPfCreditRating)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_PF_CreditRating");

                entity.Property(e => e.OldPfCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_PF_Currency");

                entity.Property(e => e.OldPfInstrument)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_PF_Instrument");

                entity.Property(e => e.OldPfLiquidityProfile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_PF_LiquidityProfile");

                entity.Property(e => e.OldPfMaturity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_PF_Maturity");

                entity.Property(e => e.OldPfNaicsCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_PF_NAICS_Code");

                entity.Property(e => e.OldPfRegion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_PF_Region");

                entity.Property(e => e.OldPfSector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_PF_Sector");

                entity.Property(e => e.OldPfSubAssetClass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_PF_SubAssetClass");

                entity.Property(e => e.OldPricingFactor).HasColumnName("Old_Pricing_factor");

                entity.Property(e => e.OldPutDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Old_Put_Date");

                entity.Property(e => e.OldPutPrice).HasColumnName("Old_Put_Price");

                entity.Property(e => e.OldResetFrequency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_ResetFrequency");

                entity.Property(e => e.OldRiskCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_Risk_Currency");

                entity.Property(e => e.OldSecurityDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_Security_Description");

                entity.Property(e => e.OldSecurityName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_Security_Name");

                entity.Property(e => e.OldSedol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_SEDOL");

                entity.Property(e => e.OldTradingFactor).HasColumnName("Old_Trading_factor");

                entity.Property(e => e.OldVolatility30days).HasColumnName("Old_Volatility_30Days");

                entity.Property(e => e.OldVolatility90days).HasColumnName("Old_Volatility_90Days");

                entity.Property(e => e.OldVolume).HasColumnName("Old_Volume");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.XnAction)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Xndate)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AuditEquity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Audit_Equity");

                entity.Property(e => e.NewAdrUnderlyingCurrency)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("New_ADR_Underlying_Currency");

                entity.Property(e => e.NewAdrUnderlyingTicker)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("New_ADR_Underlying_Ticker");

                entity.Property(e => e.NewAmount).HasColumnName("New_Amount");

                entity.Property(e => e.NewAskPrice).HasColumnName("New_Ask_Price");

                entity.Property(e => e.NewAvgVol20days).HasColumnName("New_Avg_Vol_20Days");

                entity.Property(e => e.NewBbgGlobalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_BBG_GlobalId");

                entity.Property(e => e.NewBbgIndistrySector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_BBG_Indistry_Sector");

                entity.Property(e => e.NewBbgIndustryGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_BBG_Industry_Group");

                entity.Property(e => e.NewBbgIndustrySubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_BBG_Industry_SubGroup");

                entity.Property(e => e.NewBbgUniqueId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("New_BBG_UniqueId");

                entity.Property(e => e.NewBeta).HasColumnName("New_Beta");

                entity.Property(e => e.NewBidPrice).HasColumnName("New_Bid_Price");

                entity.Property(e => e.NewBloombergTicker)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("New_Bloomberg_Ticker");

                entity.Property(e => e.NewBloombergUniqueName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_Bloomberg_Unique_Name");

                entity.Property(e => e.NewClosePrice).HasColumnName("New_Close_Price");

                entity.Property(e => e.NewCountryOfIncorp)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("New_Country_Of_Incorp");

                entity.Property(e => e.NewCusip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_CUSIP");

                entity.Property(e => e.NewDeclaredDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("New_Declared_Date");

                entity.Property(e => e.NewDividendType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("New_Dividend_Type");

                entity.Property(e => e.NewExDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("New_Ex_date");

                entity.Property(e => e.NewExchange)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("New_Exchange");

                entity.Property(e => e.NewFrequency)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("New_Frequency");

                entity.Property(e => e.NewHasPosistion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("New_Has_posistion");

                entity.Property(e => e.NewIpoDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("New_IPO_Date");

                entity.Property(e => e.NewIsActive)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("New_Is_active");

                entity.Property(e => e.NewIsAdr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("New_Is_ADR");

                entity.Property(e => e.NewIsin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_ISIN");

                entity.Property(e => e.NewIssueCountry)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("New_Issue_Country");

                entity.Property(e => e.NewIssueCurrency)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("New_Issue_Currency");

                entity.Property(e => e.NewIssuer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_Issuer");

                entity.Property(e => e.NewLastPrice).HasColumnName("New_Last_Price");

                entity.Property(e => e.NewOpenPrice).HasColumnName("New_Open_Price");

                entity.Property(e => e.NewPayDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("New_Pay_date");

                entity.Property(e => e.NewPeRatio).HasColumnName("New_PE_Ratio");

                entity.Property(e => e.NewPfAssetClass)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("New_PF_Asset_Class");

                entity.Property(e => e.NewPfCountry)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("New_PF_Country");

                entity.Property(e => e.NewPfCreditRating)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("New_PF_Credit_Rating");

                entity.Property(e => e.NewPfCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_PF_Currency");

                entity.Property(e => e.NewPfInstrument)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("New_PF_Instrument");

                entity.Property(e => e.NewPfLiquidityProfile)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("New_PF_Liquidity_Profile");

                entity.Property(e => e.NewPfMaturity)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("New_PF_Maturity");

                entity.Property(e => e.NewPfNaicsCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_PF_NAICS_Code");

                entity.Property(e => e.NewPfRegion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_PF_Region");

                entity.Property(e => e.NewPfSector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_PF_Sector");

                entity.Property(e => e.NewPfSubAssetClass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_PF_Sub_AssetClass");

                entity.Property(e => e.NewPriceCurrency)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("New_Price_Currency");

                entity.Property(e => e.NewRecordDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("New_Record_date");

                entity.Property(e => e.NewRiskCurrency)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("New_Risk_Currency");

                entity.Property(e => e.NewRoundLotSize).HasColumnName("New_Round_lot_size");

                entity.Property(e => e.NewSecurityDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_Security_description");

                entity.Property(e => e.NewSecurityName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_Security_name");

                entity.Property(e => e.NewSedol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("New_SEDOL");

                entity.Property(e => e.NewSettleDays).HasColumnName("New_Settle_Days");

                entity.Property(e => e.NewSharesPerAdr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("New_Shares_Per_ADR");

                entity.Property(e => e.NewShortIntrest).HasColumnName("New_Short_Intrest");

                entity.Property(e => e.NewTickerAndExcahnge)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_Ticker_And_Excahnge");

                entity.Property(e => e.NewTotalSharesOutstading).HasColumnName("New_Total_Shares_Outstading");

                entity.Property(e => e.NewTradingCurrency)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("New_Trading_Currency");

                entity.Property(e => e.NewVolatility90days).HasColumnName("New_Volatility_90Days");

                entity.Property(e => e.NewVolume).HasColumnName("New_Volume");

                entity.Property(e => e.NewVotingRightPerShaBre).HasColumnName("New_Voting_Right_Per_ShaBre");

                entity.Property(e => e.NewYtdReturn).HasColumnName("New_YTD_Return");

                entity.Property(e => e.OldAdrUnderlyingCurrency)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Old_ADR_Underlying_Currency");

                entity.Property(e => e.OldAdrUnderlyingTicker)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Old_ADR_Underlying_Ticker");

                entity.Property(e => e.OldAmount).HasColumnName("Old_Amount");

                entity.Property(e => e.OldAskPrice).HasColumnName("Old_Ask_Price");

                entity.Property(e => e.OldAvgVol20days).HasColumnName("Old_Avg_Vol_20Days");

                entity.Property(e => e.OldBbgGlobalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_BBG_GlobalId");

                entity.Property(e => e.OldBbgIndistrySector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_BBG_Indistry_Sector");

                entity.Property(e => e.OldBbgIndustryGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_BBG_Industry_Group");

                entity.Property(e => e.OldBbgIndustrySubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_BBG_Industry_SubGroup");

                entity.Property(e => e.OldBbgUniqueId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Old_BBG_UniqueId");

                entity.Property(e => e.OldBeta).HasColumnName("Old_Beta");

                entity.Property(e => e.OldBidPrice).HasColumnName("Old_Bid_Price");

                entity.Property(e => e.OldBloombergTicker)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Old_Bloomberg_Ticker");

                entity.Property(e => e.OldBloombergUniqueName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_Bloomberg_Unique_Name");

                entity.Property(e => e.OldClosePrice).HasColumnName("Old_Close_Price");

                entity.Property(e => e.OldCountryOfIncorp)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Old_Country_Of_Incorp");

                entity.Property(e => e.OldCusip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_CUSIP");

                entity.Property(e => e.OldDeclaredDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Old_Declared_Date");

                entity.Property(e => e.OldDividendType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Old_Dividend_Type");

                entity.Property(e => e.OldExDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Old_Ex_date");

                entity.Property(e => e.OldExchange)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Old_Exchange");

                entity.Property(e => e.OldFrequency)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Old_Frequency");

                entity.Property(e => e.OldHasPosistion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Old_Has_posistion");

                entity.Property(e => e.OldIpoDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Old_IPO_Date");

                entity.Property(e => e.OldIsActive)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Old_Is_active");

                entity.Property(e => e.OldIsAdr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OLd_Is_ADR");

                entity.Property(e => e.OldIsin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_ISIN");

                entity.Property(e => e.OldIssueCountry)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Old_Issue_Country");

                entity.Property(e => e.OldIssueCurrency)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Old_Issue_Currency");

                entity.Property(e => e.OldIssuer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_Issuer");

                entity.Property(e => e.OldLastPrice).HasColumnName("Old_Last_Price");

                entity.Property(e => e.OldOpenPrice).HasColumnName("Old_Open_Price");

                entity.Property(e => e.OldPayDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Old_Pay_date");

                entity.Property(e => e.OldPeRatio).HasColumnName("Old_PE_Ratio");

                entity.Property(e => e.OldPfAssetClass)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Old_PF_Asset_Class");

                entity.Property(e => e.OldPfCountry)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Old_PF_Country");

                entity.Property(e => e.OldPfCreditRating)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Old_PF_Credit_Rating");

                entity.Property(e => e.OldPfCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_PF_Currency");

                entity.Property(e => e.OldPfInstrument)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Old_PF_Instrument");

                entity.Property(e => e.OldPfLiquidityProfile)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Old_PF_Liquidity_Profile");

                entity.Property(e => e.OldPfMaturity)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Old_PF_Maturity");

                entity.Property(e => e.OldPfNaicsCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_PF_NAICS_Code");

                entity.Property(e => e.OldPfRegion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_PF_Region");

                entity.Property(e => e.OldPfSector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_PF_Sector");

                entity.Property(e => e.OldPfSubAssetClass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_PF_Sub_AssetClass");

                entity.Property(e => e.OldPriceCurrency)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Old_Price_Currency");

                entity.Property(e => e.OldRecordDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Old_Record_date");

                entity.Property(e => e.OldRiskCurrency)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Old_Risk_Currency");

                entity.Property(e => e.OldRoundLotSize).HasColumnName("Old_Round_lot_size");

                entity.Property(e => e.OldSecurityDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_Security_description");

                entity.Property(e => e.OldSecurityName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_Security_name");

                entity.Property(e => e.OldSedol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Old_SEDOL");

                entity.Property(e => e.OldSettleDays).HasColumnName("Old_Settle_Days");

                entity.Property(e => e.OldSharesPerAdr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Old_Shares_Per_ADR");

                entity.Property(e => e.OldShortIntrest).HasColumnName("Old_Short_Intrest");

                entity.Property(e => e.OldTickerAndExcahnge)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_Ticker_And_Excahnge");

                entity.Property(e => e.OldTotalSharesOutstading).HasColumnName("Old_Total_Shares_Outstading");

                entity.Property(e => e.OldTradingCurrency)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Old_Trading_Currency");

                entity.Property(e => e.OldVolatility90days).HasColumnName("Old_Volatility_90Days");

                entity.Property(e => e.OldVolume).HasColumnName("Old_Volume");

                entity.Property(e => e.OldVotingRightPerShaBre).HasColumnName("Old_Voting_Right_Per_ShaBre");

                entity.Property(e => e.OldYtdReturn).HasColumnName("Old_YTD_Return");

                entity.Property(e => e.SecurityId).HasColumnName("Security_id");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.XnAction)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Xndate)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bond>(entity =>
            {
                entity.Property(e => e.BondId)
                    .ValueGeneratedNever()
                    .HasColumnName("Bond_Id");

                entity.Property(e => e.AskPrice).HasColumnName("Ask_Price");

                entity.Property(e => e.AssetType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Asset_Type");

                entity.Property(e => e.AvgVolume30days).HasColumnName("AvgVolume_30days");

                entity.Property(e => e.BbgIndustryGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBG_Industry_Group");

                entity.Property(e => e.BbgIndustrySector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBG_Industry_Sector");

                entity.Property(e => e.BbgIndustrySubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBG_Industry_SubGroup");

                entity.Property(e => e.BbgTicker)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBG_Ticker");

                entity.Property(e => e.BbgUniqueId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBG_Unique_ID");

                entity.Property(e => e.BidPrice).HasColumnName("Bid_Price");

                entity.Property(e => e.CallDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CouponCap)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Coupon_Cap");

                entity.Property(e => e.CouponFloor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Coupon_Floor");

                entity.Property(e => e.CouponFrequency).HasColumnName("Coupon_Frequency");

                entity.Property(e => e.CouponRate).HasColumnName("Coupon_Rate");

                entity.Property(e => e.CouponType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Coupon_Type");

                entity.Property(e => e.Cusip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CUSIP");

                entity.Property(e => e.FirstCouponDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("First_Coupon_Date");

                entity.Property(e => e.FloatSpread)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Float_Spread");

                entity.Property(e => e.HasPosition)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Has_Position");

                entity.Property(e => e.HighPrice).HasColumnName("High_Price");

                entity.Property(e => e.InvestmentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Investment_Type");

                entity.Property(e => e.IsCallable)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Is_Callable");

                entity.Property(e => e.IsFixToFloat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsPutable)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ISIN");

                entity.Property(e => e.IssueCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Issue_Country ");

                entity.Property(e => e.IssueCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Issue_Currency");

                entity.Property(e => e.IssueDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Issuer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastPrice).HasColumnName("Last_Price");

                entity.Property(e => e.LastResetDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LowPrice).HasColumnName("Low_Price");

                entity.Property(e => e.MacaulayDuration).HasColumnName("Macaulay_Duration");

                entity.Property(e => e.Maturity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OpenPrice).HasColumnName("Open_Price");

                entity.Property(e => e.PenultimateCouponDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Penultimate_CouponDate ");

                entity.Property(e => e.PfAssetClass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PF_AssetClass");

                entity.Property(e => e.PfCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PF_Country");

                entity.Property(e => e.PfCreditRating)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PF_CreditRating");

                entity.Property(e => e.PfCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PF_Currency");

                entity.Property(e => e.PfInstrument)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PF_Instrument");

                entity.Property(e => e.PfLiquidityProfile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PF_LiquidityProfile");

                entity.Property(e => e.PfMaturity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PF_Maturity");

                entity.Property(e => e.PfNaicsCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PF_NAICS_Code");

                entity.Property(e => e.PfRegion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PF_Region");

                entity.Property(e => e.PfSector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PF_Sector");

                entity.Property(e => e.PfSubAssetClass)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("PF_SubAssetClass");

                entity.Property(e => e.PricingFactor).HasColumnName("Pricing_Factor");

                entity.Property(e => e.PutDate).HasColumnName("Put_Date");

                entity.Property(e => e.PutPrice).HasColumnName("Put_Price");

                entity.Property(e => e.ResetFrequency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RiskCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Risk_Currency");

                entity.Property(e => e.SecurityDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Security_Description");

                entity.Property(e => e.SecurityName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Security_Name");

                entity.Property(e => e.Sedol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SEDOL");

                entity.Property(e => e.TradingFactor).HasColumnName("Trading_Factor");

                entity.Property(e => e.Volatility30days).HasColumnName("Volatility_30Days");

                entity.Property(e => e.Volatility90days).HasColumnName("Volatility_90Days");
            });

            modelBuilder.Entity<Equity>(entity =>
            {
                entity.HasKey(e => e.SecurityId);

                entity.Property(e => e.SecurityId)
                    .ValueGeneratedNever()
                    .HasColumnName("Security_Id");

                entity.Property(e => e.AdrUnderlyingCurrency)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ADR_Underlying_Currency");

                entity.Property(e => e.AdrUnderlyingTicker)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ADR_Underlying_Ticker");

                entity.Property(e => e.AskPrice).HasColumnName("Ask_Price");

                entity.Property(e => e.AverageVolume20d).HasColumnName("Average_Volume_20D");

                entity.Property(e => e.BbgGlobalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBG_Global_ID");

                entity.Property(e => e.BbgIndustrySubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBG_Industry_Sub_Group");

                entity.Property(e => e.BbgUniqueName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBG_Unique_Name");

                entity.Property(e => e.BidPrice).HasColumnName("Bid_Price");

                entity.Property(e => e.BloombergIndustryGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Bloomberg_Industry_Group");

                entity.Property(e => e.BloombergSector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Bloomberg_Sector");

                entity.Property(e => e.BloombergTicker)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Bloomberg_Ticker");

                entity.Property(e => e.BloombergUniqueId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Bloomberg_Unique_ID");

                entity.Property(e => e.ClosePrice).HasColumnName("Close_Price");

                entity.Property(e => e.CountryOfIncorporation)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Country_of_Incorporation");

                entity.Property(e => e.CountryOfIssuance)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Country_of_Issuance");

                entity.Property(e => e.Cusip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CUSIP");

                entity.Property(e => e.DividendAmount).HasColumnName("Dividend_Amount");

                entity.Property(e => e.DividendDeclaredDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Dividend_Declared_Date");

                entity.Property(e => e.DividendExDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Dividend_Ex_Date");

                entity.Property(e => e.DividendPayDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Dividend_Pay_Date");

                entity.Property(e => e.DividendRecordDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Dividend_Record_Date");

                entity.Property(e => e.DividendType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Dividend_Type");

                entity.Property(e => e.Exchange)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Frequency)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HasPosition)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Has_Position");

                entity.Property(e => e.IpoDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IPO_Date");

                entity.Property(e => e.IsActiveSecurity)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Is_Active_Security");

                entity.Property(e => e.IsAdrFlag)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Is_ADR_Flag");

                entity.Property(e => e.Isin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ISIN");

                entity.Property(e => e.IssueCurrency)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Issue_Currency");

                entity.Property(e => e.Issuer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastPrice).HasColumnName("Last_Price");

                entity.Property(e => e.LotSize).HasColumnName("Lot_Size");

                entity.Property(e => e.OpenPrice).HasColumnName("Open_Price");

                entity.Property(e => e.PeRatio).HasColumnName("PE_Ratio");

                entity.Property(e => e.PfAssetClass)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PF_Asset_Class");

                entity.Property(e => e.PfCountry)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PF_Country");

                entity.Property(e => e.PfCreditRating)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PF_Credit_Rating");

                entity.Property(e => e.PfCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PF_Currency");

                entity.Property(e => e.PfInstrument)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PF_Instrument");

                entity.Property(e => e.PfLiquidityProfile)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PF_Liquidity_Profile");

                entity.Property(e => e.PfMaturity)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PF_Maturity");

                entity.Property(e => e.PfNaicsCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PF_NAICS_Code");

                entity.Property(e => e.PfRegion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PF_Region");

                entity.Property(e => e.PfSector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PF_Sector");

                entity.Property(e => e.PfSubAssetClass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PF_Sub_Asset_Class");

                entity.Property(e => e.PricingCurrency)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Pricing_Currency");

                entity.Property(e => e.ReturnYtd).HasColumnName("Return_YTD");

                entity.Property(e => e.RiskCurrency)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Risk_Currency");

                entity.Property(e => e.SecurityDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Security_Description");

                entity.Property(e => e.SecurityName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Security_Name");

                entity.Property(e => e.Sedol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SEDOL");

                entity.Property(e => e.SettleDays).HasColumnName("Settle_Days");

                entity.Property(e => e.SharesPerAdr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Shares_Per_ADR");

                entity.Property(e => e.ShortInterest).HasColumnName("Short_Interest");

                entity.Property(e => e.TickerAndExchange)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ticker_and_Exchange");

                entity.Property(e => e.TotalSharesOutstanding).HasColumnName("Total_Shares_Outstanding");

                entity.Property(e => e.TradingCurrency)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Trading_Currency");

                entity.Property(e => e.Volatility90d).HasColumnName("Volatility_90D");

                entity.Property(e => e.VotingRightsPerShare).HasColumnName("Voting_Rights_Per_Share");
            });

            modelBuilder.Entity<VuCallScheduleBond>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vuCallSchedule_bond");

                entity.Property(e => e.CallDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VuDividendHistoryEquity>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vuDividendHistory_Equities");

                entity.Property(e => e.DividendAmount).HasColumnName("Dividend_Amount");

                entity.Property(e => e.DividendDeclaredDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Dividend_Declared_Date");

                entity.Property(e => e.DividendExDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Dividend_Ex_Date");

                entity.Property(e => e.DividendPayDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Dividend_Pay_Date");

                entity.Property(e => e.DividendRecordDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Dividend_Record_Date");

                entity.Property(e => e.DividendType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Dividend_Type");

                entity.Property(e => e.Frequency)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VuPricingDetailsEquity>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vuPricingDetails_Equities");

                entity.Property(e => e.AskPrice).HasColumnName("Ask_Price");

                entity.Property(e => e.BidPrice).HasColumnName("Bid_Price");

                entity.Property(e => e.ClosePrice).HasColumnName("Close_Price");

                entity.Property(e => e.LastPrice).HasColumnName("Last_Price");

                entity.Property(e => e.OpenPrice).HasColumnName("Open_Price");

                entity.Property(e => e.PeRatio).HasColumnName("PE_Ratio");
            });

            modelBuilder.Entity<VuPricingandAnalyticsBond>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vuPricingandAnalytics_bond");

                entity.Property(e => e.AskPrice).HasColumnName("Ask_Price");

                entity.Property(e => e.BidPrice).HasColumnName("Bid_Price");

                entity.Property(e => e.HighPrice).HasColumnName("High_Price");

                entity.Property(e => e.LastPrice).HasColumnName("Last_Price");

                entity.Property(e => e.LowPrice).HasColumnName("Low_Price");

                entity.Property(e => e.OpenPrice).HasColumnName("Open_Price");
            });

            modelBuilder.Entity<VuPutScheduleBond>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vuPutSchedule_bond");

                entity.Property(e => e.PutDate).HasColumnName("Put_Date");

                entity.Property(e => e.PutPrice).HasColumnName("Put_Price");
            });

            modelBuilder.Entity<VuReferenceDataBond>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vuReferenceData_bond");

                entity.Property(e => e.BbgIndustryGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBG_Industry_Group");

                entity.Property(e => e.BbgIndustrySector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBG_Industry_Sector");

                entity.Property(e => e.BbgIndustrySubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBG_Industry_SubGroup");

                entity.Property(e => e.IssueCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Issue_Country");

                entity.Property(e => e.IssueCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Issue_Currency");

                entity.Property(e => e.Issuer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RiskCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Risk_Currency");
            });

            modelBuilder.Entity<VuReferenceDataEquity>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vuReferenceData_Equities");

                entity.Property(e => e.BbgIndustrySubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBG_Industry_Sub_Group");

                entity.Property(e => e.BloombergIndustryGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Bloomberg_Industry_Group");

                entity.Property(e => e.BloombergSector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Bloomberg_Sector");

                entity.Property(e => e.CountryOfIssuance)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Country_of_Issuance");

                entity.Property(e => e.Exchange)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.IssueCurrency)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Issue_Currency");

                entity.Property(e => e.Issuer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RiskCurrency)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Risk_Currency");

                entity.Property(e => e.TradingCurrency)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Trading_Currency");
            });

            modelBuilder.Entity<VuRegulatoryDetailsBond>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vuRegulatoryDetails_bond");

                entity.Property(e => e.PfAssetClass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PF_AssetClass");

                entity.Property(e => e.PfCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PF_Country");

                entity.Property(e => e.PfCreditRating)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PF_CreditRating");

                entity.Property(e => e.PfCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PF_Currency");

                entity.Property(e => e.PfInstrument)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PF_Instrument");

                entity.Property(e => e.PfLiquidityProfile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PF_LiquidityProfile");

                entity.Property(e => e.PfMaturity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PF_Maturity");

                entity.Property(e => e.PfNaicsCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PF_NAICS_Code");

                entity.Property(e => e.PfRegion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PF_Region");

                entity.Property(e => e.PfSector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PF_Sector");

                entity.Property(e => e.PfSubAssetClass)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("PF_SubAssetClass");
            });

            modelBuilder.Entity<VuRegulatoryDetailsEquity>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vuRegulatoryDetails_Equities");

                entity.Property(e => e.PfAssetClass)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PF_Asset_Class");

                entity.Property(e => e.PfCountry)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PF_Country");

                entity.Property(e => e.PfCreditRating)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PF_Credit_Rating");

                entity.Property(e => e.PfCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PF_Currency");

                entity.Property(e => e.PfInstrument)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PF_Instrument");

                entity.Property(e => e.PfLiquidityProfile)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PF_Liquidity_Profile");

                entity.Property(e => e.PfMaturity)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PF_Maturity");

                entity.Property(e => e.PfNaicsCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PF_NAICS_Code");

                entity.Property(e => e.PfRegion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PF_Region");

                entity.Property(e => e.PfSector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PF_Sector");

                entity.Property(e => e.PfSubAssetClass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PF_Sub_Asset_Class");
            });

            modelBuilder.Entity<VuRiskBond>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vuRisk_bond");

                entity.Property(e => e.AvgVolume30days).HasColumnName("AvgVolume_30days");

                entity.Property(e => e.MacaulayDuration).HasColumnName("Macaulay_Duration");

                entity.Property(e => e.Volatility30days).HasColumnName("Volatility_30Days");

                entity.Property(e => e.Volatility90days).HasColumnName("Volatility_90Days");
            });

            modelBuilder.Entity<VuRiskEquity>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vuRisk_Equities");

                entity.Property(e => e.AverageVolume20d).HasColumnName("Average_Volume_20D");

                entity.Property(e => e.ReturnYtd).HasColumnName("Return_YTD");

                entity.Property(e => e.ShortInterest).HasColumnName("Short_Interest");

                entity.Property(e => e.Volatility90d).HasColumnName("Volatility_90D");
            });

            modelBuilder.Entity<VuSecuritDetailsBond>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vuSecuritDetails_bond");

                entity.Property(e => e.CouponCap)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Coupon_Cap");

                entity.Property(e => e.CouponFloor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Coupon_Floor");

                entity.Property(e => e.CouponFrequency).HasColumnName("Coupon_frequency");

                entity.Property(e => e.CouponRate).HasColumnName("Coupon_Rate");

                entity.Property(e => e.CouponType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Coupon_Type");

                entity.Property(e => e.FirstCouponDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("First_coupon_Date");

                entity.Property(e => e.FloatSpread)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Float_Spread");

                entity.Property(e => e.HasPosition)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Has_Position");

                entity.Property(e => e.IsCallable)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IS_Callable");

                entity.Property(e => e.IsFixToFloat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsPutable)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IssueDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastResetDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Maturity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PenultimateCouponDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Penultimate_CouponDate");

                entity.Property(e => e.ResetFrequency)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VuSecurityDetailsEquity>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vuSecurityDetails_Equities");

                entity.Property(e => e.AdrUnderlyingTicker)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ADR_Underlying_Ticker");

                entity.Property(e => e.IpoDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IPO_Date");

                entity.Property(e => e.IsAdrFlag)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Is_ADR_Flag");

                entity.Property(e => e.PricingCurrency)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Pricing_Currency");

                entity.Property(e => e.SettleDays).HasColumnName("Settle_Days");

                entity.Property(e => e.SharesPerAdr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Shares_Per_ADR");

                entity.Property(e => e.TotalSharesOutstanding).HasColumnName("Total_Shares_Outstanding");

                entity.Property(e => e.VotingRightsPerShare).HasColumnName("Voting_Rights_Per_Share");
            });

            modelBuilder.Entity<VuSecurityIdentifierBond>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vuSecurityIdentifier_bond");

                entity.Property(e => e.BbgTicker)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBG_Ticker");

                entity.Property(e => e.BbgUniqueId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBG_Unique_Id");

                entity.Property(e => e.Cusip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CUSIP");

                entity.Property(e => e.Isin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ISIN");

                entity.Property(e => e.Sedol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SEDOL");
            });

            modelBuilder.Entity<VuSecurityIdentifierEquity>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vuSecurityIdentifier_Equities");

                entity.Property(e => e.BbgGlobalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBG_Global_ID");

                entity.Property(e => e.BloombergTicker)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Bloomberg_Ticker");

                entity.Property(e => e.BloombergUniqueId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Bloomberg_Unique_Id");

                entity.Property(e => e.Cusip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CUSIP");

                entity.Property(e => e.Isin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ISIN");

                entity.Property(e => e.Sedol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SEDOL");

                entity.Property(e => e.TickerAndExchange)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ticker_and_Exchange");
            });

            modelBuilder.Entity<VuSecuritySummaryBond>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vuSecuritySummary_bond");

                entity.Property(e => e.AssetType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Asset_type");

                entity.Property(e => e.InvestmentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Investment_type");

                entity.Property(e => e.PricingFactor).HasColumnName("Pricing_factor");

                entity.Property(e => e.SecurityDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Security_Description");

                entity.Property(e => e.SecurityName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Security_Name");

                entity.Property(e => e.TradingFactor).HasColumnName("Trading_factor");
            });

            modelBuilder.Entity<VuSecuritySummaryEquity>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vuSecuritySummary_Equities");

                entity.Property(e => e.BbgUniqueName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBG_Unique_Name");

                entity.Property(e => e.HasPosition)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Has_Position");

                entity.Property(e => e.IsActiveSecurity)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Is_Active_Security");

                entity.Property(e => e.LotSize).HasColumnName("Lot_Size");

                entity.Property(e => e.SecurityDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Security_Description");

                entity.Property(e => e.SecurityName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Security_Name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
