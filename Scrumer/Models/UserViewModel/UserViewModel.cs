using Scrumer.Infrastrucutre.Enums;

namespace Scrumer.Models.UserViewModel
{
    public class UserViewModel
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }

        public UserViewModel() { }
    }
}