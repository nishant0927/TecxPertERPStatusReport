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
    
    public partial class TSPL_COST_CENTRE_FINANCIAL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_COST_CENTRE_FINANCIAL()
        {
            this.TSPL_COST_CENTRE_FINANCIAL1 = new HashSet<TSPL_COST_CENTRE_FINANCIAL>();
            this.TSPL_COST_CENTRE_HIRERACHY_DETAIL = new HashSet<TSPL_COST_CENTRE_HIRERACHY_DETAIL>();
            this.TSPL_IssueItemToAssembledAsset_Head = new HashSet<TSPL_IssueItemToAssembledAsset_Head>();
            this.TSPL_IssueReturn_DETAIL = new HashSet<TSPL_IssueReturn_DETAIL>();
            this.TSPL_IssueReturn_DETAIL1 = new HashSet<TSPL_IssueReturn_DETAIL>();
            this.TSPL_IssueReturn_DETAIL2 = new HashSet<TSPL_IssueReturn_DETAIL>();
            this.TSPL_JOURNAL_DETAILS = new HashSet<TSPL_JOURNAL_DETAILS>();
            this.TSPL_JOURNAL_Details_History = new HashSet<TSPL_JOURNAL_Details_History>();
            this.TSPL_JOURNAL_DETAILS_SYNC = new HashSet<TSPL_JOURNAL_DETAILS_SYNC>();
            this.TSPL_JOURNAL_DETAILS1 = new HashSet<TSPL_JOURNAL_DETAILS>();
            this.TSPL_JOURNAL_DETAILS2 = new HashSet<TSPL_JOURNAL_DETAILS>();
            this.TSPL_JOURNAL_DETAILS_SYNC1 = new HashSet<TSPL_JOURNAL_DETAILS_SYNC>();
            this.TSPL_JOURNAL_DETAILS_SYNC2 = new HashSet<TSPL_JOURNAL_DETAILS_SYNC>();
            this.TSPL_MP_PAY_DETAIL = new HashSet<TSPL_MP_PAY_DETAIL>();
            this.TSPL_PAYMENT_DETAIL = new HashSet<TSPL_PAYMENT_DETAIL>();
            this.TSPL_RECEIPT_DETAIL = new HashSet<TSPL_RECEIPT_DETAIL>();
            this.TSPL_RECEIPT_DETAIL_REFUND = new HashSet<TSPL_RECEIPT_DETAIL_REFUND>();
            this.TSPL_REQUISITION_DETAIL = new HashSet<TSPL_REQUISITION_DETAIL>();
            this.TSPL_REQUISITION_DETAIL1 = new HashSet<TSPL_REQUISITION_DETAIL>();
            this.TSPL_REQUISITION_DETAIL2 = new HashSet<TSPL_REQUISITION_DETAIL>();
            this.TSPL_VENDOR_INVOICE_DETAIL = new HashSet<TSPL_VENDOR_INVOICE_DETAIL>();
            this.TSPL_VENDOR_INVOICE_HEAD = new HashSet<TSPL_VENDOR_INVOICE_HEAD>();
            this.TSPL_VENDOR_INVOICE_DETAIL1 = new HashSet<TSPL_VENDOR_INVOICE_DETAIL>();
            this.TSPL_VENDOR_INVOICE_DETAIL2 = new HashSet<TSPL_VENDOR_INVOICE_DETAIL>();
            this.TSPL_VENDOR_INVOICE_DETAIL3 = new HashSet<TSPL_VENDOR_INVOICE_DETAIL>();
            this.TSPL_VENDOR_INVOICE_DETAIL4 = new HashSet<TSPL_VENDOR_INVOICE_DETAIL>();
            this.TSPL_WORK_ESTIMATION_DETAIL = new HashSet<TSPL_WORK_ESTIMATION_DETAIL>();
            this.TSPL_WORK_ESTIMATION_DETAIL1 = new HashSet<TSPL_WORK_ESTIMATION_DETAIL>();
            this.TSPL_WORK_ESTIMATION_DETAIL2 = new HashSet<TSPL_WORK_ESTIMATION_DETAIL>();
        }
    
        public string Cost_Center_Fin_Code { get; set; }
        public string Cost_Center_Fin_Name { get; set; }
        public string Cost_Center_Group { get; set; }
        public string Comp_Code { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string Hirerachy_Level_Code { get; set; }
        public string Cost_Centre_Fin_Level_Code { get; set; }
        public string Hirerachy_Level { get; set; }
    
        public virtual TSPL_COST_CENTRE_GROUP_MASTER TSPL_COST_CENTRE_GROUP_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_COST_CENTRE_FINANCIAL> TSPL_COST_CENTRE_FINANCIAL1 { get; set; }
        public virtual TSPL_COST_CENTRE_FINANCIAL TSPL_COST_CENTRE_FINANCIAL2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_COST_CENTRE_HIRERACHY_DETAIL> TSPL_COST_CENTRE_HIRERACHY_DETAIL { get; set; }
        public virtual TSPL_HIRERACHY_LEVEL_MASTER TSPL_HIRERACHY_LEVEL_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_IssueItemToAssembledAsset_Head> TSPL_IssueItemToAssembledAsset_Head { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_IssueReturn_DETAIL> TSPL_IssueReturn_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_IssueReturn_DETAIL> TSPL_IssueReturn_DETAIL1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_IssueReturn_DETAIL> TSPL_IssueReturn_DETAIL2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_JOURNAL_DETAILS> TSPL_JOURNAL_DETAILS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_JOURNAL_Details_History> TSPL_JOURNAL_Details_History { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_JOURNAL_DETAILS_SYNC> TSPL_JOURNAL_DETAILS_SYNC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_JOURNAL_DETAILS> TSPL_JOURNAL_DETAILS1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_JOURNAL_DETAILS> TSPL_JOURNAL_DETAILS2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_JOURNAL_DETAILS_SYNC> TSPL_JOURNAL_DETAILS_SYNC1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_JOURNAL_DETAILS_SYNC> TSPL_JOURNAL_DETAILS_SYNC2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MP_PAY_DETAIL> TSPL_MP_PAY_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PAYMENT_DETAIL> TSPL_PAYMENT_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_RECEIPT_DETAIL> TSPL_RECEIPT_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_RECEIPT_DETAIL_REFUND> TSPL_RECEIPT_DETAIL_REFUND { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_REQUISITION_DETAIL> TSPL_REQUISITION_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_REQUISITION_DETAIL> TSPL_REQUISITION_DETAIL1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_REQUISITION_DETAIL> TSPL_REQUISITION_DETAIL2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_VENDOR_INVOICE_DETAIL> TSPL_VENDOR_INVOICE_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_VENDOR_INVOICE_HEAD> TSPL_VENDOR_INVOICE_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_VENDOR_INVOICE_DETAIL> TSPL_VENDOR_INVOICE_DETAIL1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_VENDOR_INVOICE_DETAIL> TSPL_VENDOR_INVOICE_DETAIL2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_VENDOR_INVOICE_DETAIL> TSPL_VENDOR_INVOICE_DETAIL3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_VENDOR_INVOICE_DETAIL> TSPL_VENDOR_INVOICE_DETAIL4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_WORK_ESTIMATION_DETAIL> TSPL_WORK_ESTIMATION_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_WORK_ESTIMATION_DETAIL> TSPL_WORK_ESTIMATION_DETAIL1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_WORK_ESTIMATION_DETAIL> TSPL_WORK_ESTIMATION_DETAIL2 { get; set; }
    }
}
