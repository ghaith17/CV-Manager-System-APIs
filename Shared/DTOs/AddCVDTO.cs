using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shared.DTOs
{
    public class AddCVDTO
    {
        [Required]
        public string Name { get; set; }

        public AddPersonal_InfoDTO Personal_Info { get; set; }

        public AddExperience_InfoDTO Experience_Info { get; set; }
    }
}
