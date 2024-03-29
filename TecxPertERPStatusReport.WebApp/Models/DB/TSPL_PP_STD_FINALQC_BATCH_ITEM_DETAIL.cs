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
    
    public partial class TSPL_PP_STD_FINALQC_BATCH_ITEM_DETAIL
    {
        public string QC_Code { get; set; }
        public int SNO { get; set; }
        public string BOM_Code { get; set; }
        public string Item_Code { get; set; }
        public string Unit_Code { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public string Shift_Code { get; set; }
        public string Section_Code { get; set; }
        public Nullable<decimal> Requir_FAT_per { get; set; }
        public Nullable<decimal> Requir_SNF_Per { get; set; }
        public Nullable<decimal> Requir_FAT_KG { get; set; }
        public Nullable<decimal> Requir_SNF_KG { get; set; }
        public Nullable<decimal> Produced_Qty { get; set; }
        public Nullable<decimal> Produced_FAT_KG { get; set; }
        public Nullable<decimal> Produced_SNF_KG { get; set; }
        public Nullable<decimal> NO_SAMPLE_QC { get; set; }
        public Nullable<decimal> DAMAGE_Qty { get; set; }
        public Nullable<decimal> FINAL_PROD_Qty { get; set; }
        public string STD_Loaction_Code { get; set; }
        public Nullable<decimal> FIFO_Cost { get; set; }
        public Nullable<decimal> LIFO_Cost { get; set; }
        public Nullable<decimal> Avg_Cost { get; set; }
        public Nullable<decimal> Produced_FAT_per { get; set; }
        public Nullable<decimal> Produced_SNF_per { get; set; }
        public Nullable<decimal> Fat_Rate { get; set; }
        public Nullable<decimal> SNF_Rate { get; set; }
        public Nullable<decimal> Fat_Amt { get; set; }
        public Nullable<decimal> SNF_Amt { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_PP_STD_FINALQC_HEAD TSPL_PP_STD_FINALQC_HEAD { get; set; }
        public virtual TSPL_SECTION_MASTER TSPL_SECTION_MASTER { get; set; }
        public virtual TSPL_SHIFT_MASTER TSPL_SHIFT_MASTER { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
    }
}
