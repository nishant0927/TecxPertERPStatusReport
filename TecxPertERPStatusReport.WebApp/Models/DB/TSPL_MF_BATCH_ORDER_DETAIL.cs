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
    
    public partial class TSPL_MF_BATCH_ORDER_DETAIL
    {
        public string BO_CODE { get; set; }
        public string PROD_PLAN_CODE { get; set; }
        public string PRODUCTION_LINE_CODE { get; set; }
        public string BOM_CODE { get; set; }
        public string ITEM_CODE { get; set; }
        public string UNIT_CODE { get; set; }
        public decimal QTY { get; set; }
        public decimal ACTUAL_REQ_QTY { get; set; }
        public decimal ISSUE_QTY { get; set; }
        public decimal RETURN_QTY { get; set; }
        public decimal BREAKAGE_QTY { get; set; }
        public decimal REJ_QTY { get; set; }
        public decimal CONSM_QTY { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_MF_BATCH_ORDER TSPL_MF_BATCH_ORDER { get; set; }
        public virtual TSPL_MF_BOM_HEAD TSPL_MF_BOM_HEAD { get; set; }
        public virtual TSPL_MF_PRODUCTION_LINES TSPL_MF_PRODUCTION_LINES { get; set; }
        public virtual TSPL_MF_PRODUCTION_PLAN_HEAD TSPL_MF_PRODUCTION_PLAN_HEAD { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
    }
}
