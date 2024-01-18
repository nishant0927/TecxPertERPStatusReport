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
    
    public partial class TSPL_PE_FINALQC_CONSUMPTION
    {
        public int CONSM_CODE { get; set; }
        public string QC_Code { get; set; }
        public string PROD_RETURN_CODE { get; set; }
        public string CONSM_ITEM_CODE { get; set; }
        public Nullable<decimal> CONSM_QTY { get; set; }
        public string LOCATION_CODE { get; set; }
        public string UNIT_CODE { get; set; }
        public Nullable<decimal> FIFO_Cost { get; set; }
        public Nullable<decimal> LIFO_Cost { get; set; }
        public Nullable<decimal> Avg_Cost { get; set; }
        public Nullable<decimal> FAT_Per { get; set; }
        public Nullable<decimal> SNF_Per { get; set; }
        public Nullable<decimal> FAT_KG { get; set; }
        public Nullable<decimal> SNF_KG { get; set; }
        public string Standardization_Code { get; set; }
        public Nullable<decimal> Fat_Rate { get; set; }
        public Nullable<decimal> SNF_Rate { get; set; }
        public Nullable<decimal> Fat_Amt { get; set; }
        public Nullable<decimal> SNF_Amt { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_PP_PRODUCTION_RETURN TSPL_PP_PRODUCTION_RETURN { get; set; }
        public virtual TSPL_PE_FINALQC_HEAD TSPL_PE_FINALQC_HEAD { get; set; }
        public virtual TSPL_PP_STANDARDIZATION_HEAD TSPL_PP_STANDARDIZATION_HEAD { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
    }
}