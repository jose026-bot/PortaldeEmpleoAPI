using System;
using System.Collections.Generic;

#nullable disable

namespace PortaldeEmpleoAPI.Models
{
    public partial class Formaccand
    {
        public int Idformacadem { get; set; }
        public string Nombrecentroed { get; set; }
        public string Estado { get; set; }
        public DateTime? Fechainicio { get; set; }
        public DateTime? Fechafin { get; set; }
        public int? TipoestudioId { get; set; }
        public int? PaisId { get; set; }
        public int? AreaestudioId { get; set; }
        public int? CandidatoIdcandidat { get; set; }
        public string Titulocarrera { get; set; }

        public virtual Areaestudio Areaestudio { get; set; }
        public virtual Candidato CandidatoIdcandidatNavigation { get; set; }
        public virtual Pais Pais { get; set; }
        public virtual Tipoestudio Tipoestudio { get; set; }
    }
}
