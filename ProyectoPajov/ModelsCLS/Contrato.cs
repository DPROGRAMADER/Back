using System;
using System.Collections.Generic;

namespace ProyectoPajov.Infrastructure.ModelsCLS
{
    public partial class Contrato
    {
        public decimal IdContrato { get; set; }
        public decimal? IdEmpleado { get; set; }
        public decimal? IdTipoContrato { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal Salario { get; set; }
    }
}
