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
    
    public partial class TSPL_TENDER_SHORT_PENALTY_DETAIL
    {
        public int PK_Id { get; set; }
        public string Document_No { get; set; }
        public string SRN_ID { get; set; }
        public Nullable<decimal> SRN_Qty { get; set; }
    
        public virtual TSPL_SRN_HEAD TSPL_SRN_HEAD { get; set; }
        public virtual TSPL_TENDER_SHORT_PENALTY TSPL_TENDER_SHORT_PENALTY { get; set; }
    }
}
