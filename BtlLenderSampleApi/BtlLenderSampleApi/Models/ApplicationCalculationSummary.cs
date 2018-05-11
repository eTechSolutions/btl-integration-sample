namespace BtlLenderSampleApi.Models
{
    public class ApplicationCalculationSummary
    {
        public decimal? Icr { get; set; }

        public decimal? LoanToValue { get; set; }

        public decimal? Yield { get; set; }

        public string Result { get; set; }

        public string ResultReason { get; set; }

        public decimal? ActualIcrPercentage => Icr * 100;

        public decimal? ActualLtvPercentage => LoanToValue * 100;

        public CalculationResult IcrToleranceResult { get; set; }

        public CalculationResult LtvToleranceResult { get; set; }
    }
}
