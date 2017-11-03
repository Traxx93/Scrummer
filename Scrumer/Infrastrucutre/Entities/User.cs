using Scrumer.Infrastrucutre.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Scrumer.Infrastrucutre.Entities
{
    public class User
    {
        [Key]
        [Required]
        public int UserID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public Role Role { get; set; }
    }
}