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
    
    public partial class TSPL_JOURNAL_MASTER_SYNC
    {
        public string Type { get; set; }
        public bool SendToTally { get; set; }
        public string CURRENCY_CODE { get; set; }
        public decimal ConvRate { get; set; }
        public Nullable<System.DateTime> ApplicableFrom { get; set; }
        public decimal ConvRateOld { get; set; }
        public string Segment_code { get; set; }
        public int Journal_No { get; set; }
        public string Voucher_No { get; set; }
        public Nullable<System.DateTime> Voucher_Date { get; set; }
        public string Source_Code { get; set; }
        public string Source_Desc { get; set; }
        public string Source_Doc_No { get; set; }
        public Nullable<System.DateTime> Source_Doc_Date { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string Voucher_Desc { get; set; }
        public string Source_Narration { get; set; }
        public string Remarks { get; set; }
        public string Comments { get; set; }
        public string Auto_Reverse { get; set; }
        public string Reverse_Date { get; set; }
        public string Source_Type { get; set; }
        public string CustVend_Code { get; set; }
        public string CustVend_Name { get; set; }
        public string Transaction_Type { get; set; }
        public string Provisional_Post { get; set; }
        public string Authorized { get; set; }
        public decimal Total_Debit_Amt { get; set; }
        public decimal Total_Credit_Amt { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modify_By { get; set; }
        public string Modify_Date { get; set; }
        public string Comp_Code { get; set; }
        public Nullable<int> MonthlyReverse { get; set; }
        public string ProgramCode { get; set; }
        public int IND_AS { get; set; }
        public Nullable<int> SYNC_STATUS { get; set; }
        public string AgainstVoucherNoReverseEntry { get; set; }
        public Nullable<System.DateTime> DateAndTime { get; set; }
        public string TapalNo { get; set; }
        public string VSP_CODE { get; set; }
    
        public virtual TSPL_CURRENCY_MASTER TSPL_CURRENCY_MASTER { get; set; }
        public virtual TSPL_PROGRAM_MASTER TSPL_PROGRAM_MASTER { get; set; }
    }
}
