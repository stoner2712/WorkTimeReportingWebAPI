using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DiplomaProject.Migrations
{
    public partial class RenameTwoPropertiesAmountAndStatusInInvoiceModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 1L, 19L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2L, 3L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2L, 15L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3L, 6L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3L, 9L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3L, 12L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3L, 13L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3L, 20L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4L, 17L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5L, 4L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5L, 9L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5L, 15L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5L, 17L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 6L, 2L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 6L, 4L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 6L, 7L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 6L, 8L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 6L, 11L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 7L, 3L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 7L, 7L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 7L, 15L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 8L, 3L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 8L, 5L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 8L, 10L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 8L, 15L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 8L, 17L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 8L, 19L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 9L, 6L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 9L, 13L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 9L, 15L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 9L, 17L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 10L, 3L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 10L, 15L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 10L, 16L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 11L, 11L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 12L, 13L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 12L, 14L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 12L, 15L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 12L, 16L });

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Invoice",
                newName: "IsInvoicePaid");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Invoice",
                newName: "AmountOfHours");

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 1L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "23479", "Lake Marisol", "McClure Inc", "Argentina", "98828-8877", "Muller Lakes" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 2L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "6464", "Lake Idella", "Morissette - Nienow", "Reunion", "04363-7948", "Bonnie Camp" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 3L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "221", "Lake Gerardo", "Dicki Inc", "Macedonia", "05127-1478", "Concepcion Way" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 4L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "218", "Kevenmouth", "Kemmer LLC", "Namibia", "26428-8484", "Donnelly Plains" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 5L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "622", "Champlinmouth", "O'Conner, Price and Wintheiser", "Equatorial Guinea", "73000-9894", "Kuphal Village" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 6L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "946", "North Jedediah", "Wintheiser, Bechtelar and Turner", "Isle of Man", "99533", "Bernhard Plains" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 7L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "366", "Lake Devenview", "Ledner and Sons", "Nauru", "97061-3854", "Casper Stravenue" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 8L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "0592", "Port Thadville", "Armstrong and Sons", "Aruba", "06288-7205", "Toy Loaf" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "51702", "New Wilfred", "Algeria", new DateTime(1983, 1, 10, 14, 22, 2, 900, DateTimeKind.Unspecified).AddTicks(8080), "Nikolas", "Regional Implementation Orchestrator", "Barton", "44345", "Monique Throughway" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "39228", "Luisberg", "Angola", new DateTime(1998, 11, 29, 9, 30, 6, 490, DateTimeKind.Unspecified).AddTicks(5594), "Lauryn", "Lead Metrics Director", "Donnelly", "95613-4381", "Katrina Glen" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "4997", "Mullerside", "Australia", new DateTime(1983, 4, 7, 5, 12, 29, 994, DateTimeKind.Unspecified).AddTicks(3046), "Giovanny", "Internal Branding Facilitator", "Rohan", "62090", "Wyman Grove" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "3828", "Denesikfort", "Malaysia", new DateTime(1974, 5, 9, 21, 39, 31, 657, DateTimeKind.Unspecified).AddTicks(6612), "Rhett", "International Marketing Executive", "Satterfield", "88095-8131", "Samanta Lodge" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "0766", "North D'angelo", "Syrian Arab Republic", new DateTime(1964, 7, 11, 16, 31, 45, 663, DateTimeKind.Unspecified).AddTicks(4658), "Gregoria", "Dynamic Markets Officer", "Bednar", "64278", "Frederick Lane" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "560", "West Jaclynville", "Italy", new DateTime(1984, 6, 11, 4, 10, 21, 341, DateTimeKind.Unspecified).AddTicks(5438), "Lonnie", "Direct Branding Consultant", "Gutkowski", "25850", "Quigley Falls" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 7L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "69276", "South Tobin", "Zimbabwe", new DateTime(1998, 11, 4, 7, 32, 44, 691, DateTimeKind.Unspecified).AddTicks(8574), "Melissa", "Dynamic Factors Representative", "Hyatt", "70838", "Tracey Spurs" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 8L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "27569", "Enolafurt", "Taiwan", new DateTime(1973, 5, 24, 21, 2, 46, 269, DateTimeKind.Unspecified).AddTicks(4614), "Van", "Investor Quality Officer", "Abernathy", "97975-4970", "Clinton Ridge" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 9L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "17975", "Morarport", "Chile", new DateTime(1959, 1, 4, 19, 16, 58, 744, DateTimeKind.Unspecified).AddTicks(1210), "Rosalyn", "District Mobility Strategist", "Quitzon", "15813", "Evans Keys" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 10L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "53184", "Andersonview", "Libyan Arab Jamahiriya", new DateTime(1974, 5, 23, 18, 48, 21, 52, DateTimeKind.Unspecified).AddTicks(9341), "Cedrick", "Global Data Executive", "Wiegand", "82822-1156", "Jeromy Bridge" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 11L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "0974", "South Kaylin", "Saint Martin", new DateTime(1962, 10, 11, 18, 11, 6, 790, DateTimeKind.Unspecified).AddTicks(4592), "Margaretta", "Future Factors Director", "Osinski", "56108", "Wehner Corner" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 12L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "47083", "Elinortown", "Turks and Caicos Islands", new DateTime(1978, 6, 30, 17, 13, 27, 161, DateTimeKind.Unspecified).AddTicks(4659), "Leonel", "Lead Interactions Developer", "Kassulke", "56854", "Schamberger Keys" });

            migrationBuilder.InsertData(
                table: "EmployeeProject",
                columns: new[] { "EmployeeId", "ProjectId" },
                values: new object[,]
                {
                    { 10L, 5L },
                    { 1L, 6L },
                    { 4L, 13L },
                    { 11L, 18L },
                    { 6L, 5L },
                    { 6L, 9L },
                    { 4L, 9L },
                    { 5L, 14L },
                    { 7L, 17L },
                    { 1L, 20L },
                    { 5L, 8L },
                    { 6L, 1L },
                    { 4L, 14L },
                    { 12L, 8L },
                    { 6L, 15L },
                    { 2L, 7L },
                    { 11L, 5L },
                    { 7L, 4L },
                    { 3L, 5L },
                    { 9L, 12L },
                    { 1L, 11L },
                    { 6L, 14L },
                    { 4L, 7L },
                    { 11L, 10L },
                    { 10L, 12L },
                    { 9L, 18L },
                    { 3L, 8L },
                    { 9L, 5L },
                    { 5L, 19L },
                    { 8L, 20L },
                    { 4L, 11L },
                    { 1L, 3L },
                    { 6L, 19L },
                    { 4L, 8L },
                    { 7L, 9L },
                    { 10L, 18L },
                    { 4L, 10L },
                    { 1L, 1L },
                    { 9L, 16L }
                });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 2L, 642.51m, "Optional logistical adapter" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 6L, 581.23m, "Expanded upward-trending concept" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 3L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 5L, 634.49m, "Future-proofed content-based adapter" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 4L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 5L, 606.61m, "Profound systemic attitude" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 5L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 3L, 829.83m, "Extended demand-driven database" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 6L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 8L, 555.39m, "Balanced 24 hour forecast" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 7L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 8L, 523.98m, "Cross-group foreground frame" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 8L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 2L, 838.03m, "Inverse dedicated knowledge user" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 9L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 4L, 831.07m, "Reverse-engineered systemic help-desk" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 10L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 7L, 785.84m, "Polarised real-time website" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 11L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 7L, 852.60m, "Future-proofed reciprocal orchestration" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 12L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 2L, 500.75m, "Focused eco-centric frame" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 13L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 5L, 598.77m, "Exclusive local archive" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 14L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 1L, 639.88m, "User-centric system-worthy utilisation" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 15L,
                columns: new[] { "PricePerHour", "ProjectName" },
                values: new object[] { 516.77m, "Intuitive dynamic hierarchy" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 16L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 6L, 600.18m, "Integrated solution-oriented matrices" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 17L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 5L, 630.63m, "Face to face 3rd generation productivity" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 18L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 6L, 636.05m, "Future-proofed neutral monitoring" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 19L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 8L, 755.63m, "Cloned tertiary knowledge user" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 20L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 5L, 574.25m, "Digitized reciprocal customer loyalty" });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 1L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 57m, "Sint libero qui ipsa doloribus ut maxime omnis ipsum quisquam.", new DateTime(2020, 10, 19, 6, 20, 57, 42, DateTimeKind.Unspecified).AddTicks(4782), 2L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 2L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Aut vel illo ut ut eligendi natus voluptatem tempore ut.", new DateTime(2020, 4, 2, 13, 8, 48, 254, DateTimeKind.Unspecified).AddTicks(2345), 10L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 3L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 2m, "Officia excepturi quisquam veritatis laborum quia voluptas magnam facilis vel.", new DateTime(2020, 9, 2, 2, 4, 40, 921, DateTimeKind.Unspecified).AddTicks(6877), 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 4L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Nihil animi cupiditate ullam ipsa beatae aliquid ut sed at.", new DateTime(2020, 6, 19, 13, 21, 0, 475, DateTimeKind.Unspecified).AddTicks(9723), 4L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 5L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 46m, "Repellat veniam ad possimus animi cumque ipsum expedita repellat doloremque.", new DateTime(2020, 5, 20, 13, 13, 24, 240, DateTimeKind.Unspecified).AddTicks(3860), 7L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 6L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 44m, "Dolorem cum sed illum tempora quam ducimus quasi perferendis totam.", new DateTime(2020, 4, 20, 14, 12, 18, 796, DateTimeKind.Unspecified).AddTicks(2311), 3L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 7L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 19m, "Nemo accusamus repellendus molestias dolorem asperiores aliquam commodi aut cum.", new DateTime(2020, 9, 11, 3, 20, 26, 784, DateTimeKind.Unspecified).AddTicks(3392), 7L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 8L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Id quos possimus repellat omnis et aut cupiditate ipsam praesentium.", new DateTime(2020, 12, 21, 18, 22, 14, 827, DateTimeKind.Unspecified).AddTicks(1901), 11L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 9L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Enim consequatur similique aut consequatur pariatur ut consequuntur dolore aperiam.", new DateTime(2020, 4, 28, 17, 49, 59, 707, DateTimeKind.Unspecified).AddTicks(8524), 3L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 10L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 49m, "In eos voluptatem laudantium qui in laudantium occaecati impedit adipisci.", new DateTime(2020, 6, 21, 5, 11, 23, 844, DateTimeKind.Unspecified).AddTicks(4320), 10L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 11L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 47m, "Omnis quia harum et tempore voluptas explicabo exercitationem odit perspiciatis.", new DateTime(2020, 3, 21, 19, 17, 16, 77, DateTimeKind.Unspecified).AddTicks(7225), 10L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 12L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 29m, "Dolore quisquam omnis rem neque exercitationem hic blanditiis adipisci velit.", new DateTime(2020, 9, 12, 22, 34, 27, 783, DateTimeKind.Unspecified).AddTicks(553), 7L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 13L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 45m, "Aspernatur autem adipisci rerum et error in et in ex.", new DateTime(2020, 6, 18, 11, 42, 1, 990, DateTimeKind.Unspecified).AddTicks(1356), 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 14L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 17m, "Facere porro nihil sit nihil doloribus ad doloribus esse nisi.", new DateTime(2020, 9, 18, 6, 17, 18, 341, DateTimeKind.Unspecified).AddTicks(6326), 11L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 15L,
                columns: new[] { "AmountOfHours", "Comment", "Date" },
                values: new object[] { 6m, "Magni modi ex placeat et nisi velit minus aliquid vel.", new DateTime(2020, 10, 31, 23, 14, 50, 798, DateTimeKind.Unspecified).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 16L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 19m, "Voluptatem nihil quo sit qui tempore cumque voluptatum nihil dolor.", new DateTime(2020, 11, 26, 20, 49, 26, 433, DateTimeKind.Unspecified).AddTicks(4855), 3L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 17L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Sapiente pariatur ipsa nihil id voluptatum autem dolor repellat rerum.", new DateTime(2020, 6, 22, 3, 39, 45, 561, DateTimeKind.Unspecified).AddTicks(9209), 4L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 18L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Consequatur saepe quo sunt dicta tenetur tempore doloribus quas rerum.", new DateTime(2020, 1, 31, 10, 12, 16, 989, DateTimeKind.Unspecified).AddTicks(9310), 5L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 19L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 39m, "Occaecati dolor non reprehenderit officiis sunt est et assumenda temporibus.", new DateTime(2020, 5, 26, 12, 35, 44, 969, DateTimeKind.Unspecified).AddTicks(7184), 5L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 20L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Nihil tenetur id eius officia soluta aut consequatur laboriosam est.", new DateTime(2020, 7, 13, 18, 4, 45, 907, DateTimeKind.Unspecified).AddTicks(1901), 5L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 21L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 59m, "Nisi nesciunt consequatur in architecto qui distinctio qui ex necessitatibus.", new DateTime(2020, 6, 9, 10, 41, 51, 333, DateTimeKind.Unspecified).AddTicks(7979), 6L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 22L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 52m, "Consequuntur ab quia distinctio nihil non error omnis ratione sed.", new DateTime(2020, 4, 1, 21, 40, 1, 20, DateTimeKind.Unspecified).AddTicks(2860), 7L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 23L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 43m, "Quo aut consequatur ex et et sequi est quam qui.", new DateTime(2020, 7, 18, 2, 2, 24, 541, DateTimeKind.Unspecified).AddTicks(5784), 5L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 24L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 36m, "Mollitia pariatur est mollitia molestiae et nobis quis rem quisquam.", new DateTime(2020, 6, 25, 20, 9, 58, 748, DateTimeKind.Unspecified).AddTicks(8012), 2L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 25L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 48m, "Aut dolore consequatur ex animi hic maiores voluptatum aut qui.", new DateTime(2020, 5, 29, 15, 32, 33, 401, DateTimeKind.Unspecified).AddTicks(3800), 5L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 26L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 31m, "Et ex enim doloremque quae sapiente tenetur ullam qui reiciendis.", new DateTime(2020, 9, 18, 18, 38, 0, 109, DateTimeKind.Unspecified).AddTicks(9330), 4L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 27L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 33m, "Voluptate quis aliquam maxime reprehenderit commodi animi quia vel repellat.", new DateTime(2020, 1, 8, 20, 30, 17, 45, DateTimeKind.Unspecified).AddTicks(6738), 10L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 28L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Delectus qui magnam reiciendis non ipsum expedita sed velit et.", new DateTime(2020, 8, 15, 10, 10, 42, 68, DateTimeKind.Unspecified).AddTicks(5387), 11L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 29L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 43m, "Pariatur doloremque veritatis ullam non iusto quasi mollitia rerum animi.", new DateTime(2020, 11, 3, 20, 5, 45, 809, DateTimeKind.Unspecified).AddTicks(5574), 1L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 30L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 27m, "Ut ipsam labore sint laboriosam fugiat sit vel est ipsam.", new DateTime(2020, 12, 2, 1, 17, 26, 226, DateTimeKind.Unspecified).AddTicks(5409), 10L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 31L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 17m, "Officiis consectetur rerum rerum cupiditate rerum quia repellendus recusandae quos.", new DateTime(2020, 11, 23, 8, 40, 46, 438, DateTimeKind.Unspecified).AddTicks(8203), 8L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 32L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 22m, "Optio et sint quia aliquam sed in aspernatur dolorem nisi.", new DateTime(2020, 1, 20, 14, 42, 41, 814, DateTimeKind.Unspecified).AddTicks(2255), 2L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 33L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 2m, "Corporis placeat cupiditate vitae perspiciatis dolor quisquam optio quo fugit.", new DateTime(2020, 5, 19, 12, 20, 53, 329, DateTimeKind.Unspecified).AddTicks(9757), 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 34L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 46m, "Eum placeat sint sequi omnis a fugit quasi qui mollitia.", new DateTime(2020, 2, 19, 1, 12, 8, 865, DateTimeKind.Unspecified).AddTicks(5987), 8L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 35L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 47m, "Commodi perspiciatis quo sint molestias quis deleniti sit ut occaecati.", new DateTime(2020, 9, 18, 15, 56, 24, 363, DateTimeKind.Unspecified).AddTicks(6050), 8L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 36L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 0m, "Itaque et ut tempora et qui porro beatae nihil tenetur.", new DateTime(2020, 8, 26, 12, 10, 2, 880, DateTimeKind.Unspecified).AddTicks(1139), 3L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 37L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 14m, "Aliquid non corrupti pariatur et rerum sit ipsum minima enim.", new DateTime(2020, 12, 4, 13, 18, 45, 765, DateTimeKind.Unspecified).AddTicks(6991), 7L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 38L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 12m, "Omnis in excepturi quas enim aut magni deserunt dolore consequatur.", new DateTime(2020, 4, 10, 18, 51, 27, 767, DateTimeKind.Unspecified).AddTicks(2303), 8L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 39L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 17m, "Sed rerum quis dicta commodi dolore fugiat ipsa aperiam autem.", new DateTime(2020, 1, 22, 18, 31, 7, 707, DateTimeKind.Unspecified).AddTicks(3014), 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 40L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 46m, "Cupiditate aperiam nihil eius unde occaecati ullam accusantium odio est.", new DateTime(2020, 9, 4, 7, 33, 47, 553, DateTimeKind.Unspecified).AddTicks(2745), 2L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 41L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 46m, "Soluta sed tempora quia rerum ipsa ab reprehenderit accusantium iusto.", new DateTime(2020, 2, 7, 15, 8, 21, 708, DateTimeKind.Unspecified).AddTicks(3079), 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 42L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 45m, "Commodi quisquam exercitationem est iusto commodi et numquam distinctio ea.", new DateTime(2020, 5, 14, 9, 24, 21, 984, DateTimeKind.Unspecified).AddTicks(4013), 5L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 43L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Dignissimos error aut omnis qui quasi ea repudiandae error aperiam.", new DateTime(2020, 12, 28, 23, 14, 2, 639, DateTimeKind.Unspecified).AddTicks(5776), 10L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 44L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Aut enim minus occaecati voluptatem natus distinctio quisquam molestiae quas.", new DateTime(2020, 9, 21, 2, 16, 54, 806, DateTimeKind.Unspecified).AddTicks(9450), 5L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 45L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 28m, "Praesentium dolorem eum ut illo a rerum praesentium praesentium recusandae.", new DateTime(2020, 9, 10, 17, 7, 0, 878, DateTimeKind.Unspecified).AddTicks(650), 11L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 46L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 27m, "Sequi voluptatem temporibus aut rerum recusandae sed reprehenderit libero dolorem.", new DateTime(2020, 5, 18, 8, 24, 22, 209, DateTimeKind.Unspecified).AddTicks(8795), 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 47L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 44m, "Dolores rem dolor ea vel saepe qui quod sed totam.", new DateTime(2020, 6, 7, 18, 14, 6, 745, DateTimeKind.Unspecified).AddTicks(1863), 7L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 48L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 33m, "Consequatur et quidem vero sit non error neque quo similique.", new DateTime(2020, 3, 8, 19, 28, 0, 329, DateTimeKind.Unspecified).AddTicks(664), 2L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 49L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Sequi alias a fuga cupiditate modi quia maiores facere deleniti.", new DateTime(2020, 4, 6, 15, 43, 41, 678, DateTimeKind.Unspecified).AddTicks(6648), 11L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 50L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 25m, "Inventore quia tempora debitis placeat et culpa accusamus consectetur non.", new DateTime(2021, 1, 1, 7, 55, 5, 166, DateTimeKind.Unspecified).AddTicks(9850), 3L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 51L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 59m, "Possimus laborum corporis fuga harum eum officia sed excepturi tenetur.", new DateTime(2020, 2, 28, 23, 48, 35, 695, DateTimeKind.Unspecified).AddTicks(813), 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 52L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 50m, "Ab sequi rerum cumque non voluptatem aut reprehenderit nisi eius.", new DateTime(2020, 3, 23, 6, 22, 29, 601, DateTimeKind.Unspecified).AddTicks(7831), 1L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 53L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 17m, "Vel molestiae vel ullam veritatis aliquid incidunt qui quia quis.", new DateTime(2020, 6, 28, 0, 58, 44, 492, DateTimeKind.Unspecified).AddTicks(8943), 11L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 54L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 52m, "Consequatur enim rerum temporibus et possimus illum aperiam qui perspiciatis.", new DateTime(2020, 10, 30, 14, 48, 37, 834, DateTimeKind.Unspecified).AddTicks(9058), 1L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 55L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 22m, "Ut vitae dolorum voluptatem eveniet corporis iure vitae sunt itaque.", new DateTime(2020, 11, 15, 2, 25, 53, 685, DateTimeKind.Unspecified).AddTicks(7363), 11L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 56L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 55m, "Reiciendis expedita pariatur mollitia quia et culpa quasi culpa numquam.", new DateTime(2020, 8, 5, 17, 36, 53, 296, DateTimeKind.Unspecified).AddTicks(7082), 3L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 57L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 47m, "Voluptas quo quis ab atque eos officiis explicabo libero eum.", new DateTime(2020, 6, 20, 7, 2, 41, 186, DateTimeKind.Unspecified).AddTicks(4908), 9L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 58L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 44m, "Optio cumque necessitatibus iste neque repudiandae inventore non eligendi esse.", new DateTime(2020, 6, 21, 13, 2, 32, 67, DateTimeKind.Unspecified).AddTicks(2987), 9L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 59L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Quas ea voluptas dolorem fugiat laborum labore id est pariatur.", new DateTime(2020, 10, 15, 4, 41, 22, 709, DateTimeKind.Unspecified).AddTicks(3605), 5L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 60L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 54m, "Doloribus sit aut quibusdam est at autem aut voluptas dolorum.", new DateTime(2020, 1, 12, 12, 54, 8, 188, DateTimeKind.Unspecified).AddTicks(4383), 7L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 61L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 55m, "Ratione officiis commodi vero beatae cum officia voluptatem maiores unde.", new DateTime(2020, 9, 20, 19, 19, 51, 5, DateTimeKind.Unspecified).AddTicks(9508), 9L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 62L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 58m, "Ab eaque dolorem iusto aut ipsum earum tempore provident saepe.", new DateTime(2020, 6, 28, 0, 23, 55, 815, DateTimeKind.Unspecified).AddTicks(7492), 11L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 63L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 37m, "Beatae modi animi veniam saepe voluptas officia omnis corrupti provident.", new DateTime(2020, 10, 28, 7, 2, 54, 397, DateTimeKind.Unspecified).AddTicks(6443), 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 64L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 44m, "Aperiam suscipit odit sint consequatur esse eum nostrum blanditiis magni.", new DateTime(2020, 4, 18, 19, 56, 9, 697, DateTimeKind.Unspecified).AddTicks(6147), 9L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 65L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 28m, "Nisi rem consequatur ratione vero delectus amet voluptas rerum velit.", new DateTime(2020, 12, 23, 10, 43, 9, 51, DateTimeKind.Unspecified).AddTicks(3406), 12L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 66L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 16m, "Unde harum dolor non officiis numquam rerum adipisci repellendus recusandae.", new DateTime(2020, 5, 16, 12, 41, 6, 545, DateTimeKind.Unspecified).AddTicks(7655), 7L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 67L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 47m, "Assumenda rem laborum ut aliquid fugit et sit non molestias.", new DateTime(2020, 10, 17, 18, 14, 6, 768, DateTimeKind.Unspecified).AddTicks(3606), 6L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 68L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 16m, "Reprehenderit optio tenetur sed ipsa iste quod qui aliquid qui.", new DateTime(2020, 7, 16, 14, 48, 32, 967, DateTimeKind.Unspecified).AddTicks(8229), 9L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 69L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 9m, "Nobis architecto culpa qui quia in repellat voluptatum et et.", new DateTime(2020, 11, 2, 3, 3, 33, 333, DateTimeKind.Unspecified).AddTicks(7102), 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 70L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 32m, "Odit ad doloremque perspiciatis cum quis aut sunt reiciendis commodi.", new DateTime(2020, 11, 5, 8, 32, 44, 482, DateTimeKind.Unspecified).AddTicks(3918), 5L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 71L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 57m, "Sed totam tempore deserunt minima veniam suscipit blanditiis molestiae quae.", new DateTime(2020, 1, 17, 20, 47, 47, 309, DateTimeKind.Unspecified).AddTicks(5009), 2L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 72L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 55m, "Eveniet laboriosam qui repellendus quo quia quo beatae aut magni.", new DateTime(2020, 4, 8, 15, 39, 4, 659, DateTimeKind.Unspecified).AddTicks(6483), 1L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 73L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 36m, "Explicabo eius dicta itaque ex ab ex sit rerum eius.", new DateTime(2020, 5, 5, 23, 45, 13, 815, DateTimeKind.Unspecified).AddTicks(9912), 12L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 74L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 39m, "Ut maiores reprehenderit ut aut necessitatibus adipisci rerum ut in.", new DateTime(2020, 3, 13, 19, 52, 44, 143, DateTimeKind.Unspecified).AddTicks(9518), 7L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 75L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Ex perspiciatis molestias qui itaque quod ea impedit sapiente numquam.", new DateTime(2020, 3, 27, 10, 7, 3, 53, DateTimeKind.Unspecified).AddTicks(700), 10L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 76L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 34m, "Reprehenderit quia consequatur voluptatem aut inventore qui consequuntur id perspiciatis.", new DateTime(2020, 7, 24, 7, 16, 7, 435, DateTimeKind.Unspecified).AddTicks(249), 5L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 77L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 27m, "Magnam molestias esse sint vel enim aut ea impedit sequi.", new DateTime(2020, 5, 25, 11, 17, 50, 356, DateTimeKind.Unspecified).AddTicks(8097), 8L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 78L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 38m, "Accusantium dolor possimus rerum sit harum dolore autem assumenda quis.", new DateTime(2020, 4, 17, 14, 24, 27, 775, DateTimeKind.Unspecified).AddTicks(4599), 10L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 79L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 14m, "Aut delectus praesentium corrupti ut et praesentium qui et ut.", new DateTime(2020, 4, 24, 8, 44, 16, 505, DateTimeKind.Unspecified).AddTicks(9570), 5L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 80L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 60m, "Totam et provident omnis voluptas explicabo aut natus temporibus rem.", new DateTime(2020, 8, 4, 9, 21, 17, 836, DateTimeKind.Unspecified).AddTicks(136), 2L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 81L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 27m, "Quod ipsa est quidem alias maxime mollitia quod eligendi dolores.", new DateTime(2020, 3, 16, 18, 3, 59, 741, DateTimeKind.Unspecified).AddTicks(2365), 2L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 82L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 34m, "Autem corrupti atque dicta ipsa aliquam quia fugit voluptas ad.", new DateTime(2020, 3, 6, 22, 49, 48, 312, DateTimeKind.Unspecified).AddTicks(6031), 5L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 83L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 14m, "Quia doloribus consequatur culpa cumque repellat quo omnis culpa voluptas.", new DateTime(2020, 2, 16, 21, 26, 56, 504, DateTimeKind.Unspecified).AddTicks(7260), 3L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 84L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 44m, "A in dignissimos vel repudiandae non sit ullam doloribus eaque.", new DateTime(2020, 5, 24, 15, 59, 23, 591, DateTimeKind.Unspecified).AddTicks(6009), 9L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 85L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 38m, "Sed velit tempora dolor et aliquid error nihil assumenda non.", new DateTime(2020, 2, 19, 15, 1, 50, 141, DateTimeKind.Unspecified).AddTicks(1699), 9L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 86L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 37m, "Voluptates porro quo adipisci eos mollitia sequi odio fugiat doloremque.", new DateTime(2020, 11, 11, 22, 35, 5, 158, DateTimeKind.Unspecified).AddTicks(5114), 4L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 87L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 53m, "Repellat voluptas vero placeat et dicta iste dolorem sed laudantium.", new DateTime(2020, 1, 22, 23, 30, 56, 707, DateTimeKind.Unspecified).AddTicks(9461), 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 88L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 15m, "Harum repudiandae eligendi minus libero similique iure enim velit non.", new DateTime(2020, 2, 28, 13, 30, 7, 139, DateTimeKind.Unspecified).AddTicks(1108), 2L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 89L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 46m, "In adipisci voluptatum sit nostrum est nihil odio tempore itaque.", new DateTime(2020, 6, 21, 9, 20, 1, 254, DateTimeKind.Unspecified).AddTicks(914), 4L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 90L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 45m, "Sit autem ut qui odio ut consequatur et laboriosam sunt.", new DateTime(2020, 1, 22, 13, 11, 27, 908, DateTimeKind.Unspecified).AddTicks(4883), 12L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 91L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 44m, "Magni sit distinctio voluptas et quibusdam deserunt laboriosam maiores non.", new DateTime(2020, 6, 28, 11, 0, 35, 694, DateTimeKind.Unspecified).AddTicks(3062), 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 92L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 11m, "Labore possimus esse saepe molestias facilis sunt qui iste enim.", new DateTime(2020, 7, 20, 9, 20, 5, 15, DateTimeKind.Unspecified).AddTicks(44), 2L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 93L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 39m, "Vero et sunt et velit reiciendis nemo nisi ad doloribus.", new DateTime(2020, 12, 15, 16, 4, 3, 868, DateTimeKind.Unspecified).AddTicks(5359), 2L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 94L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 51m, "Reprehenderit omnis quasi delectus aliquid laborum nobis culpa sequi aperiam.", new DateTime(2020, 2, 25, 20, 56, 27, 676, DateTimeKind.Unspecified).AddTicks(1817), 12L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 95L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 18m, "Est reprehenderit tempora ab nulla recusandae atque beatae sed hic.", new DateTime(2020, 8, 21, 18, 49, 2, 230, DateTimeKind.Unspecified).AddTicks(3411), 4L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 96L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 54m, "Deleniti molestiae id dolore quos magnam et quibusdam velit magni.", new DateTime(2020, 11, 22, 0, 35, 4, 878, DateTimeKind.Unspecified).AddTicks(5056), 3L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 97L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 16m, "Placeat illo illum ex laboriosam asperiores sunt rerum omnis aut.", new DateTime(2020, 12, 22, 22, 51, 52, 579, DateTimeKind.Unspecified).AddTicks(6418), 6L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 98L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 19m, "Rerum quia optio dolor est repellendus aut qui ullam minus.", new DateTime(2020, 5, 10, 13, 33, 34, 289, DateTimeKind.Unspecified).AddTicks(7476), 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 99L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 59m, "Consectetur aspernatur fugiat quas sapiente quia voluptas et magni repudiandae.", new DateTime(2020, 11, 19, 6, 44, 25, 242, DateTimeKind.Unspecified).AddTicks(1230), 3L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 100L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 36m, "Nam fuga eum ad eveniet sed nesciunt architecto iusto et.", new DateTime(2020, 4, 29, 1, 50, 22, 643, DateTimeKind.Unspecified).AddTicks(3010), 8L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 101L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Possimus vitae consequatur tenetur fugit mollitia eligendi nam ad repudiandae.", new DateTime(2020, 3, 5, 1, 57, 42, 101, DateTimeKind.Unspecified).AddTicks(262), 4L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 102L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 35m, "Asperiores dolor unde fugiat laudantium quas veritatis tempore et architecto.", new DateTime(2020, 12, 26, 16, 29, 43, 711, DateTimeKind.Unspecified).AddTicks(7233), 6L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 103L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Distinctio in saepe omnis aperiam nemo nemo quae voluptates ad.", new DateTime(2020, 10, 26, 11, 30, 43, 168, DateTimeKind.Unspecified).AddTicks(9932), 10L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 104L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 0m, "Aliquid repudiandae voluptatem placeat dolores culpa vitae expedita aut dolor.", new DateTime(2020, 11, 27, 13, 44, 8, 959, DateTimeKind.Unspecified).AddTicks(5703), 9L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 105L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Dolor recusandae laudantium aliquid dolor in consequatur officiis voluptatem voluptatum.", new DateTime(2020, 12, 18, 3, 50, 11, 885, DateTimeKind.Unspecified).AddTicks(3395), 2L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 106L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 57m, "Accusamus enim illo id animi veritatis quia doloribus ab quod.", new DateTime(2020, 4, 8, 2, 56, 20, 103, DateTimeKind.Unspecified).AddTicks(8329), 8L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 107L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 0m, "Sint aut illo commodi ut tempora et aut vel molestiae.", new DateTime(2020, 1, 13, 23, 16, 51, 508, DateTimeKind.Unspecified).AddTicks(2252), 12L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 108L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 28m, "Saepe perspiciatis harum praesentium ipsam magni repellendus est est maiores.", new DateTime(2020, 12, 31, 15, 12, 28, 766, DateTimeKind.Unspecified).AddTicks(8754), 1L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 109L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 11m, "Aut quisquam est unde ut repellat ea voluptates nihil placeat.", new DateTime(2020, 10, 6, 1, 1, 21, 363, DateTimeKind.Unspecified).AddTicks(6588), 4L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 110L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 54m, "Praesentium et temporibus ad et nulla explicabo molestias odit dolorem.", new DateTime(2020, 1, 31, 12, 58, 53, 230, DateTimeKind.Unspecified).AddTicks(1834), 12L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 111L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 55m, "Eum et exercitationem ducimus laudantium cum explicabo sunt nihil in.", new DateTime(2020, 3, 21, 15, 34, 32, 462, DateTimeKind.Unspecified).AddTicks(7741), 10L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 112L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 60m, "Sed rerum magni enim ab necessitatibus voluptatem aspernatur adipisci autem.", new DateTime(2020, 2, 13, 0, 20, 24, 443, DateTimeKind.Unspecified).AddTicks(71), 10L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 113L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 22m, "Et iste fuga quidem dolor qui cupiditate ea qui debitis.", new DateTime(2020, 2, 3, 19, 57, 4, 329, DateTimeKind.Unspecified).AddTicks(1027), 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 114L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 22m, "Molestiae reprehenderit atque quasi qui fugit iure modi eaque est.", new DateTime(2020, 10, 21, 3, 51, 5, 566, DateTimeKind.Unspecified).AddTicks(7623), 11L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 115L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 17m, "Accusamus quas et omnis qui porro voluptatum ratione est voluptatem.", new DateTime(2020, 10, 4, 19, 26, 40, 984, DateTimeKind.Unspecified).AddTicks(9383), 3L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 116L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 46m, "Et magnam optio facilis dicta omnis quia aut nemo omnis.", new DateTime(2020, 6, 17, 5, 14, 26, 129, DateTimeKind.Unspecified).AddTicks(9451), 3L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 117L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 23m, "Sint reiciendis repellendus qui eligendi labore corrupti hic voluptatem voluptatem.", new DateTime(2020, 12, 28, 19, 1, 54, 156, DateTimeKind.Unspecified).AddTicks(2289), 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 118L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 47m, "Dolorum suscipit at veritatis et fuga autem repellendus hic non.", new DateTime(2020, 11, 24, 23, 24, 32, 961, DateTimeKind.Unspecified).AddTicks(9687), 3L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 119L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 4m, "Adipisci at quis id qui vitae et autem consequatur voluptas.", new DateTime(2020, 2, 10, 2, 5, 31, 289, DateTimeKind.Unspecified).AddTicks(9520), 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 120L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 29m, "Doloribus tempore dolorem consequatur aut in sit aut voluptates sed.", new DateTime(2020, 4, 10, 20, 32, 39, 646, DateTimeKind.Unspecified).AddTicks(3086), 4L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 121L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 44m, "Accusantium sunt quia porro magni nihil possimus voluptate et numquam.", new DateTime(2020, 8, 8, 8, 38, 52, 544, DateTimeKind.Unspecified).AddTicks(45), 5L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 122L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 50m, "Delectus dicta sunt iusto ut enim quibusdam ad iure ut.", new DateTime(2020, 2, 23, 20, 27, 17, 383, DateTimeKind.Unspecified).AddTicks(7233), 2L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 123L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 13m, "Rerum magnam minima commodi deleniti eveniet voluptas autem natus aliquam.", new DateTime(2020, 11, 20, 10, 46, 44, 401, DateTimeKind.Unspecified).AddTicks(2489), 2L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 124L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 35m, "Voluptatem est et quasi magnam ex consequatur dolorem accusantium necessitatibus.", new DateTime(2020, 9, 22, 11, 2, 30, 809, DateTimeKind.Unspecified).AddTicks(6344), 1L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 125L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 45m, "Amet ut dolorum quam sed sed praesentium ea recusandae maiores.", new DateTime(2020, 12, 9, 15, 23, 48, 525, DateTimeKind.Unspecified).AddTicks(1280), 4L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 126L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 10m, "Non quo ut dolores officia non aliquam omnis qui accusantium.", new DateTime(2020, 1, 24, 6, 49, 38, 710, DateTimeKind.Unspecified).AddTicks(6301), 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 127L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Modi reprehenderit aliquid consectetur sapiente perferendis est officia quidem nam.", new DateTime(2020, 3, 18, 20, 24, 35, 569, DateTimeKind.Unspecified).AddTicks(4731), 4L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 128L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 37m, "Cum nam id alias nostrum quo ullam consectetur ut occaecati.", new DateTime(2020, 2, 14, 22, 35, 7, 586, DateTimeKind.Unspecified).AddTicks(1788), 9L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 129L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 24m, "Iure deserunt delectus consequatur voluptas nisi dolor perspiciatis quidem eos.", new DateTime(2020, 7, 1, 0, 59, 57, 829, DateTimeKind.Unspecified).AddTicks(9336), 4L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 130L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 57m, "Sed nobis sit ea sunt quidem aut sint nostrum qui.", new DateTime(2020, 7, 25, 19, 51, 3, 50, DateTimeKind.Unspecified).AddTicks(2333), 3L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 131L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Pariatur eum quos ut sint velit sed ipsa cumque nemo.", new DateTime(2020, 10, 28, 20, 23, 38, 313, DateTimeKind.Unspecified).AddTicks(547), 11L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 132L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Accusantium mollitia porro labore enim ea doloribus vero laboriosam ullam.", new DateTime(2020, 6, 10, 0, 41, 5, 970, DateTimeKind.Unspecified).AddTicks(8541), 8L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 133L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 28m, "Corporis excepturi voluptas hic occaecati ratione eligendi consequatur est ab.", new DateTime(2020, 4, 22, 7, 13, 43, 387, DateTimeKind.Unspecified).AddTicks(3652), 7L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 134L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 9m, "Voluptatibus officiis ut nemo velit ut necessitatibus eligendi id alias.", new DateTime(2020, 9, 27, 20, 45, 37, 681, DateTimeKind.Unspecified).AddTicks(5980), 2L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 135L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 60m, "Quos consectetur animi distinctio saepe minus id consectetur ut repudiandae.", new DateTime(2020, 1, 16, 17, 41, 55, 960, DateTimeKind.Unspecified).AddTicks(6068), 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 136L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 13m, "Hic nam impedit voluptates dolorum eum officiis totam possimus voluptas.", new DateTime(2020, 6, 9, 12, 26, 46, 305, DateTimeKind.Unspecified).AddTicks(7318), 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 137L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 37m, "Est voluptas nulla illo aut cumque ipsam blanditiis qui officiis.", new DateTime(2020, 7, 30, 13, 51, 59, 766, DateTimeKind.Unspecified).AddTicks(5924), 6L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 138L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 48m, "Sit et quae et sed tempore maxime architecto nostrum adipisci.", new DateTime(2020, 6, 4, 20, 7, 34, 292, DateTimeKind.Unspecified).AddTicks(2924), 11L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 139L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 1m, "Iusto enim repellat natus sequi consequuntur esse omnis et quia.", new DateTime(2020, 2, 13, 5, 38, 13, 426, DateTimeKind.Unspecified).AddTicks(2877), 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 140L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 30m, "Numquam quo odio et ea vitae dolores consequuntur veniam facere.", new DateTime(2020, 11, 27, 3, 30, 5, 120, DateTimeKind.Unspecified).AddTicks(5709), 10L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 141L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 42m, "Voluptatum est non necessitatibus qui nostrum voluptatem dolor officiis voluptates.", new DateTime(2020, 11, 13, 8, 46, 1, 267, DateTimeKind.Unspecified).AddTicks(62), 11L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 142L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 33m, "Error voluptas quisquam quibusdam assumenda magnam vero blanditiis possimus tempora.", new DateTime(2020, 5, 18, 23, 35, 8, 516, DateTimeKind.Unspecified).AddTicks(1962), 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 143L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 18m, "Doloribus et possimus magnam voluptatem quo ullam quam asperiores ullam.", new DateTime(2020, 11, 22, 7, 11, 47, 818, DateTimeKind.Unspecified).AddTicks(6499), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 144L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Sapiente non assumenda odit nihil culpa error dignissimos aperiam alias.", new DateTime(2020, 6, 22, 13, 6, 0, 865, DateTimeKind.Unspecified).AddTicks(9249), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 145L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Necessitatibus maiores beatae unde ea quo amet harum voluptatem mollitia.", new DateTime(2020, 11, 5, 7, 46, 20, 878, DateTimeKind.Unspecified).AddTicks(9011), 1L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 146L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Nulla quam facilis nesciunt dolor dolorem dolores incidunt praesentium nihil.", new DateTime(2020, 4, 3, 17, 18, 42, 812, DateTimeKind.Unspecified).AddTicks(7814), 4L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 147L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 33m, "Non possimus sed est accusamus veniam provident aut eius id.", new DateTime(2020, 9, 29, 21, 33, 23, 837, DateTimeKind.Unspecified).AddTicks(47), 3L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 148L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 20m, "Autem ipsum quasi eaque quia nihil mollitia laborum ex aut.", new DateTime(2020, 11, 6, 22, 45, 8, 71, DateTimeKind.Unspecified).AddTicks(7170), 10L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 149L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 40m, "Cupiditate autem numquam explicabo ut quidem quam qui deleniti iure.", new DateTime(2020, 7, 10, 16, 45, 17, 166, DateTimeKind.Unspecified).AddTicks(1658), 10L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 150L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 50m, "Sed eaque tenetur sit reiciendis dolorem vero nostrum quidem exercitationem.", new DateTime(2020, 8, 12, 9, 30, 45, 783, DateTimeKind.Unspecified).AddTicks(9693), 12L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 151L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 36m, "In qui illum pariatur omnis officiis corrupti nulla reprehenderit aut.", new DateTime(2020, 12, 15, 12, 2, 25, 180, DateTimeKind.Unspecified).AddTicks(6449), 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 152L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 59m, "Est soluta labore aliquid consequatur omnis velit voluptatem voluptatem vel.", new DateTime(2020, 11, 29, 12, 31, 12, 607, DateTimeKind.Unspecified).AddTicks(4861), 1L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 153L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 14m, "Id sint odit est nobis dolorem repellat laboriosam sunt rerum.", new DateTime(2020, 10, 20, 11, 37, 2, 340, DateTimeKind.Unspecified).AddTicks(8253), 3L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 154L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 21m, "Est voluptas tempora assumenda quaerat debitis animi tenetur inventore quidem.", new DateTime(2020, 5, 7, 13, 3, 30, 473, DateTimeKind.Unspecified).AddTicks(2986), 7L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 155L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Quia alias consequatur ea architecto aliquam odit voluptatum alias ratione.", new DateTime(2020, 3, 9, 12, 25, 1, 415, DateTimeKind.Unspecified).AddTicks(1722), 7L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 156L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 21m, "Aut exercitationem eos architecto esse ab libero dolor officia enim.", new DateTime(2020, 12, 26, 20, 51, 10, 923, DateTimeKind.Unspecified).AddTicks(8864), 2L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 157L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 47m, "Eos rem dolores dolores quidem repudiandae numquam similique dolores consequatur.", new DateTime(2020, 8, 20, 15, 52, 44, 567, DateTimeKind.Unspecified).AddTicks(7743), 8L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 158L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 10m, "Voluptas beatae dolore quia saepe dolore nulla omnis dolores iusto.", new DateTime(2020, 4, 1, 23, 37, 51, 198, DateTimeKind.Unspecified).AddTicks(9188), 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 159L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 57m, "Velit sed corporis sequi dolorum quia laborum provident aut accusantium.", new DateTime(2020, 5, 30, 19, 59, 55, 576, DateTimeKind.Unspecified).AddTicks(4540), 6L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 160L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 32m, "Nesciunt voluptas velit voluptatem et dolores laboriosam molestias accusantium molestiae.", new DateTime(2020, 2, 20, 2, 12, 30, 487, DateTimeKind.Unspecified).AddTicks(3164), 1L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 161L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Aut optio quisquam quas quas enim nesciunt animi quas molestias.", new DateTime(2020, 12, 10, 5, 55, 20, 876, DateTimeKind.Unspecified).AddTicks(2372), 6L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 162L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 18m, "Quasi eius est dolorem aut corporis id dolorem accusantium blanditiis.", new DateTime(2020, 7, 24, 1, 50, 29, 881, DateTimeKind.Unspecified).AddTicks(4432), 5L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 163L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 55m, "Molestias vel consequuntur incidunt iure sint iste enim nemo earum.", new DateTime(2020, 8, 10, 20, 19, 22, 119, DateTimeKind.Unspecified).AddTicks(3928), 7L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 164L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 34m, "Dolorem ut nulla officiis itaque doloremque odio consequatur velit sed.", new DateTime(2020, 5, 20, 20, 41, 42, 425, DateTimeKind.Unspecified).AddTicks(9437), 4L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 165L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 49m, "Tempore ut ipsum officia nam magnam sunt consequuntur eum et.", new DateTime(2020, 6, 30, 18, 34, 43, 540, DateTimeKind.Unspecified).AddTicks(7718), 7L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 166L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 46m, "Repudiandae dolor quaerat dolore et ipsa nisi consequuntur est praesentium.", new DateTime(2020, 10, 3, 12, 2, 11, 651, DateTimeKind.Unspecified).AddTicks(9716), 12L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 167L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 42m, "Dolor molestiae tenetur facere voluptatem placeat rerum eaque est aut.", new DateTime(2020, 6, 20, 2, 34, 8, 977, DateTimeKind.Unspecified).AddTicks(1961), 3L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 168L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 42m, "Sint id suscipit eveniet ad soluta saepe esse earum doloremque.", new DateTime(2020, 6, 21, 19, 55, 29, 534, DateTimeKind.Unspecified).AddTicks(4448), 9L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 169L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 33m, "Expedita impedit et dicta repellendus iure rerum praesentium quis repellendus.", new DateTime(2020, 6, 19, 8, 32, 18, 731, DateTimeKind.Unspecified).AddTicks(126), 1L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 170L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 53m, "Aut quis quae temporibus sunt facilis est alias quia beatae.", new DateTime(2020, 2, 13, 7, 13, 5, 298, DateTimeKind.Unspecified).AddTicks(8975), 4L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 171L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 46m, "Voluptatibus et eaque similique veniam explicabo vel veritatis ea fugit.", new DateTime(2020, 10, 22, 13, 39, 2, 867, DateTimeKind.Unspecified).AddTicks(2051), 5L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 172L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Voluptatem omnis officiis enim natus voluptatem voluptate expedita maiores molestiae.", new DateTime(2020, 10, 2, 13, 5, 56, 922, DateTimeKind.Unspecified).AddTicks(6350), 11L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 173L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 39m, "Officia sed dolor repellat qui amet voluptatum commodi maxime blanditiis.", new DateTime(2020, 12, 9, 23, 33, 14, 803, DateTimeKind.Unspecified).AddTicks(6768), 9L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 174L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 57m, "Molestiae non dignissimos corrupti saepe omnis nobis sunt quia aperiam.", new DateTime(2020, 6, 29, 13, 34, 1, 340, DateTimeKind.Unspecified).AddTicks(9788), 3L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 175L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 20m, "Itaque fugit est laudantium nesciunt est voluptatum qui sit ut.", new DateTime(2020, 5, 9, 6, 8, 45, 613, DateTimeKind.Unspecified).AddTicks(8964), 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 176L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 58m, "Aut esse unde ut provident laudantium qui inventore atque reprehenderit.", new DateTime(2020, 7, 31, 18, 28, 33, 893, DateTimeKind.Unspecified).AddTicks(884), 12L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 177L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 1m, "Sit placeat omnis et fugiat ratione molestiae harum assumenda quaerat.", new DateTime(2020, 12, 22, 3, 55, 9, 362, DateTimeKind.Unspecified).AddTicks(4225), 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 178L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Animi aspernatur doloribus sit aut qui voluptas temporibus corrupti nobis.", new DateTime(2020, 6, 21, 4, 15, 37, 687, DateTimeKind.Unspecified).AddTicks(8467), 4L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 179L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 53m, "Harum exercitationem ut est possimus blanditiis quos culpa sunt cumque.", new DateTime(2020, 8, 8, 8, 36, 53, 385, DateTimeKind.Unspecified).AddTicks(9302), 9L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 180L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 10m, "Est quis tempore voluptas asperiores fuga blanditiis eum in mollitia.", new DateTime(2020, 7, 12, 16, 4, 6, 280, DateTimeKind.Unspecified).AddTicks(1502), 5L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 181L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 33m, "Voluptatem sunt unde rerum unde unde alias rem quisquam explicabo.", new DateTime(2020, 4, 2, 3, 4, 31, 124, DateTimeKind.Unspecified).AddTicks(7868), 1L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 182L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 1m, "Non nostrum animi ut sed mollitia eos velit perferendis corrupti.", new DateTime(2020, 8, 12, 20, 55, 48, 424, DateTimeKind.Unspecified).AddTicks(913), 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 183L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 15m, "Eveniet rerum ea sint quia hic voluptatem deleniti sequi repellendus.", new DateTime(2020, 6, 3, 19, 47, 6, 49, DateTimeKind.Unspecified).AddTicks(8289), 11L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 184L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 10m, "Similique in facere voluptatibus aut odio vero aut asperiores officiis.", new DateTime(2020, 3, 3, 16, 51, 0, 246, DateTimeKind.Unspecified).AddTicks(8237), 1L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 185L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Architecto inventore illo sunt consequuntur facere sunt est id dolores.", new DateTime(2020, 5, 27, 21, 46, 15, 217, DateTimeKind.Unspecified).AddTicks(6128), 10L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 186L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 2m, "Eos illum expedita modi nihil a et iusto id voluptates.", new DateTime(2020, 9, 13, 4, 41, 10, 535, DateTimeKind.Unspecified).AddTicks(5782), 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 187L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 47m, "Hic corrupti voluptatum omnis unde magnam ea explicabo qui enim.", new DateTime(2020, 5, 22, 7, 28, 28, 193, DateTimeKind.Unspecified).AddTicks(3490), 11L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 188L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 48m, "Voluptas quaerat dolor ut quod vel aut dolor numquam illum.", new DateTime(2020, 8, 10, 8, 0, 17, 803, DateTimeKind.Unspecified).AddTicks(7927), 3L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 189L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 38m, "Quia ratione id ratione consequatur temporibus dolorem dolore sit aliquam.", new DateTime(2020, 6, 10, 2, 44, 12, 132, DateTimeKind.Unspecified).AddTicks(4844), 2L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 190L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Dicta nisi consequatur consequatur aliquid fugiat mollitia voluptatum qui et.", new DateTime(2020, 8, 22, 21, 45, 15, 980, DateTimeKind.Unspecified).AddTicks(343), 3L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 191L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 46m, "Enim distinctio voluptatem aut vel voluptas assumenda culpa impedit impedit.", new DateTime(2020, 10, 24, 23, 57, 2, 775, DateTimeKind.Unspecified).AddTicks(6544), 1L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 192L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 36m, "Labore et incidunt ullam quia non sunt accusamus ducimus modi.", new DateTime(2020, 12, 21, 8, 41, 8, 155, DateTimeKind.Unspecified).AddTicks(8218), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 193L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 51m, "Esse maiores et autem reiciendis inventore reiciendis ex itaque perferendis.", new DateTime(2020, 1, 16, 22, 52, 17, 340, DateTimeKind.Unspecified).AddTicks(6823), 8L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 194L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 30m, "Quidem expedita a sed et alias labore consequatur eum earum.", new DateTime(2020, 4, 10, 3, 24, 3, 397, DateTimeKind.Unspecified).AddTicks(6081), 5L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 195L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 24m, "Numquam explicabo aut quia est molestiae neque quisquam aut quaerat.", new DateTime(2020, 9, 5, 12, 3, 59, 724, DateTimeKind.Unspecified).AddTicks(2480), 11L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 196L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 53m, "Maiores eius nam ullam expedita qui incidunt temporibus ut iste.", new DateTime(2020, 8, 14, 0, 35, 4, 301, DateTimeKind.Unspecified).AddTicks(2003), 9L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 197L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 37m, "Animi delectus reprehenderit explicabo vel sunt qui voluptas alias nihil.", new DateTime(2020, 8, 11, 6, 44, 12, 689, DateTimeKind.Unspecified).AddTicks(9481), 2L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 198L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 55m, "At cumque optio tenetur iure ex qui dolorem ad aut.", new DateTime(2020, 5, 6, 16, 4, 10, 389, DateTimeKind.Unspecified).AddTicks(3213), 3L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 199L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 25m, "Eum blanditiis laudantium soluta ipsam omnis sed quo accusamus maxime.", new DateTime(2020, 3, 3, 20, 47, 35, 576, DateTimeKind.Unspecified).AddTicks(2714), 7L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 200L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Eius labore voluptatem nemo labore ipsam itaque similique eos temporibus.", new DateTime(2020, 9, 27, 17, 11, 19, 417, DateTimeKind.Unspecified).AddTicks(9623), 8L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 201L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 26m, "Eligendi nostrum accusamus quis ea quisquam aut perspiciatis sapiente totam.", new DateTime(2020, 10, 16, 2, 13, 14, 962, DateTimeKind.Unspecified).AddTicks(8748), 1L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 202L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 0m, "Eum hic nihil nisi et cum rerum aperiam hic sint.", new DateTime(2020, 10, 20, 16, 10, 27, 321, DateTimeKind.Unspecified).AddTicks(6563), 11L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 203L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 15m, "Mollitia tempore doloremque veritatis voluptas soluta ratione in debitis et.", new DateTime(2020, 6, 27, 3, 9, 51, 407, DateTimeKind.Unspecified).AddTicks(5800), 8L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 204L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 41m, "Minima soluta ad ducimus excepturi et id voluptates commodi nemo.", new DateTime(2020, 2, 18, 20, 40, 30, 816, DateTimeKind.Unspecified).AddTicks(9577), 8L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 205L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 40m, "Laboriosam tenetur et perspiciatis ut placeat hic quis odio ut.", new DateTime(2020, 6, 28, 22, 10, 17, 155, DateTimeKind.Unspecified).AddTicks(3969), 1L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 206L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 15m, "Architecto sit nihil id perspiciatis ad facere enim rerum voluptate.", new DateTime(2020, 11, 14, 21, 47, 26, 247, DateTimeKind.Unspecified).AddTicks(1612), 5L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 207L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 41m, "Nemo quisquam molestiae expedita consectetur quos labore et consequatur explicabo.", new DateTime(2020, 7, 12, 3, 54, 56, 780, DateTimeKind.Unspecified).AddTicks(3946), 10L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 208L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 60m, "Et nemo quam qui ab atque quo sit id doloremque.", new DateTime(2020, 9, 22, 13, 53, 33, 80, DateTimeKind.Unspecified).AddTicks(9927), 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 209L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 4m, "Enim voluptatem velit tempore modi voluptatem voluptatibus quisquam ut quis.", new DateTime(2020, 11, 27, 3, 9, 43, 801, DateTimeKind.Unspecified).AddTicks(9886), 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 210L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 9m, "Autem laborum dolorem nesciunt unde voluptas accusantium suscipit doloribus hic.", new DateTime(2020, 1, 5, 13, 14, 26, 340, DateTimeKind.Unspecified).AddTicks(5923), 7L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 211L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Fugit in sunt aut officia quia est repellendus saepe odit.", new DateTime(2020, 11, 8, 5, 9, 36, 305, DateTimeKind.Unspecified).AddTicks(9285), 2L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 212L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 31m, "Voluptas quae laudantium tempore rem nobis aut asperiores quia ea.", new DateTime(2020, 1, 4, 22, 20, 30, 899, DateTimeKind.Unspecified).AddTicks(3222), 9L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 213L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 59m, "Aperiam magnam nesciunt dolor velit at id qui veniam tenetur.", new DateTime(2020, 1, 15, 16, 20, 30, 37, DateTimeKind.Unspecified).AddTicks(7598), 10L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 214L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 35m, "Porro porro repellat sunt facere quas similique earum atque voluptas.", new DateTime(2020, 7, 17, 23, 11, 26, 877, DateTimeKind.Unspecified).AddTicks(750), 7L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 215L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Consectetur nobis nemo ducimus dolores harum facere facilis rerum voluptatibus.", new DateTime(2020, 4, 27, 16, 46, 41, 888, DateTimeKind.Unspecified).AddTicks(6996), 1L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 216L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 38m, "Voluptas excepturi aut harum qui numquam ad corrupti voluptate in.", new DateTime(2020, 12, 3, 14, 26, 29, 234, DateTimeKind.Unspecified).AddTicks(3868), 5L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 217L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Voluptas voluptatem est dolore provident deleniti tenetur animi est nisi.", new DateTime(2020, 5, 30, 6, 58, 4, 696, DateTimeKind.Unspecified).AddTicks(3388), 9L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 218L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Assumenda sit ipsa mollitia qui rerum dolor aut a earum.", new DateTime(2020, 11, 3, 13, 36, 3, 126, DateTimeKind.Unspecified).AddTicks(7999), 1L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 219L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 42m, "Minima qui et mollitia modi distinctio debitis et autem et.", new DateTime(2020, 11, 6, 21, 36, 28, 938, DateTimeKind.Unspecified).AddTicks(326), 8L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 220L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 9m, "Eos ut molestiae incidunt vel sed quisquam iure sed temporibus.", new DateTime(2020, 9, 3, 9, 1, 23, 459, DateTimeKind.Unspecified).AddTicks(1078), 12L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 221L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 48m, "Commodi nam eius molestiae harum magnam quia sint minima aut.", new DateTime(2020, 11, 30, 2, 49, 24, 945, DateTimeKind.Unspecified).AddTicks(7547), 9L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 222L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Facilis labore ut qui ad sit fugit esse sit autem.", new DateTime(2020, 3, 11, 19, 1, 24, 449, DateTimeKind.Unspecified).AddTicks(72), 9L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 223L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 54m, "Adipisci ad facilis possimus facere sunt ut impedit qui velit.", new DateTime(2020, 12, 25, 23, 4, 15, 785, DateTimeKind.Unspecified).AddTicks(8705), 10L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 224L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 57m, "Voluptatem illum perspiciatis sed aut in maxime exercitationem qui aut.", new DateTime(2020, 11, 4, 8, 31, 23, 922, DateTimeKind.Unspecified).AddTicks(6597), 3L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 225L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 57m, "Est nihil cumque doloribus enim et est alias laudantium non.", new DateTime(2020, 9, 5, 13, 58, 44, 772, DateTimeKind.Unspecified).AddTicks(2815), 6L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 226L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 56m, "Expedita est suscipit at quia dolorem sequi velit magnam cupiditate.", new DateTime(2020, 11, 18, 3, 27, 17, 187, DateTimeKind.Unspecified).AddTicks(5851), 8L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 227L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 54m, "Blanditiis voluptas similique vero velit voluptatem veritatis nesciunt dolores illum.", new DateTime(2020, 2, 23, 20, 48, 26, 675, DateTimeKind.Unspecified).AddTicks(6120), 2L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 228L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 15m, "Ex laborum omnis voluptates optio consequatur rerum quae totam suscipit.", new DateTime(2020, 3, 22, 8, 27, 53, 187, DateTimeKind.Unspecified).AddTicks(6530), 9L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 229L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 27m, "Ipsum dolor ex et quis dolorem unde fuga commodi similique.", new DateTime(2020, 10, 17, 7, 14, 8, 783, DateTimeKind.Unspecified).AddTicks(1639), 9L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 230L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 30m, "Minima occaecati nihil assumenda rerum saepe nulla rerum placeat est.", new DateTime(2020, 11, 15, 15, 5, 2, 605, DateTimeKind.Unspecified).AddTicks(3041), 9L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 231L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 24m, "Quis incidunt qui ut non et maiores ipsam praesentium veniam.", new DateTime(2020, 4, 4, 20, 1, 5, 970, DateTimeKind.Unspecified).AddTicks(1579), 2L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 232L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 44m, "Magnam quia numquam qui itaque qui assumenda hic harum hic.", new DateTime(2020, 9, 18, 18, 21, 9, 599, DateTimeKind.Unspecified).AddTicks(2599), 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 233L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 32m, "Et harum neque hic error eos magnam dolores molestiae temporibus.", new DateTime(2020, 8, 8, 10, 28, 49, 87, DateTimeKind.Unspecified).AddTicks(7488), 1L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 234L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 58m, "Inventore nihil est unde dolor fugit iure ut molestias error.", new DateTime(2020, 7, 6, 12, 17, 43, 285, DateTimeKind.Unspecified).AddTicks(5025), 5L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 235L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 25m, "Animi adipisci laboriosam harum perferendis qui rerum eum quia quia.", new DateTime(2020, 8, 23, 4, 58, 7, 789, DateTimeKind.Unspecified).AddTicks(834), 10L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 236L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 7m, "Dolor molestiae fugit nobis harum aut saepe quia ullam perferendis.", new DateTime(2020, 6, 24, 19, 14, 43, 335, DateTimeKind.Unspecified).AddTicks(2799), 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 237L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 54m, "Consequuntur mollitia omnis qui dolores fugiat provident ut ducimus qui.", new DateTime(2020, 2, 22, 22, 46, 41, 735, DateTimeKind.Unspecified).AddTicks(3812), 3L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 238L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 14m, "Corporis voluptatum porro id quidem enim possimus beatae qui quo.", new DateTime(2020, 1, 29, 12, 2, 41, 708, DateTimeKind.Unspecified).AddTicks(6985), 6L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 239L,
                columns: new[] { "AmountOfHours", "Comment", "Date" },
                values: new object[] { 23m, "Saepe quia repudiandae non nemo asperiores cumque cupiditate dolorum vel.", new DateTime(2020, 7, 12, 14, 26, 57, 855, DateTimeKind.Unspecified).AddTicks(6357) });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 240L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 33m, "Reiciendis porro dignissimos sunt qui distinctio et dolorem exercitationem fugit.", new DateTime(2020, 8, 1, 19, 18, 38, 63, DateTimeKind.Unspecified).AddTicks(3571), 11L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 241L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Ratione quo delectus distinctio nemo qui nisi consequuntur atque quo.", new DateTime(2020, 2, 18, 15, 36, 33, 991, DateTimeKind.Unspecified).AddTicks(1433), 9L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 242L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 47m, "At laboriosam non doloribus est numquam aspernatur minus enim voluptates.", new DateTime(2020, 7, 13, 6, 45, 37, 20, DateTimeKind.Unspecified).AddTicks(3698), 2L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 243L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Accusantium et soluta iusto eos expedita vel repellendus velit esse.", new DateTime(2020, 6, 27, 23, 26, 20, 305, DateTimeKind.Unspecified).AddTicks(4219), 5L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 244L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 52m, "Ut minus dolorem facilis magni consequuntur aut a qui eos.", new DateTime(2020, 3, 15, 14, 57, 45, 210, DateTimeKind.Unspecified).AddTicks(4122), 3L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 245L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 25m, "Error inventore iste odio et ad aspernatur soluta aperiam enim.", new DateTime(2020, 12, 13, 4, 32, 47, 632, DateTimeKind.Unspecified).AddTicks(5323), 3L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 246L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Molestiae fugit est magnam aut dolore et ut dicta laudantium.", new DateTime(2020, 5, 27, 4, 4, 56, 758, DateTimeKind.Unspecified).AddTicks(7942), 9L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 247L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Numquam illum aliquam earum impedit delectus eius ex eos ut.", new DateTime(2020, 2, 4, 9, 27, 15, 699, DateTimeKind.Unspecified).AddTicks(7738), 10L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 248L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 33m, "Cumque excepturi quam quaerat est et aperiam rem non recusandae.", new DateTime(2020, 10, 4, 18, 6, 8, 910, DateTimeKind.Unspecified).AddTicks(9241), 11L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 249L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Ut sunt nihil nostrum sit accusantium laudantium numquam inventore veniam.", new DateTime(2020, 11, 30, 16, 54, 4, 70, DateTimeKind.Unspecified).AddTicks(7714), 2L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 250L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 34m, "Aliquam placeat laudantium vitae corrupti rerum quo in quae deleniti.", new DateTime(2020, 11, 6, 23, 11, 48, 8, DateTimeKind.Unspecified).AddTicks(8051), 8L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 251L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 45m, "Est quia doloremque aut illo adipisci eum assumenda velit dolores.", new DateTime(2020, 1, 14, 2, 20, 0, 171, DateTimeKind.Unspecified).AddTicks(3390), 9L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 252L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 29m, "Blanditiis eos explicabo nostrum inventore laudantium numquam laudantium totam dolorem.", new DateTime(2020, 2, 1, 23, 54, 57, 755, DateTimeKind.Unspecified).AddTicks(9342), 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 253L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 24m, "Quae tempora et asperiores asperiores porro id minus magnam sequi.", new DateTime(2020, 3, 9, 15, 31, 48, 136, DateTimeKind.Unspecified).AddTicks(854), 5L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 254L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 29m, "Unde ut suscipit omnis eos aliquid quia et eum ut.", new DateTime(2020, 3, 8, 10, 31, 58, 457, DateTimeKind.Unspecified).AddTicks(3916), 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 255L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Vero quia et sunt consequatur doloribus est aut voluptas facere.", new DateTime(2020, 7, 13, 13, 12, 10, 969, DateTimeKind.Unspecified).AddTicks(7313), 9L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 256L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 43m, "Rerum itaque voluptates ea veniam minus repudiandae et quos ducimus.", new DateTime(2020, 11, 19, 15, 13, 16, 818, DateTimeKind.Unspecified).AddTicks(7170), 2L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 257L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Voluptas corporis et quam amet praesentium debitis quae ex nostrum.", new DateTime(2020, 4, 11, 5, 18, 59, 149, DateTimeKind.Unspecified).AddTicks(5064), 8L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 258L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 35m, "Magni qui voluptatem quos rem in sit ducimus odio est.", new DateTime(2020, 10, 5, 10, 4, 17, 809, DateTimeKind.Unspecified).AddTicks(1462), 4L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 259L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 21m, "Quo aliquid maiores ipsum quo officia dolores sed necessitatibus ipsam.", new DateTime(2020, 3, 26, 11, 55, 52, 385, DateTimeKind.Unspecified).AddTicks(1490), 3L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 260L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 51m, "Qui et possimus dicta aut suscipit consequatur et molestiae laborum.", new DateTime(2020, 11, 5, 1, 30, 25, 613, DateTimeKind.Unspecified).AddTicks(8648), 5L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 261L,
                columns: new[] { "AmountOfHours", "Comment", "Date" },
                values: new object[] { 24m, "Eos eos magni reprehenderit tempora occaecati sit consequatur corporis voluptatum.", new DateTime(2020, 2, 13, 10, 57, 22, 69, DateTimeKind.Unspecified).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 262L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 36m, "Optio impedit enim quae natus dolor eos qui delectus sed.", new DateTime(2020, 6, 11, 13, 12, 52, 896, DateTimeKind.Unspecified).AddTicks(9632), 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 263L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 49m, "Et autem consequatur quo totam quod tempore placeat sit temporibus.", new DateTime(2020, 12, 28, 21, 55, 45, 5, DateTimeKind.Unspecified).AddTicks(9930), 3L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 264L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 35m, "Ipsam veniam id et saepe omnis quia porro ullam ipsam.", new DateTime(2020, 7, 7, 0, 51, 39, 42, DateTimeKind.Unspecified).AddTicks(2949), 4L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 265L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Ipsum non similique sit provident occaecati vitae non nam facilis.", new DateTime(2020, 7, 14, 10, 39, 39, 215, DateTimeKind.Unspecified).AddTicks(214), 9L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 266L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 57m, "Cupiditate cupiditate pariatur ut nam veniam molestias nobis animi voluptatem.", new DateTime(2020, 12, 3, 4, 14, 2, 892, DateTimeKind.Unspecified).AddTicks(3842), 1L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 267L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 12m, "Architecto quos occaecati non quia harum in aliquam modi et.", new DateTime(2020, 8, 8, 18, 46, 0, 481, DateTimeKind.Unspecified).AddTicks(4576), 10L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 268L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 23m, "Et a aspernatur consectetur vero quaerat adipisci omnis laudantium beatae.", new DateTime(2020, 7, 1, 20, 39, 58, 811, DateTimeKind.Unspecified).AddTicks(2975), 4L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 269L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 29m, "Voluptas unde voluptas voluptatem sint debitis vero quia consequuntur quia.", new DateTime(2020, 7, 13, 21, 17, 6, 787, DateTimeKind.Unspecified).AddTicks(5060), 6L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 270L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 16m, "Ullam maiores ducimus tempore repellendus consequuntur et facilis et vel.", new DateTime(2020, 5, 15, 23, 33, 41, 210, DateTimeKind.Unspecified).AddTicks(9365), 5L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 271L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 17m, "Accusantium odio magnam a aut sunt molestiae tempore ut rem.", new DateTime(2020, 1, 4, 14, 41, 15, 793, DateTimeKind.Unspecified).AddTicks(9719), 1L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 272L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 27m, "Fugiat et eligendi sunt necessitatibus molestiae voluptatum deleniti harum id.", new DateTime(2020, 7, 11, 14, 51, 1, 795, DateTimeKind.Unspecified).AddTicks(7424), 6L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 273L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 41m, "Fuga sint delectus in et error ratione nobis molestiae ut.", new DateTime(2020, 6, 4, 1, 51, 27, 303, DateTimeKind.Unspecified).AddTicks(9843), 3L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 274L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 38m, "Dignissimos aut animi neque animi dolorum consequatur repellat sed dolor.", new DateTime(2020, 5, 5, 6, 31, 40, 233, DateTimeKind.Unspecified).AddTicks(1962), 6L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 275L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 33m, "Aut est corrupti optio nam et quae accusantium molestias dolores.", new DateTime(2020, 10, 26, 20, 7, 0, 606, DateTimeKind.Unspecified).AddTicks(4561), 10L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 276L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 9m, "Repellat voluptatem iure est qui pariatur eaque distinctio alias corporis.", new DateTime(2020, 4, 18, 18, 12, 9, 683, DateTimeKind.Unspecified).AddTicks(974), 10L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 277L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 38m, "Qui sit consequuntur dolor maxime animi debitis minima ab atque.", new DateTime(2020, 11, 17, 1, 44, 33, 792, DateTimeKind.Unspecified).AddTicks(7287), 8L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 278L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 25m, "Totam odit voluptate rerum voluptas distinctio alias ut qui nulla.", new DateTime(2020, 8, 1, 3, 48, 24, 820, DateTimeKind.Unspecified).AddTicks(179), 6L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 279L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 9m, "Facilis amet eveniet et consequatur quam et quia quis ut.", new DateTime(2020, 7, 5, 23, 17, 49, 924, DateTimeKind.Unspecified).AddTicks(4845), 3L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 280L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 43m, "Aspernatur ut asperiores atque ut et consectetur eveniet eveniet neque.", new DateTime(2020, 4, 9, 13, 42, 44, 963, DateTimeKind.Unspecified).AddTicks(2043), 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 281L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 25m, "Temporibus veniam veniam omnis sunt qui harum et officia placeat.", new DateTime(2020, 8, 18, 9, 37, 26, 204, DateTimeKind.Unspecified).AddTicks(2076), 9L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 282L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Minus iusto nihil harum reprehenderit minima accusamus quos pariatur perferendis.", new DateTime(2020, 10, 16, 14, 34, 52, 57, DateTimeKind.Unspecified).AddTicks(7309), 9L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 283L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 45m, "Quis minus reprehenderit sequi temporibus sed sed sunt est iusto.", new DateTime(2020, 12, 16, 23, 12, 21, 598, DateTimeKind.Unspecified).AddTicks(818), 8L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 284L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 14m, "Ipsam dolore facere odit eum ab neque praesentium id nulla.", new DateTime(2020, 2, 1, 7, 1, 12, 564, DateTimeKind.Unspecified).AddTicks(5213), 10L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 285L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 18m, "Et enim vitae velit est necessitatibus in at ex in.", new DateTime(2020, 7, 23, 12, 30, 20, 886, DateTimeKind.Unspecified).AddTicks(5837), 5L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 286L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 39m, "Placeat doloribus accusantium pariatur adipisci quidem quia id quaerat deserunt.", new DateTime(2020, 8, 10, 12, 54, 12, 622, DateTimeKind.Unspecified).AddTicks(9345), 1L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 287L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 50m, "Repellat unde sit dignissimos est labore expedita esse ex ea.", new DateTime(2020, 8, 1, 1, 12, 17, 282, DateTimeKind.Unspecified).AddTicks(5717), 10L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 288L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 27m, "Necessitatibus dolor id et dignissimos occaecati quo placeat illum aut.", new DateTime(2020, 8, 28, 10, 44, 20, 475, DateTimeKind.Unspecified).AddTicks(9784), 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 289L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 50m, "Perferendis corrupti dolores et nemo facere vero consequatur dolore molestiae.", new DateTime(2020, 2, 14, 13, 5, 52, 954, DateTimeKind.Unspecified).AddTicks(4409), 12L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 290L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 20m, "Harum fuga vitae repellat voluptatibus porro porro vitae vero qui.", new DateTime(2020, 12, 28, 7, 0, 2, 957, DateTimeKind.Unspecified).AddTicks(3752), 6L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 291L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 15m, "Minus ex nostrum est sed fugiat ea et enim ut.", new DateTime(2020, 2, 11, 8, 5, 57, 357, DateTimeKind.Unspecified).AddTicks(909), 11L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 292L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Non consequatur corporis architecto provident eum sed adipisci saepe voluptatem.", new DateTime(2020, 8, 8, 19, 23, 31, 476, DateTimeKind.Unspecified).AddTicks(4106), 12L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 293L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 56m, "Harum ipsam in dolore rerum est architecto necessitatibus quidem non.", new DateTime(2020, 2, 10, 0, 0, 0, 854, DateTimeKind.Unspecified).AddTicks(288), 4L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 294L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Ex dolor fugit beatae fugit quidem voluptatem quae sint reprehenderit.", new DateTime(2020, 12, 6, 10, 4, 47, 622, DateTimeKind.Unspecified).AddTicks(3018), 7L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 295L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 32m, "Laudantium qui repellendus quo est rem incidunt tenetur quas rerum.", new DateTime(2020, 2, 18, 10, 43, 23, 232, DateTimeKind.Unspecified).AddTicks(4345), 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 296L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Quia sunt dolorem vel blanditiis aliquid voluptas porro eaque et.", new DateTime(2020, 1, 3, 0, 44, 17, 503, DateTimeKind.Unspecified).AddTicks(2694), 4L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 297L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 35m, "Quibusdam aut porro voluptates voluptatum sed molestiae quos molestiae sed.", new DateTime(2020, 10, 12, 19, 50, 56, 224, DateTimeKind.Unspecified).AddTicks(9636), 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 298L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 24m, "Tempore rem vel quia et aut officiis nihil similique voluptatem.", new DateTime(2020, 7, 14, 11, 56, 9, 975, DateTimeKind.Unspecified).AddTicks(4781), 4L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 299L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 45m, "Aut sint nihil magnam eligendi est nesciunt dolores et ex.", new DateTime(2020, 9, 13, 12, 33, 17, 348, DateTimeKind.Unspecified).AddTicks(1895), 7L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 300L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 41m, "Nam quis rerum alias illum odio ipsa similique illo dolorem.", new DateTime(2020, 8, 12, 10, 9, 26, 930, DateTimeKind.Unspecified).AddTicks(1010), 11L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 301L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 22m, "Odio error harum optio quo nobis reprehenderit excepturi aut dolor.", new DateTime(2020, 9, 18, 5, 13, 38, 269, DateTimeKind.Unspecified).AddTicks(6132), 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 302L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 10m, "Omnis blanditiis id neque et adipisci omnis minima quia ad.", new DateTime(2020, 3, 28, 23, 26, 41, 703, DateTimeKind.Unspecified).AddTicks(5356), 12L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 303L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 32m, "Et quaerat voluptate accusantium recusandae repellendus illo ex quisquam qui.", new DateTime(2020, 9, 15, 4, 44, 37, 14, DateTimeKind.Unspecified).AddTicks(8446), 8L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 304L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 9m, "Quia voluptas labore recusandae sed eos perferendis mollitia natus nobis.", new DateTime(2020, 4, 15, 15, 12, 37, 486, DateTimeKind.Unspecified).AddTicks(6028), 2L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 305L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 9m, "Ea ea minus culpa reiciendis vero facilis pariatur est minus.", new DateTime(2020, 8, 12, 19, 35, 33, 360, DateTimeKind.Unspecified).AddTicks(30), 12L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 306L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 11m, "Id repellendus provident sunt et est odit odio aperiam doloremque.", new DateTime(2020, 2, 15, 23, 42, 39, 387, DateTimeKind.Unspecified).AddTicks(7400), 1L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 307L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 16m, "Cumque est eos quam ipsum saepe asperiores commodi dicta ab.", new DateTime(2020, 7, 9, 19, 53, 1, 902, DateTimeKind.Unspecified).AddTicks(1335), 12L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 308L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 19m, "Doloribus molestias voluptatibus placeat id qui eos est voluptatem mollitia.", new DateTime(2020, 7, 5, 9, 40, 1, 338, DateTimeKind.Unspecified).AddTicks(2284), 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 309L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 56m, "Quia nihil cupiditate eos suscipit quis voluptatem ab accusamus provident.", new DateTime(2020, 1, 20, 13, 27, 24, 733, DateTimeKind.Unspecified).AddTicks(9164), 4L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 310L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 22m, "Optio deleniti fuga voluptatum aut dolor ducimus cupiditate quae nemo.", new DateTime(2020, 3, 14, 14, 50, 44, 555, DateTimeKind.Unspecified).AddTicks(5221), 2L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 311L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 56m, "Sunt ut consequatur dolorem voluptas quasi eaque eum cupiditate consequatur.", new DateTime(2020, 5, 30, 15, 46, 13, 21, DateTimeKind.Unspecified).AddTicks(7185), 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 312L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 57m, "Quidem ducimus laudantium molestias dolorum corrupti architecto tempore aut dolores.", new DateTime(2020, 3, 4, 23, 47, 31, 16, DateTimeKind.Unspecified).AddTicks(920), 11L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 313L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 48m, "Expedita eius aperiam quidem sapiente modi deleniti id est fugit.", new DateTime(2020, 6, 23, 11, 58, 13, 366, DateTimeKind.Unspecified).AddTicks(2392), 5L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 314L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 19m, "A vel vel delectus est molestias necessitatibus mollitia nulla mollitia.", new DateTime(2020, 5, 2, 7, 6, 32, 457, DateTimeKind.Unspecified).AddTicks(5761), 1L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 315L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 54m, "Exercitationem tempore ut sunt mollitia labore qui nemo omnis praesentium.", new DateTime(2020, 11, 9, 3, 12, 50, 976, DateTimeKind.Unspecified).AddTicks(4713), 3L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 316L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Est aliquid sed quos sequi omnis porro neque facere itaque.", new DateTime(2020, 6, 17, 19, 29, 55, 190, DateTimeKind.Unspecified).AddTicks(6442), 8L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 317L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Quis iusto iste ipsa consequatur culpa enim illo pariatur illum.", new DateTime(2020, 11, 30, 10, 13, 0, 429, DateTimeKind.Unspecified).AddTicks(8885), 7L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 318L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 39m, "Aperiam et autem et quae vero officiis dolores deleniti officia.", new DateTime(2020, 8, 3, 6, 7, 32, 866, DateTimeKind.Unspecified).AddTicks(9967), 10L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 319L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 8m, "Sint voluptas et et voluptas libero recusandae nisi ut magni.", new DateTime(2020, 3, 8, 6, 48, 50, 257, DateTimeKind.Unspecified).AddTicks(7848), 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 320L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 40m, "Et ullam a veritatis quia et consequuntur fugiat qui aut.", new DateTime(2020, 9, 21, 13, 53, 20, 575, DateTimeKind.Unspecified).AddTicks(7296), 12L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 321L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 53m, "Tenetur ut ad ad in dolor dolores occaecati voluptates et.", new DateTime(2020, 3, 8, 6, 27, 55, 111, DateTimeKind.Unspecified).AddTicks(3031), 10L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 322L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 42m, "Voluptatem nam quasi dolorem dolores sed asperiores dolor et nihil.", new DateTime(2020, 9, 19, 16, 42, 28, 667, DateTimeKind.Unspecified).AddTicks(3412), 12L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 323L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Amet eveniet nihil enim corrupti illo iure recusandae vero enim.", new DateTime(2020, 1, 3, 4, 13, 0, 308, DateTimeKind.Unspecified).AddTicks(1330), 6L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 324L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 59m, "Reprehenderit illo exercitationem quaerat aliquid iusto vel voluptatum itaque facere.", new DateTime(2020, 7, 15, 1, 46, 12, 794, DateTimeKind.Unspecified).AddTicks(23), 12L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 325L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 47m, "Laboriosam similique ea veniam ipsum ab suscipit aut velit quos.", new DateTime(2020, 11, 20, 17, 4, 9, 529, DateTimeKind.Unspecified).AddTicks(4872), 6L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 326L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Consequatur omnis est deserunt libero perferendis temporibus sunt velit distinctio.", new DateTime(2020, 4, 21, 10, 9, 8, 339, DateTimeKind.Unspecified).AddTicks(2141), 10L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 327L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 43m, "A hic aliquid molestias ipsum est mollitia quis tenetur velit.", new DateTime(2020, 4, 9, 19, 49, 29, 458, DateTimeKind.Unspecified).AddTicks(634), 5L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 328L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 23m, "Vero et eum est dolores est libero dolor et voluptas.", new DateTime(2020, 8, 24, 14, 52, 19, 529, DateTimeKind.Unspecified).AddTicks(3783), 4L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 329L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 46m, "Nesciunt optio sint id dolor fuga illo dolore qui et.", new DateTime(2020, 12, 29, 0, 43, 2, 634, DateTimeKind.Unspecified).AddTicks(1120), 6L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 330L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 31m, "Consequatur corrupti modi amet quis voluptate porro est fugiat beatae.", new DateTime(2020, 6, 29, 16, 0, 12, 630, DateTimeKind.Unspecified).AddTicks(3211), 6L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 331L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 47m, "Rerum accusantium velit ullam dolorum eum consequuntur aliquam nobis assumenda.", new DateTime(2020, 1, 15, 8, 33, 19, 141, DateTimeKind.Unspecified).AddTicks(7492), 9L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 332L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 37m, "Distinctio et velit odio ut ratione quis culpa odit quia.", new DateTime(2020, 4, 29, 8, 9, 28, 428, DateTimeKind.Unspecified).AddTicks(3662), 6L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 333L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 33m, "Et odio dolorem ut officia ad commodi sed est consectetur.", new DateTime(2020, 1, 19, 4, 0, 13, 823, DateTimeKind.Unspecified).AddTicks(9779), 1L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 334L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 33m, "Aut qui atque aliquid vitae odit rerum molestiae aut repellat.", new DateTime(2020, 5, 25, 10, 17, 47, 220, DateTimeKind.Unspecified).AddTicks(4071), 4L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 335L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 18m, "Sint architecto et ipsa dolor in iure dolore animi totam.", new DateTime(2020, 5, 28, 18, 35, 46, 657, DateTimeKind.Unspecified).AddTicks(7499), 6L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 336L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 33m, "Sit consequatur consequatur similique placeat qui est et quidem ratione.", new DateTime(2020, 3, 30, 23, 21, 41, 797, DateTimeKind.Unspecified).AddTicks(9000), 6L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 337L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 57m, "Natus ipsum sint eligendi accusamus inventore velit est reprehenderit doloremque.", new DateTime(2020, 8, 9, 16, 6, 52, 360, DateTimeKind.Unspecified).AddTicks(381), 11L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 338L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 34m, "Pariatur sit sint aperiam eos ea maxime officiis et maxime.", new DateTime(2020, 2, 29, 22, 57, 24, 442, DateTimeKind.Unspecified).AddTicks(5372), 2L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 339L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 16m, "Odio et perspiciatis quo ut qui est et unde id.", new DateTime(2020, 7, 14, 0, 12, 32, 33, DateTimeKind.Unspecified).AddTicks(4992), 3L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 340L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 32m, "Laborum suscipit nobis non expedita numquam et dolorum tempora laudantium.", new DateTime(2020, 5, 6, 15, 2, 48, 35, DateTimeKind.Unspecified).AddTicks(6859), 1L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 341L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 41m, "Ut quia omnis veniam non recusandae non id corrupti quae.", new DateTime(2020, 3, 12, 6, 50, 1, 172, DateTimeKind.Unspecified).AddTicks(1055), 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 342L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 25m, "Totam sit at cum inventore numquam quaerat exercitationem inventore non.", new DateTime(2020, 11, 15, 3, 5, 31, 694, DateTimeKind.Unspecified).AddTicks(419), 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 343L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 49m, "Nihil vitae possimus assumenda aliquam alias saepe autem sit saepe.", new DateTime(2020, 6, 18, 6, 44, 51, 453, DateTimeKind.Unspecified).AddTicks(4876), 8L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 344L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 53m, "Pariatur rerum beatae earum ut eum sequi quae est voluptate.", new DateTime(2020, 4, 27, 4, 19, 18, 142, DateTimeKind.Unspecified).AddTicks(7766), 2L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 345L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 14m, "Sed laboriosam ex non rem qui ipsam ea nostrum vitae.", new DateTime(2020, 6, 5, 0, 30, 3, 150, DateTimeKind.Unspecified).AddTicks(6711), 6L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 346L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Repellat a perferendis est saepe eum ducimus quam dolores maiores.", new DateTime(2020, 7, 11, 19, 54, 27, 525, DateTimeKind.Unspecified).AddTicks(2861), 12L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 347L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 23m, "Voluptatum aliquid et ad culpa est aliquam voluptas ut ducimus.", new DateTime(2020, 8, 31, 3, 42, 19, 868, DateTimeKind.Unspecified).AddTicks(9496), 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 348L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 27m, "Ut repellat atque deleniti vero veritatis quae est reprehenderit quos.", new DateTime(2020, 7, 24, 17, 25, 34, 286, DateTimeKind.Unspecified).AddTicks(8725), 2L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 349L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 42m, "Quia quis et qui minus itaque non earum qui sit.", new DateTime(2020, 10, 19, 4, 53, 33, 806, DateTimeKind.Unspecified).AddTicks(6627), 4L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 350L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 9m, "Quam similique quo ut qui alias quasi eos et corrupti.", new DateTime(2020, 11, 2, 20, 22, 15, 14, DateTimeKind.Unspecified).AddTicks(6933), 3L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 351L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 50m, "Sapiente dolores consectetur sed at iste quidem dolorem sed ut.", new DateTime(2020, 5, 1, 2, 14, 25, 531, DateTimeKind.Unspecified).AddTicks(5526), 3L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 352L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 24m, "Perspiciatis corporis adipisci voluptatibus tempora saepe incidunt qui dolor fugit.", new DateTime(2020, 7, 8, 2, 2, 16, 328, DateTimeKind.Unspecified).AddTicks(8288), 3L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 353L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 4m, "Officiis possimus dolor magni est aut voluptatibus ipsam asperiores placeat.", new DateTime(2020, 8, 19, 16, 2, 56, 822, DateTimeKind.Unspecified).AddTicks(9128), 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 354L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 15m, "Consequatur quia omnis velit corrupti distinctio mollitia adipisci exercitationem ut.", new DateTime(2020, 7, 9, 22, 4, 34, 419, DateTimeKind.Unspecified).AddTicks(1346), 5L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 355L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Ex architecto voluptatem veritatis molestiae similique exercitationem ducimus commodi inventore.", new DateTime(2020, 8, 6, 21, 28, 23, 922, DateTimeKind.Unspecified).AddTicks(8799), 1L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 356L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 13m, "Enim dignissimos sapiente rerum quis reiciendis blanditiis est suscipit sit.", new DateTime(2020, 6, 6, 7, 16, 24, 235, DateTimeKind.Unspecified).AddTicks(1752), 4L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 357L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 41m, "Laudantium earum possimus ipsum molestias voluptas sapiente sint et sapiente.", new DateTime(2020, 6, 22, 13, 11, 2, 629, DateTimeKind.Unspecified).AddTicks(6875), 5L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 358L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 56m, "Consequatur quisquam sit architecto incidunt consequatur rerum pariatur ad molestiae.", new DateTime(2020, 12, 17, 18, 10, 49, 133, DateTimeKind.Unspecified).AddTicks(9869), 1L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 359L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 45m, "Id corporis possimus tenetur explicabo et voluptatibus quam corporis nulla.", new DateTime(2020, 9, 7, 21, 44, 31, 236, DateTimeKind.Unspecified).AddTicks(4830), 11L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 360L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 23m, "Perferendis repellat deserunt quam sit sed quibusdam et fugiat tempora.", new DateTime(2020, 4, 7, 1, 56, 31, 512, DateTimeKind.Unspecified).AddTicks(6744), 9L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 361L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 37m, "Nam voluptas aut rerum nesciunt numquam sit magni quia in.", new DateTime(2020, 10, 17, 0, 51, 56, 819, DateTimeKind.Unspecified).AddTicks(1447), 11L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 362L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 23m, "Esse suscipit ipsum facilis aut dolores quo minima quo est.", new DateTime(2020, 12, 9, 12, 33, 58, 250, DateTimeKind.Unspecified).AddTicks(6432), 8L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 363L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Totam non numquam doloribus eum quis possimus aut maxime sit.", new DateTime(2020, 12, 14, 20, 48, 14, 533, DateTimeKind.Unspecified).AddTicks(7346), 6L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 364L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 53m, "Autem consectetur natus cum animi voluptate sed dolores inventore aspernatur.", new DateTime(2020, 3, 18, 7, 12, 55, 602, DateTimeKind.Unspecified).AddTicks(5510), 12L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 365L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 23m, "Quos blanditiis veniam aut voluptatem veritatis distinctio cum amet et.", new DateTime(2020, 10, 12, 4, 38, 43, 820, DateTimeKind.Unspecified).AddTicks(6628), 7L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 366L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 26m, "Deserunt voluptatem numquam illo veniam tenetur atque facilis dicta molestiae.", new DateTime(2020, 8, 20, 16, 48, 2, 448, DateTimeKind.Unspecified).AddTicks(3110), 7L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 367L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 59m, "Rem sed doloribus provident deserunt consequatur atque nostrum minus quam.", new DateTime(2020, 12, 2, 22, 44, 28, 322, DateTimeKind.Unspecified).AddTicks(231), 10L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 368L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Consequatur optio dolorem aperiam est omnis et et aut rerum.", new DateTime(2020, 3, 22, 9, 45, 53, 899, DateTimeKind.Unspecified).AddTicks(9051), 1L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 369L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 51m, "Consequatur ea laudantium quisquam qui eligendi quia quasi officiis voluptatibus.", new DateTime(2020, 11, 27, 8, 52, 39, 994, DateTimeKind.Unspecified).AddTicks(6365), 12L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 370L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 18m, "Esse autem ut dolores qui consequatur rerum reprehenderit omnis excepturi.", new DateTime(2020, 12, 16, 5, 2, 42, 131, DateTimeKind.Unspecified).AddTicks(9125), 10L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 371L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 34m, "Ut quae occaecati assumenda laudantium rerum et autem a et.", new DateTime(2020, 1, 25, 4, 58, 6, 248, DateTimeKind.Unspecified).AddTicks(6371), 1L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 372L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 57m, "Qui sit veritatis molestias consequatur id quos sunt soluta debitis.", new DateTime(2020, 11, 29, 9, 29, 22, 881, DateTimeKind.Unspecified).AddTicks(595), 2L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 373L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 59m, "Animi hic hic maiores fuga facilis quo eum praesentium quia.", new DateTime(2020, 3, 16, 9, 5, 32, 812, DateTimeKind.Unspecified).AddTicks(6941), 10L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 374L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Quo velit consequuntur velit praesentium nihil sunt in qui voluptatem.", new DateTime(2020, 5, 18, 18, 23, 24, 906, DateTimeKind.Unspecified).AddTicks(7135), 5L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 375L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 8m, "Consequatur facilis tempore non iusto rerum est aut fugit voluptatem.", new DateTime(2020, 1, 27, 7, 56, 27, 113, DateTimeKind.Unspecified).AddTicks(8751), 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 376L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 60m, "Est at nihil quos tempora ducimus magnam deleniti facere saepe.", new DateTime(2020, 2, 5, 20, 35, 12, 575, DateTimeKind.Unspecified).AddTicks(2317), 1L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 377L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Dolores est rerum neque sunt eligendi laudantium illum provident accusamus.", new DateTime(2020, 5, 29, 8, 19, 59, 813, DateTimeKind.Unspecified).AddTicks(327), 11L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 378L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 50m, "Dicta odit exercitationem adipisci est culpa pariatur mollitia iste at.", new DateTime(2020, 4, 9, 2, 0, 51, 576, DateTimeKind.Unspecified).AddTicks(1603), 3L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 379L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 54m, "Saepe dolor vero recusandae ut maxime sint molestiae vel quod.", new DateTime(2020, 11, 23, 13, 13, 36, 499, DateTimeKind.Unspecified).AddTicks(1004), 9L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 380L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 55m, "Quia quo laborum autem dolor nihil qui facilis mollitia debitis.", new DateTime(2020, 7, 11, 20, 28, 40, 41, DateTimeKind.Unspecified).AddTicks(5731), 11L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 381L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 54m, "Magni repellendus molestiae hic et in molestiae placeat perferendis rerum.", new DateTime(2020, 3, 5, 4, 3, 39, 971, DateTimeKind.Unspecified).AddTicks(3611), 11L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 382L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 40m, "Est omnis quas sed illo rerum ad quisquam labore dignissimos.", new DateTime(2020, 4, 24, 13, 50, 31, 773, DateTimeKind.Unspecified).AddTicks(6679), 6L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 383L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 15m, "Sit voluptatibus ipsa quo sunt et exercitationem mollitia illum quod.", new DateTime(2020, 6, 30, 2, 42, 6, 144, DateTimeKind.Unspecified).AddTicks(1514), 8L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 384L,
                columns: new[] { "AmountOfHours", "Comment", "Date" },
                values: new object[] { 34m, "Dolorem libero eveniet expedita fugit id et ipsa quis est.", new DateTime(2020, 12, 26, 4, 58, 34, 885, DateTimeKind.Unspecified).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 385L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 25m, "Unde deleniti quas sit vitae cum similique doloremque ut sit.", new DateTime(2020, 8, 16, 10, 2, 46, 926, DateTimeKind.Unspecified).AddTicks(3963), 12L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 386L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 7m, "Id voluptas mollitia odit sapiente cumque saepe sunt perspiciatis temporibus.", new DateTime(2020, 5, 12, 7, 42, 48, 712, DateTimeKind.Unspecified).AddTicks(3592), 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 387L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Est aliquid earum laboriosam asperiores aut ab suscipit ut ad.", new DateTime(2020, 4, 29, 14, 27, 58, 687, DateTimeKind.Unspecified).AddTicks(4924), 11L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 388L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 48m, "Voluptas porro nihil quam autem autem nemo id explicabo nam.", new DateTime(2020, 1, 2, 20, 38, 39, 952, DateTimeKind.Unspecified).AddTicks(9040), 4L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 389L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 59m, "Itaque quo reiciendis voluptas aliquid molestiae nihil unde labore laborum.", new DateTime(2020, 7, 9, 0, 58, 12, 10, DateTimeKind.Unspecified).AddTicks(5921), 9L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 390L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 24m, "Non quia et distinctio optio aut aut dolorem dicta recusandae.", new DateTime(2020, 1, 30, 14, 8, 42, 663, DateTimeKind.Unspecified).AddTicks(8688), 5L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 391L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 0m, "Quaerat ad architecto architecto consequatur architecto in cupiditate exercitationem sed.", new DateTime(2020, 11, 1, 19, 28, 56, 308, DateTimeKind.Unspecified).AddTicks(1633), 12L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 392L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 13m, "Deleniti sunt quisquam ut impedit ut beatae est nihil est.", new DateTime(2020, 5, 16, 1, 12, 2, 769, DateTimeKind.Unspecified).AddTicks(2729), 3L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 393L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Et ipsa hic illum mollitia quam nostrum delectus sed fuga.", new DateTime(2020, 3, 3, 14, 43, 3, 439, DateTimeKind.Unspecified).AddTicks(8978), 2L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 394L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 0m, "Accusantium nihil impedit sed minus officia ut asperiores numquam deleniti.", new DateTime(2020, 1, 2, 18, 46, 16, 285, DateTimeKind.Unspecified).AddTicks(1136), 10L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 395L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 29m, "At totam pariatur hic ut quis saepe magnam officia magni.", new DateTime(2020, 12, 5, 11, 17, 55, 372, DateTimeKind.Unspecified).AddTicks(2321), 12L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 396L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 31m, "Iste aspernatur temporibus nihil eveniet architecto maxime quisquam eveniet odit.", new DateTime(2020, 12, 5, 19, 49, 18, 281, DateTimeKind.Unspecified).AddTicks(570), 9L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 397L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 38m, "Eum totam asperiores nam quos aut aut quasi omnis neque.", new DateTime(2020, 10, 6, 11, 53, 8, 379, DateTimeKind.Unspecified).AddTicks(1989), 2L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 398L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 47m, "Fugit culpa qui dolor distinctio fugiat odio fugit eligendi quia.", new DateTime(2020, 2, 10, 14, 0, 0, 378, DateTimeKind.Unspecified).AddTicks(3893), 1L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 399L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Similique quod ut voluptatem non voluptatem quam quia eos ipsam.", new DateTime(2020, 9, 28, 22, 10, 25, 612, DateTimeKind.Unspecified).AddTicks(800), 6L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 400L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 29m, "Quia fuga animi sit sapiente ut id voluptatem delectus et.", new DateTime(2020, 5, 27, 12, 7, 14, 555, DateTimeKind.Unspecified).AddTicks(5389), 12L, 19L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 1L, 1L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 1L, 3L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 1L, 6L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 1L, 11L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 1L, 20L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2L, 7L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3L, 5L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3L, 8L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4L, 7L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4L, 8L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4L, 9L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4L, 10L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4L, 11L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4L, 13L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4L, 14L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5L, 8L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5L, 14L });

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
                keyValues: new object[] { 6L, 5L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 6L, 9L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 6L, 14L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 6L, 15L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 6L, 19L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 7L, 4L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 7L, 9L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 7L, 17L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 8L, 20L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 9L, 5L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 9L, 12L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 9L, 16L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 9L, 18L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 10L, 5L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 10L, 12L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 10L, 18L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 11L, 5L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 11L, 10L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 11L, 18L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 12L, 8L });

            migrationBuilder.RenameColumn(
                name: "IsInvoicePaid",
                table: "Invoice",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "AmountOfHours",
                table: "Invoice",
                newName: "Amount");

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 1L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "10266", "Cruickshankborough", "Skiles - Runolfsdottir", "Singapore", "01606-8283", "Medhurst Cliffs" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 2L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "3024", "West Jakayla", "Marks - Welch", "Colombia", "40357", "Wisozk Freeway" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 3L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "6774", "East Everettchester", "Considine - Reinger", "Cameroon", "33660-3584", "Addison Pine" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 4L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "7862", "Taureanchester", "Spencer, Erdman and Mann", "British Indian Ocean Territory (Chagos Archipelago)", "24079-6616", "Curtis Turnpike" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 5L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "395", "West Gene", "Oberbrunner, Schaden and Emard", "Honduras", "68861-2416", "Weimann Estate" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 6L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "213", "West Karleyhaven", "Padberg Inc", "Ecuador", "80489", "Gislason Track" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 7L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "5445", "Pollyhaven", "Schowalter - Runolfsson", "Philippines", "87795", "Leonie Harbors" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 8L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "086", "Lake Destin", "Zboncak - Moen", "Uganda", "51883-5768", "Jerod Streets" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "320", "South Camillachester", "French Guiana", new DateTime(1965, 1, 4, 22, 10, 51, 247, DateTimeKind.Unspecified).AddTicks(6280), "Kraig", "Regional Markets Manager", "Miller", "93513", "Katlynn Track" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "491", "Jaskolskiburgh", "Norway", new DateTime(1968, 1, 5, 16, 44, 20, 78, DateTimeKind.Unspecified).AddTicks(2839), "Rickey", "Customer Intranet Designer", "Macejkovic", "83447-9269", "Gilberto Keys" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "12018", "Lake Amari", "Puerto Rico", new DateTime(1991, 8, 7, 1, 55, 5, 282, DateTimeKind.Unspecified).AddTicks(4842), "Louvenia", "District Response Administrator", "Bogisich", "62598-2070", "Dickens Radial" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "451", "Hanefort", "Gambia", new DateTime(1965, 12, 27, 20, 19, 0, 213, DateTimeKind.Unspecified).AddTicks(8991), "Dovie", "Central Mobility Orchestrator", "Powlowski", "23587-5126", "Cole Motorway" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "7865", "Shakiraview", "Jamaica", new DateTime(1960, 11, 9, 13, 53, 58, 93, DateTimeKind.Unspecified).AddTicks(1685), "Mattie", "Global Usability Architect", "Boyer", "11083", "Santa Springs" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "9804", "New Thadfort", "Algeria", new DateTime(1981, 2, 12, 4, 3, 31, 214, DateTimeKind.Unspecified).AddTicks(9812), "Leonora", "Direct Applications Consultant", "Doyle", "90946", "Weimann Land" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 7L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "2111", "East Norma", "Mexico", new DateTime(1986, 8, 3, 18, 19, 55, 202, DateTimeKind.Unspecified).AddTicks(8016), "Jett", "Human Paradigm Technician", "Koss", "05383", "Streich Oval" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 8L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "066", "West Cesar", "Chile", new DateTime(1968, 10, 24, 23, 35, 6, 745, DateTimeKind.Unspecified).AddTicks(4957), "Janae", "National Integration Designer", "Shields", "42847", "Carlo Stravenue" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 9L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "6972", "South Alexa", "Ethiopia", new DateTime(1952, 12, 2, 19, 48, 31, 932, DateTimeKind.Unspecified).AddTicks(6864), "Jayde", "Direct Interactions Planner", "Hettinger", "47310", "Cummerata Centers" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 10L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "2713", "Ryleeberg", "Cote d'Ivoire", new DateTime(1971, 4, 30, 3, 27, 17, 930, DateTimeKind.Unspecified).AddTicks(5703), "Jordan", "International Factors Strategist", "Wolff", "92914", "Edgardo Turnpike" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 11L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "912", "Shanahanland", "Svalbard & Jan Mayen Islands", new DateTime(1955, 2, 12, 14, 20, 58, 870, DateTimeKind.Unspecified).AddTicks(8597), "Trenton", "Product Response Planner", "Dicki", "64198-0781", "Janice Mall" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 12L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "8045", "West Meaghan", "Eritrea", new DateTime(1982, 1, 15, 12, 36, 0, 264, DateTimeKind.Unspecified).AddTicks(4654), "Mariam", "Dynamic Solutions Manager", "Glover", "00504", "Loren Fields" });

            migrationBuilder.InsertData(
                table: "EmployeeProject",
                columns: new[] { "EmployeeId", "ProjectId" },
                values: new object[,]
                {
                    { 9L, 13L },
                    { 6L, 4L },
                    { 7L, 3L },
                    { 5L, 4L },
                    { 8L, 17L },
                    { 3L, 20L },
                    { 5L, 15L },
                    { 10L, 15L },
                    { 1L, 19L },
                    { 7L, 7L },
                    { 8L, 5L },
                    { 10L, 16L },
                    { 7L, 15L },
                    { 3L, 9L },
                    { 12L, 13L },
                    { 3L, 13L },
                    { 12L, 15L },
                    { 9L, 17L },
                    { 3L, 6L },
                    { 2L, 3L },
                    { 4L, 17L },
                    { 6L, 2L },
                    { 6L, 8L },
                    { 6L, 7L },
                    { 8L, 19L },
                    { 11L, 11L },
                    { 12L, 16L },
                    { 8L, 15L },
                    { 10L, 3L },
                    { 6L, 11L },
                    { 8L, 10L },
                    { 9L, 6L },
                    { 8L, 3L },
                    { 5L, 9L },
                    { 2L, 15L },
                    { 3L, 12L },
                    { 5L, 17L },
                    { 9L, 15L },
                    { 12L, 14L }
                });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 1L, 562.08m, "Managed composite moratorium" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 5L, 984.51m, "Profound reciprocal portal" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 3L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 4L, 798.54m, "Visionary secondary capacity" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 4L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 7L, 989.61m, "Proactive secondary encryption" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 5L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 7L, 957.17m, "Operative system-worthy open architecture" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 6L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 1L, 551.22m, "Phased zero administration synergy" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 7L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 4L, 839.18m, "Intuitive local policy" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 8L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 7L, 616.93m, "Team-oriented bifurcated installation" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 9L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 7L, 796.13m, "Business-focused 4th generation knowledge base" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 10L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 1L, 654.37m, "Automated bifurcated task-force" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 11L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 4L, 743.84m, "Assimilated zero tolerance protocol" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 12L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 4L, 640.42m, "Optimized incremental pricing structure" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 13L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 2L, 974.23m, "Progressive systematic model" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 14L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 5L, 575.92m, "Managed asymmetric infrastructure" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 15L,
                columns: new[] { "PricePerHour", "ProjectName" },
                values: new object[] { 567.07m, "Multi-tiered dynamic approach" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 16L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 7L, 520.67m, "Networked dynamic artificial intelligence" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 17L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 8L, 517.83m, "Multi-lateral 4th generation methodology" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 18L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 8L, 642.04m, "Intuitive radical customer loyalty" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 19L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 2L, 914.17m, "Horizontal fault-tolerant contingency" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 20L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 4L, 724.25m, "Diverse foreground middleware" });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 1L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 23m, "Illo exercitationem voluptatem enim possimus et quas eum ipsam rerum.", new DateTime(2020, 12, 10, 21, 12, 44, 464, DateTimeKind.Unspecified).AddTicks(7283), 10L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 2L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 10m, "Dicta et numquam velit labore voluptatum eaque officiis aliquam est.", new DateTime(2020, 3, 8, 2, 24, 43, 1, DateTimeKind.Unspecified).AddTicks(7100), 4L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 3L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 5m, "Totam est sapiente nihil dolor fugiat molestiae quia dolores aspernatur.", new DateTime(2020, 9, 2, 3, 3, 32, 312, DateTimeKind.Unspecified).AddTicks(2311), 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 4L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 21m, "Ut qui a voluptatum autem totam eos eaque voluptatibus unde.", new DateTime(2020, 8, 12, 12, 52, 5, 385, DateTimeKind.Unspecified).AddTicks(7650), 5L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 5L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 10m, "Eaque impedit aut temporibus eum velit commodi nihil maiores dicta.", new DateTime(2020, 5, 9, 22, 51, 36, 100, DateTimeKind.Unspecified).AddTicks(3508), 11L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 6L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 46m, "Recusandae fugit dolor nesciunt eos nobis rerum fugit et qui.", new DateTime(2020, 3, 31, 23, 21, 49, 386, DateTimeKind.Unspecified).AddTicks(2314), 8L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 7L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 26m, "Et velit corporis voluptatem deleniti maxime quis temporibus consequuntur harum.", new DateTime(2020, 3, 26, 3, 5, 37, 16, DateTimeKind.Unspecified).AddTicks(8857), 3L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 8L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 32m, "Nesciunt accusamus mollitia accusantium eius aspernatur aut et assumenda et.", new DateTime(2020, 12, 28, 21, 58, 34, 750, DateTimeKind.Unspecified).AddTicks(8781), 8L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 9L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Illo voluptatem adipisci et dolor recusandae architecto sunt repellendus error.", new DateTime(2020, 7, 16, 22, 13, 54, 557, DateTimeKind.Unspecified).AddTicks(2755), 11L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 10L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Doloribus voluptatem voluptates distinctio optio aut tenetur dolor tempora error.", new DateTime(2020, 6, 23, 10, 46, 1, 697, DateTimeKind.Unspecified).AddTicks(749), 12L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 11L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 46m, "Facilis inventore porro consequatur quia ea minus aut iusto dolorum.", new DateTime(2020, 4, 29, 3, 52, 49, 986, DateTimeKind.Unspecified).AddTicks(2724), 1L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 12L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 35m, "Dicta doloremque nesciunt porro fuga a officiis dolorum sit itaque.", new DateTime(2020, 6, 15, 14, 51, 53, 476, DateTimeKind.Unspecified).AddTicks(93), 12L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 13L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 16m, "Molestiae et facilis quae est enim non est pariatur inventore.", new DateTime(2020, 12, 21, 16, 12, 21, 180, DateTimeKind.Unspecified).AddTicks(3830), 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 14L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 0m, "Quo quis rerum rerum expedita quis eligendi adipisci voluptate ut.", new DateTime(2020, 6, 1, 2, 24, 18, 465, DateTimeKind.Unspecified).AddTicks(5325), 7L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 15L,
                columns: new[] { "AmountOfHours", "Comment", "Date" },
                values: new object[] { 1m, "Est omnis voluptas omnis reprehenderit praesentium ab aut aut aut.", new DateTime(2020, 11, 22, 13, 24, 39, 665, DateTimeKind.Unspecified).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 16L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 22m, "Sit aspernatur nihil excepturi perspiciatis eos et ipsa ullam voluptas.", new DateTime(2020, 8, 28, 23, 38, 30, 79, DateTimeKind.Unspecified).AddTicks(9793), 10L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 17L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 44m, "Eius vel ut et quam et repellat architecto eius sint.", new DateTime(2020, 7, 31, 20, 16, 28, 680, DateTimeKind.Unspecified).AddTicks(197), 9L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 18L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 55m, "Ipsam libero velit excepturi quo sit perferendis enim nulla repellat.", new DateTime(2020, 12, 19, 5, 45, 16, 68, DateTimeKind.Unspecified).AddTicks(3728), 10L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 19L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 41m, "Deleniti excepturi alias autem debitis quia qui mollitia et sed.", new DateTime(2020, 2, 13, 21, 45, 40, 19, DateTimeKind.Unspecified).AddTicks(7349), 9L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 20L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Debitis et temporibus qui eveniet asperiores qui et magni voluptatem.", new DateTime(2020, 5, 13, 16, 27, 56, 335, DateTimeKind.Unspecified).AddTicks(6410), 11L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 21L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 55m, "Sed perspiciatis esse reprehenderit repellendus ipsam mollitia impedit sint non.", new DateTime(2020, 9, 18, 22, 57, 32, 829, DateTimeKind.Unspecified).AddTicks(9389), 1L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 22L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 43m, "Ut asperiores temporibus sapiente delectus et et itaque quia labore.", new DateTime(2020, 4, 28, 18, 1, 11, 142, DateTimeKind.Unspecified).AddTicks(1911), 2L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 23L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 51m, "Vel id et et est cum inventore necessitatibus temporibus voluptas.", new DateTime(2020, 12, 15, 8, 18, 21, 905, DateTimeKind.Unspecified).AddTicks(4969), 12L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 24L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 10m, "Iure eos molestias quaerat tempore perferendis qui eos rem molestiae.", new DateTime(2020, 7, 7, 14, 51, 54, 218, DateTimeKind.Unspecified).AddTicks(1497), 4L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 25L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 36m, "Suscipit quia voluptatem distinctio commodi maxime voluptas omnis voluptatem ducimus.", new DateTime(2020, 6, 23, 22, 47, 17, 724, DateTimeKind.Unspecified).AddTicks(3633), 1L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 26L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 21m, "Quia praesentium asperiores sint reprehenderit voluptatem omnis ut minus accusamus.", new DateTime(2020, 8, 29, 12, 22, 26, 130, DateTimeKind.Unspecified).AddTicks(6392), 6L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 27L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 14m, "Ut voluptatibus aliquid et velit laudantium omnis laborum et corporis.", new DateTime(2020, 6, 15, 20, 1, 14, 213, DateTimeKind.Unspecified).AddTicks(9273), 9L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 28L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 37m, "Quo veritatis tempora accusantium ex quae non perferendis non ea.", new DateTime(2020, 11, 5, 11, 54, 37, 764, DateTimeKind.Unspecified).AddTicks(4312), 5L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 29L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 60m, "Dignissimos qui non nihil nostrum dicta excepturi ipsa aspernatur incidunt.", new DateTime(2020, 1, 17, 23, 40, 7, 853, DateTimeKind.Unspecified).AddTicks(962), 6L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 30L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 36m, "Qui est ut fuga quam itaque excepturi libero rerum molestiae.", new DateTime(2020, 10, 19, 2, 36, 15, 613, DateTimeKind.Unspecified).AddTicks(1216), 8L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 31L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 15m, "Ab doloribus eum maiores esse natus dolorem libero explicabo quaerat.", new DateTime(2020, 4, 24, 17, 14, 59, 665, DateTimeKind.Unspecified).AddTicks(8927), 6L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 32L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 48m, "Sapiente repellat in nesciunt magnam suscipit et labore consequuntur autem.", new DateTime(2020, 2, 6, 11, 54, 51, 445, DateTimeKind.Unspecified).AddTicks(7893), 10L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 33L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 47m, "Facere dolor voluptas rerum est quaerat asperiores aut nulla laudantium.", new DateTime(2020, 6, 24, 8, 23, 38, 977, DateTimeKind.Unspecified).AddTicks(4445), 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 34L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 44m, "Mollitia aut ratione distinctio voluptas porro impedit facilis pariatur nihil.", new DateTime(2020, 6, 6, 13, 54, 15, 37, DateTimeKind.Unspecified).AddTicks(8362), 2L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 35L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 49m, "Eos deserunt amet enim vitae reprehenderit repudiandae enim quam deserunt.", new DateTime(2020, 8, 22, 3, 59, 22, 320, DateTimeKind.Unspecified).AddTicks(6965), 12L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 36L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 52m, "Voluptatem fugit vel sit et necessitatibus facilis voluptatem facilis eos.", new DateTime(2020, 10, 20, 9, 23, 39, 141, DateTimeKind.Unspecified).AddTicks(1817), 4L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 37L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Recusandae esse est autem dolorum sit dolore magnam minima totam.", new DateTime(2020, 1, 25, 8, 7, 49, 772, DateTimeKind.Unspecified).AddTicks(3734), 2L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 38L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 17m, "Iste iste tempore repellat sint at quos id quae qui.", new DateTime(2020, 10, 25, 7, 11, 56, 858, DateTimeKind.Unspecified).AddTicks(3111), 1L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 39L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 43m, "Hic ab ipsa quia voluptas aut vel consequatur et consectetur.", new DateTime(2020, 3, 1, 23, 43, 29, 765, DateTimeKind.Unspecified).AddTicks(970), 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 40L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 54m, "Quo repudiandae et accusamus architecto ea mollitia dicta laudantium ut.", new DateTime(2020, 8, 9, 22, 53, 54, 51, DateTimeKind.Unspecified).AddTicks(7), 11L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 41L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 11m, "Quis qui quisquam accusamus sit ut corporis tempora molestiae dolorem.", new DateTime(2020, 8, 14, 18, 43, 34, 44, DateTimeKind.Unspecified).AddTicks(3922), 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 42L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 33m, "Est deleniti omnis corporis magnam deserunt ut magni ad sed.", new DateTime(2020, 11, 28, 11, 4, 24, 367, DateTimeKind.Unspecified).AddTicks(2160), 9L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 43L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 52m, "Qui est atque fugit amet sit quidem minima totam aliquid.", new DateTime(2020, 2, 10, 20, 31, 27, 69, DateTimeKind.Unspecified).AddTicks(7559), 8L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 44L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 37m, "Corrupti ipsa sequi et qui ab qui voluptatibus quos sed.", new DateTime(2020, 8, 7, 8, 39, 0, 149, DateTimeKind.Unspecified).AddTicks(4350), 12L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 45L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 14m, "Enim sint adipisci non molestiae odio facilis et laboriosam mollitia.", new DateTime(2020, 4, 17, 16, 21, 1, 55, DateTimeKind.Unspecified).AddTicks(529), 10L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 46L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 25m, "Aut molestiae nihil sit asperiores exercitationem facilis incidunt ab est.", new DateTime(2020, 12, 1, 4, 4, 59, 93, DateTimeKind.Unspecified).AddTicks(8851), 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 47L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 36m, "Veniam hic sequi neque necessitatibus in ut tenetur nesciunt iure.", new DateTime(2020, 6, 20, 20, 53, 38, 548, DateTimeKind.Unspecified).AddTicks(9960), 8L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 48L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 50m, "Nihil natus dolore qui dolores maiores aut veritatis fugiat omnis.", new DateTime(2020, 12, 19, 18, 24, 17, 88, DateTimeKind.Unspecified).AddTicks(3657), 1L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 49L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Totam qui vero commodi ut ipsa consequatur reprehenderit dignissimos distinctio.", new DateTime(2020, 8, 4, 23, 57, 43, 623, DateTimeKind.Unspecified).AddTicks(1094), 10L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 50L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Enim ipsam unde fugiat sit vel non corrupti commodi dolorum.", new DateTime(2020, 6, 11, 10, 34, 49, 435, DateTimeKind.Unspecified).AddTicks(1004), 12L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 51L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 13m, "Fugit autem magni necessitatibus aut rerum atque sunt provident enim.", new DateTime(2020, 8, 18, 21, 28, 6, 382, DateTimeKind.Unspecified).AddTicks(1583), 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 52L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 19m, "Fugit qui eveniet dolorum perspiciatis repudiandae autem sint incidunt adipisci.", new DateTime(2020, 6, 20, 8, 24, 18, 317, DateTimeKind.Unspecified).AddTicks(5651), 9L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 53L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 59m, "Modi ut odio corrupti velit ratione ad quasi non earum.", new DateTime(2020, 7, 22, 6, 10, 51, 448, DateTimeKind.Unspecified).AddTicks(2572), 9L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 54L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 42m, "Repellendus ad facilis voluptate nisi numquam autem omnis est nemo.", new DateTime(2020, 7, 30, 18, 26, 19, 25, DateTimeKind.Unspecified).AddTicks(6243), 12L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 55L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 36m, "Ratione itaque modi accusantium sit quas ut exercitationem fugiat nihil.", new DateTime(2020, 6, 5, 16, 25, 19, 454, DateTimeKind.Unspecified).AddTicks(2549), 7L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 56L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Inventore tenetur repudiandae maiores suscipit explicabo minus tenetur omnis quaerat.", new DateTime(2020, 1, 15, 6, 13, 52, 886, DateTimeKind.Unspecified).AddTicks(5007), 6L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 57L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 27m, "Excepturi magni perspiciatis optio quisquam tempore et deserunt quisquam soluta.", new DateTime(2020, 8, 9, 11, 22, 20, 492, DateTimeKind.Unspecified).AddTicks(6610), 3L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 58L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 29m, "Odio earum ut accusantium quia sit porro assumenda qui tenetur.", new DateTime(2020, 5, 8, 22, 37, 8, 285, DateTimeKind.Unspecified).AddTicks(2224), 5L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 59L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Iure sapiente deserunt asperiores eveniet ut repellendus cumque nesciunt vel.", new DateTime(2020, 11, 14, 10, 14, 8, 813, DateTimeKind.Unspecified).AddTicks(1024), 8L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 60L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 28m, "Ut incidunt voluptas voluptatem quod et sint est ea voluptate.", new DateTime(2020, 2, 14, 21, 22, 5, 344, DateTimeKind.Unspecified).AddTicks(9694), 2L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 61L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 45m, "Id deserunt ipsam iure aut minus quia possimus dicta incidunt.", new DateTime(2020, 9, 23, 22, 13, 37, 717, DateTimeKind.Unspecified).AddTicks(8577), 3L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 62L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 45m, "Dolor sunt nihil consequatur non magnam provident neque consectetur sed.", new DateTime(2020, 9, 14, 9, 22, 13, 70, DateTimeKind.Unspecified).AddTicks(4354), 8L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 63L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 47m, "Id sit eum et quia quae delectus similique dolores non.", new DateTime(2020, 9, 4, 21, 38, 0, 115, DateTimeKind.Unspecified).AddTicks(476), 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 64L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 29m, "Qui sed dicta exercitationem perspiciatis omnis eum enim voluptatibus aliquid.", new DateTime(2020, 4, 5, 10, 38, 22, 668, DateTimeKind.Unspecified).AddTicks(9067), 1L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 65L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 34m, "In adipisci quibusdam sit inventore et voluptatem et in unde.", new DateTime(2020, 3, 17, 11, 36, 45, 967, DateTimeKind.Unspecified).AddTicks(9912), 4L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 66L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 13m, "Deserunt numquam aliquam illum asperiores illo voluptatem expedita aperiam exercitationem.", new DateTime(2020, 10, 11, 12, 27, 31, 949, DateTimeKind.Unspecified).AddTicks(570), 1L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 67L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 20m, "Velit voluptatum error cumque quo reprehenderit dolorem ullam esse autem.", new DateTime(2020, 12, 13, 5, 33, 48, 649, DateTimeKind.Unspecified).AddTicks(9325), 5L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 68L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 14m, "Dolores sed sit rerum alias et cum assumenda aspernatur et.", new DateTime(2020, 4, 30, 15, 50, 5, 510, DateTimeKind.Unspecified).AddTicks(9424), 6L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 69L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 45m, "Neque et aut nesciunt atque illum nihil et maiores in.", new DateTime(2020, 7, 21, 14, 37, 37, 164, DateTimeKind.Unspecified).AddTicks(3791), 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 70L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 17m, "Quibusdam debitis atque neque est repellendus occaecati dolores minima adipisci.", new DateTime(2020, 1, 18, 5, 58, 2, 601, DateTimeKind.Unspecified).AddTicks(491), 11L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 71L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 26m, "Autem voluptatem eius soluta quo quam eos repudiandae enim quia.", new DateTime(2020, 8, 29, 20, 10, 10, 780, DateTimeKind.Unspecified).AddTicks(7214), 5L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 72L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 12m, "Omnis dignissimos et et similique eum ut eius possimus voluptatem.", new DateTime(2020, 7, 14, 20, 55, 24, 478, DateTimeKind.Unspecified).AddTicks(6569), 6L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 73L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 40m, "Modi voluptates quaerat sequi nesciunt ad unde nam ea eos.", new DateTime(2020, 3, 23, 4, 11, 12, 765, DateTimeKind.Unspecified).AddTicks(8074), 7L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 74L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 54m, "Est nemo illum non magnam enim earum fugiat consequuntur veniam.", new DateTime(2020, 2, 27, 1, 27, 33, 298, DateTimeKind.Unspecified).AddTicks(4847), 10L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 75L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 9m, "Natus eveniet magnam quasi velit rem est commodi sint consectetur.", new DateTime(2020, 6, 17, 15, 51, 46, 111, DateTimeKind.Unspecified).AddTicks(7647), 5L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 76L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 54m, "Dicta non quasi earum tempora dicta laborum qui et eius.", new DateTime(2020, 8, 31, 20, 43, 19, 241, DateTimeKind.Unspecified).AddTicks(6729), 7L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 77L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 23m, "Repellendus aut reprehenderit aut vel reprehenderit aut praesentium necessitatibus voluptatum.", new DateTime(2020, 9, 22, 8, 54, 31, 684, DateTimeKind.Unspecified).AddTicks(5155), 6L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 78L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 14m, "Reprehenderit et at doloribus facilis illo placeat adipisci numquam illum.", new DateTime(2020, 3, 12, 10, 57, 7, 5, DateTimeKind.Unspecified).AddTicks(7579), 1L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 79L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "In doloremque omnis veniam placeat corporis culpa rerum quibusdam voluptatum.", new DateTime(2020, 7, 18, 19, 58, 54, 153, DateTimeKind.Unspecified).AddTicks(6127), 6L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 80L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 38m, "Ipsa deserunt sint perspiciatis necessitatibus consequatur veritatis accusamus commodi non.", new DateTime(2020, 10, 15, 19, 22, 11, 825, DateTimeKind.Unspecified).AddTicks(4647), 4L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 81L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 35m, "Omnis sunt fugiat odio nulla doloribus veritatis eos molestiae qui.", new DateTime(2020, 8, 22, 15, 34, 46, 88, DateTimeKind.Unspecified).AddTicks(8921), 12L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 82L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 27m, "Eum vel perspiciatis quis ut quia sequi fuga corporis quas.", new DateTime(2020, 9, 1, 18, 37, 35, 648, DateTimeKind.Unspecified).AddTicks(4684), 6L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 83L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 32m, "Nam voluptatem perferendis beatae nam doloribus sit tempora rerum consequatur.", new DateTime(2020, 1, 19, 13, 7, 57, 443, DateTimeKind.Unspecified).AddTicks(6873), 6L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 84L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 11m, "Nam quis est repellat cumque et ipsa maiores maiores eveniet.", new DateTime(2020, 7, 26, 18, 57, 49, 612, DateTimeKind.Unspecified).AddTicks(6749), 5L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 85L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Ut voluptas a libero earum provident adipisci ut consequuntur vero.", new DateTime(2020, 6, 8, 15, 42, 6, 898, DateTimeKind.Unspecified).AddTicks(8530), 3L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 86L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 36m, "Quod ut earum rem iste ut a recusandae saepe atque.", new DateTime(2020, 4, 5, 19, 8, 2, 277, DateTimeKind.Unspecified).AddTicks(8695), 6L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 87L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 41m, "Eaque sed cum ratione iste quae a ipsam ab omnis.", new DateTime(2020, 6, 27, 6, 3, 24, 597, DateTimeKind.Unspecified).AddTicks(7336), 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 88L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 46m, "Et facere assumenda voluptatem ex iusto dolore dignissimos tenetur recusandae.", new DateTime(2020, 12, 27, 17, 24, 27, 157, DateTimeKind.Unspecified).AddTicks(8058), 12L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 89L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 20m, "Iusto rem consectetur quas quae sint et aut dolor vitae.", new DateTime(2020, 3, 6, 18, 27, 27, 324, DateTimeKind.Unspecified).AddTicks(2682), 2L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 90L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 25m, "Corrupti dolor et cupiditate maiores adipisci est qui porro blanditiis.", new DateTime(2020, 8, 25, 8, 49, 34, 707, DateTimeKind.Unspecified).AddTicks(9327), 1L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 91L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 36m, "Neque quod sit sunt accusamus dolorum debitis in sunt ut.", new DateTime(2020, 6, 7, 21, 33, 53, 619, DateTimeKind.Unspecified).AddTicks(2612), 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 92L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 14m, "Sunt nobis ut qui temporibus qui a omnis ipsam odio.", new DateTime(2020, 11, 26, 5, 37, 12, 508, DateTimeKind.Unspecified).AddTicks(3320), 6L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 93L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 17m, "Possimus minus nihil repellat dicta enim nulla odio eveniet doloremque.", new DateTime(2020, 8, 24, 15, 28, 25, 858, DateTimeKind.Unspecified).AddTicks(6067), 5L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 94L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 55m, "Est ut ut sint exercitationem blanditiis similique doloremque omnis earum.", new DateTime(2020, 7, 19, 11, 9, 11, 489, DateTimeKind.Unspecified).AddTicks(8994), 4L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 95L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 23m, "Molestiae maxime laborum rerum reiciendis qui qui quo molestiae maiores.", new DateTime(2020, 8, 21, 22, 9, 27, 66, DateTimeKind.Unspecified).AddTicks(6723), 5L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 96L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Temporibus officiis quibusdam voluptas ad ipsa ipsum quae eveniet sapiente.", new DateTime(2020, 5, 22, 15, 28, 44, 513, DateTimeKind.Unspecified).AddTicks(8264), 9L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 97L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 44m, "Sit atque quod rem harum blanditiis perferendis voluptatem esse praesentium.", new DateTime(2020, 9, 23, 12, 46, 9, 88, DateTimeKind.Unspecified).AddTicks(796), 1L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 98L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 46m, "Nisi omnis dolores nam et et et soluta qui quos.", new DateTime(2020, 2, 3, 15, 13, 39, 704, DateTimeKind.Unspecified).AddTicks(888), 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 99L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 23m, "Nulla et consectetur temporibus eos explicabo expedita dignissimos et voluptates.", new DateTime(2020, 3, 21, 11, 43, 47, 844, DateTimeKind.Unspecified).AddTicks(9225), 12L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 100L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 38m, "Blanditiis suscipit quisquam ipsam tenetur in nihil ut dolorem accusantium.", new DateTime(2020, 2, 15, 1, 25, 47, 768, DateTimeKind.Unspecified).AddTicks(2585), 2L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 101L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 30m, "Laboriosam dolore dolores eaque labore harum nemo voluptas ut quaerat.", new DateTime(2020, 6, 26, 22, 54, 34, 515, DateTimeKind.Unspecified).AddTicks(6776), 2L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 102L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 54m, "Nemo modi libero dolores nemo est tempora consequatur est accusantium.", new DateTime(2020, 2, 10, 6, 55, 0, 963, DateTimeKind.Unspecified).AddTicks(9215), 8L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 103L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 30m, "Dolorem dolorem libero error est nesciunt aut repellat omnis a.", new DateTime(2020, 9, 4, 1, 0, 57, 288, DateTimeKind.Unspecified).AddTicks(8347), 9L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 104L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 42m, "Et praesentium numquam tenetur nostrum aut eaque animi ea maiores.", new DateTime(2020, 4, 30, 21, 20, 18, 752, DateTimeKind.Unspecified).AddTicks(3067), 12L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 105L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 32m, "Voluptatum odit qui quam sapiente aut itaque aut officia sed.", new DateTime(2020, 4, 10, 12, 47, 13, 777, DateTimeKind.Unspecified).AddTicks(7307), 5L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 106L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 19m, "Ducimus impedit dignissimos qui minima sed quod enim vel est.", new DateTime(2020, 10, 19, 17, 19, 28, 309, DateTimeKind.Unspecified).AddTicks(5373), 7L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 107L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 13m, "Aut nobis culpa minus rerum sunt occaecati libero natus ad.", new DateTime(2020, 6, 18, 10, 1, 12, 554, DateTimeKind.Unspecified).AddTicks(7094), 7L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 108L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 58m, "Officiis soluta error laboriosam consequatur qui sequi est perspiciatis neque.", new DateTime(2020, 10, 2, 17, 2, 34, 304, DateTimeKind.Unspecified).AddTicks(4957), 8L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 109L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 9m, "Exercitationem impedit saepe sunt nisi quo exercitationem et tenetur expedita.", new DateTime(2020, 10, 17, 4, 11, 50, 500, DateTimeKind.Unspecified).AddTicks(1431), 1L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 110L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 47m, "Ratione dolorem exercitationem facere repellendus est odio dolores quia amet.", new DateTime(2020, 10, 16, 19, 20, 32, 496, DateTimeKind.Unspecified).AddTicks(3715), 11L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 111L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 9m, "Qui esse magni ratione dolor ea autem pariatur eum iusto.", new DateTime(2020, 1, 27, 10, 29, 12, 67, DateTimeKind.Unspecified).AddTicks(8294), 3L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 112L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 58m, "Est et enim dolor itaque autem et autem accusamus nulla.", new DateTime(2020, 9, 2, 12, 24, 25, 682, DateTimeKind.Unspecified).AddTicks(7166), 12L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 113L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 9m, "Officia nihil tempora est rerum eos voluptas ut non et.", new DateTime(2020, 9, 22, 6, 14, 52, 39, DateTimeKind.Unspecified).AddTicks(7908), 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 114L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 18m, "Repellendus vero sunt maxime odit rem voluptate numquam repudiandae vitae.", new DateTime(2020, 5, 27, 1, 21, 23, 478, DateTimeKind.Unspecified).AddTicks(6036), 10L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 115L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 46m, "Perspiciatis quis consectetur voluptas quidem numquam voluptatem cum quia sunt.", new DateTime(2020, 8, 28, 3, 1, 31, 742, DateTimeKind.Unspecified).AddTicks(4968), 5L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 116L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 11m, "Vel aliquid laboriosam molestias reiciendis sed officia aut enim quia.", new DateTime(2020, 3, 15, 16, 1, 54, 518, DateTimeKind.Unspecified).AddTicks(2416), 11L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 117L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 22m, "Temporibus ratione vel rerum corrupti repellat asperiores et qui cum.", new DateTime(2020, 10, 3, 7, 19, 22, 907, DateTimeKind.Unspecified).AddTicks(2700), 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 118L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Et alias aliquid in enim modi fugiat error maxime nostrum.", new DateTime(2020, 1, 13, 9, 28, 33, 584, DateTimeKind.Unspecified).AddTicks(2437), 9L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 119L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 32m, "Perferendis maiores vero iure praesentium saepe rerum veritatis omnis qui.", new DateTime(2020, 3, 6, 4, 8, 59, 408, DateTimeKind.Unspecified).AddTicks(3331), 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 120L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Fuga distinctio quo temporibus ipsum deleniti ea enim vero suscipit.", new DateTime(2020, 3, 11, 3, 0, 50, 922, DateTimeKind.Unspecified).AddTicks(1187), 12L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 121L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 13m, "Ea occaecati tempora aperiam illum praesentium tempora quod qui voluptate.", new DateTime(2020, 7, 15, 20, 4, 46, 581, DateTimeKind.Unspecified).AddTicks(5142), 9L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 122L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 36m, "Et eveniet sed veritatis aperiam optio itaque vitae in non.", new DateTime(2020, 3, 22, 5, 15, 52, 580, DateTimeKind.Unspecified).AddTicks(4518), 4L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 123L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 45m, "Consequuntur occaecati voluptate recusandae ex distinctio expedita labore modi consequatur.", new DateTime(2020, 3, 4, 18, 56, 42, 789, DateTimeKind.Unspecified).AddTicks(3399), 5L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 124L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 53m, "Voluptas nemo et doloremque quaerat assumenda doloremque a quibusdam sint.", new DateTime(2020, 11, 30, 1, 27, 33, 19, DateTimeKind.Unspecified).AddTicks(5886), 6L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 125L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 19m, "Rerum ullam possimus quia quis corrupti et ullam alias autem.", new DateTime(2020, 4, 15, 19, 23, 16, 667, DateTimeKind.Unspecified).AddTicks(8408), 10L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 126L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 0m, "Cum non cum corporis repellendus inventore labore enim et magnam.", new DateTime(2020, 12, 9, 1, 20, 41, 655, DateTimeKind.Unspecified).AddTicks(3341), 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 127L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 10m, "Est corrupti iusto sint quis suscipit nostrum molestiae magnam voluptatem.", new DateTime(2020, 9, 18, 15, 28, 44, 522, DateTimeKind.Unspecified).AddTicks(6374), 6L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 128L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 33m, "Corporis enim et optio fugiat voluptatem veniam enim et adipisci.", new DateTime(2020, 4, 7, 21, 54, 59, 733, DateTimeKind.Unspecified).AddTicks(8990), 1L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 129L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 41m, "Iusto quas nobis aut est dignissimos in sint ea enim.", new DateTime(2020, 1, 31, 5, 26, 39, 637, DateTimeKind.Unspecified).AddTicks(2925), 3L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 130L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 45m, "Minima velit eos commodi temporibus optio ut deserunt consequatur quod.", new DateTime(2020, 9, 18, 9, 5, 6, 755, DateTimeKind.Unspecified).AddTicks(9454), 7L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 131L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 27m, "Et labore praesentium qui aliquam dolorum corrupti maxime culpa natus.", new DateTime(2020, 11, 21, 0, 58, 15, 175, DateTimeKind.Unspecified).AddTicks(3305), 8L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 132L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 48m, "Voluptates aut molestias ut enim provident doloribus fugiat suscipit eligendi.", new DateTime(2020, 12, 20, 19, 46, 25, 432, DateTimeKind.Unspecified).AddTicks(6684), 6L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 133L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 51m, "Dolores rerum nemo dicta natus quia enim sed consequatur ab.", new DateTime(2020, 9, 15, 12, 1, 15, 608, DateTimeKind.Unspecified).AddTicks(1395), 5L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 134L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 32m, "Eum ullam quo ut qui dolor soluta aperiam incidunt laboriosam.", new DateTime(2020, 4, 6, 14, 17, 33, 274, DateTimeKind.Unspecified).AddTicks(7106), 5L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 135L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 25m, "Et assumenda cumque accusamus repudiandae est dolore harum aliquam error.", new DateTime(2020, 6, 18, 9, 2, 8, 864, DateTimeKind.Unspecified).AddTicks(4540), 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 136L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 48m, "Dolorem blanditiis rerum eius ut praesentium alias eaque reiciendis totam.", new DateTime(2020, 7, 9, 19, 2, 58, 468, DateTimeKind.Unspecified).AddTicks(9761), 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 137L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 28m, "Porro delectus impedit quia distinctio vero non eaque ut deleniti.", new DateTime(2020, 2, 28, 7, 20, 12, 980, DateTimeKind.Unspecified).AddTicks(6254), 3L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 138L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 12m, "Ipsa voluptatem impedit rerum distinctio necessitatibus accusamus est blanditiis nesciunt.", new DateTime(2020, 4, 14, 9, 13, 28, 687, DateTimeKind.Unspecified).AddTicks(6428), 2L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 139L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 53m, "Autem incidunt non reprehenderit corrupti repellendus sint nostrum vero illo.", new DateTime(2020, 5, 30, 20, 53, 2, 309, DateTimeKind.Unspecified).AddTicks(2811), 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 140L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Aut voluptate ipsa et quia et asperiores dolorem omnis assumenda.", new DateTime(2020, 8, 1, 2, 56, 31, 796, DateTimeKind.Unspecified).AddTicks(8695), 11L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 141L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 57m, "Excepturi unde sed expedita ducimus nisi dolore sed ut repellendus.", new DateTime(2020, 8, 5, 7, 43, 12, 119, DateTimeKind.Unspecified).AddTicks(9570), 2L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 142L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 45m, "Exercitationem et cumque repellat nemo maxime nam quae sed et.", new DateTime(2020, 4, 13, 10, 23, 39, 605, DateTimeKind.Unspecified).AddTicks(2189), 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 143L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 59m, "Rem dignissimos cupiditate eius adipisci reiciendis dolor nemo itaque cupiditate.", new DateTime(2020, 11, 17, 7, 38, 5, 805, DateTimeKind.Unspecified).AddTicks(1830), 3L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 144L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 60m, "Qui aliquam cupiditate cum occaecati et provident aut et accusamus.", new DateTime(2020, 11, 19, 5, 30, 1, 406, DateTimeKind.Unspecified).AddTicks(4255), 12L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 145L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 28m, "Et nobis eum quo totam minima facilis qui voluptatem et.", new DateTime(2020, 4, 11, 4, 38, 54, 518, DateTimeKind.Unspecified).AddTicks(8949), 4L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 146L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 60m, "Porro dolor dolor quasi eos tempore ut eos voluptates voluptatem.", new DateTime(2020, 12, 22, 22, 34, 33, 615, DateTimeKind.Unspecified).AddTicks(7334), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 147L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 22m, "Autem expedita quaerat ut cumque ipsam debitis magnam optio vel.", new DateTime(2020, 6, 9, 14, 29, 29, 920, DateTimeKind.Unspecified).AddTicks(3511), 10L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 148L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 19m, "Asperiores et quis numquam enim perspiciatis reprehenderit necessitatibus sunt necessitatibus.", new DateTime(2020, 5, 6, 23, 45, 26, 40, DateTimeKind.Unspecified).AddTicks(7086), 12L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 149L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 34m, "Omnis cum placeat fugiat voluptas veniam dignissimos id est a.", new DateTime(2020, 7, 25, 10, 41, 33, 709, DateTimeKind.Unspecified).AddTicks(1098), 8L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 150L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 28m, "Deleniti in ullam quaerat voluptas culpa et nostrum dolor officiis.", new DateTime(2020, 2, 10, 8, 27, 10, 563, DateTimeKind.Unspecified).AddTicks(200), 5L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 151L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 29m, "Error consequatur ea aspernatur facere nemo rem sit harum itaque.", new DateTime(2020, 12, 21, 6, 34, 17, 661, DateTimeKind.Unspecified).AddTicks(288), 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 152L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 23m, "Ut esse est laborum et non voluptate est deserunt est.", new DateTime(2020, 11, 17, 11, 17, 40, 37, DateTimeKind.Unspecified).AddTicks(507), 4L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 153L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 29m, "Eveniet officiis totam rerum ipsam a ipsa veniam mollitia molestias.", new DateTime(2020, 9, 16, 2, 27, 50, 521, DateTimeKind.Unspecified).AddTicks(7954), 11L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 154L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 28m, "Assumenda commodi dolores ut nihil voluptatum voluptatem commodi voluptatem facere.", new DateTime(2020, 12, 29, 16, 22, 46, 477, DateTimeKind.Unspecified).AddTicks(7762), 6L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 155L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 53m, "Omnis quidem qui assumenda animi maiores sed possimus totam illum.", new DateTime(2020, 1, 29, 17, 51, 29, 661, DateTimeKind.Unspecified).AddTicks(2973), 9L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 156L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 41m, "Illum aut nihil et itaque rerum et tempora tempora aut.", new DateTime(2020, 5, 7, 22, 15, 21, 844, DateTimeKind.Unspecified).AddTicks(3499), 4L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 157L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 32m, "Laborum porro atque minima aut neque molestias sapiente nobis dolores.", new DateTime(2020, 3, 2, 12, 0, 46, 439, DateTimeKind.Unspecified).AddTicks(7602), 3L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 158L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 0m, "Eveniet soluta occaecati temporibus consequuntur quidem unde neque ab fugiat.", new DateTime(2020, 5, 5, 19, 25, 13, 809, DateTimeKind.Unspecified).AddTicks(2292), 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 159L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 33m, "Voluptate vel dolores quis illum officia ratione placeat sit totam.", new DateTime(2020, 12, 16, 6, 27, 56, 316, DateTimeKind.Unspecified).AddTicks(7281), 1L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 160L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 52m, "Esse similique nihil recusandae id voluptates sit unde corrupti corrupti.", new DateTime(2020, 3, 5, 17, 59, 14, 10, DateTimeKind.Unspecified).AddTicks(9414), 2L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 161L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 27m, "Libero et dolor placeat non a iste officiis rerum fugiat.", new DateTime(2020, 12, 27, 19, 51, 22, 921, DateTimeKind.Unspecified).AddTicks(167), 3L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 162L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Ut illo placeat rerum praesentium est maxime deleniti voluptate ipsum.", new DateTime(2020, 11, 14, 10, 46, 9, 148, DateTimeKind.Unspecified).AddTicks(907), 7L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 163L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 52m, "Quia aut ut quis animi optio vitae cum nostrum nostrum.", new DateTime(2020, 3, 21, 0, 56, 38, 215, DateTimeKind.Unspecified).AddTicks(2046), 12L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 164L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 33m, "Non officia quod nulla ipsa sit sed iusto id nesciunt.", new DateTime(2020, 4, 20, 19, 5, 14, 774, DateTimeKind.Unspecified).AddTicks(6138), 1L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 165L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 11m, "Dolore aut eius neque quod optio omnis harum similique ut.", new DateTime(2020, 9, 15, 9, 51, 40, 492, DateTimeKind.Unspecified).AddTicks(1110), 2L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 166L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 40m, "Voluptas praesentium ut et iure sed omnis illum molestiae nobis.", new DateTime(2020, 1, 23, 21, 14, 30, 591, DateTimeKind.Unspecified).AddTicks(3706), 1L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 167L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 54m, "Enim aut numquam nemo doloribus eveniet et veniam architecto consequatur.", new DateTime(2020, 8, 27, 18, 21, 44, 885, DateTimeKind.Unspecified).AddTicks(874), 6L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 168L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 18m, "Voluptatem voluptas eligendi accusamus quia sed libero minima amet eum.", new DateTime(2020, 12, 29, 13, 52, 59, 758, DateTimeKind.Unspecified).AddTicks(9043), 11L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 169L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 26m, "Culpa provident nesciunt impedit quae nam ea blanditiis est pariatur.", new DateTime(2020, 8, 21, 13, 32, 19, 352, DateTimeKind.Unspecified).AddTicks(4755), 3L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 170L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 29m, "Iure nesciunt assumenda repellendus non aliquam quibusdam qui doloribus dolores.", new DateTime(2020, 3, 27, 15, 59, 47, 579, DateTimeKind.Unspecified).AddTicks(4813), 11L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 171L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 60m, "Et iure in quos quaerat alias cumque ut est assumenda.", new DateTime(2020, 3, 20, 21, 30, 50, 588, DateTimeKind.Unspecified).AddTicks(9523), 7L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 172L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 34m, "Voluptatem nulla est a ullam amet saepe accusantium inventore quia.", new DateTime(2020, 12, 9, 7, 41, 42, 537, DateTimeKind.Unspecified).AddTicks(9444), 4L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 173L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 60m, "Perspiciatis accusantium quibusdam molestiae ducimus consequatur sed ullam ducimus est.", new DateTime(2020, 8, 20, 9, 12, 34, 392, DateTimeKind.Unspecified).AddTicks(9865), 11L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 174L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 51m, "Excepturi alias modi rerum voluptatem incidunt iusto ratione ducimus tenetur.", new DateTime(2020, 10, 14, 21, 2, 16, 330, DateTimeKind.Unspecified).AddTicks(4565), 10L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 175L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 54m, "Voluptas minima sed debitis quis nihil asperiores fuga ut harum.", new DateTime(2020, 2, 7, 2, 4, 23, 622, DateTimeKind.Unspecified).AddTicks(8879), 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 176L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 51m, "Qui repellat ab et ea quae sint inventore eveniet ea.", new DateTime(2020, 1, 12, 14, 55, 14, 453, DateTimeKind.Unspecified).AddTicks(7163), 1L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 177L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 24m, "In voluptas odit esse ut rerum aut ipsum corrupti doloremque.", new DateTime(2020, 7, 25, 3, 51, 8, 784, DateTimeKind.Unspecified).AddTicks(9705), 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 178L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 54m, "Doloremque deserunt consequatur facere velit qui placeat qui et facere.", new DateTime(2020, 11, 8, 3, 17, 2, 51, DateTimeKind.Unspecified).AddTicks(2311), 8L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 179L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 16m, "Vel quibusdam vel delectus qui mollitia ab magni cupiditate laudantium.", new DateTime(2020, 5, 18, 17, 55, 37, 579, DateTimeKind.Unspecified).AddTicks(6067), 4L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 180L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 13m, "Molestias sit sed voluptatem adipisci harum doloremque nemo in enim.", new DateTime(2020, 11, 18, 16, 25, 39, 843, DateTimeKind.Unspecified).AddTicks(7641), 3L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 181L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Recusandae ex repellendus non voluptatem nihil temporibus eligendi numquam eveniet.", new DateTime(2020, 8, 26, 21, 23, 23, 361, DateTimeKind.Unspecified).AddTicks(3236), 12L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 182L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 54m, "Et ut qui aut nihil cupiditate earum rerum unde nemo.", new DateTime(2020, 11, 2, 22, 49, 10, 98, DateTimeKind.Unspecified).AddTicks(6884), 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 183L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "In quas omnis neque rerum et adipisci dolorem soluta dicta.", new DateTime(2020, 3, 28, 7, 2, 13, 392, DateTimeKind.Unspecified).AddTicks(3547), 2L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 184L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 49m, "Aut nemo vel earum autem magni labore vero eos in.", new DateTime(2020, 6, 9, 1, 22, 9, 133, DateTimeKind.Unspecified).AddTicks(3147), 4L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 185L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Consequatur deleniti aliquid sint totam porro nostrum quo dolores omnis.", new DateTime(2020, 3, 8, 5, 39, 1, 445, DateTimeKind.Unspecified).AddTicks(4197), 4L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 186L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 54m, "Eos commodi cum non dicta consequuntur vitae et molestiae sint.", new DateTime(2020, 9, 16, 11, 34, 20, 372, DateTimeKind.Unspecified).AddTicks(7639), 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 187L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 33m, "Facilis ea rerum illum quod ratione ea sed id et.", new DateTime(2020, 11, 2, 23, 36, 30, 490, DateTimeKind.Unspecified).AddTicks(5253), 9L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 188L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Ipsum animi harum aut nihil laboriosam repellat dolores est placeat.", new DateTime(2020, 7, 11, 3, 40, 13, 520, DateTimeKind.Unspecified).AddTicks(4898), 1L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 189L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 34m, "Omnis iusto error ea debitis facere quasi omnis saepe quos.", new DateTime(2020, 12, 20, 4, 9, 11, 931, DateTimeKind.Unspecified).AddTicks(9425), 3L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 190L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 40m, "Et inventore qui commodi id doloribus architecto quia quis quasi.", new DateTime(2020, 7, 16, 11, 53, 14, 617, DateTimeKind.Unspecified).AddTicks(3465), 9L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 191L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Quidem eos est nobis dolor quibusdam et corporis illo aliquid.", new DateTime(2020, 7, 18, 13, 2, 17, 890, DateTimeKind.Unspecified).AddTicks(3891), 11L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 192L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 24m, "Impedit qui impedit eos et laboriosam accusamus nam molestiae cum.", new DateTime(2020, 1, 9, 19, 7, 31, 829, DateTimeKind.Unspecified).AddTicks(4327), 6L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 193L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 13m, "Ratione quos tempore eum quia et eos facere porro corrupti.", new DateTime(2020, 6, 29, 11, 26, 39, 144, DateTimeKind.Unspecified).AddTicks(5271), 5L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 194L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 19m, "Consequatur rem occaecati eum delectus cum et ratione commodi dolorem.", new DateTime(2020, 1, 4, 6, 43, 50, 414, DateTimeKind.Unspecified).AddTicks(3899), 9L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 195L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 59m, "Non explicabo incidunt quia corporis molestiae sequi natus cum praesentium.", new DateTime(2020, 4, 11, 11, 52, 24, 570, DateTimeKind.Unspecified).AddTicks(7461), 7L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 196L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 58m, "Nihil eius deleniti inventore voluptas perspiciatis distinctio blanditiis sequi dolorum.", new DateTime(2020, 4, 3, 19, 53, 59, 660, DateTimeKind.Unspecified).AddTicks(580), 1L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 197L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 0m, "Magni nulla est alias facilis dolorem ut dolorum quaerat quia.", new DateTime(2020, 8, 11, 20, 13, 38, 6, DateTimeKind.Unspecified).AddTicks(8355), 6L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 198L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 27m, "Autem veritatis ut et nihil expedita quisquam qui nisi quidem.", new DateTime(2020, 3, 3, 14, 23, 48, 905, DateTimeKind.Unspecified).AddTicks(9463), 11L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 199L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 46m, "Earum est velit quos illum voluptatem et eum est error.", new DateTime(2020, 4, 24, 4, 4, 39, 167, DateTimeKind.Unspecified).AddTicks(2179), 6L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 200L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 48m, "A nemo dolorum maxime autem numquam distinctio explicabo ex qui.", new DateTime(2020, 6, 1, 10, 54, 40, 673, DateTimeKind.Unspecified).AddTicks(1377), 5L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 201L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 60m, "Et ab quia repudiandae vero repellendus soluta et reiciendis rerum.", new DateTime(2020, 4, 13, 1, 50, 47, 54, DateTimeKind.Unspecified).AddTicks(6753), 10L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 202L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 58m, "Quis cumque voluptate suscipit et et sit eaque perferendis magni.", new DateTime(2020, 1, 5, 17, 53, 15, 85, DateTimeKind.Unspecified).AddTicks(8714), 5L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 203L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 51m, "Magnam illo aut et accusamus dignissimos voluptas quisquam odio perspiciatis.", new DateTime(2020, 2, 4, 11, 35, 0, 428, DateTimeKind.Unspecified).AddTicks(4710), 3L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 204L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 18m, "Voluptas tempore reiciendis ex sed cumque consequatur et id illo.", new DateTime(2020, 2, 13, 17, 37, 43, 8, DateTimeKind.Unspecified).AddTicks(6494), 9L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 205L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 28m, "Eaque asperiores iste omnis eligendi quo in et nulla ut.", new DateTime(2020, 10, 21, 16, 47, 21, 357, DateTimeKind.Unspecified).AddTicks(2444), 2L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 206L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 34m, "Voluptatem et aut laborum et debitis impedit laboriosam sequi alias.", new DateTime(2020, 8, 20, 11, 44, 30, 413, DateTimeKind.Unspecified).AddTicks(8729), 11L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 207L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 36m, "Voluptatem quae sequi excepturi rerum et nobis ducimus maiores totam.", new DateTime(2020, 1, 14, 13, 43, 37, 126, DateTimeKind.Unspecified).AddTicks(9125), 12L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 208L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 24m, "Dolorem architecto quia harum et et reprehenderit accusamus hic aspernatur.", new DateTime(2020, 11, 28, 21, 26, 53, 956, DateTimeKind.Unspecified).AddTicks(1983), 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 209L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 42m, "Quo iste accusamus exercitationem et et id et placeat rerum.", new DateTime(2020, 10, 3, 2, 39, 18, 148, DateTimeKind.Unspecified).AddTicks(8848), 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 210L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 49m, "Aut harum tempore occaecati ut corporis sint beatae quibusdam quaerat.", new DateTime(2020, 11, 19, 1, 13, 20, 911, DateTimeKind.Unspecified).AddTicks(9188), 4L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 211L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 27m, "Explicabo inventore tenetur quo fugit doloribus est molestiae animi rerum.", new DateTime(2020, 3, 17, 2, 25, 58, 339, DateTimeKind.Unspecified).AddTicks(8651), 6L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 212L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Voluptas similique impedit ullam commodi sunt doloribus ipsam nihil eaque.", new DateTime(2020, 10, 22, 6, 11, 1, 100, DateTimeKind.Unspecified).AddTicks(9508), 12L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 213L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 46m, "Omnis est ut consequatur mollitia voluptatem impedit est nobis non.", new DateTime(2020, 3, 7, 16, 28, 45, 804, DateTimeKind.Unspecified).AddTicks(6143), 8L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 214L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 27m, "Aperiam doloremque eaque et et quos placeat tempora omnis doloremque.", new DateTime(2020, 3, 17, 6, 46, 45, 345, DateTimeKind.Unspecified).AddTicks(4066), 6L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 215L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 47m, "Quidem repudiandae possimus nam aut nulla libero doloribus tempore voluptatum.", new DateTime(2020, 6, 18, 14, 34, 50, 440, DateTimeKind.Unspecified).AddTicks(6405), 7L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 216L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 39m, "Aut dolores facilis rem consequatur sed veniam reprehenderit alias sunt.", new DateTime(2020, 4, 26, 4, 10, 41, 172, DateTimeKind.Unspecified).AddTicks(1344), 12L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 217L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 32m, "Inventore earum in sapiente est non illo assumenda blanditiis doloribus.", new DateTime(2020, 1, 5, 14, 37, 45, 516, DateTimeKind.Unspecified).AddTicks(4562), 2L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 218L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Ea natus ex nulla quia aut ut inventore eum sapiente.", new DateTime(2020, 10, 13, 15, 55, 46, 47, DateTimeKind.Unspecified).AddTicks(3372), 4L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 219L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 14m, "Repudiandae nam quo fugit fugiat eos non minus ut unde.", new DateTime(2020, 6, 30, 3, 44, 22, 524, DateTimeKind.Unspecified).AddTicks(9732), 12L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 220L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Eaque expedita eum consequatur possimus labore aperiam odio id aut.", new DateTime(2020, 8, 3, 8, 6, 41, 701, DateTimeKind.Unspecified).AddTicks(7709), 7L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 221L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 0m, "Natus et optio voluptas iusto consequatur vero temporibus ad ut.", new DateTime(2020, 3, 8, 12, 24, 46, 547, DateTimeKind.Unspecified).AddTicks(4194), 7L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 222L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 38m, "Expedita consequatur rerum temporibus cupiditate ut sit est in voluptatem.", new DateTime(2020, 2, 10, 20, 48, 14, 745, DateTimeKind.Unspecified).AddTicks(4414), 3L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 223L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 28m, "Non est mollitia non tenetur non ipsum quis pariatur velit.", new DateTime(2020, 3, 18, 5, 19, 47, 32, DateTimeKind.Unspecified).AddTicks(6906), 12L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 224L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 15m, "Eum esse deleniti fugit magni voluptate dolor molestiae eius qui.", new DateTime(2020, 4, 3, 22, 52, 31, 409, DateTimeKind.Unspecified).AddTicks(8476), 5L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 225L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 50m, "Eaque et mollitia sit animi vel eos nam quis mollitia.", new DateTime(2020, 12, 27, 0, 50, 5, 654, DateTimeKind.Unspecified).AddTicks(9921), 9L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 226L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 22m, "A est quo maxime reiciendis assumenda laboriosam nesciunt repellendus illo.", new DateTime(2020, 6, 15, 19, 20, 25, 729, DateTimeKind.Unspecified).AddTicks(6007), 2L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 227L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 0m, "Reprehenderit accusamus unde consequatur rerum suscipit dolore quam animi voluptas.", new DateTime(2020, 9, 11, 2, 34, 54, 624, DateTimeKind.Unspecified).AddTicks(617), 3L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 228L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 43m, "Ipsa aut molestiae rerum tenetur velit delectus provident necessitatibus quidem.", new DateTime(2020, 5, 22, 20, 24, 21, 362, DateTimeKind.Unspecified).AddTicks(9922), 12L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 229L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 53m, "Est ut inventore autem est vero ad quas quae soluta.", new DateTime(2020, 7, 1, 0, 36, 4, 108, DateTimeKind.Unspecified).AddTicks(7617), 3L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 230L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 32m, "Dicta architecto similique odit vel dolorum sed ut et quia.", new DateTime(2020, 2, 15, 13, 13, 43, 827, DateTimeKind.Unspecified).AddTicks(28), 11L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 231L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 52m, "Reiciendis repudiandae eaque qui voluptas consequatur assumenda veritatis nihil eum.", new DateTime(2020, 1, 14, 0, 15, 8, 391, DateTimeKind.Unspecified).AddTicks(6534), 3L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 232L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 32m, "Quo placeat quo fugiat quis molestiae ducimus illum quasi et.", new DateTime(2020, 6, 13, 4, 56, 27, 23, DateTimeKind.Unspecified).AddTicks(1443), 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 233L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 45m, "Repudiandae rerum earum voluptate qui esse non magni rerum quas.", new DateTime(2020, 10, 6, 20, 43, 21, 429, DateTimeKind.Unspecified).AddTicks(2692), 4L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 234L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Quis sit sint nulla ipsum culpa et debitis laudantium sit.", new DateTime(2020, 10, 10, 13, 29, 42, 144, DateTimeKind.Unspecified).AddTicks(2756), 12L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 235L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 9m, "Nulla ipsum saepe sapiente id sit voluptatem qui odio omnis.", new DateTime(2020, 5, 29, 21, 31, 47, 886, DateTimeKind.Unspecified).AddTicks(2477), 9L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 236L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 42m, "Odit quia natus non expedita molestiae ducimus rerum rerum doloribus.", new DateTime(2020, 1, 5, 3, 11, 51, 34, DateTimeKind.Unspecified).AddTicks(4508), 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 237L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Quam molestiae velit numquam consequatur commodi quis rem est enim.", new DateTime(2020, 9, 7, 20, 20, 22, 359, DateTimeKind.Unspecified).AddTicks(7420), 2L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 238L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 33m, "Quod qui dolores eos similique ea est aliquam praesentium totam.", new DateTime(2020, 11, 16, 3, 18, 33, 307, DateTimeKind.Unspecified).AddTicks(8273), 12L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 239L,
                columns: new[] { "AmountOfHours", "Comment", "Date" },
                values: new object[] { 58m, "Tempora et quaerat quam suscipit sed in sint consequatur dolores.", new DateTime(2020, 9, 19, 18, 38, 23, 586, DateTimeKind.Unspecified).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 240L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 38m, "Mollitia dolore autem ut omnis eveniet ratione aut at similique.", new DateTime(2020, 6, 2, 8, 2, 20, 157, DateTimeKind.Unspecified).AddTicks(9068), 8L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 241L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 10m, "Laudantium rerum quaerat accusantium est voluptas et nihil illo qui.", new DateTime(2020, 4, 5, 1, 4, 5, 490, DateTimeKind.Unspecified).AddTicks(8314), 6L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 242L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 13m, "Est rerum sed et earum eos expedita numquam sunt illo.", new DateTime(2020, 2, 24, 23, 40, 27, 919, DateTimeKind.Unspecified).AddTicks(4528), 6L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 243L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 25m, "Illo eligendi aut perferendis vero ut ab nihil labore repellat.", new DateTime(2020, 10, 24, 16, 49, 22, 874, DateTimeKind.Unspecified).AddTicks(3081), 12L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 244L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 54m, "Consectetur est atque quibusdam maxime et doloremque numquam ducimus eligendi.", new DateTime(2020, 5, 23, 11, 10, 4, 668, DateTimeKind.Unspecified).AddTicks(1264), 5L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 245L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 15m, "Vero quia mollitia eum occaecati qui et commodi et ea.", new DateTime(2020, 7, 5, 3, 38, 13, 704, DateTimeKind.Unspecified).AddTicks(9658), 11L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 246L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 21m, "In sed molestiae at placeat voluptas voluptatem dignissimos similique et.", new DateTime(2020, 3, 4, 7, 53, 56, 845, DateTimeKind.Unspecified).AddTicks(8910), 1L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 247L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 51m, "Et fugit harum id qui et similique doloremque in ipsum.", new DateTime(2020, 5, 23, 0, 34, 53, 944, DateTimeKind.Unspecified).AddTicks(245), 7L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 248L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 50m, "Est beatae ut fugiat placeat soluta vel voluptas assumenda non.", new DateTime(2020, 3, 29, 23, 54, 57, 172, DateTimeKind.Unspecified).AddTicks(6342), 5L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 249L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 25m, "Rerum delectus possimus et et vel quia consequatur est nesciunt.", new DateTime(2020, 3, 25, 1, 11, 17, 986, DateTimeKind.Unspecified).AddTicks(9368), 3L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 250L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 22m, "Quisquam possimus veniam dolor occaecati adipisci porro corrupti qui et.", new DateTime(2020, 10, 15, 0, 46, 37, 811, DateTimeKind.Unspecified).AddTicks(5408), 2L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 251L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 55m, "Nisi odit commodi maiores sunt voluptatem reprehenderit et velit earum.", new DateTime(2020, 1, 10, 18, 6, 18, 703, DateTimeKind.Unspecified).AddTicks(1060), 2L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 252L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 55m, "Nemo maxime facilis autem saepe odio est perferendis et adipisci.", new DateTime(2020, 9, 15, 5, 55, 18, 363, DateTimeKind.Unspecified).AddTicks(745), 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 253L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 9m, "Labore sint quos est repellendus non laudantium nam autem sed.", new DateTime(2020, 9, 12, 6, 32, 44, 237, DateTimeKind.Unspecified).AddTicks(8783), 10L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 254L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 17m, "Nisi nisi quae sunt quos aut sit voluptatibus mollitia omnis.", new DateTime(2020, 12, 25, 23, 0, 38, 879, DateTimeKind.Unspecified).AddTicks(7848), 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 255L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 20m, "Eos ipsum omnis sed blanditiis et consectetur eveniet qui velit.", new DateTime(2020, 4, 21, 3, 39, 9, 237, DateTimeKind.Unspecified).AddTicks(1531), 8L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 256L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 39m, "Hic odio in voluptatem praesentium quia tempore ut ratione magni.", new DateTime(2020, 6, 13, 10, 58, 30, 972, DateTimeKind.Unspecified).AddTicks(3514), 7L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 257L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 15m, "Sint qui voluptates velit et dolores aut dolorum odio voluptatem.", new DateTime(2020, 12, 20, 12, 36, 45, 885, DateTimeKind.Unspecified).AddTicks(9843), 3L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 258L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 27m, "Necessitatibus harum ducimus repellat ex perspiciatis aperiam sequi amet omnis.", new DateTime(2020, 2, 4, 19, 8, 42, 703, DateTimeKind.Unspecified).AddTicks(3191), 2L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 259L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 58m, "Accusantium et repellat error ad itaque voluptatibus quisquam et dignissimos.", new DateTime(2020, 8, 29, 14, 45, 45, 799, DateTimeKind.Unspecified).AddTicks(8702), 8L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 260L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 20m, "Alias enim dicta quisquam tempora tempora aut excepturi nobis ut.", new DateTime(2020, 11, 3, 0, 8, 14, 967, DateTimeKind.Unspecified).AddTicks(3014), 7L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 261L,
                columns: new[] { "AmountOfHours", "Comment", "Date" },
                values: new object[] { 46m, "Ut ea architecto molestiae voluptatum voluptas mollitia consequatur ut est.", new DateTime(2020, 3, 22, 18, 49, 38, 568, DateTimeKind.Unspecified).AddTicks(5467) });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 262L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 10m, "Dolores alias esse ipsa impedit nihil sequi debitis laudantium ea.", new DateTime(2020, 6, 18, 5, 17, 3, 27, DateTimeKind.Unspecified).AddTicks(6256), 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 263L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 31m, "Rerum praesentium aperiam at quo eius sit qui quis distinctio.", new DateTime(2020, 12, 16, 3, 40, 34, 126, DateTimeKind.Unspecified).AddTicks(510), 11L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 264L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 11m, "Quae deleniti aliquam quasi assumenda voluptas vel soluta consequuntur quos.", new DateTime(2020, 9, 26, 11, 37, 31, 516, DateTimeKind.Unspecified).AddTicks(443), 9L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 265L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 40m, "Saepe libero quia quae rerum vitae et consequatur in laborum.", new DateTime(2020, 8, 10, 17, 9, 40, 485, DateTimeKind.Unspecified).AddTicks(6484), 6L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 266L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 60m, "Harum facere quia impedit ut delectus fugiat maiores voluptatem nobis.", new DateTime(2020, 12, 28, 5, 38, 57, 852, DateTimeKind.Unspecified).AddTicks(8019), 8L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 267L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 16m, "Sit ut eos adipisci laborum sint dolore cumque atque temporibus.", new DateTime(2020, 2, 18, 15, 47, 18, 537, DateTimeKind.Unspecified).AddTicks(3961), 2L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 268L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 14m, "Ut facilis fuga non at iure quae quis veniam consequatur.", new DateTime(2020, 4, 29, 11, 52, 11, 556, DateTimeKind.Unspecified).AddTicks(510), 7L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 269L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 55m, "Occaecati corrupti iure est hic animi voluptatum aperiam rem magnam.", new DateTime(2020, 11, 1, 3, 18, 40, 220, DateTimeKind.Unspecified).AddTicks(8455), 8L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 270L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 56m, "Ut quam animi voluptatem rerum mollitia dicta quas veritatis dolores.", new DateTime(2020, 9, 30, 10, 43, 38, 710, DateTimeKind.Unspecified).AddTicks(9), 4L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 271L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 58m, "Quaerat dolores facilis ut nobis suscipit sit repellat ea laboriosam.", new DateTime(2020, 3, 21, 5, 13, 42, 113, DateTimeKind.Unspecified).AddTicks(1249), 9L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 272L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 52m, "Ipsum quis ut eum facilis fugit aut et ea incidunt.", new DateTime(2020, 10, 5, 15, 44, 54, 319, DateTimeKind.Unspecified).AddTicks(5905), 1L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 273L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Molestiae magnam excepturi quia vel sint omnis laboriosam est expedita.", new DateTime(2020, 10, 29, 15, 13, 23, 605, DateTimeKind.Unspecified).AddTicks(8458), 10L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 274L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 16m, "Perferendis voluptatem dolorum repudiandae quo eius sit est ut debitis.", new DateTime(2020, 10, 2, 3, 20, 41, 38, DateTimeKind.Unspecified).AddTicks(1343), 2L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 275L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 24m, "Qui velit ut qui excepturi dolorem similique voluptatem dolorem quos.", new DateTime(2020, 11, 10, 3, 57, 6, 251, DateTimeKind.Unspecified).AddTicks(3078), 5L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 276L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 50m, "Voluptas et animi ut consequatur eum pariatur qui laborum sunt.", new DateTime(2020, 2, 2, 16, 52, 56, 870, DateTimeKind.Unspecified).AddTicks(6933), 5L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 277L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 45m, "Sit harum aut ad distinctio vel laborum adipisci nobis sit.", new DateTime(2020, 9, 8, 21, 3, 33, 227, DateTimeKind.Unspecified).AddTicks(2030), 11L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 278L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 52m, "Iusto consequuntur error mollitia magni et et doloribus ad accusamus.", new DateTime(2020, 9, 15, 1, 40, 3, 361, DateTimeKind.Unspecified).AddTicks(1638), 9L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 279L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 35m, "Et debitis illo et deleniti eum dolores adipisci reprehenderit quasi.", new DateTime(2020, 7, 19, 13, 21, 54, 970, DateTimeKind.Unspecified).AddTicks(1849), 7L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 280L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 34m, "Iste enim laboriosam dolor consequuntur maiores nihil corrupti cupiditate et.", new DateTime(2020, 3, 22, 1, 43, 26, 623, DateTimeKind.Unspecified).AddTicks(6704), 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 281L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Ea ut ut quidem fugiat voluptatem qui consequatur minima doloribus.", new DateTime(2020, 10, 26, 19, 1, 36, 171, DateTimeKind.Unspecified).AddTicks(4542), 2L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 282L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 14m, "Id dolores sit nihil ad aliquid et consequatur non a.", new DateTime(2020, 9, 24, 2, 43, 1, 872, DateTimeKind.Unspecified).AddTicks(3948), 11L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 283L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 19m, "Aliquid magnam et nostrum perferendis aut fugiat sequi provident earum.", new DateTime(2020, 11, 20, 12, 26, 11, 46, DateTimeKind.Unspecified).AddTicks(1765), 11L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 284L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 45m, "Doloribus aliquid cum aliquam quaerat praesentium facere doloremque repellendus ab.", new DateTime(2020, 3, 5, 18, 40, 50, 335, DateTimeKind.Unspecified).AddTicks(6844), 11L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 285L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 21m, "Nihil qui quod ad eos vitae blanditiis doloremque iste vel.", new DateTime(2020, 8, 5, 15, 22, 14, 275, DateTimeKind.Unspecified).AddTicks(9107), 11L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 286L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 35m, "Sapiente architecto unde beatae quia nobis perferendis dolor minima facilis.", new DateTime(2020, 5, 29, 21, 43, 23, 166, DateTimeKind.Unspecified).AddTicks(9668), 4L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 287L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 19m, "Laudantium eum vel unde sint atque ducimus hic sed animi.", new DateTime(2020, 7, 24, 13, 57, 48, 34, DateTimeKind.Unspecified).AddTicks(1061), 1L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 288L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 58m, "Quibusdam eos reprehenderit rerum ab ipsum et quo quas fugiat.", new DateTime(2020, 4, 18, 1, 42, 27, 441, DateTimeKind.Unspecified).AddTicks(3319), 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 289L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 32m, "Corporis explicabo ut porro cupiditate dolores error quia iusto ipsam.", new DateTime(2020, 5, 3, 10, 57, 14, 150, DateTimeKind.Unspecified).AddTicks(6799), 2L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 290L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 0m, "Accusamus hic sit vitae iure illo eum esse magnam nam.", new DateTime(2020, 2, 19, 7, 51, 7, 471, DateTimeKind.Unspecified).AddTicks(7141), 5L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 291L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 45m, "Debitis unde aliquam est ratione sint facilis odit harum nisi.", new DateTime(2020, 4, 3, 6, 27, 40, 566, DateTimeKind.Unspecified).AddTicks(4213), 7L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 292L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 37m, "Molestiae beatae sed consequuntur eaque illo voluptas omnis vel non.", new DateTime(2020, 5, 25, 16, 19, 38, 559, DateTimeKind.Unspecified).AddTicks(8254), 7L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 293L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 54m, "Nulla corporis nisi dolores debitis vel exercitationem rerum inventore dolores.", new DateTime(2020, 2, 23, 4, 42, 35, 866, DateTimeKind.Unspecified).AddTicks(3566), 10L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 294L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Voluptatem cum molestias tempora expedita omnis doloribus ipsum consequuntur et.", new DateTime(2020, 5, 16, 8, 5, 19, 520, DateTimeKind.Unspecified).AddTicks(2412), 5L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 295L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 19m, "Id quae dicta et est possimus voluptatem voluptas alias odio.", new DateTime(2020, 11, 28, 22, 15, 38, 600, DateTimeKind.Unspecified).AddTicks(3242), 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 296L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 33m, "Voluptatem ipsa aliquid qui soluta vitae ut eos cumque nostrum.", new DateTime(2020, 4, 30, 20, 58, 24, 853, DateTimeKind.Unspecified).AddTicks(6593), 8L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 297L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 41m, "Dolor aspernatur dolor cum voluptates ut voluptatem aut voluptate repudiandae.", new DateTime(2020, 11, 26, 1, 17, 54, 790, DateTimeKind.Unspecified).AddTicks(1357), 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 298L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 60m, "Cum quasi rerum architecto et ducimus voluptatem vitae saepe provident.", new DateTime(2020, 7, 2, 3, 59, 13, 387, DateTimeKind.Unspecified).AddTicks(9749), 7L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 299L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 36m, "Ut autem ut iure vero officia ratione ut distinctio id.", new DateTime(2020, 2, 2, 14, 35, 31, 796, DateTimeKind.Unspecified).AddTicks(4009), 9L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 300L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 0m, "Quidem iusto vel et culpa et laudantium harum ut omnis.", new DateTime(2020, 5, 23, 3, 26, 37, 470, DateTimeKind.Unspecified).AddTicks(3593), 12L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 301L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 5m, "Sed dolore nesciunt vitae debitis omnis nam laborum cum ab.", new DateTime(2020, 7, 10, 23, 51, 17, 340, DateTimeKind.Unspecified).AddTicks(9156), 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 302L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 47m, "Velit laboriosam in quasi inventore eos ducimus praesentium sequi blanditiis.", new DateTime(2020, 11, 6, 1, 39, 54, 190, DateTimeKind.Unspecified).AddTicks(1414), 3L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 303L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 43m, "Dignissimos soluta iusto ea et illo optio velit ducimus deserunt.", new DateTime(2020, 2, 20, 1, 31, 9, 563, DateTimeKind.Unspecified).AddTicks(531), 6L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 304L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Possimus voluptas nemo tempore in est modi aut sequi rerum.", new DateTime(2020, 5, 7, 17, 14, 38, 698, DateTimeKind.Unspecified).AddTicks(3943), 5L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 305L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 45m, "Explicabo cumque quo aperiam esse hic ipsum repellat et ex.", new DateTime(2020, 8, 24, 8, 51, 54, 996, DateTimeKind.Unspecified).AddTicks(6910), 11L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 306L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 60m, "Necessitatibus consequatur officia eius temporibus molestiae cumque dolorem ratione sunt.", new DateTime(2020, 1, 29, 9, 34, 45, 746, DateTimeKind.Unspecified).AddTicks(2969), 6L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 307L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 26m, "Non omnis aut soluta voluptate hic voluptatem maxime facere ducimus.", new DateTime(2020, 6, 30, 10, 27, 39, 439, DateTimeKind.Unspecified).AddTicks(8063), 6L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 308L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 46m, "Quo tenetur eum est laborum modi sed nisi exercitationem quia.", new DateTime(2020, 11, 8, 8, 47, 32, 140, DateTimeKind.Unspecified).AddTicks(1001), 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 309L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 16m, "Iste ut officia ut blanditiis minus totam et ut nesciunt.", new DateTime(2020, 1, 16, 15, 58, 43, 993, DateTimeKind.Unspecified).AddTicks(2239), 5L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 310L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Illo qui et reprehenderit culpa earum fugit adipisci quod quo.", new DateTime(2020, 9, 5, 16, 57, 8, 829, DateTimeKind.Unspecified).AddTicks(2141), 11L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 311L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 11m, "Aliquam fugiat dicta adipisci voluptates ab consectetur corrupti vero qui.", new DateTime(2020, 4, 26, 15, 41, 27, 495, DateTimeKind.Unspecified).AddTicks(4457), 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 312L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 39m, "Est libero tempora atque unde aut nostrum sequi autem sed.", new DateTime(2020, 4, 17, 13, 7, 8, 731, DateTimeKind.Unspecified).AddTicks(6200), 8L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 313L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 22m, "Cupiditate facere magni sit esse veniam consequatur sint architecto amet.", new DateTime(2020, 2, 27, 2, 34, 36, 411, DateTimeKind.Unspecified).AddTicks(7284), 3L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 314L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 34m, "Veniam ut dignissimos praesentium est totam officia quasi laborum aliquid.", new DateTime(2020, 12, 16, 10, 38, 15, 210, DateTimeKind.Unspecified).AddTicks(858), 9L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 315L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Blanditiis aut natus consequatur saepe eum delectus odit voluptatem omnis.", new DateTime(2020, 11, 23, 22, 48, 35, 242, DateTimeKind.Unspecified).AddTicks(2289), 9L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 316L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Mollitia eaque ut sint sit est accusamus doloremque omnis quia.", new DateTime(2020, 11, 3, 12, 58, 4, 535, DateTimeKind.Unspecified).AddTicks(140), 6L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 317L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 27m, "Eos omnis praesentium quasi iure impedit inventore consectetur et velit.", new DateTime(2020, 10, 11, 11, 47, 11, 755, DateTimeKind.Unspecified).AddTicks(5446), 9L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 318L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 10m, "Accusantium soluta possimus rerum et dolores voluptatum sunt dicta aut.", new DateTime(2020, 8, 8, 2, 16, 4, 847, DateTimeKind.Unspecified).AddTicks(3286), 4L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 319L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 26m, "Quia eum ex quia illo excepturi delectus ut corporis harum.", new DateTime(2020, 3, 25, 13, 8, 37, 676, DateTimeKind.Unspecified).AddTicks(6616), 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 320L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 24m, "Velit vero amet saepe consequuntur eligendi alias beatae quam vel.", new DateTime(2020, 1, 13, 5, 11, 4, 171, DateTimeKind.Unspecified).AddTicks(4347), 1L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 321L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 34m, "Eligendi expedita maxime modi voluptatum harum et et illo non.", new DateTime(2020, 12, 25, 3, 20, 57, 300, DateTimeKind.Unspecified).AddTicks(3676), 1L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 322L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 29m, "Vel quia sit et praesentium et nesciunt incidunt et iusto.", new DateTime(2020, 3, 18, 7, 21, 50, 263, DateTimeKind.Unspecified).AddTicks(5015), 1L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 323L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Sapiente perspiciatis ratione est provident in pariatur facilis necessitatibus in.", new DateTime(2020, 6, 5, 10, 30, 40, 361, DateTimeKind.Unspecified).AddTicks(8586), 8L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 324L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 10m, "Et expedita illum eaque atque sint optio exercitationem autem error.", new DateTime(2020, 5, 4, 18, 23, 45, 831, DateTimeKind.Unspecified).AddTicks(820), 10L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 325L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 28m, "Eaque enim dolor earum quia voluptatem minima molestias eum corporis.", new DateTime(2020, 5, 29, 9, 57, 8, 459, DateTimeKind.Unspecified).AddTicks(307), 7L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 326L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 44m, "Ut dolorum nulla inventore qui asperiores molestiae sapiente et alias.", new DateTime(2020, 8, 21, 6, 17, 58, 64, DateTimeKind.Unspecified).AddTicks(1289), 1L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 327L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 40m, "Facere culpa tenetur fuga doloribus iure est in eius quo.", new DateTime(2020, 5, 8, 9, 41, 58, 821, DateTimeKind.Unspecified).AddTicks(6387), 3L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 328L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 17m, "Ad sint atque tempore debitis sapiente veritatis quia porro omnis.", new DateTime(2020, 11, 21, 9, 19, 48, 879, DateTimeKind.Unspecified).AddTicks(2239), 3L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 329L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Optio dolor rerum exercitationem tempore laborum possimus et aliquid non.", new DateTime(2020, 1, 13, 9, 59, 24, 624, DateTimeKind.Unspecified).AddTicks(4559), 10L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 330L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 40m, "Ea dolores et voluptate odit dolores nobis aut sint eum.", new DateTime(2020, 2, 16, 14, 59, 44, 858, DateTimeKind.Unspecified).AddTicks(8882), 1L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 331L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 35m, "Et consectetur odio in ex provident aut ipsa dolorem ut.", new DateTime(2020, 8, 10, 17, 56, 57, 156, DateTimeKind.Unspecified).AddTicks(5640), 8L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 332L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 28m, "Dolorem omnis pariatur harum fugiat ea assumenda qui saepe omnis.", new DateTime(2020, 7, 15, 12, 56, 33, 132, DateTimeKind.Unspecified).AddTicks(8141), 4L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 333L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 36m, "Distinctio quas voluptatem veniam consequatur dolor itaque nesciunt quos et.", new DateTime(2020, 5, 24, 4, 54, 27, 947, DateTimeKind.Unspecified).AddTicks(4674), 11L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 334L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 22m, "Nemo delectus omnis fugiat animi non recusandae delectus provident in.", new DateTime(2020, 10, 11, 19, 28, 40, 193, DateTimeKind.Unspecified).AddTicks(9075), 7L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 335L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 17m, "Ullam nam enim blanditiis eos quis vel voluptatem quidem consequatur.", new DateTime(2020, 10, 23, 6, 54, 58, 908, DateTimeKind.Unspecified).AddTicks(1290), 4L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 336L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 0m, "Veritatis est quod labore et velit minima non perferendis voluptatum.", new DateTime(2020, 7, 16, 14, 54, 14, 554, DateTimeKind.Unspecified).AddTicks(3026), 4L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 337L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 42m, "Aut eos qui et quis expedita eos eum ut iusto.", new DateTime(2020, 8, 30, 1, 33, 12, 11, DateTimeKind.Unspecified).AddTicks(3128), 6L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 338L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 60m, "Voluptas reprehenderit error et tempore molestiae ut et distinctio ipsam.", new DateTime(2020, 12, 25, 17, 46, 41, 612, DateTimeKind.Unspecified).AddTicks(4472), 7L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 339L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 22m, "Est quibusdam sequi tenetur et nobis ut omnis rerum totam.", new DateTime(2020, 1, 1, 16, 48, 52, 6, DateTimeKind.Unspecified).AddTicks(4409), 12L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 340L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 14m, "Quidem corporis omnis eos molestiae nostrum animi dolorum voluptates inventore.", new DateTime(2020, 2, 24, 9, 25, 31, 91, DateTimeKind.Unspecified).AddTicks(9726), 7L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 341L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 3m, "Sed velit modi aut et corrupti sit quia veniam quas.", new DateTime(2020, 10, 17, 18, 4, 47, 744, DateTimeKind.Unspecified).AddTicks(2350), 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 342L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 33m, "Facere aspernatur quaerat temporibus omnis tempore veniam ex ut odio.", new DateTime(2020, 8, 23, 6, 2, 57, 923, DateTimeKind.Unspecified).AddTicks(6880), 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 343L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Rerum explicabo dignissimos eveniet saepe nostrum in tempora et aut.", new DateTime(2020, 10, 9, 6, 35, 54, 711, DateTimeKind.Unspecified).AddTicks(6390), 3L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 344L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 28m, "Voluptatem ad minima dolores est ab accusamus consequatur quibusdam quisquam.", new DateTime(2020, 1, 19, 7, 25, 26, 337, DateTimeKind.Unspecified).AddTicks(7269), 12L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 345L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 51m, "Officiis repellendus consequatur earum quisquam sequi quis amet veritatis delectus.", new DateTime(2020, 10, 9, 6, 24, 45, 713, DateTimeKind.Unspecified).AddTicks(6178), 5L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 346L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 32m, "Vero magnam natus sed dolorum qui suscipit voluptatem neque fugiat.", new DateTime(2020, 12, 24, 10, 23, 44, 638, DateTimeKind.Unspecified).AddTicks(623), 1L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 347L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 4m, "Ullam quisquam earum est cupiditate qui ex praesentium alias veniam.", new DateTime(2020, 2, 27, 21, 16, 23, 566, DateTimeKind.Unspecified).AddTicks(1351), 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 348L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 50m, "Numquam enim minus corporis architecto laboriosam tenetur unde nesciunt fugiat.", new DateTime(2020, 3, 4, 15, 22, 17, 98, DateTimeKind.Unspecified).AddTicks(6272), 6L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 349L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 37m, "Dolorum quia aut alias repellat non necessitatibus laboriosam voluptatem et.", new DateTime(2020, 7, 6, 13, 17, 41, 253, DateTimeKind.Unspecified).AddTicks(9589), 10L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 350L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 24m, "Dolore minima sit qui est et ab pariatur aspernatur omnis.", new DateTime(2020, 3, 3, 10, 48, 0, 808, DateTimeKind.Unspecified).AddTicks(6398), 8L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 351L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 45m, "Natus aut ad in eius placeat quo eum ea itaque.", new DateTime(2020, 2, 15, 19, 7, 56, 666, DateTimeKind.Unspecified).AddTicks(2322), 11L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 352L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 53m, "Nostrum odit voluptatum dolorem ipsum omnis ullam aut est assumenda.", new DateTime(2020, 12, 13, 18, 3, 24, 444, DateTimeKind.Unspecified).AddTicks(2643), 4L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 353L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 47m, "Architecto quia ex sit dicta eos omnis repudiandae ex dolore.", new DateTime(2020, 7, 23, 12, 24, 56, 191, DateTimeKind.Unspecified).AddTicks(9054), 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 354L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 25m, "Debitis dolore fugiat nobis omnis quia natus asperiores veniam qui.", new DateTime(2020, 7, 25, 20, 15, 6, 103, DateTimeKind.Unspecified).AddTicks(2396), 8L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 355L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 41m, "Praesentium quas minima quia consectetur veritatis possimus minima qui quo.", new DateTime(2020, 6, 13, 7, 31, 12, 183, DateTimeKind.Unspecified).AddTicks(5277), 11L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 356L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 23m, "Placeat incidunt quibusdam placeat doloribus aut consequatur ea itaque laborum.", new DateTime(2020, 2, 5, 18, 54, 38, 673, DateTimeKind.Unspecified).AddTicks(1754), 6L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 357L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Voluptas provident sed sint eligendi aspernatur blanditiis at ut dolorem.", new DateTime(2020, 3, 19, 18, 48, 35, 715, DateTimeKind.Unspecified).AddTicks(554), 3L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 358L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 36m, "Distinctio quia consequatur maxime beatae sit et ab accusantium eveniet.", new DateTime(2020, 8, 31, 6, 25, 43, 905, DateTimeKind.Unspecified).AddTicks(8993), 7L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 359L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Error nam maxime consequatur pariatur cum odio ab quia ea.", new DateTime(2020, 9, 4, 14, 59, 14, 340, DateTimeKind.Unspecified).AddTicks(2044), 2L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 360L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 54m, "Quaerat aut occaecati corrupti eius voluptate maxime illum et porro.", new DateTime(2020, 12, 4, 12, 58, 4, 587, DateTimeKind.Unspecified).AddTicks(4378), 4L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 361L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 48m, "Quas rerum recusandae consequuntur nihil in quis nemo beatae quam.", new DateTime(2020, 11, 2, 3, 29, 40, 506, DateTimeKind.Unspecified).AddTicks(192), 8L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 362L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 37m, "Rerum qui et beatae quaerat ut autem illo vel explicabo.", new DateTime(2020, 2, 28, 5, 11, 8, 606, DateTimeKind.Unspecified).AddTicks(4941), 5L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 363L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 45m, "Eos accusantium molestias vel voluptas est perspiciatis sed molestiae doloribus.", new DateTime(2020, 4, 23, 21, 11, 36, 103, DateTimeKind.Unspecified).AddTicks(9243), 7L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 364L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 58m, "Saepe aspernatur fugiat ut magnam dolores accusamus aliquid sunt modi.", new DateTime(2020, 8, 11, 14, 44, 5, 267, DateTimeKind.Unspecified).AddTicks(4040), 10L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 365L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 27m, "Voluptatem quo dolor sequi sunt sed dignissimos illo repudiandae quo.", new DateTime(2021, 1, 1, 4, 22, 20, 162, DateTimeKind.Unspecified).AddTicks(6303), 2L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 366L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 25m, "Voluptatem quidem et id id quo nesciunt minima quaerat aut.", new DateTime(2020, 1, 24, 10, 49, 12, 38, DateTimeKind.Unspecified).AddTicks(9112), 1L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 367L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 31m, "Recusandae veniam ipsa ex et explicabo ad officia quia nihil.", new DateTime(2020, 11, 19, 4, 12, 49, 760, DateTimeKind.Unspecified).AddTicks(1314), 6L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 368L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 51m, "Sit repellat sunt quod quasi praesentium voluptas qui est eaque.", new DateTime(2020, 7, 7, 3, 12, 3, 798, DateTimeKind.Unspecified).AddTicks(6946), 9L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 369L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 59m, "Culpa libero eos repudiandae expedita non quia et quibusdam temporibus.", new DateTime(2020, 4, 17, 4, 54, 23, 826, DateTimeKind.Unspecified).AddTicks(7495), 11L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 370L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 26m, "Et architecto nemo libero quia quia explicabo voluptatem voluptatem ad.", new DateTime(2020, 2, 19, 21, 55, 53, 625, DateTimeKind.Unspecified).AddTicks(1376), 2L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 371L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 29m, "Iste alias est quos et nostrum aut ut veniam sint.", new DateTime(2020, 3, 8, 9, 50, 51, 14, DateTimeKind.Unspecified).AddTicks(852), 5L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 372L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 33m, "Velit corporis aut aspernatur quia saepe voluptatem et qui vitae.", new DateTime(2020, 9, 20, 10, 38, 50, 985, DateTimeKind.Unspecified).AddTicks(1885), 11L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 373L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 19m, "Facilis et aut ut maxime rerum architecto autem dolor consequatur.", new DateTime(2020, 11, 21, 1, 50, 16, 541, DateTimeKind.Unspecified).AddTicks(207), 3L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 374L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 54m, "Autem temporibus magnam quod id ut veritatis quisquam reprehenderit aut.", new DateTime(2020, 6, 4, 22, 0, 48, 310, DateTimeKind.Unspecified).AddTicks(6446), 2L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 375L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 55m, "Ad non et eum voluptate est saepe quam impedit dolor.", new DateTime(2020, 6, 17, 5, 32, 57, 75, DateTimeKind.Unspecified).AddTicks(9616), 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 376L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 24m, "Quia excepturi non deleniti totam magni vero earum eum explicabo.", new DateTime(2020, 6, 25, 7, 20, 2, 610, DateTimeKind.Unspecified).AddTicks(4141), 5L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 377L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 56m, "Rem quibusdam eos blanditiis sit dolorem occaecati et porro laboriosam.", new DateTime(2020, 4, 3, 16, 28, 4, 754, DateTimeKind.Unspecified).AddTicks(3843), 6L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 378L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 22m, "Beatae architecto et cupiditate veritatis distinctio mollitia aut beatae et.", new DateTime(2020, 12, 31, 22, 53, 7, 46, DateTimeKind.Unspecified).AddTicks(6288), 10L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 379L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 20m, "Cumque natus laudantium veritatis iusto ut rerum repudiandae ipsa vel.", new DateTime(2020, 1, 18, 8, 42, 1, 661, DateTimeKind.Unspecified).AddTicks(9086), 11L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 380L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 28m, "Quibusdam deserunt ipsa id dolores atque eos facere consectetur voluptas.", new DateTime(2020, 11, 20, 8, 49, 15, 234, DateTimeKind.Unspecified).AddTicks(89), 4L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 381L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 36m, "Quisquam occaecati quidem at quia amet hic nesciunt officiis autem.", new DateTime(2020, 4, 30, 11, 47, 58, 532, DateTimeKind.Unspecified).AddTicks(2372), 4L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 382L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 10m, "Doloremque non et placeat est consequuntur vitae corrupti in vitae.", new DateTime(2020, 6, 5, 20, 43, 41, 993, DateTimeKind.Unspecified).AddTicks(5511), 3L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 383L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 57m, "Consequatur fuga omnis quo rerum ex consectetur cupiditate quod ipsa.", new DateTime(2020, 6, 22, 14, 17, 21, 372, DateTimeKind.Unspecified).AddTicks(4215), 3L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 384L,
                columns: new[] { "AmountOfHours", "Comment", "Date" },
                values: new object[] { 39m, "Quisquam libero iusto odit inventore eligendi est nam non sed.", new DateTime(2020, 7, 10, 7, 29, 24, 584, DateTimeKind.Unspecified).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 385L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 14m, "Rerum iste distinctio iste quo consequatur temporibus dolore mollitia praesentium.", new DateTime(2020, 7, 5, 19, 47, 27, 363, DateTimeKind.Unspecified).AddTicks(4932), 5L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 386L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 31m, "Repellendus qui iste beatae id odio voluptas et est dicta.", new DateTime(2020, 12, 23, 14, 38, 36, 872, DateTimeKind.Unspecified).AddTicks(6451), 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 387L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 43m, "Esse et sit iusto nulla a in amet vel harum.", new DateTime(2020, 3, 22, 8, 9, 27, 10, DateTimeKind.Unspecified).AddTicks(9126), 12L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 388L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 28m, "Architecto reiciendis porro maiores quisquam numquam debitis fuga reiciendis maxime.", new DateTime(2020, 11, 9, 4, 28, 28, 890, DateTimeKind.Unspecified).AddTicks(9865), 8L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 389L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Et in ab recusandae repellendus vitae eum aliquid dignissimos tenetur.", new DateTime(2020, 6, 20, 1, 38, 38, 191, DateTimeKind.Unspecified).AddTicks(5594), 3L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 390L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 36m, "Quia molestiae explicabo sunt officia exercitationem eum tempore consequatur occaecati.", new DateTime(2020, 12, 8, 2, 0, 28, 642, DateTimeKind.Unspecified).AddTicks(2674), 1L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 391L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 48m, "Ut enim quo omnis quos sed minima aut qui ab.", new DateTime(2020, 10, 31, 12, 3, 35, 0, DateTimeKind.Unspecified).AddTicks(4231), 9L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 392L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 44m, "Provident voluptas omnis nihil veniam ad quam illo est excepturi.", new DateTime(2020, 8, 23, 17, 23, 40, 970, DateTimeKind.Unspecified).AddTicks(4884), 6L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 393L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 14m, "Quia non officiis omnis magnam ipsa vitae ipsum sed ducimus.", new DateTime(2020, 3, 18, 11, 9, 49, 979, DateTimeKind.Unspecified).AddTicks(5719), 7L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 394L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 24m, "Nisi quae ea illum et aut eos id omnis ex.", new DateTime(2020, 4, 27, 18, 32, 45, 919, DateTimeKind.Unspecified).AddTicks(1606), 9L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 395L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 13m, "Fuga quia exercitationem voluptatem voluptas ipsa mollitia illo quia tenetur.", new DateTime(2020, 5, 16, 2, 56, 54, 330, DateTimeKind.Unspecified).AddTicks(3623), 7L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 396L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 22m, "Est ipsam sit rerum tenetur sit quo id sequi nam.", new DateTime(2020, 8, 23, 10, 51, 34, 736, DateTimeKind.Unspecified).AddTicks(9504), 7L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 397L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 36m, "Assumenda occaecati ab cumque libero accusamus unde autem voluptatem velit.", new DateTime(2020, 2, 5, 9, 36, 27, 192, DateTimeKind.Unspecified).AddTicks(2967), 1L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 398L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 17m, "Officiis voluptate exercitationem ab laudantium omnis a ducimus ipsum voluptas.", new DateTime(2020, 10, 22, 20, 39, 53, 570, DateTimeKind.Unspecified).AddTicks(5695), 8L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 399L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Ipsum harum et eius rerum asperiores veniam expedita ut qui.", new DateTime(2020, 7, 2, 19, 50, 56, 48, DateTimeKind.Unspecified).AddTicks(6620), 12L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 400L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 52m, "Neque voluptatibus illum cum non nihil minus placeat consequatur rem.", new DateTime(2020, 10, 26, 7, 20, 5, 50, DateTimeKind.Unspecified).AddTicks(8756), 8L, 7L });
        }
    }
}
