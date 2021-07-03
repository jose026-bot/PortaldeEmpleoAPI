using System;
using System.Collections.Generic;

#nullable disable

namespace PortaldeEmpleoAPI.Models
{
    public partial class Idiomacandid
    {
        public int Ididioma { get; set; }
        public int? IdiomaId { get; set; }
        public int? NiveloralidiId { get; set; }
        public int? NivescridId { get; set; }
        public int? CandidatoIdcandidat { get; set; }

        public virtual Candidato CandidatoIdcandidatNavigation { get; set; }
        public virtual Idioma Idioma { get; set; }
        public virtual Niveloralidi Niveloralidi { get; set; }
        public virtual Nivescrid Nivescrid { get; set; }
    }
}
