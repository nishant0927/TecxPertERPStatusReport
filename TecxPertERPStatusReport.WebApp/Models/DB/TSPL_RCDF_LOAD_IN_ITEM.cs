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
    
    public partial class TSPL_RCDF_LOAD_IN_ITEM
    {
        public int PK_ID { get; set; }
        public string Document_Code { get; set; }
        public string Item_Code { get; set; }
        public Nullable<decimal> Qty_BAG { get; set; }
        public Nullable<decimal> Qty_KG { get; set; }
        public Nullable<decimal> Qty_MT { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<decimal> Amount { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_RCDF_LOAD_IN TSPL_RCDF_LOAD_IN { get; set; }
    }
}
