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
    
    public partial class REG_MANEJO
    {
        public int IDC_REG_MANEJO { get; set; }
        public Nullable<System.DateTime> DAT_MANEJO { get; set; }
        public Nullable<int> VAR_IDADE_PARCELA { get; set; }
        public Nullable<double> VOL_IRRIGACAO_NECESSARIA { get; set; }
        public Nullable<double> VOL_IRRIGACAO_REALIZADA { get; set; }
        public Nullable<double> PER_PERCENTIMETRO { get; set; }
        public Nullable<double> VOL_CONSUMO_DIARIO { get; set; }
        public Nullable<double> TMO_MANEJO { get; set; }
        public Nullable<double> VAR_KS { get; set; }
        public Nullable<double> VAR_BALANCO { get; set; }
        public Nullable<double> VAR_ETO { get; set; }
        public Nullable<double> VAR_KC { get; set; }
        public Nullable<double> VAR_KL { get; set; }
        public Nullable<double> VAR_PRECIPITACAO { get; set; }
        public Nullable<double> TMO_IRRIGADO_GOTEJO { get; set; }
        public Nullable<double> TMO_IRRIGADO_PIVO { get; set; }
        public Nullable<double> QTD_IRRIGADA { get; set; }
        public Nullable<double> VAR_EXTRESSE_ULTRAPASSADO { get; set; }
        public int CAD_PARCELA_IDC_CAD_PARCELA { get; set; }
        public Nullable<double> VOL_IRRIGACAO_DESNECESSARIA { get; set; }
    
        public virtual CAD_PARCELA CAD_PARCELA { get; set; }
    }
}
