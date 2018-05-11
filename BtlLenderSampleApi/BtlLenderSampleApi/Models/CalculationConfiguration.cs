namespace BtlLenderSampleApi.Models
{
    public class CalculationConfiguration
    {
        public CalculationValuesSource CalculationValuesSource { get; set; }

        public decimal? AvmConfidenceThreshold { get; set; }

        public decimal? UseBrokerRentalValueDifferenceThreshold { get; set; }

        public decimal? UseBrokerPropertyValueDifferenceThreshold { get; set; }

        public bool ReRunDerivationChecksExcludingHmoProperties { get; set; }

        public decimal? PercentageOfPropertiesToBeNonHmoForReRun { get; set; }
        
        public decimal? InterestRate { get; set; }

        public decimal? LtvWarnTolerancePrivate { get; set; }

        public decimal? LtvWarnToleranceLimited { get; set; }

        public decimal? IcrWarnTolerancePrivate { get; set; }

        public decimal? IcrFailTolerancePrivate { get; set; }

        public decimal? IcrWarnToleranceLimited { get; set; }

        public decimal? IcrFailToleranceLimited { get; set; }

        public bool? IsPortfolioTotalsCheckIncluded { get; set; }

        public decimal? IcrPassThreshold { get; set; }

        public decimal? IcrReferThreshold { get; set; }

        public decimal? LtvPassThreshold { get; set; }

        public bool? IsNonPrivateHeldSubGroupIncluded { get; set; }

        public decimal? IcrLimitedToleranceSettingsPass { get; set; }

        public decimal? IcrLimitedToleranceSettingsRefer { get; set; }

        public decimal? LtvLimitedToleranceSettingsPass { get; set; }

        public bool? IsPrivateHeldSubGroupIncluded { get; set; }

        public decimal? IcrPrivateNameToleranceSettingsPass { get; set; }

        public decimal? IcrPrivateNameToleranceSettingsRefer { get; set; }

        public decimal? LtvPrivateNameToleranceSettingsPass { get; set; }

        public decimal? BrokerVerifiedAddressPercentage { get; set; }

        public bool? IsLenderVerifiedAddressIncluded { get; set; }

        public decimal? LenderVerifiedAddressPercentage { get; set; }

        public bool? IsIndividualPropertiesAboveIcrIncluded { get; set; }

        public decimal? IndividualPropertiesAboveIcr { get; set; }

        public bool? IsValidAvmCheckIncluded { get; set; }

        public decimal? ValidAvmPercentage { get; set; }

        public int? MinimumNumberOfValidAvmProperties { get; set; }

        public bool HoldAllApplications { get; set; }

        public AvmSource? AvmSource { get; set; }

        public LenderOutputType? OutputType { get; set; }

        public LenderType LenderType { get; set; }

        public bool IsLenderLoanOriginationSystemEnabled { get; set; }

        public string LenderLoanOriginationSystemUrl { get; set; }

        public CalculationConfigurationHistory ModificationHistory { get; set; }
    }
}
