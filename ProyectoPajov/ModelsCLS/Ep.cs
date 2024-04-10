using System;
using System.Collections.Generic;

namespace ProyectoPajov.Infrastructure.ModelsCLS
{
    public partial class Ep
    {
        public Ep()
        {
            Empleados = new HashSet<Empleado>();
        }

        public decimal IdEps { get; set; }
        public string NombreEps { get; set; } = null!;
        public string Estado { get; set; } = null!;

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
