using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.migrations
{
    /// <inheritdoc />
    public partial class updateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-50d4165d63b9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d79b09b-964b-4468-888a-11b1d894149c", "AQAAAAIAAYagAAAAELtcNa+QMgF96KM/CbAxaVLxTEw5UnSp/L6DUGUzybqCJ/cgli/pBFpYIjLtxnsfZg==", "b55fe4ad-1f87-44ba-93f8-431076c0e346" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 11,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 14,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 17,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 20,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 21,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 22,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 23,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 24,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 25,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 26,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 27,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 28,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 29,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 30,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 31,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 32,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 33,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 34,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 35,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 36,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 37,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 38,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 39,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 40,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 41,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 42,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 43,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 44,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 45,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 46,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 47,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 48,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 49,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 50,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 51,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 52,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 53,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 54,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 55,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 56,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 57,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 58,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 59,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 60,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-50d4165d63b9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b284c96b-2f7a-4057-ae7a-a19c5c9ebbbc", "AQAAAAIAAYagAAAAEOd30+5g9LglFBVWzbippI2ufMLiVgf4sXjxy7hOj4+zgCh4c2mVCzuGX0Z3jBIpcg==", "34612830-edb4-41fb-a556-7fd00d2cf35e" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 11,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 14,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 17,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 20,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 21,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 22,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 23,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 24,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 25,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 26,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 27,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 28,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 29,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 30,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 31,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 32,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 33,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 34,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 35,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 36,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 37,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 38,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 39,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 40,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 41,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 42,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 43,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 44,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 45,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 46,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 47,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 48,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 49,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 50,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 51,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 52,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 53,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 54,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 55,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 56,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 57,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 58,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 59,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 60,
                columns: new[] { "ClosedBy", "ClosedByDate" },
                values: new object[] { null, null });
        }
    }
}
