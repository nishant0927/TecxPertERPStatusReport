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
    
    public partial class TSPL_TRANSFER_ORDER_DETAIL
    {
        public string Document_No { get; set; }
        public int Line_No { get; set; }
        public string Row_Type { get; set; }
        public string Item_Code { get; set; }
        public string Item_Desc { get; set; }
        public Nullable<decimal> MRP { get; set; }
        public string TransferOutNo { get; set; }
        public Nullable<decimal> Out_Qty { get; set; }
        public Nullable<decimal> In_Qty { get; set; }
        public Nullable<decimal> Breakage { get; set; }
        public Nullable<decimal> Shortage { get; set; }
        public Nullable<decimal> Leak { get; set; }
        public string Unit_code { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> Item_Cost { get; set; }
        public string Location { get; set; }
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
        public Nullable<double> Item_Unit_Wt { get; set; }
        public Nullable<double> Item_Net_Wt { get; set; }
        public Nullable<double> Item_Net_MT_Wt { get; set; }
        public string Alt_Unit_Code { get; set; }
        public Nullable<decimal> Abatement_Per { get; set; }
        public Nullable<decimal> Abatement_Amt { get; set; }
        public string Bin_No { get; set; }
        public string GatePassNo { get; set; }
        public string ItemwiseTaxCode { get; set; }
    
        public virtual TSPL_GATEPASS_TRANSFER_HEAD TSPL_GATEPASS_TRANSFER_HEAD { get; set; }
        public virtual TSPL_TRANSFER_ORDER_HEAD TSPL_TRANSFER_ORDER_HEAD { get; set; }
    }
}
