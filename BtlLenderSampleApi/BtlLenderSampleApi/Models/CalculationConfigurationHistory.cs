namespace BtlLenderSampleApi.Models
{
    public class CalculationConfigurationHistory
    {
        public CalculationConfigurationHistoryItem PreSubmissionRulesLastModifiedBy { get; set; }

        public CalculationConfigurationHistoryItem SubmissionRulesLastModifiedBy { get; set; }

        public CalculationConfigurationHistoryItem IndividualPropertyWarningLastModifiedBy { get; set; }

        public CalculationConfigurationHistoryItem PortfolioTotalsLastModifiedBy { get; set; }

        public CalculationConfigurationHistoryItem NonPrivatePropertyTotalsLastModifiedBy { get; set; }

        public CalculationConfigurationHistoryItem PrivatePropertyTotalsLastModifiedBy { get; set; }

        public CalculationConfigurationHistoryItem VerifiedAddressesLastModifiedBy { get; set; }

        public CalculationConfigurationHistoryItem IcrThresholdLastModifiedBy { get; set; }

        public CalculationConfigurationHistoryItem ValidAvmPropertiesLastModifiedBy { get; set; }
    }
}
