//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TecxPertERPStatusReport.WebApp.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class TSPL_MILK_GATE_ENTRY_WEIGHTMENT
    {
        public string Weighment_Code { get; set; }
        public System.DateTime GW_Weighment_Date { get; set; }
        public Nullable<System.DateTime> TW_Weighment_Date { get; set; }
        public string Against_Gate_Entry_No { get; set; }
        public Nullable<decimal> Gross_Weight { get; set; }
        public Nullable<decimal> Tare_Weight { get; set; }
        public Nullable<decimal> Net_Weight { get; set; }
        public int GW_Status { get; set; }
        public string GW_Created_By { get; set; }
        public System.DateTime GW_Created_Date { get; set; }
        public string GW_Modified_By { get; set; }
        public System.DateTime GW_Modified_Date { get; set; }
        public Nullable<System.DateTime> GW_Posted_Date { get; set; }
        public string GW_Posted_By { get; set; }
        public int TW_Status { get; set; }
        public string TW_Modified_By { get; set; }
        public Nullable<System.DateTime> TW_Modified_Date { get; set; }
        public Nullable<System.DateTime> TW_Posted_Date { get; set; }
        public string TW_Posted_By { get; set; }
    
        public virtual TSPL_MILK_GATE_ENTRY_IN TSPL_MILK_GATE_ENTRY_IN { get; set; }
    }
}
