using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DiplomaProject.Migrations
{
    public partial class AddTwoPropertiesUserNameAndHashedPasswordInEmployeeModel : Migration
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
                keyValues: new object[] { 5L, 5L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5L, 11L });

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
                keyValues: new object[] { 6L, 19L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 8L, 4L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 8L, 5L });

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
                keyValues: new object[] { 10L, 7L });

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
                values: new object[] { "4148", "Odaborough", "Hermiston LLC", "Guinea-Bissau", "63001-7079", "Loren Walks" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 2L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "2786", "Lake Marlene", "Terry Group", "Singapore", "96935-8612", "Monahan Union" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 3L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "635", "North Obieton", "Heaney Group", "Dominican Republic", "64991", "Beaulah Fords" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 4L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "3812", "Gorczanyborough", "Casper Inc", "Oman", "51307", "Tre Circle" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 5L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "97011", "South Sydniefort", "Keeling, Mueller and Rau", "Malta", "27434-4993", "Kyler Park" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 6L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "7536", "East Lela", "Haley Inc", "Slovakia (Slovak Republic)", "31970-5011", "Quitzon Forges" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 7L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "2101", "Balistreriport", "Purdy, Towne and Cassin", "Cook Islands", "89552-7050", "Thompson Walk" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 8L,
                columns: new[] { "BuildingNumber", "City", "ClientName", "Country", "PostCode", "StreetName" },
                values: new object[] { "056", "Batzfurt", "Tillman, Moen and Huel", "New Caledonia", "14082-2084", "Strosin Meadow" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "Password", "PostCode", "StreetName", "UserName" },
                values: new object[] { "814", "South Obieview", "Belarus", new DateTime(1957, 12, 27, 17, 4, 6, 323, DateTimeKind.Unspecified).AddTicks(1880), "Marisa", "Senior Infrastructure Director", "McLaughlin", "tzHu8f1QbmXhbptFcXcYw3rlHEWAf7Ow/oMhqgJRMzm9/wIdAowtq3+tV7XUIn7C916CasZc+MCu1OZaea3zRA==", "06913-8295", "Runolfsdottir Flats", "Gregorio_Berge" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "Password", "PostCode", "StreetName", "UserName" },
                values: new object[] { "261", "Port Mohammedberg", "Somalia", new DateTime(1992, 5, 15, 9, 22, 57, 351, DateTimeKind.Unspecified).AddTicks(1044), "Travon", "International Branding Consultant", "Schuppe", "tzHu8f1QbmXhbptFcXcYw3rlHEWAf7Ow/oMhqgJRMzm9/wIdAowtq3+tV7XUIn7C916CasZc+MCu1OZaea3zRA==", "40242-6221", "Howell Valleys", "Abdul_Carroll" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "Password", "PostCode", "StreetName", "UserName" },
                values: new object[] { "131", "Erikafurt", "Poland", new DateTime(1957, 1, 9, 4, 50, 21, 899, DateTimeKind.Unspecified).AddTicks(4758), "Reyna", "Internal Functionality Administrator", "Abbott", "tzHu8f1QbmXhbptFcXcYw3rlHEWAf7Ow/oMhqgJRMzm9/wIdAowtq3+tV7XUIn7C916CasZc+MCu1OZaea3zRA==", "35348", "Berta Creek", "Liza_Botsford" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "Password", "PostCode", "StreetName", "UserName" },
                values: new object[] { "23260", "New Jennifer", "Equatorial Guinea", new DateTime(1968, 1, 13, 22, 8, 15, 290, DateTimeKind.Unspecified).AddTicks(2360), "Katlynn", "Internal Directives Specialist", "Weissnat", "tzHu8f1QbmXhbptFcXcYw3rlHEWAf7Ow/oMhqgJRMzm9/wIdAowtq3+tV7XUIn7C916CasZc+MCu1OZaea3zRA==", "10008", "Leonard Club", "Tristin_Botsford" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "Password", "PostCode", "StreetName", "UserName" },
                values: new object[] { "5279", "New Tatyanaview", "France", new DateTime(1976, 12, 9, 15, 53, 46, 57, DateTimeKind.Unspecified).AddTicks(5636), "Cody", "Senior Directives Facilitator", "Rosenbaum", "tzHu8f1QbmXhbptFcXcYw3rlHEWAf7Ow/oMhqgJRMzm9/wIdAowtq3+tV7XUIn7C916CasZc+MCu1OZaea3zRA==", "36923-5724", "Zboncak Glen", "Haley_Trantow57" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "Password", "PostCode", "StreetName", "UserName" },
                values: new object[] { "8672", "West Abdulbury", "China", new DateTime(1992, 8, 13, 15, 41, 26, 883, DateTimeKind.Unspecified).AddTicks(5802), "Jada", "Senior Brand Orchestrator", "Ward", "tzHu8f1QbmXhbptFcXcYw3rlHEWAf7Ow/oMhqgJRMzm9/wIdAowtq3+tV7XUIn7C916CasZc+MCu1OZaea3zRA==", "78110", "Trystan Landing", "Shayna.Kassulke" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 7L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "Password", "PostCode", "StreetName", "UserName" },
                values: new object[] { "697", "Schmelerhaven", "Bahamas", new DateTime(1978, 4, 14, 19, 57, 2, 5, DateTimeKind.Unspecified).AddTicks(8403), "Bertrand", "District Branding Specialist", "Ziemann", "tzHu8f1QbmXhbptFcXcYw3rlHEWAf7Ow/oMhqgJRMzm9/wIdAowtq3+tV7XUIn7C916CasZc+MCu1OZaea3zRA==", "09312-5649", "Matt Motorway", "Wilfredo57" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 8L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "Password", "PostCode", "StreetName", "UserName" },
                values: new object[] { "850", "Shieldsland", "French Polynesia", new DateTime(1997, 1, 15, 23, 45, 56, 494, DateTimeKind.Unspecified).AddTicks(3354), "Kennedy", "Internal Response Planner", "Reichel", "tzHu8f1QbmXhbptFcXcYw3rlHEWAf7Ow/oMhqgJRMzm9/wIdAowtq3+tV7XUIn7C916CasZc+MCu1OZaea3zRA==", "54948", "Jerde Circle", "Rosemary_Rutherford34" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 9L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "Password", "PostCode", "StreetName", "UserName" },
                values: new object[] { "7654", "West Lincoln", "Latvia", new DateTime(1995, 5, 22, 8, 29, 40, 415, DateTimeKind.Unspecified).AddTicks(4762), "Alysson", "Dynamic Division Representative", "Okuneva", "tzHu8f1QbmXhbptFcXcYw3rlHEWAf7Ow/oMhqgJRMzm9/wIdAowtq3+tV7XUIn7C916CasZc+MCu1OZaea3zRA==", "96559", "Gus Flats", "Emely.Champlin" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 10L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "Password", "PostCode", "StreetName", "UserName" },
                values: new object[] { "310", "Lake Marlee", "Thailand", new DateTime(1981, 4, 20, 17, 57, 24, 480, DateTimeKind.Unspecified).AddTicks(3344), "Edyth", "Legacy Accountability Agent", "Champlin", "tzHu8f1QbmXhbptFcXcYw3rlHEWAf7Ow/oMhqgJRMzm9/wIdAowtq3+tV7XUIn7C916CasZc+MCu1OZaea3zRA==", "88424-6416", "Jodie Road", "Tyree.Schneider" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 11L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "Password", "PostCode", "StreetName", "UserName" },
                values: new object[] { "74075", "South Ilianamouth", "Australia", new DateTime(1959, 2, 22, 7, 6, 16, 937, DateTimeKind.Unspecified).AddTicks(9258), "Alexandria", "Central Response Liaison", "Block", "tzHu8f1QbmXhbptFcXcYw3rlHEWAf7Ow/oMhqgJRMzm9/wIdAowtq3+tV7XUIn7C916CasZc+MCu1OZaea3zRA==", "47990-2568", "Zoie Extension", "Samanta.Durgan96" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 12L,
                columns: new[] { "BuildingNumber", "City", "Country", "DateOfBirth", "FirstName", "JobTitle", "LastName", "Password", "PostCode", "StreetName", "UserName" },
                values: new object[] { "62441", "Suzanneborough", "Bulgaria", new DateTime(1965, 7, 2, 4, 18, 59, 199, DateTimeKind.Unspecified).AddTicks(4876), "Rosetta", "Chief Branding Orchestrator", "Sawayn", "tzHu8f1QbmXhbptFcXcYw3rlHEWAf7Ow/oMhqgJRMzm9/wIdAowtq3+tV7XUIn7C916CasZc+MCu1OZaea3zRA==", "21991", "Omari Meadows", "Andres62" });

            migrationBuilder.InsertData(
                table: "EmployeeProject",
                columns: new[] { "EmployeeId", "ProjectId" },
                values: new object[,]
                {
                    { 10L, 19L },
                    { 8L, 17L },
                    { 3L, 17L },
                    { 8L, 6L },
                    { 12L, 1L },
                    { 3L, 16L },
                    { 7L, 9L },
                    { 8L, 9L },
                    { 7L, 15L },
                    { 11L, 12L },
                    { 11L, 8L },
                    { 5L, 8L },
                    { 11L, 3L },
                    { 2L, 8L },
                    { 1L, 3L },
                    { 3L, 15L },
                    { 2L, 14L },
                    { 10L, 15L },
                    { 4L, 8L },
                    { 3L, 12L },
                    { 7L, 4L },
                    { 12L, 11L },
                    { 7L, 18L },
                    { 9L, 15L },
                    { 11L, 14L },
                    { 9L, 20L },
                    { 5L, 3L },
                    { 3L, 20L },
                    { 6L, 12L },
                    { 10L, 3L },
                    { 1L, 9L },
                    { 5L, 15L },
                    { 7L, 5L },
                    { 6L, 7L },
                    { 1L, 7L },
                    { 7L, 10L },
                    { 2L, 11L },
                    { 11L, 7L },
                    { 3L, 7L },
                    { 12L, 18L },
                    { 1L, 4L }
                });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 7L, 651.80m, "Business-focused grid-enabled intranet" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 4L, 592.99m, "User-centric systemic matrix" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 3L,
                columns: new[] { "PricePerHour", "ProjectName" },
                values: new object[] { 544.29m, "Fully-configurable human-resource project" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 4L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 1L, 558.51m, "Integrated systemic structure" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 5L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 6L, 501.87m, "User-friendly asynchronous frame" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 6L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 6L, 858.42m, "Team-oriented homogeneous toolset" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 7L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 7L, 879.77m, "Cloned static time-frame" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 8L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 8L, 581.99m, "Profound 4th generation function" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 9L,
                columns: new[] { "PricePerHour", "ProjectName" },
                values: new object[] { 503.45m, "Pre-emptive well-modulated task-force" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 10L,
                columns: new[] { "PricePerHour", "ProjectName" },
                values: new object[] { 636.22m, "Implemented fresh-thinking collaboration" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 11L,
                columns: new[] { "PricePerHour", "ProjectName" },
                values: new object[] { 790.20m, "Polarised tangible synergy" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 12L,
                columns: new[] { "PricePerHour", "ProjectName" },
                values: new object[] { 832.15m, "Virtual analyzing internet solution" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 13L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 3L, 731.87m, "Multi-channelled tertiary success" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 14L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 2L, 663.18m, "Multi-lateral interactive algorithm" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 15L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 4L, 593.94m, "Grass-roots homogeneous paradigm" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 16L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 3L, 627.34m, "Visionary bottom-line forecast" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 17L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 1L, 651.52m, "Multi-layered discrete open architecture" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 18L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 7L, 540.13m, "Distributed upward-trending function" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 19L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 4L, 641.41m, "Organized hybrid paradigm" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 20L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 3L, 835.10m, "Re-contextualized asymmetric info-mediaries" });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 1L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Decentralized object-oriented groupware", new DateTime(2020, 7, 28, 0, 28, 50, 235, DateTimeKind.Unspecified).AddTicks(5566), 5L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 2L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Synergized local synergy", new DateTime(2020, 11, 12, 16, 0, 9, 385, DateTimeKind.Unspecified).AddTicks(6394), 3L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 3L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Organized tangible approach", new DateTime(2020, 3, 19, 6, 44, 1, 814, DateTimeKind.Unspecified).AddTicks(4890), 3L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 4L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Focused reciprocal software", new DateTime(2020, 8, 21, 18, 12, 21, 497, DateTimeKind.Unspecified).AddTicks(3564), 3L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 5L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Total object-oriented archive", new DateTime(2020, 12, 17, 2, 49, 0, 459, DateTimeKind.Unspecified).AddTicks(3858), 12L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 6L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Streamlined optimizing standardization", new DateTime(2020, 5, 6, 3, 52, 12, 680, DateTimeKind.Unspecified).AddTicks(2989), 12L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 7L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Multi-layered neutral artificial intelligence", new DateTime(2020, 5, 9, 20, 13, 55, 96, DateTimeKind.Unspecified).AddTicks(9058), 7L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 8L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Universal stable budgetary management", new DateTime(2020, 3, 27, 7, 40, 14, 938, DateTimeKind.Unspecified).AddTicks(4195), 12L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 9L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 7m, "User-friendly local collaboration", new DateTime(2020, 3, 7, 16, 16, 3, 709, DateTimeKind.Unspecified).AddTicks(7333), 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 10L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 8m, "Streamlined secondary collaboration", new DateTime(2020, 12, 29, 14, 1, 35, 638, DateTimeKind.Unspecified).AddTicks(617), 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 11L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 6m, "Customizable composite contingency", new DateTime(2020, 2, 13, 2, 53, 20, 220, DateTimeKind.Unspecified).AddTicks(1173), 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 12L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Centralized optimal migration", new DateTime(2020, 7, 30, 9, 52, 28, 313, DateTimeKind.Unspecified).AddTicks(5374), 6L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 13L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Total value-added approach", new DateTime(2020, 7, 6, 23, 49, 17, 508, DateTimeKind.Unspecified).AddTicks(2925), 11L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 14L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 8m, "Devolved national extranet", new DateTime(2020, 5, 23, 19, 3, 4, 297, DateTimeKind.Unspecified).AddTicks(1480), 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 15L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Synergized uniform productivity", new DateTime(2020, 2, 16, 11, 24, 4, 661, DateTimeKind.Unspecified).AddTicks(1566), 9L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 16L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Pre-emptive uniform archive", new DateTime(2020, 7, 4, 3, 27, 17, 480, DateTimeKind.Unspecified).AddTicks(3214), 8L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 17L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Stand-alone intermediate collaboration", new DateTime(2020, 1, 16, 12, 0, 21, 834, DateTimeKind.Unspecified).AddTicks(9449), 3L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 18L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Synergized background strategy", new DateTime(2021, 1, 1, 21, 10, 57, 876, DateTimeKind.Unspecified).AddTicks(85), 9L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 19L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Operative transitional task-force", new DateTime(2020, 11, 11, 4, 4, 2, 328, DateTimeKind.Unspecified).AddTicks(8741), 12L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 20L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Stand-alone static portal", new DateTime(2020, 3, 5, 7, 22, 34, 280, DateTimeKind.Unspecified).AddTicks(401), 8L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 21L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 3m, "Assimilated zero defect database", new DateTime(2020, 3, 15, 11, 43, 17, 774, DateTimeKind.Unspecified).AddTicks(4761), 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 22L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Cross-platform bandwidth-monitored paradigm", new DateTime(2020, 1, 3, 3, 44, 46, 816, DateTimeKind.Unspecified).AddTicks(4528), 11L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 23L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Secured uniform algorithm", new DateTime(2020, 9, 16, 18, 19, 52, 289, DateTimeKind.Unspecified).AddTicks(1179), 5L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 24L,
                columns: new[] { "Comment", "Date", "ProjectId" },
                values: new object[] { "Adaptive bottom-line parallelism", new DateTime(2020, 10, 21, 0, 42, 18, 742, DateTimeKind.Unspecified).AddTicks(7789), 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 25L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Reactive heuristic leverage", new DateTime(2020, 9, 3, 5, 12, 27, 87, DateTimeKind.Unspecified).AddTicks(5812), 6L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 26L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Cross-platform mission-critical capability", new DateTime(2020, 9, 1, 2, 22, 32, 887, DateTimeKind.Unspecified).AddTicks(7909), 5L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 27L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Seamless composite algorithm", new DateTime(2020, 8, 18, 15, 16, 35, 154, DateTimeKind.Unspecified).AddTicks(8773), 4L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 28L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Upgradable next generation conglomeration", new DateTime(2020, 3, 14, 13, 58, 3, 677, DateTimeKind.Unspecified).AddTicks(1916), 5L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 29L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 1m, "Streamlined intangible Graphic Interface", new DateTime(2020, 3, 6, 8, 24, 58, 810, DateTimeKind.Unspecified).AddTicks(2845), 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 30L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Progressive bi-directional Graphical User Interface", new DateTime(2020, 5, 6, 4, 32, 12, 851, DateTimeKind.Unspecified).AddTicks(7111), 4L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 31L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Front-line tangible access", new DateTime(2020, 3, 1, 7, 11, 36, 198, DateTimeKind.Unspecified).AddTicks(4353), 10L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 32L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Upgradable neutral service-desk", new DateTime(2020, 9, 9, 17, 3, 40, 584, DateTimeKind.Unspecified).AddTicks(4018), 5L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 33L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Reduced explicit array", new DateTime(2020, 12, 20, 23, 28, 26, 301, DateTimeKind.Unspecified).AddTicks(3187), 5L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 34L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Cloned optimizing success", new DateTime(2020, 10, 27, 2, 2, 49, 997, DateTimeKind.Unspecified).AddTicks(6866), 7L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 35L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Cloned mobile workforce", new DateTime(2020, 12, 24, 21, 5, 13, 6, DateTimeKind.Unspecified).AddTicks(1429), 6L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 36L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Stand-alone coherent local area network", new DateTime(2020, 5, 14, 5, 33, 22, 69, DateTimeKind.Unspecified).AddTicks(4289), 3L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 37L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Streamlined local architecture", new DateTime(2020, 10, 20, 13, 45, 51, 299, DateTimeKind.Unspecified).AddTicks(7113), 11L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 38L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Right-sized disintermediate task-force", new DateTime(2020, 8, 29, 22, 21, 31, 440, DateTimeKind.Unspecified).AddTicks(9774), 7L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 39L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 2m, "Customer-focused bandwidth-monitored definition", new DateTime(2020, 5, 15, 7, 39, 45, 734, DateTimeKind.Unspecified).AddTicks(315), 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 40L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Centralized stable utilisation", new DateTime(2020, 2, 9, 16, 51, 10, 535, DateTimeKind.Unspecified).AddTicks(7238), 6L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 41L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Devolved interactive challenge", new DateTime(2020, 2, 21, 10, 1, 16, 738, DateTimeKind.Unspecified).AddTicks(1508), 12L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 42L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Digitized scalable moderator", new DateTime(2020, 5, 28, 18, 46, 47, 195, DateTimeKind.Unspecified).AddTicks(1048), 11L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 43L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 3m, "Fully-configurable 6th generation strategy", new DateTime(2020, 3, 8, 10, 51, 26, 708, DateTimeKind.Unspecified).AddTicks(5490), 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 44L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Centralized discrete focus group", new DateTime(2020, 5, 29, 4, 43, 2, 243, DateTimeKind.Unspecified).AddTicks(7634), 10L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 45L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Re-contextualized attitude-oriented hardware", new DateTime(2020, 1, 14, 7, 0, 0, 780, DateTimeKind.Unspecified).AddTicks(6016), 10L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 46L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Right-sized real-time knowledge base", new DateTime(2020, 1, 5, 19, 18, 26, 140, DateTimeKind.Unspecified).AddTicks(3881), 4L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 47L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 8m, "Fully-configurable mobile utilisation", new DateTime(2020, 12, 21, 15, 8, 1, 935, DateTimeKind.Unspecified).AddTicks(3313), 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 48L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Seamless attitude-oriented portal", new DateTime(2020, 7, 18, 3, 36, 42, 172, DateTimeKind.Unspecified).AddTicks(8532), 8L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 49L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Ergonomic solution-oriented conglomeration", new DateTime(2020, 3, 22, 19, 35, 16, 797, DateTimeKind.Unspecified).AddTicks(4696), 4L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 50L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Reactive context-sensitive benchmark", new DateTime(2020, 6, 29, 11, 38, 14, 587, DateTimeKind.Unspecified).AddTicks(6674), 10L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 51L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Face to face dynamic frame", new DateTime(2020, 9, 21, 11, 15, 41, 595, DateTimeKind.Unspecified).AddTicks(1664), 1L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 52L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Progressive executive functionalities", new DateTime(2020, 10, 1, 3, 45, 21, 390, DateTimeKind.Unspecified).AddTicks(1136), 10L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 53L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Adaptive needs-based challenge", new DateTime(2020, 1, 2, 8, 21, 7, 818, DateTimeKind.Unspecified).AddTicks(6989), 10L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 54L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "User-centric encompassing ability", new DateTime(2020, 6, 30, 6, 46, 13, 595, DateTimeKind.Unspecified).AddTicks(658), 8L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 55L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Integrated static matrices", new DateTime(2020, 6, 28, 0, 39, 39, 379, DateTimeKind.Unspecified).AddTicks(3704), 10L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 56L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Secured exuding local area network", new DateTime(2020, 3, 16, 16, 54, 24, 646, DateTimeKind.Unspecified).AddTicks(772), 4L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 57L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Multi-lateral stable knowledge base", new DateTime(2020, 5, 4, 0, 13, 31, 710, DateTimeKind.Unspecified).AddTicks(1420), 11L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 58L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Operative well-modulated access", new DateTime(2020, 7, 9, 11, 12, 33, 405, DateTimeKind.Unspecified).AddTicks(8431), 5L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 59L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Virtual executive help-desk", new DateTime(2020, 1, 11, 17, 54, 34, 960, DateTimeKind.Unspecified).AddTicks(5539), 12L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 60L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Open-architected responsive access", new DateTime(2020, 2, 25, 22, 15, 7, 590, DateTimeKind.Unspecified).AddTicks(9973), 9L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 61L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 2m, "Front-line methodical infrastructure", new DateTime(2020, 6, 11, 15, 13, 6, 596, DateTimeKind.Unspecified).AddTicks(8453), 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 62L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Object-based grid-enabled paradigm", new DateTime(2020, 12, 14, 3, 32, 45, 794, DateTimeKind.Unspecified).AddTicks(3323), 12L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 63L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Team-oriented logistical framework", new DateTime(2020, 11, 29, 16, 44, 12, 548, DateTimeKind.Unspecified).AddTicks(8136), 8L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 64L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Ameliorated bi-directional flexibility", new DateTime(2020, 2, 26, 15, 1, 19, 479, DateTimeKind.Unspecified).AddTicks(6987), 3L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 65L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Assimilated intermediate concept", new DateTime(2020, 4, 19, 9, 48, 57, 934, DateTimeKind.Unspecified).AddTicks(7146), 9L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 66L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Horizontal incremental application", new DateTime(2020, 6, 29, 17, 2, 39, 435, DateTimeKind.Unspecified).AddTicks(6286), 1L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 67L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Universal non-volatile toolset", new DateTime(2020, 11, 12, 12, 48, 30, 380, DateTimeKind.Unspecified).AddTicks(4535), 4L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 68L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Down-sized motivating approach", new DateTime(2020, 5, 31, 11, 10, 39, 712, DateTimeKind.Unspecified).AddTicks(2332), 8L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 69L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Multi-lateral bottom-line artificial intelligence", new DateTime(2020, 5, 21, 5, 4, 8, 355, DateTimeKind.Unspecified).AddTicks(6251), 12L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 70L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Total impactful encryption", new DateTime(2020, 7, 13, 10, 45, 19, 370, DateTimeKind.Unspecified).AddTicks(4085), 11L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 71L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Balanced disintermediate interface", new DateTime(2020, 8, 17, 17, 46, 3, 477, DateTimeKind.Unspecified).AddTicks(274), 2L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 72L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 1m, "Inverse executive system engine", new DateTime(2020, 5, 11, 11, 42, 34, 563, DateTimeKind.Unspecified).AddTicks(25), 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 73L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Triple-buffered bandwidth-monitored approach", new DateTime(2020, 4, 28, 4, 20, 2, 866, DateTimeKind.Unspecified).AddTicks(4930), 10L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 74L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Implemented well-modulated artificial intelligence", new DateTime(2020, 12, 18, 6, 36, 20, 307, DateTimeKind.Unspecified).AddTicks(2757), 6L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 75L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Diverse multi-tasking Graphic Interface", new DateTime(2020, 12, 31, 7, 11, 11, 213, DateTimeKind.Unspecified).AddTicks(6180), 10L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 76L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Fundamental intermediate interface", new DateTime(2020, 2, 8, 20, 34, 5, 48, DateTimeKind.Unspecified).AddTicks(8227), 12L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 77L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Seamless client-driven adapter", new DateTime(2020, 2, 29, 18, 33, 47, 145, DateTimeKind.Unspecified).AddTicks(7849), 10L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 78L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Innovative contextually-based array", new DateTime(2020, 8, 25, 11, 14, 26, 514, DateTimeKind.Unspecified).AddTicks(2620), 4L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 79L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Fundamental full-range moratorium", new DateTime(2020, 8, 18, 21, 27, 43, 598, DateTimeKind.Unspecified).AddTicks(8983), 12L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 80L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Quality-focused intangible attitude", new DateTime(2020, 2, 6, 3, 22, 26, 654, DateTimeKind.Unspecified).AddTicks(4998), 2L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 81L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Organized intermediate project", new DateTime(2020, 8, 30, 9, 42, 0, 977, DateTimeKind.Unspecified).AddTicks(2898), 1L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 82L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Secured analyzing moratorium", new DateTime(2020, 11, 2, 9, 12, 57, 975, DateTimeKind.Unspecified).AddTicks(8399), 2L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 83L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Monitored discrete instruction set", new DateTime(2020, 1, 8, 2, 15, 58, 805, DateTimeKind.Unspecified).AddTicks(7198), 2L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 84L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Cross-platform systematic algorithm", new DateTime(2020, 6, 24, 15, 14, 25, 90, DateTimeKind.Unspecified).AddTicks(1633), 8L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 85L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Profit-focused uniform moratorium", new DateTime(2020, 11, 9, 21, 0, 40, 560, DateTimeKind.Unspecified).AddTicks(2256), 12L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 86L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Public-key dynamic contingency", new DateTime(2020, 6, 4, 15, 58, 36, 801, DateTimeKind.Unspecified).AddTicks(4705), 11L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 87L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Grass-roots 24 hour service-desk", new DateTime(2020, 2, 7, 4, 38, 36, 151, DateTimeKind.Unspecified).AddTicks(3824), 1L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 88L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Enterprise-wide methodical utilisation", new DateTime(2020, 5, 20, 17, 25, 39, 663, DateTimeKind.Unspecified).AddTicks(5482), 9L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 89L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Public-key optimizing Graphical User Interface", new DateTime(2020, 7, 30, 1, 38, 9, 868, DateTimeKind.Unspecified).AddTicks(8403), 9L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 90L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Decentralized zero tolerance benchmark", new DateTime(2020, 6, 26, 20, 46, 37, 369, DateTimeKind.Unspecified).AddTicks(1439), 5L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 91L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Virtual discrete database", new DateTime(2020, 1, 4, 14, 22, 11, 714, DateTimeKind.Unspecified).AddTicks(373), 9L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 92L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Synchronised cohesive moderator", new DateTime(2020, 6, 16, 0, 10, 4, 484, DateTimeKind.Unspecified).AddTicks(3900), 12L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 93L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Fully-configurable needs-based database", new DateTime(2020, 11, 7, 21, 56, 17, 594, DateTimeKind.Unspecified).AddTicks(279), 10L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 94L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Organic scalable budgetary management", new DateTime(2020, 5, 12, 8, 6, 0, 425, DateTimeKind.Unspecified).AddTicks(5112), 10L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 95L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Adaptive neutral moderator", new DateTime(2020, 5, 21, 9, 32, 53, 543, DateTimeKind.Unspecified).AddTicks(8477), 6L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 96L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Fully-configurable object-oriented analyzer", new DateTime(2020, 6, 26, 18, 36, 26, 121, DateTimeKind.Unspecified).AddTicks(7885), 10L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 97L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Optimized real-time portal", new DateTime(2020, 9, 4, 22, 43, 42, 32, DateTimeKind.Unspecified).AddTicks(4733), 7L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 98L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Fully-configurable system-worthy knowledge user", new DateTime(2020, 10, 2, 10, 50, 31, 272, DateTimeKind.Unspecified).AddTicks(1971), 9L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 99L,
                columns: new[] { "Comment", "Date", "ProjectId" },
                values: new object[] { "Multi-layered background strategy", new DateTime(2020, 10, 9, 9, 28, 52, 449, DateTimeKind.Unspecified).AddTicks(6816), 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 100L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 7m, "Object-based zero tolerance installation", new DateTime(2020, 8, 1, 5, 57, 22, 91, DateTimeKind.Unspecified).AddTicks(9146), 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 101L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Versatile coherent workforce", new DateTime(2020, 2, 22, 7, 0, 56, 120, DateTimeKind.Unspecified).AddTicks(7159), 9L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 102L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Automated fault-tolerant encryption", new DateTime(2020, 2, 29, 7, 14, 9, 170, DateTimeKind.Unspecified).AddTicks(8102), 12L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 103L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Stand-alone asynchronous policy", new DateTime(2020, 5, 7, 0, 39, 36, 501, DateTimeKind.Unspecified).AddTicks(6954), 9L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 104L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Polarised coherent alliance", new DateTime(2020, 11, 8, 6, 56, 19, 937, DateTimeKind.Unspecified).AddTicks(6232), 1L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 105L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Robust content-based groupware", new DateTime(2020, 12, 24, 19, 49, 34, 486, DateTimeKind.Unspecified).AddTicks(2397), 4L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 106L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Public-key leading edge access", new DateTime(2020, 11, 5, 17, 24, 41, 644, DateTimeKind.Unspecified).AddTicks(4301), 12L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 107L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 4m, "Re-contextualized leading edge product", new DateTime(2020, 5, 25, 5, 37, 32, 893, DateTimeKind.Unspecified).AddTicks(9386), 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 108L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Triple-buffered real-time framework", new DateTime(2020, 2, 29, 8, 35, 44, 456, DateTimeKind.Unspecified).AddTicks(1894), 8L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 109L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Adaptive web-enabled neural-net", new DateTime(2020, 3, 3, 19, 34, 47, 332, DateTimeKind.Unspecified).AddTicks(8135), 8L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 110L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Customizable tertiary paradigm", new DateTime(2020, 12, 21, 20, 12, 53, 836, DateTimeKind.Unspecified).AddTicks(6868), 1L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 111L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Operative non-volatile process improvement", new DateTime(2020, 5, 6, 4, 13, 5, 803, DateTimeKind.Unspecified).AddTicks(8988), 2L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 112L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Pre-emptive demand-driven methodology", new DateTime(2020, 5, 25, 1, 57, 40, 456, DateTimeKind.Unspecified).AddTicks(1347), 11L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 113L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Multi-tiered 4th generation middleware", new DateTime(2020, 5, 13, 11, 47, 2, 496, DateTimeKind.Unspecified).AddTicks(5323), 4L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 114L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Phased encompassing framework", new DateTime(2021, 1, 1, 9, 43, 19, 710, DateTimeKind.Unspecified).AddTicks(2364), 6L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 115L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Programmable actuating groupware", new DateTime(2020, 3, 2, 5, 30, 54, 292, DateTimeKind.Unspecified).AddTicks(2783), 9L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 116L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Automated mission-critical intranet", new DateTime(2020, 7, 19, 23, 23, 11, 782, DateTimeKind.Unspecified).AddTicks(6061), 11L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 117L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Quality-focused actuating policy", new DateTime(2020, 6, 19, 10, 25, 20, 981, DateTimeKind.Unspecified).AddTicks(2130), 5L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 118L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Synergistic asynchronous orchestration", new DateTime(2020, 5, 25, 22, 10, 19, 690, DateTimeKind.Unspecified).AddTicks(4465), 10L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 119L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Innovative fault-tolerant open architecture", new DateTime(2020, 6, 16, 0, 12, 39, 670, DateTimeKind.Unspecified).AddTicks(4323), 1L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 120L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Distributed cohesive benchmark", new DateTime(2020, 4, 21, 4, 14, 7, 408, DateTimeKind.Unspecified).AddTicks(5536), 12L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 121L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Managed analyzing info-mediaries", new DateTime(2020, 7, 6, 3, 41, 41, 248, DateTimeKind.Unspecified).AddTicks(5194), 11L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 122L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Extended motivating analyzer", new DateTime(2020, 4, 20, 19, 56, 31, 1, DateTimeKind.Unspecified).AddTicks(9851), 10L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 123L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Virtual neutral superstructure", new DateTime(2020, 12, 4, 12, 30, 57, 452, DateTimeKind.Unspecified).AddTicks(1871), 6L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 124L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Enhanced systematic projection", new DateTime(2020, 6, 4, 23, 46, 56, 903, DateTimeKind.Unspecified).AddTicks(6638), 7L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 125L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Synchronised mission-critical framework", new DateTime(2020, 5, 31, 10, 7, 22, 689, DateTimeKind.Unspecified).AddTicks(2540), 10L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 126L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Advanced contextually-based system engine", new DateTime(2020, 3, 21, 22, 21, 8, 446, DateTimeKind.Unspecified).AddTicks(8957), 10L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 127L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Reduced modular concept", new DateTime(2020, 1, 10, 9, 21, 1, 628, DateTimeKind.Unspecified).AddTicks(6986), 6L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 128L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Object-based context-sensitive interface", new DateTime(2020, 2, 29, 18, 24, 2, 193, DateTimeKind.Unspecified).AddTicks(3348), 9L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 129L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Down-sized multi-tasking forecast", new DateTime(2020, 10, 13, 0, 39, 30, 483, DateTimeKind.Unspecified).AddTicks(7840), 5L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 130L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Assimilated needs-based algorithm", new DateTime(2020, 6, 3, 11, 57, 25, 563, DateTimeKind.Unspecified).AddTicks(9235), 11L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 131L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Multi-lateral zero administration monitoring", new DateTime(2020, 5, 13, 6, 39, 0, 916, DateTimeKind.Unspecified).AddTicks(7848), 12L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 132L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Enterprise-wide methodical archive", new DateTime(2020, 7, 22, 1, 4, 42, 204, DateTimeKind.Unspecified).AddTicks(8950), 10L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 133L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Innovative static application", new DateTime(2020, 4, 6, 8, 7, 50, 116, DateTimeKind.Unspecified).AddTicks(5678), 10L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 134L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Optional logistical help-desk", new DateTime(2020, 3, 30, 10, 12, 14, 499, DateTimeKind.Unspecified).AddTicks(5401), 4L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 135L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "User-centric client-server leverage", new DateTime(2020, 9, 9, 20, 0, 17, 753, DateTimeKind.Unspecified).AddTicks(4409), 9L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 136L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Exclusive systemic productivity", new DateTime(2020, 4, 10, 21, 33, 1, 815, DateTimeKind.Unspecified).AddTicks(5188), 9L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 137L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Centralized demand-driven matrices", new DateTime(2020, 9, 18, 4, 24, 47, 350, DateTimeKind.Unspecified).AddTicks(1241), 8L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 138L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Switchable well-modulated architecture", new DateTime(2020, 1, 26, 19, 35, 1, 713, DateTimeKind.Unspecified).AddTicks(3430), 4L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 139L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Innovative context-sensitive neural-net", new DateTime(2020, 2, 24, 14, 11, 23, 520, DateTimeKind.Unspecified).AddTicks(2485), 10L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 140L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Managed impactful artificial intelligence", new DateTime(2020, 10, 12, 22, 54, 15, 91, DateTimeKind.Unspecified).AddTicks(797), 6L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 141L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Virtual directional attitude", new DateTime(2020, 4, 22, 20, 57, 10, 518, DateTimeKind.Unspecified).AddTicks(3956), 3L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 142L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 4m, "Function-based static middleware", new DateTime(2020, 10, 29, 2, 43, 49, 878, DateTimeKind.Unspecified).AddTicks(6924), 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 143L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Down-sized hybrid Graphical User Interface", new DateTime(2020, 1, 17, 20, 21, 6, 324, DateTimeKind.Unspecified).AddTicks(580), 9L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 144L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 7m, "Profit-focused attitude-oriented success", new DateTime(2020, 2, 17, 12, 29, 50, 327, DateTimeKind.Unspecified).AddTicks(8680), 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 145L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Reverse-engineered human-resource collaboration", new DateTime(2020, 9, 9, 10, 58, 29, 186, DateTimeKind.Unspecified).AddTicks(4025), 3L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 146L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Public-key well-modulated alliance", new DateTime(2020, 7, 13, 19, 3, 32, 100, DateTimeKind.Unspecified).AddTicks(2561), 8L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 147L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Implemented 6th generation forecast", new DateTime(2020, 6, 6, 1, 54, 23, 572, DateTimeKind.Unspecified).AddTicks(9136), 3L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 148L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Advanced needs-based product", new DateTime(2020, 3, 12, 10, 45, 9, 561, DateTimeKind.Unspecified).AddTicks(9322), 11L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 149L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Devolved context-sensitive solution", new DateTime(2020, 4, 6, 13, 25, 5, 35, DateTimeKind.Unspecified).AddTicks(7000), 8L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 150L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Grass-roots global definition", new DateTime(2020, 10, 31, 5, 36, 41, 767, DateTimeKind.Unspecified).AddTicks(2394), 11L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 151L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Operative explicit archive", new DateTime(2020, 3, 27, 16, 10, 15, 617, DateTimeKind.Unspecified).AddTicks(8373), 10L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 152L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Balanced interactive attitude", new DateTime(2020, 10, 19, 22, 2, 3, 794, DateTimeKind.Unspecified).AddTicks(7655), 3L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 153L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Self-enabling full-range extranet", new DateTime(2020, 6, 13, 6, 6, 0, 494, DateTimeKind.Unspecified).AddTicks(919), 8L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 154L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Re-engineered coherent website", new DateTime(2020, 7, 11, 14, 31, 45, 179, DateTimeKind.Unspecified).AddTicks(8468), 3L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 155L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Polarised analyzing functionalities", new DateTime(2020, 7, 1, 2, 1, 16, 876, DateTimeKind.Unspecified).AddTicks(834), 3L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 156L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Fully-configurable national application", new DateTime(2020, 9, 4, 15, 55, 9, 680, DateTimeKind.Unspecified).AddTicks(9684), 6L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 157L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Public-key optimal Graphic Interface", new DateTime(2020, 1, 26, 15, 51, 21, 871, DateTimeKind.Unspecified).AddTicks(1398), 8L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 158L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Advanced well-modulated definition", new DateTime(2020, 10, 31, 22, 48, 21, 581, DateTimeKind.Unspecified).AddTicks(3897), 3L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 159L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Devolved attitude-oriented methodology", new DateTime(2020, 1, 9, 11, 12, 6, 508, DateTimeKind.Unspecified).AddTicks(6243), 2L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 160L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Multi-lateral object-oriented website", new DateTime(2020, 4, 2, 1, 4, 7, 797, DateTimeKind.Unspecified).AddTicks(7592), 7L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 161L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 4m, "Reduced dedicated array", new DateTime(2020, 4, 7, 8, 4, 19, 307, DateTimeKind.Unspecified).AddTicks(4919), 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 162L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Multi-channelled maximized knowledge user", new DateTime(2020, 5, 23, 14, 7, 10, 127, DateTimeKind.Unspecified).AddTicks(9796), 3L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 163L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Configurable bandwidth-monitored toolset", new DateTime(2020, 6, 19, 3, 39, 24, 849, DateTimeKind.Unspecified).AddTicks(3396), 3L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 164L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Organized heuristic framework", new DateTime(2020, 9, 3, 13, 1, 29, 670, DateTimeKind.Unspecified).AddTicks(2925), 2L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 165L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Advanced full-range array", new DateTime(2020, 9, 5, 20, 59, 58, 362, DateTimeKind.Unspecified).AddTicks(2650), 8L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 166L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Realigned clear-thinking hierarchy", new DateTime(2020, 1, 23, 2, 59, 13, 761, DateTimeKind.Unspecified).AddTicks(6720), 4L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 167L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Open-architected actuating success", new DateTime(2020, 10, 3, 3, 14, 56, 467, DateTimeKind.Unspecified).AddTicks(8446), 8L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 168L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Phased 24/7 emulation", new DateTime(2020, 11, 2, 22, 46, 48, 9, DateTimeKind.Unspecified).AddTicks(6984), 2L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 169L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Secured optimal model", new DateTime(2020, 5, 12, 7, 41, 50, 757, DateTimeKind.Unspecified).AddTicks(5337), 8L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 170L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "De-engineered grid-enabled methodology", new DateTime(2020, 11, 1, 23, 2, 40, 212, DateTimeKind.Unspecified).AddTicks(3394), 2L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 171L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "User-friendly intangible workforce", new DateTime(2020, 5, 1, 9, 46, 2, 668, DateTimeKind.Unspecified).AddTicks(2743), 1L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 172L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Innovative human-resource interface", new DateTime(2020, 5, 29, 14, 7, 43, 166, DateTimeKind.Unspecified).AddTicks(3038), 1L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 173L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Intuitive secondary infrastructure", new DateTime(2020, 11, 10, 0, 53, 40, 401, DateTimeKind.Unspecified).AddTicks(815), 12L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 174L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Managed scalable middleware", new DateTime(2020, 2, 7, 7, 38, 26, 321, DateTimeKind.Unspecified).AddTicks(645), 12L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 175L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Pre-emptive didactic internet solution", new DateTime(2020, 4, 13, 0, 45, 1, 519, DateTimeKind.Unspecified).AddTicks(6872), 5L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 176L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 6m, "Multi-tiered discrete artificial intelligence", new DateTime(2020, 12, 21, 23, 41, 13, 105, DateTimeKind.Unspecified).AddTicks(2468), 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 177L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Ergonomic background matrix", new DateTime(2020, 2, 12, 3, 10, 38, 594, DateTimeKind.Unspecified).AddTicks(5701), 11L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 178L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 7m, "Pre-emptive bandwidth-monitored benchmark", new DateTime(2020, 1, 15, 15, 13, 10, 3, DateTimeKind.Unspecified).AddTicks(1837), 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 179L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Re-contextualized explicit artificial intelligence", new DateTime(2020, 6, 22, 5, 16, 37, 847, DateTimeKind.Unspecified).AddTicks(6777), 1L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 180L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Down-sized zero defect moderator", new DateTime(2020, 9, 16, 12, 42, 31, 614, DateTimeKind.Unspecified).AddTicks(3043), 5L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 181L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Open-source fault-tolerant encryption", new DateTime(2020, 10, 3, 7, 12, 47, 795, DateTimeKind.Unspecified).AddTicks(6330), 9L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 182L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Quality-focused 24/7 alliance", new DateTime(2020, 7, 5, 15, 30, 2, 85, DateTimeKind.Unspecified).AddTicks(412), 12L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 183L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Decentralized fresh-thinking neural-net", new DateTime(2020, 8, 3, 21, 55, 38, 60, DateTimeKind.Unspecified).AddTicks(5067), 4L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 184L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Up-sized zero tolerance neural-net", new DateTime(2020, 2, 15, 14, 25, 22, 406, DateTimeKind.Unspecified).AddTicks(5456), 10L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 185L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Cross-platform web-enabled internet solution", new DateTime(2020, 8, 24, 3, 9, 13, 820, DateTimeKind.Unspecified).AddTicks(6183), 2L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 186L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Re-engineered solution-oriented time-frame", new DateTime(2020, 11, 2, 18, 13, 4, 276, DateTimeKind.Unspecified).AddTicks(6054), 3L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 187L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Grass-roots 6th generation application", new DateTime(2020, 5, 5, 17, 30, 4, 87, DateTimeKind.Unspecified).AddTicks(9439), 11L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 188L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Organized well-modulated application", new DateTime(2020, 10, 8, 4, 40, 30, 447, DateTimeKind.Unspecified).AddTicks(4432), 5L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 189L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Innovative modular synergy", new DateTime(2020, 2, 28, 21, 29, 26, 65, DateTimeKind.Unspecified).AddTicks(8541), 7L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 190L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Business-focused impactful solution", new DateTime(2020, 2, 26, 5, 11, 26, 888, DateTimeKind.Unspecified).AddTicks(5917), 12L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 191L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Persevering object-oriented algorithm", new DateTime(2020, 11, 27, 6, 2, 44, 183, DateTimeKind.Unspecified).AddTicks(665), 7L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 192L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "User-centric mission-critical task-force", new DateTime(2020, 9, 26, 10, 39, 44, 119, DateTimeKind.Unspecified).AddTicks(4406), 4L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 193L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Visionary homogeneous orchestration", new DateTime(2020, 12, 22, 21, 9, 52, 653, DateTimeKind.Unspecified).AddTicks(4292), 8L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 194L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Diverse 4th generation monitoring", new DateTime(2020, 7, 3, 3, 59, 55, 763, DateTimeKind.Unspecified).AddTicks(9672), 2L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 195L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Optimized composite system engine", new DateTime(2020, 6, 18, 19, 22, 18, 859, DateTimeKind.Unspecified).AddTicks(8260), 5L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 196L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Ergonomic 3rd generation solution", new DateTime(2020, 8, 22, 8, 35, 40, 826, DateTimeKind.Unspecified).AddTicks(3962), 11L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 197L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Advanced zero defect encoding", new DateTime(2020, 1, 9, 5, 5, 51, 485, DateTimeKind.Unspecified).AddTicks(8242), 12L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 198L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Assimilated bifurcated encoding", new DateTime(2020, 1, 8, 16, 48, 57, 491, DateTimeKind.Unspecified).AddTicks(622), 1L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 199L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Public-key explicit help-desk", new DateTime(2020, 1, 27, 15, 15, 59, 822, DateTimeKind.Unspecified).AddTicks(6609), 8L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 200L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Intuitive 24 hour synergy", new DateTime(2020, 4, 13, 9, 54, 10, 853, DateTimeKind.Unspecified).AddTicks(4761), 1L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 201L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Monitored systematic protocol", new DateTime(2020, 7, 20, 1, 43, 46, 993, DateTimeKind.Unspecified).AddTicks(228), 3L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 202L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Balanced explicit array", new DateTime(2020, 11, 28, 17, 19, 18, 384, DateTimeKind.Unspecified).AddTicks(7068), 1L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 203L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Business-focused motivating encoding", new DateTime(2020, 3, 21, 5, 32, 0, 183, DateTimeKind.Unspecified).AddTicks(5725), 6L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 204L,
                columns: new[] { "Comment", "Date", "EmployeeId" },
                values: new object[] { "Profound full-range database", new DateTime(2020, 8, 16, 0, 6, 45, 270, DateTimeKind.Unspecified).AddTicks(1013), 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 205L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Virtual explicit utilisation", new DateTime(2020, 1, 14, 12, 2, 16, 78, DateTimeKind.Unspecified).AddTicks(4211), 11L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 206L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Focused homogeneous service-desk", new DateTime(2020, 5, 1, 3, 2, 58, 599, DateTimeKind.Unspecified).AddTicks(4789), 12L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 207L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Vision-oriented eco-centric leverage", new DateTime(2020, 3, 8, 8, 20, 56, 829, DateTimeKind.Unspecified).AddTicks(9433), 10L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 208L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Implemented modular knowledge user", new DateTime(2020, 11, 26, 1, 3, 21, 761, DateTimeKind.Unspecified).AddTicks(5977), 10L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 209L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Mandatory leading edge archive", new DateTime(2020, 3, 9, 7, 2, 42, 502, DateTimeKind.Unspecified).AddTicks(6776), 9L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 210L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Adaptive bi-directional capacity", new DateTime(2020, 8, 2, 8, 22, 34, 421, DateTimeKind.Unspecified).AddTicks(2064), 12L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 211L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Decentralized high-level intranet", new DateTime(2020, 12, 2, 21, 31, 24, 87, DateTimeKind.Unspecified).AddTicks(4630), 5L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 212L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Compatible multi-tasking firmware", new DateTime(2020, 12, 5, 15, 21, 38, 120, DateTimeKind.Unspecified).AddTicks(3635), 9L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 213L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Re-engineered full-range architecture", new DateTime(2020, 4, 10, 18, 24, 46, 28, DateTimeKind.Unspecified).AddTicks(7439), 7L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 214L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Up-sized optimal circuit", new DateTime(2020, 10, 17, 10, 59, 40, 75, DateTimeKind.Unspecified).AddTicks(8188), 4L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 215L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Distributed full-range standardization", new DateTime(2020, 7, 20, 10, 51, 27, 467, DateTimeKind.Unspecified).AddTicks(6678), 3L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 216L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Devolved 24 hour framework", new DateTime(2020, 7, 24, 5, 53, 31, 684, DateTimeKind.Unspecified).AddTicks(6750), 6L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 217L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Team-oriented real-time application", new DateTime(2020, 2, 21, 7, 22, 30, 397, DateTimeKind.Unspecified).AddTicks(1000), 9L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 218L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Realigned asymmetric Graphical User Interface", new DateTime(2020, 6, 25, 16, 36, 58, 890, DateTimeKind.Unspecified).AddTicks(2925), 9L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 219L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 2m, "Re-contextualized executive artificial intelligence", new DateTime(2020, 12, 2, 18, 28, 49, 473, DateTimeKind.Unspecified).AddTicks(7321), 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 220L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Ergonomic high-level installation", new DateTime(2020, 8, 30, 18, 49, 46, 147, DateTimeKind.Unspecified).AddTicks(3831), 2L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 221L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Inverse next generation analyzer", new DateTime(2020, 5, 20, 12, 12, 10, 923, DateTimeKind.Unspecified).AddTicks(2738), 11L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 222L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Versatile bandwidth-monitored knowledge base", new DateTime(2020, 7, 7, 12, 16, 11, 900, DateTimeKind.Unspecified).AddTicks(2810), 4L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 223L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Fundamental grid-enabled hardware", new DateTime(2020, 9, 22, 22, 1, 22, 364, DateTimeKind.Unspecified).AddTicks(5737), 11L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 224L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Profound demand-driven moderator", new DateTime(2020, 12, 30, 10, 46, 34, 432, DateTimeKind.Unspecified).AddTicks(1217), 11L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 225L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 6m, "Front-line leading edge local area network", new DateTime(2020, 6, 11, 16, 28, 39, 638, DateTimeKind.Unspecified).AddTicks(7254), 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 226L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Implemented executive standardization", new DateTime(2020, 9, 16, 6, 51, 3, 56, DateTimeKind.Unspecified).AddTicks(7025), 6L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 227L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Enterprise-wide interactive knowledge user", new DateTime(2020, 3, 8, 12, 28, 3, 697, DateTimeKind.Unspecified).AddTicks(1850), 4L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 228L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Ameliorated analyzing encryption", new DateTime(2020, 6, 4, 5, 54, 48, 331, DateTimeKind.Unspecified).AddTicks(9760), 1L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 229L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Monitored fresh-thinking workforce", new DateTime(2020, 2, 13, 14, 25, 0, 216, DateTimeKind.Unspecified).AddTicks(2415), 3L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 230L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Organic zero defect open system", new DateTime(2020, 5, 28, 15, 58, 57, 141, DateTimeKind.Unspecified).AddTicks(8148), 12L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 231L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Centralized local function", new DateTime(2020, 3, 6, 21, 26, 24, 913, DateTimeKind.Unspecified).AddTicks(7889), 3L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 232L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Re-contextualized attitude-oriented local area network", new DateTime(2020, 9, 7, 0, 6, 47, 208, DateTimeKind.Unspecified).AddTicks(2521), 7L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 233L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Multi-tiered didactic interface", new DateTime(2020, 9, 23, 13, 11, 4, 233, DateTimeKind.Unspecified).AddTicks(9838), 9L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 234L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 8m, "User-friendly systemic encryption", new DateTime(2020, 7, 15, 0, 46, 32, 736, DateTimeKind.Unspecified).AddTicks(1710), 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 235L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Optional systematic focus group", new DateTime(2020, 2, 8, 3, 58, 26, 263, DateTimeKind.Unspecified).AddTicks(645), 12L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 236L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 8m, "Object-based upward-trending service-desk", new DateTime(2020, 12, 11, 21, 55, 1, 585, DateTimeKind.Unspecified).AddTicks(5486), 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 237L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Front-line full-range migration", new DateTime(2020, 5, 9, 0, 42, 4, 656, DateTimeKind.Unspecified).AddTicks(9973), 1L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 238L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 1m, "Realigned client-driven data-warehouse", new DateTime(2020, 5, 18, 21, 24, 7, 789, DateTimeKind.Unspecified).AddTicks(4471), 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 239L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Reactive analyzing support", new DateTime(2020, 1, 16, 21, 35, 20, 843, DateTimeKind.Unspecified).AddTicks(8535), 1L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 240L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Ergonomic contextually-based middleware", new DateTime(2020, 9, 27, 11, 33, 53, 560, DateTimeKind.Unspecified).AddTicks(4370), 10L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 241L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Grass-roots needs-based benchmark", new DateTime(2020, 5, 1, 6, 20, 53, 624, DateTimeKind.Unspecified).AddTicks(4320), 2L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 242L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Mandatory multi-tasking emulation", new DateTime(2020, 3, 14, 18, 35, 31, 167, DateTimeKind.Unspecified).AddTicks(5905), 2L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 243L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 7m, "Progressive asymmetric infrastructure", new DateTime(2020, 8, 7, 16, 37, 13, 915, DateTimeKind.Unspecified).AddTicks(7592), 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 244L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Switchable user-facing knowledge user", new DateTime(2020, 11, 1, 17, 20, 58, 571, DateTimeKind.Unspecified).AddTicks(71), 11L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 245L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Digitized 24 hour definition", new DateTime(2020, 7, 21, 10, 31, 55, 937, DateTimeKind.Unspecified).AddTicks(3892), 11L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 246L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Networked bi-directional emulation", new DateTime(2020, 2, 4, 22, 4, 50, 400, DateTimeKind.Unspecified).AddTicks(2992), 6L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 247L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Intuitive mobile system engine", new DateTime(2020, 6, 19, 12, 29, 0, 601, DateTimeKind.Unspecified).AddTicks(6038), 11L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 248L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Decentralized bi-directional circuit", new DateTime(2020, 5, 1, 22, 9, 13, 967, DateTimeKind.Unspecified).AddTicks(4072), 11L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 249L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Reverse-engineered logistical encoding", new DateTime(2020, 3, 8, 14, 3, 54, 661, DateTimeKind.Unspecified).AddTicks(5684), 7L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 250L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Profound 24/7 concept", new DateTime(2020, 8, 7, 5, 21, 35, 541, DateTimeKind.Unspecified).AddTicks(5368), 9L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 251L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "User-centric composite budgetary management", new DateTime(2020, 6, 25, 2, 43, 11, 354, DateTimeKind.Unspecified).AddTicks(7010), 1L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 252L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Fully-configurable mobile ability", new DateTime(2020, 7, 13, 0, 38, 8, 834, DateTimeKind.Unspecified).AddTicks(2168), 6L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 253L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Synergized asynchronous access", new DateTime(2020, 6, 26, 4, 7, 0, 621, DateTimeKind.Unspecified).AddTicks(6106), 7L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 254L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Optional zero tolerance superstructure", new DateTime(2020, 11, 7, 17, 4, 35, 221, DateTimeKind.Unspecified).AddTicks(9650), 3L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 255L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Polarised object-oriented circuit", new DateTime(2020, 1, 8, 10, 21, 11, 264, DateTimeKind.Unspecified).AddTicks(2813), 8L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 256L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Up-sized 5th generation service-desk", new DateTime(2020, 5, 21, 16, 54, 38, 832, DateTimeKind.Unspecified).AddTicks(6025), 2L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 257L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "User-friendly directional archive", new DateTime(2020, 1, 28, 21, 37, 44, 749, DateTimeKind.Unspecified).AddTicks(7719), 6L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 258L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Universal coherent benchmark", new DateTime(2020, 3, 19, 12, 13, 55, 33, DateTimeKind.Unspecified).AddTicks(7532), 8L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 259L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Down-sized content-based standardization", new DateTime(2020, 6, 13, 8, 40, 12, 978, DateTimeKind.Unspecified).AddTicks(2897), 7L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 260L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Total stable software", new DateTime(2020, 9, 8, 9, 50, 55, 229, DateTimeKind.Unspecified).AddTicks(694), 5L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 261L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Balanced client-server Graphical User Interface", new DateTime(2020, 10, 30, 20, 33, 49, 339, DateTimeKind.Unspecified).AddTicks(1513), 4L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 262L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Reactive scalable process improvement", new DateTime(2020, 4, 19, 4, 44, 4, 335, DateTimeKind.Unspecified).AddTicks(3196), 10L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 263L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Operative 5th generation alliance", new DateTime(2020, 12, 20, 5, 14, 17, 526, DateTimeKind.Unspecified).AddTicks(891), 3L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 264L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Self-enabling well-modulated migration", new DateTime(2020, 10, 25, 10, 3, 19, 299, DateTimeKind.Unspecified).AddTicks(4254), 2L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 265L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Monitored dedicated application", new DateTime(2020, 9, 28, 11, 46, 43, 524, DateTimeKind.Unspecified).AddTicks(1950), 1L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 266L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Advanced next generation focus group", new DateTime(2020, 11, 2, 0, 8, 39, 612, DateTimeKind.Unspecified).AddTicks(1889), 11L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 267L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 5m, "Mandatory attitude-oriented portal", new DateTime(2020, 10, 19, 3, 14, 3, 470, DateTimeKind.Unspecified).AddTicks(3449), 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 268L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Seamless responsive capability", new DateTime(2020, 1, 3, 9, 39, 0, 718, DateTimeKind.Unspecified).AddTicks(8026), 2L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 269L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Down-sized responsive array", new DateTime(2020, 3, 29, 21, 50, 0, 269, DateTimeKind.Unspecified).AddTicks(2991), 5L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 270L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Optional neutral policy", new DateTime(2020, 7, 15, 16, 44, 56, 975, DateTimeKind.Unspecified).AddTicks(8106), 6L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 271L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Future-proofed next generation frame", new DateTime(2020, 10, 31, 14, 56, 0, 844, DateTimeKind.Unspecified).AddTicks(8547), 10L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 272L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Synergistic system-worthy hierarchy", new DateTime(2020, 3, 14, 6, 53, 42, 284, DateTimeKind.Unspecified).AddTicks(425), 9L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 273L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Multi-channelled uniform standardization", new DateTime(2020, 9, 12, 15, 28, 17, 405, DateTimeKind.Unspecified).AddTicks(3031), 5L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 274L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Universal contextually-based info-mediaries", new DateTime(2020, 8, 14, 7, 6, 50, 527, DateTimeKind.Unspecified).AddTicks(4037), 8L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 275L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Intuitive 24/7 emulation", new DateTime(2020, 3, 30, 23, 55, 27, 883, DateTimeKind.Unspecified).AddTicks(8335), 8L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 276L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Compatible reciprocal framework", new DateTime(2020, 11, 6, 12, 55, 57, 208, DateTimeKind.Unspecified).AddTicks(844), 12L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 277L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Universal multi-tasking orchestration", new DateTime(2020, 11, 19, 19, 27, 26, 394, DateTimeKind.Unspecified).AddTicks(4284), 10L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 278L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Seamless system-worthy analyzer", new DateTime(2020, 8, 9, 13, 35, 25, 648, DateTimeKind.Unspecified).AddTicks(7895), 7L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 279L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Multi-layered tangible complexity", new DateTime(2020, 9, 23, 15, 1, 0, 349, DateTimeKind.Unspecified).AddTicks(5268), 10L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 280L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Synergistic clear-thinking architecture", new DateTime(2020, 6, 25, 10, 7, 23, 974, DateTimeKind.Unspecified).AddTicks(2198), 7L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 281L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Customer-focused human-resource framework", new DateTime(2020, 3, 19, 13, 56, 49, 622, DateTimeKind.Unspecified).AddTicks(712), 7L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 282L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Organic real-time process improvement", new DateTime(2020, 6, 8, 19, 7, 29, 733, DateTimeKind.Unspecified).AddTicks(7289), 6L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 283L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Customer-focused contextually-based analyzer", new DateTime(2020, 10, 14, 19, 48, 58, 925, DateTimeKind.Unspecified).AddTicks(164), 12L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 284L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Total client-driven customer loyalty", new DateTime(2020, 1, 6, 7, 52, 24, 185, DateTimeKind.Unspecified).AddTicks(8424), 2L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 285L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Object-based modular data-warehouse", new DateTime(2020, 11, 24, 18, 13, 53, 863, DateTimeKind.Unspecified).AddTicks(2204), 12L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 286L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Innovative national workforce", new DateTime(2020, 9, 29, 9, 48, 41, 384, DateTimeKind.Unspecified).AddTicks(2914), 6L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 287L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 8m, "Cross-platform global flexibility", new DateTime(2020, 6, 8, 2, 2, 15, 610, DateTimeKind.Unspecified).AddTicks(7880), 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 288L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Upgradable 4th generation matrices", new DateTime(2020, 11, 4, 23, 46, 28, 744, DateTimeKind.Unspecified).AddTicks(4120), 9L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 289L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Fully-configurable bi-directional hub", new DateTime(2020, 9, 29, 8, 33, 44, 547, DateTimeKind.Unspecified).AddTicks(5659), 4L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 290L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Customer-focused hybrid hardware", new DateTime(2020, 12, 14, 4, 30, 28, 67, DateTimeKind.Unspecified).AddTicks(2864), 4L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 291L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Optional 6th generation infrastructure", new DateTime(2020, 12, 23, 12, 46, 24, 603, DateTimeKind.Unspecified).AddTicks(8675), 10L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 292L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Reduced transitional product", new DateTime(2020, 9, 15, 11, 7, 29, 406, DateTimeKind.Unspecified).AddTicks(9688), 9L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 293L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Persistent national database", new DateTime(2020, 4, 27, 19, 13, 51, 103, DateTimeKind.Unspecified).AddTicks(3363), 3L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 294L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Optimized intangible capability", new DateTime(2020, 5, 26, 7, 22, 44, 269, DateTimeKind.Unspecified).AddTicks(2436), 10L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 295L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Up-sized transitional application", new DateTime(2020, 11, 7, 0, 31, 49, 946, DateTimeKind.Unspecified).AddTicks(3099), 8L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 296L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Virtual background superstructure", new DateTime(2020, 12, 23, 20, 22, 45, 91, DateTimeKind.Unspecified).AddTicks(6978), 8L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 297L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Enhanced needs-based migration", new DateTime(2020, 6, 25, 18, 4, 17, 607, DateTimeKind.Unspecified).AddTicks(8465), 6L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 298L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Stand-alone client-driven application", new DateTime(2020, 6, 30, 14, 33, 4, 424, DateTimeKind.Unspecified).AddTicks(6795), 1L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 299L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Open-source encompassing architecture", new DateTime(2020, 9, 6, 17, 35, 52, 395, DateTimeKind.Unspecified).AddTicks(7309), 2L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 300L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Vision-oriented non-volatile analyzer", new DateTime(2020, 10, 10, 21, 36, 53, 347, DateTimeKind.Unspecified).AddTicks(4757), 3L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 301L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Organic even-keeled local area network", new DateTime(2020, 3, 12, 22, 3, 0, 722, DateTimeKind.Unspecified).AddTicks(8413), 12L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 302L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Switchable incremental data-warehouse", new DateTime(2020, 7, 4, 10, 22, 32, 872, DateTimeKind.Unspecified).AddTicks(5694), 11L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 303L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 1m, "Re-engineered zero tolerance methodology", new DateTime(2020, 6, 14, 10, 34, 49, 889, DateTimeKind.Unspecified).AddTicks(3325), 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 304L,
                columns: new[] { "Comment", "Date", "EmployeeId" },
                values: new object[] { "Robust solution-oriented interface", new DateTime(2020, 5, 12, 1, 22, 12, 89, DateTimeKind.Unspecified).AddTicks(5650), 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 305L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Virtual logistical encryption", new DateTime(2020, 9, 30, 23, 10, 54, 349, DateTimeKind.Unspecified).AddTicks(6312), 4L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 306L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Sharable human-resource architecture", new DateTime(2020, 12, 4, 6, 56, 12, 686, DateTimeKind.Unspecified).AddTicks(9282), 8L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 307L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Sharable scalable core", new DateTime(2020, 9, 13, 19, 5, 42, 850, DateTimeKind.Unspecified).AddTicks(7842), 7L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 308L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Realigned grid-enabled success", new DateTime(2020, 9, 20, 17, 7, 53, 239, DateTimeKind.Unspecified).AddTicks(8410), 1L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 309L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Operative 5th generation productivity", new DateTime(2020, 3, 3, 12, 2, 57, 246, DateTimeKind.Unspecified).AddTicks(6951), 3L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 310L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "User-centric well-modulated local area network", new DateTime(2020, 2, 1, 5, 27, 56, 269, DateTimeKind.Unspecified).AddTicks(3854), 1L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 311L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Object-based intangible migration", new DateTime(2020, 11, 4, 9, 52, 50, 392, DateTimeKind.Unspecified).AddTicks(9992), 2L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 312L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Advanced directional neural-net", new DateTime(2020, 10, 7, 14, 53, 30, 766, DateTimeKind.Unspecified).AddTicks(1676), 5L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 313L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Customer-focused foreground contingency", new DateTime(2020, 12, 18, 15, 4, 42, 234, DateTimeKind.Unspecified).AddTicks(6240), 6L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 314L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Monitored disintermediate hierarchy", new DateTime(2020, 6, 21, 0, 29, 0, 762, DateTimeKind.Unspecified).AddTicks(2748), 5L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 315L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Switchable multi-tasking hierarchy", new DateTime(2020, 10, 24, 16, 8, 39, 277, DateTimeKind.Unspecified).AddTicks(3821), 10L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 316L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Triple-buffered demand-driven system engine", new DateTime(2020, 5, 10, 3, 47, 13, 495, DateTimeKind.Unspecified).AddTicks(8423), 3L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 317L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Right-sized attitude-oriented secured line", new DateTime(2020, 11, 3, 21, 41, 48, 261, DateTimeKind.Unspecified).AddTicks(5471), 9L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 318L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Organic encompassing matrices", new DateTime(2020, 8, 13, 23, 6, 46, 432, DateTimeKind.Unspecified).AddTicks(8104), 10L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 319L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Enterprise-wide client-server orchestration", new DateTime(2020, 8, 18, 2, 34, 31, 529, DateTimeKind.Unspecified).AddTicks(1960), 1L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 320L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Polarised context-sensitive matrices", new DateTime(2020, 1, 29, 6, 9, 39, 212, DateTimeKind.Unspecified).AddTicks(5999), 2L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 321L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Customizable disintermediate emulation", new DateTime(2020, 1, 19, 14, 36, 19, 92, DateTimeKind.Unspecified).AddTicks(607), 5L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 322L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Distributed modular open architecture", new DateTime(2020, 10, 9, 10, 3, 43, 991, DateTimeKind.Unspecified).AddTicks(3453), 6L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 323L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Fully-configurable systematic access", new DateTime(2020, 1, 27, 19, 47, 38, 890, DateTimeKind.Unspecified).AddTicks(1256), 7L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 324L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Centralized contextually-based benchmark", new DateTime(2020, 2, 20, 20, 52, 42, 211, DateTimeKind.Unspecified).AddTicks(9047), 6L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 325L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Synergized contextually-based leverage", new DateTime(2020, 5, 7, 22, 36, 10, 434, DateTimeKind.Unspecified).AddTicks(9226), 7L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 326L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Automated disintermediate hardware", new DateTime(2020, 7, 28, 3, 45, 58, 69, DateTimeKind.Unspecified).AddTicks(7778), 9L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 327L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 1m, "Optional 24/7 knowledge user", new DateTime(2020, 5, 24, 1, 46, 32, 994, DateTimeKind.Unspecified).AddTicks(8986), 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 328L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Horizontal logistical model", new DateTime(2020, 11, 20, 7, 47, 53, 146, DateTimeKind.Unspecified).AddTicks(1536), 11L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 329L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Business-focused bottom-line success", new DateTime(2020, 7, 25, 14, 51, 55, 703, DateTimeKind.Unspecified).AddTicks(2352), 11L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 330L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Integrated attitude-oriented utilisation", new DateTime(2020, 7, 12, 13, 0, 13, 497, DateTimeKind.Unspecified).AddTicks(5413), 8L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 331L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Optional maximized process improvement", new DateTime(2020, 11, 15, 4, 46, 55, 607, DateTimeKind.Unspecified).AddTicks(521), 11L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 332L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Down-sized logistical open system", new DateTime(2020, 8, 19, 4, 33, 34, 367, DateTimeKind.Unspecified).AddTicks(9859), 10L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 333L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Profound user-facing model", new DateTime(2020, 11, 7, 8, 57, 52, 250, DateTimeKind.Unspecified).AddTicks(5168), 8L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 334L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Customizable interactive strategy", new DateTime(2020, 5, 6, 20, 53, 38, 675, DateTimeKind.Unspecified).AddTicks(3281), 6L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 335L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Universal logistical benchmark", new DateTime(2020, 9, 22, 19, 48, 12, 25, DateTimeKind.Unspecified).AddTicks(7334), 7L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 336L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Vision-oriented system-worthy ability", new DateTime(2020, 1, 10, 9, 46, 41, 381, DateTimeKind.Unspecified).AddTicks(3615), 2L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 337L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Persevering cohesive array", new DateTime(2020, 7, 21, 11, 10, 58, 390, DateTimeKind.Unspecified).AddTicks(2248), 12L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 338L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "De-engineered empowering utilisation", new DateTime(2020, 10, 22, 15, 33, 3, 662, DateTimeKind.Unspecified).AddTicks(8534), 6L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 339L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Automated tangible help-desk", new DateTime(2020, 4, 19, 0, 21, 29, 363, DateTimeKind.Unspecified).AddTicks(9988), 11L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 340L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 3m, "Vision-oriented local database", new DateTime(2020, 5, 9, 11, 30, 32, 426, DateTimeKind.Unspecified).AddTicks(621), 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 341L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Balanced modular infrastructure", new DateTime(2020, 9, 13, 9, 39, 40, 437, DateTimeKind.Unspecified).AddTicks(1146), 1L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 342L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Fundamental real-time info-mediaries", new DateTime(2020, 2, 13, 12, 14, 4, 834, DateTimeKind.Unspecified).AddTicks(6254), 3L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 343L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Exclusive bottom-line ability", new DateTime(2020, 6, 6, 3, 39, 0, 944, DateTimeKind.Unspecified).AddTicks(2993), 6L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 344L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Visionary logistical emulation", new DateTime(2020, 5, 28, 15, 43, 27, 812, DateTimeKind.Unspecified).AddTicks(1941), 1L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 345L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Proactive systematic installation", new DateTime(2020, 7, 24, 4, 18, 14, 902, DateTimeKind.Unspecified).AddTicks(5644), 11L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 346L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Reactive human-resource Graphical User Interface", new DateTime(2020, 1, 26, 22, 12, 6, 984, DateTimeKind.Unspecified).AddTicks(1313), 9L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 347L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 6m, "Cross-platform web-enabled open system", new DateTime(2020, 11, 4, 3, 21, 42, 321, DateTimeKind.Unspecified).AddTicks(45), 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 348L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Inverse dedicated time-frame", new DateTime(2020, 7, 21, 19, 15, 41, 421, DateTimeKind.Unspecified).AddTicks(240), 2L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 349L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Balanced cohesive alliance", new DateTime(2020, 9, 21, 18, 19, 33, 132, DateTimeKind.Unspecified).AddTicks(3520), 8L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 350L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Universal zero administration flexibility", new DateTime(2020, 12, 25, 9, 5, 31, 285, DateTimeKind.Unspecified).AddTicks(3235), 10L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 351L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Profound logistical process improvement", new DateTime(2020, 8, 22, 13, 31, 8, 624, DateTimeKind.Unspecified).AddTicks(2733), 7L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 352L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Pre-emptive maximized alliance", new DateTime(2020, 3, 27, 21, 3, 33, 862, DateTimeKind.Unspecified).AddTicks(6854), 4L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 353L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Persistent interactive process improvement", new DateTime(2020, 11, 6, 7, 13, 18, 911, DateTimeKind.Unspecified).AddTicks(2960), 10L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 354L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Face to face explicit budgetary management", new DateTime(2020, 1, 14, 1, 34, 6, 600, DateTimeKind.Unspecified).AddTicks(9986), 8L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 355L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Virtual executive circuit", new DateTime(2020, 1, 2, 0, 52, 24, 841, DateTimeKind.Unspecified).AddTicks(7648), 7L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 356L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Progressive cohesive intranet", new DateTime(2020, 3, 12, 6, 20, 38, 46, DateTimeKind.Unspecified).AddTicks(413), 9L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 357L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Polarised 24 hour firmware", new DateTime(2020, 3, 17, 22, 39, 55, 492, DateTimeKind.Unspecified).AddTicks(404), 7L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 358L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Mandatory local workforce", new DateTime(2020, 6, 27, 22, 52, 37, 497, DateTimeKind.Unspecified).AddTicks(4429), 1L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 359L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Diverse modular system engine", new DateTime(2020, 11, 27, 13, 2, 3, 325, DateTimeKind.Unspecified).AddTicks(1894), 9L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 360L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Enhanced systemic orchestration", new DateTime(2020, 8, 25, 18, 37, 53, 94, DateTimeKind.Unspecified).AddTicks(7628), 2L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 361L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Future-proofed context-sensitive architecture", new DateTime(2020, 6, 18, 4, 53, 10, 44, DateTimeKind.Unspecified).AddTicks(7316), 11L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 362L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Implemented secondary application", new DateTime(2020, 3, 18, 2, 11, 23, 139, DateTimeKind.Unspecified).AddTicks(6229), 9L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 363L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Secured client-driven knowledge base", new DateTime(2020, 11, 26, 18, 11, 13, 876, DateTimeKind.Unspecified).AddTicks(374), 4L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 364L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Organized mission-critical adapter", new DateTime(2020, 5, 21, 14, 3, 0, 799, DateTimeKind.Unspecified).AddTicks(563), 4L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 365L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Customizable mission-critical hub", new DateTime(2020, 10, 17, 8, 37, 37, 497, DateTimeKind.Unspecified).AddTicks(5799), 6L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 366L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Grass-roots uniform budgetary management", new DateTime(2020, 5, 20, 23, 42, 3, 352, DateTimeKind.Unspecified).AddTicks(2887), 10L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 367L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Sharable systemic utilisation", new DateTime(2020, 9, 11, 3, 34, 49, 447, DateTimeKind.Unspecified).AddTicks(4537), 9L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 368L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Public-key bottom-line productivity", new DateTime(2020, 2, 5, 18, 23, 49, 906, DateTimeKind.Unspecified).AddTicks(8595), 5L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 369L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Phased actuating methodology", new DateTime(2020, 6, 19, 4, 56, 36, 466, DateTimeKind.Unspecified).AddTicks(1025), 4L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 370L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Diverse mission-critical customer loyalty", new DateTime(2020, 4, 17, 16, 22, 13, 509, DateTimeKind.Unspecified).AddTicks(6589), 6L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 371L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Expanded fresh-thinking internet solution", new DateTime(2020, 6, 17, 1, 32, 56, 91, DateTimeKind.Unspecified).AddTicks(7853), 8L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 372L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Reduced 5th generation internet solution", new DateTime(2020, 8, 18, 18, 2, 46, 426, DateTimeKind.Unspecified).AddTicks(5667), 10L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 373L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Multi-lateral national attitude", new DateTime(2020, 12, 16, 8, 7, 59, 875, DateTimeKind.Unspecified).AddTicks(5573), 12L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 374L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Synchronised intangible instruction set", new DateTime(2020, 4, 28, 1, 14, 12, 978, DateTimeKind.Unspecified).AddTicks(2227), 4L, 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 375L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Exclusive optimal contingency", new DateTime(2020, 8, 10, 13, 18, 32, 375, DateTimeKind.Unspecified).AddTicks(7898), 3L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 376L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Re-engineered dedicated process improvement", new DateTime(2020, 12, 27, 5, 18, 24, 560, DateTimeKind.Unspecified).AddTicks(5167), 5L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 377L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Advanced asymmetric hierarchy", new DateTime(2020, 1, 1, 13, 35, 34, 249, DateTimeKind.Unspecified).AddTicks(1855), 9L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 378L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 6m, "Up-sized bandwidth-monitored internet solution", new DateTime(2020, 10, 12, 12, 28, 18, 518, DateTimeKind.Unspecified).AddTicks(4685), 8L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 379L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Team-oriented 24/7 firmware", new DateTime(2020, 9, 13, 23, 49, 16, 571, DateTimeKind.Unspecified).AddTicks(3835), 4L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 380L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Fully-configurable disintermediate leverage", new DateTime(2020, 2, 26, 18, 12, 34, 859, DateTimeKind.Unspecified).AddTicks(9876), 1L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 381L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Managed executive local area network", new DateTime(2020, 1, 10, 14, 27, 0, 358, DateTimeKind.Unspecified).AddTicks(9816), 2L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 382L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Monitored actuating knowledge user", new DateTime(2020, 11, 22, 3, 14, 36, 535, DateTimeKind.Unspecified).AddTicks(620), 1L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 383L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Polarised needs-based migration", new DateTime(2020, 11, 17, 4, 56, 43, 259, DateTimeKind.Unspecified).AddTicks(2663), 7L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 384L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 7m, "Enterprise-wide grid-enabled archive", new DateTime(2020, 1, 5, 20, 54, 15, 672, DateTimeKind.Unspecified).AddTicks(5122), 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 385L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Robust systemic moratorium", new DateTime(2020, 5, 15, 2, 11, 46, 593, DateTimeKind.Unspecified).AddTicks(4889), 5L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 386L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Right-sized well-modulated instruction set", new DateTime(2020, 1, 2, 11, 17, 20, 609, DateTimeKind.Unspecified).AddTicks(7974), 10L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 387L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "User-friendly reciprocal core", new DateTime(2020, 7, 31, 6, 32, 36, 580, DateTimeKind.Unspecified).AddTicks(4263), 3L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 388L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Phased web-enabled knowledge user", new DateTime(2020, 2, 28, 7, 2, 35, 530, DateTimeKind.Unspecified).AddTicks(2351), 9L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 389L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 2m, "Universal homogeneous definition", new DateTime(2020, 11, 19, 19, 18, 38, 702, DateTimeKind.Unspecified).AddTicks(8225), 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 390L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Diverse system-worthy open architecture", new DateTime(2020, 2, 16, 14, 25, 0, 714, DateTimeKind.Unspecified).AddTicks(7703), 1L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 391L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Re-contextualized bandwidth-monitored open architecture", new DateTime(2020, 10, 30, 12, 7, 15, 111, DateTimeKind.Unspecified).AddTicks(8023), 6L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 392L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Programmable systematic middleware", new DateTime(2020, 5, 31, 12, 36, 11, 704, DateTimeKind.Unspecified).AddTicks(3149), 7L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 393L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Universal bandwidth-monitored neural-net", new DateTime(2020, 1, 3, 22, 24, 24, 270, DateTimeKind.Unspecified).AddTicks(1748), 9L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 394L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Multi-tiered content-based focus group", new DateTime(2020, 4, 23, 7, 12, 17, 317, DateTimeKind.Unspecified).AddTicks(7455), 4L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 395L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Total interactive attitude", new DateTime(2020, 10, 8, 12, 46, 48, 804, DateTimeKind.Unspecified).AddTicks(7018), 5L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 396L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Streamlined systemic conglomeration", new DateTime(2020, 11, 8, 4, 33, 42, 571, DateTimeKind.Unspecified).AddTicks(7234), 7L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 397L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Pre-emptive multi-state support", new DateTime(2020, 12, 2, 12, 35, 11, 998, DateTimeKind.Unspecified).AddTicks(204), 4L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 398L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Reverse-engineered 24 hour focus group", new DateTime(2020, 7, 2, 2, 18, 34, 170, DateTimeKind.Unspecified).AddTicks(3168), 9L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 399L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Team-oriented encompassing circuit", new DateTime(2020, 1, 2, 5, 22, 32, 923, DateTimeKind.Unspecified).AddTicks(8448), 12L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 400L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Fully-configurable hybrid capacity", new DateTime(2020, 7, 11, 4, 6, 56, 41, DateTimeKind.Unspecified).AddTicks(5510), 11L, 4L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 1L, 3L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 1L, 4L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 1L, 7L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 1L, 9L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2L, 8L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2L, 11L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2L, 14L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3L, 7L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3L, 12L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3L, 15L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3L, 16L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3L, 17L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3L, 20L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4L, 8L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5L, 3L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5L, 8L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 5L, 15L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 6L, 7L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 6L, 12L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 7L, 4L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 7L, 5L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 7L, 9L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 7L, 10L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 7L, 15L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 7L, 18L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 8L, 6L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 8L, 9L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 8L, 17L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 9L, 15L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 9L, 20L });

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
                keyValues: new object[] { 10L, 19L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 11L, 3L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 11L, 7L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 11L, 8L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 11L, 12L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 11L, 14L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 12L, 1L });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 12L, 11L });

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
                    { 8L, 5L },
                    { 3L, 13L },
                    { 8L, 4L },
                    { 1L, 2L },
                    { 9L, 2L },
                    { 9L, 7L },
                    { 10L, 1L },
                    { 10L, 14L },
                    { 10L, 7L },
                    { 5L, 19L },
                    { 1L, 13L },
                    { 12L, 2L },
                    { 2L, 16L },
                    { 1L, 17L },
                    { 4L, 18L },
                    { 11L, 16L },
                    { 12L, 3L },
                    { 5L, 11L },
                    { 3L, 1L },
                    { 10L, 10L },
                    { 6L, 19L },
                    { 5L, 5L },
                    { 5L, 13L },
                    { 11L, 17L },
                    { 2L, 4L },
                    { 9L, 8L },
                    { 2L, 6L },
                    { 1L, 1L },
                    { 1L, 10L },
                    { 2L, 12L },
                    { 10L, 13L },
                    { 2L, 1L },
                    { 6L, 1L },
                    { 2L, 7L },
                    { 11L, 15L },
                    { 8L, 16L },
                    { 1L, 15L },
                    { 10L, 6L },
                    { 4L, 15L }
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
                columns: new[] { "PricePerHour", "ProjectName" },
                values: new object[] { 547.90m, "Future-proofed didactic capability" });

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
                columns: new[] { "PricePerHour", "ProjectName" },
                values: new object[] { 825.25m, "Polarised regional moratorium" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 10L,
                columns: new[] { "PricePerHour", "ProjectName" },
                values: new object[] { 990.44m, "Optional clear-thinking conglomeration" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 11L,
                columns: new[] { "PricePerHour", "ProjectName" },
                values: new object[] { 937.96m, "Synergized 6th generation synergy" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 12L,
                columns: new[] { "PricePerHour", "ProjectName" },
                values: new object[] { 774.36m, "Seamless transitional protocol" });

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
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 1L, 732.62m, "Integrated asymmetric success" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 16L,
                columns: new[] { "ClientId", "PricePerHour", "ProjectName" },
                values: new object[] { 6L, 778.92m, "Enterprise-wide neutral artificial intelligence" });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Monitored impactful alliance", new DateTime(2020, 1, 27, 6, 43, 1, 661, DateTimeKind.Unspecified).AddTicks(2043), 6L, 14L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Future-proofed next generation encryption", new DateTime(2020, 3, 17, 20, 6, 3, 709, DateTimeKind.Unspecified).AddTicks(1586), 12L, 16L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 6m, "Virtual incremental portal", new DateTime(2020, 6, 21, 22, 40, 56, 745, DateTimeKind.Unspecified).AddTicks(7013), 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 10L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 2m, "Down-sized national neural-net", new DateTime(2020, 2, 25, 23, 29, 4, 213, DateTimeKind.Unspecified).AddTicks(7665), 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 11L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 3m, "Diverse mission-critical implementation", new DateTime(2020, 8, 24, 19, 37, 52, 688, DateTimeKind.Unspecified).AddTicks(5976), 3L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Persistent intangible internet solution", new DateTime(2020, 1, 1, 6, 53, 46, 149, DateTimeKind.Unspecified).AddTicks(1995), 3L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 14L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 7m, "Reactive mission-critical utilisation", new DateTime(2020, 3, 22, 19, 35, 1, 692, DateTimeKind.Unspecified).AddTicks(3011), 16L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Cloned executive workforce", new DateTime(2020, 10, 6, 3, 25, 15, 451, DateTimeKind.Unspecified).AddTicks(4117), 9L, 10L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 5m, "De-engineered interactive installation", new DateTime(2020, 10, 12, 11, 0, 18, 841, DateTimeKind.Unspecified).AddTicks(2493), 15L });

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
                columns: new[] { "Comment", "Date", "ProjectId" },
                values: new object[] { "Synergized modular core", new DateTime(2020, 3, 3, 19, 33, 8, 580, DateTimeKind.Unspecified).AddTicks(7440), 4L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Customer-focused system-worthy protocol", new DateTime(2020, 2, 3, 10, 45, 29, 480, DateTimeKind.Unspecified).AddTicks(7138), 6L, 2L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 28L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Compatible eco-centric website", new DateTime(2020, 2, 29, 11, 44, 59, 644, DateTimeKind.Unspecified).AddTicks(8148), 12L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 29L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 3m, "Triple-buffered demand-driven Graphic Interface", new DateTime(2020, 6, 6, 14, 15, 27, 519, DateTimeKind.Unspecified).AddTicks(861), 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 30L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Vision-oriented asymmetric policy", new DateTime(2020, 12, 7, 5, 19, 5, 440, DateTimeKind.Unspecified).AddTicks(1582), 1L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 31L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Intuitive leading edge database", new DateTime(2020, 7, 23, 13, 25, 55, 407, DateTimeKind.Unspecified).AddTicks(9072), 1L, 2L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Secured analyzing groupware", new DateTime(2020, 2, 4, 20, 33, 45, 976, DateTimeKind.Unspecified).AddTicks(3854), 12L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 36L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Right-sized object-oriented task-force", new DateTime(2020, 11, 18, 5, 38, 53, 543, DateTimeKind.Unspecified).AddTicks(6320), 7L, 13L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Profound regional parallelism", new DateTime(2020, 9, 16, 20, 37, 51, 324, DateTimeKind.Unspecified).AddTicks(1998), 6L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 39L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 7m, "Persistent background architecture", new DateTime(2020, 12, 25, 0, 57, 34, 766, DateTimeKind.Unspecified).AddTicks(6178), 12L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 2m, "Face to face national hub", new DateTime(2020, 3, 8, 19, 57, 33, 23, DateTimeKind.Unspecified).AddTicks(2138), 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 44L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Polarised systematic methodology", new DateTime(2020, 11, 6, 1, 15, 7, 76, DateTimeKind.Unspecified).AddTicks(7021), 11L, 20L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 3m, "Multi-lateral next generation pricing structure", new DateTime(2020, 2, 20, 14, 1, 40, 344, DateTimeKind.Unspecified).AddTicks(3327), 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 48L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Persistent multi-tasking hardware", new DateTime(2020, 10, 24, 7, 37, 9, 369, DateTimeKind.Unspecified).AddTicks(6814), 2L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 49L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Decentralized clear-thinking circuit", new DateTime(2020, 2, 8, 15, 57, 5, 834, DateTimeKind.Unspecified).AddTicks(4724), 2L, 7L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Re-contextualized 6th generation time-frame", new DateTime(2020, 3, 14, 4, 43, 18, 589, DateTimeKind.Unspecified).AddTicks(3195), 6L, 15L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Adaptive fresh-thinking hardware", new DateTime(2020, 12, 23, 2, 28, 42, 190, DateTimeKind.Unspecified).AddTicks(2740), 12L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 59L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Stand-alone even-keeled framework", new DateTime(2020, 11, 14, 15, 53, 3, 441, DateTimeKind.Unspecified).AddTicks(1783), 10L, 7L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 1m, "Networked background projection", new DateTime(2020, 12, 22, 14, 12, 41, 130, DateTimeKind.Unspecified).AddTicks(468), 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 62L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Persistent 24 hour benchmark", new DateTime(2020, 8, 20, 14, 29, 37, 647, DateTimeKind.Unspecified).AddTicks(3259), 2L, 12L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Cross-platform eco-centric Graphical User Interface", new DateTime(2020, 12, 7, 22, 23, 53, 590, DateTimeKind.Unspecified).AddTicks(4780), 12L, 20L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Front-line mobile model", new DateTime(2020, 6, 23, 1, 10, 7, 524, DateTimeKind.Unspecified).AddTicks(319), 6L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 67L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Future-proofed contextually-based open architecture", new DateTime(2020, 6, 19, 11, 40, 13, 152, DateTimeKind.Unspecified).AddTicks(214), 10L, 7L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Seamless exuding flexibility", new DateTime(2020, 4, 20, 20, 37, 20, 283, DateTimeKind.Unspecified).AddTicks(6519), 11L, 2L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 7m, "Cloned object-oriented conglomeration", new DateTime(2020, 7, 26, 7, 13, 5, 33, DateTimeKind.Unspecified).AddTicks(7209), 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 73L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Focused national productivity", new DateTime(2020, 11, 6, 2, 55, 43, 208, DateTimeKind.Unspecified).AddTicks(3581), 12L, 4L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Fundamental needs-based orchestration", new DateTime(2020, 5, 3, 2, 6, 53, 466, DateTimeKind.Unspecified).AddTicks(8147), 7L, 15L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Extended exuding matrices", new DateTime(2020, 11, 9, 13, 42, 20, 808, DateTimeKind.Unspecified).AddTicks(748), 12L, 2L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Visionary asymmetric functionalities", new DateTime(2020, 6, 4, 17, 55, 33, 381, DateTimeKind.Unspecified).AddTicks(1181), 6L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 82L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Diverse disintermediate utilisation", new DateTime(2020, 10, 24, 6, 29, 27, 777, DateTimeKind.Unspecified).AddTicks(3868), 5L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 83L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Decentralized mission-critical complexity", new DateTime(2020, 7, 23, 9, 19, 50, 98, DateTimeKind.Unspecified).AddTicks(2879), 6L, 1L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Focused cohesive intranet", new DateTime(2020, 10, 16, 15, 19, 39, 434, DateTimeKind.Unspecified).AddTicks(629), 7L, 11L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Intuitive multimedia synergy", new DateTime(2020, 9, 27, 13, 28, 56, 282, DateTimeKind.Unspecified).AddTicks(8466), 7L, 15L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Ergonomic bandwidth-monitored conglomeration", new DateTime(2020, 2, 27, 22, 51, 4, 394, DateTimeKind.Unspecified).AddTicks(1055), 10L, 15L });

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
                columns: new[] { "Comment", "Date", "ProjectId" },
                values: new object[] { "Robust secondary superstructure", new DateTime(2020, 3, 24, 9, 33, 26, 922, DateTimeKind.Unspecified).AddTicks(6246), 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 100L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 8m, "Enterprise-wide modular analyzer", new DateTime(2020, 1, 5, 7, 13, 4, 694, DateTimeKind.Unspecified).AddTicks(7165), 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 101L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Versatile modular product", new DateTime(2020, 9, 3, 16, 38, 11, 233, DateTimeKind.Unspecified).AddTicks(6941), 12L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 102L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Reverse-engineered tangible software", new DateTime(2020, 1, 25, 2, 45, 28, 364, DateTimeKind.Unspecified).AddTicks(4991), 3L, 6L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "De-engineered asymmetric capacity", new DateTime(2020, 7, 9, 14, 4, 0, 143, DateTimeKind.Unspecified).AddTicks(7354), 5L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 105L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Networked clear-thinking monitoring", new DateTime(2020, 8, 26, 16, 6, 49, 475, DateTimeKind.Unspecified).AddTicks(6844), 7L, 16L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 1m, "Upgradable 6th generation model", new DateTime(2020, 10, 23, 19, 59, 5, 336, DateTimeKind.Unspecified).AddTicks(908), 15L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Realigned client-server moderator", new DateTime(2020, 9, 2, 9, 10, 8, 567, DateTimeKind.Unspecified).AddTicks(9074), 7L, 19L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Configurable multimedia utilisation", new DateTime(2020, 7, 26, 19, 15, 59, 842, DateTimeKind.Unspecified).AddTicks(6099), 9L, 16L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Versatile static challenge", new DateTime(2020, 6, 30, 10, 13, 54, 487, DateTimeKind.Unspecified).AddTicks(9337), 5L, 18L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Pre-emptive analyzing emulation", new DateTime(2020, 2, 23, 21, 35, 25, 554, DateTimeKind.Unspecified).AddTicks(271), 9L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 124L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Distributed explicit strategy", new DateTime(2020, 5, 1, 10, 2, 20, 207, DateTimeKind.Unspecified).AddTicks(4505), 12L, 12L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Integrated multi-tasking knowledge base", new DateTime(2020, 8, 12, 20, 9, 0, 176, DateTimeKind.Unspecified).AddTicks(8799), 9L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 133L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Advanced bi-directional Graphical User Interface", new DateTime(2020, 9, 7, 21, 7, 9, 86, DateTimeKind.Unspecified).AddTicks(1007), 5L, 2L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Pre-emptive systematic matrices", new DateTime(2020, 11, 14, 5, 45, 26, 400, DateTimeKind.Unspecified).AddTicks(8052), 1L, 17L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Multi-lateral 24/7 moderator", new DateTime(2020, 1, 29, 7, 41, 2, 226, DateTimeKind.Unspecified).AddTicks(3545), 3L, 2L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Progressive heuristic solution", new DateTime(2020, 10, 6, 15, 45, 42, 129, DateTimeKind.Unspecified).AddTicks(3091), 7L, 15L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 144L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 6m, "Profit-focused analyzing website", new DateTime(2020, 8, 15, 16, 25, 19, 666, DateTimeKind.Unspecified).AddTicks(7261), 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 145L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Open-architected non-volatile success", new DateTime(2020, 8, 19, 7, 50, 58, 828, DateTimeKind.Unspecified).AddTicks(2285), 11L, 12L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Mandatory stable toolset", new DateTime(2020, 1, 31, 15, 51, 15, 235, DateTimeKind.Unspecified).AddTicks(5692), 11L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 153L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Public-key dedicated orchestration", new DateTime(2020, 5, 31, 20, 27, 44, 127, DateTimeKind.Unspecified).AddTicks(9355), 11L, 16L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 2m, "Multi-layered asynchronous policy", new DateTime(2020, 8, 27, 19, 33, 30, 862, DateTimeKind.Unspecified).AddTicks(1761), 20L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Persistent context-sensitive policy", new DateTime(2020, 4, 13, 17, 3, 49, 794, DateTimeKind.Unspecified).AddTicks(7723), 11L, 9L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Synergistic upward-trending ability", new DateTime(2020, 4, 16, 21, 8, 13, 277, DateTimeKind.Unspecified).AddTicks(5852), 8L, 5L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Front-line dedicated core", new DateTime(2020, 5, 11, 0, 43, 21, 509, DateTimeKind.Unspecified).AddTicks(4069), 9L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 174L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Face to face secondary solution", new DateTime(2020, 1, 11, 22, 14, 7, 296, DateTimeKind.Unspecified).AddTicks(6552), 8L, 10L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 5m, "Team-oriented multi-tasking leverage", new DateTime(2020, 12, 17, 11, 36, 10, 874, DateTimeKind.Unspecified).AddTicks(2366), 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 177L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Seamless executive pricing structure", new DateTime(2020, 6, 10, 11, 22, 42, 268, DateTimeKind.Unspecified).AddTicks(408), 4L, 19L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 178L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 5m, "Progressive real-time solution", new DateTime(2020, 10, 17, 10, 53, 38, 98, DateTimeKind.Unspecified).AddTicks(999), 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 179L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Pre-emptive zero tolerance project", new DateTime(2020, 3, 10, 22, 14, 12, 543, DateTimeKind.Unspecified).AddTicks(4181), 2L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 180L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Automated leading edge challenge", new DateTime(2020, 8, 10, 5, 32, 11, 682, DateTimeKind.Unspecified).AddTicks(6854), 12L, 8L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Progressive regional internet solution", new DateTime(2020, 1, 5, 20, 38, 8, 26, DateTimeKind.Unspecified).AddTicks(2617), 7L, 17L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Cross-group scalable productivity", new DateTime(2020, 2, 21, 3, 44, 45, 371, DateTimeKind.Unspecified).AddTicks(3188), 8L, 12L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Open-source zero defect website", new DateTime(2020, 10, 4, 9, 38, 3, 417, DateTimeKind.Unspecified).AddTicks(6449), 9L, 13L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 191L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Total cohesive capacity", new DateTime(2020, 5, 16, 1, 5, 30, 536, DateTimeKind.Unspecified).AddTicks(9202), 3L, 20L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Integrated bottom-line superstructure", new DateTime(2020, 3, 23, 2, 27, 34, 574, DateTimeKind.Unspecified).AddTicks(7888), 3L, 20L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Networked multimedia monitoring", new DateTime(2020, 7, 15, 4, 6, 31, 363, DateTimeKind.Unspecified).AddTicks(6321), 3L, 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 196L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Virtual 3rd generation hierarchy", new DateTime(2020, 2, 12, 20, 52, 39, 784, DateTimeKind.Unspecified).AddTicks(9212), 10L, 2L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Stand-alone asymmetric help-desk", new DateTime(2020, 9, 13, 9, 57, 24, 487, DateTimeKind.Unspecified).AddTicks(7106), 8L, 4L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Ergonomic impactful product", new DateTime(2020, 5, 27, 16, 35, 4, 240, DateTimeKind.Unspecified).AddTicks(191), 11L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 201L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Cross-platform high-level hub", new DateTime(2020, 12, 24, 20, 24, 36, 836, DateTimeKind.Unspecified).AddTicks(2939), 11L, 1L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Organized context-sensitive local area network", new DateTime(2020, 4, 3, 0, 6, 11, 437, DateTimeKind.Unspecified).AddTicks(2935), 8L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 204L,
                columns: new[] { "Comment", "Date", "EmployeeId" },
                values: new object[] { "Reduced actuating architecture", new DateTime(2020, 5, 16, 19, 14, 39, 246, DateTimeKind.Unspecified).AddTicks(4266), 7L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Pre-emptive zero administration parallelism", new DateTime(2020, 9, 13, 16, 15, 20, 195, DateTimeKind.Unspecified).AddTicks(4250), 2L, 10L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Integrated background protocol", new DateTime(2020, 4, 22, 9, 14, 13, 181, DateTimeKind.Unspecified).AddTicks(7084), 8L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 213L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Seamless uniform emulation", new DateTime(2020, 9, 12, 12, 30, 40, 996, DateTimeKind.Unspecified).AddTicks(8347), 2L, 18L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Customizable multimedia matrix", new DateTime(2020, 7, 9, 19, 55, 31, 241, DateTimeKind.Unspecified).AddTicks(137), 8L, 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 216L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Grass-roots secondary moderator", new DateTime(2020, 9, 23, 17, 58, 53, 369, DateTimeKind.Unspecified).AddTicks(2509), 2L, 11L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Phased 4th generation workforce", new DateTime(2020, 10, 17, 14, 27, 18, 724, DateTimeKind.Unspecified).AddTicks(3215), 8L, 14L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 219L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 6m, "Open-architected motivating workforce", new DateTime(2020, 9, 22, 13, 9, 24, 124, DateTimeKind.Unspecified).AddTicks(6495), 16L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 220L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Multi-layered composite website", new DateTime(2020, 7, 20, 10, 10, 58, 89, DateTimeKind.Unspecified).AddTicks(9767), 5L, 20L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Intuitive 3rd generation definition", new DateTime(2020, 11, 30, 16, 36, 27, 727, DateTimeKind.Unspecified).AddTicks(7980), 2L, 11L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 227L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Optional systemic structure", new DateTime(2020, 4, 29, 17, 37, 49, 461, DateTimeKind.Unspecified).AddTicks(1189), 1L, 18L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 4m, "Fundamental methodical standardization", new DateTime(2020, 8, 7, 5, 21, 34, 64, DateTimeKind.Unspecified).AddTicks(9808), 1L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 1m, "Intuitive hybrid implementation", new DateTime(2020, 9, 2, 4, 0, 29, 919, DateTimeKind.Unspecified).AddTicks(3643), 11L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 6m, "Business-focused multi-state neural-net", new DateTime(2020, 8, 13, 13, 24, 1, 53, DateTimeKind.Unspecified).AddTicks(6693), 9L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 6m, "Synergized holistic middleware", new DateTime(2020, 7, 14, 20, 5, 24, 190, DateTimeKind.Unspecified).AddTicks(5639), 3L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Down-sized executive workforce", new DateTime(2020, 12, 10, 3, 7, 36, 862, DateTimeKind.Unspecified).AddTicks(615), 6L, 3L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "De-engineered context-sensitive structure", new DateTime(2020, 11, 18, 9, 3, 41, 900, DateTimeKind.Unspecified).AddTicks(9238), 12L, 15L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Fully-configurable full-range support", new DateTime(2020, 3, 15, 16, 27, 48, 711, DateTimeKind.Unspecified).AddTicks(6228), 2L, 10L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Operative coherent analyzer", new DateTime(2020, 3, 4, 3, 21, 1, 159, DateTimeKind.Unspecified).AddTicks(9323), 4L, 16L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 7m, "Enhanced systematic service-desk", new DateTime(2020, 4, 21, 17, 3, 37, 972, DateTimeKind.Unspecified).AddTicks(9897), 13L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Up-sized attitude-oriented structure", new DateTime(2020, 4, 25, 23, 14, 5, 541, DateTimeKind.Unspecified).AddTicks(2718), 2L, 7L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 271L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Triple-buffered non-volatile forecast", new DateTime(2020, 6, 16, 23, 40, 26, 266, DateTimeKind.Unspecified).AddTicks(7561), 4L, 10L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 272L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Enterprise-wide even-keeled strategy", new DateTime(2020, 8, 18, 6, 58, 46, 300, DateTimeKind.Unspecified).AddTicks(9412), 4L, 13L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 7m, "Multi-lateral bandwidth-monitored capacity", new DateTime(2020, 12, 1, 8, 54, 57, 619, DateTimeKind.Unspecified).AddTicks(7601), 9L, 3L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Integrated demand-driven application", new DateTime(2020, 2, 16, 7, 8, 34, 273, DateTimeKind.Unspecified).AddTicks(5318), 8L, 16L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Optional fresh-thinking local area network", new DateTime(2020, 4, 20, 14, 13, 9, 574, DateTimeKind.Unspecified).AddTicks(9941), 5L, 19L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Pre-emptive scalable complexity", new DateTime(2020, 8, 6, 15, 24, 23, 281, DateTimeKind.Unspecified).AddTicks(4472), 1L, 12L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 6m, "Compatible reciprocal benchmark", new DateTime(2020, 8, 1, 4, 23, 44, 859, DateTimeKind.Unspecified).AddTicks(2138), 2L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Mandatory analyzing application", new DateTime(2020, 10, 31, 10, 15, 7, 566, DateTimeKind.Unspecified).AddTicks(8373), 11L, 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 292L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Ameliorated analyzing superstructure", new DateTime(2020, 7, 29, 17, 32, 37, 358, DateTimeKind.Unspecified).AddTicks(6475), 11L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 293L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Robust mission-critical functionalities", new DateTime(2020, 4, 30, 21, 47, 58, 268, DateTimeKind.Unspecified).AddTicks(4319), 6L, 18L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 2m, "Networked scalable customer loyalty", new DateTime(2020, 10, 9, 12, 57, 47, 318, DateTimeKind.Unspecified).AddTicks(82), 1L, 9L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 7m, "Phased disintermediate benchmark", new DateTime(2020, 10, 18, 17, 24, 22, 957, DateTimeKind.Unspecified).AddTicks(4665), 4L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 304L,
                columns: new[] { "Comment", "Date", "EmployeeId" },
                values: new object[] { "Sharable tertiary utilisation", new DateTime(2020, 4, 5, 2, 45, 26, 849, DateTimeKind.Unspecified).AddTicks(3997), 1L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 305L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Optimized eco-centric access", new DateTime(2020, 11, 21, 0, 5, 20, 491, DateTimeKind.Unspecified).AddTicks(2008), 11L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 306L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Expanded grid-enabled emulation", new DateTime(2020, 1, 5, 7, 51, 54, 375, DateTimeKind.Unspecified).AddTicks(3422), 11L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 307L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 4m, "Face to face reciprocal algorithm", new DateTime(2020, 2, 19, 14, 2, 57, 584, DateTimeKind.Unspecified).AddTicks(1472), 4L, 14L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Assimilated zero defect forecast", new DateTime(2020, 5, 31, 21, 40, 31, 943, DateTimeKind.Unspecified).AddTicks(1922), 1L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 314L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Devolved content-based capability", new DateTime(2020, 12, 30, 19, 27, 11, 270, DateTimeKind.Unspecified).AddTicks(9538), 9L, 1L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Universal 5th generation productivity", new DateTime(2020, 2, 13, 13, 54, 46, 429, DateTimeKind.Unspecified).AddTicks(5388), 7L, 3L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Focused contextually-based benchmark", new DateTime(2020, 12, 10, 12, 39, 1, 666, DateTimeKind.Unspecified).AddTicks(9819), 8L, 20L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Decentralized asynchronous toolset", new DateTime(2020, 1, 26, 21, 16, 42, 710, DateTimeKind.Unspecified).AddTicks(1069), 4L, 9L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 327L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 6m, "Self-enabling high-level software", new DateTime(2020, 11, 4, 1, 49, 25, 383, DateTimeKind.Unspecified).AddTicks(4225), 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 328L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Optional radical moratorium", new DateTime(2020, 4, 11, 9, 9, 1, 818, DateTimeKind.Unspecified).AddTicks(4002), 6L, 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 329L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Robust full-range internet solution", new DateTime(2020, 10, 1, 10, 5, 18, 662, DateTimeKind.Unspecified).AddTicks(6887), 8L, 1L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Profound full-range middleware", new DateTime(2020, 2, 21, 8, 57, 26, 994, DateTimeKind.Unspecified).AddTicks(6892), 3L, 6L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 333L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Seamless intangible emulation", new DateTime(2020, 4, 30, 11, 10, 55, 887, DateTimeKind.Unspecified).AddTicks(1606), 10L, 7L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Future-proofed 6th generation hardware", new DateTime(2020, 4, 2, 3, 26, 25, 82, DateTimeKind.Unspecified).AddTicks(4965), 12L, 13L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Virtual user-facing moratorium", new DateTime(2020, 1, 26, 20, 6, 27, 304, DateTimeKind.Unspecified).AddTicks(9671), 3L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 340L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 8m, "Compatible intermediate application", new DateTime(2020, 8, 25, 4, 46, 16, 42, DateTimeKind.Unspecified).AddTicks(4306), 2L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Innovative needs-based secured line", new DateTime(2020, 9, 18, 11, 22, 35, 994, DateTimeKind.Unspecified).AddTicks(1259), 2L, 17L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 347L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 4m, "Programmable 3rd generation neural-net", new DateTime(2020, 4, 2, 9, 56, 26, 709, DateTimeKind.Unspecified).AddTicks(4683), 7L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Front-line fresh-thinking local area network", new DateTime(2020, 6, 2, 5, 18, 35, 94, DateTimeKind.Unspecified).AddTicks(7988), 4L, 12L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 360L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Multi-layered contextually-based application", new DateTime(2020, 9, 13, 23, 59, 54, 428, DateTimeKind.Unspecified).AddTicks(8373), 7L, 13L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Vision-oriented multi-state local area network", new DateTime(2020, 10, 2, 22, 24, 21, 234, DateTimeKind.Unspecified).AddTicks(7859), 10L, 18L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 364L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 3m, "Persevering web-enabled hub", new DateTime(2020, 12, 2, 12, 0, 53, 73, DateTimeKind.Unspecified).AddTicks(4800), 8L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 365L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 5m, "Front-line systemic internet solution", new DateTime(2020, 4, 21, 15, 21, 58, 866, DateTimeKind.Unspecified).AddTicks(2176), 3L, 13L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Configurable neutral open architecture", new DateTime(2020, 1, 15, 18, 5, 52, 104, DateTimeKind.Unspecified).AddTicks(4975), 5L, 3L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Public-key contextually-based architecture", new DateTime(2020, 10, 2, 11, 30, 56, 367, DateTimeKind.Unspecified).AddTicks(8756), 12L, 20L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 376L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Secured 5th generation flexibility", new DateTime(2020, 2, 2, 3, 1, 42, 99, DateTimeKind.Unspecified).AddTicks(5921), 2L, 19L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Progressive responsive knowledge user", new DateTime(2020, 11, 3, 14, 10, 32, 91, DateTimeKind.Unspecified).AddTicks(9215), 2L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 380L,
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Organized intangible encryption", new DateTime(2020, 10, 22, 20, 4, 47, 676, DateTimeKind.Unspecified).AddTicks(7808), 4L, 1L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Function-based leading edge projection", new DateTime(2020, 8, 15, 7, 42, 22, 820, DateTimeKind.Unspecified).AddTicks(8480), 11L, 5L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 384L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId" },
                values: new object[] { 1m, "Exclusive regional website", new DateTime(2020, 1, 6, 17, 22, 2, 575, DateTimeKind.Unspecified).AddTicks(3673), 9L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 8m, "Team-oriented 6th generation system engine", new DateTime(2020, 11, 28, 5, 57, 32, 776, DateTimeKind.Unspecified).AddTicks(2260), 5L, 4L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "ProjectId" },
                values: new object[] { 5m, "Integrated discrete core", new DateTime(2020, 6, 18, 13, 56, 5, 913, DateTimeKind.Unspecified).AddTicks(1954), 3L });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryId",
                keyValue: 390L,
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 1m, "Enhanced heuristic instruction set", new DateTime(2020, 1, 11, 18, 2, 0, 201, DateTimeKind.Unspecified).AddTicks(2692), 3L, 3L });

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
                columns: new[] { "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { "Re-engineered 6th generation flexibility", new DateTime(2020, 3, 19, 3, 20, 16, 904, DateTimeKind.Unspecified).AddTicks(8112), 8L, 9L });

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
                columns: new[] { "AmountOfHours", "Comment", "Date", "EmployeeId", "ProjectId" },
                values: new object[] { 6m, "Triple-buffered homogeneous portal", new DateTime(2020, 8, 24, 19, 25, 46, 547, DateTimeKind.Unspecified).AddTicks(8567), 2L, 5L });

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
