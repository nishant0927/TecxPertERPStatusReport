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
    
    public partial class TSPL_PP_STD_FINALQC_QC_DETAIL
    {
        public string QC_Code { get; set; }
        public Nullable<int> SNO { get; set; }
        public string Item_Code { get; set; }
        public string Parameter_Code { get; set; }
        public Nullable<decimal> Lower_range { get; set; }
        public Nullable<decimal> Upper_range { get; set; }
        public decimal Actual_Range { get; set; }
        public string Actual_Value { get; set; }
        public string Actual_Status { get; set; }
        public string Qc_Status { get; set; }
        public string Remarks { get; set; }
        public string QC_Type { get; set; }
        public Nullable<int> Parent_Line_No { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_PARAMETER_MASTER TSPL_PARAMETER_MASTER { get; set; }
        public virtual TSPL_PP_STD_FINALQC_HEAD TSPL_PP_STD_FINALQC_HEAD { get; set; }
    }
}
