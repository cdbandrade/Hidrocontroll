//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace hidrocontroll.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CAD_FAZENDA
    {
        public CAD_FAZENDA()
        {
            this.CAD_CULTURA = new HashSet<CAD_CULTURA>();
            this.CAD_GOTEJADOR = new HashSet<CAD_GOTEJADOR>();
            this.CAD_OUTORGA = new HashSet<CAD_OUTORGA>();
            this.CAD_RESERVATORIO = new HashSet<CAD_RESERVATORIO>();
            this.CAD_CLIMA = new HashSet<CAD_CLIMA>();
            this.CAD_USUARIO = new HashSet<CAD_USUARIO>();
            this.CAD_PIVO_CENTRAL = new HashSet<CAD_PIVO_CENTRAL>();
            this.CAD_SOLO = new HashSet<CAD_SOLO>();
            this.CAD_MOTOBOMBA = new HashSet<CAD_MOTOBOMBA>();
        }
    
        public int IDC_CAD_FAZENDA { get; set; }
        public string NOM_FAZENDA { get; set; }
        public Nullable<double> ARE_FAZENDA { get; set; }
        public Nullable<double> VAR_ALTITUDE { get; set; }
        public int CAD_CIDADE_IDC_CAD_CIDADE { get; set; }
        public int CAD_CLIENTE_IDC_CAD_CLIENTE { get; set; }
    
        public virtual CAD_CIDADE CAD_CIDADE { get; set; }
        public virtual CAD_CLIENTE CAD_CLIENTE { get; set; }
        public virtual ICollection<CAD_CULTURA> CAD_CULTURA { get; set; }
        public virtual ICollection<CAD_GOTEJADOR> CAD_GOTEJADOR { get; set; }
        public virtual ICollection<CAD_OUTORGA> CAD_OUTORGA { get; set; }
        public virtual ICollection<CAD_RESERVATORIO> CAD_RESERVATORIO { get; set; }
        public virtual ICollection<CAD_CLIMA> CAD_CLIMA { get; set; }
        public virtual ICollection<CAD_USUARIO> CAD_USUARIO { get; set; }
        public virtual ICollection<CAD_PIVO_CENTRAL> CAD_PIVO_CENTRAL { get; set; }
        public virtual ICollection<CAD_SOLO> CAD_SOLO { get; set; }
        public virtual ICollection<CAD_MOTOBOMBA> CAD_MOTOBOMBA { get; set; }
    }
}
