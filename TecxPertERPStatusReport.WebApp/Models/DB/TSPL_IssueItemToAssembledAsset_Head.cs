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
    
    public partial class TSPL_IssueItemToAssembledAsset_Head
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_IssueItemToAssembledAsset_Head()
        {
            this.TSPL_IssueItemToAssembledAsset_Head1 = new HashSet<TSPL_IssueItemToAssembledAsset_Head>();
            this.TSPL_IssueItemToAssembledAsset_Detail = new HashSet<TSPL_IssueItemToAssembledAsset_Detail>();
        }
    
        public string Doc_No { get; set; }
        public System.DateTime Doc_Date { get; set; }
        public string Doc_Type { get; set; }
        public string Asset_Code { get; set; }
        public string From_Location { get; set; }
        public string Remarks { get; set; }
        public string Comment { get; set; }
        public string Issue_To { get; set; }
        public string Request_By { get; set; }
        public string comp_code { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modify_By { get; set; }
        public string Modify_Date { get; set; }
        public int Status { get; set; }
        public int On_Hold { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string Dept { get; set; }
        public string Dept_Desc { get; set; }
        public string Tax_Group { get; set; }
        public string Tax_Desc { get; set; }
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
        public Nullable<decimal> BeforeTax_Amt { get; set; }
        public Nullable<decimal> Total_Tax_Amt { get; set; }
        public Nullable<decimal> Doc_Amt { get; set; }
        public string Vehicle_Id { get; set; }
        public string Machine_Id { get; set; }
        public string Req_IssueNo { get; set; }
        public string RequisitionNo { get; set; }
        public string Asset_Type { get; set; }
        public string Against_Return_No { get; set; }
        public string H_Code { get; set; }
        public string CC_Code { get; set; }
    
        public virtual TSPL_COST_CENTRE_FINANCIAL TSPL_COST_CENTRE_FINANCIAL { get; set; }
        public virtual TSPL_HIRERACHY_LEVEL_MASTER TSPL_HIRERACHY_LEVEL_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_IssueItemToAssembledAsset_Head> TSPL_IssueItemToAssembledAsset_Head1 { get; set; }
        public virtual TSPL_IssueItemToAssembledAsset_Head TSPL_IssueItemToAssembledAsset_Head2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_IssueItemToAssembledAsset_Detail> TSPL_IssueItemToAssembledAsset_Detail { get; set; }
    }
}