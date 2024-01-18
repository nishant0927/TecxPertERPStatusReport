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
    
    public partial class TSPL_MF_BATCH_PP_DETAIL
    {
        public string BO_CODE { get; set; }
        public string PROD_PLAN_CODE { get; set; }
        public string PRODUCTION_LINE_CODE { get; set; }
        public string BOM_CODE { get; set; }
        public string BOM_REVISION_NO { get; set; }
        public string ITEM_CODE { get; set; }
        public string ITEM_DESCRIPTION { get; set; }
        public decimal MIN_QUANTITY { get; set; }
        public decimal MAX_QUANTITY { get; set; }
        public string UNIT_CODE { get; set; }
        public string REMARKS { get; set; }
        public decimal BATCH_QTY { get; set; }
        public Nullable<System.TimeSpan> START_TIME { get; set; }
        public Nullable<System.TimeSpan> END_TIME { get; set; }
        public Nullable<decimal> HOURS { get; set; }
        public Nullable<decimal> SPEED { get; set; }
        public string REASON { get; set; }
        public Nullable<System.DateTime> MF_DATE { get; set; }
        public Nullable<System.DateTime> EXP_DATE { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_MF_BATCH_ORDER TSPL_MF_BATCH_ORDER { get; set; }
        public virtual TSPL_MF_BOM_HEAD TSPL_MF_BOM_HEAD { get; set; }
        public virtual TSPL_MF_PRODUCTION_LINES TSPL_MF_PRODUCTION_LINES { get; set; }
        public virtual TSPL_MF_PRODUCTION_PLAN_HEAD TSPL_MF_PRODUCTION_PLAN_HEAD { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
    }
}