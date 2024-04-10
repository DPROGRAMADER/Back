using System;
using System.Collections.Generic;

namespace ProyectoPajov.Infrastructure.ModelsCLS
{
    public partial class FondoPensione
    {
        public FondoPensione()
        {
            Empleados = new HashSet<Empleado>();
        }

        public decimal IdPension { get; set; }
        public string NombrePension { get; set; } = null!;
        public string Estado { get; set; } = null!;

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
