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
    
    public partial class CAD_RESERVATORIO
    {
        public CAD_RESERVATORIO()
        {
            this.CAD_RESERVATORIO_DIARIO = new HashSet<CAD_RESERVATORIO_DIARIO>();
            this.CAD_IRRIGACAO = new HashSet<CAD_IRRIGACAO>();
        }
    
        public int IDC_CAD_RESERVATORIO { get; set; }
        public string NOM_RESERVATORIO { get; set; }
        public Nullable<double> VOL_ATUAL { get; set; }
        public Nullable<double> VAR_VALOR { get; set; }
        public int CAD_FAZENDA_IDC_CAD_FAZENDA { get; set; }
    
        public virtual CAD_FAZENDA CAD_FAZENDA { get; set; }
        public virtual ICollection<CAD_RESERVATORIO_DIARIO> CAD_RESERVATORIO_DIARIO { get; set; }
        public virtual ICollection<CAD_IRRIGACAO> CAD_IRRIGACAO { get; set; }
    }
}