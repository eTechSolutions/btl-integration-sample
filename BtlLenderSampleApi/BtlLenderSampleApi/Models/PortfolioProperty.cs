using System;
using System.Collections.Generic;

namespace BtlLenderSampleApi.Models
{
    public class PortfolioProperty
    {
        public Guid Id { get; set; }

        public DateTime CreatedUtc { get; set; }

        public DateTime ModifiedUtc { get; set; }

        public decimal? LenderAvmMonthlyMortgagePayment { get; set; }

        public decimal? AvmLoanToValue { get; set; }

        public decimal? AvmLoanToValuePercent { get; set; }

        public decimal? AvmIcr { get; set; }

        public decimal? AvmIcrPercent { get; set; }

        public CalculationResult BrokerIcrToleranceResult { get; set; }

        public CalculationResult AvmIcrToleranceResult { get; set; }

        public CalculationResult BrokerLtvToleranceResult { get; set; }

        public CalculationResult AvmLtvToleranceResult { get; set; }

        public List<PortfolioPropertyOwner> PortfolioPropertyOwners { get; set; }

        public string ImportedAddress { get; set; }

        public PortfolioPropertyStatus Status { get; set; }
        
        public decimal? CurrentMortgageBalance { get; set; }
        
        public decimal? RentalIncome { get; set; }
        
        public decimal? PropertyValue { get; set; }
        
        public decimal? MonthlyMortgagePayment { get; set; }

        public string LenderName { get; set; }

        public bool IsPrivatelyOwned { get; set; }

        public Guid BrokerPortfolioPropertyId { get; set; }

        public bool IsRemoved { get; set; }

        public string RemovalReason { get; set; }

        public DateTime? RemovedUtc { get; set; }

        public Guid? RemovedByUserId { get; set; }

        public string RemovedByUserFirstName { get; set; }

        public string RemovedByUserLastName { get; set; }

        public bool IsManuallyEntered { get; set; }

        public decimal? IncomeContingentRepayment { get; set; }

        public decimal? IncomeContingentRepaymentPercent { get; set; }

        public decimal? LoanToValue { get; set; }

        public decimal? LoanToValuePercent { get; set; }

        public decimal? Yield { get; set; }

        public decimal? AvmYield { get; set; }

        public int AvmPropertyValue { get; set; }

        public string AvmPropertyType { get; set; }

        public string AvmPropertyStyle { get; set; }

        public double AvmCapitalConfidencePercentage { get; set; }

        public bool? AvmCapitalConfidenceWithinThreshold { get; set; }

        public string AvmCapitalConfidenceLevel { get; set; }

        public int AvmMonthlyRental { get; set; }

        public double AvmRentalConfidencePercentage { get; set; }

        public bool? AvmRentalConfidenceWithinThreshold { get; set; }

        public bool AvmAvailable { get; set; }

        public int AvmNumberOfBeds { get; set; }

        public bool IsHmoProperty { get; set; }

        public Address Address { get; set; }

        public string EpcCurrentRating { get; set; }

        public DateTime? EpcCompletionDateUtc { get; set; }

        public string EpcPossibleRating { get; set; }

        public DateTime? EpcLastUpdatedUtc { get; set; }

        public bool CurrentlyTenanted { get; set; }

        public string TimeOwned { get; set; }

        public bool MultiUnitBlocks { get; set; }
    }
}
