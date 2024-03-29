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
    
    public partial class TSPL_GRN_RGP_CONVERSION_DETAIL
    {
        public string GRN_No { get; set; }
        public string Status { get; set; }
        public string Item_Code { get; set; }
        public string Unit_Code { get; set; }
        public Nullable<double> Item_Cost { get; set; }
        public Nullable<double> Pending_Qty { get; set; }
        public Nullable<double> Qty { get; set; }
        public Nullable<double> Amount { get; set; }
        public string Specification { get; set; }
        public string Item_Conversion_Type { get; set; }
        public string RGP_No { get; set; }
        public string Against_Schedule_Code { get; set; }
        public string PO_Id { get; set; }
    
        public virtual TSPL_GRN_HEAD TSPL_GRN_HEAD { get; set; }
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_PO_SCH_HEAD TSPL_PO_SCH_HEAD { get; set; }
        public virtual TSPL_PURCHASE_ORDER_HEAD TSPL_PURCHASE_ORDER_HEAD { get; set; }
        public virtual TSPL_RGP_HEAD TSPL_RGP_HEAD { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
    }
}
