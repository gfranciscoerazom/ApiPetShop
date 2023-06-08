using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiPetShop.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Numero = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Contactos",
                columns: table => new
                {
                    ContactoId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Apellido = table.Column<string>(type: "text", nullable: false),
                    Cedula = table.Column<string>(type: "text", nullable: false),
                    Direccion = table.Column<string>(type: "text", nullable: false),
                    Telefono = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Imagen = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contactos", x => x.ContactoId);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    ProductoId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    Precio = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.ProductoId);
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "ClienteId", "Email", "Nombre", "Numero" },
                values: new object[,]
                {
                    { 1, "juan@gmail.com", "Juan", "1234567890" },
                    { 2, "pedro@gmail.com", "Pedro", "1234567890" },
                    { 3, "maria@gmail.com", "Maria", "1234567890" },
                    { 4, "luis@gmail.com", "Luis", "1234567890" }
                });

            migrationBuilder.InsertData(
                table: "Contactos",
                columns: new[] { "ContactoId", "Apellido", "Cedula", "Direccion", "Email", "Imagen", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Apellido 1", "1234567890", "Direccion 1", "contacto1@email.com", "https://www.pngall.com/wp-content/uploads/5/Profile-Avatar-PNG-Picture.png", "Nombre 1", "1234567890" },
                    { 2, "Apellido 2", "1234567890", "Direccion 2", "contacto2@email.com", "https://www.pngall.com/wp-content/uploads/5/Profile-Avatar-PNG-Picture.png", "Nombre 2", "1234567890" },
                    { 3, "Apellido 3", "1234567890", "Direccion 3", "contacto3@email.com", "https://www.pngall.com/wp-content/uploads/5/Profile-Avatar-PNG-Picture.png", "Nombre 3", "1234567890" }
                });

            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "ProductoId", "Descripcion", "Nombre", "Precio" },
                values: new object[,]
                {
                    { 1, "Descripcion 1", "Producto 1", 100.0 },
                    { 2, "Descripcion 2", "Producto 2", 200.0 },
                    { 3, "Descripcion 3", "Producto 3", 300.0 },
                    { 4, "Descripcion 4", "Producto 4", 400.0 },
                    { 5, "Descripcion 5", "Producto 5", 500.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Contactos");

            migrationBuilder.DropTable(
                name: "Producto");
        }
    }
}
