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
    
    public partial class TSPL_INVOICE_MASTER_BULKSALE_HISTORY
    {
        public string Document_No { get; set; }
        public System.DateTime Document_Date { get; set; }
        public string Customer_Code { get; set; }
        public string Location_Code { get; set; }
        public decimal RoundOffAmount { get; set; }
        public decimal Total_Amt { get; set; }
        public int Posted { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string InvoiceAgainst { get; set; }
        public Nullable<System.DateTime> From_date { get; set; }
        public Nullable<System.DateTime> To_date { get; set; }
        public string Comp_Code { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string History_Date { get; set; }
        public int IsUploader { get; set; }
        public string Comments { get; set; }
        public string EWayBillNo { get; set; }
        public Nullable<System.DateTime> EWayBillDate { get; set; }
        public string Electronic_Ref_No { get; set; }
        public int Tax_Calculation_Type { get; set; }
        public string Tax_Group { get; set; }
        public string TAX1 { get; set; }
        public Nullable<decimal> TAX1_Rate { get; set; }
        public Nullable<decimal> TAX1_Amt { get; set; }
        public Nullable<decimal> TAX1_Base_Amt { get; set; }
        public string TAX2 { get; set; }
        public Nullable<decimal> TAX2_Rate { get; set; }
        public Nullable<decimal> TAX2_Amt { get; set; }
        public Nullable<decimal> TAX2_Base_Amt { get; set; }
        public string TAX3 { get; set; }
        public Nullable<decimal> TAX3_Rate { get; set; }
        public Nullable<decimal> TAX3_Amt { get; set; }
        public Nullable<decimal> TAX3_Base_Amt { get; set; }
        public string TAX4 { get; set; }
        public Nullable<decimal> TAX4_Rate { get; set; }
        public Nullable<decimal> TAX4_Amt { get; set; }
        public Nullable<decimal> TAX4_Base_Amt { get; set; }
        public string TAX5 { get; set; }
        public Nullable<decimal> TAX5_Rate { get; set; }
        public Nullable<decimal> TAX5_Amt { get; set; }
        public Nullable<decimal> TAX5_Base_Amt { get; set; }
        public Nullable<decimal> Amount_Less_Discount { get; set; }
        public Nullable<decimal> Total_Tax_Amt { get; set; }
        public Nullable<decimal> Document_Amount { get; set; }
        public Nullable<double> ActualTCSBaseAmount { get; set; }
        public Nullable<double> ChangedTCSBaseAmount { get; set; }
    }
}
