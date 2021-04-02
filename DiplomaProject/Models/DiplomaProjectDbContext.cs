using Bogus;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomaProject.Models
{
    public class DiplomaProjectDbContext : DbContext
    {
        public DiplomaProjectDbContext(DbContextOptions options)    // konstruktor z 1 argumentem i dziedziczy ...
        : base(options)
        {
        }

        public DiplomaProjectDbContext() // czy to musi być? co to robi? - konstruktor bezargumentowy
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeProject>().HasKey(
              ep => new { ep.EmployeeId, ep.ProjectId });  //def kluczy obcych jako PK dla tabeli EmployeeProject

            var faker = new Faker("en");
            const int totalEmployees = 12;
            const int totalClients = 8;
            const int totalProjects = 20;
            const int totalTimeEntries = 400;
            //const int totalInvoices = 5;

            var employees = new List<Employee>();
            //sprawdzenie jak działa Bogus Faker -> wstaw breakpoint przed "for" żeby nie leciało 1000 razy
            for (int i = 0; i < totalEmployees; i++)
            {
                var employee = new Employee()
                {
                    EmployeeId = (i + 1),
                    FirstName = faker.Name.FirstName(),
                    LastName = faker.Name.LastName(),
                    DateOfBirth = faker.Date.Between(new DateTime(1950, 01, 01), new DateTime(1999, 12, 31)),
                    BuildingNumber = faker.Address.BuildingNumber(),
                    StreetName = faker.Address.StreetName(),
                    PostCode = faker.Address.ZipCode(),
                    City = faker.Address.City(),
                    Country = faker.Address.Country(),
                    JobTitle = faker.Name.JobTitle(),
                };
                employees.Add(employee);
            }
            modelBuilder.Entity<Employee>().HasData(employees);   // HasData sprawdza czy jakies dane sa w tabeli, 
                                                                  // jezeli tak, to nic nie bedzie generowane, jezeli nie, to wygeneruje 

            var clients = new List<Client>();
            for (int i = 0; i < totalClients; i++)
            {
                var client = new Client()
                {
                    ClientId = i + 1,
                    ClientName = faker.Company.CompanyName(),
                    BuildingNumber = faker.Address.BuildingNumber(),
                    StreetName = faker.Address.StreetName(),
                    PostCode = faker.Address.ZipCode(),
                    City = faker.Address.City(),
                    Country = faker.Address.Country(),
                };
                clients.Add(client);
            }
            modelBuilder.Entity<Client>().HasData(clients);

            var projects = new List<Project>();
            for (int i = 0; i < totalProjects; i++)
            {
                var project = new Project()
                {
                    ProjectId = i + 1,
                    ProjectName = faker.Company.CatchPhrase(),
                    PricePerHour = faker.Finance.Amount(500, 1000, 2),
                    ClientId = faker.Random.Number(1, totalClients),
                };
                projects.Add(project);
            }
            modelBuilder.Entity<Project>().HasData(projects);

            var employeesProjectsList = new List<EmployeeProject>();
            int tableEntries = 0;
            do
            {
                var employeeProject = new EmployeeProject()
                {
                    EmployeeId = faker.Random.Number(1, totalEmployees),
                    ProjectId = faker.Random.Number(1, totalProjects),
                };
                if (employeesProjectsList.Any(ep => ep.EmployeeId == employeeProject.EmployeeId && ep.ProjectId == employeeProject.ProjectId))
                {
                    //"Entry already exists! Skipping...";
                    continue;
                }

                employeesProjectsList.Add(employeeProject);
                tableEntries++;
            }
            while (tableEntries < 50);
            modelBuilder.Entity<EmployeeProject>().HasData(employeesProjectsList);

            var timeentries = new List<TimeEntry>();
            for (int i = 0; i < totalTimeEntries; i++)
            {
                var timeentry = new TimeEntry()
                {
                    TimeEntryId = i + 1,
                    Date = faker.Date.Between(new DateTime(2020, 01, 01), new DateTime(2021, 01, 02)),
                    AmountOfHours = faker.Random.Number(0, 60),
                    Comment = faker.Lorem.Sentence(10),
                    EmployeeId = faker.Random.Number(1, totalEmployees),
                    ProjectId = faker.Random.Number(1, totalProjects),
                };
                timeentries.Add(timeentry);
            }
            modelBuilder.Entity<TimeEntry>().HasData(timeentries);

            //var invoices = new List<Invoice>();
            //for (int i = 0; i < totalInvoices; i++)
            //{
            //    var invoice = new Invoice()
            //    {
            //        InvoiceId = i + 1,
            //        DateFrom = faker.Date.Past(2, new DateTime(2020, 1, 1)), // data z zakresu 3 lat do tyłu począwszy od 1.1.2020
            //        DateTo = faker.Date.Past(1, new DateTime(2021, 1, 1)),
            //        TotalPrice = faker.Finance.Amount(6500, 99876, 2),
            //        ProjectId = faker.Random.Number(1, totalProjects),
            //    };
            //    invoices.Add(invoice);
            //}
            //modelBuilder.Entity<Invoice>().HasData(invoices);

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<EmployeeProject> EmployeeProjects { get; set; }
        public DbSet<TimeEntry> TimeEntries { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
    }
}
