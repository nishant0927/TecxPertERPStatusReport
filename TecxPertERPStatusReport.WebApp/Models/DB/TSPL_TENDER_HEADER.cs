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
    
    public partial class TSPL_TENDER_HEADER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_TENDER_HEADER()
        {
            this.TSPL_SRN_TENDER = new HashSet<TSPL_SRN_TENDER>();
            this.TSPL_TENDER_DETAIL = new HashSet<TSPL_TENDER_DETAIL>();
            this.TSPL_TENDER_SCHEDULE = new HashSet<TSPL_TENDER_SCHEDULE>();
            this.TSPL_TENDER_SCHEDULE_PENALTY = new HashSet<TSPL_TENDER_SCHEDULE_PENALTY>();
            this.TSPL_TENDER_SHORT_PENALTY = new HashSet<TSPL_TENDER_SHORT_PENALTY>();
            this.TSPL_TENDER_PENALTY = new HashSet<TSPL_TENDER_PENALTY>();
        }
    
        public string DocumentCode { get; set; }
        public System.DateTime DocumentDate { get; set; }
        public int TendorSeqNo { get; set; }
        public decimal DocumentAmount { get; set; }
        public string FieldValue1 { get; set; }
        public string FieldValue2 { get; set; }
        public string FieldValue3 { get; set; }
        public string FieldValue4 { get; set; }
        public string FieldValue5 { get; set; }
        public string FieldValue6 { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public int Posted { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string Posted_By { get; set; }
        public string OtherInfo1 { get; set; }
        public string OtherInfo2 { get; set; }
        public string OtherInfo3 { get; set; }
        public string OtherInfo4 { get; set; }
        public string OtherInfo5 { get; set; }
        public string OtherInfo6 { get; set; }
        public string OtherInfo7 { get; set; }
        public string OtherInfo8 { get; set; }
        public string OtherInfo9 { get; set; }
        public string OtherInfo10 { get; set; }
        public string Comp_code { get; set; }
        public Nullable<int> Tender_Type { get; set; }
        public Nullable<int> Mode { get; set; }
        public string close_yn { get; set; }
        public string Closed_By { get; set; }
        public Nullable<System.DateTime> Closed_Date { get; set; }
        public string close_remarks { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SRN_TENDER> TSPL_SRN_TENDER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_TENDER_DETAIL> TSPL_TENDER_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_TENDER_SCHEDULE> TSPL_TENDER_SCHEDULE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_TENDER_SCHEDULE_PENALTY> TSPL_TENDER_SCHEDULE_PENALTY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_TENDER_SHORT_PENALTY> TSPL_TENDER_SHORT_PENALTY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_TENDER_PENALTY> TSPL_TENDER_PENALTY { get; set; }
    }
}
