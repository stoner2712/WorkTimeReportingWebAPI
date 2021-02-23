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

            var employees = new List<Employee>();
            //sprawdzenie jak działa Bogus Faker -> wstaw breakpoint przed "for" żeby nie leciało 1000 razy
            for (int i = 0; i < 100; i++)
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
            modelBuilder.Entity<Employee>().HasData(employees);   // Hasdata sprawdza czy jakies dane sa w tabeli, 
                                                                  // jezeli tak, to nic nie bedzie generowane, jezeli nie, to wygeneruje 

            var clients = new List<Client>();
            for (int i = 0; i < 100; i++)
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
            for (int i = 0; i < 100; i++)
            {
                var project = new Project()
                {
                    ProjectId = i + 1,
                    ProjectName = faker.Company.CatchPhrase(),
                    PricePerHour = faker.Finance.Amount(500, 1000, 2),
                    ClientId = faker.Random.Number(1, 100),
                };
                projects.Add(project);
            }
            modelBuilder.Entity<Project>().HasData(projects);


            var timeentries = new List<TimeEntry>();
            for (int i = 0; i < 100; i++)
            {
                var timeentry = new TimeEntry()
                {
                    TimeEntryId = i + 1,
                    Date = faker.Date.Between(new DateTime(2020, 01, 01), new DateTime(2021, 01, 02)),
                    AmountOfHours = faker.Random.Number(0, 60),
                    Comment = faker.Lorem.Sentence(10),
                    EmployeeId = faker.Random.Number(1, 100),
                    ProjectId = faker.Random.Number(1, 100),
                };
                timeentries.Add(timeentry);
            }
            modelBuilder.Entity<TimeEntry>().HasData(timeentries);


            var invoices = new List<Invoice>();
            for (int i = 0; i < 100; i++)
            {
                var invoice = new Invoice()
                {
                    InvoiceId = i + 1,
                    DateFrom = faker.Date.Past(3, new DateTime(2020, 1, 1)), // data z zakresu 3 lat do tyłu począwszy od 1.1.2020
                    DateTo = faker.Date.Past(1, new DateTime(2021, 1, 1)),
                    TotalPrice = faker.Finance.Amount(6500, 99876, 2),
                    ProjectId = faker.Random.Number(1, 100),
                };
                invoices.Add(invoice);
            }
            modelBuilder.Entity<Invoice>().HasData(invoices);

            var employeesProjectsList = new List<EmployeeProject>();
            for (int i = 0; i < 100; i++)
            {
                var ep = new EmployeeProject()
                {
                    EmployeeId = faker.Random.Number(1, 100),
                    ProjectId = faker.Random.Number(1, 100),
                };
                employeesProjectsList.Add(ep);
            }
            modelBuilder.Entity<EmployeeProject>().HasData(employeesProjectsList);
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<EmployeeProject> EmployeeProjects { get; set; }
        public DbSet<TimeEntry> TimeEntries { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
    }
}
