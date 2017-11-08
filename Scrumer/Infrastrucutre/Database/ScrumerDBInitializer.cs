using Scrumer.Infrastrucutre.Context;
using Scrumer.Infrastrucutre.Entities;
using Scrumer.Infrastrucutre.Enums;
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


            context.SaveChanges();
            base.Seed(context);
        }
    }
}