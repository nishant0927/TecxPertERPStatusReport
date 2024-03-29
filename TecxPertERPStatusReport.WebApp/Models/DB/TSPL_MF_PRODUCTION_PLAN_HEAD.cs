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
    
    public partial class TSPL_MF_PRODUCTION_PLAN_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_MF_PRODUCTION_PLAN_HEAD()
        {
            this.TSPL_MF_MANUFACTURING_ORDER = new HashSet<TSPL_MF_MANUFACTURING_ORDER>();
            this.TSPL_MF_BATCH_PP_DETAIL = new HashSet<TSPL_MF_BATCH_PP_DETAIL>();
            this.TSPL_MF_BATCH_ORDER_DETAIL = new HashSet<TSPL_MF_BATCH_ORDER_DETAIL>();
            this.TSPL_MF_PROD_PLAN_DETAIL = new HashSet<TSPL_MF_PROD_PLAN_DETAIL>();
            this.TSPL_MF_RECEIPT_DETAIL = new HashSet<TSPL_MF_RECEIPT_DETAIL>();
            this.TSPL_MRP_HEAD = new HashSet<TSPL_MRP_HEAD>();
        }
    
        public string PROD_PLAN_CODE { get; set; }
        public string DESCRIPTION { get; set; }
        public string COMMENTS { get; set; }
        public System.DateTime PLANNING_DATE { get; set; }
        public string PLANNED_BY { get; set; }
        public bool POSTED { get; set; }
        public Nullable<System.DateTime> POSTING_DATE { get; set; }
        public string APPROVED_BY { get; set; }
        public System.DateTime PLAN_FOR_DATE { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string comp_code { get; set; }
        public Nullable<System.DateTime> PLAN_TO_DATE { get; set; }
        public string Location_Code { get; set; }
    
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MF_MANUFACTURING_ORDER> TSPL_MF_MANUFACTURING_ORDER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MF_BATCH_PP_DETAIL> TSPL_MF_BATCH_PP_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MF_BATCH_ORDER_DETAIL> TSPL_MF_BATCH_ORDER_DETAIL { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MF_PROD_PLAN_DETAIL> TSPL_MF_PROD_PLAN_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MF_RECEIPT_DETAIL> TSPL_MF_RECEIPT_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MRP_HEAD> TSPL_MRP_HEAD { get; set; }
    }
}
