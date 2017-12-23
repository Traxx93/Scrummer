using Scrumer.Infrastrucutre.Entities;
using System;
using System.Collections.Generic;

namespace Scrumer.Models.SprintViewModel
{
    public class AddSprintViewModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ScrumGoal { get; set; }
        public IEnumerable<UserViewModel.UserViewModel> Users { get; set; }
        public IEnumerable<int> SelectedUsersForSprint { get; set; }
        public Project ProjectID { get; set; }
        public Project Project { get; set; }
    }
}