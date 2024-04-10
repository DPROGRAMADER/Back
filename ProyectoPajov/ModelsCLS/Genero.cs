using System;
using System.Collections.Generic;

namespace ProyectoPajov.Infrastructure.ModelsCLS
{
    public partial class Genero
    {
        public Genero()
        {
            Empleados = new HashSet<Empleado>();
        }

        public decimal IdGenero { get; set; }
        public string NombreGenero { get; set; } = null!;
        public string EstadoGenero { get; set; } = null!;

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
