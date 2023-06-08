using ApiPetShop.Utils;
using Microsoft.EntityFrameworkCore;

namespace ApiPetShop.Models
{
    public class AppEFContext: DbContext
    {
        public DbSet<Producto> Productos
        {
            get;
            set;
        }

        public DbSet<Cliente> Clientes
        {
            get;
            set;
        }

        public DbSet<Contacto> Contactos
        {
            get;
            set;
        }

        public AppEFContext(DbContextOptions<AppEFContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            Util burnData = Util.Instance;

            modelBuilder.Entity<Cliente>(c =>
            {
                c.ToTable("Cliente");

                c.HasKey(c => c.ClienteId);

                //c.Property(c => c.Nombre);
                //c.Property(c => c.Email);
                //c.Property(c => c.Numero);

                c.HasData(burnData.GetDatosDePruebaClientes()); ;
            });

            modelBuilder.Entity<Producto>(p =>
            {
                p.ToTable("Producto");

                p.HasKey(p => p.ProductoId);

                //p.Property(p => p.Nombre);
                //p.Property(p => p.Descripcion);
                //p.Property(p => p.Precio);

                p.HasData(burnData.GetDatosDePruebaProductos());
            });

            modelBuilder.Entity<Contacto>(p =>
            {
                p.ToTable("Contactos");

                p.HasKey(p => p.ContactoId);

                p.HasData(burnData.GetDatosDePruebaContactos());
            });
        }
    }
}
