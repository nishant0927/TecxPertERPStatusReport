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
    
    public partial class TSPL_MILK_PURCHASE_INVOICE_OWN_BMC
    {
        public int PK_Id { get; set; }
        public string InvoiceNo { get; set; }
        public System.DateTime Doc_Date { get; set; }
        public int Against_Milk_Collection_MCC_Detail { get; set; }
        public string Planning_Code { get; set; }
        public Nullable<decimal> DCS_Qty { get; set; }
        public Nullable<decimal> DCS_FATKG { get; set; }
        public Nullable<decimal> DCS_SNFKG { get; set; }
        public Nullable<decimal> DIFF_FATKG { get; set; }
        public Nullable<decimal> DIFF_SNFKG { get; set; }
        public Nullable<decimal> FAT_Rate { get; set; }
        public Nullable<decimal> SNF_Rate { get; set; }
        public Nullable<decimal> DIFF_FAT_Amt { get; set; }
        public Nullable<decimal> DIFF_SNF_Amt { get; set; }
        public Nullable<decimal> FAT_Amt { get; set; }
        public Nullable<decimal> SNF_Amt { get; set; }
        public Nullable<decimal> Amt { get; set; }
        public string Against_Own_BMC_Gain_Loss_Rate { get; set; }
    
        public virtual TSPL_MILK_COLLECTION_MCC_DETAIL TSPL_MILK_COLLECTION_MCC_DETAIL { get; set; }
        public virtual TSPL_MILK_PURCHASE_INVOICE_HEAD TSPL_MILK_PURCHASE_INVOICE_HEAD { get; set; }
        public virtual TSPL_OWN_BMC_GAIN_LOSS_RATE TSPL_OWN_BMC_GAIN_LOSS_RATE { get; set; }
        public virtual TSPL_PRICE_CHART_PLANNING TSPL_PRICE_CHART_PLANNING { get; set; }
    }
}