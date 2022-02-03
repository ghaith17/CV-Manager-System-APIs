using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shared.DTOs
{
    public class AddExperience_InfoDTO
    {
        [Required, MaxLength(20)]
        public string CompanyName { get; set; }

        public string City { get; set; }

        public string CompanyField { get; set; }
    }
}
