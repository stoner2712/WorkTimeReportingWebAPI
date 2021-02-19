using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomaProject.Models
{
    public class DiplomaProjectDbContext : DbContext
    {
        public DiplomaProjectDbContext(DbContextOptions options)
        : base(options)
        {
        }

        public DiplomaProjectDbContext() // czy to musi być? co to robi?
        {
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<TimeEntry> TimeEntries { get; set; }
    }
}
