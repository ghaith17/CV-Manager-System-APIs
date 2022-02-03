using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Databases.Models
{
    public class Experience_Information
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required,MaxLength(20)]
        public string CompanyName { get; set; }

        public string City { get; set; }

        public string CompanyField { get; set; }

    }
}
