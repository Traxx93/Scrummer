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
        public DbSet<User> Users { get; set; }
        public DbSet<Sprint> Sprints { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<WorkItem> WorkItems { get; set; }
    }
}