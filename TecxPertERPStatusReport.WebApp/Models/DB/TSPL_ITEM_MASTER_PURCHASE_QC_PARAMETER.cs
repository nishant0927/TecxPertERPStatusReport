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
    
    public partial class TSPL_ITEM_MASTER_PURCHASE_QC_PARAMETER
    {
        public Nullable<int> SNO { get; set; }
        public string Item_Code { get; set; }
        public string QC_Code { get; set; }
        public string Specifications { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_QC_LOG_SHEET_MASTER TSPL_QC_LOG_SHEET_MASTER { get; set; }
    }
}
