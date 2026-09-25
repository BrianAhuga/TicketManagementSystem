using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.migrations
{
    /// <inheritdoc />
    public partial class updateColumnNameClosedByDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClosedDate",
                table: "Tickets",
                newName: "ClosedByDate");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-50d4165d63b9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b284c96b-2f7a-4057-ae7a-a19c5c9ebbbc", "AQAAAAIAAYagAAAAEOd30+5g9LglFBVWzbippI2ufMLiVgf4sXjxy7hOj4+zgCh4c2mVCzuGX0Z3jBIpcg==", "34612830-edb4-41fb-a556-7fd00d2cf35e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClosedByDate",
                table: "Tickets",
                newName: "ClosedDate");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-50d4165d63b9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8a0032b-37f9-44a5-97d1-c7b76e3427a3", "AQAAAAIAAYagAAAAEMy+2vI/iTD0Kg/25sdeeS3fLeTZwtoCe6l5/9bJjRGrbVH7gDCx9+WdpRkhXDJzGQ==", "0be8d55c-9aa9-44f1-966b-cc27feb202f9" });
        }
    }
}
