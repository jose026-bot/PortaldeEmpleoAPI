using System;
using System.Collections.Generic;

#nullable disable

namespace PortaldeEmpleoAPI.Models
{
    public partial class Idioma
    {
        public Idioma()
        {
            Idiomacandid = new HashSet<Idiomacandid>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Idiomacandid> Idiomacandid { get; set; }
    }
}
