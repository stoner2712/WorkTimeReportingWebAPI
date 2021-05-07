using Bogus;
using DiplomaProject.Services.SecurityServiceNS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomaProject.Models
{
    public class DiplomaProjectDbContext : DbContext
    {
        #region Property  
        /// <summary>
        /// Property Declaration
        /// </summary>
        /// <returns></returns>
        //private IConfiguration _config;
        private ISecurityService securityService;
        #endregion

        #region Constructor Injector  
        /// <summary>
        /// Constructor Injection to access all methods or simply DI(Dependency Injection)
        /// Property and Constructor to invoke the appsettings.json Secret JWT Key and its Issuer
        /// </summary>
        public DiplomaProjectDbContext(DbContextOptions options, ISecurityService securityService)    // konstruktor z 1 argumentem i dziedziczy ...
        : base(options)
        {
            this.securityService = securityService;
        }

        public DiplomaProjectDbContext() // czy to musi być? co to robi? - konstruktor bezargumentowy
        {
        }
        #endregion
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
                    UserName = faker.Internet.UserName(),
                    Password = this.securityService.GetHash("zero123"),
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
                    AmountOfHours = faker.Random.Number(1, 8),
                    Comment = faker.Company.CatchPhrase(),
                    EmployeeId = faker.Random.Number(1, totalEmployees),
                    ProjectId = faker.Random.Number(1, totalProjects),
                };
                timeentries.Add(timeentry);
            }
            modelBuilder.Entity<TimeEntry>().HasData(timeentries);
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<EmployeeProject> EmployeeProjects { get; set; }
        public DbSet<TimeEntry> TimeEntries { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
    }
}
