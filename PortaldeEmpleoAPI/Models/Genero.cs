using System;
using System.Collections.Generic;

#nullable disable

namespace PortaldeEmpleoAPI.Models
{
    public partial class Genero
    {
        public Genero()
        {
            Candidato = new HashSet<Candidato>();
        }

        public int Idgenero { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Candidato> Candidato { get; set; }
    }
}
