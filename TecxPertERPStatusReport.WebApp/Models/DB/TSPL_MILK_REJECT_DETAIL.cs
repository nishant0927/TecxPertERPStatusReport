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
    
    public partial class TSPL_MILK_REJECT_DETAIL
    {
        public string DOC_CODE { get; set; }
        public string Item_Code { get; set; }
        public int SAMPLE_NO { get; set; }
        public string VLC_CODE { get; set; }
        public string ROUTE_CODE { get; set; }
        public string VSP_CODE { get; set; }
        public string VEHICLE_CODE { get; set; }
        public int Other_VEHICLE { get; set; }
        public int Other_VLC { get; set; }
        public Nullable<int> NO_OF_CANS { get; set; }
        public decimal MILK_WEIGHT { get; set; }
        public decimal ACC_WEIGHT_KG { get; set; }
        public decimal ACC_WEIGHT_LTR { get; set; }
        public decimal Conversion_Factor { get; set; }
        public string UOM_Code { get; set; }
        public decimal FAT { get; set; }
        public decimal SNF { get; set; }
        public string Reject_Type { get; set; }
        public decimal SNF_RATE { get; set; }
        public decimal SNF_Amount { get; set; }
        public decimal FAT_RATE { get; set; }
        public decimal FAT_Amount { get; set; }
        public Nullable<decimal> RATE { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> SNF_Deduction_Per { get; set; }
        public Nullable<decimal> SNF_Deduction_Amount { get; set; }
        public Nullable<decimal> SNF_Amount_After_Deduction { get; set; }
        public Nullable<decimal> FAT_Deduction_Per { get; set; }
        public Nullable<decimal> FAT_Deduction_Amount { get; set; }
        public Nullable<decimal> FAT_Amount_After_Deduction { get; set; }
        public int Is_Return { get; set; }
        public string Price_Code { get; set; }
        public string Defaulter { get; set; }
        public Nullable<decimal> Org_Rate { get; set; }
        public Nullable<decimal> Applicable_Per { get; set; }
        public string Against_Shift_Uploader_TR_No { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_MILK_SHIFT_UPLOADER_DETAIL TSPL_MILK_SHIFT_UPLOADER_DETAIL { get; set; }
        public virtual TSPL_MILK_REJECT_HEAD TSPL_MILK_REJECT_HEAD { get; set; }
        public virtual TSPL_VLC_MASTER_HEAD TSPL_VLC_MASTER_HEAD { get; set; }
        public virtual TSPL_VENDOR_MASTER TSPL_VENDOR_MASTER { get; set; }
    }
}
