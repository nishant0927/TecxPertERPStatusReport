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
    
    public partial class TSPL_ASSET_SCRAP_DETAIL
    {
        public string Document_No { get; set; }
        public string Asset_Code { get; set; }
        public int Line_No { get; set; }
        public string Item_Code { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public string UOM { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<decimal> Amt { get; set; }
        public Nullable<decimal> Discount_Per { get; set; }
        public Nullable<decimal> Discount_Amt { get; set; }
        public Nullable<decimal> Amt_After_Discount { get; set; }
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
        public Nullable<decimal> Tax_Amt { get; set; }
        public Nullable<decimal> Amt_After_Tax { get; set; }
        public string CostCenter_Code { get; set; }
        public string Hirerachy_Code { get; set; }
    
        public virtual TSPL_ASSET_SCRAP_HEAD TSPL_ASSET_SCRAP_HEAD { get; set; }
        public virtual TSPL_HIRERACHY_LEVEL_MASTER TSPL_HIRERACHY_LEVEL_MASTER { get; set; }
    }
}
