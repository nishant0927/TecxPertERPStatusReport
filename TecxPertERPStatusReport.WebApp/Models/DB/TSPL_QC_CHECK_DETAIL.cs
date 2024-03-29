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
    
    public partial class TSPL_QC_CHECK_DETAIL
    {
        public string Document_Code { get; set; }
        public Nullable<int> Line_No { get; set; }
        public string Item_Code { get; set; }
        public string MRN_No { get; set; }
        public string Row_Type { get; set; }
        public string Unit_Code { get; set; }
        public Nullable<double> MRN_Qty { get; set; }
        public Nullable<double> Ok_Qty { get; set; }
        public Nullable<double> Reject_Qty { get; set; }
        public string Remarks { get; set; }
        public string Reject_Remarks { get; set; }
        public string QC_Status { get; set; }
        public string PO_No { get; set; }
        public string Additional_Remarks { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_MRN_HEAD TSPL_MRN_HEAD { get; set; }
        public virtual TSPL_PURCHASE_ORDER_HEAD TSPL_PURCHASE_ORDER_HEAD { get; set; }
        public virtual TSPL_QC_CHECK_HEAD TSPL_QC_CHECK_HEAD { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
    }
}
