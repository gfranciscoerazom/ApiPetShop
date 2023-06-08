using System.ComponentModel.DataAnnotations;

namespace ApiPetShop.Models
{
    public class Producto
    {
        public int ProductoId
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
        }

        public string Descripcion
        {
            get;
            set;
        }

        public double Precio
        {
            get;
            set;
        }

        public int Cantidad
        {
            get;
            set;
        }

        public string Imagen
        {
            get;
            set;
        }

        public Producto(int productoId, string nombre, string descripcion, double precio, int cantidad, string imagen)
        {
            ProductoId = productoId;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Cantidad = cantidad;
            Imagen = imagen;
        }
    }
}
