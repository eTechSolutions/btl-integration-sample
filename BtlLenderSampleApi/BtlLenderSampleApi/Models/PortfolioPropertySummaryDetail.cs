namespace BtlLenderSampleApi.Models
{
    public class PortfolioPropertySummaryDetail
    {
        public decimal? PropertyValue { get; set; }

        public decimal? MonthlyRentalIncome { get; set; }

        public decimal? CurrentMortgageBalance { get; set; }

        public decimal? MonthlyMortgagePayment { get; set; }

        public decimal? Yield { get; set; }

        public decimal? Icr { get; set; }

        public decimal? ActualIcrPercentage => Icr * 100;

        public CalculationResult IcrToleranceResult { get; set; }

        public decimal? LoanToValue { get; set; }

        public decimal? ActualLtvPercentage => LoanToValue * 100;

        public CalculationResult LtvToleranceResult { get; set; }
    }
}
