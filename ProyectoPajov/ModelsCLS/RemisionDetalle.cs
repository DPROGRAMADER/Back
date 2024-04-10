using System;
using System.Collections.Generic;

namespace ProyectoPajov.Infrastructure.ModelsCLS
{
    public partial class RemisionDetalle
    {
        public decimal IdRemisionDetalle { get; set; }
        public decimal? IdRemision { get; set; }
        public string ReferenciaRemisionDetalle { get; set; } = null!;
        public string DescripcionRemisionDetalle { get; set; } = null!;
        public decimal CantidadRemisionDetalle { get; set; }
        public decimal TallaRemisionDetalle { get; set; }

        public virtual Remision? IdRemisionNavigation { get; set; }
    }
}
