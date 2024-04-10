using System;
using System.Collections.Generic;

namespace ProyectoPajov.Infrastructure.ModelsCLS
{
    public partial class CajaCompensacion
    {
        public CajaCompensacion()
        {
            Empleados = new HashSet<Empleado>();
        }

        public decimal IdCaja { get; set; }
        public string NombreCaja { get; set; } = null!;
        public string Estado { get; set; } = null!;

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
