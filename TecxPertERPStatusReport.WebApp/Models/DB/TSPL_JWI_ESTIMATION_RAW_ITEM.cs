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
    
    public partial class TSPL_JWI_ESTIMATION_RAW_ITEM
    {
        public string TR_Code { get; set; }
        public System.DateTime TR_Date { get; set; }
        public string Document_NO { get; set; }
        public Nullable<int> SNo { get; set; }
        public Nullable<int> Parent_SNo { get; set; }
        public string Parent_Type { get; set; }
        public string Main_BOM_CODE { get; set; }
        public string Main_Item_Code { get; set; }
        public Nullable<decimal> Main_Item_Qty { get; set; }
        public string Main_Item_UOM { get; set; }
        public string Raw_Item_Code { get; set; }
        public Nullable<decimal> Raw_Item_Qty { get; set; }
        public string Raw_Item_UOM { get; set; }
        public Nullable<decimal> Raw_Item_FAT_Per { get; set; }
        public Nullable<decimal> Raw_Item_FAT_KG { get; set; }
        public Nullable<decimal> Raw_Item_SNF_Per { get; set; }
        public Nullable<decimal> Raw_Item_SNF_KG { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER1 { get; set; }
        public virtual TSPL_JWI_ESTIMATION_HEAD TSPL_JWI_ESTIMATION_HEAD { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
        public virtual TSPL_PP_BOM_HEAD TSPL_PP_BOM_HEAD { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER1 { get; set; }
    }
}
