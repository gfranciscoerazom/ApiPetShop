using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiPetShop.Migrations
{
    /// <inheritdoc />
    public partial class PasswordToCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Contrasena",
                table: "Cliente",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contrasena",
                table: "Cliente");
        }
    }
}
