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
    
    public partial class TSPL_DCS_MP_INCENTIVE_RECO_DETAIL_INVALID
    {
        public int PK_Id { get; set; }
        public string Document_Code { get; set; }
        public Nullable<int> SNo { get; set; }
        public int Cycle_Year { get; set; }
        public int Cycle_Month { get; set; }
        public string MCC_Code { get; set; }
        public string VLC_Code { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public string UOM { get; set; }
        public Nullable<decimal> FAT { get; set; }
        public Nullable<decimal> SNF { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> MP_Qty { get; set; }
        public Nullable<decimal> MP_FAT { get; set; }
        public Nullable<decimal> MP_SNF { get; set; }
        public Nullable<decimal> MP_Amount { get; set; }
        public Nullable<decimal> Diff_Qty { get; set; }
        public Nullable<decimal> Diff_FAT { get; set; }
        public Nullable<decimal> Diff_SNF { get; set; }
        public Nullable<decimal> Diff_Amount { get; set; }
        public int Cycle_No { get; set; }
        public Nullable<int> MP_Count { get; set; }
    
        public virtual TSPL_DCS_MP_INCENTIVE_RECO_HEAD TSPL_DCS_MP_INCENTIVE_RECO_HEAD { get; set; }
        public virtual TSPL_MCC_MASTER TSPL_MCC_MASTER { get; set; }
        public virtual TSPL_VLC_MASTER_HEAD TSPL_VLC_MASTER_HEAD { get; set; }
    }
}
