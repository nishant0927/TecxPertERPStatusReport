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
    
    public partial class TSPL_PP_STD_FINALQC_ISSUE_ITEM_DETAIL
    {
        public string QC_Code { get; set; }
        public string Item_Code { get; set; }
        public string Unit_Code { get; set; }
        public Nullable<int> SNO { get; set; }
        public Nullable<decimal> Avail_Qty { get; set; }
        public Nullable<decimal> Avail_FAT_Per { get; set; }
        public Nullable<decimal> Avail_SNF_Per { get; set; }
        public Nullable<decimal> Avail_FAT_KG { get; set; }
        public Nullable<decimal> Avail_SNF_KG { get; set; }
        public Nullable<decimal> Requir_FAT_Per { get; set; }
        public Nullable<decimal> Requir_SNF_Per { get; set; }
        public Nullable<decimal> Diff_Qty { get; set; }
        public Nullable<decimal> Diff_FAT_Per { get; set; }
        public Nullable<decimal> Diff_SNF_Per { get; set; }
        public Nullable<decimal> Diff_FAT_KG { get; set; }
        public Nullable<decimal> Diff_SNF_KG { get; set; }
        public string Remarks { get; set; }
        public string TO_LOC_CODE { get; set; }
        public string TO_LOC_DESC { get; set; }
        public string Issue_Status { get; set; }
        public Nullable<decimal> Fat_Rate { get; set; }
        public Nullable<decimal> SNF_Rate { get; set; }
        public Nullable<decimal> Fat_Amt { get; set; }
        public Nullable<decimal> SNF_Amt { get; set; }
        public Nullable<decimal> Total_Amount { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_PP_STD_FINALQC_HEAD TSPL_PP_STD_FINALQC_HEAD { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
    }
}
