using Scrumer.Infrastrucutre.Context;
using Scrumer.Infrastrucutre.Entities;
using Scrumer.Infrastrucutre.Enums;
using Scrumer.Models.UserViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Scrumer.Infrastrucutre.Database
{
    public class ScrumerDBInitializer : DropCreateDatabaseAlways<ScrumerContext>
    {
        protected override void Seed(ScrumerContext context)
        {

            var user1 = new User() { FirstName = "Korisnik", LastName = "1", Role = Role.PRODUCT_OWNER };
            var user2 = new User() { FirstName = "Korisnik", LastName = "2", Role = Role.SCRUM_MASTER };
            var user3 = new User() { FirstName = "Korisnik", LastName = "3", Role = Role.TEAM_MEMBER };
            var user4 = new User() { FirstName = "Korisnik", LastName = "4", Role = Role.TEAM_MEMBER };
            var user5 = new User() { FirstName = "Korisnik", LastName = "5", Role = Role.PRODUCT_OWNER };

            context.Users.Add(user1);
            context.Users.Add(user2);
            context.Users.Add(user3);
            context.Users.Add(user4);
            context.Users.Add(user5);

            var users = new List<User>
            {
                user1,
                user2,
                user3
            };

            var project1 = new Project() { Title = "Projekat 1" };
            var project2 = new Project() { Title = "Projekat 2" };
            var project3 = new Project() { Title = "Projekat 3" };


            var scrum1 = new Sprint() { StartDate = DateTime.Parse("12/03/2017"), EndDate = DateTime.Parse("12/31/2017"), Users = users, Project = project1};


            context.SaveChanges();
            base.Seed(context);
        }
    }
}