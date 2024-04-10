using System;
using System.Collections.Generic;

namespace ProyectoPajov.Infrastructure.ModelsCLS
{
    public partial class Municipio
    {
        public decimal IdMunicipio { get; set; }
        public decimal IdDepartamento { get; set; }
        public string NombreMunicipio { get; set; } = null!;
        public string EstadoDepartamento { get; set; } = null!;

        public virtual Departamento IdDepartamentoNavigation { get; set; } = null!;
    }
}
