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
    
    public partial class TSPL_CSA_PRICE_DETAIL
    {
        public string Doc_No { get; set; }
        public Nullable<int> Line_no { get; set; }
        public string Item_Code { get; set; }
        public string UOM { get; set; }
        public Nullable<double> Diff_Rate { get; set; }
        public Nullable<double> Ltr_Rate { get; set; }
        public Nullable<double> Case_Rate { get; set; }
        public Nullable<double> Pcs_Rate { get; set; }
        public Nullable<double> Ltr_Per_Case { get; set; }
        public Nullable<double> Pcs_Per_Case { get; set; }
        public string CASE_UOM { get; set; }
        public Nullable<double> MRP { get; set; }
    
        public virtual TSPL_CSA_PRICE_HEAD TSPL_CSA_PRICE_HEAD { get; set; }
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER1 { get; set; }
    }
}
