using System;
using System.Collections.Generic;

namespace BtlLenderSampleApi.Models
{
    public class Applicant
    {
        public Guid Id { get; set; }
        
        public Salutation Salutation { get; set; }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string Email { get; set; }

        public string TelephoneNumber { get; set; }

        public ICollection<ApplicantCompany> Companies { get; set; }
    }
}
