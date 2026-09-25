using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.migrations
{
    /// <inheritdoc />
    public partial class updateAttachmentFileSizeType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "Attachments",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-50d4165d63b9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b128e41e-b909-4e61-a885-5c9e54e313f4", "AQAAAAIAAYagAAAAEKnmIxrZ9GbCbEwRHLLwp/zppdtOmo2Us3ATSTdvWo24LcWSptaWRqXqoQRW4I3QUw==", "3eee2c32-1f4f-430e-8175-37e0ba7cb649" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "Attachments",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-50d4165d63b9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d79b09b-964b-4468-888a-11b1d894149c", "AQAAAAIAAYagAAAAELtcNa+QMgF96KM/CbAxaVLxTEw5UnSp/L6DUGUzybqCJ/cgli/pBFpYIjLtxnsfZg==", "b55fe4ad-1f87-44ba-93f8-431076c0e346" });
        }
    }
}
