using System;
using System.Collections.Generic;

namespace ProyectoPajov.Infrastructure.ModelsCLS
{
    public partial class Cliente
    {
        public Cliente()
        {
            Remisions = new HashSet<Remision>();
        }

        public decimal IdCliente { get; set; }
        public decimal NitCliente { get; set; }
        public string NombreCliente { get; set; } = null!;
        public string? DirrecionCliente { get; set; }
        public decimal TelefonoCliente { get; set; }
        public string ContactoCliente { get; set; } = null!;
        public string EmailCliente { get; set; } = null!;
        public string CiudadCliente { get; set; } = null!;
        public string DepartamentoCliente { get; set; } = null!;
        public string PaisCliente { get; set; } = null!;

        public virtual ICollection<Remision> Remisions { get; set; }
    }
}
