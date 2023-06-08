using System;
using ApiPetShop.Models;

namespace ApiPetShop.Utils
{

    public class Util
    {
        public static Util Instance { get; } = new Util();

        private Util()
        {
        }

        public List<Cliente> GetDatosDePruebaClientes()
        {
            return new List<Cliente>()
            {
                new Cliente(1, "Juan", "juan@gmail.com", "1234567890", "12345"),
                new Cliente(2, "Pedro", "pedro@gmail.com", "1234567890", "12345"),
                new Cliente(3, "Maria", "maria@gmail.com", "1234567890", "12345"),
                new Cliente(4, "Luis", "luis@gmail.com", "1234567890", "12345")
            };
        }

        public List<Producto> GetDatosDePruebaProductos()
        {
            return new List<Producto>()
            {
                new Producto(1, "Producto 1", "Descripcion 1", 100.00, 13, "https://img.elo7.com.br/product/zoom/2CA6D43/chaveiro-ossinho-pet-shop-petshop.jpg"),
                new Producto(2, "Producto 2", "Descripcion 2", 200.00, 40, "https://img.elo7.com.br/product/zoom/335FD6C/lembrancinha-para-pet-shop-chaveiro-natal.jpg"),
                new Producto(3, "Producto 3", "Descripcion 3", 300.00, 10, "https://img.elo7.com.br/product/zoom/336A80E/lembrancinha-pet-shop-cachorro-lembrancinha-padrinho.jpg"),
                new Producto(4, "Producto 4", "Descripcion 4", 400.00, 5, "https://www.mypetbrasil.com/img/products/kit-produtos-pet-petshop-atacado-revenda-1_1_630.jpg"),
                new Producto(5, "Producto 5", "Descripcion 5", 500.00, 3, "https://images.pexels.com/photos/1564506/pexels-photo-1564506.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2")
            };
        }

        public List<Contacto> GetDatosDePruebaContactos()
        {
            return new List<Contacto>()
            {
                new Contacto("Nombre 1", "Apellido 1", "1234567890", "Direccion 1", "1234567890", "contacto1@email.com", "https://www.pngall.com/wp-content/uploads/5/Profile-Avatar-PNG-Picture.png")
                {
                    ContactoId = 1
                },
                new Contacto("Nombre 2", "Apellido 2", "1234567890", "Direccion 2", "1234567890", "contacto2@email.com", "https://www.pngall.com/wp-content/uploads/5/Profile-Avatar-PNG-Picture.png")
                {
                    ContactoId = 2
                },
                new Contacto("Nombre 3", "Apellido 3", "1234567890", "Direccion 3", "1234567890", "contacto3@email.com", "https://www.pngall.com/wp-content/uploads/5/Profile-Avatar-PNG-Picture.png")
                {
                    ContactoId = 3
                }
            };
        }

    }
}

