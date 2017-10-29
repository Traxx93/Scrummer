using Scrumer.Infrastrucutre.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Scrumer.Infrastrucutre.Context
{
    public class ScrumerContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Sprint> Sprints { get; set; }
        public DbSet<Project>
    }
}