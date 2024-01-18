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
    
    public partial class TSPL_MF_MANUFACTURING_ORDER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_MF_MANUFACTURING_ORDER()
        {
            this.TSPL_MF_ISSUE_DETAIL = new HashSet<TSPL_MF_ISSUE_DETAIL>();
            this.TSPL_MF_MO_MATERIAL = new HashSet<TSPL_MF_MO_MATERIAL>();
            this.TSPL_MF_MO_OPERATIONS = new HashSet<TSPL_MF_MO_OPERATIONS>();
            this.TSPL_MF_MO_RESOURCES = new HashSet<TSPL_MF_MO_RESOURCES>();
            this.TSPL_MF_MO_TOOLTYPES = new HashSet<TSPL_MF_MO_TOOLTYPES>();
            this.TSPL_MF_MO_COSTING = new HashSet<TSPL_MF_MO_COSTING>();
            this.TSPL_MF_MANUFACTURING_ORDER1 = new HashSet<TSPL_MF_MANUFACTURING_ORDER>();
            this.TSPL_MF_REQ_DETAIL = new HashSet<TSPL_MF_REQ_DETAIL>();
            this.TSPL_MF_RECEIPT = new HashSet<TSPL_MF_RECEIPT>();
        }
    
        public string MO_CODE { get; set; }
        public string MO_STATUS { get; set; }
        public string ITEM_CODE { get; set; }
        public decimal QTY_ORDERED { get; set; }
        public string UNIT_CODE { get; set; }
        public decimal QTY_ORDERED_STOCK { get; set; }
        public string UNIT_CODE_STOCK { get; set; }
        public string MO_REFERENCE { get; set; }
        public string DESCRIPTION { get; set; }
        public string BOM_CODE { get; set; }
        public string BOM_REVISION_NO { get; set; }
        public System.DateTime MO_DATE { get; set; }
        public Nullable<System.DateTime> MO_DUE_DATE { get; set; }
        public string PRODUCTION_AREA { get; set; }
        public string PLANNER { get; set; }
        public string IN_CHARGE { get; set; }
        public Nullable<System.DateTime> PLANNED_START_DATE { get; set; }
        public Nullable<System.DateTime> PLANNED_END_DATE { get; set; }
        public Nullable<System.DateTime> ACTUAL_START_DATE { get; set; }
        public Nullable<System.DateTime> ACTUAL_END_DATE { get; set; }
        public bool POSTED { get; set; }
        public Nullable<System.DateTime> POSTING_DATE { get; set; }
        public string APPROVED_BY { get; set; }
        public string RELEASED_BY { get; set; }
        public string CLOSED_BY { get; set; }
        public Nullable<System.DateTime> APPROVED_DATE { get; set; }
        public Nullable<System.DateTime> RELEASED_DATE_DATE { get; set; }
        public Nullable<System.DateTime> CLOSED_DATE { get; set; }
        public string COMMENTS { get; set; }
        public byte[] ATTACHED_DOC { get; set; }
        public string ATTACHED_DOC_PATH { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string comp_code { get; set; }
        public string LOCATION_CODE { get; set; }
        public string SOURCE_DOC_TYPE { get; set; }
        public string PROD_PLAN_CODE { get; set; }
        public string SO_CODE { get; set; }
        public string PARENT_MO_CODE { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_MF_BOM_HEAD TSPL_MF_BOM_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MF_ISSUE_DETAIL> TSPL_MF_ISSUE_DETAIL { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER1 { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MF_MO_MATERIAL> TSPL_MF_MO_MATERIAL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MF_MO_OPERATIONS> TSPL_MF_MO_OPERATIONS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MF_MO_RESOURCES> TSPL_MF_MO_RESOURCES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MF_MO_TOOLTYPES> TSPL_MF_MO_TOOLTYPES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MF_MO_COSTING> TSPL_MF_MO_COSTING { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MF_MANUFACTURING_ORDER> TSPL_MF_MANUFACTURING_ORDER1 { get; set; }
        public virtual TSPL_MF_MANUFACTURING_ORDER TSPL_MF_MANUFACTURING_ORDER2 { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER3 { get; set; }
        public virtual TSPL_MF_PRODUCTION_PLAN_HEAD TSPL_MF_PRODUCTION_PLAN_HEAD { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER4 { get; set; }
        public virtual TSPL_SD_SALES_ORDER_HEAD TSPL_SD_SALES_ORDER_HEAD { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MF_REQ_DETAIL> TSPL_MF_REQ_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MF_RECEIPT> TSPL_MF_RECEIPT { get; set; }
    }
}