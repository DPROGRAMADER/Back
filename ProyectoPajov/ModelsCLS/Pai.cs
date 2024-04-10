using System;
using System.Collections.Generic;

namespace ProyectoPajov.Infrastructure.ModelsCLS
{
    public partial class Pai
    {
        public Pai()
        {
            Departamentos = new HashSet<Departamento>();
        }

        public decimal IdPais { get; set; }
        public string NombrePais { get; set; } = null!;
        public string CodigoTelefonicoPais { get; set; } = null!;
        public string EstadoPais { get; set; } = null!;

        public virtual ICollection<Departamento> Departamentos { get; set; }
    }
}
