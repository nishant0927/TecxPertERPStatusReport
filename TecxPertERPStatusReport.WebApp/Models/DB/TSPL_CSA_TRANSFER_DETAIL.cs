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
    
    public partial class TSPL_CSA_TRANSFER_DETAIL
    {
        public string DOC_CODE { get; set; }
        public int Line_No { get; set; }
        public string Item_Code { get; set; }
        public string Item_Desc { get; set; }
        public double Qty { get; set; }
        public Nullable<decimal> Balance_Qty { get; set; }
        public string Unit_code { get; set; }
        public double Unit_Rate { get; set; }
        public string Including_Tax { get; set; }
        public string CALC_TYPE { get; set; }
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
        public string Remarks { get; set; }
        public Nullable<decimal> MRP { get; set; }
        public Nullable<double> Transfer_Rate { get; set; }
        public Nullable<double> Item_Pack_Size { get; set; }
        public Nullable<double> Commision_Rate { get; set; }
        public Nullable<double> Other_Chrage { get; set; }
        public Nullable<double> Commission_Chrage { get; set; }
        public Nullable<double> Item_Master_Pack_Size { get; set; }
        public string Scheme_Applicable { get; set; }
        public string FOC { get; set; }
        public string Scheme_Code { get; set; }
        public string Scheme_Type { get; set; }
        public string Scheme_Item_Code { get; set; }
        public Nullable<double> Scheme_Qty { get; set; }
        public string Scheme_Item_UOM { get; set; }
        public string Cash_Scheme_Code { get; set; }
        public string Cash_Scheme_Type { get; set; }
        public Nullable<double> Cash_Scheme_Pers { get; set; }
        public Nullable<double> Cash_Scheme_Amount { get; set; }
        public Nullable<double> Item_Unit_Wt { get; set; }
        public Nullable<double> Item_Net_Wt { get; set; }
        public Nullable<double> Item_Net_MT_Wt { get; set; }
        public string CSA_Commission_RS_PERS { get; set; }
        public string Alt_Unit_Code { get; set; }
        public string DELEVERY_ORDER_NO { get; set; }
        public Nullable<double> DO_Qty { get; set; }
        public Nullable<double> DO_Pending_Qty { get; set; }
        public int Is_MRP_Mandatory { get; set; }
        public Nullable<double> Abatement_Pers { get; set; }
        public Nullable<double> Abatement_Amt { get; set; }
    
        public virtual TSPL_CSA_DO_HEAD TSPL_CSA_DO_HEAD { get; set; }
        public virtual TSPL_CSA_TRANSFER_HEAD TSPL_CSA_TRANSFER_HEAD { get; set; }
    }
}
