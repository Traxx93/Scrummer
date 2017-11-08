using Scrumer.Infrastrucutre.Entities;
using System.Data.Entity;

namespace Scrumer.Infrastrucutre.Context
{
    public class ScrumerContext : DbContext

    {
        public ScrumerContext() : base() { }

        public DbSet<User> Users { get; set; }
        public DbSet<Sprint> Sprints { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<WorkItem> WorkItems { get; set; }
    }
}