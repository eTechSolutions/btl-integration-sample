using System;

namespace BtlLenderSampleApi.Models
{
    public class PortfolioPropertyCalculationValues : Address
    {
        public Guid PortfolioPropertyId { get; set; }

        public decimal? PropertyValue { get; set; }

        public ValueSource PropertyValueSource { get; set; }

        public decimal? MonthlyRentalIncome { get; set; }

        public ValueSource RentalIncomeSource { get; set; }

        public decimal? CurrentMortgageBalance { get; set; }

        public decimal? MonthlyMortgagePayment { get; set; }

        public decimal? Yield { get; set; }

        public decimal? LoanToValue { get; set; }

        public decimal? LoanToValuePercent => LoanToValue * 100;

        public CalculationResult LtvThresholdResult { get; set; }

        public decimal? Icr { get; set; }

        internal decimal? IcrPercent => Icr * 100;

        public CalculationResult IcrThresholdResult { get; set; }

        public bool IsHmoProperty { get; set; }

        public bool PrivatelyOwned { get; set; }

        public bool AvmAvailable { get; set; }

        public bool? AvmCapitalConfidenceWithinThreshold { get; set; }

        public bool? AvmRentalConfidenceWithinThreshold { get; set; }

        public int AvmPropertyValue { get; set; }

        public int AvmMonthlyRental { get; set; }

        public bool CurrentlyTenanted { get; set; }

        public string TimeOwned { get; set; }

        public bool MultiUnitBlocks { get; set; }
    }
}
