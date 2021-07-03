using System;
using System.Collections.Generic;

#nullable disable

namespace PortaldeEmpleoAPI.Models
{
    public partial class Explabcand
    {
        public int Idexplabcand { get; set; }
        public string Empresaexp { get; set; }
        public string Cargo { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string Descripfuncion { get; set; }
        public int? GiroempresaId { get; set; }
        public int? AreatrabajoId { get; set; }
        public int? CandidatoIdcandidat { get; set; }

        public virtual Areatrabajo Areatrabajo { get; set; }
        public virtual Candidato CandidatoIdcandidatNavigation { get; set; }
        public virtual Giroempresa Giroempresa { get; set; }
    }
}
