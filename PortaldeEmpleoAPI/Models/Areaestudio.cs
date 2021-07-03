using System;
using System.Collections.Generic;

#nullable disable

namespace PortaldeEmpleoAPI.Models
{
    public partial class Areaestudio
    {
        public Areaestudio()
        {
            Formaccand = new HashSet<Formaccand>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Formaccand> Formaccand { get; set; }
    }
}
