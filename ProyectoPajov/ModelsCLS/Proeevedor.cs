using System;
using System.Collections.Generic;

namespace ProyectoPajov.Infrastructure.ModelsCLS
{
    public partial class Proeevedor
    {
        public decimal IdProeevedor { get; set; }
        public decimal NitProeevedor { get; set; }
        public string NombreProeevedor { get; set; } = null!;
        public string? DirrecionProeevedor { get; set; }
        public decimal TelefonoProeevedor { get; set; }
        public string ContactoProeevedor { get; set; } = null!;
        public string EmailProeevedor { get; set; } = null!;
        public string CiudadProeevedor { get; set; } = null!;
        public string DepartamentoProeevedor { get; set; } = null!;
        public string PaisProeevedor { get; set; } = null!;
    }
}
