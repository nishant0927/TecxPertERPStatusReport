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
    
    public partial class TSPL_SRN_DETAIL_HISTORY
    {
        public string SRN_No { get; set; }
        public int Line_No { get; set; }
        public string Row_Type { get; set; }
        public string Item_Code { get; set; }
        public string Item_Desc { get; set; }
        public Nullable<decimal> SRN_Qty { get; set; }
        public Nullable<decimal> Rejected_Qty { get; set; }
        public string MRN_Id { get; set; }
        public string RGP_Id { get; set; }
        public string PO_ID { get; set; }
        public string Req_No { get; set; }
        public string GRN_ID { get; set; }
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
        public Nullable<decimal> MRP { get; set; }
        public string Batch_No { get; set; }
        public Nullable<System.DateTime> MFG_Date { get; set; }
        public Nullable<System.DateTime> Expiry_Date { get; set; }
        public Nullable<decimal> Unit_Cost_Tax_Rate { get; set; }
        public Nullable<decimal> Unit_Cost_Tax { get; set; }
        public Nullable<decimal> Add_Cost { get; set; }
        public Nullable<decimal> Landed_Cost { get; set; }
        public string Specification { get; set; }
        public string Remarks { get; set; }
        public Nullable<decimal> Assessable { get; set; }
        public Nullable<decimal> AssessableAmt { get; set; }
        public Nullable<decimal> Leak_Qty { get; set; }
        public Nullable<decimal> Burst_Qty { get; set; }
        public Nullable<decimal> Short_Qty { get; set; }
        public string Fater_Code { get; set; }
        public Nullable<decimal> Fater_Rate { get; set; }
        public Nullable<decimal> Fater_Amt { get; set; }
        public Nullable<decimal> PO_Qty { get; set; }
        public Nullable<decimal> GRN_Qty { get; set; }
        public Nullable<decimal> MRN_Qty { get; set; }
        public Nullable<decimal> Free_Qty { get; set; }
        public int Is_Mannual_Amt { get; set; }
        public Nullable<decimal> Total_RecTax_PerUnit { get; set; }
        public Nullable<decimal> Total_NonRecTax_PerUnit { get; set; }
        public Nullable<decimal> Total_AddtionalCost_PerUnit { get; set; }
        public string Bar_Code { get; set; }
        public decimal AbatementRate { get; set; }
        public decimal AssessableMRP { get; set; }
        public decimal TotalAssessableMRP { get; set; }
        public string Bin_No { get; set; }
        public string UOM_WEIGHT { get; set; }
        public decimal UOM_WEIGHT_VALUE { get; set; }
        public int Disc_Type { get; set; }
        public string Against_Schedule_Code { get; set; }
        public Nullable<double> RGP_Qty { get; set; }
        public Nullable<double> Schedule_Qty { get; set; }
        public Nullable<decimal> Landed_Cost_Rate { get; set; }
        public Nullable<decimal> Landed_Cost_Amount { get; set; }
        public Nullable<int> Version_Id { get; set; }
        public decimal Accepted_Amount { get; set; }
        public decimal Rejected_Amount { get; set; }
        public decimal Shortage_Amount { get; set; }
        public decimal Leak_Amount { get; set; }
        public decimal Burst_Amount { get; set; }
        public decimal Amt_Less_Discount_Without_Shortage { get; set; }
        public string RGP_NO { get; set; }
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
        public string Category { get; set; }
        public int Emergency { get; set; }
        public string Capex_Code { get; set; }
        public string Capex_SubCode { get; set; }
        public string Against_Item_Wise_Tax_Rate { get; set; }
        public Nullable<decimal> Taxable_Amount_Per { get; set; }
        public Nullable<decimal> Taxable_Amount { get; set; }
        public Nullable<decimal> Insurance_Base_Amt { get; set; }
        public Nullable<decimal> Insurance_Per { get; set; }
        public Nullable<decimal> Header_Discount_Per { get; set; }
        public Nullable<decimal> Header_Discount_Amount { get; set; }
        public Nullable<decimal> Detail_Discount_Amount { get; set; }
        public Nullable<decimal> Item_Insurance_Base_Amt { get; set; }
        public string Item_Insurance_Apply_On { get; set; }
        public Nullable<decimal> Item_Insurance_Rate { get; set; }
        public Nullable<decimal> Item_Insurance_Amt { get; set; }
        public Nullable<decimal> Item_Amt_After_Insurance { get; set; }
    
        public virtual TSPL_CAPEX_BUDGET_MASTER TSPL_CAPEX_BUDGET_MASTER { get; set; }
        public virtual TSPL_CAPEX_MASTER TSPL_CAPEX_MASTER { get; set; }
    }
}
