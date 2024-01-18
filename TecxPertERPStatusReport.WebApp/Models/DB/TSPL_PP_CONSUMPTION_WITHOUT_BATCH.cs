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
    
    public partial class TSPL_PP_CONSUMPTION_WITHOUT_BATCH
    {
        public string PROD_ENTRY_CODE { get; set; }
        public string Main_ITEM_CODE { get; set; }
        public string BOM_CODE { get; set; }
        public string MAIN_UOM { get; set; }
        public string CONSM_ITEM_CODE { get; set; }
        public double CONSM_QTY { get; set; }
        public string LOCATION_CODE { get; set; }
        public string UNIT_CODE { get; set; }
        public decimal FIFO_Cost { get; set; }
        public decimal LIFO_Cost { get; set; }
        public decimal Avg_Cost { get; set; }
        public Nullable<double> FAT_Per { get; set; }
        public Nullable<double> SNF_Per { get; set; }
        public Nullable<double> FAT_KG { get; set; }
        public Nullable<double> SNF_KG { get; set; }
        public double Fat_Rate { get; set; }
        public double SNF_Rate { get; set; }
        public double Fat_Amt { get; set; }
        public double SNF_Amt { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER1 { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_PP_PRODUCTION_ENTRY TSPL_PP_PRODUCTION_ENTRY { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER1 { get; set; }
    }
}
