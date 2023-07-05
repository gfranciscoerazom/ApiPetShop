﻿// <auto-generated />
using ApiPetShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ApiPetShop.Migrations
{
    [DbContext(typeof(AppEFContext))]
    [Migration("20230705023227_AddFotoAtributeAndIsAdminToClient")]
    partial class AddFotoAtributeAndIsAdminToClient
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ApiPetShop.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ClienteId"));

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("boolean");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente", (string)null);

                    b.HasData(
                        new
                        {
                            ClienteId = 1,
                            Contrasena = "12345",
                            Email = "juan@gmail.com",
                            Foto = "https://www.pngall.com/wp-content/uploads/5/Profile-Avatar-PNG-Picture.png",
                            IsAdmin = true,
                            Nombre = "Juan",
                            Numero = "1234567890"
                        },
                        new
                        {
                            ClienteId = 2,
                            Contrasena = "12345",
                            Email = "pedro@gmail.com",
                            Foto = "https://www.pngall.com/wp-content/uploads/5/Profile-Avatar-PNG-Picture.png",
                            IsAdmin = false,
                            Nombre = "Pedro",
                            Numero = "1234567890"
                        },
                        new
                        {
                            ClienteId = 3,
                            Contrasena = "12345",
                            Email = "maria@gmail.com",
                            Foto = "https://www.pngall.com/wp-content/uploads/5/Profile-Avatar-PNG-Picture.png",
                            IsAdmin = true,
                            Nombre = "Maria",
                            Numero = "1234567890"
                        },
                        new
                        {
                            ClienteId = 4,
                            Contrasena = "12345",
                            Email = "luis@gmail.com",
                            Foto = "https://www.pngall.com/wp-content/uploads/5/Profile-Avatar-PNG-Picture.png",
                            IsAdmin = false,
                            Nombre = "Luis",
                            Numero = "1234567890"
                        });
                });

            modelBuilder.Entity("ApiPetShop.Models.Contacto", b =>
                {
                    b.Property<int>("ContactoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ContactoId"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Imagen")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ContactoId");

                    b.ToTable("Contactos", (string)null);

                    b.HasData(
                        new
                        {
                            ContactoId = 1,
                            Apellido = "Apellido 1",
                            Cedula = "1234567890",
                            Direccion = "Direccion 1",
                            Email = "contacto1@email.com",
                            Imagen = "https://www.pngall.com/wp-content/uploads/5/Profile-Avatar-PNG-Picture.png",
                            Nombre = "Nombre 1",
                            Telefono = "1234567890"
                        },
                        new
                        {
                            ContactoId = 2,
                            Apellido = "Apellido 2",
                            Cedula = "1234567890",
                            Direccion = "Direccion 2",
                            Email = "contacto2@email.com",
                            Imagen = "https://www.pngall.com/wp-content/uploads/5/Profile-Avatar-PNG-Picture.png",
                            Nombre = "Nombre 2",
                            Telefono = "1234567890"
                        },
                        new
                        {
                            ContactoId = 3,
                            Apellido = "Apellido 3",
                            Cedula = "1234567890",
                            Direccion = "Direccion 3",
                            Email = "contacto3@email.com",
                            Imagen = "https://www.pngall.com/wp-content/uploads/5/Profile-Avatar-PNG-Picture.png",
                            Nombre = "Nombre 3",
                            Telefono = "1234567890"
                        });
                });

            modelBuilder.Entity("ApiPetShop.Models.Producto", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProductoId"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("integer");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Imagen")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Precio")
                        .HasColumnType("double precision");

                    b.HasKey("ProductoId");

                    b.ToTable("Producto", (string)null);

                    b.HasData(
                        new
                        {
                            ProductoId = 1,
                            Cantidad = 13,
                            Descripcion = "Descripcion 1",
                            Imagen = "https://img.elo7.com.br/product/zoom/2CA6D43/chaveiro-ossinho-pet-shop-petshop.jpg",
                            Nombre = "Producto 1",
                            Precio = 100.0
                        },
                        new
                        {
                            ProductoId = 2,
                            Cantidad = 40,
                            Descripcion = "Descripcion 2",
                            Imagen = "https://img.elo7.com.br/product/zoom/335FD6C/lembrancinha-para-pet-shop-chaveiro-natal.jpg",
                            Nombre = "Producto 2",
                            Precio = 200.0
                        },
                        new
                        {
                            ProductoId = 3,
                            Cantidad = 10,
                            Descripcion = "Descripcion 3",
                            Imagen = "https://img.elo7.com.br/product/zoom/336A80E/lembrancinha-pet-shop-cachorro-lembrancinha-padrinho.jpg",
                            Nombre = "Producto 3",
                            Precio = 300.0
                        },
                        new
                        {
                            ProductoId = 4,
                            Cantidad = 5,
                            Descripcion = "Descripcion 4",
                            Imagen = "https://www.mypetbrasil.com/img/products/kit-produtos-pet-petshop-atacado-revenda-1_1_630.jpg",
                            Nombre = "Producto 4",
                            Precio = 400.0
                        },
                        new
                        {
                            ProductoId = 5,
                            Cantidad = 3,
                            Descripcion = "Descripcion 5",
                            Imagen = "https://images.pexels.com/photos/1564506/pexels-photo-1564506.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
                            Nombre = "Producto 5",
                            Precio = 500.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
