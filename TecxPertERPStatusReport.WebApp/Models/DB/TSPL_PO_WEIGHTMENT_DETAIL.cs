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
    
    public partial class TSPL_PO_WEIGHTMENT_DETAIL
    {
        public string TR_No { get; set; }
        public string Weighment_Code { get; set; }
        public Nullable<int> SNo { get; set; }
        public string Item_Code { get; set; }
        public Nullable<decimal> Gross_Weight { get; set; }
        public Nullable<decimal> Tare_Weight { get; set; }
        public Nullable<decimal> Net_Weight { get; set; }
        public Nullable<int> Unload_SNo { get; set; }
        public Nullable<int> Is_Unload_Item { get; set; }
        public string Unload_By { get; set; }
        public Nullable<System.DateTime> Unload_Date { get; set; }
        public string Weight_By { get; set; }
        public Nullable<System.DateTime> Weight_Date { get; set; }
        public Nullable<decimal> GRN_Qty { get; set; }
        public string UOM { get; set; }
        public Nullable<int> Is_Auto_Weighment { get; set; }
        public Nullable<decimal> Extra_Weight { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_PO_WEIGHTMENT_HEAD TSPL_PO_WEIGHTMENT_HEAD { get; set; }
    }
}
