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
    
    public partial class TSPL_ACKNOWLEDGENT_ENTRY_DETAIL
    {
        public int SNO { get; set; }
        public string Document_No { get; set; }
        public Nullable<int> Chamber_No { get; set; }
        public string Chamber_Description { get; set; }
        public string Item_code { get; set; }
        public string Item_UOM { get; set; }
        public Nullable<decimal> Qty_KG { get; set; }
        public Nullable<decimal> FAT_KG { get; set; }
        public Nullable<decimal> SNF_KG { get; set; }
        public Nullable<decimal> FAT_Rate { get; set; }
        public Nullable<decimal> SNF_Rate { get; set; }
        public Nullable<decimal> Amount { get; set; }
    
        public virtual TSPL_ACKNOWLEDGENT_ENTRY_HEADER TSPL_ACKNOWLEDGENT_ENTRY_HEADER { get; set; }
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
    }
}
