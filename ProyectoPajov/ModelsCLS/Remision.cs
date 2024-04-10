using System;
using System.Collections.Generic;

namespace ProyectoPajov.Infrastructure.ModelsCLS
{
    public partial class Remision
    {
        public Remision()
        {
            RemisionDetalles = new HashSet<RemisionDetalle>();
        }

        public decimal IdRemision { get; set; }
        public decimal? IdCliente { get; set; }
        public decimal? IdOrden { get; set; }
        public DateTime FechaRemision { get; set; }
        public decimal CantidadRemision { get; set; }
        public string CategoriaRemision { get; set; } = null!;

        public virtual Cliente? IdClienteNavigation { get; set; }
        public virtual Orden? IdOrdenNavigation { get; set; }
        public virtual ICollection<RemisionDetalle> RemisionDetalles { get; set; }
    }
}
