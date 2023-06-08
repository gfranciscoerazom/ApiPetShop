﻿using System.ComponentModel.DataAnnotations;

namespace ApiPetShop.Models
{
    public class Cliente
    {
        public int ClienteId
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public string Numero
        {
            get;
            set;
        }

        public string Contrasena
        {
            get;
            set;
        }

        public Cliente(int clienteId, string nombre, string email, string numero, string contrasena)
        {
            ClienteId = clienteId;
            Nombre = nombre;
            Email = email;
            Numero = numero;
            Contrasena = contrasena;
        }
    }
}
