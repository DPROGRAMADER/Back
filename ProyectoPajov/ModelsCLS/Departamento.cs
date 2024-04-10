using System;
using System.Collections.Generic;

namespace ProyectoPajov.Infrastructure.ModelsCLS
{
    public partial class Departamento
    {
        public Departamento()
        {
            Municipios = new HashSet<Municipio>();
        }

        public decimal IdDepartamento { get; set; }
        public decimal IdPais { get; set; }
        public string NombreDepartamento { get; set; } = null!;
        public string EstadoDepartamento { get; set; } = null!;

        public virtual Pai IdPaisNavigation { get; set; } = null!;
        public virtual ICollection<Municipio> Municipios { get; set; }
    }
}
