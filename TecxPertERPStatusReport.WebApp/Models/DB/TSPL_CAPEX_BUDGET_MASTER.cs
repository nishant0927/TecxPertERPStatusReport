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
    
    public partial class TSPL_CAPEX_BUDGET_MASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_CAPEX_BUDGET_MASTER()
        {
            this.TSPL_ASSET_WORK_HEAD = new HashSet<TSPL_ASSET_WORK_HEAD>();
            this.TSPL_ACQUISITION_DETAIL = new HashSet<TSPL_ACQUISITION_DETAIL>();
            this.TSPL_GRN_DETAIL = new HashSet<TSPL_GRN_DETAIL>();
            this.TSPL_GRN_DETAIL_HISTORY = new HashSet<TSPL_GRN_DETAIL_HISTORY>();
            this.TSPL_IssueItemToAssembledAsset_Detail = new HashSet<TSPL_IssueItemToAssembledAsset_Detail>();
            this.TSPL_IssueReturn_HEAD = new HashSet<TSPL_IssueReturn_HEAD>();
            this.TSPL_MRN_DETAIL = new HashSet<TSPL_MRN_DETAIL>();
            this.TSPL_MRN_DETAIL_HISTORY = new HashSet<TSPL_MRN_DETAIL_HISTORY>();
            this.TSPL_PI_DETAIL = new HashSet<TSPL_PI_DETAIL>();
            this.TSPL_PR_DETAIL = new HashSet<TSPL_PR_DETAIL>();
            this.TSPL_PURCHASE_ORDER_HEAD = new HashSet<TSPL_PURCHASE_ORDER_HEAD>();
            this.TSPL_PURCHASE_ORDER_HEAD_Hist_New = new HashSet<TSPL_PURCHASE_ORDER_HEAD_Hist_New>();
            this.TSPL_REQUISITION_HEAD = new HashSet<TSPL_REQUISITION_HEAD>();
            this.TSPL_SRN_DETAIL = new HashSet<TSPL_SRN_DETAIL>();
            this.TSPL_SRN_DETAIL_HISTORY = new HashSet<TSPL_SRN_DETAIL_HISTORY>();
            this.TSPL_WORK_ESTIMATION_HEAD = new HashSet<TSPL_WORK_ESTIMATION_HEAD>();
        }
    
        public string CODE { get; set; }
        public string DESCRIPTION { get; set; }
        public string Capex_Code { get; set; }
        public Nullable<double> Budget { get; set; }
        public Nullable<double> Revised_Budget { get; set; }
        public Nullable<double> Tolerence { get; set; }
        public System.DateTime Doc_Date { get; set; }
        public string Revision_No { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public Nullable<double> Inc_Budget { get; set; }
        public Nullable<double> Current_Budget { get; set; }
        public Nullable<int> Provisional { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ASSET_WORK_HEAD> TSPL_ASSET_WORK_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ACQUISITION_DETAIL> TSPL_ACQUISITION_DETAIL { get; set; }
        public virtual TSPL_CAPEX_MASTER TSPL_CAPEX_MASTER { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_GRN_DETAIL> TSPL_GRN_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_GRN_DETAIL_HISTORY> TSPL_GRN_DETAIL_HISTORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_IssueItemToAssembledAsset_Detail> TSPL_IssueItemToAssembledAsset_Detail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_IssueReturn_HEAD> TSPL_IssueReturn_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MRN_DETAIL> TSPL_MRN_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MRN_DETAIL_HISTORY> TSPL_MRN_DETAIL_HISTORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PI_DETAIL> TSPL_PI_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PR_DETAIL> TSPL_PR_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PURCHASE_ORDER_HEAD> TSPL_PURCHASE_ORDER_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PURCHASE_ORDER_HEAD_Hist_New> TSPL_PURCHASE_ORDER_HEAD_Hist_New { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_REQUISITION_HEAD> TSPL_REQUISITION_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SRN_DETAIL> TSPL_SRN_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SRN_DETAIL_HISTORY> TSPL_SRN_DETAIL_HISTORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_WORK_ESTIMATION_HEAD> TSPL_WORK_ESTIMATION_HEAD { get; set; }
    }
}
