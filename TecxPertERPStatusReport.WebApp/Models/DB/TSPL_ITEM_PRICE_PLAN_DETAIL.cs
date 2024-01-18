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
    
    public partial class TSPL_ITEM_PRICE_PLAN_DETAIL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_ITEM_PRICE_PLAN_DETAIL()
        {
            this.TSPL_ITEM_PRICE_MASTER = new HashSet<TSPL_ITEM_PRICE_MASTER>();
        }
    
        public Nullable<int> SNo { get; set; }
        public string Plan_TR_Code { get; set; }
        public string Plan_Code { get; set; }
        public string Item_Code { get; set; }
        public string UOM { get; set; }
        public Nullable<decimal> Item_MRP { get; set; }
        public string Price_Code { get; set; }
        public string Price_Comp1 { get; set; }
        public Nullable<decimal> Price_Rate1 { get; set; }
        public Nullable<decimal> Price_Amount1 { get; set; }
        public string Price_Comp2 { get; set; }
        public Nullable<decimal> Price_Rate2 { get; set; }
        public Nullable<decimal> Price_Amount2 { get; set; }
        public string Price_Comp3 { get; set; }
        public Nullable<decimal> Price_Rate3 { get; set; }
        public Nullable<decimal> Price_Amount3 { get; set; }
        public string Price_Comp4 { get; set; }
        public Nullable<decimal> Price_Rate4 { get; set; }
        public Nullable<decimal> Price_Amount4 { get; set; }
        public string Price_Comp5 { get; set; }
        public Nullable<decimal> Price_Rate5 { get; set; }
        public Nullable<decimal> Price_Amount5 { get; set; }
        public string Price_Comp6 { get; set; }
        public Nullable<decimal> Price_Rate6 { get; set; }
        public Nullable<decimal> Price_Amount6 { get; set; }
        public string Price_Comp7 { get; set; }
        public Nullable<decimal> Price_Rate7 { get; set; }
        public Nullable<decimal> Price_Amount7 { get; set; }
        public string Price_Comp8 { get; set; }
        public Nullable<decimal> Price_Rate8 { get; set; }
        public Nullable<decimal> Price_Amount8 { get; set; }
        public string Price_Comp9 { get; set; }
        public Nullable<decimal> Price_Rate9 { get; set; }
        public Nullable<decimal> Price_Amount9 { get; set; }
        public string Price_Comp10 { get; set; }
        public Nullable<decimal> Price_Rate10 { get; set; }
        public Nullable<decimal> Price_Amount10 { get; set; }
        public decimal Item_Basic_Price { get; set; }
        public string Tax_group { get; set; }
        public Nullable<decimal> TAX1_Base_Amt { get; set; }
        public string TAX1 { get; set; }
        public Nullable<decimal> TAX1_Rate { get; set; }
        public Nullable<decimal> TAX1_Amt { get; set; }
        public Nullable<decimal> TAX2_Base_Amt { get; set; }
        public string TAX2 { get; set; }
        public Nullable<decimal> TAX2_Rate { get; set; }
        public Nullable<decimal> TAX2_Amt { get; set; }
        public Nullable<decimal> TAX3_Base_Amt { get; set; }
        public string TAX3 { get; set; }
        public Nullable<decimal> TAX3_Rate { get; set; }
        public Nullable<decimal> TAX3_Amt { get; set; }
        public Nullable<decimal> TAX4_Base_Amt { get; set; }
        public string TAX4 { get; set; }
        public Nullable<decimal> TAX4_Rate { get; set; }
        public Nullable<decimal> TAX4_Amt { get; set; }
        public Nullable<decimal> TAX5_Base_Amt { get; set; }
        public string TAX5 { get; set; }
        public Nullable<decimal> TAX5_Rate { get; set; }
        public Nullable<decimal> TAX5_Amt { get; set; }
        public Nullable<decimal> TAX6_Base_Amt { get; set; }
        public string TAX6 { get; set; }
        public Nullable<decimal> TAX6_Rate { get; set; }
        public Nullable<decimal> TAX6_Amt { get; set; }
        public Nullable<decimal> TAX7_Base_Amt { get; set; }
        public string TAX7 { get; set; }
        public Nullable<decimal> TAX7_Rate { get; set; }
        public Nullable<decimal> TAX7_Amt { get; set; }
        public Nullable<decimal> TAX8_Base_Amt { get; set; }
        public string TAX8 { get; set; }
        public Nullable<decimal> TAX8_Rate { get; set; }
        public Nullable<decimal> TAX8_Amt { get; set; }
        public Nullable<decimal> TAX9_Base_Amt { get; set; }
        public string TAX9 { get; set; }
        public Nullable<decimal> TAX9_Rate { get; set; }
        public Nullable<decimal> TAX9_Amt { get; set; }
        public Nullable<decimal> TAX10_Base_Amt { get; set; }
        public string TAX10 { get; set; }
        public Nullable<decimal> TAX10_Rate { get; set; }
        public Nullable<decimal> TAX10_Amt { get; set; }
        public Nullable<decimal> Total_Tax_Amt { get; set; }
        public Nullable<decimal> Item_Selling_Price { get; set; }
        public string Against_Item_Wise_Tax_Rate { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ITEM_PRICE_MASTER> TSPL_ITEM_PRICE_MASTER { get; set; }
        public virtual TSPL_ITEM_WISE_TAX TSPL_ITEM_WISE_TAX { get; set; }
        public virtual TSPL_ITEM_PRICE_PLAN_HEADER TSPL_ITEM_PRICE_PLAN_HEADER { get; set; }
    }
}