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
    
    public partial class TSPL_INV_MOVE_TRANS_DL
    {
        public int INV_ID { get; set; }
        public Nullable<System.DateTime> TRANS_DATE { get; set; }
        public string Location_Code { get; set; }
        public string Item_Code { get; set; }
        public string Item_Desc { get; set; }
        public string Stock_UOM { get; set; }
        public string Trans_Type { get; set; }
        public decimal FIFO_Cost { get; set; }
        public decimal LIFO_Cost { get; set; }
        public decimal In_Avg_Cost { get; set; }
        public decimal Out_Avg_Cost { get; set; }
        public decimal Avg_Cost { get; set; }
        public decimal IN_QTY { get; set; }
        public decimal Out_QTY { get; set; }
        public decimal TRANS_QTY { get; set; }
        public decimal In_Fat_KG { get; set; }
        public decimal Out_Fat_KG { get; set; }
        public decimal Fat_KG { get; set; }
        public decimal In_SNF_KG { get; set; }
        public decimal Out_SNF_KG { get; set; }
        public decimal SNF_KG { get; set; }
        public decimal CL_QTY { get; set; }
        public decimal CL_FAT_KG { get; set; }
        public decimal CL_SNF_KG { get; set; }
        public decimal CL_FIFO_Cost { get; set; }
        public decimal CL_LIFO_Cost { get; set; }
        public decimal CL_Avg_Cost { get; set; }
        public bool AGEING_Flag { get; set; }
        public decimal AGEING_QTY { get; set; }
        public decimal QC_In_FAT_KG { get; set; }
        public decimal QC_Out_FAT_KG { get; set; }
        public decimal QC_FAT_KG { get; set; }
        public decimal QC_In_SNF_KG { get; set; }
        public decimal QC_Out_SNF_KG { get; set; }
        public decimal QC_SNF_KG { get; set; }
        public decimal CL_QC_FAT_KG { get; set; }
        public decimal CL_QC_SNF_KG { get; set; }
        public bool IsFromMilk { get; set; }
    }
}
