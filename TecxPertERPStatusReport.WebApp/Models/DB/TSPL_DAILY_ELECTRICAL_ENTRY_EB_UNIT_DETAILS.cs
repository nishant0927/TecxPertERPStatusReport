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
    
    public partial class TSPL_DAILY_ELECTRICAL_ENTRY_EB_UNIT_DETAILS
    {
        public string Document_No { get; set; }
        public Nullable<int> SNo { get; set; }
        public string Slot_Code { get; set; }
        public Nullable<decimal> Slot_Unit { get; set; }
    
        public virtual TSPL_DAILY_ELECTRICAL_ENTRY_HEAD TSPL_DAILY_ELECTRICAL_ENTRY_HEAD { get; set; }
        public virtual TSPL_SLOT_MASTER TSPL_SLOT_MASTER { get; set; }
    }
}