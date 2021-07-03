using System;
using System.Collections.Generic;

#nullable disable

namespace PortaldeEmpleoAPI.Models
{
    public partial class Empresa
    {
        public Empresa()
        {
            Ofertalaboral = new HashSet<Ofertalaboral>();
        }

        public int Id { get; set; }
        public string Ruc { get; set; }
        public string Ubicacion { get; set; }
        public string Email { get; set; }
        public string Industria { get; set; }
        public string Telefono { get; set; }
        public string Descripcionempr { get; set; }
        public string Razonsocial { get; set; }
        public string Logoempresa { get; set; }

        public virtual Admiempresa Admiempresa { get; set; }
        public virtual ICollection<Ofertalaboral> Ofertalaboral { get; set; }
    }
}
