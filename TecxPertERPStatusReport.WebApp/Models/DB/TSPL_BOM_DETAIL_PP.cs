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
    
    public partial class TSPL_BOM_DETAIL_PP
    {
        public string BOM_CODE { get; set; }
        public int LINE_NO { get; set; }
        public string CONSM_ITEM_CATEGORY_CODE { get; set; }
        public string CONSM_ITEM_CODE { get; set; }
        public string ITEM_DESCRIPTION { get; set; }
        public decimal CONSM_QUANTITY { get; set; }
        public string CONSM_ITEM_UNIT_CODE { get; set; }
        public string FAT { get; set; }
        public string SNF { get; set; }
        public string REMARKS { get; set; }
        public string REVISION_NO { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_MF_BOM_HEAD TSPL_MF_BOM_HEAD { get; set; }
        public virtual TSPL_MF_PRODUCTION_ITEM_CATEGORY TSPL_MF_PRODUCTION_ITEM_CATEGORY { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
    }
}
