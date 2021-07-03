using System;
using System.Collections.Generic;

#nullable disable

namespace PortaldeEmpleoAPI.Models
{
    public partial class Areatrabajo
    {
        public Areatrabajo()
        {
            Explabcand = new HashSet<Explabcand>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Explabcand> Explabcand { get; set; }
    }
}
