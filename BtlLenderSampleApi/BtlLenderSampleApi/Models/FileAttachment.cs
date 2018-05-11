using System;

namespace BtlLenderSampleApi.Models
{
    public class FileAttachment
    {
        public Guid Id { get; set; }

        public string FileName { get; set; }

        public string ExtensionType { get; set; }

        public DateTime CreatedUtc { get; set; }

        public ApplicationReportType ApplicationReportType { get; set; }
    }
}
