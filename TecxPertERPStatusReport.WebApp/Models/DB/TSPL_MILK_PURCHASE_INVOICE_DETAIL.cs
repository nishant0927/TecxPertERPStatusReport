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
    
    public partial class TSPL_MILK_PURCHASE_INVOICE_DETAIL
    {
        public string DOC_CODE { get; set; }
        public string SRN_CODE { get; set; }
        public string Item_Code { get; set; }
        public decimal Qty { get; set; }
        public decimal FAT_PER { get; set; }
        public decimal SNF_PER { get; set; }
        public string MCC_CODE { get; set; }
        public string VEHICLE_NO { get; set; }
        public string VLC_NO { get; set; }
        public int Cans { get; set; }
        public decimal Correction_Factor { get; set; }
        public decimal CLR { get; set; }
        public decimal RATE { get; set; }
        public decimal AMOUNT { get; set; }
        public decimal Incentive { get; set; }
        public decimal COMMISSION { get; set; }
        public decimal TOTAL_AMOUNT { get; set; }
        public decimal PAYMENT_COMMISSION { get; set; }
        public decimal TOTAL_AMOUNT_ACC { get; set; }
        public decimal Deduction_AMOUNT { get; set; }
        public decimal Net_AMOUNT { get; set; }
        public decimal ACC_Qty { get; set; }
        public string Service_Charge { get; set; }
        public decimal IncentiveEMP { get; set; }
        public decimal Head_Load_AMOUNT { get; set; }
        public decimal Own_Asset_AMOUNT { get; set; }
        public int PK_Id { get; set; }
        public Nullable<decimal> Service_Charge_Amount { get; set; }
        public Nullable<decimal> Handling_Charges_Amount { get; set; }
        public Nullable<decimal> SRN_Net_Amount { get; set; }
        public Nullable<decimal> SRN_RO_Amount { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_MCC_MASTER TSPL_MCC_MASTER { get; set; }
        public virtual TSPL_MILK_PURCHASE_INVOICE_HEAD TSPL_MILK_PURCHASE_INVOICE_HEAD { get; set; }
        public virtual TSPL_MILK_SRN_HEAD TSPL_MILK_SRN_HEAD { get; set; }
    }
}
