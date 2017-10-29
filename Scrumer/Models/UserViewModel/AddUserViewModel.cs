using Scrumer.Infrastrucutre.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrumer.Models.UserViewModel
{
    public class AddUserViewModel
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Roles Role { get; set; }
    }
}