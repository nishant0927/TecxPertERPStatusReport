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
    
    public partial class TSPL_PURCHASE_ORDER_DETAIL_Hist
    {
        public string PurchaseOrder_No { get; set; }
        public int Line_No { get; set; }
        public string Item_Code { get; set; }
        public string Item_Desc { get; set; }
        public Nullable<decimal> PurchaseOrder_Qty { get; set; }
        public string Requisition_Id { get; set; }
        public Nullable<decimal> Balance_Qty { get; set; }
        public string Unit_code { get; set; }
        public string Location { get; set; }
        public Nullable<decimal> Item_Cost { get; set; }
        public string TAX1 { get; set; }
        public Nullable<decimal> TAX1_Base_Amt { get; set; }
        public Nullable<decimal> TAX1_Rate { get; set; }
        public Nullable<decimal> TAX1_Amt { get; set; }
        public string TAX2 { get; set; }
        public Nullable<decimal> TAX2_Base_Amt { get; set; }
        public Nullable<decimal> TAX2_Rate { get; set; }
        public Nullable<decimal> TAX2_Amt { get; set; }
        public string TAX3 { get; set; }
        public Nullable<decimal> TAX3_Base_Amt { get; set; }
        public Nullable<decimal> TAX3_Rate { get; set; }
        public Nullable<decimal> TAX3_Amt { get; set; }
        public string TAX4 { get; set; }
        public Nullable<decimal> TAX4_Base_Amt { get; set; }
        public Nullable<decimal> TAX4_Rate { get; set; }
        public Nullable<decimal> TAX4_Amt { get; set; }
        public string TAX5 { get; set; }
        public Nullable<decimal> TAX5_Base_Amt { get; set; }
        public Nullable<decimal> TAX5_Rate { get; set; }
        public Nullable<decimal> TAX5_Amt { get; set; }
        public string TAX6 { get; set; }
        public Nullable<decimal> TAX6_Base_Amt { get; set; }
        public Nullable<decimal> TAX6_Rate { get; set; }
        public Nullable<decimal> TAX6_Amt { get; set; }
        public string TAX7 { get; set; }
        public Nullable<decimal> TAX7_Base_Amt { get; set; }
        public Nullable<decimal> TAX7_Rate { get; set; }
        public Nullable<decimal> TAX7_Amt { get; set; }
        public string TAX8 { get; set; }
        public Nullable<decimal> TAX8_Base_Amt { get; set; }
        public Nullable<decimal> TAX8_Rate { get; set; }
        public Nullable<decimal> TAX8_Amt { get; set; }
        public string TAX9 { get; set; }
        public Nullable<decimal> TAX9_Base_Amt { get; set; }
        public Nullable<decimal> TAX9_Rate { get; set; }
        public Nullable<decimal> TAX9_Amt { get; set; }
        public string TAX10 { get; set; }
        public Nullable<decimal> TAX10_Base_Amt { get; set; }
        public Nullable<decimal> TAX10_Rate { get; set; }
        public Nullable<decimal> TAX10_Amt { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> Disc_Per { get; set; }
        public Nullable<decimal> Disc_Amt { get; set; }
        public Nullable<decimal> Amt_Less_Discount { get; set; }
        public Nullable<decimal> Total_Tax_Amt { get; set; }
        public Nullable<decimal> Item_Net_Amt { get; set; }
        public int Status { get; set; }
        public string Specification { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> Abandonment_No { get; set; }
        public Nullable<decimal> MRP { get; set; }
        public Nullable<decimal> Assessable { get; set; }
        public Nullable<decimal> AssessableAmt { get; set; }
        public string Row_Type { get; set; }
        public Nullable<double> Last_Same_Vendor_Rate { get; set; }
        public Nullable<double> Last_Other_Vendor_Rate { get; set; }
        public string ItemAdd_Charge_Code1 { get; set; }
        public Nullable<double> ItemAdd_Org_Charge_Amt1 { get; set; }
        public Nullable<double> ItemAdd_Calc_Charge_Amt1 { get; set; }
        public string ItemAdd_Charge_Code2 { get; set; }
        public Nullable<double> ItemAdd_Org_Charge_Amt2 { get; set; }
        public Nullable<double> ItemAdd_Calc_Charge_Amt2 { get; set; }
        public string ItemAdd_Charge_Code3 { get; set; }
        public Nullable<double> ItemAdd_Org_Charge_Amt3 { get; set; }
        public Nullable<double> ItemAdd_Calc_Charge_Amt3 { get; set; }
        public string ItemAdd_Charge_Code4 { get; set; }
        public Nullable<double> ItemAdd_Org_Charge_Amt4 { get; set; }
        public Nullable<double> ItemAdd_Calc_Charge_Amt4 { get; set; }
        public string ItemAdd_Charge_Code5 { get; set; }
        public Nullable<double> ItemAdd_Org_Charge_Amt5 { get; set; }
        public Nullable<double> ItemAdd_Calc_Charge_Amt5 { get; set; }
        public string ItemAdd_Charge_Code6 { get; set; }
        public Nullable<double> ItemAdd_Org_Charge_Amt6 { get; set; }
        public Nullable<double> ItemAdd_Calc_Charge_Amt6 { get; set; }
        public string ItemAdd_Charge_Code7 { get; set; }
        public Nullable<double> ItemAdd_Org_Charge_Amt7 { get; set; }
        public Nullable<double> ItemAdd_Calc_Charge_Amt7 { get; set; }
        public string ItemAdd_Charge_Code8 { get; set; }
        public Nullable<double> ItemAdd_Org_Charge_Amt8 { get; set; }
        public Nullable<double> ItemAdd_Calc_Charge_Amt8 { get; set; }
        public string ItemAdd_Charge_Code9 { get; set; }
        public Nullable<double> ItemAdd_Org_Charge_Amt9 { get; set; }
        public Nullable<double> ItemAdd_Calc_Charge_Amt9 { get; set; }
        public string ItemAdd_Charge_Code10 { get; set; }
        public Nullable<double> ItemAdd_Org_Charge_Amt10 { get; set; }
        public Nullable<double> ItemAdd_Calc_Charge_Amt10 { get; set; }
        public Nullable<double> Total_ItemAdd_Charge { get; set; }
        public string Against_Item_Wise_Tax_Rate { get; set; }
        public Nullable<decimal> Taxable_Amount_Per { get; set; }
        public Nullable<decimal> Taxable_Amount { get; set; }
        public Nullable<decimal> Insurance_Base_Amt { get; set; }
        public Nullable<decimal> Insurance_Per { get; set; }
        public Nullable<decimal> Header_Discount_Per { get; set; }
        public Nullable<decimal> Header_Discount_Amount { get; set; }
        public Nullable<decimal> Detail_Discount_Amount { get; set; }
    }
}
