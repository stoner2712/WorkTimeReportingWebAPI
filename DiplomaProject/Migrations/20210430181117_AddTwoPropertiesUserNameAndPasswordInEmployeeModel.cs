using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DiplomaProject.Migrations
{
    public partial class AddTwoPropertiesUserNameAndPasswordInEmployeeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 1L, 2L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 1L, 10L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 1L, 13L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 1L, 15L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 1L, 17L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2L, 1L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2L, 4L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2L, 6L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2L, 7L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2L, 12L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2L, 16L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3L, 1L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3L, 9L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3L, 13L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4L, 14L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4L, 15L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4L, 18L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5L, 4L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5L, 5L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5L, 12L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5L, 13L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5L, 19L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 6L, 1L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 6L, 2L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 6L, 19L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 8L, 4L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 8L, 16L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 9L, 2L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 9L, 7L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 9L, 8L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 10L, 1L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 10L, 6L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 10L, 9L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 10L, 10L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 10L, 13L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 10L, 14L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 11L, 15L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 11L, 16L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 11L, 17L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 12L, 2L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 12L, 3L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 12L, 7L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 12L, 20L });

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Employee",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Employee",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 1L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "1749", "Lake Malachi", "McGlynn and Sons", "Comoros", "48608", "Lesch Green" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 2L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "109", "Kihnstad", "Simonis - Klein", "Tuvalu", "33514-2878", "Carroll Rue" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 3L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "9300", "West Katharinastad", "Yundt, Roob and Rogahn", "Netherlands", "80749-6730", "Gisselle Shores" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 4L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "25912", "Giovanimouth", "Boyer, Shields and Hettinger", "Zimbabwe", "92813", "Flo Field" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 5L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "668", "Eleazarhaven", "Spinka - Rolfson", "Turkmenistan", "79201", "Clinton Wells" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 6L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "4382", "Port Eda", "Ferry - Nicolas", "Finland", "90454", "Charlene Wall" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 7L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "0089", "North Alexanefort", "Barton, Hessel and Weissnat", "Sri Lanka", "51223-2851", "Hammes Mills" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 8L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "5652", "Annastad", "Luettgen, Rippin and Carter", "Gibraltar", "84336", "Kade Stravenue" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "Password", "PostCode", "StreetName", "UserName" },
                values: new object[] { "31420", "South Esperanza", "Ireland", new DateTime(1990, 12, 20, 5, 46, 52, 103, DateTimeKind.Unspecified).AddTicks(2170), "Ike", "Legacy Solutions Manager", "Welch", "zero123", "83246", "O'Kon Union", "Yolanda63" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "Password", "PostCode", "StreetName", "UserName" },
                values: new object[] { "082", "Manteshire", "Guatemala", new DateTime(1989, 2, 22, 21, 45, 41, 841, DateTimeKind.Unspecified).AddTicks(486), "Sydney", "Human Paradigm Liaison", "Sporer", "zero123", "50617", "Selena Mews", "Jakayla.Predovic67" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "Password", "PostCode", "StreetName", "UserName" },
                values: new object[] { "6148", "Krisfurt", "Brunei Darussalam", new DateTime(1994, 12, 28, 17, 16, 3, 559, DateTimeKind.Unspecified).AddTicks(4912), "Reba", "Forward Mobility Consultant", "Walker", "zero123", "50979-1731", "Cassin Neck", "Libbie21" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "Password", "PostCode", "StreetName", "UserName" },
                values: new object[] { "9054", "Avashire", "Jersey", new DateTime(1969, 7, 15, 2, 37, 48, 683, DateTimeKind.Unspecified).AddTicks(654), "Amy", "Future Response Agent", "Medhurst", "zero123", "28429-5245", "Rice Heights", "Kylee51" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "Password", "PostCode", "StreetName", "UserName" },
                values: new object[] { "648", "New William", "Guatemala", new DateTime(1985, 6, 30, 0, 1, 11, 938, DateTimeKind.Unspecified).AddTicks(6160), "Victor", "Central Division Associate", "Balistreri", "zero123", "35833-3480", "McCullough Harbors", "Geovanni9" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "Password", "PostCode", "StreetName", "UserName" },
                values: new object[] { "05547", "Tatemouth", "Denmark", new DateTime(1981, 10, 22, 19, 30, 28, 791, DateTimeKind.Unspecified).AddTicks(4276), "Isadore", "Investor Functionality Associate", "Fay", "zero123", "74589", "Sasha Fields", "Mose.Sawayn5" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 7L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "Password", "PostCode", "StreetName", "UserName" },
                values: new object[] { "59321", "Aufderharport", "Tanzania", new DateTime(1994, 4, 26, 2, 8, 15, 982, DateTimeKind.Unspecified).AddTicks(8428), "Arvel", "Internal Marketing Liaison", "Becker", "zero123", "31872", "Roberto Turnpike", "Ferne40" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 8L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "Password", "PostCode", "StreetName", "UserName" },
                values: new object[] { "06399", "Kunzebury", "Falkland Islands (Malvinas)", new DateTime(1953, 4, 20, 9, 5, 4, 884, DateTimeKind.Unspecified).AddTicks(988), "Clark", "Senior Branding Engineer", "Ritchie", "zero123", "67703", "Orin Court", "Elmore.Emmerich" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 9L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "Password", "PostCode", "StreetName", "UserName" },
                values: new object[] { "894", "North Abbigail", "Greece", new DateTime(1985, 12, 7, 5, 3, 38, 378, DateTimeKind.Unspecified).AddTicks(6000), "Bartholome", "Direct Metrics Agent", "Gleason", "zero123", "78770-9110", "McKenzie Landing", "Sim73" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 10L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "Password", "PostCode", "StreetName", "UserName" },
                values: new object[] { "204", "Aftonland", "Fiji", new DateTime(1962, 8, 22, 7, 49, 34, 105, DateTimeKind.Unspecified).AddTicks(8958), "Henderson", "Principal Functionality Coordinator", "Boyer", "zero123", "48175-4263", "Mohammad Ford", "Margarette13" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 11L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "Password", "PostCode", "StreetName", "UserName" },
                values: new object[] { "66959", "Houstonbury", "Uruguay", new DateTime(1964, 7, 12, 14, 15, 36, 230, DateTimeKind.Unspecified).AddTicks(1231), "Frederik", "Principal Interactions Strategist", "Lebsack", "zero123", "57114-4437", "Murray Lodge", "Kathryn82" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 12L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "Password", "PostCode", "StreetName", "UserName" },
                values: new object[] { "8095", "New Ozella", "Swaziland", new DateTime(1995, 3, 4, 7, 50, 2, 157, DateTimeKind.Unspecified).AddTicks(5642), "Gwen", "Human Assurance Orchestrator", "Marquardt", "zero123", "52721-2146", "Rath Summit", "Margarett_Thiel" });

            migrationBuilder.InsertData(
                table: "EmployeeProject",
                columns: new[] { "EmployeeId", "ProjectId" },
                values: new object[,]
                {
                    { 2L, 19L },
                    { 8L, 3L },
                    { 11L, 13L },
                    { 11L, 4L },
                    { 3L, 5L },
                    { 7L, 13L },
                    { 6L, 5L },
                    { 7L, 6L },
                    { 1L, 11L },
                    { 4L, 7L },
                    { 10L, 17L },
                    { 4L, 17L },
                    { 6L, 9L },
                    { 3L, 10L },
                    { 12L, 10L },
                    { 2L, 11L },
                    { 7L, 7L },
                    { 7L, 14L },
                    { 5L, 7L },
                    { 12L, 1L },
                    { 12L, 16L },
                    { 3L, 6L },
                    { 3L, 7L },
                    { 7L, 3L },
                    { 4L, 19L },
                    { 1L, 4L },
                    { 11L, 1L },
                    { 5L, 3L },
                    { 6L, 13L },
                    { 3L, 4L },
                    { 2L, 13L },
                    { 2L, 2L },
                    { 9L, 19L },
                    { 8L, 18L },
                    { 8L, 12L },
                    { 11L, 11L },
                    { 12L, 18L },
                    { 6L, 17L },
                    { 7L, 19L },
                    { 1L, 8L },
                    { 5L, 8L },
                    { 2L, 3L },
                    { 9L, 4L }
                });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 4L, 831.44m, "Fully-configurable client-driven application" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 8L, 670.40m, "Re-contextualized optimizing access" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 3L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 2L, 625.29m, "Stand-alone client-driven contingency" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 4L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 8L, 607.89m, "Realigned user-facing support" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 5L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 8L, 768.86m, "Up-sized user-facing portal" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 6L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 3L, 841.66m, "Automated asynchronous secured line" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 7L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 2L, 724.62m, "Focused optimizing database" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 8L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 8L, 590.88m, "Organic actuating paradigm" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 9L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 8L, 812.22m, "Streamlined client-server task-force" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 10L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 5L, 563.96m, "Devolved methodical conglomeration" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 11L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 4L, 830.74m, "Realigned solution-oriented solution" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 12L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 4L, 880.87m, "Innovative global interface" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 13L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 5L, 989.84m, "Proactive user-facing flexibility" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 14L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 6L, 504.46m, "Centralized upward-trending product" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 15L,
                columns: new[] { "PricePerHour", "ProjectName" },
                values: new object[] { 658.28m, "Profound context-sensitive parallelism" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 16L,
                columns: new[] { "PricePerHour", "ProjectName" },
                values: new object[] { 770.58m, "Reduced zero tolerance attitude" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 17L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 6L, 531.60m, "Mandatory system-worthy open architecture" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 18L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 7L, 524.00m, "Multi-layered tertiary matrices" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 19L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 3L, 902.33m, "Cross-platform interactive time-frame" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 20L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 8L, 507.03m, "Triple-buffered systematic time-frame" });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 1L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Integrated disintermediate encryption", new DateTime(2020, 8, 10, 22, 24, 18, 550, DateTimeKind.Unspecified).AddTicks(2300), 11L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 2L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 8m, "Multi-layered uniform website", new DateTime(2020, 12, 15, 23, 53, 32, 822, DateTimeKind.Unspecified).AddTicks(5384), 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 3L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Switchable upward-trending definition", new DateTime(2020, 10, 28, 20, 15, 11, 559, DateTimeKind.Unspecified).AddTicks(137), 7L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 4L,
                columns: new[] { "Comment", "Date", "ProjectId" },
                values: new object[] { "Open-source attitude-oriented focus group", new DateTime(2020, 9, 15, 11, 55, 4, 623, DateTimeKind.Unspecified).AddTicks(4286), 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 5L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Team-oriented 24 hour attitude", new DateTime(2020, 2, 4, 5, 56, 12, 799, DateTimeKind.Unspecified).AddTicks(2709), 12L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 6L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Triple-buffered value-added adapter", new DateTime(2020, 9, 28, 13, 4, 47, 765, DateTimeKind.Unspecified).AddTicks(4161), 1L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 7L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Enhanced methodical portal", new DateTime(2020, 9, 21, 10, 14, 24, 306, DateTimeKind.Unspecified).AddTicks(1184), 5L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 8L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Networked bifurcated internet solution", new DateTime(2020, 12, 22, 8, 4, 8, 625, DateTimeKind.Unspecified).AddTicks(1117), 12L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 9L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Distributed web-enabled superstructure", new DateTime(2020, 1, 17, 23, 34, 13, 671, DateTimeKind.Unspecified).AddTicks(5932), 8L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 10L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Universal system-worthy infrastructure", new DateTime(2020, 1, 1, 1, 59, 15, 700, DateTimeKind.Unspecified).AddTicks(7599), 1L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 11L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Virtual dedicated instruction set", new DateTime(2020, 3, 31, 8, 22, 51, 118, DateTimeKind.Unspecified).AddTicks(783), 1L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 12L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Networked methodical moderator", new DateTime(2020, 7, 30, 23, 49, 50, 584, DateTimeKind.Unspecified).AddTicks(6772), 10L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 13L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Synchronised logistical adapter", new DateTime(2020, 2, 13, 14, 29, 4, 364, DateTimeKind.Unspecified).AddTicks(7866), 1L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 14L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Vision-oriented bandwidth-monitored hub", new DateTime(2020, 5, 10, 22, 32, 37, 157, DateTimeKind.Unspecified).AddTicks(6645), 1L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 15L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Re-engineered demand-driven data-warehouse", new DateTime(2020, 7, 20, 12, 52, 12, 780, DateTimeKind.Unspecified).AddTicks(6152), 8L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 16L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 5m, "Total 24/7 task-force", new DateTime(2020, 10, 31, 10, 12, 29, 708, DateTimeKind.Unspecified).AddTicks(2285), 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 17L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Grass-roots dedicated projection", new DateTime(2020, 7, 26, 21, 35, 25, 315, DateTimeKind.Unspecified).AddTicks(2837), 9L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 18L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Face to face high-level algorithm", new DateTime(2020, 3, 18, 7, 4, 31, 181, DateTimeKind.Unspecified).AddTicks(4686), 5L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 19L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Customer-focused actuating toolset", new DateTime(2020, 3, 26, 13, 24, 36, 432, DateTimeKind.Unspecified).AddTicks(8779), 4L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 20L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Future-proofed exuding challenge", new DateTime(2020, 12, 25, 6, 33, 46, 58, DateTimeKind.Unspecified).AddTicks(620), 5L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 21L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Organic asymmetric attitude", new DateTime(2020, 11, 11, 6, 55, 36, 183, DateTimeKind.Unspecified).AddTicks(7667), 3L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 22L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Synergistic multimedia firmware", new DateTime(2020, 1, 6, 20, 54, 8, 554, DateTimeKind.Unspecified).AddTicks(3452), 11L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 23L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Secured contextually-based customer loyalty", new DateTime(2020, 4, 5, 3, 41, 51, 883, DateTimeKind.Unspecified).AddTicks(7061), 11L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 24L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "User-friendly zero administration monitoring", new DateTime(2020, 7, 17, 14, 14, 3, 898, DateTimeKind.Unspecified).AddTicks(1757), 6L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 25L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Synergized motivating focus group", new DateTime(2020, 12, 5, 11, 57, 57, 433, DateTimeKind.Unspecified).AddTicks(6360), 8L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 26L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Implemented uniform challenge", new DateTime(2020, 2, 7, 11, 58, 13, 216, DateTimeKind.Unspecified).AddTicks(86), 2L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 27L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Inverse motivating hardware", new DateTime(2020, 5, 7, 10, 4, 30, 536, DateTimeKind.Unspecified).AddTicks(537), 9L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 28L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Customizable upward-trending knowledge base", new DateTime(2020, 4, 29, 16, 33, 29, 994, DateTimeKind.Unspecified).AddTicks(5838), 9L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 29L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Cross-group high-level productivity", new DateTime(2020, 3, 11, 18, 20, 53, 727, DateTimeKind.Unspecified).AddTicks(6501), 3L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 30L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 8m, "Advanced zero defect customer loyalty", new DateTime(2020, 8, 16, 19, 20, 22, 128, DateTimeKind.Unspecified).AddTicks(2926), 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 31L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Fully-configurable asymmetric policy", new DateTime(2020, 9, 20, 15, 33, 9, 739, DateTimeKind.Unspecified).AddTicks(3040), 5L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 32L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Fundamental contextually-based pricing structure", new DateTime(2020, 7, 2, 17, 18, 28, 104, DateTimeKind.Unspecified).AddTicks(6335), 11L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 33L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Reactive reciprocal superstructure", new DateTime(2020, 6, 19, 1, 35, 3, 826, DateTimeKind.Unspecified).AddTicks(3169), 1L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 34L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Multi-channelled exuding superstructure", new DateTime(2020, 2, 13, 20, 37, 6, 452, DateTimeKind.Unspecified).AddTicks(6668), 2L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 35L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 4m, "Profound client-driven orchestration", new DateTime(2020, 4, 10, 22, 6, 34, 656, DateTimeKind.Unspecified).AddTicks(7444), 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 36L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Switchable solution-oriented extranet", new DateTime(2020, 2, 18, 5, 36, 0, 264, DateTimeKind.Unspecified).AddTicks(6281), 2L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 37L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Enterprise-wide 4th generation flexibility", new DateTime(2020, 1, 22, 10, 15, 28, 494, DateTimeKind.Unspecified).AddTicks(9877), 6L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 38L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Diverse even-keeled time-frame", new DateTime(2020, 4, 4, 19, 14, 1, 820, DateTimeKind.Unspecified).AddTicks(4377), 3L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 39L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Reactive stable database", new DateTime(2020, 2, 26, 18, 2, 20, 686, DateTimeKind.Unspecified).AddTicks(4931), 6L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 40L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Balanced 5th generation encryption", new DateTime(2020, 2, 22, 12, 50, 42, 13, DateTimeKind.Unspecified).AddTicks(3746), 12L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 41L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "User-friendly maximized support", new DateTime(2020, 11, 24, 13, 4, 5, 720, DateTimeKind.Unspecified).AddTicks(4218), 3L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 42L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Future-proofed leading edge migration", new DateTime(2020, 6, 24, 11, 37, 43, 290, DateTimeKind.Unspecified).AddTicks(5127), 7L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 43L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Streamlined optimizing extranet", new DateTime(2020, 2, 7, 13, 59, 47, 506, DateTimeKind.Unspecified).AddTicks(3207), 1L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 44L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Visionary actuating monitoring", new DateTime(2020, 12, 24, 21, 51, 31, 899, DateTimeKind.Unspecified).AddTicks(4197), 6L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 45L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Visionary 3rd generation installation", new DateTime(2020, 2, 10, 13, 30, 28, 895, DateTimeKind.Unspecified).AddTicks(178), 10L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 46L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Right-sized 5th generation algorithm", new DateTime(2020, 6, 10, 7, 21, 44, 274, DateTimeKind.Unspecified).AddTicks(349), 7L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 47L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Extended mobile support", new DateTime(2020, 8, 20, 14, 59, 28, 414, DateTimeKind.Unspecified).AddTicks(5195), 3L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 48L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 2m, "Focused zero tolerance website", new DateTime(2020, 3, 22, 16, 44, 18, 941, DateTimeKind.Unspecified).AddTicks(139), 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 49L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 8m, "Open-source dedicated pricing structure", new DateTime(2020, 9, 18, 19, 41, 32, 607, DateTimeKind.Unspecified).AddTicks(2197), 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 50L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Operative bi-directional policy", new DateTime(2020, 1, 17, 8, 54, 41, 144, DateTimeKind.Unspecified).AddTicks(4521), 8L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 51L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Reactive directional implementation", new DateTime(2020, 3, 13, 15, 46, 17, 749, DateTimeKind.Unspecified).AddTicks(1119), 4L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 52L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Monitored optimizing database", new DateTime(2020, 10, 17, 16, 39, 38, 151, DateTimeKind.Unspecified).AddTicks(5088), 11L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 53L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Assimilated incremental info-mediaries", new DateTime(2020, 12, 16, 20, 24, 22, 242, DateTimeKind.Unspecified).AddTicks(4885), 6L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 54L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Seamless directional functionalities", new DateTime(2020, 4, 15, 10, 10, 59, 752, DateTimeKind.Unspecified).AddTicks(3696), 4L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 55L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Multi-tiered client-driven knowledge user", new DateTime(2021, 1, 1, 13, 21, 19, 383, DateTimeKind.Unspecified).AddTicks(4538), 5L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 56L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Reactive impactful analyzer", new DateTime(2020, 2, 26, 18, 0, 22, 458, DateTimeKind.Unspecified).AddTicks(6491), 7L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 57L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Object-based human-resource definition", new DateTime(2020, 4, 4, 20, 19, 34, 642, DateTimeKind.Unspecified).AddTicks(2781), 6L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 58L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 4m, "Polarised demand-driven concept", new DateTime(2020, 9, 1, 21, 43, 35, 739, DateTimeKind.Unspecified).AddTicks(7411), 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 59L,
                columns: new[] { "Comment", "Date", "ProjectId" },
                values: new object[] { "Adaptive asymmetric workforce", new DateTime(2020, 10, 31, 21, 2, 48, 573, DateTimeKind.Unspecified).AddTicks(3716), 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 60L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Organized neutral initiative", new DateTime(2020, 12, 18, 16, 10, 54, 170, DateTimeKind.Unspecified).AddTicks(4345), 11L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 61L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Adaptive full-range strategy", new DateTime(2020, 2, 5, 17, 48, 55, 264, DateTimeKind.Unspecified).AddTicks(4280), 10L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 62L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Seamless bandwidth-monitored service-desk", new DateTime(2020, 2, 26, 16, 49, 13, 823, DateTimeKind.Unspecified).AddTicks(6632), 7L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 63L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Triple-buffered even-keeled help-desk", new DateTime(2020, 4, 3, 4, 38, 46, 333, DateTimeKind.Unspecified).AddTicks(3428), 2L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 64L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Mandatory actuating secured line", new DateTime(2020, 9, 4, 18, 5, 32, 814, DateTimeKind.Unspecified).AddTicks(6001), 2L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 65L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Secured reciprocal middleware", new DateTime(2020, 2, 16, 10, 16, 7, 387, DateTimeKind.Unspecified).AddTicks(8365), 4L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 66L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Switchable empowering benchmark", new DateTime(2020, 2, 28, 15, 26, 56, 985, DateTimeKind.Unspecified).AddTicks(6628), 11L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 67L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "User-friendly clear-thinking database", new DateTime(2020, 8, 21, 20, 18, 15, 750, DateTimeKind.Unspecified).AddTicks(1290), 6L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 68L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Grass-roots 6th generation portal", new DateTime(2020, 2, 1, 12, 23, 24, 109, DateTimeKind.Unspecified).AddTicks(11), 6L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 69L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Grass-roots 6th generation neural-net", new DateTime(2020, 8, 19, 12, 30, 7, 595, DateTimeKind.Unspecified).AddTicks(6077), 9L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 70L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Future-proofed composite conglomeration", new DateTime(2020, 5, 7, 18, 35, 28, 520, DateTimeKind.Unspecified).AddTicks(6123), 10L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 71L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Advanced dynamic core", new DateTime(2020, 4, 6, 11, 29, 6, 100, DateTimeKind.Unspecified).AddTicks(8011), 8L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 72L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Triple-buffered leading edge moratorium", new DateTime(2020, 6, 27, 0, 36, 0, 953, DateTimeKind.Unspecified).AddTicks(5987), 8L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 73L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Realigned systemic protocol", new DateTime(2020, 4, 6, 17, 39, 6, 298, DateTimeKind.Unspecified).AddTicks(4008), 2L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 74L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Face to face heuristic capability", new DateTime(2020, 1, 12, 21, 9, 15, 669, DateTimeKind.Unspecified).AddTicks(5622), 8L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 75L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "User-centric 5th generation open system", new DateTime(2020, 3, 21, 20, 54, 22, 833, DateTimeKind.Unspecified).AddTicks(7287), 8L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 76L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Reduced incremental service-desk", new DateTime(2020, 8, 9, 22, 28, 45, 542, DateTimeKind.Unspecified).AddTicks(2641), 5L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 77L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Networked 24/7 budgetary management", new DateTime(2020, 2, 7, 10, 40, 9, 565, DateTimeKind.Unspecified).AddTicks(4100), 12L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 78L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Future-proofed foreground methodology", new DateTime(2020, 7, 24, 18, 59, 26, 890, DateTimeKind.Unspecified).AddTicks(5219), 7L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 79L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Synchronised asymmetric workforce", new DateTime(2020, 7, 29, 11, 27, 29, 903, DateTimeKind.Unspecified).AddTicks(529), 9L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 80L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Open-source well-modulated utilisation", new DateTime(2020, 11, 11, 16, 54, 49, 467, DateTimeKind.Unspecified).AddTicks(5076), 3L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 81L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Future-proofed zero administration process improvement", new DateTime(2020, 2, 4, 9, 55, 52, 801, DateTimeKind.Unspecified).AddTicks(5855), 5L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 82L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Monitored 24 hour monitoring", new DateTime(2020, 1, 14, 8, 57, 4, 979, DateTimeKind.Unspecified).AddTicks(2786), 3L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 83L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 5m, "Proactive asymmetric alliance", new DateTime(2020, 12, 28, 1, 8, 30, 147, DateTimeKind.Unspecified).AddTicks(2918), 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 84L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Mandatory solution-oriented model", new DateTime(2020, 8, 11, 22, 41, 29, 155, DateTimeKind.Unspecified).AddTicks(6643), 11L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 85L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Automated clear-thinking product", new DateTime(2020, 7, 3, 7, 13, 0, 84, DateTimeKind.Unspecified).AddTicks(5625), 6L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 86L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 8m, "Managed static circuit", new DateTime(2020, 8, 27, 21, 31, 15, 562, DateTimeKind.Unspecified).AddTicks(7859), 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 87L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Centralized encompassing intranet", new DateTime(2020, 12, 11, 13, 16, 49, 65, DateTimeKind.Unspecified).AddTicks(3061), 8L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 88L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Synergized upward-trending migration", new DateTime(2020, 5, 7, 11, 41, 19, 278, DateTimeKind.Unspecified).AddTicks(759), 8L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 89L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Customizable bandwidth-monitored installation", new DateTime(2020, 1, 30, 12, 5, 19, 64, DateTimeKind.Unspecified).AddTicks(1114), 9L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 90L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Switchable tertiary product", new DateTime(2020, 10, 29, 3, 14, 9, 276, DateTimeKind.Unspecified).AddTicks(3082), 3L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 91L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Enterprise-wide systemic encoding", new DateTime(2020, 8, 11, 4, 21, 7, 62, DateTimeKind.Unspecified).AddTicks(7652), 6L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 92L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Networked asynchronous definition", new DateTime(2020, 6, 26, 7, 42, 42, 458, DateTimeKind.Unspecified).AddTicks(3195), 5L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 93L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Enterprise-wide bifurcated projection", new DateTime(2020, 1, 30, 18, 27, 58, 757, DateTimeKind.Unspecified).AddTicks(8535), 12L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 94L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Re-contextualized national methodology", new DateTime(2020, 1, 31, 2, 42, 56, 257, DateTimeKind.Unspecified).AddTicks(4584), 1L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 95L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Monitored real-time groupware", new DateTime(2020, 1, 4, 9, 10, 21, 135, DateTimeKind.Unspecified).AddTicks(2100), 7L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 96L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Business-focused empowering benchmark", new DateTime(2020, 9, 3, 17, 33, 52, 118, DateTimeKind.Unspecified).AddTicks(9743), 10L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 97L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 6m, "Assimilated context-sensitive firmware", new DateTime(2020, 7, 20, 18, 45, 54, 272, DateTimeKind.Unspecified).AddTicks(5594), 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 98L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Reduced zero defect concept", new DateTime(2020, 3, 27, 6, 40, 28, 959, DateTimeKind.Unspecified).AddTicks(5984), 10L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 99L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Digitized national initiative", new DateTime(2020, 12, 10, 21, 33, 13, 933, DateTimeKind.Unspecified).AddTicks(9001), 7L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 100L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Function-based systemic service-desk", new DateTime(2020, 2, 20, 19, 48, 19, 954, DateTimeKind.Unspecified).AddTicks(6785), 5L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 101L,
                columns: new[] { "AmountOfHours", "Comment", "Date" },
                values: new object[] { 2m, "Sharable multi-tasking challenge", new DateTime(2020, 7, 10, 4, 36, 3, 74, DateTimeKind.Unspecified).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 102L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Multi-channelled discrete middleware", new DateTime(2020, 8, 14, 1, 49, 18, 819, DateTimeKind.Unspecified).AddTicks(8290), 5L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 103L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Seamless cohesive productivity", new DateTime(2020, 8, 12, 21, 11, 51, 286, DateTimeKind.Unspecified).AddTicks(3002), 3L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 104L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Profound motivating data-warehouse", new DateTime(2020, 2, 18, 6, 14, 8, 586, DateTimeKind.Unspecified).AddTicks(9184), 2L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 105L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Horizontal human-resource toolset", new DateTime(2020, 8, 13, 3, 52, 48, 356, DateTimeKind.Unspecified).AddTicks(5086), 4L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 106L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Fully-configurable 5th generation productivity", new DateTime(2020, 6, 11, 18, 4, 48, 188, DateTimeKind.Unspecified).AddTicks(8916), 12L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 107L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Innovative systemic circuit", new DateTime(2020, 10, 30, 3, 13, 29, 851, DateTimeKind.Unspecified).AddTicks(945), 9L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 108L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Programmable 5th generation concept", new DateTime(2020, 5, 6, 2, 5, 0, 565, DateTimeKind.Unspecified).AddTicks(8378), 9L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 109L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Ameliorated transitional solution", new DateTime(2020, 4, 16, 18, 34, 12, 0, DateTimeKind.Unspecified).AddTicks(4479), 2L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 110L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Secured multi-state alliance", new DateTime(2020, 12, 23, 23, 28, 32, 115, DateTimeKind.Unspecified).AddTicks(4493), 1L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 111L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "De-engineered zero tolerance conglomeration", new DateTime(2020, 10, 8, 2, 22, 49, 987, DateTimeKind.Unspecified).AddTicks(4366), 5L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 112L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Robust asynchronous hardware", new DateTime(2020, 2, 23, 16, 13, 32, 717, DateTimeKind.Unspecified).AddTicks(5126), 11L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 113L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Monitored radical monitoring", new DateTime(2020, 3, 3, 16, 12, 41, 588, DateTimeKind.Unspecified).AddTicks(6409), 4L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 114L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Customer-focused user-facing strategy", new DateTime(2020, 10, 11, 12, 48, 5, 94, DateTimeKind.Unspecified).AddTicks(8533), 4L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 115L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Diverse bi-directional model", new DateTime(2020, 8, 23, 7, 29, 49, 989, DateTimeKind.Unspecified).AddTicks(4050), 5L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 116L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Automated zero defect data-warehouse", new DateTime(2020, 1, 27, 3, 52, 6, 492, DateTimeKind.Unspecified).AddTicks(806), 2L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 117L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 2m, "Sharable global core", new DateTime(2020, 11, 25, 4, 45, 18, 556, DateTimeKind.Unspecified).AddTicks(1200), 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 118L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Total exuding policy", new DateTime(2020, 5, 22, 13, 46, 48, 500, DateTimeKind.Unspecified).AddTicks(4874), 1L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 119L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Business-focused encompassing archive", new DateTime(2020, 3, 5, 10, 9, 41, 838, DateTimeKind.Unspecified).AddTicks(467), 6L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 120L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "User-friendly regional internet solution", new DateTime(2020, 9, 3, 5, 1, 49, 746, DateTimeKind.Unspecified).AddTicks(9220), 9L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 121L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 4m, "Robust fault-tolerant customer loyalty", new DateTime(2020, 3, 16, 2, 29, 52, 20, DateTimeKind.Unspecified).AddTicks(7945), 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 122L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Object-based motivating matrices", new DateTime(2020, 1, 17, 13, 57, 57, 748, DateTimeKind.Unspecified).AddTicks(8794), 1L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 123L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Reduced transitional focus group", new DateTime(2020, 3, 29, 13, 22, 23, 819, DateTimeKind.Unspecified).AddTicks(8776), 8L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 124L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Proactive client-server migration", new DateTime(2020, 6, 22, 7, 27, 29, 227, DateTimeKind.Unspecified).AddTicks(8269), 8L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 125L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Profit-focused next generation alliance", new DateTime(2020, 9, 7, 13, 16, 14, 595, DateTimeKind.Unspecified).AddTicks(2054), 9L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 126L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Vision-oriented human-resource ability", new DateTime(2020, 12, 15, 0, 24, 25, 251, DateTimeKind.Unspecified).AddTicks(8801), 2L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 127L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Reactive hybrid groupware", new DateTime(2020, 9, 14, 16, 57, 54, 16, DateTimeKind.Unspecified).AddTicks(943), 4L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 128L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Synergized coherent artificial intelligence", new DateTime(2020, 4, 3, 14, 29, 32, 493, DateTimeKind.Unspecified).AddTicks(9038), 3L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 129L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Diverse mission-critical framework", new DateTime(2020, 6, 2, 13, 52, 52, 798, DateTimeKind.Unspecified).AddTicks(3305), 8L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 130L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Upgradable intermediate focus group", new DateTime(2020, 6, 21, 2, 53, 4, 654, DateTimeKind.Unspecified).AddTicks(3599), 1L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 131L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Intuitive empowering info-mediaries", new DateTime(2020, 3, 11, 3, 37, 23, 770, DateTimeKind.Unspecified).AddTicks(2940), 10L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 132L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Public-key context-sensitive functionalities", new DateTime(2020, 6, 1, 9, 42, 6, 294, DateTimeKind.Unspecified).AddTicks(5412), 10L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 133L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Open-architected user-facing installation", new DateTime(2020, 8, 23, 4, 2, 33, 917, DateTimeKind.Unspecified).AddTicks(4446), 6L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 134L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Team-oriented motivating hub", new DateTime(2020, 12, 24, 18, 5, 7, 834, DateTimeKind.Unspecified).AddTicks(6511), 10L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 135L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "User-friendly actuating collaboration", new DateTime(2020, 9, 17, 13, 10, 19, 855, DateTimeKind.Unspecified).AddTicks(7091), 2L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 136L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Synchronised modular help-desk", new DateTime(2020, 6, 19, 11, 14, 35, 156, DateTimeKind.Unspecified).AddTicks(4602), 12L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 137L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 5m, "Integrated zero defect solution", new DateTime(2020, 3, 19, 13, 59, 59, 713, DateTimeKind.Unspecified).AddTicks(8988), 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 138L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Polarised stable middleware", new DateTime(2020, 2, 2, 17, 17, 0, 27, DateTimeKind.Unspecified).AddTicks(585), 10L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 139L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Quality-focused 24/7 workforce", new DateTime(2020, 12, 19, 2, 21, 38, 910, DateTimeKind.Unspecified).AddTicks(6143), 7L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 140L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Decentralized cohesive monitoring", new DateTime(2020, 2, 25, 4, 54, 15, 751, DateTimeKind.Unspecified).AddTicks(5972), 5L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 141L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Front-line actuating infrastructure", new DateTime(2020, 4, 19, 3, 13, 53, 288, DateTimeKind.Unspecified).AddTicks(9075), 7L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 142L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 4m, "Profound mission-critical service-desk", new DateTime(2020, 4, 5, 0, 52, 4, 281, DateTimeKind.Unspecified).AddTicks(7878), 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 143L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Enhanced local function", new DateTime(2020, 5, 13, 1, 30, 38, 429, DateTimeKind.Unspecified).AddTicks(35), 11L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 144L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Polarised grid-enabled hardware", new DateTime(2020, 12, 11, 18, 17, 36, 227, DateTimeKind.Unspecified).AddTicks(4942), 4L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 145L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Robust cohesive local area network", new DateTime(2020, 10, 19, 10, 55, 41, 964, DateTimeKind.Unspecified).AddTicks(545), 8L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 146L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Robust bandwidth-monitored contingency", new DateTime(2020, 10, 4, 18, 12, 48, 909, DateTimeKind.Unspecified).AddTicks(9617), 6L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 147L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Intuitive clear-thinking benchmark", new DateTime(2020, 1, 14, 5, 17, 11, 950, DateTimeKind.Unspecified).AddTicks(8522), 2L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 148L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Proactive didactic instruction set", new DateTime(2020, 5, 24, 20, 17, 33, 255, DateTimeKind.Unspecified).AddTicks(3283), 9L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 149L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Pre-emptive actuating core", new DateTime(2020, 6, 28, 14, 16, 34, 12, DateTimeKind.Unspecified).AddTicks(2680), 9L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 150L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Intuitive demand-driven pricing structure", new DateTime(2020, 4, 2, 2, 18, 57, 428, DateTimeKind.Unspecified).AddTicks(8911), 10L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 151L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Mandatory bottom-line Graphic Interface", new DateTime(2020, 1, 10, 20, 55, 44, 496, DateTimeKind.Unspecified).AddTicks(2912), 10L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 152L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Extended discrete conglomeration", new DateTime(2020, 2, 20, 16, 22, 59, 364, DateTimeKind.Unspecified).AddTicks(1678), 4L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 153L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Up-sized 6th generation utilisation", new DateTime(2020, 4, 26, 10, 39, 57, 262, DateTimeKind.Unspecified).AddTicks(1173), 6L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 154L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Business-focused zero tolerance pricing structure", new DateTime(2020, 8, 16, 4, 6, 20, 591, DateTimeKind.Unspecified).AddTicks(7332), 3L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 155L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Triple-buffered exuding database", new DateTime(2020, 2, 24, 9, 34, 35, 719, DateTimeKind.Unspecified).AddTicks(6766), 3L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 156L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Cross-platform background strategy", new DateTime(2020, 6, 21, 14, 21, 40, 184, DateTimeKind.Unspecified).AddTicks(3350), 6L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 157L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Right-sized 24/7 hardware", new DateTime(2020, 6, 25, 17, 7, 35, 696, DateTimeKind.Unspecified).AddTicks(5042), 1L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 158L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Diverse reciprocal functionalities", new DateTime(2020, 9, 29, 11, 45, 6, 897, DateTimeKind.Unspecified).AddTicks(1995), 5L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 159L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Decentralized multimedia knowledge base", new DateTime(2020, 4, 19, 11, 44, 16, 722, DateTimeKind.Unspecified).AddTicks(542), 2L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 160L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Universal web-enabled archive", new DateTime(2020, 3, 15, 9, 14, 2, 78, DateTimeKind.Unspecified).AddTicks(471), 1L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 161L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "User-centric attitude-oriented website", new DateTime(2020, 12, 10, 23, 31, 17, 283, DateTimeKind.Unspecified).AddTicks(4129), 11L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 162L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Virtual eco-centric circuit", new DateTime(2020, 10, 23, 16, 42, 52, 459, DateTimeKind.Unspecified).AddTicks(2862), 11L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 163L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Phased systemic software", new DateTime(2020, 7, 9, 20, 0, 53, 71, DateTimeKind.Unspecified).AddTicks(1733), 12L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 164L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Multi-lateral dynamic flexibility", new DateTime(2020, 10, 30, 10, 47, 55, 640, DateTimeKind.Unspecified).AddTicks(498), 5L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 165L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Business-focused empowering adapter", new DateTime(2020, 12, 22, 15, 31, 31, 395, DateTimeKind.Unspecified).AddTicks(5204), 2L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 166L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Progressive foreground Graphical User Interface", new DateTime(2020, 9, 7, 23, 32, 49, 559, DateTimeKind.Unspecified).AddTicks(7179), 4L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 167L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Function-based exuding definition", new DateTime(2020, 1, 29, 14, 37, 27, 873, DateTimeKind.Unspecified).AddTicks(1401), 8L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 168L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Compatible dedicated approach", new DateTime(2020, 9, 5, 1, 7, 40, 549, DateTimeKind.Unspecified).AddTicks(8944), 9L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 169L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Seamless multi-state knowledge user", new DateTime(2020, 11, 1, 18, 34, 5, 448, DateTimeKind.Unspecified).AddTicks(6026), 11L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 170L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 8m, "Vision-oriented bottom-line process improvement", new DateTime(2020, 6, 10, 12, 42, 35, 36, DateTimeKind.Unspecified).AddTicks(1325), 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 171L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Multi-channelled full-range open system", new DateTime(2020, 6, 9, 17, 17, 28, 759, DateTimeKind.Unspecified).AddTicks(1497), 9L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 172L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Upgradable 6th generation product", new DateTime(2020, 10, 16, 17, 10, 1, 448, DateTimeKind.Unspecified).AddTicks(3993), 8L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 173L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 8m, "Cloned web-enabled groupware", new DateTime(2020, 7, 18, 11, 32, 45, 396, DateTimeKind.Unspecified).AddTicks(8558), 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 174L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 8m, "Reduced systemic Graphic Interface", new DateTime(2020, 10, 13, 3, 57, 56, 486, DateTimeKind.Unspecified).AddTicks(8833), 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 175L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Enhanced hybrid website", new DateTime(2020, 4, 4, 22, 48, 55, 595, DateTimeKind.Unspecified).AddTicks(2467), 11L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 176L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Stand-alone explicit workforce", new DateTime(2020, 5, 19, 6, 38, 35, 778, DateTimeKind.Unspecified).AddTicks(8001), 5L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 177L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Phased reciprocal data-warehouse", new DateTime(2020, 5, 4, 14, 24, 38, 47, DateTimeKind.Unspecified).AddTicks(2207), 7L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 178L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Diverse even-keeled synergy", new DateTime(2020, 12, 15, 16, 52, 26, 689, DateTimeKind.Unspecified).AddTicks(1631), 12L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 179L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 6m, "Optional discrete adapter", new DateTime(2020, 1, 18, 2, 51, 43, 107, DateTimeKind.Unspecified).AddTicks(8297), 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 180L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Optional responsive portal", new DateTime(2020, 10, 25, 22, 17, 11, 397, DateTimeKind.Unspecified).AddTicks(2459), 1L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 181L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Organized full-range firmware", new DateTime(2020, 4, 30, 17, 46, 16, 420, DateTimeKind.Unspecified).AddTicks(7110), 10L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 182L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Cloned bi-directional array", new DateTime(2020, 1, 15, 0, 46, 15, 672, DateTimeKind.Unspecified).AddTicks(8155), 9L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 183L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Decentralized actuating standardization", new DateTime(2020, 5, 30, 12, 4, 33, 297, DateTimeKind.Unspecified).AddTicks(3510), 7L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 184L,
                columns: new[] { "Comment", "Date", "ProjectId" },
                values: new object[] { "Cloned well-modulated database", new DateTime(2020, 12, 5, 5, 17, 55, 320, DateTimeKind.Unspecified).AddTicks(8443), 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 185L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Visionary incremental infrastructure", new DateTime(2020, 2, 17, 2, 3, 40, 554, DateTimeKind.Unspecified).AddTicks(8455), 9L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 186L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Upgradable maximized circuit", new DateTime(2020, 8, 31, 17, 18, 28, 241, DateTimeKind.Unspecified).AddTicks(3457), 3L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 187L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Decentralized uniform framework", new DateTime(2020, 7, 27, 6, 8, 24, 495, DateTimeKind.Unspecified).AddTicks(5640), 3L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 188L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Re-contextualized tangible info-mediaries", new DateTime(2020, 9, 13, 19, 17, 16, 344, DateTimeKind.Unspecified).AddTicks(8705), 10L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 189L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Multi-channelled analyzing encoding", new DateTime(2020, 12, 25, 4, 59, 13, 26, DateTimeKind.Unspecified).AddTicks(3075), 11L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 190L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 1m, "Pre-emptive modular ability", new DateTime(2020, 2, 5, 20, 28, 43, 694, DateTimeKind.Unspecified).AddTicks(6613), 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 191L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Multi-layered national frame", new DateTime(2020, 5, 25, 8, 47, 41, 917, DateTimeKind.Unspecified).AddTicks(7981), 4L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 192L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Automated tangible emulation", new DateTime(2020, 10, 23, 16, 49, 11, 535, DateTimeKind.Unspecified).AddTicks(5243), 2L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 193L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 3m, "Pre-emptive 24 hour superstructure", new DateTime(2020, 8, 24, 19, 39, 21, 577, DateTimeKind.Unspecified).AddTicks(2726), 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 194L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Open-architected tangible encryption", new DateTime(2020, 2, 15, 8, 29, 18, 988, DateTimeKind.Unspecified).AddTicks(326), 2L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 195L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Face to face executive intranet", new DateTime(2020, 5, 10, 20, 11, 42, 58, DateTimeKind.Unspecified).AddTicks(377), 8L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 196L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Diverse background installation", new DateTime(2020, 3, 8, 18, 18, 45, 551, DateTimeKind.Unspecified).AddTicks(3185), 1L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 197L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Digitized 24 hour project", new DateTime(2020, 7, 29, 22, 39, 44, 84, DateTimeKind.Unspecified).AddTicks(3372), 6L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 198L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Pre-emptive attitude-oriented implementation", new DateTime(2020, 11, 10, 10, 38, 43, 262, DateTimeKind.Unspecified).AddTicks(3577), 1L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 199L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Secured 6th generation contingency", new DateTime(2020, 9, 27, 14, 14, 5, 512, DateTimeKind.Unspecified).AddTicks(2084), 11L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 200L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Open-source optimizing implementation", new DateTime(2020, 5, 23, 14, 45, 50, 565, DateTimeKind.Unspecified).AddTicks(3644), 2L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 201L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Team-oriented fault-tolerant challenge", new DateTime(2020, 1, 1, 1, 28, 47, 340, DateTimeKind.Unspecified).AddTicks(4489), 7L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 202L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Synergized impactful middleware", new DateTime(2020, 1, 27, 21, 47, 28, 846, DateTimeKind.Unspecified).AddTicks(9862), 1L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 203L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Exclusive asymmetric matrix", new DateTime(2020, 7, 16, 9, 43, 4, 536, DateTimeKind.Unspecified).AddTicks(4704), 1L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 204L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Balanced directional capacity", new DateTime(2020, 4, 16, 15, 31, 23, 728, DateTimeKind.Unspecified).AddTicks(5734), 9L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 205L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Expanded empowering frame", new DateTime(2020, 8, 24, 19, 59, 27, 52, DateTimeKind.Unspecified).AddTicks(4083), 12L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 206L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Realigned discrete intranet", new DateTime(2020, 7, 29, 11, 29, 50, 677, DateTimeKind.Unspecified).AddTicks(9080), 9L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 207L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Optional mission-critical strategy", new DateTime(2020, 8, 20, 1, 9, 11, 170, DateTimeKind.Unspecified).AddTicks(426), 12L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 208L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Programmable systemic archive", new DateTime(2020, 2, 6, 16, 24, 3, 182, DateTimeKind.Unspecified).AddTicks(4899), 1L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 209L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Cross-group 24/7 project", new DateTime(2020, 1, 6, 5, 11, 11, 577, DateTimeKind.Unspecified).AddTicks(1479), 5L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 210L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Devolved demand-driven adapter", new DateTime(2020, 8, 31, 2, 26, 4, 789, DateTimeKind.Unspecified).AddTicks(5183), 8L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 211L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Seamless 6th generation encryption", new DateTime(2020, 12, 5, 5, 31, 18, 596, DateTimeKind.Unspecified).AddTicks(8739), 10L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 212L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Progressive discrete process improvement", new DateTime(2020, 6, 28, 4, 51, 43, 816, DateTimeKind.Unspecified).AddTicks(9555), 4L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 213L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 5m, "Multi-lateral demand-driven utilisation", new DateTime(2020, 5, 26, 0, 2, 19, 68, DateTimeKind.Unspecified).AddTicks(8897), 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 214L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Face to face optimizing frame", new DateTime(2020, 11, 28, 13, 47, 44, 845, DateTimeKind.Unspecified).AddTicks(6656), 3L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 215L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 4m, "Future-proofed static extranet", new DateTime(2020, 4, 20, 7, 48, 14, 230, DateTimeKind.Unspecified).AddTicks(465), 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 216L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 8m, "Sharable regional contingency", new DateTime(2020, 9, 23, 22, 3, 50, 491, DateTimeKind.Unspecified).AddTicks(5113), 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 217L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Realigned 4th generation algorithm", new DateTime(2020, 4, 29, 2, 38, 2, 200, DateTimeKind.Unspecified).AddTicks(8356), 11L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 218L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Vision-oriented 5th generation initiative", new DateTime(2020, 1, 9, 15, 33, 14, 865, DateTimeKind.Unspecified).AddTicks(1664), 5L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 219L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Front-line value-added intranet", new DateTime(2020, 12, 11, 18, 58, 23, 545, DateTimeKind.Unspecified).AddTicks(3414), 9L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 220L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 3m, "Monitored high-level help-desk", new DateTime(2020, 2, 17, 23, 31, 31, 598, DateTimeKind.Unspecified).AddTicks(1613), 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 221L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Multi-layered optimizing archive", new DateTime(2020, 9, 20, 15, 53, 8, 38, DateTimeKind.Unspecified).AddTicks(3773), 1L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 222L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Realigned eco-centric forecast", new DateTime(2020, 2, 27, 14, 43, 30, 880, DateTimeKind.Unspecified).AddTicks(1433), 9L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 223L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Secured secondary infrastructure", new DateTime(2020, 9, 2, 5, 35, 58, 130, DateTimeKind.Unspecified).AddTicks(189), 2L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 224L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Streamlined national frame", new DateTime(2020, 5, 15, 8, 9, 9, 450, DateTimeKind.Unspecified).AddTicks(7181), 5L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 225L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 3m, "Organized methodical instruction set", new DateTime(2020, 2, 13, 9, 8, 49, 231, DateTimeKind.Unspecified).AddTicks(9868), 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 226L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Focused foreground framework", new DateTime(2020, 1, 19, 21, 24, 25, 426, DateTimeKind.Unspecified).AddTicks(6478), 6L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 227L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Pre-emptive coherent website", new DateTime(2020, 12, 13, 10, 1, 44, 137, DateTimeKind.Unspecified).AddTicks(2780), 11L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 228L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Profit-focused web-enabled conglomeration", new DateTime(2020, 12, 23, 6, 20, 2, 275, DateTimeKind.Unspecified).AddTicks(22), 11L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 229L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Business-focused optimal open system", new DateTime(2020, 2, 23, 19, 2, 37, 676, DateTimeKind.Unspecified).AddTicks(4918), 5L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 230L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Re-contextualized stable array", new DateTime(2020, 4, 15, 20, 34, 2, 622, DateTimeKind.Unspecified).AddTicks(9255), 12L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 231L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Inverse background paradigm", new DateTime(2020, 10, 31, 1, 47, 44, 362, DateTimeKind.Unspecified).AddTicks(1236), 12L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 232L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Multi-tiered exuding hardware", new DateTime(2020, 12, 5, 10, 16, 13, 882, DateTimeKind.Unspecified).AddTicks(4301), 9L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 233L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Proactive disintermediate orchestration", new DateTime(2020, 8, 16, 14, 46, 45, 674, DateTimeKind.Unspecified).AddTicks(6209), 12L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 234L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Programmable national analyzer", new DateTime(2020, 11, 19, 23, 6, 39, 378, DateTimeKind.Unspecified).AddTicks(6544), 9L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 235L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Grass-roots system-worthy task-force", new DateTime(2020, 6, 10, 4, 18, 51, 483, DateTimeKind.Unspecified).AddTicks(8988), 11L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 236L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Switchable human-resource success", new DateTime(2020, 2, 25, 14, 6, 42, 633, DateTimeKind.Unspecified).AddTicks(8218), 12L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 237L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Grass-roots didactic monitoring", new DateTime(2020, 6, 5, 22, 23, 16, 139, DateTimeKind.Unspecified).AddTicks(3836), 11L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 238L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Operative foreground access", new DateTime(2020, 3, 20, 5, 3, 36, 593, DateTimeKind.Unspecified).AddTicks(4156), 9L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 239L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Mandatory multi-tasking database", new DateTime(2020, 4, 7, 10, 58, 19, 651, DateTimeKind.Unspecified).AddTicks(5115), 10L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 240L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Object-based human-resource success", new DateTime(2020, 4, 25, 6, 18, 3, 989, DateTimeKind.Unspecified).AddTicks(9064), 12L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 241L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Self-enabling solution-oriented adapter", new DateTime(2020, 9, 13, 5, 48, 42, 234, DateTimeKind.Unspecified).AddTicks(9473), 9L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 242L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Intuitive fault-tolerant solution", new DateTime(2020, 8, 28, 14, 45, 30, 784, DateTimeKind.Unspecified).AddTicks(4618), 12L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 243L,
                columns: new[] { "AmountOfHours", "Comment", "Date" },
                values: new object[] { 7m, "Multi-lateral upward-trending benchmark", new DateTime(2020, 10, 22, 18, 45, 56, 407, DateTimeKind.Unspecified).AddTicks(2491) });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 244L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Sharable modular challenge", new DateTime(2020, 6, 27, 6, 11, 53, 330, DateTimeKind.Unspecified).AddTicks(3597), 9L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 245L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Robust real-time superstructure", new DateTime(2020, 6, 11, 5, 24, 21, 528, DateTimeKind.Unspecified).AddTicks(6471), 3L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 246L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Organized zero defect adapter", new DateTime(2020, 4, 19, 14, 39, 56, 748, DateTimeKind.Unspecified).AddTicks(3737), 6L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 247L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Face to face foreground product", new DateTime(2020, 6, 7, 7, 18, 59, 109, DateTimeKind.Unspecified).AddTicks(9740), 4L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 248L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Organic optimizing projection", new DateTime(2020, 4, 27, 23, 49, 14, 164, DateTimeKind.Unspecified).AddTicks(3557), 8L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 249L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Distributed systemic throughput", new DateTime(2020, 5, 20, 19, 29, 36, 589, DateTimeKind.Unspecified).AddTicks(1760), 5L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 250L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Pre-emptive web-enabled projection", new DateTime(2020, 6, 21, 0, 52, 36, 233, DateTimeKind.Unspecified).AddTicks(2138), 9L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 251L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Upgradable attitude-oriented orchestration", new DateTime(2020, 1, 31, 12, 36, 58, 489, DateTimeKind.Unspecified).AddTicks(8990), 4L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 252L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Enterprise-wide fault-tolerant info-mediaries", new DateTime(2020, 5, 20, 7, 28, 41, 455, DateTimeKind.Unspecified).AddTicks(1559), 8L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 253L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Advanced asynchronous methodology", new DateTime(2020, 10, 23, 1, 47, 36, 309, DateTimeKind.Unspecified).AddTicks(4616), 4L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 254L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Cross-platform asymmetric capability", new DateTime(2020, 9, 28, 13, 56, 13, 236, DateTimeKind.Unspecified).AddTicks(284), 5L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 255L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Monitored zero administration knowledge user", new DateTime(2020, 5, 25, 9, 56, 28, 626, DateTimeKind.Unspecified).AddTicks(2151), 1L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 256L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Profit-focused asynchronous extranet", new DateTime(2020, 2, 24, 15, 54, 49, 204, DateTimeKind.Unspecified).AddTicks(8372), 2L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 257L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Multi-layered holistic policy", new DateTime(2020, 6, 14, 19, 37, 41, 859, DateTimeKind.Unspecified).AddTicks(6883), 2L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 258L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Synergistic coherent Graphic Interface", new DateTime(2020, 6, 2, 13, 31, 32, 18, DateTimeKind.Unspecified).AddTicks(8356), 8L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 259L,
                columns: new[] { "Comment", "Date", "ProjectId" },
                values: new object[] { "Ameliorated leading edge structure", new DateTime(2020, 7, 2, 20, 57, 38, 386, DateTimeKind.Unspecified).AddTicks(7618), 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 260L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Inverse uniform matrix", new DateTime(2020, 11, 18, 18, 14, 0, 662, DateTimeKind.Unspecified).AddTicks(3788), 11L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 261L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Adaptive disintermediate capability", new DateTime(2020, 7, 31, 13, 59, 45, 234, DateTimeKind.Unspecified).AddTicks(9590), 11L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 262L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 6m, "Phased fresh-thinking encryption", new DateTime(2020, 6, 6, 9, 12, 28, 840, DateTimeKind.Unspecified).AddTicks(494), 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 263L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Seamless bottom-line groupware", new DateTime(2020, 1, 22, 3, 52, 43, 249, DateTimeKind.Unspecified).AddTicks(3948), 11L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 264L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Operative global application", new DateTime(2020, 10, 29, 1, 3, 52, 624, DateTimeKind.Unspecified).AddTicks(7576), 1L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 265L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Optional bi-directional concept", new DateTime(2020, 3, 3, 23, 17, 6, 38, DateTimeKind.Unspecified).AddTicks(2610), 1L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 266L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Total dedicated neural-net", new DateTime(2020, 3, 24, 18, 20, 35, 403, DateTimeKind.Unspecified).AddTicks(1870), 1L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 267L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Customizable logistical project", new DateTime(2020, 2, 27, 20, 48, 11, 610, DateTimeKind.Unspecified).AddTicks(732), 1L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 268L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Right-sized coherent website", new DateTime(2020, 3, 18, 1, 14, 5, 776, DateTimeKind.Unspecified).AddTicks(1696), 1L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 269L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Synergistic asymmetric superstructure", new DateTime(2020, 10, 2, 14, 19, 2, 870, DateTimeKind.Unspecified).AddTicks(2), 9L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 270L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 1m, "Face to face asynchronous encoding", new DateTime(2020, 8, 8, 3, 37, 15, 16, DateTimeKind.Unspecified).AddTicks(4891), 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 271L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Triple-buffered object-oriented software", new DateTime(2020, 9, 19, 9, 42, 18, 569, DateTimeKind.Unspecified).AddTicks(2685), 7L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 272L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Synchronised didactic ability", new DateTime(2020, 3, 16, 18, 17, 22, 751, DateTimeKind.Unspecified).AddTicks(4860), 10L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 273L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Upgradable context-sensitive workforce", new DateTime(2020, 6, 1, 5, 51, 3, 677, DateTimeKind.Unspecified).AddTicks(4713), 1L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 274L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Devolved reciprocal focus group", new DateTime(2020, 5, 24, 22, 13, 36, 339, DateTimeKind.Unspecified).AddTicks(3498), 10L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 275L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Multi-tiered human-resource strategy", new DateTime(2020, 5, 13, 17, 49, 18, 612, DateTimeKind.Unspecified).AddTicks(5613), 12L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 276L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Multi-lateral bifurcated help-desk", new DateTime(2020, 9, 30, 20, 32, 27, 41, DateTimeKind.Unspecified).AddTicks(3880), 2L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 277L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Self-enabling tertiary toolset", new DateTime(2020, 1, 31, 0, 56, 32, 204, DateTimeKind.Unspecified).AddTicks(8972), 4L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 278L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Synergistic disintermediate analyzer", new DateTime(2020, 4, 3, 23, 25, 21, 253, DateTimeKind.Unspecified).AddTicks(7607), 5L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 279L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "User-centric hybrid process improvement", new DateTime(2020, 11, 14, 21, 59, 30, 424, DateTimeKind.Unspecified).AddTicks(825), 2L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 280L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Seamless bi-directional pricing structure", new DateTime(2020, 7, 10, 9, 34, 45, 851, DateTimeKind.Unspecified).AddTicks(4261), 6L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 281L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Centralized leading edge workforce", new DateTime(2020, 12, 9, 19, 54, 39, 323, DateTimeKind.Unspecified).AddTicks(9748), 12L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 282L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 3m, "Team-oriented explicit interface", new DateTime(2020, 1, 3, 10, 37, 30, 625, DateTimeKind.Unspecified).AddTicks(4553), 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 283L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Distributed secondary model", new DateTime(2020, 7, 9, 13, 8, 49, 557, DateTimeKind.Unspecified).AddTicks(3857), 3L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 284L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 5m, "Profit-focused national website", new DateTime(2020, 2, 17, 8, 13, 56, 714, DateTimeKind.Unspecified).AddTicks(163), 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 285L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Reverse-engineered cohesive service-desk", new DateTime(2020, 8, 25, 2, 35, 16, 423, DateTimeKind.Unspecified).AddTicks(986), 7L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 286L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Reduced actuating Graphical User Interface", new DateTime(2020, 11, 17, 15, 25, 5, 198, DateTimeKind.Unspecified).AddTicks(8219), 1L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 287L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Cross-platform content-based policy", new DateTime(2020, 5, 12, 22, 33, 26, 309, DateTimeKind.Unspecified).AddTicks(8824), 9L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 288L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Function-based background encoding", new DateTime(2020, 10, 3, 17, 12, 54, 707, DateTimeKind.Unspecified).AddTicks(8901), 10L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 289L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Team-oriented 24 hour contingency", new DateTime(2020, 12, 15, 16, 15, 55, 317, DateTimeKind.Unspecified).AddTicks(5439), 10L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 290L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "De-engineered needs-based standardization", new DateTime(2020, 5, 5, 12, 18, 28, 614, DateTimeKind.Unspecified).AddTicks(2851), 10L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 291L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Reverse-engineered context-sensitive challenge", new DateTime(2020, 10, 29, 8, 44, 16, 301, DateTimeKind.Unspecified).AddTicks(3715), 1L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 292L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Mandatory dedicated toolset", new DateTime(2020, 6, 16, 8, 21, 4, 996, DateTimeKind.Unspecified).AddTicks(7468), 7L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 293L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Cloned interactive parallelism", new DateTime(2020, 6, 9, 17, 55, 23, 748, DateTimeKind.Unspecified).AddTicks(1388), 7L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 294L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Balanced coherent database", new DateTime(2020, 5, 12, 7, 31, 22, 54, DateTimeKind.Unspecified).AddTicks(7275), 7L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 295L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Optional system-worthy throughput", new DateTime(2020, 12, 5, 18, 18, 8, 910, DateTimeKind.Unspecified).AddTicks(6804), 5L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 296L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Total bandwidth-monitored product", new DateTime(2020, 2, 19, 23, 28, 59, 466, DateTimeKind.Unspecified).AddTicks(2565), 1L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 297L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Right-sized demand-driven complexity", new DateTime(2020, 11, 30, 18, 56, 15, 983, DateTimeKind.Unspecified).AddTicks(7319), 6L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 298L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Decentralized bi-directional definition", new DateTime(2020, 9, 15, 8, 32, 50, 152, DateTimeKind.Unspecified).AddTicks(8096), 9L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 299L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Assimilated uniform instruction set", new DateTime(2020, 8, 6, 20, 36, 1, 516, DateTimeKind.Unspecified).AddTicks(2658), 9L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 300L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Implemented 3rd generation complexity", new DateTime(2020, 7, 24, 0, 42, 5, 926, DateTimeKind.Unspecified).AddTicks(7551), 12L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 301L,
                columns: new[] { "Comment", "Date", "EmployeeId" },
                values: new object[] { "Inverse value-added implementation", new DateTime(2020, 11, 10, 21, 26, 16, 753, DateTimeKind.Unspecified).AddTicks(2216), 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 302L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Up-sized actuating algorithm", new DateTime(2020, 5, 26, 15, 52, 40, 194, DateTimeKind.Unspecified).AddTicks(1509), 2L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 303L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Reduced multi-tasking model", new DateTime(2020, 11, 19, 19, 59, 57, 500, DateTimeKind.Unspecified).AddTicks(8450), 6L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 304L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Down-sized demand-driven encoding", new DateTime(2020, 11, 18, 0, 1, 11, 252, DateTimeKind.Unspecified).AddTicks(376), 12L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 305L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Enterprise-wide zero tolerance installation", new DateTime(2020, 7, 29, 21, 7, 16, 294, DateTimeKind.Unspecified).AddTicks(680), 8L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 306L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Digitized scalable encoding", new DateTime(2020, 11, 21, 1, 33, 29, 308, DateTimeKind.Unspecified).AddTicks(3020), 1L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 307L,
                columns: new[] { "AmountOfHours", "Comment", "Date" },
                values: new object[] { 1m, "Synchronised homogeneous migration", new DateTime(2020, 5, 26, 23, 57, 29, 736, DateTimeKind.Unspecified).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 308L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Grass-roots leading edge initiative", new DateTime(2020, 6, 26, 3, 2, 32, 280, DateTimeKind.Unspecified).AddTicks(9735), 10L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 309L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Public-key client-driven hub", new DateTime(2020, 4, 29, 23, 14, 19, 888, DateTimeKind.Unspecified).AddTicks(7297), 2L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 310L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Business-focused intangible instruction set", new DateTime(2020, 11, 28, 4, 24, 22, 269, DateTimeKind.Unspecified).AddTicks(1899), 5L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 311L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Synchronised even-keeled hierarchy", new DateTime(2020, 8, 29, 9, 38, 29, 181, DateTimeKind.Unspecified).AddTicks(2549), 5L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 312L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Seamless multi-tasking monitoring", new DateTime(2020, 10, 6, 5, 47, 38, 51, DateTimeKind.Unspecified).AddTicks(7508), 9L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 313L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Mandatory 24/7 software", new DateTime(2020, 10, 8, 7, 27, 1, 357, DateTimeKind.Unspecified).AddTicks(3283), 11L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 314L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Proactive stable synergy", new DateTime(2020, 7, 16, 8, 12, 7, 524, DateTimeKind.Unspecified).AddTicks(8680), 5L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 315L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "User-friendly background system engine", new DateTime(2020, 5, 31, 21, 6, 15, 824, DateTimeKind.Unspecified).AddTicks(1083), 9L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 316L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Down-sized 5th generation Graphical User Interface", new DateTime(2020, 1, 22, 17, 25, 38, 281, DateTimeKind.Unspecified).AddTicks(5400), 7L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 317L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Open-architected responsive Graphical User Interface", new DateTime(2020, 11, 6, 8, 31, 24, 924, DateTimeKind.Unspecified).AddTicks(3843), 9L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 318L,
                columns: new[] { "Comment", "Date", "EmployeeId" },
                values: new object[] { "Open-architected national instruction set", new DateTime(2020, 10, 24, 15, 2, 23, 59, DateTimeKind.Unspecified).AddTicks(5590), 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 319L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Open-architected intangible utilisation", new DateTime(2020, 1, 25, 7, 35, 3, 486, DateTimeKind.Unspecified).AddTicks(9604), 12L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 320L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Optimized object-oriented workforce", new DateTime(2020, 7, 26, 20, 56, 9, 676, DateTimeKind.Unspecified).AddTicks(8024), 4L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 321L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Versatile full-range frame", new DateTime(2020, 5, 19, 19, 10, 10, 421, DateTimeKind.Unspecified).AddTicks(1294), 12L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 322L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Assimilated hybrid model", new DateTime(2020, 8, 6, 18, 52, 59, 235, DateTimeKind.Unspecified).AddTicks(907), 5L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 323L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Monitored full-range customer loyalty", new DateTime(2020, 3, 1, 13, 55, 56, 915, DateTimeKind.Unspecified).AddTicks(2559), 9L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 324L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Open-architected heuristic interface", new DateTime(2020, 4, 9, 14, 21, 11, 491, DateTimeKind.Unspecified).AddTicks(4309), 3L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 325L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Centralized full-range implementation", new DateTime(2020, 1, 27, 5, 36, 45, 960, DateTimeKind.Unspecified).AddTicks(1759), 6L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 326L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Exclusive bottom-line hierarchy", new DateTime(2020, 5, 25, 20, 30, 3, 256, DateTimeKind.Unspecified).AddTicks(484), 6L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 327L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Ameliorated empowering middleware", new DateTime(2020, 2, 9, 3, 11, 31, 488, DateTimeKind.Unspecified).AddTicks(3086), 9L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 328L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 1m, "Front-line radical knowledge base", new DateTime(2020, 5, 23, 22, 42, 39, 400, DateTimeKind.Unspecified).AddTicks(1838), 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 329L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Virtual stable product", new DateTime(2020, 7, 14, 18, 52, 5, 633, DateTimeKind.Unspecified).AddTicks(4100), 5L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 330L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Cloned client-driven system engine", new DateTime(2020, 2, 27, 16, 52, 37, 365, DateTimeKind.Unspecified).AddTicks(7498), 3L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 331L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Extended responsive definition", new DateTime(2020, 11, 22, 19, 54, 33, 245, DateTimeKind.Unspecified).AddTicks(6332), 7L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 332L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Cross-group tertiary info-mediaries", new DateTime(2020, 3, 17, 15, 49, 13, 395, DateTimeKind.Unspecified).AddTicks(5541), 11L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 333L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Programmable transitional paradigm", new DateTime(2020, 11, 10, 17, 35, 33, 670, DateTimeKind.Unspecified).AddTicks(9884), 4L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 334L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Front-line multi-tasking access", new DateTime(2020, 2, 3, 15, 8, 19, 512, DateTimeKind.Unspecified).AddTicks(9064), 12L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 335L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "De-engineered neutral local area network", new DateTime(2020, 7, 14, 2, 22, 54, 89, DateTimeKind.Unspecified).AddTicks(2450), 8L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 336L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 1m, "User-friendly directional collaboration", new DateTime(2020, 12, 2, 3, 42, 6, 146, DateTimeKind.Unspecified).AddTicks(5939), 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 337L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "User-centric disintermediate internet solution", new DateTime(2020, 12, 22, 18, 43, 14, 224, DateTimeKind.Unspecified).AddTicks(9865), 11L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 338L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Expanded composite solution", new DateTime(2020, 3, 7, 13, 38, 4, 633, DateTimeKind.Unspecified).AddTicks(2421), 11L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 339L,
                columns: new[] { "Comment", "Date", "ProjectId" },
                values: new object[] { "Cross-platform demand-driven leverage", new DateTime(2020, 11, 30, 8, 48, 36, 802, DateTimeKind.Unspecified).AddTicks(3525), 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 340L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Distributed transitional customer loyalty", new DateTime(2020, 7, 16, 12, 48, 12, 47, DateTimeKind.Unspecified).AddTicks(5817), 3L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 341L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Polarised intangible function", new DateTime(2020, 9, 29, 5, 29, 23, 592, DateTimeKind.Unspecified).AddTicks(2673), 7L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 342L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Implemented homogeneous artificial intelligence", new DateTime(2020, 6, 2, 23, 15, 54, 171, DateTimeKind.Unspecified).AddTicks(4611), 8L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 343L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Networked non-volatile parallelism", new DateTime(2020, 7, 12, 3, 26, 49, 505, DateTimeKind.Unspecified).AddTicks(154), 9L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 344L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Ameliorated mobile parallelism", new DateTime(2020, 1, 25, 20, 13, 8, 72, DateTimeKind.Unspecified).AddTicks(9806), 8L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 345L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Integrated discrete moratorium", new DateTime(2020, 11, 27, 22, 48, 39, 504, DateTimeKind.Unspecified).AddTicks(8089), 5L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 346L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Public-key homogeneous frame", new DateTime(2020, 9, 19, 1, 20, 48, 364, DateTimeKind.Unspecified).AddTicks(8129), 9L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 347L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Seamless homogeneous knowledge base", new DateTime(2020, 8, 6, 6, 21, 33, 348, DateTimeKind.Unspecified).AddTicks(7388), 4L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 348L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Digitized impactful info-mediaries", new DateTime(2020, 1, 24, 9, 4, 1, 666, DateTimeKind.Unspecified).AddTicks(4976), 12L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 349L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Universal multimedia success", new DateTime(2020, 11, 15, 23, 41, 20, 766, DateTimeKind.Unspecified).AddTicks(2795), 9L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 350L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Digitized global encoding", new DateTime(2020, 8, 17, 12, 42, 40, 183, DateTimeKind.Unspecified).AddTicks(8012), 11L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 351L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Ergonomic executive adapter", new DateTime(2020, 3, 29, 2, 22, 27, 414, DateTimeKind.Unspecified).AddTicks(5959), 7L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 352L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Customer-focused clear-thinking firmware", new DateTime(2020, 1, 30, 3, 51, 20, 951, DateTimeKind.Unspecified).AddTicks(5913), 6L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 353L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Robust coherent Graphical User Interface", new DateTime(2020, 1, 13, 20, 31, 23, 794, DateTimeKind.Unspecified).AddTicks(9397), 10L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 354L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Streamlined holistic workforce", new DateTime(2020, 1, 21, 18, 27, 20, 614, DateTimeKind.Unspecified).AddTicks(1456), 12L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 355L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Automated didactic Graphical User Interface", new DateTime(2020, 10, 12, 5, 46, 13, 290, DateTimeKind.Unspecified).AddTicks(4322), 3L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 356L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Customizable heuristic hardware", new DateTime(2020, 11, 26, 11, 12, 11, 802, DateTimeKind.Unspecified).AddTicks(9025), 3L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 357L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Multi-tiered local data-warehouse", new DateTime(2020, 5, 9, 3, 9, 53, 472, DateTimeKind.Unspecified).AddTicks(8675), 9L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 358L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Enterprise-wide systemic capability", new DateTime(2020, 10, 7, 20, 58, 29, 244, DateTimeKind.Unspecified).AddTicks(3013), 12L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 359L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Total 3rd generation internet solution", new DateTime(2020, 1, 14, 1, 19, 58, 555, DateTimeKind.Unspecified).AddTicks(7891), 7L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 360L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Team-oriented transitional contingency", new DateTime(2020, 8, 26, 18, 55, 4, 54, DateTimeKind.Unspecified).AddTicks(5706), 1L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 361L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Reduced zero tolerance knowledge base", new DateTime(2020, 4, 8, 19, 0, 52, 522, DateTimeKind.Unspecified).AddTicks(7269), 1L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 362L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Triple-buffered object-oriented encryption", new DateTime(2021, 1, 1, 1, 6, 2, 929, DateTimeKind.Unspecified).AddTicks(9853), 5L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 363L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 7m, "Intuitive didactic contingency", new DateTime(2020, 3, 6, 14, 17, 14, 307, DateTimeKind.Unspecified).AddTicks(6036), 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 364L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Managed tangible open system", new DateTime(2020, 7, 13, 10, 28, 5, 220, DateTimeKind.Unspecified).AddTicks(728), 6L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 365L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Programmable 5th generation monitoring", new DateTime(2020, 9, 7, 14, 53, 5, 256, DateTimeKind.Unspecified).AddTicks(7505), 6L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 366L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Synergized logistical synergy", new DateTime(2020, 10, 15, 3, 50, 10, 926, DateTimeKind.Unspecified).AddTicks(4229), 6L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 367L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Focused contextually-based attitude", new DateTime(2020, 1, 24, 14, 50, 15, 629, DateTimeKind.Unspecified).AddTicks(646), 4L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 368L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Proactive zero tolerance function", new DateTime(2020, 4, 14, 19, 33, 47, 793, DateTimeKind.Unspecified).AddTicks(3657), 4L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 369L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Cross-group systemic knowledge base", new DateTime(2020, 5, 16, 18, 12, 59, 572, DateTimeKind.Unspecified).AddTicks(7886), 1L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 370L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Public-key multimedia system engine", new DateTime(2020, 10, 4, 4, 46, 38, 11, DateTimeKind.Unspecified).AddTicks(2111), 7L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 371L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Quality-focused dynamic capacity", new DateTime(2020, 4, 23, 4, 28, 32, 417, DateTimeKind.Unspecified).AddTicks(587), 10L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 372L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Profound local complexity", new DateTime(2020, 4, 6, 8, 13, 8, 299, DateTimeKind.Unspecified).AddTicks(6339), 3L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 373L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Automated directional collaboration", new DateTime(2020, 2, 8, 20, 53, 56, 275, DateTimeKind.Unspecified).AddTicks(1924), 10L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 374L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Realigned executive info-mediaries", new DateTime(2020, 3, 6, 7, 32, 16, 352, DateTimeKind.Unspecified).AddTicks(391), 9L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 375L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 5m, "Persevering cohesive product", new DateTime(2020, 10, 5, 23, 11, 24, 288, DateTimeKind.Unspecified).AddTicks(3544), 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 376L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Public-key composite hierarchy", new DateTime(2020, 12, 16, 19, 26, 56, 285, DateTimeKind.Unspecified).AddTicks(4789), 4L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 377L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Focused executive product", new DateTime(2020, 3, 13, 6, 36, 0, 375, DateTimeKind.Unspecified).AddTicks(6196), 12L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 378L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 6m, "Horizontal optimal pricing structure", new DateTime(2020, 3, 13, 8, 11, 16, 478, DateTimeKind.Unspecified).AddTicks(5144), 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 379L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 8m, "User-centric needs-based artificial intelligence", new DateTime(2020, 10, 9, 7, 16, 19, 246, DateTimeKind.Unspecified).AddTicks(2262), 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 380L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Implemented full-range capability", new DateTime(2020, 7, 7, 0, 0, 28, 411, DateTimeKind.Unspecified).AddTicks(710), 6L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 381L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Business-focused optimizing infrastructure", new DateTime(2020, 2, 4, 10, 23, 21, 893, DateTimeKind.Unspecified).AddTicks(2248), 4L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 382L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Adaptive neutral projection", new DateTime(2020, 4, 20, 23, 20, 27, 236, DateTimeKind.Unspecified).AddTicks(8480), 8L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 383L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 2m, "Multi-lateral 24/7 artificial intelligence", new DateTime(2020, 12, 22, 3, 30, 18, 424, DateTimeKind.Unspecified).AddTicks(7031), 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 384L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Open-source encompassing attitude", new DateTime(2020, 12, 20, 0, 16, 55, 29, DateTimeKind.Unspecified).AddTicks(3370), 8L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 385L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Upgradable mobile initiative", new DateTime(2020, 5, 25, 11, 26, 53, 316, DateTimeKind.Unspecified).AddTicks(53), 6L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 386L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Vision-oriented didactic neural-net", new DateTime(2020, 4, 10, 17, 17, 15, 141, DateTimeKind.Unspecified).AddTicks(4806), 2L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 387L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Visionary discrete initiative", new DateTime(2020, 7, 23, 15, 54, 6, 62, DateTimeKind.Unspecified).AddTicks(417), 12L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 388L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Intuitive 6th generation local area network", new DateTime(2020, 11, 3, 16, 33, 26, 452, DateTimeKind.Unspecified).AddTicks(9816), 12L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 389L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Intuitive executive open system", new DateTime(2020, 8, 19, 11, 12, 10, 308, DateTimeKind.Unspecified).AddTicks(9657), 4L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 390L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Centralized dynamic capacity", new DateTime(2020, 7, 1, 2, 39, 52, 647, DateTimeKind.Unspecified).AddTicks(5510), 6L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 391L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Re-engineered full-range open system", new DateTime(2020, 12, 5, 1, 43, 36, 909, DateTimeKind.Unspecified).AddTicks(5530), 9L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 392L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Automated mobile moratorium", new DateTime(2020, 10, 16, 1, 54, 47, 353, DateTimeKind.Unspecified).AddTicks(8750), 2L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 393L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Organic upward-trending internet solution", new DateTime(2020, 1, 7, 4, 13, 12, 617, DateTimeKind.Unspecified).AddTicks(9435), 12L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 394L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Universal zero defect solution", new DateTime(2020, 10, 7, 18, 24, 5, 744, DateTimeKind.Unspecified).AddTicks(9953), 7L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 395L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Visionary empowering info-mediaries", new DateTime(2020, 11, 19, 1, 25, 20, 747, DateTimeKind.Unspecified).AddTicks(7653), 11L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 396L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Proactive system-worthy customer loyalty", new DateTime(2020, 6, 8, 19, 53, 12, 894, DateTimeKind.Unspecified).AddTicks(3491), 9L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 397L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Reduced 3rd generation capability", new DateTime(2020, 12, 29, 20, 31, 25, 762, DateTimeKind.Unspecified).AddTicks(6618), 5L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 398L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Innovative modular infrastructure", new DateTime(2020, 7, 18, 0, 39, 47, 211, DateTimeKind.Unspecified).AddTicks(3135), 1L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 399L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Mandatory static capacity", new DateTime(2020, 11, 19, 1, 16, 4, 351, DateTimeKind.Unspecified).AddTicks(9095), 5L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 400L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Face to face coherent encoding", new DateTime(2020, 8, 21, 12, 55, 17, 681, DateTimeKind.Unspecified).AddTicks(9258), 8L, 12L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 1L, 4L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 1L, 8L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 1L, 11L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2L, 2L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2L, 3L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2L, 11L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2L, 13L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2L, 19L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3L, 4L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3L, 5L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3L, 6L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3L, 7L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3L, 10L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4L, 7L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4L, 17L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4L, 19L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5L, 3L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5L, 7L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5L, 8L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 6L, 5L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 6L, 9L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 6L, 13L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 6L, 17L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 7L, 3L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 7L, 6L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 7L, 7L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 7L, 13L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 7L, 14L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 7L, 19L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 8L, 3L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 8L, 12L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 8L, 18L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 9L, 4L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 9L, 19L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 10L, 17L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 11L, 1L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 11L, 4L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 11L, 11L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 11L, 13L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 12L, 1L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 12L, 10L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 12L, 16L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 12L, 18L });

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Employee");

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 1L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "8167", "West Alexandria", "Kulas, Stiedemann and Dach", "Anguilla", "99712", "Lance Rapid" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 2L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "66010", "New Guiseppehaven", "Kessler, Rau and Hamill", "Saint Kitts and Nevis", "12070", "Perry Island" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 3L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "028", "New Lessie", "Kub - Thompson", "Poland", "44364-0715", "Gerhold Via" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 4L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "3733", "Patiencemouth", "Volkman - Dietrich", "Bouvet Island (Bouvetoya)", "77992-6544", "Windler Ridges" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 5L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "24081", "New Torey", "Fahey - Wiza", "Paraguay", "34548", "Carolyn Canyon" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 6L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "5012", "New Rosanna", "Rogahn Inc", "Morocco", "75303", "Casper Lights" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 7L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "30808", "New Matildafurt", "Schimmel - Upton", "Tokelau", "92189-9693", "Bradford Estates" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 8L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "90089", "Kemmermouth", "Koelpin LLC", "Oman", "32083-3861", "Fritz Forks" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "486", "South Madalinefort", "Croatia", new DateTime(1990, 10, 25, 4, 7, 45, 814, DateTimeKind.Unspecified).AddTicks(3648), "Chris", "Human Intranet Facilitator", "Haley", "58767", "Donato Forks" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "17713", "Jakubowskiport", "Gambia", new DateTime(1986, 7, 10, 8, 55, 41, 27, DateTimeKind.Unspecified).AddTicks(2092), "Retta", "Future Accountability Consultant", "Stoltenberg", "92410-1396", "Bradtke Pass" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "906", "Port Alveraberg", "Central African Republic", new DateTime(1963, 11, 7, 4, 15, 30, 60, DateTimeKind.Unspecified).AddTicks(6098), "Melyssa", "Investor Directives Producer", "Morissette", "52126", "Fernando Walk" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "378", "Reannamouth", "Kiribati", new DateTime(1958, 3, 18, 18, 2, 40, 489, DateTimeKind.Unspecified).AddTicks(2824), "Cortney", "Investor Mobility Architect", "Swift", "98879-6380", "Sipes Hollow" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "1455", "North Lethamouth", "Saint Vincent and the Grenadines", new DateTime(1981, 9, 7, 20, 21, 4, 908, DateTimeKind.Unspecified).AddTicks(2138), "Filiberto", "Direct Brand Coordinator", "Dietrich", "51978-5382", "Santos Plains" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "3531", "Port Moises", "Bolivia", new DateTime(1968, 10, 19, 20, 29, 36, 283, DateTimeKind.Unspecified).AddTicks(5533), "Bella", "Human Factors Specialist", "Prohaska", "37006", "Marvin Meadows" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 7L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "08334", "Port Robertamouth", "Turkey", new DateTime(1959, 7, 30, 16, 0, 30, 396, DateTimeKind.Unspecified).AddTicks(5896), "Taurean", "District Solutions Planner", "Farrell", "12655", "Wilbert Drive" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 8L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "2270", "Lake Tamiamouth", "Iran", new DateTime(1956, 9, 13, 12, 22, 34, 773, DateTimeKind.Unspecified).AddTicks(4811), "Chance", "Senior Identity Liaison", "Kuhn", "18218", "Cassin Groves" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 9L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "3370", "Arelyburgh", "Guam", new DateTime(1950, 1, 20, 13, 56, 1, 718, DateTimeKind.Unspecified).AddTicks(3680), "Laron", "National Response Developer", "Rodriguez", "18741", "Marcus Summit" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 10L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "187", "Port Myrl", "Germany", new DateTime(1986, 12, 24, 20, 5, 45, 882, DateTimeKind.Unspecified).AddTicks(7012), "Mattie", "Principal Optimization Orchestrator", "Price", "47628-5171", "Osvaldo Fields" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 11L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "242", "Corwinburgh", "Norfolk Island", new DateTime(1952, 9, 15, 22, 34, 53, 887, DateTimeKind.Unspecified).AddTicks(6009), "Shanon", "Global Integration Engineer", "Abbott", "96944", "Pagac Parkways" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 12L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "37947", "Mooreberg", "Malawi", new DateTime(1978, 10, 4, 20, 8, 37, 978, DateTimeKind.Unspecified).AddTicks(8106), "Morton", "Corporate Marketing Specialist", "Dickens", "74494", "Dibbert Trail" });

            migrationBuilder.InsertData(
                table: "EmployeeProject",
                columns: new[] { "EmployeeId", "ProjectId" },
                values: new object[,]
                {
                    { 12L, 20L },
                    { 4L, 14L },
                    { 3L, 13L },
                    { 8L, 4L },
                    { 1L, 2L },
                    { 9L, 2L },
                    { 9L, 7L },
                    { 12L, 7L },
                    { 10L, 1L },
                    { 10L, 14L },
                    { 12L, 2L },
                    { 1L, 13L },
                    { 6L, 1L },
                    { 2L, 16L },
                    { 3L, 9L },
                    { 10L, 9L },
                    { 5L, 19L },
                    { 1L, 17L },
                    { 4L, 18L },
                    { 11L, 16L },
                    { 12L, 3L },
                    { 2L, 4L },
                    { 10L, 10L },
                    { 6L, 19L },
                    { 5L, 5L },
                    { 5L, 13L },
                    { 6L, 2L },
                    { 3L, 1L },
                    { 2L, 6L },
                    { 5L, 4L },
                    { 11L, 17L },
                    { 2L, 12L },
                    { 10L, 13L },
                    { 2L, 1L },
                    { 5L, 12L },
                    { 11L, 15L },
                    { 1L, 10L },
                    { 8L, 16L },
                    { 2L, 7L },
                    { 1L, 15L },
                    { 10L, 6L },
                    { 4L, 15L },
                    { 9L, 8L }
                });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 3L, 878.72m, "Decentralized multimedia archive" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 5L, 825.80m, "Fully-configurable multimedia circuit" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 3L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 7L, 547.90m, "Future-proofed didactic capability" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 4L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 6L, 758.47m, "Cross-platform didactic solution" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 5L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 2L, 642.35m, "Ameliorated explicit portal" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 6L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 1L, 636.92m, "Focused exuding solution" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 7L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 8L, 652.94m, "Optional asymmetric info-mediaries" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 8L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 1L, 981.74m, "Monitored object-oriented complexity" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 9L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 6L, 825.25m, "Polarised regional moratorium" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 10L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 4L, 990.44m, "Optional clear-thinking conglomeration" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 11L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 6L, 937.96m, "Synergized 6th generation synergy" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 12L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 8L, 774.36m, "Seamless transitional protocol" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 13L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 1L, 796.08m, "User-centric responsive support" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 14L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 4L, 581.63m, "Expanded responsive software" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 15L,
                columns: new[] { "PricePerHour", "ProjectName" },
                values: new object[] { 732.62m, "Integrated asymmetric success" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 16L,
                columns: new[] { "PricePerHour", "ProjectName" },
                values: new object[] { 778.92m, "Enterprise-wide neutral artificial intelligence" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 17L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 2L, 888.02m, "Customer-focused clear-thinking strategy" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 18L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 2L, 830.38m, "Networked clear-thinking matrix" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 19L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 1L, 982.95m, "Optimized uniform moderator" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 20L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 4L, 823.45m, "Sharable system-worthy approach" });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 1L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Compatible national secured line", new DateTime(2020, 3, 1, 7, 31, 41, 38, DateTimeKind.Unspecified).AddTicks(6519), 9L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 2L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 2m, "Monitored impactful alliance", new DateTime(2020, 1, 27, 6, 43, 1, 661, DateTimeKind.Unspecified).AddTicks(2043), 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 3L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Decentralized full-range toolset", new DateTime(2020, 5, 13, 7, 58, 18, 690, DateTimeKind.Unspecified).AddTicks(4978), 2L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 4L,
                columns: new[] { "Comment", "Date", "ProjectId" },
                values: new object[] { "Future-proofed next generation encryption", new DateTime(2020, 3, 17, 20, 6, 3, 709, DateTimeKind.Unspecified).AddTicks(1586), 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 5L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Fully-configurable discrete framework", new DateTime(2020, 5, 16, 22, 15, 44, 779, DateTimeKind.Unspecified).AddTicks(5302), 10L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 6L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Stand-alone context-sensitive frame", new DateTime(2020, 6, 23, 10, 39, 24, 739, DateTimeKind.Unspecified).AddTicks(7429), 8L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 7L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Configurable encompassing architecture", new DateTime(2020, 12, 15, 5, 51, 56, 131, DateTimeKind.Unspecified).AddTicks(1397), 1L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 8L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Synergistic neutral service-desk", new DateTime(2020, 1, 13, 15, 29, 22, 553, DateTimeKind.Unspecified).AddTicks(9339), 3L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 9L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Virtual incremental portal", new DateTime(2020, 6, 21, 22, 40, 56, 745, DateTimeKind.Unspecified).AddTicks(7013), 9L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 10L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Down-sized national neural-net", new DateTime(2020, 2, 25, 23, 29, 4, 213, DateTimeKind.Unspecified).AddTicks(7665), 7L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 11L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Diverse mission-critical implementation", new DateTime(2020, 8, 24, 19, 37, 52, 688, DateTimeKind.Unspecified).AddTicks(5976), 3L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 12L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Horizontal context-sensitive standardization", new DateTime(2020, 12, 27, 12, 1, 40, 441, DateTimeKind.Unspecified).AddTicks(7606), 1L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 13L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Persistent intangible internet solution", new DateTime(2020, 1, 1, 6, 53, 46, 149, DateTimeKind.Unspecified).AddTicks(1995), 3L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 14L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Reactive mission-critical utilisation", new DateTime(2020, 3, 22, 19, 35, 1, 692, DateTimeKind.Unspecified).AddTicks(3011), 11L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 15L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Programmable foreground intranet", new DateTime(2020, 8, 14, 14, 59, 37, 915, DateTimeKind.Unspecified).AddTicks(7756), 10L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 16L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 6m, "Cloned executive workforce", new DateTime(2020, 10, 6, 3, 25, 15, 451, DateTimeKind.Unspecified).AddTicks(4117), 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 17L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Focused tangible methodology", new DateTime(2020, 7, 5, 11, 58, 2, 204, DateTimeKind.Unspecified).AddTicks(2398), 5L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 18L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Customizable bi-directional firmware", new DateTime(2020, 9, 8, 3, 4, 20, 470, DateTimeKind.Unspecified).AddTicks(4893), 11L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 19L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Vision-oriented human-resource framework", new DateTime(2020, 6, 27, 4, 49, 59, 115, DateTimeKind.Unspecified).AddTicks(5318), 6L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 20L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Sharable eco-centric customer loyalty", new DateTime(2020, 5, 10, 5, 9, 34, 687, DateTimeKind.Unspecified).AddTicks(3495), 12L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 21L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "De-engineered interactive installation", new DateTime(2020, 10, 12, 11, 0, 18, 841, DateTimeKind.Unspecified).AddTicks(2493), 7L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 22L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Re-engineered executive infrastructure", new DateTime(2020, 3, 27, 0, 30, 11, 190, DateTimeKind.Unspecified).AddTicks(9815), 8L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 23L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Expanded context-sensitive system engine", new DateTime(2020, 4, 6, 17, 40, 58, 501, DateTimeKind.Unspecified).AddTicks(8961), 12L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 24L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Synergized modular core", new DateTime(2020, 3, 3, 19, 33, 8, 580, DateTimeKind.Unspecified).AddTicks(7440), 2L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 25L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Organic executive groupware", new DateTime(2020, 12, 3, 20, 43, 38, 327, DateTimeKind.Unspecified).AddTicks(2262), 11L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 26L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Persistent secondary framework", new DateTime(2020, 2, 9, 18, 58, 1, 635, DateTimeKind.Unspecified).AddTicks(9048), 9L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 27L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Customer-focused system-worthy protocol", new DateTime(2020, 2, 3, 10, 45, 29, 480, DateTimeKind.Unspecified).AddTicks(7138), 6L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 28L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Compatible eco-centric website", new DateTime(2020, 2, 29, 11, 44, 59, 644, DateTimeKind.Unspecified).AddTicks(8148), 12L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 29L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Triple-buffered demand-driven Graphic Interface", new DateTime(2020, 6, 6, 14, 15, 27, 519, DateTimeKind.Unspecified).AddTicks(861), 7L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 30L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 2m, "Vision-oriented asymmetric policy", new DateTime(2020, 12, 7, 5, 19, 5, 440, DateTimeKind.Unspecified).AddTicks(1582), 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 31L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Intuitive leading edge database", new DateTime(2020, 7, 23, 13, 25, 55, 407, DateTimeKind.Unspecified).AddTicks(9072), 1L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 32L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Reverse-engineered global open architecture", new DateTime(2020, 10, 27, 8, 29, 51, 396, DateTimeKind.Unspecified).AddTicks(2253), 1L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 33L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Automated global throughput", new DateTime(2020, 12, 6, 22, 22, 31, 628, DateTimeKind.Unspecified).AddTicks(177), 4L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 34L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Optional well-modulated capability", new DateTime(2020, 9, 5, 0, 48, 31, 804, DateTimeKind.Unspecified).AddTicks(426), 12L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 35L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 2m, "Secured analyzing groupware", new DateTime(2020, 2, 4, 20, 33, 45, 976, DateTimeKind.Unspecified).AddTicks(3854), 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 36L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Right-sized object-oriented task-force", new DateTime(2020, 11, 18, 5, 38, 53, 543, DateTimeKind.Unspecified).AddTicks(6320), 7L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 37L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Streamlined non-volatile initiative", new DateTime(2020, 7, 24, 5, 36, 6, 607, DateTimeKind.Unspecified).AddTicks(8244), 7L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 38L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Profound regional parallelism", new DateTime(2020, 9, 16, 20, 37, 51, 324, DateTimeKind.Unspecified).AddTicks(1998), 6L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 39L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Persistent background architecture", new DateTime(2020, 12, 25, 0, 57, 34, 766, DateTimeKind.Unspecified).AddTicks(6178), 12L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 40L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Grass-roots didactic benchmark", new DateTime(2020, 8, 7, 7, 46, 39, 116, DateTimeKind.Unspecified).AddTicks(180), 2L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 41L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Reactive 24 hour product", new DateTime(2020, 10, 8, 8, 13, 44, 348, DateTimeKind.Unspecified).AddTicks(1), 1L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 42L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Exclusive multimedia function", new DateTime(2020, 7, 17, 7, 3, 19, 929, DateTimeKind.Unspecified).AddTicks(3505), 2L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 43L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Face to face national hub", new DateTime(2020, 3, 8, 19, 57, 33, 23, DateTimeKind.Unspecified).AddTicks(2138), 9L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 44L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Polarised systematic methodology", new DateTime(2020, 11, 6, 1, 15, 7, 76, DateTimeKind.Unspecified).AddTicks(7021), 11L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 45L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Mandatory explicit Graphic Interface", new DateTime(2020, 3, 12, 14, 8, 13, 895, DateTimeKind.Unspecified).AddTicks(8494), 12L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 46L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Seamless web-enabled groupware", new DateTime(2020, 9, 5, 20, 47, 41, 708, DateTimeKind.Unspecified).AddTicks(4449), 10L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 47L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Multi-lateral next generation pricing structure", new DateTime(2020, 2, 20, 14, 1, 40, 344, DateTimeKind.Unspecified).AddTicks(3327), 5L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 48L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 1m, "Persistent multi-tasking hardware", new DateTime(2020, 10, 24, 7, 37, 9, 369, DateTimeKind.Unspecified).AddTicks(6814), 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 49L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 1m, "Decentralized clear-thinking circuit", new DateTime(2020, 2, 8, 15, 57, 5, 834, DateTimeKind.Unspecified).AddTicks(4724), 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 50L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Extended zero defect concept", new DateTime(2020, 3, 24, 0, 35, 23, 929, DateTimeKind.Unspecified).AddTicks(560), 6L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 51L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Re-contextualized 6th generation time-frame", new DateTime(2020, 3, 14, 4, 43, 18, 589, DateTimeKind.Unspecified).AddTicks(3195), 6L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 52L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Decentralized static knowledge user", new DateTime(2020, 10, 31, 19, 24, 23, 825, DateTimeKind.Unspecified).AddTicks(6741), 7L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 53L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Reactive zero administration projection", new DateTime(2020, 6, 3, 16, 51, 29, 20, DateTimeKind.Unspecified).AddTicks(9183), 1L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 54L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Seamless contextually-based methodology", new DateTime(2020, 11, 9, 2, 11, 4, 481, DateTimeKind.Unspecified).AddTicks(1443), 2L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 55L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Re-contextualized intermediate success", new DateTime(2020, 7, 12, 3, 14, 29, 853, DateTimeKind.Unspecified).AddTicks(7866), 11L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 56L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Polarised holistic open architecture", new DateTime(2020, 7, 25, 18, 53, 39, 706, DateTimeKind.Unspecified).AddTicks(7279), 3L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 57L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Fully-configurable modular methodology", new DateTime(2020, 12, 14, 13, 37, 14, 987, DateTimeKind.Unspecified).AddTicks(2430), 12L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 58L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 5m, "Adaptive fresh-thinking hardware", new DateTime(2020, 12, 23, 2, 28, 42, 190, DateTimeKind.Unspecified).AddTicks(2740), 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 59L,
                columns: new[] { "Comment", "Date", "ProjectId" },
                values: new object[] { "Stand-alone even-keeled framework", new DateTime(2020, 11, 14, 15, 53, 3, 441, DateTimeKind.Unspecified).AddTicks(1783), 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 60L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Front-line multi-state model", new DateTime(2020, 12, 15, 7, 58, 30, 723, DateTimeKind.Unspecified).AddTicks(4239), 10L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 61L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Networked background projection", new DateTime(2020, 12, 22, 14, 12, 41, 130, DateTimeKind.Unspecified).AddTicks(468), 4L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 62L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Persistent 24 hour benchmark", new DateTime(2020, 8, 20, 14, 29, 37, 647, DateTimeKind.Unspecified).AddTicks(3259), 2L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 63L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Customer-focused high-level utilisation", new DateTime(2020, 8, 17, 14, 14, 1, 573, DateTimeKind.Unspecified).AddTicks(3442), 4L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 64L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Cross-platform eco-centric Graphical User Interface", new DateTime(2020, 12, 7, 22, 23, 53, 590, DateTimeKind.Unspecified).AddTicks(4780), 12L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 65L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Versatile well-modulated collaboration", new DateTime(2020, 7, 29, 9, 2, 45, 523, DateTimeKind.Unspecified).AddTicks(8005), 12L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 66L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Front-line mobile model", new DateTime(2020, 6, 23, 1, 10, 7, 524, DateTimeKind.Unspecified).AddTicks(319), 6L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 67L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Future-proofed contextually-based open architecture", new DateTime(2020, 6, 19, 11, 40, 13, 152, DateTimeKind.Unspecified).AddTicks(214), 10L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 68L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Distributed multi-tasking instruction set", new DateTime(2020, 9, 18, 14, 45, 32, 694, DateTimeKind.Unspecified).AddTicks(2483), 2L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 69L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Seamless exuding flexibility", new DateTime(2020, 4, 20, 20, 37, 20, 283, DateTimeKind.Unspecified).AddTicks(6519), 11L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 70L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Automated value-added capacity", new DateTime(2020, 6, 18, 4, 5, 55, 396, DateTimeKind.Unspecified).AddTicks(6978), 7L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 71L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Switchable empowering secured line", new DateTime(2020, 3, 15, 7, 55, 55, 223, DateTimeKind.Unspecified).AddTicks(3218), 6L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 72L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Cloned object-oriented conglomeration", new DateTime(2020, 7, 26, 7, 13, 5, 33, DateTimeKind.Unspecified).AddTicks(7209), 9L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 73L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Focused national productivity", new DateTime(2020, 11, 6, 2, 55, 43, 208, DateTimeKind.Unspecified).AddTicks(3581), 12L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 74L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Enterprise-wide dynamic internet solution", new DateTime(2020, 2, 20, 5, 54, 36, 612, DateTimeKind.Unspecified).AddTicks(5063), 3L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 75L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Focused intangible complexity", new DateTime(2020, 8, 6, 22, 27, 24, 645, DateTimeKind.Unspecified).AddTicks(2577), 3L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 76L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Fundamental needs-based orchestration", new DateTime(2020, 5, 3, 2, 6, 53, 466, DateTimeKind.Unspecified).AddTicks(8147), 7L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 77L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Profound attitude-oriented core", new DateTime(2020, 8, 6, 9, 11, 31, 330, DateTimeKind.Unspecified).AddTicks(8462), 3L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 78L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Extended exuding matrices", new DateTime(2020, 11, 9, 13, 42, 20, 808, DateTimeKind.Unspecified).AddTicks(748), 12L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 79L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Ameliorated directional emulation", new DateTime(2020, 4, 26, 13, 34, 19, 16, DateTimeKind.Unspecified).AddTicks(1998), 6L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 80L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Diverse 3rd generation initiative", new DateTime(2020, 6, 23, 7, 53, 50, 529, DateTimeKind.Unspecified).AddTicks(6106), 5L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 81L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Visionary asymmetric functionalities", new DateTime(2020, 6, 4, 17, 55, 33, 381, DateTimeKind.Unspecified).AddTicks(1181), 6L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 82L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Diverse disintermediate utilisation", new DateTime(2020, 10, 24, 6, 29, 27, 777, DateTimeKind.Unspecified).AddTicks(3868), 5L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 83L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 1m, "Decentralized mission-critical complexity", new DateTime(2020, 7, 23, 9, 19, 50, 98, DateTimeKind.Unspecified).AddTicks(2879), 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 84L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Intuitive fresh-thinking array", new DateTime(2020, 9, 28, 23, 50, 18, 953, DateTimeKind.Unspecified).AddTicks(1413), 10L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 85L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Cloned optimal solution", new DateTime(2020, 11, 30, 4, 23, 24, 341, DateTimeKind.Unspecified).AddTicks(5620), 2L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 86L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 3m, "Focused cohesive intranet", new DateTime(2020, 10, 16, 15, 19, 39, 434, DateTimeKind.Unspecified).AddTicks(629), 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 87L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Virtual dynamic approach", new DateTime(2020, 1, 11, 10, 17, 54, 125, DateTimeKind.Unspecified).AddTicks(7810), 3L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 88L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Inverse disintermediate support", new DateTime(2020, 10, 11, 1, 42, 44, 629, DateTimeKind.Unspecified).AddTicks(8124), 6L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 89L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Programmable directional moratorium", new DateTime(2020, 8, 26, 23, 47, 45, 370, DateTimeKind.Unspecified).AddTicks(7516), 6L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 90L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Organic bandwidth-monitored emulation", new DateTime(2020, 2, 17, 6, 50, 3, 311, DateTimeKind.Unspecified).AddTicks(5829), 4L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 91L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Intuitive multimedia synergy", new DateTime(2020, 9, 27, 13, 28, 56, 282, DateTimeKind.Unspecified).AddTicks(8466), 7L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 92L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Configurable 4th generation intranet", new DateTime(2020, 6, 25, 5, 27, 37, 141, DateTimeKind.Unspecified).AddTicks(2253), 3L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 93L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Mandatory value-added methodology", new DateTime(2020, 5, 27, 1, 21, 0, 30, DateTimeKind.Unspecified).AddTicks(8933), 9L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 94L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Up-sized system-worthy artificial intelligence", new DateTime(2020, 9, 13, 20, 32, 9, 844, DateTimeKind.Unspecified).AddTicks(5793), 8L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 95L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Digitized responsive synergy", new DateTime(2020, 9, 19, 0, 44, 40, 795, DateTimeKind.Unspecified).AddTicks(2774), 2L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 96L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Profit-focused zero defect website", new DateTime(2020, 3, 12, 11, 20, 52, 856, DateTimeKind.Unspecified).AddTicks(8860), 12L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 97L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 5m, "Ergonomic bandwidth-monitored conglomeration", new DateTime(2020, 2, 27, 22, 51, 4, 394, DateTimeKind.Unspecified).AddTicks(1055), 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 98L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Devolved multi-tasking knowledge base", new DateTime(2020, 6, 9, 4, 38, 22, 896, DateTimeKind.Unspecified).AddTicks(529), 8L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 99L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Robust secondary superstructure", new DateTime(2020, 3, 24, 9, 33, 26, 922, DateTimeKind.Unspecified).AddTicks(6246), 10L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 100L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Enterprise-wide modular analyzer", new DateTime(2020, 1, 5, 7, 13, 4, 694, DateTimeKind.Unspecified).AddTicks(7165), 2L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 101L,
                columns: new[] { "AmountOfHours", "Comment", "Date" },
                values: new object[] { 7m, "Versatile modular product", new DateTime(2020, 9, 3, 16, 38, 11, 233, DateTimeKind.Unspecified).AddTicks(6941) });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 102L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Reverse-engineered tangible software", new DateTime(2020, 1, 25, 2, 45, 28, 364, DateTimeKind.Unspecified).AddTicks(4991), 3L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 103L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Cross-platform even-keeled interface", new DateTime(2020, 4, 13, 15, 29, 43, 459, DateTimeKind.Unspecified).AddTicks(1514), 12L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 104L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "De-engineered asymmetric capacity", new DateTime(2020, 7, 9, 14, 4, 0, 143, DateTimeKind.Unspecified).AddTicks(7354), 5L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 105L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Networked clear-thinking monitoring", new DateTime(2020, 8, 26, 16, 6, 49, 475, DateTimeKind.Unspecified).AddTicks(6844), 7L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 106L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Assimilated regional monitoring", new DateTime(2020, 5, 6, 7, 6, 40, 647, DateTimeKind.Unspecified).AddTicks(7952), 6L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 107L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Upgradable 6th generation model", new DateTime(2020, 10, 23, 19, 59, 5, 336, DateTimeKind.Unspecified).AddTicks(908), 6L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 108L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Extended intangible artificial intelligence", new DateTime(2020, 11, 27, 7, 10, 2, 386, DateTimeKind.Unspecified).AddTicks(7131), 3L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 109L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Optional mobile knowledge base", new DateTime(2020, 11, 30, 4, 2, 37, 670, DateTimeKind.Unspecified).AddTicks(5121), 5L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 110L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Realigned client-server moderator", new DateTime(2020, 9, 2, 9, 10, 8, 567, DateTimeKind.Unspecified).AddTicks(9074), 7L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 111L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Optional systematic installation", new DateTime(2020, 10, 17, 13, 38, 22, 444, DateTimeKind.Unspecified).AddTicks(9339), 10L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 112L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Ameliorated incremental synergy", new DateTime(2020, 11, 10, 17, 29, 25, 550, DateTimeKind.Unspecified).AddTicks(7962), 6L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 113L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Proactive leading edge emulation", new DateTime(2020, 11, 25, 0, 5, 6, 119, DateTimeKind.Unspecified).AddTicks(6433), 8L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 114L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Devolved attitude-oriented artificial intelligence", new DateTime(2020, 6, 4, 13, 46, 44, 350, DateTimeKind.Unspecified).AddTicks(9625), 9L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 115L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Synergized zero tolerance utilisation", new DateTime(2020, 10, 5, 6, 9, 18, 692, DateTimeKind.Unspecified).AddTicks(916), 10L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 116L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Progressive methodical hardware", new DateTime(2020, 1, 7, 9, 38, 58, 130, DateTimeKind.Unspecified).AddTicks(1624), 6L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 117L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 5m, "Configurable multimedia utilisation", new DateTime(2020, 7, 26, 19, 15, 59, 842, DateTimeKind.Unspecified).AddTicks(6099), 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 118L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Polarised executive superstructure", new DateTime(2020, 1, 17, 18, 17, 59, 10, DateTimeKind.Unspecified).AddTicks(7140), 7L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 119L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Reverse-engineered foreground application", new DateTime(2020, 8, 12, 18, 19, 54, 662, DateTimeKind.Unspecified).AddTicks(9131), 7L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 120L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Open-source user-facing migration", new DateTime(2020, 1, 2, 23, 18, 41, 627, DateTimeKind.Unspecified).AddTicks(8452), 8L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 121L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 8m, "Versatile static challenge", new DateTime(2020, 6, 30, 10, 13, 54, 487, DateTimeKind.Unspecified).AddTicks(9337), 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 122L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Multi-channelled bandwidth-monitored architecture", new DateTime(2020, 12, 15, 2, 11, 9, 415, DateTimeKind.Unspecified).AddTicks(1349), 5L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 123L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Pre-emptive analyzing emulation", new DateTime(2020, 2, 23, 21, 35, 25, 554, DateTimeKind.Unspecified).AddTicks(271), 9L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 124L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Distributed explicit strategy", new DateTime(2020, 5, 1, 10, 2, 20, 207, DateTimeKind.Unspecified).AddTicks(4505), 12L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 125L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Reactive even-keeled algorithm", new DateTime(2020, 5, 19, 22, 29, 27, 335, DateTimeKind.Unspecified).AddTicks(8817), 11L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 126L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Open-architected optimal attitude", new DateTime(2020, 2, 11, 0, 59, 14, 125, DateTimeKind.Unspecified).AddTicks(9663), 7L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 127L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Face to face zero defect concept", new DateTime(2020, 4, 28, 7, 0, 31, 16, DateTimeKind.Unspecified).AddTicks(844), 5L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 128L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Synergistic encompassing success", new DateTime(2020, 11, 23, 21, 28, 54, 936, DateTimeKind.Unspecified).AddTicks(2704), 6L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 129L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Multi-layered discrete hardware", new DateTime(2020, 1, 18, 23, 4, 11, 578, DateTimeKind.Unspecified).AddTicks(478), 4L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 130L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Right-sized 5th generation info-mediaries", new DateTime(2020, 6, 27, 19, 38, 8, 850, DateTimeKind.Unspecified).AddTicks(7308), 2L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 131L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Future-proofed clear-thinking core", new DateTime(2020, 8, 9, 3, 28, 36, 345, DateTimeKind.Unspecified).AddTicks(4740), 9L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 132L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Integrated multi-tasking knowledge base", new DateTime(2020, 8, 12, 20, 9, 0, 176, DateTimeKind.Unspecified).AddTicks(8799), 9L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 133L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Advanced bi-directional Graphical User Interface", new DateTime(2020, 9, 7, 21, 7, 9, 86, DateTimeKind.Unspecified).AddTicks(1007), 5L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 134L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Mandatory neutral conglomeration", new DateTime(2020, 11, 18, 1, 45, 22, 931, DateTimeKind.Unspecified).AddTicks(3478), 2L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 135L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Upgradable object-oriented contingency", new DateTime(2020, 7, 22, 6, 55, 12, 261, DateTimeKind.Unspecified).AddTicks(3457), 10L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 136L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Devolved multi-state parallelism", new DateTime(2020, 10, 14, 13, 12, 32, 625, DateTimeKind.Unspecified).AddTicks(6589), 2L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 137L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 1m, "Pre-emptive systematic matrices", new DateTime(2020, 11, 14, 5, 45, 26, 400, DateTimeKind.Unspecified).AddTicks(8052), 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 138L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Triple-buffered 6th generation product", new DateTime(2020, 11, 30, 1, 39, 32, 412, DateTimeKind.Unspecified).AddTicks(4683), 12L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 139L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Multi-lateral 24/7 moderator", new DateTime(2020, 1, 29, 7, 41, 2, 226, DateTimeKind.Unspecified).AddTicks(3545), 3L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 140L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "User-centric encompassing structure", new DateTime(2020, 5, 23, 18, 20, 28, 83, DateTimeKind.Unspecified).AddTicks(2911), 3L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 141L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Multi-layered needs-based core", new DateTime(2020, 4, 24, 20, 51, 55, 94, DateTimeKind.Unspecified).AddTicks(1558), 8L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 142L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 7m, "Streamlined mobile ability", new DateTime(2020, 12, 13, 23, 51, 12, 182, DateTimeKind.Unspecified).AddTicks(9069), 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 143L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Progressive heuristic solution", new DateTime(2020, 10, 6, 15, 45, 42, 129, DateTimeKind.Unspecified).AddTicks(3091), 7L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 144L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Profit-focused analyzing website", new DateTime(2020, 8, 15, 16, 25, 19, 666, DateTimeKind.Unspecified).AddTicks(7261), 5L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 145L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Open-architected non-volatile success", new DateTime(2020, 8, 19, 7, 50, 58, 828, DateTimeKind.Unspecified).AddTicks(2285), 11L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 146L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Horizontal interactive focus group", new DateTime(2020, 12, 2, 20, 47, 40, 941, DateTimeKind.Unspecified).AddTicks(3198), 9L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 147L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Intuitive motivating budgetary management", new DateTime(2020, 2, 5, 12, 9, 26, 40, DateTimeKind.Unspecified).AddTicks(6436), 5L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 148L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Team-oriented 3rd generation migration", new DateTime(2020, 6, 7, 17, 15, 36, 941, DateTimeKind.Unspecified).AddTicks(8925), 3L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 149L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Polarised dedicated customer loyalty", new DateTime(2020, 2, 15, 14, 4, 8, 360, DateTimeKind.Unspecified).AddTicks(1463), 7L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 150L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Triple-buffered bandwidth-monitored benchmark", new DateTime(2020, 2, 15, 11, 9, 42, 944, DateTimeKind.Unspecified).AddTicks(2047), 1L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 151L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Universal impactful solution", new DateTime(2020, 8, 5, 7, 59, 31, 209, DateTimeKind.Unspecified).AddTicks(5171), 7L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 152L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Mandatory stable toolset", new DateTime(2020, 1, 31, 15, 51, 15, 235, DateTimeKind.Unspecified).AddTicks(5692), 11L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 153L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Public-key dedicated orchestration", new DateTime(2020, 5, 31, 20, 27, 44, 127, DateTimeKind.Unspecified).AddTicks(9355), 11L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 154L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Face to face asynchronous circuit", new DateTime(2020, 8, 6, 17, 21, 55, 298, DateTimeKind.Unspecified).AddTicks(4404), 10L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 155L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Open-architected 24/7 framework", new DateTime(2020, 4, 24, 3, 19, 35, 947, DateTimeKind.Unspecified).AddTicks(4393), 10L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 156L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Open-source reciprocal middleware", new DateTime(2020, 12, 20, 15, 24, 29, 88, DateTimeKind.Unspecified).AddTicks(542), 3L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 157L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Inverse directional open architecture", new DateTime(2020, 8, 6, 22, 20, 48, 12, DateTimeKind.Unspecified).AddTicks(7679), 2L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 158L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Synergized full-range budgetary management", new DateTime(2020, 9, 9, 3, 11, 31, 933, DateTimeKind.Unspecified).AddTicks(7699), 1L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 159L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Intuitive multi-tasking process improvement", new DateTime(2020, 7, 20, 9, 19, 13, 734, DateTimeKind.Unspecified).AddTicks(2123), 7L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 160L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Stand-alone maximized application", new DateTime(2020, 9, 29, 9, 2, 36, 887, DateTimeKind.Unspecified).AddTicks(4362), 5L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 161L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Multi-layered asynchronous policy", new DateTime(2020, 8, 27, 19, 33, 30, 862, DateTimeKind.Unspecified).AddTicks(1761), 10L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 162L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Sharable human-resource open architecture", new DateTime(2020, 7, 31, 15, 31, 11, 216, DateTimeKind.Unspecified).AddTicks(5914), 4L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 163L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Persistent context-sensitive policy", new DateTime(2020, 4, 13, 17, 3, 49, 794, DateTimeKind.Unspecified).AddTicks(7723), 11L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 164L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Configurable static middleware", new DateTime(2020, 5, 10, 3, 5, 56, 956, DateTimeKind.Unspecified).AddTicks(9506), 4L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 165L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Quality-focused modular process improvement", new DateTime(2020, 4, 5, 16, 41, 36, 946, DateTimeKind.Unspecified).AddTicks(4791), 4L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 166L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Function-based fresh-thinking encoding", new DateTime(2020, 1, 18, 22, 9, 10, 323, DateTimeKind.Unspecified).AddTicks(5324), 12L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 167L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Digitized analyzing emulation", new DateTime(2020, 9, 30, 9, 5, 55, 645, DateTimeKind.Unspecified).AddTicks(4811), 2L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 168L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Horizontal eco-centric instruction set", new DateTime(2020, 4, 7, 23, 38, 32, 181, DateTimeKind.Unspecified).AddTicks(1146), 1L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 169L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Ergonomic background infrastructure", new DateTime(2020, 1, 20, 17, 0, 25, 493, DateTimeKind.Unspecified).AddTicks(1243), 2L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 170L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 1m, "Synergistic upward-trending ability", new DateTime(2020, 4, 16, 21, 8, 13, 277, DateTimeKind.Unspecified).AddTicks(5852), 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 171L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Stand-alone grid-enabled solution", new DateTime(2020, 4, 2, 17, 26, 30, 84, DateTimeKind.Unspecified).AddTicks(8800), 6L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 172L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Robust empowering attitude", new DateTime(2020, 7, 7, 10, 0, 25, 607, DateTimeKind.Unspecified).AddTicks(5893), 5L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 173L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 3m, "Front-line dedicated core", new DateTime(2020, 5, 11, 0, 43, 21, 509, DateTimeKind.Unspecified).AddTicks(4069), 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 174L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 1m, "Face to face secondary solution", new DateTime(2020, 1, 11, 22, 14, 7, 296, DateTimeKind.Unspecified).AddTicks(6552), 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 175L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Customizable discrete knowledge base", new DateTime(2020, 6, 25, 20, 8, 34, 658, DateTimeKind.Unspecified).AddTicks(9334), 3L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 176L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Team-oriented multi-tasking leverage", new DateTime(2020, 12, 17, 11, 36, 10, 874, DateTimeKind.Unspecified).AddTicks(2366), 9L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 177L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Seamless executive pricing structure", new DateTime(2020, 6, 10, 11, 22, 42, 268, DateTimeKind.Unspecified).AddTicks(408), 4L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 178L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Progressive real-time solution", new DateTime(2020, 10, 17, 10, 53, 38, 98, DateTimeKind.Unspecified).AddTicks(999), 3L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 179L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 5m, "Pre-emptive zero tolerance project", new DateTime(2020, 3, 10, 22, 14, 12, 543, DateTimeKind.Unspecified).AddTicks(4181), 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 180L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Automated leading edge challenge", new DateTime(2020, 8, 10, 5, 32, 11, 682, DateTimeKind.Unspecified).AddTicks(6854), 12L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 181L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Persevering multimedia alliance", new DateTime(2020, 10, 13, 7, 8, 16, 732, DateTimeKind.Unspecified).AddTicks(5688), 6L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 182L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Monitored attitude-oriented firmware", new DateTime(2020, 8, 12, 16, 26, 54, 908, DateTimeKind.Unspecified).AddTicks(925), 7L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 183L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Open-source neutral website", new DateTime(2020, 10, 7, 10, 57, 34, 476, DateTimeKind.Unspecified).AddTicks(8621), 10L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 184L,
                columns: new[] { "Comment", "Date", "ProjectId" },
                values: new object[] { "Progressive regional internet solution", new DateTime(2020, 1, 5, 20, 38, 8, 26, DateTimeKind.Unspecified).AddTicks(2617), 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 185L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Self-enabling logistical focus group", new DateTime(2020, 11, 4, 15, 6, 30, 857, DateTimeKind.Unspecified).AddTicks(1288), 7L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 186L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Cross-group scalable productivity", new DateTime(2020, 2, 21, 3, 44, 45, 371, DateTimeKind.Unspecified).AddTicks(3188), 8L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 187L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Total holistic model", new DateTime(2020, 1, 12, 13, 24, 24, 677, DateTimeKind.Unspecified).AddTicks(2386), 5L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 188L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Synchronised client-server collaboration", new DateTime(2020, 2, 28, 22, 0, 7, 434, DateTimeKind.Unspecified).AddTicks(6241), 8L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 189L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Synergistic impactful throughput", new DateTime(2020, 2, 26, 22, 58, 41, 433, DateTimeKind.Unspecified).AddTicks(6706), 10L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 190L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 6m, "Open-source zero defect website", new DateTime(2020, 10, 4, 9, 38, 3, 417, DateTimeKind.Unspecified).AddTicks(6449), 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 191L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Total cohesive capacity", new DateTime(2020, 5, 16, 1, 5, 30, 536, DateTimeKind.Unspecified).AddTicks(9202), 3L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 192L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Fully-configurable tertiary challenge", new DateTime(2020, 1, 31, 20, 7, 13, 943, DateTimeKind.Unspecified).AddTicks(5393), 12L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 193L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 8m, "Integrated bottom-line superstructure", new DateTime(2020, 3, 23, 2, 27, 34, 574, DateTimeKind.Unspecified).AddTicks(7888), 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 194L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Focused stable structure", new DateTime(2020, 3, 8, 15, 52, 29, 640, DateTimeKind.Unspecified).AddTicks(3558), 10L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 195L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Networked multimedia monitoring", new DateTime(2020, 7, 15, 4, 6, 31, 363, DateTimeKind.Unspecified).AddTicks(6321), 3L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 196L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Virtual 3rd generation hierarchy", new DateTime(2020, 2, 12, 20, 52, 39, 784, DateTimeKind.Unspecified).AddTicks(9212), 10L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 197L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Polarised reciprocal process improvement", new DateTime(2020, 2, 19, 20, 23, 59, 426, DateTimeKind.Unspecified).AddTicks(5189), 2L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 198L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Stand-alone asymmetric help-desk", new DateTime(2020, 9, 13, 9, 57, 24, 487, DateTimeKind.Unspecified).AddTicks(7106), 8L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 199L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Horizontal directional function", new DateTime(2020, 2, 27, 5, 2, 25, 965, DateTimeKind.Unspecified).AddTicks(8767), 9L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 200L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Ergonomic impactful product", new DateTime(2020, 5, 27, 16, 35, 4, 240, DateTimeKind.Unspecified).AddTicks(191), 11L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 201L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Cross-platform high-level hub", new DateTime(2020, 12, 24, 20, 24, 36, 836, DateTimeKind.Unspecified).AddTicks(2939), 11L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 202L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Balanced background paradigm", new DateTime(2020, 9, 11, 13, 57, 45, 629, DateTimeKind.Unspecified).AddTicks(2106), 9L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 203L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Organized context-sensitive local area network", new DateTime(2020, 4, 3, 0, 6, 11, 437, DateTimeKind.Unspecified).AddTicks(2935), 8L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 204L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Reduced actuating architecture", new DateTime(2020, 5, 16, 19, 14, 39, 246, DateTimeKind.Unspecified).AddTicks(4266), 7L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 205L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Extended zero defect complexity", new DateTime(2020, 9, 26, 13, 57, 36, 87, DateTimeKind.Unspecified).AddTicks(9226), 6L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 206L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Pre-emptive zero administration parallelism", new DateTime(2020, 9, 13, 16, 15, 20, 195, DateTimeKind.Unspecified).AddTicks(4250), 2L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 207L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "De-engineered multi-tasking toolset", new DateTime(2020, 11, 30, 15, 41, 10, 408, DateTimeKind.Unspecified).AddTicks(3527), 9L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 208L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Extended cohesive emulation", new DateTime(2020, 2, 25, 16, 47, 16, 970, DateTimeKind.Unspecified).AddTicks(1831), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 209L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Integrated exuding functionalities", new DateTime(2020, 10, 23, 17, 43, 41, 590, DateTimeKind.Unspecified).AddTicks(4101), 4L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 210L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Cross-platform incremental firmware", new DateTime(2020, 4, 24, 7, 16, 35, 477, DateTimeKind.Unspecified).AddTicks(6409), 2L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 211L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Exclusive static implementation", new DateTime(2020, 12, 23, 9, 16, 38, 735, DateTimeKind.Unspecified).AddTicks(2944), 6L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 212L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Integrated background protocol", new DateTime(2020, 4, 22, 9, 14, 13, 181, DateTimeKind.Unspecified).AddTicks(7084), 8L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 213L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 8m, "Seamless uniform emulation", new DateTime(2020, 9, 12, 12, 30, 40, 996, DateTimeKind.Unspecified).AddTicks(8347), 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 214L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Persistent empowering secured line", new DateTime(2020, 4, 26, 1, 23, 48, 689, DateTimeKind.Unspecified).AddTicks(7653), 7L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 215L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 1m, "Customizable multimedia matrix", new DateTime(2020, 7, 9, 19, 55, 31, 241, DateTimeKind.Unspecified).AddTicks(137), 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 216L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 1m, "Grass-roots secondary moderator", new DateTime(2020, 9, 23, 17, 58, 53, 369, DateTimeKind.Unspecified).AddTicks(2509), 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 217L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Expanded logistical parallelism", new DateTime(2020, 10, 18, 15, 46, 50, 479, DateTimeKind.Unspecified).AddTicks(8537), 5L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 218L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Phased 4th generation workforce", new DateTime(2020, 10, 17, 14, 27, 18, 724, DateTimeKind.Unspecified).AddTicks(3215), 8L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 219L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Open-architected motivating workforce", new DateTime(2020, 9, 22, 13, 9, 24, 124, DateTimeKind.Unspecified).AddTicks(6495), 11L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 220L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 2m, "Multi-layered composite website", new DateTime(2020, 7, 20, 10, 10, 58, 89, DateTimeKind.Unspecified).AddTicks(9767), 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 221L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Compatible modular utilisation", new DateTime(2020, 12, 21, 10, 40, 50, 124, DateTimeKind.Unspecified).AddTicks(5141), 5L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 222L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Reverse-engineered asynchronous benchmark", new DateTime(2020, 3, 22, 10, 50, 8, 316, DateTimeKind.Unspecified).AddTicks(6185), 12L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 223L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Phased methodical system engine", new DateTime(2020, 9, 10, 9, 7, 16, 480, DateTimeKind.Unspecified).AddTicks(7297), 7L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 224L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Devolved multimedia emulation", new DateTime(2020, 5, 15, 9, 22, 7, 55, DateTimeKind.Unspecified).AddTicks(5415), 9L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 225L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 7m, "Implemented optimal utilisation", new DateTime(2020, 10, 4, 12, 47, 47, 340, DateTimeKind.Unspecified).AddTicks(512), 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 226L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Intuitive 3rd generation definition", new DateTime(2020, 11, 30, 16, 36, 27, 727, DateTimeKind.Unspecified).AddTicks(7980), 2L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 227L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Optional systemic structure", new DateTime(2020, 4, 29, 17, 37, 49, 461, DateTimeKind.Unspecified).AddTicks(1189), 1L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 228L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Phased 6th generation structure", new DateTime(2020, 9, 13, 13, 17, 55, 8, DateTimeKind.Unspecified).AddTicks(7827), 12L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 229L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Visionary needs-based moratorium", new DateTime(2020, 8, 5, 12, 34, 14, 196, DateTimeKind.Unspecified).AddTicks(8050), 4L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 230L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Grass-roots bottom-line focus group", new DateTime(2020, 7, 16, 18, 47, 52, 608, DateTimeKind.Unspecified).AddTicks(4294), 11L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 231L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Organized multi-state function", new DateTime(2020, 1, 14, 6, 26, 3, 133, DateTimeKind.Unspecified).AddTicks(2341), 7L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 232L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Seamless fresh-thinking monitoring", new DateTime(2020, 1, 30, 16, 10, 28, 929, DateTimeKind.Unspecified).AddTicks(506), 5L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 233L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Public-key asymmetric neural-net", new DateTime(2020, 12, 5, 15, 41, 11, 893, DateTimeKind.Unspecified).AddTicks(8405), 3L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 234L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Fundamental methodical standardization", new DateTime(2020, 8, 7, 5, 21, 34, 64, DateTimeKind.Unspecified).AddTicks(9808), 1L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 235L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Realigned interactive capability", new DateTime(2020, 5, 19, 14, 28, 16, 929, DateTimeKind.Unspecified).AddTicks(1557), 1L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 236L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Intuitive hybrid implementation", new DateTime(2020, 9, 2, 4, 0, 29, 919, DateTimeKind.Unspecified).AddTicks(3643), 7L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 237L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Extended 24/7 success", new DateTime(2020, 4, 15, 1, 43, 53, 941, DateTimeKind.Unspecified).AddTicks(4864), 5L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 238L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Business-focused multi-state neural-net", new DateTime(2020, 8, 13, 13, 24, 1, 53, DateTimeKind.Unspecified).AddTicks(6693), 6L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 239L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Balanced incremental implementation", new DateTime(2020, 10, 10, 7, 40, 7, 443, DateTimeKind.Unspecified).AddTicks(9118), 4L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 240L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Synergized hybrid encryption", new DateTime(2020, 6, 5, 14, 35, 13, 431, DateTimeKind.Unspecified).AddTicks(207), 5L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 241L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Persevering composite moratorium", new DateTime(2020, 9, 23, 16, 31, 18, 247, DateTimeKind.Unspecified).AddTicks(1591), 10L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 242L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Persevering zero administration migration", new DateTime(2020, 3, 24, 23, 2, 0, 589, DateTimeKind.Unspecified).AddTicks(5810), 3L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 243L,
                columns: new[] { "AmountOfHours", "Comment", "Date" },
                values: new object[] { 6m, "Synergized holistic middleware", new DateTime(2020, 7, 14, 20, 5, 24, 190, DateTimeKind.Unspecified).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 244L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Virtual zero tolerance encryption", new DateTime(2020, 10, 22, 8, 41, 7, 871, DateTimeKind.Unspecified).AddTicks(4540), 10L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 245L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Object-based logistical access", new DateTime(2020, 2, 17, 6, 12, 7, 303, DateTimeKind.Unspecified).AddTicks(7702), 5L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 246L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Monitored 24/7 moderator", new DateTime(2020, 5, 20, 19, 0, 36, 763, DateTimeKind.Unspecified).AddTicks(1665), 2L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 247L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Optional stable architecture", new DateTime(2020, 3, 4, 12, 39, 21, 765, DateTimeKind.Unspecified).AddTicks(9274), 12L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 248L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Assimilated needs-based challenge", new DateTime(2020, 6, 4, 9, 4, 13, 502, DateTimeKind.Unspecified).AddTicks(1204), 5L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 249L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Down-sized executive workforce", new DateTime(2020, 12, 10, 3, 7, 36, 862, DateTimeKind.Unspecified).AddTicks(615), 6L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 250L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Integrated mission-critical secured line", new DateTime(2020, 8, 27, 11, 17, 12, 757, DateTimeKind.Unspecified).AddTicks(3757), 11L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 251L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Multi-channelled well-modulated artificial intelligence", new DateTime(2020, 3, 1, 8, 57, 44, 23, DateTimeKind.Unspecified).AddTicks(6453), 5L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 252L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "De-engineered context-sensitive structure", new DateTime(2020, 11, 18, 9, 3, 41, 900, DateTimeKind.Unspecified).AddTicks(9238), 12L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 253L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Total static workforce", new DateTime(2020, 5, 30, 18, 50, 56, 760, DateTimeKind.Unspecified).AddTicks(2772), 12L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 254L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Profit-focused multi-state neural-net", new DateTime(2020, 11, 15, 8, 32, 18, 970, DateTimeKind.Unspecified).AddTicks(6010), 6L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 255L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Enhanced demand-driven analyzer", new DateTime(2020, 5, 22, 20, 6, 38, 862, DateTimeKind.Unspecified).AddTicks(7801), 9L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 256L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Realigned analyzing ability", new DateTime(2020, 7, 26, 5, 58, 53, 660, DateTimeKind.Unspecified).AddTicks(1566), 4L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 257L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Customizable bandwidth-monitored infrastructure", new DateTime(2020, 3, 9, 11, 44, 7, 866, DateTimeKind.Unspecified).AddTicks(2583), 5L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 258L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Right-sized solution-oriented support", new DateTime(2020, 8, 8, 10, 32, 6, 148, DateTimeKind.Unspecified).AddTicks(9210), 9L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 259L,
                columns: new[] { "Comment", "Date", "ProjectId" },
                values: new object[] { "Fully-configurable full-range support", new DateTime(2020, 3, 15, 16, 27, 48, 711, DateTimeKind.Unspecified).AddTicks(6228), 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 260L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "User-friendly secondary contingency", new DateTime(2020, 4, 6, 20, 6, 21, 138, DateTimeKind.Unspecified).AddTicks(7161), 6L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 261L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Robust zero defect neural-net", new DateTime(2020, 11, 27, 6, 20, 15, 107, DateTimeKind.Unspecified).AddTicks(790), 5L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 262L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 5m, "Operative coherent analyzer", new DateTime(2020, 3, 4, 3, 21, 1, 159, DateTimeKind.Unspecified).AddTicks(9323), 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 263L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Monitored bifurcated alliance", new DateTime(2020, 8, 31, 9, 23, 28, 464, DateTimeKind.Unspecified).AddTicks(9571), 12L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 264L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Profound asynchronous circuit", new DateTime(2020, 10, 8, 3, 15, 49, 839, DateTimeKind.Unspecified).AddTicks(5125), 7L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 265L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Focused demand-driven throughput", new DateTime(2020, 2, 14, 10, 0, 3, 760, DateTimeKind.Unspecified).AddTicks(1519), 5L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 266L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Streamlined contextually-based firmware", new DateTime(2020, 4, 27, 16, 47, 49, 825, DateTimeKind.Unspecified).AddTicks(441), 8L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 267L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Enhanced systematic service-desk", new DateTime(2020, 4, 21, 17, 3, 37, 972, DateTimeKind.Unspecified).AddTicks(9897), 9L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 268L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Progressive client-server infrastructure", new DateTime(2020, 6, 24, 15, 58, 12, 533, DateTimeKind.Unspecified).AddTicks(847), 6L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 269L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Team-oriented hybrid protocol", new DateTime(2020, 10, 10, 9, 33, 56, 308, DateTimeKind.Unspecified).AddTicks(9871), 10L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 270L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 2m, "Up-sized attitude-oriented structure", new DateTime(2020, 4, 25, 23, 14, 5, 541, DateTimeKind.Unspecified).AddTicks(2718), 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 271L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Triple-buffered non-volatile forecast", new DateTime(2020, 6, 16, 23, 40, 26, 266, DateTimeKind.Unspecified).AddTicks(7561), 4L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 272L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Enterprise-wide even-keeled strategy", new DateTime(2020, 8, 18, 6, 58, 46, 300, DateTimeKind.Unspecified).AddTicks(9412), 4L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 273L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Centralized holistic support", new DateTime(2020, 9, 3, 12, 15, 58, 395, DateTimeKind.Unspecified).AddTicks(9487), 7L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 274L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Re-engineered hybrid solution", new DateTime(2020, 11, 19, 18, 45, 53, 199, DateTimeKind.Unspecified).AddTicks(9843), 12L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 275L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Right-sized value-added methodology", new DateTime(2020, 7, 17, 2, 37, 14, 253, DateTimeKind.Unspecified).AddTicks(4795), 4L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 276L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Multi-lateral bandwidth-monitored capacity", new DateTime(2020, 12, 1, 8, 54, 57, 619, DateTimeKind.Unspecified).AddTicks(7601), 9L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 277L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Customizable value-added help-desk", new DateTime(2020, 9, 10, 16, 34, 11, 787, DateTimeKind.Unspecified).AddTicks(1956), 5L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 278L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Proactive zero administration internet solution", new DateTime(2020, 8, 12, 18, 47, 38, 254, DateTimeKind.Unspecified).AddTicks(3331), 10L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 279L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Enhanced hybrid forecast", new DateTime(2020, 8, 27, 9, 57, 36, 999, DateTimeKind.Unspecified).AddTicks(2098), 6L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 280L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Integrated demand-driven application", new DateTime(2020, 2, 16, 7, 8, 34, 273, DateTimeKind.Unspecified).AddTicks(5318), 8L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 281L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Fundamental radical success", new DateTime(2020, 11, 11, 3, 58, 50, 362, DateTimeKind.Unspecified).AddTicks(1091), 5L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 282L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 5m, "Optional fresh-thinking local area network", new DateTime(2020, 4, 20, 14, 13, 9, 574, DateTimeKind.Unspecified).AddTicks(9941), 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 283L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Virtual asymmetric implementation", new DateTime(2020, 6, 12, 22, 48, 3, 52, DateTimeKind.Unspecified).AddTicks(7032), 6L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 284L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 2m, "Pre-emptive scalable complexity", new DateTime(2020, 8, 6, 15, 24, 23, 281, DateTimeKind.Unspecified).AddTicks(4472), 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 285L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Public-key explicit productivity", new DateTime(2020, 3, 3, 23, 13, 14, 868, DateTimeKind.Unspecified).AddTicks(6438), 11L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 286L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Down-sized motivating functionalities", new DateTime(2020, 3, 28, 3, 29, 58, 140, DateTimeKind.Unspecified).AddTicks(6047), 5L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 287L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Compatible reciprocal benchmark", new DateTime(2020, 8, 1, 4, 23, 44, 859, DateTimeKind.Unspecified).AddTicks(2138), 2L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 288L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Devolved methodical circuit", new DateTime(2020, 5, 8, 23, 17, 19, 427, DateTimeKind.Unspecified).AddTicks(4461), 6L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 289L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "User-centric needs-based forecast", new DateTime(2020, 5, 16, 23, 25, 38, 907, DateTimeKind.Unspecified).AddTicks(4972), 8L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 290L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Assimilated regional hub", new DateTime(2020, 11, 3, 7, 31, 54, 807, DateTimeKind.Unspecified).AddTicks(2756), 3L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 291L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Mandatory analyzing application", new DateTime(2020, 10, 31, 10, 15, 7, 566, DateTimeKind.Unspecified).AddTicks(8373), 11L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 292L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Ameliorated analyzing superstructure", new DateTime(2020, 7, 29, 17, 32, 37, 358, DateTimeKind.Unspecified).AddTicks(6475), 11L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 293L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Robust mission-critical functionalities", new DateTime(2020, 4, 30, 21, 47, 58, 268, DateTimeKind.Unspecified).AddTicks(4319), 6L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 294L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "User-friendly 5th generation pricing structure", new DateTime(2020, 8, 1, 23, 37, 20, 491, DateTimeKind.Unspecified).AddTicks(8635), 3L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 295L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Vision-oriented multi-tasking website", new DateTime(2020, 10, 21, 5, 58, 4, 300, DateTimeKind.Unspecified).AddTicks(7381), 6L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 296L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Open-source background leverage", new DateTime(2020, 8, 31, 16, 27, 33, 291, DateTimeKind.Unspecified).AddTicks(1472), 3L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 297L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Polarised heuristic policy", new DateTime(2020, 3, 7, 16, 10, 30, 465, DateTimeKind.Unspecified).AddTicks(7954), 4L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 298L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Devolved actuating open architecture", new DateTime(2020, 5, 10, 15, 16, 1, 399, DateTimeKind.Unspecified).AddTicks(3573), 5L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 299L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Assimilated disintermediate open architecture", new DateTime(2020, 6, 28, 22, 28, 16, 325, DateTimeKind.Unspecified).AddTicks(9269), 4L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 300L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Intuitive transitional Graphical User Interface", new DateTime(2020, 6, 23, 13, 31, 34, 150, DateTimeKind.Unspecified).AddTicks(1054), 4L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 301L,
                columns: new[] { "Comment", "Date", "EmployeeId" },
                values: new object[] { "Networked scalable customer loyalty", new DateTime(2020, 10, 9, 12, 57, 47, 318, DateTimeKind.Unspecified).AddTicks(82), 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 302L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Persistent 24/7 support", new DateTime(2020, 5, 7, 8, 1, 40, 660, DateTimeKind.Unspecified).AddTicks(8367), 3L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 303L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Phased disintermediate benchmark", new DateTime(2020, 10, 18, 17, 24, 22, 957, DateTimeKind.Unspecified).AddTicks(4665), 4L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 304L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Sharable tertiary utilisation", new DateTime(2020, 4, 5, 2, 45, 26, 849, DateTimeKind.Unspecified).AddTicks(3997), 1L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 305L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Optimized eco-centric access", new DateTime(2020, 11, 21, 0, 5, 20, 491, DateTimeKind.Unspecified).AddTicks(2008), 11L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 306L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Expanded grid-enabled emulation", new DateTime(2020, 1, 5, 7, 51, 54, 375, DateTimeKind.Unspecified).AddTicks(3422), 11L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 307L,
                columns: new[] { "AmountOfHours", "Comment", "Date" },
                values: new object[] { 4m, "Face to face reciprocal algorithm", new DateTime(2020, 2, 19, 14, 2, 57, 584, DateTimeKind.Unspecified).AddTicks(1472) });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 308L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Phased discrete adapter", new DateTime(2020, 3, 20, 7, 4, 2, 563, DateTimeKind.Unspecified).AddTicks(4786), 6L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 309L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Triple-buffered demand-driven alliance", new DateTime(2020, 10, 3, 21, 10, 42, 787, DateTimeKind.Unspecified).AddTicks(2551), 9L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 310L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Quality-focused tertiary functionalities", new DateTime(2020, 2, 19, 7, 21, 12, 525, DateTimeKind.Unspecified).AddTicks(8667), 11L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 311L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Synergistic static hardware", new DateTime(2020, 2, 22, 3, 38, 33, 100, DateTimeKind.Unspecified).AddTicks(8373), 1L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 312L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Cross-group value-added open system", new DateTime(2020, 1, 22, 4, 5, 13, 797, DateTimeKind.Unspecified).AddTicks(6074), 1L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 313L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Assimilated zero defect forecast", new DateTime(2020, 5, 31, 21, 40, 31, 943, DateTimeKind.Unspecified).AddTicks(1922), 1L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 314L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Devolved content-based capability", new DateTime(2020, 12, 30, 19, 27, 11, 270, DateTimeKind.Unspecified).AddTicks(9538), 9L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 315L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Synergized motivating implementation", new DateTime(2020, 5, 21, 1, 8, 16, 23, DateTimeKind.Unspecified).AddTicks(4900), 11L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 316L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Monitored maximized hub", new DateTime(2020, 6, 16, 18, 7, 32, 981, DateTimeKind.Unspecified).AddTicks(4800), 5L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 317L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Function-based encompassing moratorium", new DateTime(2020, 2, 26, 16, 7, 30, 27, DateTimeKind.Unspecified).AddTicks(5465), 10L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 318L,
                columns: new[] { "Comment", "Date", "EmployeeId" },
                values: new object[] { "Universal 5th generation productivity", new DateTime(2020, 2, 13, 13, 54, 46, 429, DateTimeKind.Unspecified).AddTicks(5388), 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 319L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Phased directional forecast", new DateTime(2020, 12, 27, 1, 39, 48, 401, DateTimeKind.Unspecified).AddTicks(5990), 2L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 320L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Focused contextually-based benchmark", new DateTime(2020, 12, 10, 12, 39, 1, 666, DateTimeKind.Unspecified).AddTicks(9819), 8L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 321L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Integrated tangible open architecture", new DateTime(2020, 3, 11, 10, 19, 48, 518, DateTimeKind.Unspecified).AddTicks(4014), 7L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 322L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Triple-buffered homogeneous success", new DateTime(2020, 7, 27, 13, 12, 27, 357, DateTimeKind.Unspecified).AddTicks(9345), 4L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 323L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Phased national framework", new DateTime(2020, 12, 7, 12, 36, 56, 857, DateTimeKind.Unspecified).AddTicks(1982), 12L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 324L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Fully-configurable background data-warehouse", new DateTime(2020, 1, 20, 12, 58, 45, 594, DateTimeKind.Unspecified).AddTicks(4574), 1L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 325L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Configurable interactive complexity", new DateTime(2020, 7, 19, 10, 48, 23, 120, DateTimeKind.Unspecified).AddTicks(8100), 10L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 326L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Decentralized asynchronous toolset", new DateTime(2020, 1, 26, 21, 16, 42, 710, DateTimeKind.Unspecified).AddTicks(1069), 4L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 327L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Self-enabling high-level software", new DateTime(2020, 11, 4, 1, 49, 25, 383, DateTimeKind.Unspecified).AddTicks(4225), 5L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 328L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 6m, "Optional radical moratorium", new DateTime(2020, 4, 11, 9, 9, 1, 818, DateTimeKind.Unspecified).AddTicks(4002), 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 329L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Robust full-range internet solution", new DateTime(2020, 10, 1, 10, 5, 18, 662, DateTimeKind.Unspecified).AddTicks(6887), 8L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 330L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Upgradable neutral instruction set", new DateTime(2020, 10, 29, 3, 15, 2, 934, DateTimeKind.Unspecified).AddTicks(3555), 5L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 331L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Persevering fresh-thinking middleware", new DateTime(2020, 6, 14, 6, 3, 53, 331, DateTimeKind.Unspecified).AddTicks(9170), 1L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 332L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Profound full-range middleware", new DateTime(2020, 2, 21, 8, 57, 26, 994, DateTimeKind.Unspecified).AddTicks(6892), 3L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 333L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Seamless intangible emulation", new DateTime(2020, 4, 30, 11, 10, 55, 887, DateTimeKind.Unspecified).AddTicks(1606), 10L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 334L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Progressive global open architecture", new DateTime(2020, 6, 7, 1, 24, 35, 875, DateTimeKind.Unspecified).AddTicks(7898), 5L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 335L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Right-sized eco-centric approach", new DateTime(2020, 11, 27, 19, 40, 31, 809, DateTimeKind.Unspecified).AddTicks(5612), 2L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 336L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 8m, "Future-proofed 6th generation hardware", new DateTime(2020, 4, 2, 3, 26, 25, 82, DateTimeKind.Unspecified).AddTicks(4965), 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 337L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Adaptive upward-trending Graphical User Interface", new DateTime(2020, 7, 29, 18, 17, 42, 158, DateTimeKind.Unspecified).AddTicks(3411), 10L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 338L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "De-engineered contextually-based knowledge user", new DateTime(2020, 3, 29, 20, 30, 11, 89, DateTimeKind.Unspecified).AddTicks(2386), 7L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 339L,
                columns: new[] { "Comment", "Date", "ProjectId" },
                values: new object[] { "Virtual user-facing moratorium", new DateTime(2020, 1, 26, 20, 6, 27, 304, DateTimeKind.Unspecified).AddTicks(9671), 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 340L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Compatible intermediate application", new DateTime(2020, 8, 25, 4, 46, 16, 42, DateTimeKind.Unspecified).AddTicks(4306), 6L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 341L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Multi-layered systematic standardization", new DateTime(2020, 8, 5, 2, 25, 25, 454, DateTimeKind.Unspecified).AddTicks(8695), 9L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 342L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Object-based didactic model", new DateTime(2020, 4, 3, 12, 50, 58, 59, DateTimeKind.Unspecified).AddTicks(9985), 7L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 343L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Cloned incremental methodology", new DateTime(2020, 9, 18, 23, 13, 21, 472, DateTimeKind.Unspecified).AddTicks(9129), 10L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 344L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Cross-group radical parallelism", new DateTime(2020, 1, 18, 2, 23, 41, 591, DateTimeKind.Unspecified).AddTicks(192), 5L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 345L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Implemented executive extranet", new DateTime(2020, 3, 26, 3, 1, 32, 292, DateTimeKind.Unspecified).AddTicks(4838), 6L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 346L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Innovative needs-based secured line", new DateTime(2020, 9, 18, 11, 22, 35, 994, DateTimeKind.Unspecified).AddTicks(1259), 2L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 347L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Programmable 3rd generation neural-net", new DateTime(2020, 4, 2, 9, 56, 26, 709, DateTimeKind.Unspecified).AddTicks(4683), 7L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 348L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Ameliorated heuristic model", new DateTime(2020, 4, 17, 6, 14, 48, 739, DateTimeKind.Unspecified).AddTicks(4667), 11L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 349L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Compatible bi-directional focus group", new DateTime(2020, 1, 25, 19, 13, 26, 36, DateTimeKind.Unspecified).AddTicks(5642), 12L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 350L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Universal empowering artificial intelligence", new DateTime(2020, 10, 3, 17, 43, 11, 477, DateTimeKind.Unspecified).AddTicks(2361), 1L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 351L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Streamlined regional model", new DateTime(2020, 11, 28, 3, 32, 39, 168, DateTimeKind.Unspecified).AddTicks(4982), 5L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 352L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Re-engineered 6th generation projection", new DateTime(2020, 11, 25, 13, 13, 3, 923, DateTimeKind.Unspecified).AddTicks(9402), 12L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 353L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Triple-buffered multi-tasking interface", new DateTime(2020, 11, 28, 18, 6, 28, 632, DateTimeKind.Unspecified).AddTicks(6035), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 354L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Optional homogeneous core", new DateTime(2020, 5, 3, 19, 59, 2, 658, DateTimeKind.Unspecified).AddTicks(6561), 10L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 355L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Public-key local knowledge base", new DateTime(2020, 5, 5, 1, 49, 0, 687, DateTimeKind.Unspecified).AddTicks(4389), 12L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 356L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Profound zero tolerance internet solution", new DateTime(2020, 4, 18, 23, 45, 47, 87, DateTimeKind.Unspecified).AddTicks(8687), 10L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 357L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Cloned intermediate task-force", new DateTime(2020, 11, 26, 14, 30, 11, 242, DateTimeKind.Unspecified).AddTicks(7582), 1L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 358L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Programmable logistical support", new DateTime(2020, 10, 14, 23, 1, 57, 782, DateTimeKind.Unspecified).AddTicks(3542), 5L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 359L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Front-line fresh-thinking local area network", new DateTime(2020, 6, 2, 5, 18, 35, 94, DateTimeKind.Unspecified).AddTicks(7988), 4L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 360L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Multi-layered contextually-based application", new DateTime(2020, 9, 13, 23, 59, 54, 428, DateTimeKind.Unspecified).AddTicks(8373), 7L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 361L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Progressive zero defect forecast", new DateTime(2020, 2, 25, 0, 40, 23, 717, DateTimeKind.Unspecified).AddTicks(3718), 6L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 362L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Upgradable disintermediate orchestration", new DateTime(2020, 12, 9, 14, 42, 45, 924, DateTimeKind.Unspecified).AddTicks(9254), 8L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 363L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 1m, "Vision-oriented multi-state local area network", new DateTime(2020, 10, 2, 22, 24, 21, 234, DateTimeKind.Unspecified).AddTicks(7859), 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 364L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Persevering web-enabled hub", new DateTime(2020, 12, 2, 12, 0, 53, 73, DateTimeKind.Unspecified).AddTicks(4800), 8L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 365L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Front-line systemic internet solution", new DateTime(2020, 4, 21, 15, 21, 58, 866, DateTimeKind.Unspecified).AddTicks(2176), 3L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 366L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Persistent intermediate structure", new DateTime(2020, 10, 3, 11, 41, 43, 172, DateTimeKind.Unspecified).AddTicks(924), 2L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 367L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Configurable systemic moderator", new DateTime(2020, 10, 25, 18, 17, 25, 916, DateTimeKind.Unspecified).AddTicks(9084), 1L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 368L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Organized human-resource policy", new DateTime(2020, 1, 9, 6, 34, 8, 468, DateTimeKind.Unspecified).AddTicks(2804), 9L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 369L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Assimilated transitional standardization", new DateTime(2020, 11, 25, 18, 36, 6, 173, DateTimeKind.Unspecified).AddTicks(3552), 3L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 370L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Mandatory client-server groupware", new DateTime(2020, 11, 11, 0, 48, 7, 23, DateTimeKind.Unspecified).AddTicks(867), 12L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 371L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Configurable neutral open architecture", new DateTime(2020, 1, 15, 18, 5, 52, 104, DateTimeKind.Unspecified).AddTicks(4975), 5L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 372L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Compatible scalable methodology", new DateTime(2020, 12, 23, 17, 58, 15, 389, DateTimeKind.Unspecified).AddTicks(4127), 4L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 373L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Implemented responsive installation", new DateTime(2020, 2, 14, 9, 15, 53, 209, DateTimeKind.Unspecified).AddTicks(1281), 5L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 374L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Profit-focused 24/7 superstructure", new DateTime(2020, 11, 25, 1, 49, 51, 80, DateTimeKind.Unspecified).AddTicks(5271), 11L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 375L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 6m, "Public-key contextually-based architecture", new DateTime(2020, 10, 2, 11, 30, 56, 367, DateTimeKind.Unspecified).AddTicks(8756), 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 376L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Secured 5th generation flexibility", new DateTime(2020, 2, 2, 3, 1, 42, 99, DateTimeKind.Unspecified).AddTicks(5921), 2L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 377L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Compatible dedicated website", new DateTime(2020, 8, 12, 0, 46, 58, 233, DateTimeKind.Unspecified).AddTicks(1560), 5L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 378L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 1m, "Innovative transitional interface", new DateTime(2020, 11, 24, 10, 39, 42, 42, DateTimeKind.Unspecified).AddTicks(4855), 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 379L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 4m, "Progressive responsive knowledge user", new DateTime(2020, 11, 3, 14, 10, 32, 91, DateTimeKind.Unspecified).AddTicks(9215), 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 380L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Organized intangible encryption", new DateTime(2020, 10, 22, 20, 4, 47, 676, DateTimeKind.Unspecified).AddTicks(7808), 4L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 381L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Reverse-engineered client-driven definition", new DateTime(2020, 4, 4, 3, 39, 23, 623, DateTimeKind.Unspecified).AddTicks(8785), 12L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 382L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Right-sized uniform initiative", new DateTime(2020, 8, 17, 14, 20, 34, 307, DateTimeKind.Unspecified).AddTicks(7259), 3L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 383L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 3m, "Function-based leading edge projection", new DateTime(2020, 8, 15, 7, 42, 22, 820, DateTimeKind.Unspecified).AddTicks(8480), 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 384L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Exclusive regional website", new DateTime(2020, 1, 6, 17, 22, 2, 575, DateTimeKind.Unspecified).AddTicks(3673), 9L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 385L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Realigned national analyzer", new DateTime(2020, 7, 11, 7, 49, 58, 748, DateTimeKind.Unspecified).AddTicks(3692), 9L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 386L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Re-contextualized dedicated conglomeration", new DateTime(2020, 6, 21, 20, 38, 0, 48, DateTimeKind.Unspecified).AddTicks(7954), 11L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 387L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Team-oriented 6th generation system engine", new DateTime(2020, 11, 28, 5, 57, 32, 776, DateTimeKind.Unspecified).AddTicks(2260), 5L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 388L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Virtual hybrid hub", new DateTime(2020, 2, 9, 11, 9, 59, 843, DateTimeKind.Unspecified).AddTicks(67), 10L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 389L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Integrated discrete core", new DateTime(2020, 6, 18, 13, 56, 5, 913, DateTimeKind.Unspecified).AddTicks(1954), 6L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 390L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Enhanced heuristic instruction set", new DateTime(2020, 1, 11, 18, 2, 0, 201, DateTimeKind.Unspecified).AddTicks(2692), 3L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 391L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Fully-configurable maximized website", new DateTime(2020, 9, 5, 8, 13, 33, 681, DateTimeKind.Unspecified).AddTicks(4717), 1L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 392L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Re-engineered 6th generation flexibility", new DateTime(2020, 3, 19, 3, 20, 16, 904, DateTimeKind.Unspecified).AddTicks(8112), 8L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 393L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Digitized maximized synergy", new DateTime(2020, 4, 12, 10, 51, 46, 424, DateTimeKind.Unspecified).AddTicks(325), 5L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 394L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Versatile zero defect function", new DateTime(2020, 2, 15, 12, 57, 52, 481, DateTimeKind.Unspecified).AddTicks(9311), 2L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 395L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Phased fresh-thinking capability", new DateTime(2020, 11, 11, 17, 18, 33, 989, DateTimeKind.Unspecified).AddTicks(7354), 1L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 396L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Triple-buffered homogeneous portal", new DateTime(2020, 8, 24, 19, 25, 46, 547, DateTimeKind.Unspecified).AddTicks(8567), 2L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 397L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Enterprise-wide tertiary standardization", new DateTime(2020, 2, 19, 11, 16, 1, 366, DateTimeKind.Unspecified).AddTicks(912), 9L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 398L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Synchronised methodical secured line", new DateTime(2020, 4, 20, 9, 16, 2, 523, DateTimeKind.Unspecified).AddTicks(185), 2L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 399L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Polarised mission-critical system engine", new DateTime(2020, 4, 5, 22, 58, 27, 198, DateTimeKind.Unspecified).AddTicks(4632), 3L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 400L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Proactive client-server leverage", new DateTime(2020, 9, 19, 11, 4, 16, 564, DateTimeKind.Unspecified).AddTicks(799), 12L, 13L });
        }
    }
}
