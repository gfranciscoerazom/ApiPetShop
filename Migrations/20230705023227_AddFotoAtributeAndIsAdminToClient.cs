using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiPetShop.Migrations
{
    /// <inheritdoc />
    public partial class AddFotoAtributeAndIsAdminToClient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Foto",
                table: "Cliente",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "Cliente",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "ClienteId",
                keyValue: 1,
                columns: new[] { "Foto", "IsAdmin" },
                values: new object[] { "https://www.pngall.com/wp-content/uploads/5/Profile-Avatar-PNG-Picture.png", true });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "ClienteId",
                keyValue: 2,
                columns: new[] { "Foto", "IsAdmin" },
                values: new object[] { "https://www.pngall.com/wp-content/uploads/5/Profile-Avatar-PNG-Picture.png", false });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "ClienteId",
                keyValue: 3,
                columns: new[] { "Foto", "IsAdmin" },
                values: new object[] { "https://www.pngall.com/wp-content/uploads/5/Profile-Avatar-PNG-Picture.png", true });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "ClienteId",
                keyValue: 4,
                columns: new[] { "Foto", "IsAdmin" },
                values: new object[] { "https://www.pngall.com/wp-content/uploads/5/Profile-Avatar-PNG-Picture.png", false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Cliente");
        }
    }
}
