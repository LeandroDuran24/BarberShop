using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using Entidades;

namespace DAL
{
     public class BarberShopDb:DbContext
    {
        public BarberShopDb() : base("ConStr")
        {

        }
        public DbSet<Usuarios> usuario { get; set; }
        public DbSet<Clientes> cliente { get; set; }
        public DbSet<Peluqueros> peluquero { get; set; }
        public DbSet<Turnos> turno { get; set; }
        public DbSet<TipoServicios> servicio { get; set; }
        
    }
}
