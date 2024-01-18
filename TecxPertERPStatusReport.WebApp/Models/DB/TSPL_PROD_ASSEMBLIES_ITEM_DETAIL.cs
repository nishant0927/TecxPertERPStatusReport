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
    
    public partial class TSPL_PROD_ASSEMBLIES_ITEM_DETAIL
    {
        public string ASSEMBLY_CODE { get; set; }
        public string BOM_CODE { get; set; }
        public int LINE_NO { get; set; }
        public string CONSM_ITEM_CODE { get; set; }
        public string ITEM_DESCRIPTION { get; set; }
        public decimal CONSM_QUANTITY { get; set; }
        public string CONSM_ITEM_UNIT_CODE { get; set; }
        public string LOCATION_CODE { get; set; }
        public string Item_Type { get; set; }
        public string Item_Status { get; set; }
        public string Serial_No { get; set; }
        public Nullable<decimal> Item_Amount { get; set; }
        public Nullable<decimal> FAT_PER { get; set; }
        public Nullable<decimal> SNF_PER { get; set; }
        public Nullable<decimal> FAT_KG { get; set; }
        public Nullable<decimal> SNF_KG { get; set; }
        public Nullable<decimal> FAT_Rate { get; set; }
        public Nullable<decimal> SNF_Rate { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_PP_BOM_HEAD TSPL_PP_BOM_HEAD { get; set; }
        public virtual TSPL_PROD_ASSEMBLIES TSPL_PROD_ASSEMBLIES { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
    }
}