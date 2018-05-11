namespace BtlLenderSampleApi.Models
{
    public class ApplicationCalculationValues
    {
        public PortfolioPropertyCalculationValuesSummary PortfolioPropertyCalculationValuesSummary { get; set; }

        public decimal? TotalPropertyValue { get; set; }

        public decimal? TotalMonthlyRentalIncome { get; set; }

        public decimal? TotalCurrentMortgageBalance { get; set; }

        public decimal? TotalMonthlyMortgagePayment { get; set; }

        public decimal? AverageLoanToValue { get; set; }

        public decimal? AverageInterestCoverageRatio { get; set; }

        public ApplicationCalculationSummary CalculationSummary { get; set; }

        public ApplicationCalculationSummary CalculationSummaryCompany { get; set; }

        public ApplicationCalculationSummary CalculationSummaryPrivate { get; set; }

        public decimal? PropertiesFailingIcrPercentage { get; set; }

        public string PropertiesFailingIcrResult { get; set; }

        public string PropertiesFailingIcrResultReason { get; set; }

        public decimal? PropertiesWithVerifiedAddressPercentage { get; set; }

        public string PropertiesWithUnverifiedAddressResult { get; set; }

        public string PropertiesWithUnverifiedAddressResultReason { get; set; }

        public string OverallResult { get; set; }

        public string OverallResultReason { get; set; }

        public decimal? AverageTotalPropertyValue { get; set; }

        public decimal? AverageCurrentMortgageBalance { get; set; }

        public string PropertiesWithValidAvmResult { get; set; }

        public bool ValidAvmRuleUsedPercentage { get; set; }

        public decimal? PropertiesWithValidAvm { get; set; }

        public string AvmAvailableReason { get; set; }
    }
}
