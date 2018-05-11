using System.Collections.Generic;

namespace BtlLenderSampleApi.Models
{
    public class PortfolioPropertyCalculationValuesSummary
    {
        public List<PortfolioPropertyCalculationValues> PortfolioPropertyCalculationValues { get; set; }

        public PortfolioPropertyCalculationResults BaselineSummary { get; set; }

        public PortfolioPropertyCalculationResults CalculationValuesSummary { get; set; }

        public PortfolioPropertyCalculationResults CalculationValuesExHmoSummary { get; set; }
    }
}
