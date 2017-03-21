using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int PrecioCompra { get; set; }
        public int PrecioVenta { get; set; }
        public int Cantidad { get; set; }

        public virtual List<Facturas>facturalist { get; set; }

        public Productos()
        {
            facturalist = new List<Facturas>();
        }
    }
}
