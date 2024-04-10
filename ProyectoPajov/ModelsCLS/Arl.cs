using System;
using System.Collections.Generic;

namespace ProyectoPajov.Infrastructure.ModelsCLS
{
    public partial class Arl
    {
        public Arl()
        {
            Empleados = new HashSet<Empleado>();
        }

        public decimal IdArl { get; set; }
        public string NombreArl { get; set; } = null!;
        public string Estado { get; set; } = null!;

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
