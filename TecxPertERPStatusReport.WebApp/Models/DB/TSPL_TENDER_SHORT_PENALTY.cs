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
    
    public partial class TSPL_TENDER_SHORT_PENALTY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_TENDER_SHORT_PENALTY()
        {
            this.TSPL_TENDER_SHORT_PENALTY_DETAIL = new HashSet<TSPL_TENDER_SHORT_PENALTY_DETAIL>();
        }
    
        public string Document_No { get; set; }
        public System.DateTime Document_Date { get; set; }
        public string Location_Code { get; set; }
        public string Tender_No { get; set; }
        public string Vendor_Code { get; set; }
        public string Item_Code { get; set; }
        public Nullable<decimal> Short_Qty { get; set; }
        public Nullable<decimal> Short_Tolerance { get; set; }
        public Nullable<decimal> Penalty_Per { get; set; }
        public Nullable<decimal> Tender_Qty { get; set; }
        public Nullable<decimal> Tender_Rate { get; set; }
        public Nullable<decimal> Received_Qty { get; set; }
        public Nullable<decimal> Difference_Qty { get; set; }
        public string Remarks { get; set; }
        public Nullable<decimal> Amount { get; set; }
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
        public string TAX6 { get; set; }
        public Nullable<decimal> TAX6_Rate { get; set; }
        public Nullable<decimal> TAX6_Amt { get; set; }
        public Nullable<decimal> TAX6_Base_Amt { get; set; }
        public string TAX7 { get; set; }
        public Nullable<decimal> TAX7_Rate { get; set; }
        public Nullable<decimal> TAX7_Amt { get; set; }
        public Nullable<decimal> TAX7_Base_Amt { get; set; }
        public string TAX8 { get; set; }
        public Nullable<decimal> TAX8_Rate { get; set; }
        public Nullable<decimal> TAX8_Amt { get; set; }
        public Nullable<decimal> TAX8_Base_Amt { get; set; }
        public string TAX9 { get; set; }
        public Nullable<decimal> TAX9_Rate { get; set; }
        public Nullable<decimal> TAX9_Amt { get; set; }
        public Nullable<decimal> TAX9_Base_Amt { get; set; }
        public string TAX10 { get; set; }
        public Nullable<decimal> TAX10_Rate { get; set; }
        public Nullable<decimal> TAX10_Amt { get; set; }
        public Nullable<decimal> TAX10_Base_Amt { get; set; }
        public Nullable<decimal> Total_Tax_Amt { get; set; }
        public Nullable<decimal> Total_Amt { get; set; }
        public string CURRENCY_CODE { get; set; }
        public decimal ConvRate { get; set; }
        public Nullable<System.DateTime> ApplicableFrom { get; set; }
        public int Status { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modify_By { get; set; }
        public System.DateTime Modify_Date { get; set; }
        public string Post_By { get; set; }
        public Nullable<System.DateTime> Post_Date { get; set; }
    
        public virtual TSPL_CURRENCY_MASTER TSPL_CURRENCY_MASTER { get; set; }
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_TENDER_HEADER TSPL_TENDER_HEADER { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_TENDER_SHORT_PENALTY_DETAIL> TSPL_TENDER_SHORT_PENALTY_DETAIL { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER1 { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER2 { get; set; }
        public virtual TSPL_VENDOR_MASTER TSPL_VENDOR_MASTER { get; set; }
    }
}
