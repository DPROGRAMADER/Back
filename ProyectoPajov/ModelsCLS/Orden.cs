using System;
using System.Collections.Generic;

namespace ProyectoPajov.Infrastructure.ModelsCLS
{
    public partial class Orden
    {
        public Orden()
        {
            OrdenDetalles = new HashSet<OrdenDetalle>();
            Remisions = new HashSet<Remision>();
        }

        public decimal IdOrden { get; set; }
        public DateTime FechaElaboracion { get; set; }
        public DateTime FechaEntrega { get; set; }
        public decimal CantidadTotalOrden { get; set; }
        public decimal ValorPago { get; set; }
        public string Observacion { get; set; } = null!;

        public virtual ICollection<OrdenDetalle> OrdenDetalles { get; set; }
        public virtual ICollection<Remision> Remisions { get; set; }
    }
}
