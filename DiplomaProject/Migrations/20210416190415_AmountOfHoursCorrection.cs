using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DiplomaProject.Migrations
{
    public partial class AmountOfHoursCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValues: new object[] { 2L, 5L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2L, 7L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2L, 14L });

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
                keyValues: new object[] { 6L, 6L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 6L, 9L });

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
                keyValues: new object[] { 8L, 12L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 8L, 14L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 9L, 5L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 9L, 10L });

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
                keyValues: new object[] { 10L, 11L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 10L, 12L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 10L, 17L });

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
                keyValues: new object[] { 11L, 18L });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 1L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "24629", "East Chadrick", "Senger, Lehner and Veum", "Hungary", "81533-3134", "Susanna Plains" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 2L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "5285", "Cristobalport", "McGlynn - Gleichner", "Somalia", "47612-2110", "Oscar Shore" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 3L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "31608", "Lake Kelly", "Mann - Armstrong", "Timor-Leste", "66737", "Bogisich Villages" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 4L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "11037", "Lake Kylahaven", "Johnston - Graham", "Mozambique", "68276", "Olaf Plains" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 5L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "4608", "New Cydneychester", "Rutherford LLC", "Christmas Island", "50195", "Gerhold Ports" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 6L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "06773", "Ardellaborough", "Osinski, Aufderhar and Sporer", "Guernsey", "56567", "Schultz Creek" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 7L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "6570", "Lake Sonya", "Grady - Franecki", "Reunion", "94559-1943", "Towne Walks" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 8L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "411", "Liaberg", "Tremblay - Johns", "American Samoa", "84010-2091", "Hahn Lakes" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "4380", "Rogersborough", "Lao People's Democratic Republic", new DateTime(1998, 11, 29, 14, 26, 56, 287, DateTimeKind.Unspecified).AddTicks(3884), "Jamal", "Investor Creative Manager", "Carroll", "85121-3763", "Botsford Brook" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "5867", "Torphychester", "Malaysia", new DateTime(1977, 3, 17, 12, 38, 15, 450, DateTimeKind.Unspecified).AddTicks(2541), "Rex", "Customer Optimization Producer", "Strosin", "64014-9210", "Bruen Prairie" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "562", "Christinashire", "Taiwan", new DateTime(1995, 10, 4, 4, 44, 33, 432, DateTimeKind.Unspecified).AddTicks(4862), "Drake", "International Assurance Representative", "Mueller", "08349", "Lubowitz Prairie" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "99889", "New Neva", "Pitcairn Islands", new DateTime(1983, 4, 15, 23, 54, 10, 734, DateTimeKind.Unspecified).AddTicks(2218), "Kenna", "Dynamic Paradigm Developer", "Jacobi", "18002", "Vergie Mill" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "6605", "Lake Robb", "China", new DateTime(1952, 6, 7, 5, 11, 29, 961, DateTimeKind.Unspecified).AddTicks(7595), "Hermina", "Human Web Coordinator", "Torphy", "43778-2688", "Heller Landing" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "34507", "Klockoport", "Isle of Man", new DateTime(1992, 12, 28, 13, 15, 41, 539, DateTimeKind.Unspecified).AddTicks(8626), "Breanne", "Internal Marketing Executive", "Dickens", "95841-6968", "Estell Ranch" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 7L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "644", "Jerdeton", "Cyprus", new DateTime(1987, 9, 23, 22, 40, 16, 143, DateTimeKind.Unspecified).AddTicks(3466), "Cristopher", "International Mobility Specialist", "Daniel", "86939-0997", "Deanna Mount" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 8L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "630", "Legrosmouth", "Lesotho", new DateTime(1983, 4, 16, 1, 49, 54, 358, DateTimeKind.Unspecified).AddTicks(2402), "Ebba", "Central Factors Coordinator", "Jakubowski", "24031-6700", "Greenholt Pass" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 9L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "2912", "Lake Harvey", "Saint Kitts and Nevis", new DateTime(1956, 1, 30, 22, 24, 34, 163, DateTimeKind.Unspecified).AddTicks(7844), "Brianne", "Investor Integration Architect", "Schmidt", "45403", "Kirk Path" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 10L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "7814", "New Hettie", "Kyrgyz Republic", new DateTime(1985, 3, 9, 11, 42, 3, 373, DateTimeKind.Unspecified).AddTicks(7530), "Jovany", "District Implementation Liaison", "Nienow", "10423-8260", "Yost Trafficway" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 11L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "5606", "Tateburgh", "United Kingdom", new DateTime(1980, 11, 25, 10, 0, 12, 904, DateTimeKind.Unspecified).AddTicks(170), "Mitchel", "District Brand Representative", "Lakin", "41547", "Nikki Locks" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 12L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "PostCode", "StreetName" },
                values: new object[] { "02936", "New Fletcherton", "Congo", new DateTime(1972, 2, 16, 21, 41, 44, 550, DateTimeKind.Unspecified).AddTicks(7243), "Emmitt", "Human Accountability Liaison", "Nienow", "31507", "Nicklaus Ford" });

            migrationBuilder.InsertData(
                table: "EmployeeProject",
                columns: new[] { "EmployeeId", "ProjectId" },
                values: new object[,]
                {
                    { 8L, 16L },
                    { 12L, 6L },
                    { 7L, 6L },
                    { 8L, 15L },
                    { 12L, 11L },
                    { 4L, 1L },
                    { 3L, 18L },
                    { 11L, 6L },
                    { 7L, 15L },
                    { 4L, 3L },
                    { 3L, 13L },
                    { 5L, 9L },
                    { 5L, 1L },
                    { 3L, 4L },
                    { 11L, 1L },
                    { 8L, 3L },
                    { 8L, 10L },
                    { 7L, 14L },
                    { 7L, 5L },
                    { 9L, 2L },
                    { 10L, 20L },
                    { 3L, 2L },
                    { 9L, 3L },
                    { 2L, 8L },
                    { 9L, 14L },
                    { 10L, 8L },
                    { 10L, 2L },
                    { 4L, 16L },
                    { 9L, 19L },
                    { 7L, 20L },
                    { 2L, 18L },
                    { 5L, 11L },
                    { 5L, 4L },
                    { 7L, 10L },
                    { 1L, 15L },
                    { 7L, 3L },
                    { 12L, 9L }
                });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 8L, 548.47m, "Business-focused optimal frame" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 7L, 674.75m, "Advanced composite installation" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 3L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 2L, 533.62m, "Enterprise-wide motivating forecast" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 4L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 1L, 806.20m, "Quality-focused systemic Graphic Interface" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 5L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 7L, 567.98m, "Advanced needs-based knowledge base" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 6L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 6L, 927.60m, "Multi-lateral actuating forecast" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 7L,
                columns: new[] { "PricePerHour", "ProjectName" },
                values: new object[] { 699.74m, "Diverse solution-oriented neural-net" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 8L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 3L, 811.28m, "Reverse-engineered stable ability" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 9L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 7L, 792.51m, "Diverse actuating internet solution" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 10L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 2L, 946.52m, "Optimized multi-state conglomeration" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 11L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 8L, 601.53m, "Extended bi-directional ability" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 12L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 4L, 649.31m, "Implemented client-driven contingency" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 13L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 6L, 801.58m, "User-friendly systematic moderator" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 14L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 4L, 592.18m, "Inverse well-modulated time-frame" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 15L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 7L, 656.31m, "Synchronised systemic product" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 16L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 3L, 677.49m, "User-friendly bottom-line utilisation" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 17L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 4L, 809.74m, "Self-enabling stable implementation" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 18L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 5L, 700.71m, "Centralized secondary implementation" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 19L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 3L, 599.13m, "Organized mission-critical orchestration" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 20L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 3L, 970.71m, "Future-proofed full-range system engine" });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 1L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Eum quis natus et nam possimus deserunt eos dolorem nobis.", new DateTime(2020, 10, 13, 11, 45, 27, 65, DateTimeKind.Unspecified).AddTicks(3862), 4L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 2L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Aliquid sed numquam expedita quia tenetur et sit sed minus.", new DateTime(2020, 1, 28, 9, 58, 31, 347, DateTimeKind.Unspecified).AddTicks(5773), 2L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 3L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Quos sit voluptatum alias nesciunt qui temporibus voluptatum est porro.", new DateTime(2020, 12, 9, 23, 6, 54, 859, DateTimeKind.Unspecified).AddTicks(1578), 3L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 4L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Nisi et ea et modi molestiae est quo eaque aut.", new DateTime(2020, 6, 15, 9, 15, 43, 498, DateTimeKind.Unspecified).AddTicks(7000), 8L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 5L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Fugiat dolorem commodi maxime illum laborum quis ratione non ullam.", new DateTime(2020, 3, 14, 6, 10, 41, 721, DateTimeKind.Unspecified).AddTicks(7761), 10L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 6L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Qui et laudantium dolorum quas id cum laborum voluptas cupiditate.", new DateTime(2020, 6, 14, 2, 30, 44, 820, DateTimeKind.Unspecified).AddTicks(7897), 9L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 7L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Voluptatibus et reprehenderit sit adipisci nihil rerum eveniet ex ducimus.", new DateTime(2020, 5, 15, 23, 57, 13, 123, DateTimeKind.Unspecified).AddTicks(3754), 9L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 8L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Impedit odit eos perspiciatis reiciendis id dignissimos ut molestias doloribus.", new DateTime(2020, 9, 10, 21, 0, 44, 173, DateTimeKind.Unspecified).AddTicks(9658), 4L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 9L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Et voluptas quae nemo labore porro dolorem impedit et quam.", new DateTime(2020, 9, 9, 22, 19, 13, 384, DateTimeKind.Unspecified).AddTicks(9166), 6L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 10L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Qui sit aut distinctio quae voluptatum et modi distinctio voluptatem.", new DateTime(2020, 3, 25, 18, 39, 54, 26, DateTimeKind.Unspecified).AddTicks(321), 7L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 11L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Asperiores ea aut minus id quam in sint in molestiae.", new DateTime(2020, 3, 18, 7, 44, 32, 548, DateTimeKind.Unspecified).AddTicks(8912), 8L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 12L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Sed dignissimos veritatis tenetur quas rerum qui corrupti odit distinctio.", new DateTime(2020, 1, 12, 13, 3, 50, 335, DateTimeKind.Unspecified).AddTicks(4318), 5L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 13L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Dolor saepe omnis est molestias est porro et voluptate placeat.", new DateTime(2020, 4, 26, 5, 51, 57, 879, DateTimeKind.Unspecified).AddTicks(5511), 4L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 14L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Dolorum blanditiis inventore quasi ducimus ut sit numquam sunt culpa.", new DateTime(2020, 2, 6, 2, 14, 41, 178, DateTimeKind.Unspecified).AddTicks(8626), 2L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 15L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 5m, "Exercitationem ut voluptatem cupiditate aut quia suscipit molestias et asperiores.", new DateTime(2020, 1, 18, 9, 15, 35, 270, DateTimeKind.Unspecified).AddTicks(9434), 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 16L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Aperiam ipsam nam optio pariatur voluptas accusamus et id nisi.", new DateTime(2020, 4, 14, 23, 6, 40, 505, DateTimeKind.Unspecified).AddTicks(3431), 10L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 17L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Aut adipisci deleniti et cum non quia inventore et voluptas.", new DateTime(2020, 4, 4, 15, 29, 55, 193, DateTimeKind.Unspecified).AddTicks(5074), 9L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 18L,
                columns: new[] { "Comment", "Date", "ProjectId" },
                values: new object[] { "Et veritatis id eos et voluptatem sit omnis repudiandae et.", new DateTime(2020, 4, 17, 11, 35, 16, 452, DateTimeKind.Unspecified).AddTicks(5241), 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 19L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Maxime aut possimus est eos autem cumque blanditiis sint modi.", new DateTime(2020, 8, 20, 22, 20, 18, 509, DateTimeKind.Unspecified).AddTicks(6087), 8L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 20L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Rerum ut doloribus accusamus rem possimus pariatur ut quod et.", new DateTime(2020, 6, 30, 9, 36, 4, 976, DateTimeKind.Unspecified).AddTicks(9676), 10L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 21L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Minima quae eum qui in error ipsam blanditiis consequatur perferendis.", new DateTime(2020, 10, 13, 16, 5, 42, 354, DateTimeKind.Unspecified).AddTicks(5034), 2L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 22L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Unde vel molestias ut dolorem quia saepe perferendis dignissimos perspiciatis.", new DateTime(2020, 5, 30, 13, 51, 37, 482, DateTimeKind.Unspecified).AddTicks(7060), 10L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 23L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Ut magni saepe molestiae deserunt cum quia rem qui ut.", new DateTime(2020, 10, 17, 18, 17, 43, 482, DateTimeKind.Unspecified).AddTicks(4940), 7L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 24L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 4m, "Saepe aut possimus omnis ut quas asperiores ea sed aliquam.", new DateTime(2020, 8, 30, 17, 44, 29, 744, DateTimeKind.Unspecified).AddTicks(8462), 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 25L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Id veniam qui optio assumenda aut modi officiis quia consectetur.", new DateTime(2020, 2, 19, 14, 0, 45, 240, DateTimeKind.Unspecified).AddTicks(4272), 4L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 26L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Maiores enim ipsa saepe perspiciatis laudantium quia totam temporibus aliquam.", new DateTime(2020, 3, 3, 11, 52, 59, 728, DateTimeKind.Unspecified).AddTicks(7529), 7L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 27L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Aut quidem vel sit ut voluptates accusamus fugit est et.", new DateTime(2020, 3, 18, 9, 33, 14, 511, DateTimeKind.Unspecified).AddTicks(7887), 2L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 28L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "At error tempora laborum suscipit sint quis nulla numquam eius.", new DateTime(2020, 3, 15, 19, 23, 44, 950, DateTimeKind.Unspecified).AddTicks(5279), 1L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 29L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Quos sit dolorem atque eveniet ut eos atque vel enim.", new DateTime(2020, 2, 23, 6, 9, 45, 148, DateTimeKind.Unspecified).AddTicks(7174), 3L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 30L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Fuga labore minus asperiores voluptatem aut laborum modi doloremque sint.", new DateTime(2020, 3, 16, 18, 17, 38, 476, DateTimeKind.Unspecified).AddTicks(8080), 12L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 31L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 2m, "Nihil deserunt maiores accusamus voluptas minus dolorum voluptatem harum cum.", new DateTime(2020, 7, 3, 8, 5, 54, 665, DateTimeKind.Unspecified).AddTicks(3332), 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 32L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 3m, "Amet sint esse architecto quo et modi aut atque eaque.", new DateTime(2020, 2, 27, 5, 7, 38, 242, DateTimeKind.Unspecified).AddTicks(7185), 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 33L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Corporis magnam provident est nulla optio veritatis repellendus voluptas voluptas.", new DateTime(2020, 7, 10, 20, 21, 40, 243, DateTimeKind.Unspecified).AddTicks(855), 6L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 34L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Id illo laboriosam ea rerum et eaque aut quas debitis.", new DateTime(2020, 4, 2, 23, 2, 12, 804, DateTimeKind.Unspecified).AddTicks(9644), 7L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 35L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Odit rerum laudantium quisquam non aliquid perferendis eum ratione quae.", new DateTime(2020, 12, 11, 22, 5, 31, 85, DateTimeKind.Unspecified).AddTicks(6951), 1L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 36L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Deserunt sunt in labore dolore sint quis et cumque alias.", new DateTime(2020, 4, 23, 7, 16, 2, 34, DateTimeKind.Unspecified).AddTicks(8128), 2L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 37L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Placeat et accusantium nulla possimus laborum cum vel eos omnis.", new DateTime(2020, 3, 25, 11, 51, 54, 749, DateTimeKind.Unspecified).AddTicks(3830), 4L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 38L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Et exercitationem qui corrupti recusandae quidem occaecati velit ullam laboriosam.", new DateTime(2020, 4, 16, 16, 16, 16, 228, DateTimeKind.Unspecified).AddTicks(5550), 10L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 39L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Et praesentium fuga non sed dolorem quidem dolores sit dolorem.", new DateTime(2020, 1, 29, 4, 25, 11, 483, DateTimeKind.Unspecified).AddTicks(1253), 9L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 40L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Tempora et aut nisi fuga ratione cupiditate ea est est.", new DateTime(2020, 9, 22, 18, 45, 23, 618, DateTimeKind.Unspecified).AddTicks(4107), 5L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 41L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Aliquid nobis sunt qui sed repellat dolores ea voluptatem suscipit.", new DateTime(2020, 9, 3, 4, 36, 4, 914, DateTimeKind.Unspecified).AddTicks(9063), 10L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 42L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 4m, "Ad tempora repellendus labore repudiandae enim sit et consequatur velit.", new DateTime(2020, 8, 2, 18, 1, 42, 982, DateTimeKind.Unspecified).AddTicks(8553), 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 43L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "At perferendis qui non sequi ullam qui sit beatae aut.", new DateTime(2020, 2, 26, 7, 31, 21, 951, DateTimeKind.Unspecified).AddTicks(4490), 2L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 44L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Est rerum natus nesciunt error aut consequuntur vel dolorem odit.", new DateTime(2020, 1, 27, 22, 33, 34, 480, DateTimeKind.Unspecified).AddTicks(7896), 9L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 45L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 7m, "Voluptatem soluta sit est nulla exercitationem unde eos placeat aliquam.", new DateTime(2020, 2, 25, 13, 57, 16, 610, DateTimeKind.Unspecified).AddTicks(8204), 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 46L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 8m, "Voluptatem vel vitae consectetur labore ea pariatur est pariatur labore.", new DateTime(2020, 4, 8, 6, 56, 58, 503, DateTimeKind.Unspecified).AddTicks(9398), 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 47L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 4m, "Amet deleniti pariatur autem voluptatem nostrum perferendis in rerum unde.", new DateTime(2020, 9, 18, 5, 26, 26, 728, DateTimeKind.Unspecified).AddTicks(4508), 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 48L,
                columns: new[] { "AmountOfHours", "Comment", "Date" },
                values: new object[] { 5m, "Saepe nemo nulla minima nulla sit incidunt aut voluptatem quos.", new DateTime(2020, 4, 11, 13, 15, 45, 858, DateTimeKind.Unspecified).AddTicks(850) });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 49L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Eum sunt et aut qui beatae hic ut voluptate occaecati.", new DateTime(2020, 1, 2, 15, 21, 42, 368, DateTimeKind.Unspecified).AddTicks(5400), 2L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 50L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 7m, "Ipsum sed enim praesentium vitae laboriosam fugiat perspiciatis qui dicta.", new DateTime(2020, 12, 7, 21, 54, 24, 986, DateTimeKind.Unspecified).AddTicks(3908), 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 51L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 2m, "Praesentium ea libero ex quis quam similique omnis corporis architecto.", new DateTime(2020, 3, 29, 11, 33, 50, 51, DateTimeKind.Unspecified).AddTicks(8662), 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 52L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Eveniet quia ratione et magnam deleniti voluptas corrupti dolor distinctio.", new DateTime(2020, 7, 24, 3, 32, 37, 854, DateTimeKind.Unspecified).AddTicks(8863), 9L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 53L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Optio nesciunt est inventore quo est consequatur ab pariatur omnis.", new DateTime(2020, 10, 5, 22, 20, 3, 719, DateTimeKind.Unspecified).AddTicks(9082), 9L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 54L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Incidunt labore ut aut dolor non facilis quasi earum sit.", new DateTime(2020, 3, 8, 10, 56, 38, 822, DateTimeKind.Unspecified).AddTicks(9697), 4L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 55L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Dolor consequatur facilis dolorum distinctio minima vero ratione totam dolores.", new DateTime(2020, 5, 3, 15, 8, 50, 75, DateTimeKind.Unspecified).AddTicks(9674), 5L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 56L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Rem consequatur dolor quod exercitationem modi aliquam earum qui eum.", new DateTime(2020, 10, 25, 15, 41, 50, 391, DateTimeKind.Unspecified).AddTicks(1976), 11L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 57L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Eius ad dolor architecto iusto quo officiis nulla dolores quasi.", new DateTime(2020, 8, 24, 5, 11, 52, 916, DateTimeKind.Unspecified).AddTicks(9760), 11L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 58L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Est magni sint asperiores qui quibusdam mollitia sunt sequi sed.", new DateTime(2020, 10, 6, 17, 52, 33, 347, DateTimeKind.Unspecified).AddTicks(6146), 6L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 59L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 2m, "Laborum vel minus aut quidem incidunt non consectetur ex nostrum.", new DateTime(2020, 9, 20, 11, 34, 52, 424, DateTimeKind.Unspecified).AddTicks(1290), 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 60L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Ut odit rerum reprehenderit praesentium dolorem ipsum voluptatem ipsam saepe.", new DateTime(2020, 12, 24, 4, 13, 19, 73, DateTimeKind.Unspecified).AddTicks(2294), 2L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 61L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Quia et laborum quia sed quidem incidunt voluptatem suscipit maxime.", new DateTime(2020, 1, 11, 20, 5, 27, 197, DateTimeKind.Unspecified).AddTicks(1056), 4L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 62L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Omnis tempora est quam qui delectus laboriosam quae est architecto.", new DateTime(2020, 2, 27, 20, 49, 14, 348, DateTimeKind.Unspecified).AddTicks(9403), 8L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 63L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Et voluptas tenetur temporibus sed quis et aut cum accusantium.", new DateTime(2020, 1, 25, 19, 26, 24, 580, DateTimeKind.Unspecified).AddTicks(2797), 11L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 64L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Est qui quia non aut officia atque dicta dolore id.", new DateTime(2020, 5, 26, 10, 48, 53, 866, DateTimeKind.Unspecified).AddTicks(6501), 1L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 65L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Deserunt ut nam similique similique aut illum dolores temporibus deleniti.", new DateTime(2020, 4, 21, 7, 6, 54, 544, DateTimeKind.Unspecified).AddTicks(9236), 4L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 66L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 6m, "Unde dolorum error deleniti similique nihil ad quas hic qui.", new DateTime(2020, 7, 7, 18, 27, 45, 386, DateTimeKind.Unspecified).AddTicks(6928), 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 67L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Mollitia eius omnis eos voluptatibus doloribus occaecati eos ea quis.", new DateTime(2020, 11, 13, 16, 21, 56, 919, DateTimeKind.Unspecified).AddTicks(1635), 10L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 68L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Ex rerum mollitia eos architecto qui sed fuga ipsum perspiciatis.", new DateTime(2020, 2, 5, 7, 28, 29, 794, DateTimeKind.Unspecified).AddTicks(7484), 6L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 69L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Officia itaque doloremque dicta perferendis ea ut sunt quisquam consectetur.", new DateTime(2020, 10, 21, 23, 16, 18, 665, DateTimeKind.Unspecified).AddTicks(4341), 11L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 70L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 4m, "Voluptatem minima nihil quae voluptas repellat voluptatem enim magni ea.", new DateTime(2020, 2, 23, 13, 12, 57, 453, DateTimeKind.Unspecified).AddTicks(8083), 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 71L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Ab eius rerum aut amet et omnis nihil aliquam nobis.", new DateTime(2020, 11, 17, 14, 13, 12, 400, DateTimeKind.Unspecified).AddTicks(442), 7L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 72L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Et voluptate dolore unde cum magni commodi saepe voluptas ducimus.", new DateTime(2020, 5, 17, 11, 12, 46, 549, DateTimeKind.Unspecified).AddTicks(9681), 7L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 73L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Aut et soluta ut non non cupiditate quas unde repellendus.", new DateTime(2020, 12, 9, 17, 10, 0, 780, DateTimeKind.Unspecified).AddTicks(62), 5L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 74L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Voluptatem sit perspiciatis quidem fuga consequatur reprehenderit est sequi vero.", new DateTime(2020, 11, 10, 3, 29, 54, 878, DateTimeKind.Unspecified).AddTicks(3412), 5L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 75L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Autem adipisci iste vel quos ad et et consequatur sed.", new DateTime(2020, 8, 10, 21, 8, 36, 191, DateTimeKind.Unspecified).AddTicks(2811), 2L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 76L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Vero laudantium non a ad cupiditate accusamus qui et repudiandae.", new DateTime(2020, 4, 5, 16, 38, 3, 894, DateTimeKind.Unspecified).AddTicks(2047), 3L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 77L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Voluptatum dolorem animi dolor quia consequatur consequuntur ex incidunt a.", new DateTime(2020, 11, 20, 21, 47, 14, 294, DateTimeKind.Unspecified).AddTicks(8221), 3L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 78L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Perferendis aut rem dolor odit aut et eligendi est velit.", new DateTime(2020, 3, 21, 9, 21, 11, 852, DateTimeKind.Unspecified).AddTicks(2199), 6L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 79L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Quis facilis velit molestiae reprehenderit sed sequi sit recusandae eum.", new DateTime(2020, 4, 15, 20, 37, 52, 35, DateTimeKind.Unspecified).AddTicks(4411), 2L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 80L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Incidunt magnam id eligendi nemo rem consequatur saepe odio alias.", new DateTime(2020, 4, 17, 15, 50, 27, 836, DateTimeKind.Unspecified).AddTicks(8724), 6L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 81L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Dolor consectetur nemo et beatae similique et officia omnis exercitationem.", new DateTime(2020, 3, 19, 23, 42, 52, 800, DateTimeKind.Unspecified).AddTicks(6626), 3L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 82L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Architecto sunt inventore numquam soluta consequatur praesentium qui tempore dolor.", new DateTime(2020, 3, 30, 12, 5, 41, 836, DateTimeKind.Unspecified).AddTicks(4281), 10L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 83L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Sed adipisci laudantium deleniti voluptatem quis alias maxime architecto debitis.", new DateTime(2020, 10, 1, 13, 15, 48, 683, DateTimeKind.Unspecified).AddTicks(1753), 10L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 84L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Quos odio quas fuga tempora aut qui ut earum dolore.", new DateTime(2020, 6, 7, 16, 36, 5, 386, DateTimeKind.Unspecified).AddTicks(1369), 3L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 85L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Sint non totam quaerat qui cum eum error fugiat impedit.", new DateTime(2020, 4, 27, 15, 32, 35, 284, DateTimeKind.Unspecified).AddTicks(4114), 5L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 86L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Sit dolor qui tenetur recusandae illum et incidunt ad voluptatem.", new DateTime(2020, 10, 31, 10, 58, 55, 349, DateTimeKind.Unspecified).AddTicks(3666), 8L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 87L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Magnam eius et rem ab modi incidunt unde velit iste.", new DateTime(2020, 7, 28, 21, 21, 29, 198, DateTimeKind.Unspecified).AddTicks(3137), 11L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 88L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 8m, "Est autem voluptatem ex ratione quos sit omnis at minima.", new DateTime(2020, 4, 4, 19, 15, 57, 434, DateTimeKind.Unspecified).AddTicks(7774), 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 89L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Aliquam voluptatem tempore quae aut non enim laborum totam necessitatibus.", new DateTime(2020, 11, 18, 4, 28, 51, 811, DateTimeKind.Unspecified).AddTicks(4013), 10L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 90L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Assumenda quo illo quia natus reiciendis fuga deleniti necessitatibus ut.", new DateTime(2020, 2, 6, 7, 50, 27, 206, DateTimeKind.Unspecified).AddTicks(4326), 8L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 91L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Consequatur delectus iste unde nisi rerum exercitationem explicabo rerum at.", new DateTime(2020, 7, 12, 12, 10, 55, 881, DateTimeKind.Unspecified).AddTicks(9185), 8L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 92L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Voluptas quis provident sed reprehenderit eos asperiores perferendis tempora id.", new DateTime(2020, 8, 13, 9, 58, 18, 418, DateTimeKind.Unspecified).AddTicks(1765), 12L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 93L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Molestiae iusto quam voluptatem repellat qui dolore et sit ad.", new DateTime(2020, 8, 30, 2, 53, 27, 961, DateTimeKind.Unspecified).AddTicks(3347), 4L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 94L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Tenetur velit occaecati eum commodi et voluptatem sint nihil sunt.", new DateTime(2020, 3, 5, 15, 34, 23, 666, DateTimeKind.Unspecified).AddTicks(4026), 9L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 95L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Id qui est dignissimos quis occaecati nam ducimus iusto harum.", new DateTime(2020, 7, 1, 11, 55, 11, 651, DateTimeKind.Unspecified).AddTicks(9159), 9L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 96L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Eaque quaerat enim et nobis ipsam inventore accusantium numquam aut.", new DateTime(2020, 10, 1, 3, 53, 28, 343, DateTimeKind.Unspecified).AddTicks(5377), 7L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 97L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Minus voluptas laboriosam sit voluptas saepe voluptas excepturi nam qui.", new DateTime(2020, 8, 16, 7, 23, 43, 250, DateTimeKind.Unspecified).AddTicks(5773), 11L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 98L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Voluptas necessitatibus aspernatur sunt aut quia deleniti ducimus qui dignissimos.", new DateTime(2020, 1, 5, 20, 43, 57, 630, DateTimeKind.Unspecified).AddTicks(4408), 12L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 99L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 6m, "Id dolores et aliquam eveniet facere porro odit exercitationem in.", new DateTime(2020, 4, 17, 20, 12, 17, 906, DateTimeKind.Unspecified).AddTicks(1233), 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 100L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Deserunt qui autem doloremque corporis iste voluptatem voluptas perferendis delectus.", new DateTime(2020, 1, 24, 5, 51, 30, 671, DateTimeKind.Unspecified).AddTicks(7726), 2L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 101L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Molestias saepe aliquid qui animi ab voluptates ipsum repudiandae est.", new DateTime(2020, 6, 7, 6, 48, 55, 659, DateTimeKind.Unspecified).AddTicks(1637), 10L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 102L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Mollitia optio odit doloremque voluptatem tenetur at quis quasi tenetur.", new DateTime(2020, 10, 15, 14, 0, 47, 87, DateTimeKind.Unspecified).AddTicks(8121), 11L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 103L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Atque earum odit animi quia et animi in ab quia.", new DateTime(2020, 6, 13, 16, 46, 25, 1, DateTimeKind.Unspecified).AddTicks(1228), 4L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 104L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Sed voluptas enim ipsa assumenda id qui voluptatem vero quia.", new DateTime(2020, 8, 14, 9, 26, 56, 900, DateTimeKind.Unspecified).AddTicks(6804), 1L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 105L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Dolorem qui voluptatem eos id harum est aut quas nesciunt.", new DateTime(2020, 6, 6, 20, 27, 1, 389, DateTimeKind.Unspecified).AddTicks(4025), 12L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 106L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Facilis dolor omnis magnam suscipit et fugiat corporis nobis quo.", new DateTime(2020, 1, 21, 16, 17, 47, 447, DateTimeKind.Unspecified).AddTicks(1711), 12L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 107L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Vitae voluptatibus error nulla alias laudantium in expedita veritatis iure.", new DateTime(2020, 7, 20, 9, 4, 50, 170, DateTimeKind.Unspecified).AddTicks(3987), 5L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 108L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Quaerat fugit aut esse unde provident tempore beatae nisi repellendus.", new DateTime(2020, 9, 26, 20, 9, 5, 336, DateTimeKind.Unspecified).AddTicks(6185), 2L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 109L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Quo nihil saepe omnis vitae cupiditate saepe cupiditate deserunt explicabo.", new DateTime(2020, 4, 20, 19, 3, 45, 915, DateTimeKind.Unspecified).AddTicks(4699), 5L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 110L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Quisquam reprehenderit voluptas aliquid optio ad ipsa sunt minus iste.", new DateTime(2020, 8, 14, 21, 36, 51, 775, DateTimeKind.Unspecified).AddTicks(38), 4L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 111L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Rerum dolor nihil consequatur neque inventore rerum quidem dolores est.", new DateTime(2020, 6, 28, 19, 30, 59, 156, DateTimeKind.Unspecified).AddTicks(9840), 11L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 112L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Cupiditate aut veritatis a sint nobis ex hic rerum temporibus.", new DateTime(2020, 9, 2, 1, 18, 45, 727, DateTimeKind.Unspecified).AddTicks(1357), 4L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 113L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Est laboriosam totam et aperiam rerum aut vel iure ut.", new DateTime(2020, 6, 24, 0, 19, 47, 434, DateTimeKind.Unspecified).AddTicks(1553), 6L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 114L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Eveniet consectetur ducimus corrupti est nemo ab est quos suscipit.", new DateTime(2020, 1, 17, 11, 11, 32, 80, DateTimeKind.Unspecified).AddTicks(7683), 2L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 115L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 6m, "Fugiat repudiandae nihil dolores culpa aut rerum sequi sit quo.", new DateTime(2020, 8, 27, 0, 40, 46, 965, DateTimeKind.Unspecified).AddTicks(1636), 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 116L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Dolorum quo cupiditate ex rerum ut illo facere nisi vel.", new DateTime(2020, 11, 10, 5, 21, 38, 58, DateTimeKind.Unspecified).AddTicks(9644), 6L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 117L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Nulla magni ut tempora ut consectetur reiciendis voluptatum rerum ullam.", new DateTime(2020, 2, 3, 17, 49, 34, 85, DateTimeKind.Unspecified).AddTicks(4205), 12L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 118L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 6m, "Aut est nemo dolorem ducimus suscipit aut omnis consequatur maxime.", new DateTime(2020, 2, 20, 21, 3, 26, 329, DateTimeKind.Unspecified).AddTicks(9562), 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 119L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Sunt saepe quo voluptate quo voluptatibus enim ab accusamus hic.", new DateTime(2020, 8, 21, 17, 31, 34, 46, DateTimeKind.Unspecified).AddTicks(6191), 7L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 120L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Architecto tempora quis in magni enim maxime minus quas deserunt.", new DateTime(2020, 9, 26, 11, 24, 49, 731, DateTimeKind.Unspecified).AddTicks(2400), 9L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 121L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Voluptatem modi inventore at iste eveniet ut placeat qui sunt.", new DateTime(2020, 11, 12, 15, 54, 31, 357, DateTimeKind.Unspecified).AddTicks(6598), 7L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 122L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Quod ea veniam repellendus id tenetur nihil qui quis assumenda.", new DateTime(2020, 6, 7, 9, 30, 36, 351, DateTimeKind.Unspecified).AddTicks(9545), 4L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 123L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 7m, "Iure quia est a sed et qui facilis necessitatibus eligendi.", new DateTime(2020, 5, 2, 20, 25, 45, 225, DateTimeKind.Unspecified).AddTicks(1807), 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 124L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Facilis et accusamus aut aut repellendus asperiores ratione enim itaque.", new DateTime(2020, 3, 30, 6, 6, 36, 963, DateTimeKind.Unspecified).AddTicks(9404), 2L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 125L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Pariatur nostrum animi incidunt natus et ea praesentium rerum similique.", new DateTime(2020, 5, 13, 0, 52, 26, 134, DateTimeKind.Unspecified).AddTicks(7773), 1L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 126L,
                columns: new[] { "AmountOfHours", "Comment", "Date" },
                values: new object[] { 1m, "Totam officia tempore voluptas quo vel earum sunt eveniet minima.", new DateTime(2020, 3, 25, 17, 4, 15, 892, DateTimeKind.Unspecified).AddTicks(9208) });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 127L,
                columns: new[] { "AmountOfHours", "Comment", "Date" },
                values: new object[] { 2m, "Vel facere aut non aut asperiores autem animi explicabo aut.", new DateTime(2020, 11, 6, 8, 40, 18, 935, DateTimeKind.Unspecified).AddTicks(6502) });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 128L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Repudiandae corporis itaque eligendi iste eveniet cum quisquam voluptatem iure.", new DateTime(2020, 12, 20, 6, 40, 39, 381, DateTimeKind.Unspecified).AddTicks(4691), 3L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 129L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 3m, "Reprehenderit voluptatem repellendus perferendis eius fugit est dolores voluptas dolorem.", new DateTime(2020, 10, 19, 0, 43, 50, 719, DateTimeKind.Unspecified).AddTicks(7896), 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 130L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Dolores autem quos sed esse possimus expedita mollitia nisi facere.", new DateTime(2020, 4, 20, 19, 27, 13, 560, DateTimeKind.Unspecified).AddTicks(6618), 12L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 131L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Corrupti quam sit eveniet adipisci sint quia est aspernatur voluptatem.", new DateTime(2020, 7, 26, 11, 19, 0, 598, DateTimeKind.Unspecified).AddTicks(702), 12L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 132L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Sed aut eum ipsam deserunt consequatur modi totam eveniet distinctio.", new DateTime(2020, 7, 14, 20, 9, 42, 292, DateTimeKind.Unspecified).AddTicks(5637), 7L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 133L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Aut doloremque sit enim omnis iste facilis nisi consequatur velit.", new DateTime(2020, 8, 15, 16, 29, 23, 962, DateTimeKind.Unspecified).AddTicks(9268), 1L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 134L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Optio tempora in error modi debitis inventore ut quis cum.", new DateTime(2020, 8, 30, 3, 18, 49, 626, DateTimeKind.Unspecified).AddTicks(1858), 5L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 135L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 1m, "Cupiditate ex sit nesciunt saepe velit et quasi et est.", new DateTime(2020, 11, 14, 20, 21, 34, 779, DateTimeKind.Unspecified).AddTicks(3050), 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 136L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Corporis ut ad consequatur voluptatem et est libero vitae alias.", new DateTime(2020, 2, 20, 2, 36, 5, 913, DateTimeKind.Unspecified).AddTicks(9587), 10L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 137L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Expedita laboriosam repudiandae quibusdam est fuga qui qui beatae aut.", new DateTime(2020, 9, 27, 3, 17, 9, 970, DateTimeKind.Unspecified).AddTicks(2789), 11L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 138L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Voluptatibus necessitatibus ut dolore quod et recusandae in ea unde.", new DateTime(2020, 12, 3, 15, 21, 58, 617, DateTimeKind.Unspecified).AddTicks(2952), 8L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 139L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Ad sit nisi voluptatem cum veritatis velit et est quas.", new DateTime(2020, 3, 31, 1, 7, 7, 39, DateTimeKind.Unspecified).AddTicks(2332), 4L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 140L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Necessitatibus reprehenderit sint ut culpa ratione nobis consectetur minus error.", new DateTime(2020, 5, 17, 15, 36, 41, 388, DateTimeKind.Unspecified).AddTicks(2064), 1L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 141L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Itaque consequatur consectetur voluptatem vel sapiente quia placeat sed quod.", new DateTime(2020, 10, 22, 23, 29, 36, 432, DateTimeKind.Unspecified).AddTicks(7428), 7L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 142L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 1m, "Sed voluptas sapiente tempora corrupti beatae molestias aut et cumque.", new DateTime(2020, 3, 19, 19, 50, 41, 36, DateTimeKind.Unspecified).AddTicks(4722), 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 143L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 1m, "Mollitia dolor voluptatem aut quaerat sequi delectus ea enim delectus.", new DateTime(2020, 3, 4, 1, 18, 14, 562, DateTimeKind.Unspecified).AddTicks(6698), 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 144L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "At dolor sit est recusandae id architecto ut id est.", new DateTime(2020, 9, 4, 19, 1, 29, 70, DateTimeKind.Unspecified).AddTicks(8289), 5L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 145L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Id quos provident veniam autem explicabo sequi possimus officia voluptas.", new DateTime(2020, 9, 30, 23, 33, 19, 359, DateTimeKind.Unspecified).AddTicks(3149), 8L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 146L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Qui asperiores explicabo beatae ea consequatur nesciunt qui consequatur veritatis.", new DateTime(2020, 2, 11, 10, 6, 48, 354, DateTimeKind.Unspecified).AddTicks(7792), 2L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 147L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Quia autem nihil provident voluptate ipsa nam qui et pariatur.", new DateTime(2020, 1, 4, 8, 48, 23, 57, DateTimeKind.Unspecified).AddTicks(9089), 8L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 148L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Officia similique consequuntur officiis quos ex occaecati est cum corporis.", new DateTime(2020, 12, 27, 22, 5, 42, 510, DateTimeKind.Unspecified).AddTicks(3364), 4L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 149L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Quia totam sed modi dicta provident qui numquam nisi et.", new DateTime(2020, 10, 8, 22, 19, 39, 57, DateTimeKind.Unspecified).AddTicks(9216), 8L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 150L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Natus dolore blanditiis dolorem eum veritatis et et itaque nostrum.", new DateTime(2020, 1, 19, 13, 26, 47, 762, DateTimeKind.Unspecified).AddTicks(1194), 1L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 151L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Optio sed non doloremque ad vel optio delectus minus qui.", new DateTime(2020, 2, 8, 11, 20, 31, 219, DateTimeKind.Unspecified).AddTicks(5461), 6L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 152L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Tempora inventore modi quam nemo necessitatibus ab et nulla dolores.", new DateTime(2020, 7, 7, 9, 55, 23, 386, DateTimeKind.Unspecified).AddTicks(942), 12L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 153L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Provident eum ratione et molestiae sit occaecati modi vero dolorum.", new DateTime(2020, 6, 3, 2, 15, 22, 724, DateTimeKind.Unspecified).AddTicks(3625), 10L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 154L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Excepturi veritatis voluptas molestiae unde quos in aut et expedita.", new DateTime(2020, 12, 8, 16, 15, 38, 906, DateTimeKind.Unspecified).AddTicks(4078), 5L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 155L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Ad quo aperiam error sapiente autem et et dolore veritatis.", new DateTime(2020, 7, 8, 11, 14, 43, 624, DateTimeKind.Unspecified).AddTicks(4891), 1L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 156L,
                columns: new[] { "AmountOfHours", "Comment", "Date" },
                values: new object[] { 1m, "Velit id fuga quidem tenetur qui et repellendus ipsum quasi.", new DateTime(2020, 11, 9, 8, 50, 52, 20, DateTimeKind.Unspecified).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 157L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Omnis quos dicta non et aliquam hic ratione qui incidunt.", new DateTime(2020, 10, 1, 16, 10, 25, 128, DateTimeKind.Unspecified).AddTicks(9907), 9L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 158L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Vel ut eveniet ab rerum sunt soluta praesentium aperiam impedit.", new DateTime(2020, 3, 1, 16, 5, 48, 598, DateTimeKind.Unspecified).AddTicks(2435), 4L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 159L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Perspiciatis delectus voluptate aperiam fuga dolor qui possimus aut illum.", new DateTime(2020, 5, 5, 13, 51, 51, 22, DateTimeKind.Unspecified).AddTicks(3630), 12L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 160L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Sit reprehenderit molestiae qui quis enim ut et ipsum odit.", new DateTime(2020, 1, 21, 0, 57, 12, 703, DateTimeKind.Unspecified).AddTicks(7321), 4L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 161L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Praesentium vel rerum iusto repudiandae praesentium animi dolorum dolorem cum.", new DateTime(2020, 12, 23, 2, 12, 26, 939, DateTimeKind.Unspecified).AddTicks(7597), 12L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 162L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Nostrum beatae inventore ipsa sint fuga dignissimos rerum dolor accusamus.", new DateTime(2020, 6, 20, 6, 54, 45, 809, DateTimeKind.Unspecified).AddTicks(2662), 10L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 163L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Autem ullam maxime ducimus aut voluptas ullam mollitia officiis iste.", new DateTime(2020, 7, 9, 2, 5, 18, 239, DateTimeKind.Unspecified).AddTicks(3690), 9L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 164L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Similique magnam praesentium ut nulla repudiandae laborum sunt ab dolore.", new DateTime(2020, 6, 15, 8, 33, 32, 784, DateTimeKind.Unspecified).AddTicks(9663), 8L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 165L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 7m, "Mollitia beatae distinctio rerum earum sapiente dolorem non non atque.", new DateTime(2020, 11, 10, 22, 4, 56, 688, DateTimeKind.Unspecified).AddTicks(5773), 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 166L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Quia et ex et ipsum quae architecto provident voluptate debitis.", new DateTime(2020, 10, 5, 6, 15, 23, 829, DateTimeKind.Unspecified).AddTicks(6405), 3L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 167L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Dolore dolores temporibus blanditiis voluptatibus deleniti alias autem eveniet et.", new DateTime(2020, 1, 10, 15, 59, 10, 460, DateTimeKind.Unspecified).AddTicks(1091), 8L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 168L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Voluptatem reiciendis voluptatem eius nesciunt sint rerum omnis saepe id.", new DateTime(2020, 7, 28, 14, 52, 48, 412, DateTimeKind.Unspecified).AddTicks(7863), 3L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 169L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Tempore dolor cumque laboriosam recusandae quia minima iusto optio quia.", new DateTime(2020, 9, 29, 14, 11, 31, 446, DateTimeKind.Unspecified).AddTicks(152), 8L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 170L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Animi omnis ut soluta rem aperiam numquam molestiae iste sapiente.", new DateTime(2020, 9, 11, 17, 15, 14, 725, DateTimeKind.Unspecified).AddTicks(8392), 6L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 171L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Id ab minima ipsum id itaque quia fugit aut ipsam.", new DateTime(2020, 10, 27, 10, 27, 15, 823, DateTimeKind.Unspecified).AddTicks(7203), 7L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 172L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Veniam velit in debitis tempora rem hic laboriosam rem dolores.", new DateTime(2020, 10, 5, 19, 0, 30, 843, DateTimeKind.Unspecified).AddTicks(5848), 5L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 173L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Tempora id saepe eum nemo qui eum facilis voluptas voluptatum.", new DateTime(2020, 11, 6, 13, 10, 1, 458, DateTimeKind.Unspecified).AddTicks(5448), 7L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 174L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Qui tenetur quia accusantium ad sit ratione ea iure similique.", new DateTime(2020, 4, 17, 2, 54, 32, 408, DateTimeKind.Unspecified).AddTicks(984), 11L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 175L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Culpa repellendus eum doloremque sunt debitis necessitatibus commodi nihil qui.", new DateTime(2020, 10, 1, 11, 47, 42, 213, DateTimeKind.Unspecified).AddTicks(7983), 2L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 176L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Ea aut laboriosam totam dolor laudantium rerum occaecati quis enim.", new DateTime(2020, 1, 21, 7, 20, 12, 109, DateTimeKind.Unspecified).AddTicks(4976), 6L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 177L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Aliquid voluptas rerum a quo natus et inventore facilis molestias.", new DateTime(2020, 2, 5, 12, 14, 20, 835, DateTimeKind.Unspecified).AddTicks(616), 8L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 178L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Non qui rerum aspernatur ad excepturi alias quis tempora velit.", new DateTime(2020, 8, 6, 11, 21, 14, 996, DateTimeKind.Unspecified).AddTicks(1343), 3L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 179L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Velit sint mollitia in dolor voluptatem perferendis aspernatur dolor sit.", new DateTime(2020, 5, 19, 8, 39, 23, 424, DateTimeKind.Unspecified).AddTicks(7061), 5L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 180L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Blanditiis eum aut voluptas et quibusdam doloribus reiciendis molestiae suscipit.", new DateTime(2020, 7, 27, 17, 57, 25, 744, DateTimeKind.Unspecified).AddTicks(2585), 3L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 181L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Aspernatur provident temporibus unde sit consequatur est consequuntur repudiandae dicta.", new DateTime(2020, 11, 14, 9, 32, 29, 18, DateTimeKind.Unspecified).AddTicks(4527), 8L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 182L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Et cumque possimus repellendus earum cumque eum qui est ea.", new DateTime(2020, 1, 28, 0, 4, 20, 639, DateTimeKind.Unspecified).AddTicks(7049), 6L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 183L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Sunt voluptatem laboriosam adipisci sequi hic repellat dolore qui temporibus.", new DateTime(2020, 1, 27, 8, 6, 55, 801, DateTimeKind.Unspecified).AddTicks(9157), 4L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 184L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Sint porro magni exercitationem est iste ea qui in qui.", new DateTime(2020, 8, 27, 0, 56, 47, 686, DateTimeKind.Unspecified).AddTicks(3662), 8L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 185L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Molestiae eum magni animi recusandae numquam eaque est maxime odio.", new DateTime(2020, 3, 26, 19, 31, 21, 16, DateTimeKind.Unspecified).AddTicks(3304), 6L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 186L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Nemo ut rem vel ab et voluptatum necessitatibus enim quia.", new DateTime(2020, 6, 7, 23, 39, 19, 920, DateTimeKind.Unspecified).AddTicks(8275), 11L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 187L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 3m, "Est rerum omnis doloribus porro exercitationem quia aut expedita impedit.", new DateTime(2020, 1, 27, 6, 53, 38, 647, DateTimeKind.Unspecified).AddTicks(4901), 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 188L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Aut eligendi debitis id quia asperiores nihil id voluptatibus voluptatem.", new DateTime(2020, 4, 17, 6, 21, 24, 87, DateTimeKind.Unspecified).AddTicks(3527), 2L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 189L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Aut aut maxime quam qui tempore a vero rerum molestiae.", new DateTime(2020, 3, 23, 16, 32, 5, 726, DateTimeKind.Unspecified).AddTicks(4027), 5L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 190L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Enim voluptas facere laborum quia quia sint culpa dolore aliquam.", new DateTime(2020, 1, 17, 15, 12, 50, 539, DateTimeKind.Unspecified).AddTicks(8412), 5L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 191L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Et quis accusamus voluptatibus quasi quis eveniet est delectus quia.", new DateTime(2020, 12, 11, 8, 12, 28, 348, DateTimeKind.Unspecified).AddTicks(8146), 4L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 192L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Consequatur qui velit maiores hic consequuntur exercitationem eius excepturi quas.", new DateTime(2020, 4, 25, 4, 7, 51, 649, DateTimeKind.Unspecified).AddTicks(8996), 7L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 193L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Omnis quos accusantium et minus officiis hic animi iste quam.", new DateTime(2020, 2, 12, 22, 14, 31, 903, DateTimeKind.Unspecified).AddTicks(395), 1L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 194L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Quibusdam perspiciatis voluptatem officia saepe aut assumenda quibusdam illo ea.", new DateTime(2020, 5, 25, 8, 30, 29, 66, DateTimeKind.Unspecified).AddTicks(8317), 2L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 195L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 6m, "Omnis consequatur blanditiis ab ipsum commodi rerum voluptatum dolor tempora.", new DateTime(2020, 10, 16, 11, 38, 21, 252, DateTimeKind.Unspecified).AddTicks(6484), 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 196L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Saepe omnis et consectetur minus quidem quam delectus sit itaque.", new DateTime(2020, 2, 29, 19, 13, 16, 43, DateTimeKind.Unspecified).AddTicks(7397), 2L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 197L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Iusto dolorum recusandae et dicta voluptatem qui consectetur delectus perferendis.", new DateTime(2020, 10, 7, 0, 6, 13, 596, DateTimeKind.Unspecified).AddTicks(3644), 8L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 198L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Consequatur explicabo nihil qui rerum natus ut minima atque itaque.", new DateTime(2020, 10, 10, 14, 47, 45, 219, DateTimeKind.Unspecified).AddTicks(173), 1L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 199L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Sit occaecati et vero animi et eaque iste nostrum delectus.", new DateTime(2020, 4, 9, 7, 59, 35, 333, DateTimeKind.Unspecified).AddTicks(8963), 5L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 200L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Vel voluptates id cumque eos explicabo animi sunt incidunt cum.", new DateTime(2020, 5, 22, 8, 27, 47, 225, DateTimeKind.Unspecified).AddTicks(219), 9L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 201L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Eos repellat quo non doloribus aut aut dignissimos sunt qui.", new DateTime(2020, 1, 24, 19, 1, 18, 568, DateTimeKind.Unspecified).AddTicks(896), 6L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 202L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Et quod aspernatur quod quia velit totam in suscipit eum.", new DateTime(2020, 4, 14, 5, 24, 39, 255, DateTimeKind.Unspecified).AddTicks(9297), 4L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 203L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Nostrum dolore amet in at rerum quam exercitationem consequuntur nihil.", new DateTime(2020, 3, 19, 8, 42, 41, 147, DateTimeKind.Unspecified).AddTicks(6731), 11L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 204L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Illum officiis enim aut vel temporibus nostrum corrupti culpa recusandae.", new DateTime(2020, 9, 11, 9, 24, 2, 73, DateTimeKind.Unspecified).AddTicks(3043), 1L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 205L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Distinctio blanditiis rerum illum autem sint sequi nulla perspiciatis doloremque.", new DateTime(2020, 9, 10, 3, 12, 47, 679, DateTimeKind.Unspecified).AddTicks(9292), 12L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 206L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 5m, "Et tempore eum autem molestias aspernatur omnis praesentium fugit veniam.", new DateTime(2020, 5, 22, 11, 44, 34, 505, DateTimeKind.Unspecified).AddTicks(5828), 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 207L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Nam magnam autem doloribus adipisci vero quidem tempore repellendus explicabo.", new DateTime(2020, 10, 21, 7, 37, 36, 541, DateTimeKind.Unspecified).AddTicks(8133), 8L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 208L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Sit labore aut velit ea dolor officiis voluptates odit incidunt.", new DateTime(2020, 3, 19, 21, 12, 44, 51, DateTimeKind.Unspecified).AddTicks(5743), 5L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 209L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Nisi ea qui quis fugit ex dolor nostrum expedita consequatur.", new DateTime(2020, 10, 21, 11, 57, 19, 272, DateTimeKind.Unspecified).AddTicks(8693), 3L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 210L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 8m, "Necessitatibus minus non minus aut repellendus magni officiis enim tenetur.", new DateTime(2020, 11, 15, 20, 3, 37, 246, DateTimeKind.Unspecified).AddTicks(5854), 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 211L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Ratione qui quidem animi illo iusto sit molestiae facilis non.", new DateTime(2020, 12, 6, 1, 26, 11, 802, DateTimeKind.Unspecified).AddTicks(46), 8L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 212L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 1m, "Qui consequatur quia officiis voluptates non sit quis voluptatem fuga.", new DateTime(2020, 10, 18, 21, 43, 27, 47, DateTimeKind.Unspecified).AddTicks(504), 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 213L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Dicta et aliquid aspernatur molestiae quam ratione excepturi quis id.", new DateTime(2020, 1, 25, 16, 50, 17, 648, DateTimeKind.Unspecified).AddTicks(2215), 6L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 214L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Sunt repellat quasi voluptatem doloribus explicabo nostrum ut placeat ratione.", new DateTime(2020, 8, 13, 3, 50, 30, 91, DateTimeKind.Unspecified).AddTicks(7988), 2L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 215L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Sed aut necessitatibus eaque consequatur eos laboriosam qui vero error.", new DateTime(2020, 9, 28, 5, 26, 35, 118, DateTimeKind.Unspecified).AddTicks(3872), 6L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 216L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Harum animi in voluptatum ipsam iste veniam voluptatem omnis est.", new DateTime(2020, 11, 23, 16, 11, 16, 510, DateTimeKind.Unspecified).AddTicks(3656), 1L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 217L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Facere quia doloribus et soluta quis qui commodi quo iusto.", new DateTime(2020, 3, 6, 13, 31, 55, 923, DateTimeKind.Unspecified).AddTicks(5943), 1L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 218L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Eos molestias officia et sed eius harum ratione placeat harum.", new DateTime(2020, 2, 15, 3, 12, 23, 160, DateTimeKind.Unspecified).AddTicks(7702), 9L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 219L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Blanditiis sed perferendis qui nobis sint reprehenderit et in alias.", new DateTime(2020, 6, 29, 10, 43, 20, 893, DateTimeKind.Unspecified).AddTicks(1191), 9L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 220L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Rerum sapiente voluptate error iusto suscipit aut quae aut velit.", new DateTime(2020, 9, 5, 4, 49, 10, 676, DateTimeKind.Unspecified).AddTicks(6475), 10L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 221L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Blanditiis ea facere et debitis exercitationem et excepturi quam tempore.", new DateTime(2020, 3, 10, 17, 38, 37, 699, DateTimeKind.Unspecified).AddTicks(4813), 1L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 222L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 4m, "Recusandae qui sint cum perspiciatis ea voluptatem repellendus modi fugit.", new DateTime(2020, 7, 23, 4, 23, 21, 540, DateTimeKind.Unspecified).AddTicks(1288), 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 223L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Aspernatur id fuga est voluptas repellendus velit numquam magnam velit.", new DateTime(2020, 3, 19, 14, 18, 38, 603, DateTimeKind.Unspecified).AddTicks(7870), 8L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 224L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Ut id dolores eum dolor qui aut occaecati quos explicabo.", new DateTime(2020, 5, 14, 1, 47, 58, 395, DateTimeKind.Unspecified).AddTicks(8033), 5L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 225L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Dolores quidem facere est vitae dolores esse illum ab nisi.", new DateTime(2020, 5, 6, 8, 58, 47, 10, DateTimeKind.Unspecified).AddTicks(3486), 4L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 226L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Sit quisquam aperiam neque repellat necessitatibus et corrupti et sint.", new DateTime(2020, 4, 16, 0, 6, 19, 351, DateTimeKind.Unspecified).AddTicks(2316), 5L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 227L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Aut non nemo et odio non vitae et dignissimos et.", new DateTime(2020, 4, 19, 16, 44, 59, 587, DateTimeKind.Unspecified).AddTicks(4641), 4L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 228L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Nobis sequi unde consequatur aut qui amet assumenda inventore magnam.", new DateTime(2020, 12, 17, 1, 20, 24, 385, DateTimeKind.Unspecified).AddTicks(596), 10L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 229L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Sit fugiat ut ut adipisci quo impedit occaecati aperiam dolor.", new DateTime(2020, 6, 5, 2, 44, 36, 383, DateTimeKind.Unspecified).AddTicks(3688), 4L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 230L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 6m, "Ad fugit et consequuntur recusandae cupiditate et laudantium quis consequatur.", new DateTime(2020, 8, 21, 8, 7, 49, 602, DateTimeKind.Unspecified).AddTicks(3481), 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 231L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Totam illo nam maiores aut et mollitia laborum sunt aperiam.", new DateTime(2020, 5, 23, 8, 40, 56, 605, DateTimeKind.Unspecified).AddTicks(4922), 9L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 232L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 2m, "Sed assumenda cum ut omnis rem dolores rerum iure impedit.", new DateTime(2020, 1, 5, 23, 5, 36, 170, DateTimeKind.Unspecified).AddTicks(3470), 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 233L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Laudantium voluptatibus iste nostrum ducimus consequatur ab voluptatibus fugit ut.", new DateTime(2020, 11, 7, 16, 31, 43, 428, DateTimeKind.Unspecified).AddTicks(9980), 8L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 234L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Perspiciatis fugiat ducimus vel molestias harum ut id eligendi commodi.", new DateTime(2020, 2, 13, 22, 33, 28, 421, DateTimeKind.Unspecified).AddTicks(8403), 2L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 235L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Libero a laudantium velit qui ipsa voluptatem officia voluptatum eum.", new DateTime(2020, 11, 6, 4, 48, 48, 42, DateTimeKind.Unspecified).AddTicks(5316), 9L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 236L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Et voluptas nobis iste aliquid eum ea iste quaerat impedit.", new DateTime(2020, 2, 11, 15, 42, 53, 636, DateTimeKind.Unspecified).AddTicks(6401), 5L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 237L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 7m, "Nostrum adipisci ratione non cupiditate non enim nesciunt rerum laudantium.", new DateTime(2020, 3, 17, 4, 44, 26, 595, DateTimeKind.Unspecified).AddTicks(9915), 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 238L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Ex et eos et occaecati non hic commodi cum officia.", new DateTime(2020, 7, 7, 10, 28, 25, 913, DateTimeKind.Unspecified).AddTicks(6238), 7L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 239L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Cumque possimus aut consequatur fugiat nostrum ullam minima ut ratione.", new DateTime(2020, 2, 14, 5, 14, 25, 122, DateTimeKind.Unspecified).AddTicks(9097), 2L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 240L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Dignissimos modi recusandae ad voluptatem ducimus velit consectetur similique non.", new DateTime(2020, 10, 29, 4, 40, 6, 502, DateTimeKind.Unspecified).AddTicks(7330), 9L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 241L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Occaecati natus sapiente molestias voluptate sed praesentium magni expedita aliquam.", new DateTime(2020, 11, 29, 14, 34, 18, 267, DateTimeKind.Unspecified).AddTicks(873), 3L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 242L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Eum asperiores maxime itaque iure blanditiis et qui et nostrum.", new DateTime(2020, 8, 29, 2, 38, 22, 951, DateTimeKind.Unspecified).AddTicks(7591), 9L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 243L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Amet ad tempore quo vel quis omnis cum sit laborum.", new DateTime(2020, 11, 30, 19, 22, 0, 860, DateTimeKind.Unspecified).AddTicks(443), 3L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 244L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Similique soluta doloremque explicabo autem quia commodi in repellendus possimus.", new DateTime(2020, 1, 14, 2, 49, 37, 693, DateTimeKind.Unspecified).AddTicks(8247), 8L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 245L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Et libero vel id nostrum hic earum vel culpa voluptate.", new DateTime(2020, 1, 2, 15, 9, 33, 171, DateTimeKind.Unspecified).AddTicks(3281), 11L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 246L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Consequatur dolores omnis voluptas nihil est rerum ut voluptatem id.", new DateTime(2020, 4, 25, 15, 44, 43, 686, DateTimeKind.Unspecified).AddTicks(6166), 11L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 247L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Quos repudiandae tempora non consequatur eligendi assumenda sint quibusdam odio.", new DateTime(2020, 2, 23, 15, 18, 33, 485, DateTimeKind.Unspecified).AddTicks(8790), 4L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 248L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Aut dolorum magnam quas consequatur quia voluptas et repellat nulla.", new DateTime(2020, 5, 15, 23, 42, 34, 218, DateTimeKind.Unspecified).AddTicks(1442), 1L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 249L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Voluptate non vero et aut sit necessitatibus nam sit repudiandae.", new DateTime(2020, 3, 8, 10, 2, 7, 143, DateTimeKind.Unspecified).AddTicks(8722), 12L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 250L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Suscipit voluptatem et suscipit labore optio accusamus rerum aliquid autem.", new DateTime(2020, 5, 21, 9, 38, 7, 75, DateTimeKind.Unspecified).AddTicks(7622), 12L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 251L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Repudiandae eum eveniet ut molestias fugiat odit officia qui fugiat.", new DateTime(2020, 11, 6, 12, 45, 13, 592, DateTimeKind.Unspecified).AddTicks(619), 4L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 252L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Odio laboriosam qui amet qui rem ipsam soluta velit eligendi.", new DateTime(2020, 4, 19, 0, 51, 35, 664, DateTimeKind.Unspecified).AddTicks(5622), 2L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 253L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Vero deleniti occaecati et atque ab facere quibusdam perferendis hic.", new DateTime(2020, 1, 25, 5, 57, 9, 835, DateTimeKind.Unspecified).AddTicks(5336), 2L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 254L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 6m, "Id animi illo velit in iusto sed perferendis temporibus autem.", new DateTime(2020, 3, 9, 3, 14, 11, 262, DateTimeKind.Unspecified).AddTicks(1353), 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 255L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Ut quia vel voluptatem assumenda nisi qui aut enim esse.", new DateTime(2020, 7, 10, 12, 26, 11, 939, DateTimeKind.Unspecified).AddTicks(6338), 7L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 256L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 6m, "Quia quidem architecto enim quis similique rerum consequatur rerum a.", new DateTime(2020, 9, 7, 21, 59, 6, 36, DateTimeKind.Unspecified).AddTicks(8883), 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 257L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Eligendi est placeat aut non sint eum consequatur dolores sunt.", new DateTime(2020, 7, 25, 18, 45, 0, 416, DateTimeKind.Unspecified).AddTicks(7260), 10L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 258L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Quis quidem facilis sequi placeat natus est sequi quisquam nulla.", new DateTime(2020, 1, 7, 20, 49, 11, 691, DateTimeKind.Unspecified).AddTicks(5819), 2L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 259L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Error vero itaque dolores dolor aut velit officia libero dignissimos.", new DateTime(2020, 4, 16, 10, 16, 30, 12, DateTimeKind.Unspecified).AddTicks(4975), 9L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 260L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Et voluptatibus atque dignissimos omnis enim cupiditate alias ipsam non.", new DateTime(2020, 10, 25, 12, 27, 3, 479, DateTimeKind.Unspecified).AddTicks(4870), 11L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 261L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Alias ut voluptatem in tempora libero et minima sequi est.", new DateTime(2020, 2, 27, 1, 4, 57, 406, DateTimeKind.Unspecified).AddTicks(5829), 1L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 262L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Ut velit iusto qui maxime quia et quod ea facilis.", new DateTime(2020, 3, 21, 14, 50, 32, 336, DateTimeKind.Unspecified).AddTicks(2361), 5L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 263L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Ut consequatur aliquam omnis qui officiis qui voluptas nihil qui.", new DateTime(2020, 8, 21, 22, 17, 47, 87, DateTimeKind.Unspecified).AddTicks(6176), 12L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 264L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 2m, "Eum quo vel esse explicabo qui aperiam sed dolores ullam.", new DateTime(2020, 4, 10, 2, 48, 45, 883, DateTimeKind.Unspecified).AddTicks(3232), 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 265L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Ut autem quia magnam doloremque soluta id ratione qui quis.", new DateTime(2020, 11, 20, 18, 21, 9, 968, DateTimeKind.Unspecified).AddTicks(7207), 5L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 266L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Est exercitationem facilis animi ut molestiae voluptates cupiditate voluptatem maiores.", new DateTime(2020, 2, 12, 18, 23, 4, 775, DateTimeKind.Unspecified).AddTicks(1389), 11L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 267L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Excepturi a occaecati maxime doloribus voluptatem modi quae delectus est.", new DateTime(2020, 7, 12, 16, 52, 49, 551, DateTimeKind.Unspecified).AddTicks(790), 2L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 268L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Dignissimos explicabo aut placeat nihil fugiat nisi velit et expedita.", new DateTime(2020, 6, 27, 4, 1, 40, 355, DateTimeKind.Unspecified).AddTicks(4337), 1L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 269L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Fugit consectetur commodi numquam voluptatem ipsam quidem iusto voluptas distinctio.", new DateTime(2020, 5, 9, 23, 50, 48, 620, DateTimeKind.Unspecified).AddTicks(4115), 5L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 270L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Sit tenetur corrupti nemo rerum tempora vitae dolorem reiciendis dolores.", new DateTime(2020, 12, 24, 22, 12, 26, 529, DateTimeKind.Unspecified).AddTicks(1068), 2L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 271L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Corporis et libero sed delectus quia recusandae est quia ut.", new DateTime(2020, 1, 30, 10, 43, 41, 298, DateTimeKind.Unspecified).AddTicks(1180), 6L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 272L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Sit ut qui voluptates at et accusamus cumque dolorem assumenda.", new DateTime(2020, 1, 18, 7, 0, 45, 323, DateTimeKind.Unspecified).AddTicks(6310), 7L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 273L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Numquam incidunt aut blanditiis ut voluptas dolores eveniet asperiores qui.", new DateTime(2020, 12, 9, 14, 41, 5, 149, DateTimeKind.Unspecified).AddTicks(9741), 10L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 274L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Et qui accusamus est dolor beatae quo et quod sed.", new DateTime(2020, 10, 18, 22, 13, 23, 513, DateTimeKind.Unspecified).AddTicks(7504), 11L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 275L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Optio eveniet voluptatem quo enim maiores natus explicabo quibusdam voluptatibus.", new DateTime(2020, 6, 10, 4, 6, 12, 224, DateTimeKind.Unspecified).AddTicks(55), 12L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 276L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Ex in beatae vitae qui ipsam quasi culpa ut quod.", new DateTime(2020, 11, 15, 11, 15, 29, 615, DateTimeKind.Unspecified).AddTicks(1871), 12L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 277L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Corrupti ut et assumenda rerum non sed explicabo quibusdam doloribus.", new DateTime(2020, 2, 10, 15, 33, 41, 169, DateTimeKind.Unspecified).AddTicks(5902), 7L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 278L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Temporibus rerum fugiat praesentium quia ea ad dolorem quia possimus.", new DateTime(2020, 12, 30, 23, 24, 7, 774, DateTimeKind.Unspecified).AddTicks(2155), 8L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 279L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Asperiores veniam necessitatibus velit officiis reiciendis est saepe consequatur ipsum.", new DateTime(2020, 7, 14, 20, 33, 14, 633, DateTimeKind.Unspecified).AddTicks(2039), 11L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 280L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Omnis sunt culpa aut voluptatem sed autem sit et quos.", new DateTime(2020, 3, 25, 6, 45, 39, 747, DateTimeKind.Unspecified).AddTicks(4521), 8L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 281L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Dolor vero consequuntur voluptas repellat dicta aut excepturi aut sunt.", new DateTime(2020, 4, 22, 23, 51, 8, 86, DateTimeKind.Unspecified).AddTicks(4898), 12L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 282L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Sint nam fuga et quia sit iure doloremque dolor harum.", new DateTime(2020, 12, 5, 8, 10, 38, 943, DateTimeKind.Unspecified).AddTicks(109), 10L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 283L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Vel in possimus dolorem libero quis aut molestias ipsa quasi.", new DateTime(2020, 4, 28, 13, 56, 25, 714, DateTimeKind.Unspecified).AddTicks(2548), 5L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 284L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Doloribus quos architecto corporis laborum saepe et et et repellendus.", new DateTime(2020, 2, 27, 12, 35, 51, 865, DateTimeKind.Unspecified).AddTicks(7180), 7L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 285L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 7m, "Soluta quos sapiente repellat voluptas quia dolores nihil sit assumenda.", new DateTime(2020, 12, 7, 20, 36, 22, 206, DateTimeKind.Unspecified).AddTicks(9603), 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 286L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Dolorum omnis occaecati aperiam eos quia ipsa est natus et.", new DateTime(2020, 10, 15, 0, 35, 52, 955, DateTimeKind.Unspecified).AddTicks(2112), 5L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 287L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Provident aut quidem vel ex commodi eum omnis aut nisi.", new DateTime(2020, 6, 25, 12, 50, 50, 757, DateTimeKind.Unspecified).AddTicks(5638), 5L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 288L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Nesciunt nemo tenetur reiciendis aut quos dolorum enim voluptatem et.", new DateTime(2020, 2, 18, 15, 46, 50, 497, DateTimeKind.Unspecified).AddTicks(5965), 6L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 289L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Recusandae laudantium et suscipit rerum repellat ipsum ea magni ut.", new DateTime(2020, 9, 16, 8, 49, 59, 237, DateTimeKind.Unspecified).AddTicks(3913), 4L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 290L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Dignissimos quia et dolorem doloribus possimus non aliquam perspiciatis voluptate.", new DateTime(2020, 3, 6, 12, 38, 1, 734, DateTimeKind.Unspecified).AddTicks(2553), 4L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 291L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Impedit eos hic unde expedita quo dolorum est qui ipsa.", new DateTime(2020, 7, 7, 19, 53, 3, 395, DateTimeKind.Unspecified).AddTicks(7886), 5L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 292L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Quia maiores optio est enim omnis accusamus sunt nulla animi.", new DateTime(2020, 2, 11, 13, 41, 24, 750, DateTimeKind.Unspecified).AddTicks(5233), 10L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 293L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Sint non sit est atque tenetur et doloribus sit minus.", new DateTime(2020, 6, 19, 21, 44, 44, 677, DateTimeKind.Unspecified).AddTicks(8906), 10L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 294L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Ducimus est et at facilis qui beatae natus impedit et.", new DateTime(2020, 6, 14, 0, 37, 56, 317, DateTimeKind.Unspecified).AddTicks(3263), 9L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 295L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Exercitationem aliquid qui nihil quis earum qui occaecati accusantium maxime.", new DateTime(2020, 5, 8, 14, 13, 7, 531, DateTimeKind.Unspecified).AddTicks(1106), 8L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 296L,
                columns: new[] { "Comment", "Date", "ProjectId" },
                values: new object[] { "Ut delectus sint ut aut quasi rerum ut ipsum delectus.", new DateTime(2020, 2, 24, 17, 59, 40, 172, DateTimeKind.Unspecified).AddTicks(4169), 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 297L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Et reprehenderit ut occaecati id doloremque optio libero consequatur veritatis.", new DateTime(2020, 8, 7, 23, 30, 23, 549, DateTimeKind.Unspecified).AddTicks(7273), 12L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 298L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Qui est sed atque culpa eveniet officia maxime impedit impedit.", new DateTime(2020, 1, 25, 20, 36, 52, 240, DateTimeKind.Unspecified).AddTicks(8348), 11L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 299L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 1m, "Sit omnis ea harum laboriosam quis sit harum est magni.", new DateTime(2020, 12, 24, 23, 36, 47, 410, DateTimeKind.Unspecified).AddTicks(2485), 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 300L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Sapiente vero repellat deserunt alias quo et atque omnis illum.", new DateTime(2020, 6, 26, 23, 56, 59, 371, DateTimeKind.Unspecified).AddTicks(9312), 2L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 301L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Soluta quaerat nam quia illo rerum atque et expedita laboriosam.", new DateTime(2020, 10, 9, 10, 27, 21, 352, DateTimeKind.Unspecified).AddTicks(2762), 3L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 302L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 8m, "Repudiandae architecto molestiae praesentium velit quis repellendus at quo voluptatem.", new DateTime(2020, 11, 30, 14, 42, 21, 55, DateTimeKind.Unspecified).AddTicks(4566), 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 303L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Alias qui rem quidem animi voluptatem tenetur sint totam ut.", new DateTime(2020, 5, 28, 12, 43, 14, 135, DateTimeKind.Unspecified).AddTicks(7394), 1L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 304L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Velit expedita molestiae nemo et cumque sunt est necessitatibus optio.", new DateTime(2020, 10, 26, 11, 10, 50, 259, DateTimeKind.Unspecified).AddTicks(3496), 4L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 305L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Unde in quae repellendus labore repellendus labore architecto et provident.", new DateTime(2020, 12, 22, 0, 21, 53, 616, DateTimeKind.Unspecified).AddTicks(1706), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 306L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Id eligendi in similique rem et et illo quo ut.", new DateTime(2020, 12, 31, 13, 0, 25, 478, DateTimeKind.Unspecified).AddTicks(4459), 6L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 307L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Eligendi est nisi sed nostrum consequuntur ut et amet ad.", new DateTime(2020, 2, 17, 1, 13, 15, 180, DateTimeKind.Unspecified).AddTicks(650), 8L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 308L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Temporibus saepe quia voluptatem nihil quia vitae velit ullam est.", new DateTime(2020, 6, 24, 11, 30, 45, 705, DateTimeKind.Unspecified).AddTicks(6924), 1L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 309L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Error architecto voluptatem provident distinctio non vel sunt amet reiciendis.", new DateTime(2020, 3, 5, 9, 20, 40, 154, DateTimeKind.Unspecified).AddTicks(4638), 5L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 310L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Molestias quia sapiente dignissimos officia non ut earum omnis ipsam.", new DateTime(2020, 6, 6, 13, 10, 51, 987, DateTimeKind.Unspecified).AddTicks(6209), 12L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 311L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Voluptatum dolorum aut iure hic voluptatum quas aut a quasi.", new DateTime(2020, 3, 24, 13, 32, 53, 724, DateTimeKind.Unspecified).AddTicks(5280), 5L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 312L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Impedit incidunt autem quo maxime perspiciatis est dolor voluptas error.", new DateTime(2020, 10, 1, 10, 56, 2, 907, DateTimeKind.Unspecified).AddTicks(8557), 4L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 313L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Ipsam alias sed nihil cumque aut et similique accusamus delectus.", new DateTime(2020, 3, 23, 11, 5, 3, 329, DateTimeKind.Unspecified).AddTicks(9095), 12L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 314L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Neque necessitatibus architecto eaque omnis similique ut provident cupiditate neque.", new DateTime(2020, 1, 14, 11, 22, 43, 548, DateTimeKind.Unspecified).AddTicks(1384), 3L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 315L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "At perspiciatis architecto corporis magnam aut quibusdam tenetur sed nam.", new DateTime(2020, 10, 23, 2, 39, 5, 737, DateTimeKind.Unspecified).AddTicks(2442), 11L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 316L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Commodi eum sint autem molestias exercitationem perferendis officiis quos ad.", new DateTime(2020, 1, 30, 13, 47, 56, 302, DateTimeKind.Unspecified).AddTicks(8957), 11L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 317L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Deleniti autem quos sit architecto quia quo quia saepe et.", new DateTime(2020, 5, 21, 18, 3, 57, 936, DateTimeKind.Unspecified).AddTicks(6596), 9L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 318L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Aliquid voluptate consectetur voluptates corrupti explicabo ipsum eligendi dolore quam.", new DateTime(2020, 8, 7, 17, 47, 27, 179, DateTimeKind.Unspecified).AddTicks(8927), 3L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 319L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Ab quibusdam et mollitia dolores perferendis voluptatum neque quia eum.", new DateTime(2020, 4, 12, 10, 51, 24, 615, DateTimeKind.Unspecified).AddTicks(2994), 10L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 320L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Recusandae ullam explicabo aliquid optio consequatur occaecati dicta vitae a.", new DateTime(2020, 6, 6, 11, 38, 46, 227, DateTimeKind.Unspecified).AddTicks(5682), 3L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 321L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Magni architecto voluptas error ipsa minus enim aspernatur amet aut.", new DateTime(2020, 8, 12, 17, 1, 43, 363, DateTimeKind.Unspecified).AddTicks(7541), 8L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 322L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Incidunt commodi sed qui nam magni omnis rerum voluptas dolorem.", new DateTime(2020, 9, 25, 16, 40, 42, 82, DateTimeKind.Unspecified).AddTicks(5239), 10L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 323L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Quo rem nihil sed ea est aperiam aut doloribus incidunt.", new DateTime(2020, 6, 17, 8, 20, 56, 342, DateTimeKind.Unspecified).AddTicks(9615), 9L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 324L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Fugit doloribus optio aut architecto sit at quisquam voluptas odio.", new DateTime(2020, 10, 8, 4, 52, 56, 93, DateTimeKind.Unspecified).AddTicks(4897), 8L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 325L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Maxime perferendis maxime sunt enim nemo eum porro cum qui.", new DateTime(2020, 1, 9, 22, 9, 46, 66, DateTimeKind.Unspecified).AddTicks(6900), 3L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 326L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Autem necessitatibus perferendis delectus commodi molestiae fugiat suscipit consequuntur nihil.", new DateTime(2020, 2, 27, 22, 5, 36, 840, DateTimeKind.Unspecified).AddTicks(6830), 5L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 327L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 8m, "Harum maiores sunt et nam pariatur ex aut atque qui.", new DateTime(2020, 2, 11, 18, 3, 18, 215, DateTimeKind.Unspecified).AddTicks(8531), 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 328L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Enim et non aperiam quia quisquam ut hic molestiae nam.", new DateTime(2020, 6, 14, 11, 37, 31, 386, DateTimeKind.Unspecified).AddTicks(3729), 2L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 329L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Rerum ipsa dolor ratione consectetur reprehenderit vitae eligendi aut quaerat.", new DateTime(2020, 5, 8, 21, 29, 11, 499, DateTimeKind.Unspecified).AddTicks(1658), 5L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 330L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Voluptate officiis ut et rem iusto voluptatem rerum est ea.", new DateTime(2020, 10, 12, 1, 4, 28, 613, DateTimeKind.Unspecified).AddTicks(4982), 12L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 331L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Iste voluptates aut similique et rerum dicta odio delectus minima.", new DateTime(2020, 8, 24, 22, 47, 0, 966, DateTimeKind.Unspecified).AddTicks(9406), 4L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 332L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Commodi tempore distinctio et rerum rerum perspiciatis omnis quia non.", new DateTime(2020, 4, 24, 23, 53, 2, 413, DateTimeKind.Unspecified).AddTicks(8923), 8L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 333L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Enim illum consectetur et placeat ea dolores ut blanditiis consequatur.", new DateTime(2020, 5, 22, 6, 17, 35, 977, DateTimeKind.Unspecified).AddTicks(6665), 10L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 334L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Et voluptatem quidem esse quia ea occaecati aspernatur cumque sunt.", new DateTime(2020, 4, 24, 3, 23, 17, 135, DateTimeKind.Unspecified).AddTicks(5376), 6L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 335L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Repellendus deserunt earum culpa iste dicta dolorem voluptatem sunt totam.", new DateTime(2020, 2, 19, 11, 49, 29, 910, DateTimeKind.Unspecified).AddTicks(5386), 4L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 336L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Eius pariatur illo aut quidem culpa est eos in non.", new DateTime(2020, 6, 26, 7, 22, 46, 285, DateTimeKind.Unspecified).AddTicks(4870), 10L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 337L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Fugit aspernatur aliquid ab enim dolores sit eos et tempora.", new DateTime(2020, 6, 26, 6, 32, 36, 813, DateTimeKind.Unspecified).AddTicks(2153), 4L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 338L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 7m, "Quia dolorem odit non et consequuntur aut pariatur aperiam suscipit.", new DateTime(2020, 10, 19, 18, 53, 27, 882, DateTimeKind.Unspecified).AddTicks(5314), 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 339L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Sit minus repellendus sunt animi repellat aperiam doloribus sed voluptatem.", new DateTime(2020, 5, 10, 20, 55, 47, 618, DateTimeKind.Unspecified).AddTicks(3020), 8L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 340L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 3m, "Voluptatibus dolorem quo velit dolor necessitatibus nobis voluptate aut qui.", new DateTime(2020, 3, 17, 19, 38, 0, 346, DateTimeKind.Unspecified).AddTicks(6530), 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 341L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Veritatis perferendis maiores quo omnis quaerat voluptas dolores odio nihil.", new DateTime(2020, 4, 16, 4, 7, 34, 753, DateTimeKind.Unspecified).AddTicks(8335), 8L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 342L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Ab nulla sunt sunt sint cupiditate accusamus non et et.", new DateTime(2020, 9, 22, 1, 57, 46, 709, DateTimeKind.Unspecified).AddTicks(6111), 10L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 343L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Et sed molestias dolore impedit est molestiae aut ad molestiae.", new DateTime(2020, 3, 29, 8, 57, 17, 383, DateTimeKind.Unspecified).AddTicks(4358), 7L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 344L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Eum magni repellendus voluptatibus dolorem et ex quaerat aut quos.", new DateTime(2020, 7, 8, 22, 22, 13, 524, DateTimeKind.Unspecified).AddTicks(4345), 6L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 345L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Excepturi suscipit itaque nemo sit tempora molestias labore adipisci vel.", new DateTime(2020, 5, 24, 16, 21, 2, 503, DateTimeKind.Unspecified).AddTicks(2043), 2L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 346L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Sunt est repellat delectus consequatur voluptatem dolorem consequatur et autem.", new DateTime(2020, 4, 5, 3, 1, 22, 77, DateTimeKind.Unspecified).AddTicks(8137), 4L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 347L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 3m, "Adipisci sit aut earum vel quasi deserunt itaque maiores ut.", new DateTime(2020, 4, 3, 23, 21, 6, 710, DateTimeKind.Unspecified).AddTicks(2609), 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 348L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Itaque voluptate rerum eius et velit est commodi dolores voluptatum.", new DateTime(2020, 5, 4, 4, 41, 37, 430, DateTimeKind.Unspecified).AddTicks(210), 10L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 349L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Rem ratione consequatur minima ut qui ipsa quia sunt voluptatem.", new DateTime(2020, 1, 12, 13, 4, 31, 206, DateTimeKind.Unspecified).AddTicks(5037), 7L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 350L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Distinctio qui doloremque porro soluta cum et blanditiis et vitae.", new DateTime(2020, 5, 10, 9, 57, 43, 593, DateTimeKind.Unspecified).AddTicks(7023), 6L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 351L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Occaecati sit sit consequatur eaque ducimus laudantium voluptas quaerat expedita.", new DateTime(2020, 9, 5, 17, 1, 35, 421, DateTimeKind.Unspecified).AddTicks(4113), 4L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 352L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Quo id est illo illo illo nihil voluptas dignissimos ipsa.", new DateTime(2020, 2, 7, 21, 48, 28, 457, DateTimeKind.Unspecified).AddTicks(4856), 9L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 353L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Labore et dolor consequuntur laudantium numquam expedita labore delectus error.", new DateTime(2020, 9, 18, 14, 43, 4, 462, DateTimeKind.Unspecified).AddTicks(7851), 2L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 354L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Rem quis in atque sunt libero dolorum ipsum iusto dignissimos.", new DateTime(2020, 3, 3, 2, 26, 51, 24, DateTimeKind.Unspecified).AddTicks(9545), 10L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 355L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Rerum qui ipsam nobis minus ducimus id suscipit debitis consectetur.", new DateTime(2020, 2, 16, 16, 23, 36, 282, DateTimeKind.Unspecified).AddTicks(7364), 9L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 356L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Assumenda vitae ut ratione rerum rerum exercitationem architecto rerum quia.", new DateTime(2020, 2, 8, 22, 36, 14, 909, DateTimeKind.Unspecified).AddTicks(3703), 10L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 357L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Corrupti laboriosam suscipit voluptas dicta ut ex dolorem magnam totam.", new DateTime(2020, 5, 25, 9, 32, 20, 95, DateTimeKind.Unspecified).AddTicks(1858), 3L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 358L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Quos quia facere nobis error accusantium ea aliquid ut facilis.", new DateTime(2020, 3, 20, 4, 55, 26, 627, DateTimeKind.Unspecified).AddTicks(8171), 9L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 359L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Et aut ut est ab sed pariatur ut vero necessitatibus.", new DateTime(2020, 6, 18, 1, 23, 24, 323, DateTimeKind.Unspecified).AddTicks(8142), 10L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 360L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Fugiat iusto aut dolorem libero nesciunt culpa iusto qui aspernatur.", new DateTime(2020, 3, 29, 10, 7, 46, 121, DateTimeKind.Unspecified).AddTicks(8768), 6L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 361L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Quibusdam eligendi odit nulla odio perspiciatis quia eos similique atque.", new DateTime(2020, 8, 31, 3, 38, 2, 519, DateTimeKind.Unspecified).AddTicks(9933), 9L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 362L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Aliquid eos aut ex repellendus praesentium occaecati odit libero similique.", new DateTime(2020, 4, 14, 20, 27, 51, 388, DateTimeKind.Unspecified).AddTicks(3669), 7L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 363L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Expedita et non soluta officiis porro quod dolorem repellendus a.", new DateTime(2020, 3, 25, 8, 40, 23, 599, DateTimeKind.Unspecified).AddTicks(4753), 10L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 364L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Accusamus quos dolores doloribus officiis et dicta officia eius quia.", new DateTime(2020, 8, 15, 5, 1, 3, 80, DateTimeKind.Unspecified).AddTicks(3878), 8L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 365L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 6m, "Voluptatem sed ut eos enim quaerat atque voluptas ad doloribus.", new DateTime(2020, 8, 13, 23, 45, 17, 405, DateTimeKind.Unspecified).AddTicks(4708), 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 366L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Beatae et deserunt dicta voluptas dolorem labore dolor architecto qui.", new DateTime(2020, 3, 19, 5, 37, 32, 647, DateTimeKind.Unspecified).AddTicks(2693), 6L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 367L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Qui dicta explicabo tempore aspernatur ab ratione dolore eligendi et.", new DateTime(2020, 12, 25, 10, 31, 38, 567, DateTimeKind.Unspecified).AddTicks(952), 5L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 368L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Eius molestias amet corporis esse ut molestias exercitationem provident et.", new DateTime(2020, 3, 18, 19, 11, 4, 33, DateTimeKind.Unspecified).AddTicks(3914), 5L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 369L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Laudantium nobis impedit impedit minima velit dolor amet saepe magni.", new DateTime(2020, 6, 15, 8, 56, 55, 291, DateTimeKind.Unspecified).AddTicks(7431), 6L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 370L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Incidunt delectus cumque deleniti laborum dolores sapiente error in consequuntur.", new DateTime(2020, 1, 14, 19, 12, 46, 152, DateTimeKind.Unspecified).AddTicks(8537), 3L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 371L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 3m, "Omnis deserunt enim nemo mollitia corporis repellendus aut sint tempore.", new DateTime(2020, 7, 24, 4, 28, 31, 851, DateTimeKind.Unspecified).AddTicks(9843), 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 372L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Laborum illo fugiat magnam et cum et similique et aut.", new DateTime(2020, 12, 6, 2, 38, 0, 67, DateTimeKind.Unspecified).AddTicks(7552), 3L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 373L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Veniam qui occaecati sed at necessitatibus harum corporis qui neque.", new DateTime(2020, 11, 18, 17, 44, 3, 605, DateTimeKind.Unspecified).AddTicks(563), 7L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 374L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Ab accusantium ea vel quia non hic ut nostrum itaque.", new DateTime(2020, 1, 17, 21, 38, 43, 500, DateTimeKind.Unspecified).AddTicks(64), 3L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 375L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Temporibus et consequuntur ad nihil necessitatibus est sit sequi debitis.", new DateTime(2020, 3, 23, 12, 53, 13, 753, DateTimeKind.Unspecified).AddTicks(5696), 12L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 376L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Incidunt libero nobis magni harum voluptas sint est deleniti consequatur.", new DateTime(2020, 5, 25, 20, 21, 48, 63, DateTimeKind.Unspecified).AddTicks(4414), 2L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 377L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Exercitationem qui doloribus aut nam facilis excepturi reprehenderit aperiam nostrum.", new DateTime(2020, 12, 13, 3, 18, 12, 707, DateTimeKind.Unspecified).AddTicks(8988), 4L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 378L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 6m, "Officiis cupiditate accusamus dolorem provident rerum fugit dolorum aliquam vitae.", new DateTime(2020, 7, 1, 9, 43, 4, 937, DateTimeKind.Unspecified).AddTicks(8764), 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 379L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Tenetur omnis neque voluptatum earum temporibus eaque similique rerum ut.", new DateTime(2020, 6, 21, 9, 17, 24, 207, DateTimeKind.Unspecified).AddTicks(5885), 5L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 380L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Quidem reprehenderit dolorem voluptatum ut et ut tenetur dolores rerum.", new DateTime(2020, 10, 19, 16, 16, 2, 382, DateTimeKind.Unspecified).AddTicks(9250), 5L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 381L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Voluptas voluptates est minima quia dolores odio ad consequuntur eum.", new DateTime(2020, 10, 28, 2, 17, 50, 282, DateTimeKind.Unspecified).AddTicks(2828), 3L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 382L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Quidem eveniet autem dolor nulla ad maiores eos aliquam est.", new DateTime(2020, 9, 6, 12, 43, 14, 770, DateTimeKind.Unspecified).AddTicks(9401), 1L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 383L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Voluptatem eius veritatis quidem ut consequatur labore reiciendis et explicabo.", new DateTime(2020, 2, 12, 15, 20, 0, 83, DateTimeKind.Unspecified).AddTicks(9610), 7L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 384L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Ut asperiores quaerat quidem sed mollitia ipsam mollitia voluptatem harum.", new DateTime(2020, 5, 27, 10, 28, 6, 884, DateTimeKind.Unspecified).AddTicks(3567), 6L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 385L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Et hic et molestias vel odio aut et assumenda culpa.", new DateTime(2020, 9, 8, 16, 34, 54, 166, DateTimeKind.Unspecified).AddTicks(6881), 9L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 386L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Expedita optio quia perspiciatis officiis fuga mollitia voluptatem sint in.", new DateTime(2020, 1, 24, 13, 51, 17, 298, DateTimeKind.Unspecified).AddTicks(7076), 7L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 387L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Et molestiae dolor nihil soluta est voluptas exercitationem at quasi.", new DateTime(2020, 9, 8, 18, 18, 52, 291, DateTimeKind.Unspecified).AddTicks(2136), 12L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 388L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Tempora soluta ut aut provident et earum blanditiis molestiae sint.", new DateTime(2020, 5, 9, 23, 52, 4, 707, DateTimeKind.Unspecified).AddTicks(3454), 9L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 389L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Iusto nulla a eos facere laboriosam voluptas laboriosam ea ipsam.", new DateTime(2020, 11, 15, 15, 36, 20, 518, DateTimeKind.Unspecified).AddTicks(8366), 8L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 390L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Nulla dolores dolorum voluptates ut ut aperiam quo dolores quod.", new DateTime(2020, 5, 1, 22, 14, 18, 477, DateTimeKind.Unspecified).AddTicks(5642), 12L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 391L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Alias quaerat placeat et ut itaque vero consequatur aut veritatis.", new DateTime(2020, 9, 22, 21, 23, 38, 730, DateTimeKind.Unspecified).AddTicks(3008), 3L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 392L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Minima officia ipsum et quia culpa laborum nostrum ullam omnis.", new DateTime(2020, 7, 9, 11, 19, 10, 850, DateTimeKind.Unspecified).AddTicks(4387), 10L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 393L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Ut numquam accusamus quisquam et tempora suscipit qui error sit.", new DateTime(2020, 5, 10, 9, 3, 27, 684, DateTimeKind.Unspecified).AddTicks(2236), 5L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 394L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Accusantium natus cumque aliquam porro ratione natus voluptates similique placeat.", new DateTime(2020, 7, 3, 9, 51, 47, 414, DateTimeKind.Unspecified).AddTicks(9059), 9L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 395L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Sapiente maiores dolorem ut qui voluptatem distinctio eveniet consectetur corrupti.", new DateTime(2020, 1, 1, 6, 19, 41, 665, DateTimeKind.Unspecified).AddTicks(3775), 5L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 396L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Voluptatem sequi at molestiae beatae est ut id veritatis sed.", new DateTime(2020, 7, 21, 10, 43, 51, 624, DateTimeKind.Unspecified).AddTicks(1131), 12L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 397L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Facilis quia aut rem tempora fuga sit in consectetur sed.", new DateTime(2020, 1, 14, 12, 36, 29, 170, DateTimeKind.Unspecified).AddTicks(5650), 10L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 398L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 2m, "Consequatur non eos molestiae deserunt molestiae rerum velit saepe dolor.", new DateTime(2020, 3, 6, 6, 9, 55, 780, DateTimeKind.Unspecified).AddTicks(6854), 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 399L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Molestiae quis aliquid quis modi modi aliquam quasi voluptatum et.", new DateTime(2020, 6, 12, 1, 5, 37, 991, DateTimeKind.Unspecified).AddTicks(5569), 1L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 400L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Delectus minus fugit quo mollitia eos quis pariatur cum corrupti.", new DateTime(2020, 12, 15, 23, 26, 26, 986, DateTimeKind.Unspecified).AddTicks(6570), 8L, 13L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 1L, 15L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2L, 8L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2L, 18L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3L, 2L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3L, 4L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3L, 13L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3L, 18L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4L, 1L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4L, 3L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4L, 16L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5L, 1L });

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
                keyValues: new object[] { 5L, 11L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 7L, 3L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 7L, 5L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 7L, 6L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 7L, 10L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 7L, 14L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 7L, 15L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 7L, 20L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 8L, 3L });

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
                keyValues: new object[] { 8L, 16L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 9L, 2L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 9L, 3L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 9L, 14L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 9L, 19L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 10L, 2L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 10L, 8L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 10L, 20L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 11L, 1L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 11L, 6L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 12L, 6L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 12L, 9L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 12L, 11L });

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
                    { 1L, 6L },
                    { 6L, 6L },
                    { 4L, 13L },
                    { 11L, 18L },
                    { 6L, 5L },
                    { 6L, 9L },
                    { 2L, 14L },
                    { 10L, 11L },
                    { 9L, 16L },
                    { 7L, 17L },
                    { 5L, 8L },
                    { 9L, 10L },
                    { 6L, 1L },
                    { 4L, 14L },
                    { 6L, 15L },
                    { 2L, 7L },
                    { 11L, 5L },
                    { 10L, 17L },
                    { 7L, 4L },
                    { 3L, 5L },
                    { 9L, 12L },
                    { 8L, 12L },
                    { 4L, 7L },
                    { 10L, 12L },
                    { 1L, 1L },
                    { 9L, 18L },
                    { 3L, 8L },
                    { 9L, 5L },
                    { 8L, 14L },
                    { 5L, 19L },
                    { 4L, 11L },
                    { 1L, 3L },
                    { 6L, 19L },
                    { 7L, 9L },
                    { 10L, 18L },
                    { 4L, 10L },
                    { 2L, 5L }
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
                columns: new[] { "PricePerHour", "ProjectName" },
                values: new object[] { 523.98m, "Cross-group foreground frame" });

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
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 6L, 516.77m, "Intuitive dynamic hierarchy" });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Officia excepturi quisquam veritatis laborum quia voluptas magnam facilis vel.", new DateTime(2020, 9, 2, 2, 4, 40, 921, DateTimeKind.Unspecified).AddTicks(6877), 6L, 4L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Id quos possimus repellat omnis et aut cupiditate ipsam praesentium.", new DateTime(2020, 12, 21, 18, 22, 14, 827, DateTimeKind.Unspecified).AddTicks(1901), 11L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 9L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 56m, "Enim consequatur similique aut consequatur pariatur ut consequuntur dolore aperiam.", new DateTime(2020, 4, 28, 17, 49, 59, 707, DateTimeKind.Unspecified).AddTicks(8524), 3L, 7L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 45m, "Aspernatur autem adipisci rerum et error in et in ex.", new DateTime(2020, 6, 18, 11, 42, 1, 990, DateTimeKind.Unspecified).AddTicks(1356), 8L, 3L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 6m, "Magni modi ex placeat et nisi velit minus aliquid vel.", new DateTime(2020, 10, 31, 23, 14, 50, 798, DateTimeKind.Unspecified).AddTicks(6807), 3L });

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
                columns: new[] { "Comment", "Date", "ProjectId" },
                values: new object[] { "Consequatur saepe quo sunt dicta tenetur tempore doloribus quas rerum.", new DateTime(2020, 1, 31, 10, 12, 16, 989, DateTimeKind.Unspecified).AddTicks(9310), 4L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Nihil tenetur id eius officia soluta aut consequatur laboriosam est.", new DateTime(2020, 7, 13, 18, 4, 45, 907, DateTimeKind.Unspecified).AddTicks(1901), 5L, 11L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 36m, "Mollitia pariatur est mollitia molestiae et nobis quis rem quisquam.", new DateTime(2020, 6, 25, 20, 9, 58, 748, DateTimeKind.Unspecified).AddTicks(8012), 19L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 17m, "Officiis consectetur rerum rerum cupiditate rerum quia repellendus recusandae quos.", new DateTime(2020, 11, 23, 8, 40, 46, 438, DateTimeKind.Unspecified).AddTicks(8203), 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 32L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 22m, "Optio et sint quia aliquam sed in aspernatur dolorem nisi.", new DateTime(2020, 1, 20, 14, 42, 41, 814, DateTimeKind.Unspecified).AddTicks(2255), 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 33L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Corporis placeat cupiditate vitae perspiciatis dolor quisquam optio quo fugit.", new DateTime(2020, 5, 19, 12, 20, 53, 329, DateTimeKind.Unspecified).AddTicks(9757), 10L, 1L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 17m, "Sed rerum quis dicta commodi dolore fugiat ipsa aperiam autem.", new DateTime(2020, 1, 22, 18, 31, 7, 707, DateTimeKind.Unspecified).AddTicks(3014), 3L, 15L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 46m, "Soluta sed tempora quia rerum ipsa ab reprehenderit accusantium iusto.", new DateTime(2020, 2, 7, 15, 8, 21, 708, DateTimeKind.Unspecified).AddTicks(3079), 6L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 42L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 45m, "Commodi quisquam exercitationem est iusto commodi et numquam distinctio ea.", new DateTime(2020, 5, 14, 9, 24, 21, 984, DateTimeKind.Unspecified).AddTicks(4013), 11L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 28m, "Praesentium dolorem eum ut illo a rerum praesentium praesentium recusandae.", new DateTime(2020, 9, 10, 17, 7, 0, 878, DateTimeKind.Unspecified).AddTicks(650), 11L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 44m, "Dolores rem dolor ea vel saepe qui quod sed totam.", new DateTime(2020, 6, 7, 18, 14, 6, 745, DateTimeKind.Unspecified).AddTicks(1863), 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 48L,
                columns: new[] { "AmountOfHours", "Comment", "Date" },
                values: new object[] { 33m, "Consequatur et quidem vero sit non error neque quo similique.", new DateTime(2020, 3, 8, 19, 28, 0, 329, DateTimeKind.Unspecified).AddTicks(664) });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 49L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Sequi alias a fuga cupiditate modi quia maiores facere deleniti.", new DateTime(2020, 4, 6, 15, 43, 41, 678, DateTimeKind.Unspecified).AddTicks(6648), 11L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 50L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 25m, "Inventore quia tempora debitis placeat et culpa accusamus consectetur non.", new DateTime(2021, 1, 1, 7, 55, 5, 166, DateTimeKind.Unspecified).AddTicks(9850), 5L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 11m, "Quas ea voluptas dolorem fugiat laborum labore id est pariatur.", new DateTime(2020, 10, 15, 4, 41, 22, 709, DateTimeKind.Unspecified).AddTicks(3605), 15L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 37m, "Beatae modi animi veniam saepe voluptas officia omnis corrupti provident.", new DateTime(2020, 10, 28, 7, 2, 54, 397, DateTimeKind.Unspecified).AddTicks(6443), 8L, 8L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 16m, "Unde harum dolor non officiis numquam rerum adipisci repellendus recusandae.", new DateTime(2020, 5, 16, 12, 41, 6, 545, DateTimeKind.Unspecified).AddTicks(7655), 9L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 9m, "Nobis architecto culpa qui quia in repellat voluptatum et et.", new DateTime(2020, 11, 2, 3, 3, 33, 333, DateTimeKind.Unspecified).AddTicks(7102), 10L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 70L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 32m, "Odit ad doloremque perspiciatis cum quis aut sunt reiciendis commodi.", new DateTime(2020, 11, 5, 8, 32, 44, 482, DateTimeKind.Unspecified).AddTicks(3918), 5L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Ex perspiciatis molestias qui itaque quod ea impedit sapiente numquam.", new DateTime(2020, 3, 27, 10, 7, 3, 53, DateTimeKind.Unspecified).AddTicks(700), 10L, 5L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 53m, "Repellat voluptas vero placeat et dicta iste dolorem sed laudantium.", new DateTime(2020, 1, 22, 23, 30, 56, 707, DateTimeKind.Unspecified).AddTicks(9461), 3L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 88L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 15m, "Harum repudiandae eligendi minus libero similique iure enim velit non.", new DateTime(2020, 2, 28, 13, 30, 7, 139, DateTimeKind.Unspecified).AddTicks(1108), 2L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 44m, "Magni sit distinctio voluptas et quibusdam deserunt laboriosam maiores non.", new DateTime(2020, 6, 28, 11, 0, 35, 694, DateTimeKind.Unspecified).AddTicks(3062), 9L, 10L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 19m, "Rerum quia optio dolor est repellendus aut qui ullam minus.", new DateTime(2020, 5, 10, 13, 33, 34, 289, DateTimeKind.Unspecified).AddTicks(7476), 5L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 99L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 59m, "Consectetur aspernatur fugiat quas sapiente quia voluptas et magni repudiandae.", new DateTime(2020, 11, 19, 6, 44, 25, 242, DateTimeKind.Unspecified).AddTicks(1230), 3L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 22m, "Et iste fuga quidem dolor qui cupiditate ea qui debitis.", new DateTime(2020, 2, 3, 19, 57, 4, 329, DateTimeKind.Unspecified).AddTicks(1027), 7L, 9L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 17m, "Accusamus quas et omnis qui porro voluptatum ratione est voluptatem.", new DateTime(2020, 10, 4, 19, 26, 40, 984, DateTimeKind.Unspecified).AddTicks(9383), 14L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 23m, "Sint reiciendis repellendus qui eligendi labore corrupti hic voluptatem voluptatem.", new DateTime(2020, 12, 28, 19, 1, 54, 156, DateTimeKind.Unspecified).AddTicks(2289), 10L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 118L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 47m, "Dolorum suscipit at veritatis et fuga autem repellendus hic non.", new DateTime(2020, 11, 24, 23, 24, 32, 961, DateTimeKind.Unspecified).AddTicks(9687), 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 119L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Adipisci at quis id qui vitae et autem consequatur voluptas.", new DateTime(2020, 2, 10, 2, 5, 31, 289, DateTimeKind.Unspecified).AddTicks(9520), 12L, 5L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 13m, "Rerum magnam minima commodi deleniti eveniet voluptas autem natus aliquam.", new DateTime(2020, 11, 20, 10, 46, 44, 401, DateTimeKind.Unspecified).AddTicks(2489), 18L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date" },
                values: new object[] { 10m, "Non quo ut dolores officia non aliquam omnis qui accusantium.", new DateTime(2020, 1, 24, 6, 49, 38, 710, DateTimeKind.Unspecified).AddTicks(6301) });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 127L,
                columns: new[] { "AmountOfHours", "Comment", "Date" },
                values: new object[] { 7m, "Modi reprehenderit aliquid consectetur sapiente perferendis est officia quidem nam.", new DateTime(2020, 3, 18, 20, 24, 35, 569, DateTimeKind.Unspecified).AddTicks(4731) });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 24m, "Iure deserunt delectus consequatur voluptas nisi dolor perspiciatis quidem eos.", new DateTime(2020, 7, 1, 0, 59, 57, 829, DateTimeKind.Unspecified).AddTicks(9336), 1L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Pariatur eum quos ut sint velit sed ipsa cumque nemo.", new DateTime(2020, 10, 28, 20, 23, 38, 313, DateTimeKind.Unspecified).AddTicks(547), 11L, 16L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 13m, "Hic nam impedit voluptates dolorum eum officiis totam possimus voluptas.", new DateTime(2020, 6, 9, 12, 26, 46, 305, DateTimeKind.Unspecified).AddTicks(7318), 8L, 7L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Iusto enim repellat natus sequi consequuntur esse omnis et quia.", new DateTime(2020, 2, 13, 5, 38, 13, 426, DateTimeKind.Unspecified).AddTicks(2877), 3L, 15L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 18m, "Doloribus et possimus magnam voluptatem quo ullam quam asperiores ullam.", new DateTime(2020, 11, 22, 7, 11, 47, 818, DateTimeKind.Unspecified).AddTicks(6499), 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 144L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Sapiente non assumenda odit nihil culpa error dignissimos aperiam alias.", new DateTime(2020, 6, 22, 13, 6, 0, 865, DateTimeKind.Unspecified).AddTicks(9249), 2L, 13L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 36m, "In qui illum pariatur omnis officiis corrupti nulla reprehenderit aut.", new DateTime(2020, 12, 15, 12, 2, 25, 180, DateTimeKind.Unspecified).AddTicks(6449), 10L, 5L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date" },
                values: new object[] { 21m, "Aut exercitationem eos architecto esse ab libero dolor officia enim.", new DateTime(2020, 12, 26, 20, 51, 10, 923, DateTimeKind.Unspecified).AddTicks(8864) });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 10m, "Voluptas beatae dolore quia saepe dolore nulla omnis dolores iusto.", new DateTime(2020, 4, 1, 23, 37, 51, 198, DateTimeKind.Unspecified).AddTicks(9188), 10L, 3L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 49m, "Tempore ut ipsum officia nam magnam sunt consequuntur eum et.", new DateTime(2020, 6, 30, 18, 34, 43, 540, DateTimeKind.Unspecified).AddTicks(7718), 1L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 20m, "Itaque fugit est laudantium nesciunt est voluptatum qui sit ut.", new DateTime(2020, 5, 9, 6, 8, 45, 613, DateTimeKind.Unspecified).AddTicks(8964), 6L, 12L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Sit placeat omnis et fugiat ratione molestiae harum assumenda quaerat.", new DateTime(2020, 12, 22, 3, 55, 9, 362, DateTimeKind.Unspecified).AddTicks(4225), 11L, 16L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Non nostrum animi ut sed mollitia eos velit perferendis corrupti.", new DateTime(2020, 8, 12, 20, 55, 48, 424, DateTimeKind.Unspecified).AddTicks(913), 11L, 20L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Eos illum expedita modi nihil a et iusto id voluptates.", new DateTime(2020, 9, 13, 4, 41, 10, 535, DateTimeKind.Unspecified).AddTicks(5782), 12L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 187L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 47m, "Hic corrupti voluptatum omnis unde magnam ea explicabo qui enim.", new DateTime(2020, 5, 22, 7, 28, 28, 193, DateTimeKind.Unspecified).AddTicks(3490), 11L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 24m, "Numquam explicabo aut quia est molestiae neque quisquam aut quaerat.", new DateTime(2020, 9, 5, 12, 3, 59, 724, DateTimeKind.Unspecified).AddTicks(2480), 19L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 15m, "Architecto sit nihil id perspiciatis ad facere enim rerum voluptate.", new DateTime(2020, 11, 14, 21, 47, 26, 247, DateTimeKind.Unspecified).AddTicks(1612), 12L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 60m, "Et nemo quam qui ab atque quo sit id doloremque.", new DateTime(2020, 9, 22, 13, 53, 33, 80, DateTimeKind.Unspecified).AddTicks(9927), 7L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 209L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Enim voluptatem velit tempore modi voluptatem voluptatibus quisquam ut quis.", new DateTime(2020, 11, 27, 3, 9, 43, 801, DateTimeKind.Unspecified).AddTicks(9886), 12L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 210L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 9m, "Autem laborum dolorem nesciunt unde voluptas accusantium suscipit doloribus hic.", new DateTime(2020, 1, 5, 13, 14, 26, 340, DateTimeKind.Unspecified).AddTicks(5923), 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 211L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Fugit in sunt aut officia quia est repellendus saepe odit.", new DateTime(2020, 11, 8, 5, 9, 36, 305, DateTimeKind.Unspecified).AddTicks(9285), 2L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 212L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 31m, "Voluptas quae laudantium tempore rem nobis aut asperiores quia ea.", new DateTime(2020, 1, 4, 22, 20, 30, 899, DateTimeKind.Unspecified).AddTicks(3222), 3L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Consectetur nobis nemo ducimus dolores harum facere facilis rerum voluptatibus.", new DateTime(2020, 4, 27, 16, 46, 41, 888, DateTimeKind.Unspecified).AddTicks(6996), 1L, 4L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 8m, "Facilis labore ut qui ad sit fugit esse sit autem.", new DateTime(2020, 3, 11, 19, 1, 24, 449, DateTimeKind.Unspecified).AddTicks(72), 13L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 30m, "Minima occaecati nihil assumenda rerum saepe nulla rerum placeat est.", new DateTime(2020, 11, 15, 15, 5, 2, 605, DateTimeKind.Unspecified).AddTicks(3041), 7L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 44m, "Magnam quia numquam qui itaque qui assumenda hic harum hic.", new DateTime(2020, 9, 18, 18, 21, 9, 599, DateTimeKind.Unspecified).AddTicks(2599), 18L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Dolor molestiae fugit nobis harum aut saepe quia ullam perferendis.", new DateTime(2020, 6, 24, 19, 14, 43, 335, DateTimeKind.Unspecified).AddTicks(2799), 9L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 237L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 54m, "Consequuntur mollitia omnis qui dolores fugiat provident ut ducimus qui.", new DateTime(2020, 2, 22, 22, 46, 41, 735, DateTimeKind.Unspecified).AddTicks(3812), 3L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 23m, "Saepe quia repudiandae non nemo asperiores cumque cupiditate dolorum vel.", new DateTime(2020, 7, 12, 14, 26, 57, 855, DateTimeKind.Unspecified).AddTicks(6357), 1L, 13L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 29m, "Blanditiis eos explicabo nostrum inventore laudantium numquam laudantium totam dolorem.", new DateTime(2020, 2, 1, 23, 54, 57, 755, DateTimeKind.Unspecified).AddTicks(9342), 3L, 20L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 29m, "Unde ut suscipit omnis eos aliquid quia et eum ut.", new DateTime(2020, 3, 8, 10, 31, 58, 457, DateTimeKind.Unspecified).AddTicks(3916), 12L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 43m, "Rerum itaque voluptates ea veniam minus repudiandae et quos ducimus.", new DateTime(2020, 11, 19, 15, 13, 16, 818, DateTimeKind.Unspecified).AddTicks(7170), 17L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 24m, "Eos eos magni reprehenderit tempora occaecati sit consequatur corporis voluptatum.", new DateTime(2020, 2, 13, 10, 57, 22, 69, DateTimeKind.Unspecified).AddTicks(7679), 6L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 262L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 36m, "Optio impedit enim quae natus dolor eos qui delectus sed.", new DateTime(2020, 6, 11, 13, 12, 52, 896, DateTimeKind.Unspecified).AddTicks(9632), 10L, 18L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 35m, "Ipsam veniam id et saepe omnis quia porro ullam ipsam.", new DateTime(2020, 7, 7, 0, 51, 39, 42, DateTimeKind.Unspecified).AddTicks(2949), 19L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 43m, "Aspernatur ut asperiores atque ut et consectetur eveniet eveniet neque.", new DateTime(2020, 4, 9, 13, 42, 44, 963, DateTimeKind.Unspecified).AddTicks(2043), 6L, 5L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Minus iusto nihil harum reprehenderit minima accusamus quos pariatur perferendis.", new DateTime(2020, 10, 16, 14, 34, 52, 57, DateTimeKind.Unspecified).AddTicks(7309), 9L, 18L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 18m, "Et enim vitae velit est necessitatibus in at ex in.", new DateTime(2020, 7, 23, 12, 30, 20, 886, DateTimeKind.Unspecified).AddTicks(5837), 12L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 27m, "Necessitatibus dolor id et dignissimos occaecati quo placeat illum aut.", new DateTime(2020, 8, 28, 10, 44, 20, 475, DateTimeKind.Unspecified).AddTicks(9784), 2L, 19L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 46m, "Ex dolor fugit beatae fugit quidem voluptatem quae sint reprehenderit.", new DateTime(2020, 12, 6, 10, 4, 47, 622, DateTimeKind.Unspecified).AddTicks(3018), 7L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 295L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 32m, "Laudantium qui repellendus quo est rem incidunt tenetur quas rerum.", new DateTime(2020, 2, 18, 10, 43, 23, 232, DateTimeKind.Unspecified).AddTicks(4345), 4L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 296L,
                columns: new[] { "Comment", "Date", "ProjectId" },
                values: new object[] { "Quia sunt dolorem vel blanditiis aliquid voluptas porro eaque et.", new DateTime(2020, 1, 3, 0, 44, 17, 503, DateTimeKind.Unspecified).AddTicks(2694), 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 297L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 35m, "Quibusdam aut porro voluptates voluptatum sed molestiae quos molestiae sed.", new DateTime(2020, 10, 12, 19, 50, 56, 224, DateTimeKind.Unspecified).AddTicks(9636), 6L, 10L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 45m, "Aut sint nihil magnam eligendi est nesciunt dolores et ex.", new DateTime(2020, 9, 13, 12, 33, 17, 348, DateTimeKind.Unspecified).AddTicks(1895), 10L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 22m, "Odio error harum optio quo nobis reprehenderit excepturi aut dolor.", new DateTime(2020, 9, 18, 5, 13, 38, 269, DateTimeKind.Unspecified).AddTicks(6132), 10L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 302L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 10m, "Omnis blanditiis id neque et adipisci omnis minima quia ad.", new DateTime(2020, 3, 28, 23, 26, 41, 703, DateTimeKind.Unspecified).AddTicks(5356), 12L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 19m, "Doloribus molestias voluptatibus placeat id qui eos est voluptatem mollitia.", new DateTime(2020, 7, 5, 9, 40, 1, 338, DateTimeKind.Unspecified).AddTicks(2284), 8L, 1L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 56m, "Sunt ut consequatur dolorem voluptas quasi eaque eum cupiditate consequatur.", new DateTime(2020, 5, 30, 15, 46, 13, 21, DateTimeKind.Unspecified).AddTicks(7185), 2L, 3L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Sint voluptas et et voluptas libero recusandae nisi ut magni.", new DateTime(2020, 3, 8, 6, 48, 50, 257, DateTimeKind.Unspecified).AddTicks(7848), 8L, 18L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 43m, "A hic aliquid molestias ipsum est mollitia quis tenetur velit.", new DateTime(2020, 4, 9, 19, 49, 29, 458, DateTimeKind.Unspecified).AddTicks(634), 5L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 34m, "Pariatur sit sint aperiam eos ea maxime officiis et maxime.", new DateTime(2020, 2, 29, 22, 57, 24, 442, DateTimeKind.Unspecified).AddTicks(5372), 2L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 32m, "Laborum suscipit nobis non expedita numquam et dolorum tempora laudantium.", new DateTime(2020, 5, 6, 15, 2, 48, 35, DateTimeKind.Unspecified).AddTicks(6859), 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 341L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 41m, "Ut quia omnis veniam non recusandae non id corrupti quae.", new DateTime(2020, 3, 12, 6, 50, 1, 172, DateTimeKind.Unspecified).AddTicks(1055), 11L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 342L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 25m, "Totam sit at cum inventore numquam quaerat exercitationem inventore non.", new DateTime(2020, 11, 15, 3, 5, 31, 694, DateTimeKind.Unspecified).AddTicks(419), 12L, 7L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Officiis possimus dolor magni est aut voluptatibus ipsam asperiores placeat.", new DateTime(2020, 8, 19, 16, 2, 56, 822, DateTimeKind.Unspecified).AddTicks(9128), 1L, 6L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 23m, "Quos blanditiis veniam aut voluptatem veritatis distinctio cum amet et.", new DateTime(2020, 10, 12, 4, 38, 43, 820, DateTimeKind.Unspecified).AddTicks(6628), 7L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 34m, "Ut quae occaecati assumenda laudantium rerum et autem a et.", new DateTime(2020, 1, 25, 4, 58, 6, 248, DateTimeKind.Unspecified).AddTicks(6371), 11L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Quo velit consequuntur velit praesentium nihil sunt in qui voluptatem.", new DateTime(2020, 5, 18, 18, 23, 24, 906, DateTimeKind.Unspecified).AddTicks(7135), 5L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 375L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Consequatur facilis tempore non iusto rerum est aut fugit voluptatem.", new DateTime(2020, 1, 27, 7, 56, 27, 113, DateTimeKind.Unspecified).AddTicks(8751), 11L, 6L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 50m, "Dicta odit exercitationem adipisci est culpa pariatur mollitia iste at.", new DateTime(2020, 4, 9, 2, 0, 51, 576, DateTimeKind.Unspecified).AddTicks(1603), 13L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 34m, "Dolorem libero eveniet expedita fugit id et ipsa quis est.", new DateTime(2020, 12, 26, 4, 58, 34, 885, DateTimeKind.Unspecified).AddTicks(6977), 10L, 5L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Id voluptas mollitia odit sapiente cumque saepe sunt perspiciatis temporibus.", new DateTime(2020, 5, 12, 7, 42, 48, 712, DateTimeKind.Unspecified).AddTicks(3592), 5L, 16L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 47m, "Fugit culpa qui dolor distinctio fugiat odio fugit eligendi quia.", new DateTime(2020, 2, 10, 14, 0, 0, 378, DateTimeKind.Unspecified).AddTicks(3893), 18L });

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
    }
}
