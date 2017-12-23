using Scrumer.Infrastrucutre.Entities;
using System;
using Scrumer.Models.UserViewModel;
using System.Collections.Generic;

namespace Scrumer.Models.SprintViewModel
{
    public class SprintViewModel
    {
        public int SprintID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ScrumGoal { get; set; }
        public IEnumerable<User> Users { get; set; }


        public int ProjectID { get; set; }
        public Project Project { get; set; }
    }
}