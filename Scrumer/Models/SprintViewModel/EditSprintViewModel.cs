using Scrumer.Infrastrucutre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Scrumer.Models.UserViewModel;

namespace Scrumer.Models.SprintViewModel
{
    public class EditSprintViewModel
    {
        public int SprintID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ScrumGoal { get; set; }
        public IEnumerable<int> SelectedUsers { get; set; }
        public IEnumerable<UserViewModel.UserViewModel> Users { get; set; }
        public int ProjectID { get; set; }
        public Project Project { get; set; }

    }
}