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
    
    public partial class TSPL_CAN_SALE_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_CAN_SALE_HEAD()
        {
            this.TSPL_CAN_SALE_DETAIL = new HashSet<TSPL_CAN_SALE_DETAIL>();
            this.TSPL_CANSALE_DISPATCH_HEAD = new HashSet<TSPL_CANSALE_DISPATCH_HEAD>();
            this.TSPL_CANSALE_INVOICE_HEAD = new HashSet<TSPL_CANSALE_INVOICE_HEAD>();
        }
    
        public string Document_No { get; set; }
        public System.DateTime Document_Date { get; set; }
        public string Customer_Code { get; set; }
        public string Customer_Name { get; set; }
        public string Location_Code { get; set; }
        public string Location_Name { get; set; }
        public string Price_Code { get; set; }
        public decimal Fat_Weightage { get; set; }
        public decimal Snf_Weightage { get; set; }
        public decimal Fat_Ratio { get; set; }
        public decimal Snf_Ratio { get; set; }
        public decimal Standard_Rate { get; set; }
        public double TolerancePerPlus { get; set; }
        public double TolerancePerMinus { get; set; }
        public double DocumentAmount { get; set; }
        public int Posted { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string Comp_Code { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public int CanInventoryType { get; set; }
        public int TotalNoofCans { get; set; }
        public string CanItemCode { get; set; }
        public double CanItemRate { get; set; }
        public string CanItemUOM { get; set; }
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
        public Nullable<decimal> Total_Tax_Amt { get; set; }
        public decimal Total_Amt { get; set; }
        public Nullable<double> ActualTCSBaseAmount { get; set; }
        public Nullable<double> ChangedTCSBaseAmount { get; set; }
    
        public virtual TSPL_BulkSalePrice_MASTER TSPL_BulkSalePrice_MASTER { get; set; }
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_CUSTOMER_MASTER TSPL_CUSTOMER_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CAN_SALE_DETAIL> TSPL_CAN_SALE_DETAIL { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CANSALE_DISPATCH_HEAD> TSPL_CANSALE_DISPATCH_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CANSALE_INVOICE_HEAD> TSPL_CANSALE_INVOICE_HEAD { get; set; }
    }
}
