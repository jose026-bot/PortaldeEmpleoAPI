using System;
using System.Collections.Generic;

#nullable disable

namespace PortaldeEmpleoAPI.Models
{
    public partial class Detpostuof
    {
        public int Id { get; set; }
        public int? OfertalaboralId { get; set; }
        public int? CandidatoIdcandidat { get; set; }

        public virtual Candidato CandidatoIdcandidatNavigation { get; set; }
        public virtual Ofertalaboral Ofertalaboral { get; set; }
    }
}
