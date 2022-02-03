using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shared.DTOs
{
    public class AddPersonal_InfoDTO
    {
        [Required]
        public string FullName { get; set; }

        public string CityName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string MobileNumber { get; set; }
    }
}
