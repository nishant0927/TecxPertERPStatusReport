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
    
    public partial class TSPL_MF_RETURN_DETAIL
    {
        public string RETURN_CODE { get; set; }
        public string ISSUE_CODE { get; set; }
        public string PRODUCTION_LINE_CODE { get; set; }
        public string BOM_CODE { get; set; }
        public string ITEM_CODE { get; set; }
        public string ITEM_DESCRIPTION { get; set; }
        public decimal BATCH_QTY { get; set; }
        public decimal REQ_QTY { get; set; }
        public decimal ISSUE_QTY { get; set; }
        public string UNIT_CODE { get; set; }
        public decimal RETURN_QTY { get; set; }
        public decimal WASTAGE_QTY { get; set; }
        public decimal CONSUMED_QTY { get; set; }
        public string REMARKS { get; set; }
        public string TR_TYPE { get; set; }
        public decimal FIFO_Cost { get; set; }
        public decimal LIFO_Cost { get; set; }
        public decimal Avg_Cost { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_MF_BOM_HEAD TSPL_MF_BOM_HEAD { get; set; }
        public virtual TSPL_MF_ISSUE TSPL_MF_ISSUE { get; set; }
        public virtual TSPL_MF_PRODUCTION_LINES TSPL_MF_PRODUCTION_LINES { get; set; }
        public virtual TSPL_MF_RETURN TSPL_MF_RETURN { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
    }
}
