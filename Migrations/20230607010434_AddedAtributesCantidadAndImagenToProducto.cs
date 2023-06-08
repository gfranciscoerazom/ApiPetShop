using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiPetShop.Migrations
{
    /// <inheritdoc />
    public partial class AddedAtributesCantidadAndImagenToProducto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cantidad",
                table: "Producto",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Imagen",
                table: "Producto",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "ProductoId",
                keyValue: 1,
                columns: new[] { "Cantidad", "Imagen" },
                values: new object[] { 13, "https://img.elo7.com.br/product/zoom/2CA6D43/chaveiro-ossinho-pet-shop-petshop.jpg" });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "ProductoId",
                keyValue: 2,
                columns: new[] { "Cantidad", "Imagen" },
                values: new object[] { 40, "https://img.elo7.com.br/product/zoom/335FD6C/lembrancinha-para-pet-shop-chaveiro-natal.jpg" });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "ProductoId",
                keyValue: 3,
                columns: new[] { "Cantidad", "Imagen" },
                values: new object[] { 10, "https://img.elo7.com.br/product/zoom/336A80E/lembrancinha-pet-shop-cachorro-lembrancinha-padrinho.jpg" });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "ProductoId",
                keyValue: 4,
                columns: new[] { "Cantidad", "Imagen" },
                values: new object[] { 5, "https://www.mypetbrasil.com/img/products/kit-produtos-pet-petshop-atacado-revenda-1_1_630.jpg" });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "ProductoId",
                keyValue: 5,
                columns: new[] { "Cantidad", "Imagen" },
                values: new object[] { 3, "https://images.pexels.com/photos/1564506/pexels-photo-1564506.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "Imagen",
                table: "Producto");
        }
    }
}
