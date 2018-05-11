namespace BtlLenderSampleApi.Models
{
    public class PortfolioPropertyCalculationResults
    {
        public int BrokerValidPropertyValueCount { get; set; }

        public int AvmValidPropertyValueCount { get; set; }

        public decimal BrokerPropertyValueTotal { get; set; }

        public decimal AvmPropertyValueTotal { get; set; }

        public decimal? PropertyTotalDifference { get; set; }

        public decimal BrokerMortgageBalanceTotal { get; set; }

        public decimal AvmMortgageBalanceTotal { get; set; }
        
        public decimal? BrokerLoanToValue { get; set; }

        public decimal? AvmLoanToValue { get; set; }
        
        public int BrokerValidRentalValueCount { get; set; }

        public int AvmValidRentalValueCount { get; set; }

        public decimal BrokerRentalIncomeTotal { get; set; }

        public decimal AvmRentalIncomeTotal { get; set; }

        public decimal? RentalIncomeTotalDifference { get; set; }

        public decimal BrokerMonthlyMortgagePaymentTotal { get; set; }

        public decimal AvmMonthlyMortgagePaymentTotal { get; set; }

        public decimal? MortgagePaymentTotalDifference { get; set; }

        public decimal? BrokerInterestCoverageRatio { get; set; }

        public decimal? AvmInterestCoverageRatio { get; set; }

        public decimal BrokerPropertyValuesAverage { get; set; }

        public decimal BrokerCurrentMortgageBalanceAverage { get; set; }

        public decimal AvmPropertyValuesAverage { get; set; }

        public decimal AvmCurrentMortgageBalanceAverage { get; set; }

        public decimal PercentageOfPropertiesWithValidAvm { get; set; }

        public decimal PercentageOfRentalPropertiesWithValidAvm { get; set; }
    }
}
