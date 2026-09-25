using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.migrations
{
    /// <inheritdoc />
    public partial class addClosedByInTicket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClosedBy",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ClosedDate",
                table: "Tickets",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedDate",
                table: "Tickets",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-50d4165d63b9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8a0032b-37f9-44a5-97d1-c7b76e3427a3", "AQAAAAIAAYagAAAAEMy+2vI/iTD0Kg/25sdeeS3fLeTZwtoCe6l5/9bJjRGrbVH7gDCx9+WdpRkhXDJzGQ==", "0be8d55c-9aa9-44f1-966b-cc27feb202f9" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 9,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 10,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 11,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 12,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 13,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 14,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 15,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 16,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 17,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 18,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 19,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 20,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 21,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 22,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 23,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 24,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 25,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 26,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 27,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 28,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 29,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 30,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 31,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 32,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 33,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 34,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 35,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 36,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 37,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 38,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 39,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 40,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 41,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 42,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 43,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 44,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 45,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 46,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 47,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 48,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 49,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 50,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 51,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 52,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 53,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 54,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 55,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 56,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 57,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 58,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 59,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 60,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdatedDate" },
                values: new object[] { null, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClosedBy",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "ClosedDate",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "LastUpdatedDate",
                table: "Tickets");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-50d4165d63b9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59b3d070-8be0-4b91-b0cd-2fd0785a4ebb", "AQAAAAIAAYagAAAAEDUWhZZI4m80geTwaoA9SzpS6nlg1GFnOO04YwW+b8osTu5Jq08xcDtJadT2QS97VA==", "cc86ffb0-6e0c-46ea-b8a6-31504d0dd1a2" });
        }
    }
}
