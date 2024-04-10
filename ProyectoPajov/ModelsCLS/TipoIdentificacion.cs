using System;
using System.Collections.Generic;

namespace ProyectoPajov.Infrastructure.ModelsCLS
{
    public partial class TipoIdentificacion
    {
        public TipoIdentificacion()
        {
            Empleados = new HashSet<Empleado>();
        }

        public decimal IdTipoidentificacion { get; set; }
        public string NombreTipoidentificacion { get; set; } = null!;
        public string EstadoTipoidentificacion { get; set; } = null!;

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
