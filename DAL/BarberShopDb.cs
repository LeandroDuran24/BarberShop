using System.Collections.Generic;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using Entidades;

namespace DAL
{
    public class BarberShopDb : DbContext
    {
        public BarberShopDb() : base("ConStr")
        {

        }
        public DbSet<Usuarios> usuario { get; set; }
        public DbSet<Clientes> cliente { get; set; }
        public DbSet<Peluqueros> peluquero { get; set; }
        public DbSet<Turnos> turno { get; set; }
        public DbSet<TipoServicios> servicio { get; set; }
        public DbSet<Facturas> factura { get; set; }
        public DbSet<Productos> producto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Facturas>()
                .HasMany(p => p.ServicioList)
                .WithMany(p => p.FacturaList)
                .Map(mapeo =>
                {
                    mapeo.MapLeftKey("ServicioId");
                    mapeo.MapRightKey("FacturaId");
                    mapeo.ToTable("FacturaServicios");
                });

            modelBuilder.Entity<Facturas>()
               .HasMany(p => p.ProductoList)
               .WithMany(p => p.facturalist)
               .Map(mapeo =>
               {
                   mapeo.MapLeftKey("ProductoId");
                   mapeo.MapRightKey("FacturaId");
                   mapeo.ToTable("FacturaProductos");
               });
        }


    }
}
