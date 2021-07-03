using System;
using System.Collections.Generic;

#nullable disable

namespace PortaldeEmpleoAPI.Models
{
    public partial class Ofertalaboral
    {
        public Ofertalaboral()
        {
            Detpostuof = new HashSet<Detpostuof>();
        }

        public int Id { get; set; }
        public string Descripcionpuesto { get; set; }
        public string Titulooferta { get; set; }
        public string Detalleoferta { get; set; }
        public string Perfilcandidato { get; set; }
        public string Requisitos { get; set; }
        public decimal? Salario { get; set; }
        public DateTime? Fechapublicacion { get; set; }
        public DateTime? Fechafin { get; set; }
        public int? JornadaId { get; set; }
        public int? EmpresaId { get; set; }

        public virtual Empresa Empresa { get; set; }
        public virtual Jornada Jornada { get; set; }
        public virtual ICollection<Detpostuof> Detpostuof { get; set; }
    }
}
