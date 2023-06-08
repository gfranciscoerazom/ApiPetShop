using System;
namespace ApiPetShop.Models
{
	public class Contacto
	{
        public int ContactoId
        {
            get;
            set;
        }

		public string Nombre
		{
			get;
			set;
		}

		public string Apellido
		{
			get;
			set;
        }

        public string Cedula
        {
            get;
            set;
        }

        public string Direccion
        {
            get;
            set;
        }

        public string Telefono
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public string Imagen
        {
            get;
            set;
        }

        public Contacto(string nombre, string apellido, string cedula, string direccion, string telefono, string email, string imagen)
        {
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            Imagen = imagen;
        }
    }
}

