using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Databases.Models
{
    public class CV
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        // relations

        public int Personal_Information_Id { get; set; }

        [ForeignKey(nameof(Personal_Information_Id))]
        public Personal_Information Personal_Information { get; set; }

        public int Experience_Information_Id { get; set; }

        [ForeignKey(nameof(Experience_Information_Id))]
        public Experience_Information Experience_Information { get; set; }
    }
}
