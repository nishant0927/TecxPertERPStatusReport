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
    
    public partial class TSPL_LC_REQUEST_DETAIL_MT
    {
        public string LCRequestNo { get; set; }
        public Nullable<int> Line_No { get; set; }
        public string Item_Code { get; set; }
        public string Item_Desc { get; set; }
        public string Unit_code { get; set; }
        public double Qty { get; set; }
        public string PurchaseOrder_No { get; set; }
        public double Rate { get; set; }
        public string PurchaseInvoice_No { get; set; }
    
        public virtual TSPL_EX_PI_HEAD TSPL_EX_PI_HEAD { get; set; }
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_LC_REQUEST_MT TSPL_LC_REQUEST_MT { get; set; }
        public virtual TSPL_PURCHASE_ORDER_HEAD TSPL_PURCHASE_ORDER_HEAD { get; set; }
    }
}
