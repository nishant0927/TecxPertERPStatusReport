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
    
    public partial class TSPL_VENDOR_INVOICE_DETAIL
    {
        public string Document_No { get; set; }
        public int Detail_Line_No { get; set; }
        public string GL_Account_Code { get; set; }
        public string GL_Account_Desc { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> Discount_Per { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> Amount_less_Discount { get; set; }
        public string TAX1 { get; set; }
        public Nullable<decimal> TAX1_Rate { get; set; }
        public Nullable<decimal> TAX1_Amt { get; set; }
        public string TAX2 { get; set; }
        public Nullable<decimal> TAX2_Rate { get; set; }
        public Nullable<decimal> TAX2_Amt { get; set; }
        public string TAX3 { get; set; }
        public Nullable<decimal> TAX3_Rate { get; set; }
        public Nullable<decimal> TAX3_Amt { get; set; }
        public string TAX4 { get; set; }
        public Nullable<decimal> TAX4_Rate { get; set; }
        public Nullable<decimal> TAX4_Amt { get; set; }
        public string TAX5 { get; set; }
        public Nullable<decimal> TAX5_Rate { get; set; }
        public Nullable<decimal> TAX5_Amt { get; set; }
        public string TAX6 { get; set; }
        public Nullable<decimal> TAX6_Rate { get; set; }
        public Nullable<decimal> TAX6_Amt { get; set; }
        public string TAX7 { get; set; }
        public Nullable<decimal> TAX7_Rate { get; set; }
        public Nullable<decimal> TAX7_Amt { get; set; }
        public string TAX8 { get; set; }
        public Nullable<decimal> TAX8_Rate { get; set; }
        public Nullable<decimal> TAX8_Amt { get; set; }
        public string TAX9 { get; set; }
        public Nullable<decimal> TAX9_Rate { get; set; }
        public Nullable<decimal> TAX9_Amt { get; set; }
        public string TAX10 { get; set; }
        public Nullable<decimal> TAX10_Rate { get; set; }
        public Nullable<decimal> TAX10_Amt { get; set; }
        public Nullable<decimal> Total_Tax { get; set; }
        public decimal Total_Amount { get; set; }
        public string Remarks { get; set; }
        public string Comments { get; set; }
        public string AddChargeCode { get; set; }
        public string AddChargeDesc { get; set; }
        public int is_Unclaimed_Tax { get; set; }
        public string Invoice_No { get; set; }
        public string Invoice_Type { get; set; }
        public Nullable<decimal> Landed_Amount { get; set; }
        public string Deduction_Code { get; set; }
        public string item_code { get; set; }
        public string item_desc { get; set; }
        public string charge_cat_code { get; set; }
        public string charge_cat_desc { get; set; }
        public Nullable<double> charge_cat_charges { get; set; }
        public Nullable<decimal> Item_Rate { get; set; }
        public Nullable<decimal> Abatement_Per { get; set; }
        public Nullable<decimal> Abatement_Amt { get; set; }
        public Nullable<decimal> TAX1_Base_Amt { get; set; }
        public Nullable<decimal> TAX2_Base_Amt { get; set; }
        public Nullable<decimal> TAX3_Base_Amt { get; set; }
        public Nullable<decimal> TAX4_Base_Amt { get; set; }
        public Nullable<decimal> TAX5_Base_Amt { get; set; }
        public Nullable<decimal> TAX6_Base_Amt { get; set; }
        public Nullable<decimal> TAX7_Base_Amt { get; set; }
        public Nullable<decimal> TAX8_Base_Amt { get; set; }
        public Nullable<decimal> TAX9_Base_Amt { get; set; }
        public Nullable<decimal> TAX10_Base_Amt { get; set; }
        public string DeductionCode { get; set; }
        public string Deduction_Desc { get; set; }
        public int PK_Id { get; set; }
        public Nullable<decimal> Reverse_Charge_Per { get; set; }
        public Nullable<decimal> Reverse_Charge_Amount { get; set; }
        public string AgainstPayment_No { get; set; }
        public double Payment_Amount { get; set; }
        public double TDS_Per { get; set; }
        public string Hirerachy_Code { get; set; }
        public string Cost_Centre_Code { get; set; }
        public string Against_Milk_SRN_Commission_No { get; set; }
        public string Asset_Code { get; set; }
        public string Item_Type { get; set; }
        public string SAC_Code { get; set; }
        public Nullable<decimal> Taxable_Amount_Per { get; set; }
        public Nullable<decimal> Taxable_Amount { get; set; }
        public string Hirerachy_Code3 { get; set; }
        public string Hirerachy_Code4 { get; set; }
        public string Hirerachy_Code1 { get; set; }
        public string Hirerachy_Code2 { get; set; }
        public string DCS_Addition_Deduction { get; set; }
    
        public virtual TSPL_COST_CENTRE_FINANCIAL TSPL_COST_CENTRE_FINANCIAL { get; set; }
        public virtual TSPL_COST_CENTRE_FINANCIAL TSPL_COST_CENTRE_FINANCIAL1 { get; set; }
        public virtual TSPL_COST_CENTRE_FINANCIAL TSPL_COST_CENTRE_FINANCIAL2 { get; set; }
        public virtual TSPL_COST_CENTRE_FINANCIAL TSPL_COST_CENTRE_FINANCIAL3 { get; set; }
        public virtual TSPL_COST_CENTRE_FINANCIAL TSPL_COST_CENTRE_FINANCIAL4 { get; set; }
        public virtual TSPL_DCS_ADDITION_DEDUCTION TSPL_DCS_ADDITION_DEDUCTION { get; set; }
        public virtual TSPL_HIRERACHY_LEVEL_MASTER TSPL_HIRERACHY_LEVEL_MASTER { get; set; }
        public virtual TSPL_MILK_SRN_HEAD TSPL_MILK_SRN_HEAD { get; set; }
        public virtual TSPL_PAYMENT_HEADER TSPL_PAYMENT_HEADER { get; set; }
        public virtual TSPL_SAC_MASTER TSPL_SAC_MASTER { get; set; }
        public virtual TSPL_TDS_DEDUCTION_HEAD TSPL_TDS_DEDUCTION_HEAD { get; set; }
        public virtual TSPL_VENDOR_INVOICE_HEAD TSPL_VENDOR_INVOICE_HEAD { get; set; }
    }
}
