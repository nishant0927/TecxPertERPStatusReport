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
    
    public partial class TSPL_JWI_PRICE_DETAIL_ALL_UOM
    {
        public string Price_Code { get; set; }
        public string RM_Item_Code { get; set; }
        public string FG_Item_Code { get; set; }
        public string FG_Item_UOM { get; set; }
        public Nullable<decimal> FG_Item_Cost { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER1 { get; set; }
        public virtual TSPL_JWI_PRICE_HEAD TSPL_JWI_PRICE_HEAD { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
    }
}
