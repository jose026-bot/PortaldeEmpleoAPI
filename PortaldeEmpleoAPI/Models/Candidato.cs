using System;
using System.Collections.Generic;

#nullable disable

namespace PortaldeEmpleoAPI.Models
{
    public partial class Candidato
    {
        public Candidato()
        {
            Detpostuof = new HashSet<Detpostuof>();
            Explabcand = new HashSet<Explabcand>();
            Formaccand = new HashSet<Formaccand>();
            Habconocimcand = new HashSet<Habconocimcand>();
            Idiomacandid = new HashSet<Idiomacandid>();
        }

        public int Idcandidat { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public DateTime? Fechanacim { get; set; }
        public string Telefono { get; set; }
        public string Descrpperfil { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public string Foto { get; set; }
        public int? GeneroIdgenero { get; set; }
        public int? EstadocivilIdestciv { get; set; }
        public string Dochojavida { get; set; }
        public string SalCandidato { get; set; }

        public virtual Estadocivil EstadocivilIdestcivNavigation { get; set; }
        public virtual Genero GeneroIdgeneroNavigation { get; set; }
        public virtual ICollection<Detpostuof> Detpostuof { get; set; }
        public virtual ICollection<Explabcand> Explabcand { get; set; }
        public virtual ICollection<Formaccand> Formaccand { get; set; }
        public virtual ICollection<Habconocimcand> Habconocimcand { get; set; }
        public virtual ICollection<Idiomacandid> Idiomacandid { get; set; }
    }
}
