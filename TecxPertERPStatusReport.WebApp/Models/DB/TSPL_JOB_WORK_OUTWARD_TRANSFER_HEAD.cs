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
    
    public partial class TSPL_JOB_WORK_OUTWARD_TRANSFER_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_JOB_WORK_OUTWARD_TRANSFER_HEAD()
        {
            this.TSPL_JOB_WORK_OUTWARD_TRANSFER_RETURN = new HashSet<TSPL_JOB_WORK_OUTWARD_TRANSFER_RETURN>();
            this.TSPL_JOB_WORK_OUTWARD_TRANSFER_DETAILS = new HashSet<TSPL_JOB_WORK_OUTWARD_TRANSFER_DETAILS>();
            this.TSPL_JWO_GATE_ENTRY = new HashSet<TSPL_JWO_GATE_ENTRY>();
        }
    
        public string TRANSFER_NO { get; set; }
        public System.DateTime TRANSFER_DATE { get; set; }
        public string From_Locaction { get; set; }
        public string To_Locaction { get; set; }
        public string Vendor_Code { get; set; }
        public string Remarks { get; set; }
        public int Status { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modify_By { get; set; }
        public System.DateTime Modify_Date { get; set; }
        public string Comp_code { get; set; }
        public string Vehicle_Code { get; set; }
        public string Vehicle_No { get; set; }
        public string Posted_By { get; set; }
        public Nullable<System.DateTime> Post_Date { get; set; }
        public string AgainstSRN_No { get; set; }
        public string Tax_Group { get; set; }
        public int Tax_Calculation_Type { get; set; }
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
        public Nullable<decimal> Total_Amount { get; set; }
        public Nullable<decimal> Total_Tax_Amount { get; set; }
        public Nullable<decimal> Total_Net_Amount { get; set; }
        public string Loading_Advice_No { get; set; }
        public string Entry_Bill_No { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_JOB_WORK_OUTWARD_TRANSFER_RETURN> TSPL_JOB_WORK_OUTWARD_TRANSFER_RETURN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_JOB_WORK_OUTWARD_TRANSFER_DETAILS> TSPL_JOB_WORK_OUTWARD_TRANSFER_DETAILS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_JWO_GATE_ENTRY> TSPL_JWO_GATE_ENTRY { get; set; }
    }
}
