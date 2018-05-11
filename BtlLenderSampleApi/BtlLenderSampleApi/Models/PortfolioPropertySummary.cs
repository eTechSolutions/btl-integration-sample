namespace BtlLenderSampleApi.Models
{
    public class PortfolioPropertySummary
    {
        public PortfolioPropertySummaryDetail BrokerSummary { get; set; }

        public PortfolioPropertySummaryDetail AvmSummary { get; set; }

        public decimal? PropertyValueDifference { get; set; }

        public decimal? MonthlyRentalDifference { get; set; }

        public decimal? MonthlyMortgagePaymentDifference { get; set; }
    }
}
