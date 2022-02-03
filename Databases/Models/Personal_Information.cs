using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Databases.Models
{
    public class Personal_Information
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        public string CityName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string MobileNumber { get; set; }
    }
}
