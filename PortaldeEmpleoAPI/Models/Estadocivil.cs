using System;
using System.Collections.Generic;

#nullable disable

namespace PortaldeEmpleoAPI.Models
{
    public partial class Estadocivil
    {
        public Estadocivil()
        {
            Candidato = new HashSet<Candidato>();
        }

        public int Idestciv { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Candidato> Candidato { get; set; }
    }
}
