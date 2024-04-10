using System;
using System.Collections.Generic;

namespace ProyectoPajov.Infrastructure.ModelsCLS
{
    public partial class TipoContrato
    {
        public decimal IdTipoContrato { get; set; }
        public string NombreContrato { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string TipoContracto { get; set; } = null!;
        public string Estado { get; set; } = null!;
    }
}
