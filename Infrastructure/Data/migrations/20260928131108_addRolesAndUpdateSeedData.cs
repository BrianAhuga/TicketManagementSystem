using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Data.migrations
{
    /// <inheritdoc />
    public partial class addRolesAndUpdateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "14ccdd59-817a-48ff-b09d-15a3d8defa6a", null, "Admin", "ADMIN" },
                    { "b3bd0df7-a483-49e2-9c5f-6a381ba150ec", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-50d4165d63b9",
                columns: new[] { "ConcurrencyStamp", "IsDeleted", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0615b752-1951-45f8-9e63-4a27d5585650", false, "AQAAAAIAAYagAAAAEAbrhTzzuGpBg+lWzEGSgyZkePNUOBenS5EnkMj/C/Yb71liKYZxhhRHUqk6r+H/Hw==", "2d2669e7-f5a5-4409-ac6a-8f1c53fdc99d" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 1, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 1, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 9,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 3, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 10,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 11,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 12,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 6, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 13,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 14,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 15,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 16,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 17,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 18,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 3, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 19,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 20,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 21,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 6, 10, 7, 40, 49, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 5, 7, 40, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 22,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 1, 6, 23, 56, 10, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 6, 15, 56, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 23,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 1, 9, 16, 10, 57, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 1, 16, 10, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 24,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 1, 24, 3, 16, 57, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 23, 19, 16, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 25,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 1, 27, 4, 18, 47, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 22, 4, 18, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 26,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 6, 7, 0, 28, 17, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 30, 0, 28, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 27,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 5, 10, 20, 13, 4, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 2, 20, 13, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 28,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 7, 28, 21, 1, 34, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 28, 13, 1, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 29,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 1, 6, 9, 3, 20, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 1, 9, 3, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 30,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 4, 26, 18, 56, 12, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 21, 18, 56, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 31,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 12, 5, 11, 40, 49, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 5, 3, 40, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 32,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 8, 15, 12, 50, 18, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 10, 12, 50, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 33,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 8, 6, 5, 16, 30, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 29, 5, 16, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 34,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 12, 25, 14, 40, 25, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 25, 6, 40, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 35,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 8, 7, 11, 10, 42, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 30, 11, 10, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 36,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 1, 1, 4, 36, 12, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 31, 20, 36, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 37,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 11, 15, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 1, 12, 11, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 38,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 10, 20, 10, 43, 29, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 12, 10, 43, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 39,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 7, 20, 8, 50, 11, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 15, 8, 50, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 40,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 4, 22, 17, 28, 30, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 22, 9, 28, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 41,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 9, 22, 14, 15, 30, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 14, 14, 15, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 42,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 12, 8, 11, 23, 18, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 3, 11, 23, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 43,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 10, 27, 22, 19, 44, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 22, 16, 19, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 44,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 11, 15, 9, 7, 55, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 7, 9, 7, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 45,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 7, 23, 12, 41, 29, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 18, 12, 41, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 46,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 9, 5, 18, 56, 11, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 5, 10, 56, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 47,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 4, 22, 13, 13, 30, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 14, 13, 13, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 48,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 2, 13, 17, 12, 15, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 8, 17, 12, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 49,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 3, 16, 15, 45, 48, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 16, 7, 45, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 50,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 12, 3, 16, 19, 33, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 25, 16, 19, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 51,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 10, 9, 15, 26, 21, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 1, 15, 26, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 52,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 10, 4, 8, 30, 17, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 29, 8, 30, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 53,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 1, 13, 22, 36, 48, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 13, 14, 36, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 54,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 8, 26, 10, 17, 29, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 21, 10, 17, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 55,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 5, 20, 13, 59, 36, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 20, 5, 59, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 56,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 11, 27, 16, 23, 9, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 19, 16, 23, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 57,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 8, 15, 9, 40, 13, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 10, 9, 40, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 58,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 11, 7, 11, 7, 25, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 30, 11, 7, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 59,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 6, 15, 20, 19, 44, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 15, 12, 19, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 60,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2026, 9, 7, 18, 24, 59, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 2, 18, 24, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "14ccdd59-817a-48ff-b09d-15a3d8defa6a", "62f94fe7-0580-42df-969c-50d4165d63b9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3bd0df7-a483-49e2-9c5f-6a381ba150ec");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "14ccdd59-817a-48ff-b09d-15a3d8defa6a", "62f94fe7-0580-42df-969c-50d4165d63b9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14ccdd59-817a-48ff-b09d-15a3d8defa6a");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-50d4165d63b9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "288275e7-376c-484f-9c7f-12e0080d6c80", "AQAAAAIAAYagAAAAEP47dFfhnqXJ58bUbk0HndGYnacGFtGGOnEjhu2+LexP9B/qi7mn2vqR4JCFIaag+g==", "0715baf8-9067-4888-bb15-833940e96745" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 9, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 9, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 9,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 3, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 10,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 11,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 12,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 6, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 13,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 14,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 15,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 9, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 16,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 17,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 18,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 3, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 19,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 20,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 21,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 6, 10, 7, 40, 49, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 5, 7, 40, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 22,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2023, 11, 6, 23, 56, 10, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 6, 15, 56, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 23,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2023, 10, 9, 16, 10, 57, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 16, 10, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 24,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2023, 10, 24, 3, 16, 57, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 23, 19, 16, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 25,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2023, 11, 27, 4, 18, 47, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 22, 4, 18, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 26,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 6, 7, 0, 28, 17, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 30, 0, 28, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 27,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 10, 20, 13, 4, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 2, 20, 13, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 28,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 7, 28, 21, 1, 34, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 28, 13, 1, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 29,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2023, 10, 6, 9, 3, 20, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 3, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 30,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 26, 18, 56, 12, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 21, 18, 56, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 31,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2023, 12, 5, 11, 40, 49, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 5, 3, 40, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 32,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 50, 18, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 10, 12, 50, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 33,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2023, 8, 6, 5, 16, 30, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 29, 5, 16, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 34,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 14, 40, 25, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 25, 6, 40, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 35,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2023, 8, 7, 11, 10, 42, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 30, 11, 10, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 36,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 1, 1, 4, 36, 12, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 20, 36, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 37,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2023, 9, 6, 12, 11, 15, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 1, 12, 11, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 38,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 43, 29, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 12, 10, 43, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 39,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 7, 20, 8, 50, 11, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 15, 8, 50, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 40,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 17, 28, 30, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 22, 9, 28, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 41,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2023, 9, 22, 14, 15, 30, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 14, 14, 15, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 42,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2023, 12, 8, 11, 23, 18, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 3, 11, 23, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 43,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2023, 10, 27, 22, 19, 44, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 22, 16, 19, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 44,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2023, 11, 15, 9, 7, 55, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 7, 9, 7, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 45,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2023, 7, 23, 12, 41, 29, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 18, 12, 41, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 46,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2023, 9, 5, 18, 56, 11, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 5, 10, 56, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 47,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 13, 13, 30, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 14, 13, 13, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 48,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 12, 15, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 8, 17, 12, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 49,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 3, 16, 15, 45, 48, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 16, 7, 45, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 50,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 19, 33, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 25, 16, 19, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 51,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2023, 10, 9, 15, 26, 21, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 15, 26, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 52,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2023, 10, 4, 8, 30, 17, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 29, 8, 30, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 53,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 1, 13, 22, 36, 48, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 13, 14, 36, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 54,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 10, 17, 29, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 21, 10, 17, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 55,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 20, 13, 59, 36, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 20, 5, 59, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 56,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2023, 11, 27, 16, 23, 9, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 19, 16, 23, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 57,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2023, 8, 15, 9, 40, 13, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 10, 9, 40, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 58,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2023, 11, 7, 11, 7, 25, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 30, 11, 7, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 59,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 6, 15, 20, 19, 44, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 15, 12, 19, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 60,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2023, 9, 7, 18, 24, 59, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 2, 18, 24, 59, 0, DateTimeKind.Unspecified) });
        }
    }
}
