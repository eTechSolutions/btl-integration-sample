using System.Collections.Generic;

namespace BtlLenderSampleApi.Models
{
    public class Application
    {
        public decimal LenderInterestRate { get; set; }

        public ICollection<Applicant> Applicants { get; set; }

        public ICollection<PortfolioProperty> PortfolioProperties { get; set; }

        public ICollection<PortfolioProperty> RemovedPortfolioProperties { get; set; }

        public PortfolioPropertySummary PortfolioSummary { get; set; }

        public ApplicationCalculationValues CalculationValues { get; set; }

        public CalculationConfiguration CalculationConfiguration { get; set; }

        public ICollection<FileAttachment> ApplicationAttachments { get; set; }

        public string RegeneratedBy { get; set; }

        public string SubmittedByBrokerUser { get; set; }

        public string SubmittedByBrokerFirm { get; set; }
    }
}
