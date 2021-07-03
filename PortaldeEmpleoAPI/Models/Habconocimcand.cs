using System;
using System.Collections.Generic;

#nullable disable

namespace PortaldeEmpleoAPI.Models
{
    public partial class Habconocimcand
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int? CandidatoIdcandidat { get; set; }

        public virtual Candidato CandidatoIdcandidatNavigation { get; set; }
    }
}
