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
    
    public partial class TSPL_JW_ESTIMATE_DETAILS
    {
        public string Document_NO { get; set; }
        public string SRN_NO { get; set; }
        public System.DateTime SRN_Date { get; set; }
        public string UOM { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> FAT_PER { get; set; }
        public Nullable<decimal> SNF_PER { get; set; }
        public Nullable<decimal> FAT_KG { get; set; }
        public Nullable<decimal> SNF_KG { get; set; }
    
        public virtual TSPL_Bulk_MILK_SRN TSPL_Bulk_MILK_SRN { get; set; }
        public virtual TSPL_JW_ESTIMATE_HEAD TSPL_JW_ESTIMATE_HEAD { get; set; }
    }
}
