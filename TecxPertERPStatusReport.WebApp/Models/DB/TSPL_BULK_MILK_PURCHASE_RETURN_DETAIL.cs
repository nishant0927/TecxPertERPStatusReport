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
    
    public partial class TSPL_BULK_MILK_PURCHASE_RETURN_DETAIL
    {
        public string Pur_Return_No { get; set; }
        public string Invoice_No { get; set; }
        public int SL_NO { get; set; }
        public string SRN_NO { get; set; }
        public Nullable<System.DateTime> SRN_Date { get; set; }
        public string Item_Code { get; set; }
        public string Item_Desc { get; set; }
        public string UOM { get; set; }
        public double Gross_Weight { get; set; }
        public double Tare_Weight { get; set; }
        public double Net_Weight { get; set; }
        public double Invoice_Qty { get; set; }
        public double snf_Per { get; set; }
        public double fat_per { get; set; }
        public double fat_KG { get; set; }
        public double SNF_KG { get; set; }
        public double fat_Rate { get; set; }
        public double SNF_Rate { get; set; }
        public double Amount { get; set; }
        public double Deduction { get; set; }
        public double Incentive { get; set; }
        public double Special_Deduction { get; set; }
        public double Actual_Amount { get; set; }
        public string Price_code { get; set; }
        public double NetRate { get; set; }
        public string CHAMBER_DESC { get; set; }
    
        public virtual tspl_Bulk_milk_purchase_Invoice_head tspl_Bulk_milk_purchase_Invoice_head { get; set; }
        public virtual TSPL_BULK_MILK_PURCHASE_RETURN_HEAD TSPL_BULK_MILK_PURCHASE_RETURN_HEAD { get; set; }
        public virtual TSPL_Bulk_MILK_SRN TSPL_Bulk_MILK_SRN { get; set; }
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
    }
}
