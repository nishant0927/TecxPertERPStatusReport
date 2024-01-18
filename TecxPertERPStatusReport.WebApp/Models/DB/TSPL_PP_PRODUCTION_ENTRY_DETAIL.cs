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
    
    public partial class TSPL_PP_PRODUCTION_ENTRY_DETAIL
    {
        public string PROD_ENTRY_CODE { get; set; }
        public string BOM_CODE { get; set; }
        public string ITEM_CODE { get; set; }
        public string ITEM_DESCRIPTION { get; set; }
        public double BATCH_QTY { get; set; }
        public double RECEIPT_QTY { get; set; }
        public string REJ_HEAD { get; set; }
        public double REJ_QTY { get; set; }
        public string BREAKAGE_HEAD { get; set; }
        public double BREAKAGE_QTY { get; set; }
        public string LAB_TESTING { get; set; }
        public string UNIT_CODE { get; set; }
        public Nullable<System.TimeSpan> START_TIME { get; set; }
        public Nullable<System.TimeSpan> END_TIME { get; set; }
        public System.DateTime MFG_DATE { get; set; }
        public System.DateTime EXP_DATE { get; set; }
        public Nullable<decimal> FIFO_Cost { get; set; }
        public Nullable<decimal> LIFO_Cost { get; set; }
        public Nullable<decimal> Avg_Cost { get; set; }
        public string Shift_Code { get; set; }
        public string Section_Code { get; set; }
        public Nullable<double> FAT_Per { get; set; }
        public Nullable<double> SNF_Per { get; set; }
        public Nullable<double> FAT_KG { get; set; }
        public Nullable<double> SNF_KG { get; set; }
        public Nullable<double> FINAL_PRODUCTION_QTY { get; set; }
        public string LOCATION_CODE { get; set; }
        public Nullable<double> Fat_Rate { get; set; }
        public Nullable<double> SNF_Rate { get; set; }
        public Nullable<double> Fat_Amt { get; set; }
        public Nullable<double> SNF_Amt { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_PP_BOM_HEAD TSPL_PP_BOM_HEAD { get; set; }
        public virtual TSPL_PP_PRODUCTION_ENTRY TSPL_PP_PRODUCTION_ENTRY { get; set; }
        public virtual TSPL_SECTION_MASTER TSPL_SECTION_MASTER { get; set; }
        public virtual TSPL_SHIFT_MASTER TSPL_SHIFT_MASTER { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
    }
}
