using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiPetShop.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDataTypeOfClientPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Contrasena",
                table: "Cliente",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "ClienteId",
                keyValue: 1,
                column: "Contrasena",
                value: "12345");

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "ClienteId",
                keyValue: 2,
                column: "Contrasena",
                value: "12345");

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "ClienteId",
                keyValue: 3,
                column: "Contrasena",
                value: "12345");

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "ClienteId",
                keyValue: 4,
                column: "Contrasena",
                value: "12345");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Contrasena",
                table: "Cliente",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "ClienteId",
                keyValue: 1,
                column: "Contrasena",
                value: 1864045727);

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "ClienteId",
                keyValue: 2,
                column: "Contrasena",
                value: 1864045727);

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "ClienteId",
                keyValue: 3,
                column: "Contrasena",
                value: 1864045727);

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "ClienteId",
                keyValue: 4,
                column: "Contrasena",
                value: 1864045727);
        }
    }
}
