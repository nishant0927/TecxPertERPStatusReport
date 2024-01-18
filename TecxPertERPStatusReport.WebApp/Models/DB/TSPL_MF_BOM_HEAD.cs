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
    
    public partial class TSPL_MF_BOM_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_MF_BOM_HEAD()
        {
            this.TSPL_CATALOG_MASTER = new HashSet<TSPL_CATALOG_MASTER>();
            this.TSPL_BOM_DETAIL_PP = new HashSet<TSPL_BOM_DETAIL_PP>();
            this.TSPL_MF_BOM_DETAIL = new HashSet<TSPL_MF_BOM_DETAIL>();
            this.TSPL_MF_BOM_OPERATIONS = new HashSet<TSPL_MF_BOM_OPERATIONS>();
            this.TSPL_MF_BOM_RESOURCES = new HashSet<TSPL_MF_BOM_RESOURCES>();
            this.TSPL_MF_BOM_TOOLTYPES = new HashSet<TSPL_MF_BOM_TOOLTYPES>();
            this.TSPL_MF_BOM_COSTING = new HashSet<TSPL_MF_BOM_COSTING>();
            this.TSPL_MF_BATCH_PP_DETAIL = new HashSet<TSPL_MF_BATCH_PP_DETAIL>();
            this.TSPL_MF_BATCH_ORDER_DETAIL = new HashSet<TSPL_MF_BATCH_ORDER_DETAIL>();
            this.TSPL_MF_ISSUE_DETAIL = new HashSet<TSPL_MF_ISSUE_DETAIL>();
            this.TSPL_MF_MANUFACTURING_ORDER = new HashSet<TSPL_MF_MANUFACTURING_ORDER>();
            this.TSPL_MF_MO_COSTING = new HashSet<TSPL_MF_MO_COSTING>();
            this.TSPL_MF_PROD_PLAN_DETAIL = new HashSet<TSPL_MF_PROD_PLAN_DETAIL>();
            this.TSPL_MF_REQ_DETAIL = new HashSet<TSPL_MF_REQ_DETAIL>();
            this.TSPL_MF_RETURN_DETAIL = new HashSet<TSPL_MF_RETURN_DETAIL>();
            this.TSPL_MF_RECEIPT_DETAIL = new HashSet<TSPL_MF_RECEIPT_DETAIL>();
            this.TSPL_MRP_HEAD = new HashSet<TSPL_MRP_HEAD>();
            this.TSPL_PJC_ASSEMBLIES = new HashSet<TSPL_PJC_ASSEMBLIES>();
            this.TSPL_PJC_ASSEMBLIES_ITEM_DETAIL = new HashSet<TSPL_PJC_ASSEMBLIES_ITEM_DETAIL>();
            this.TSPL_SPP_PRODUCTION_ENTRY_DETAIL = new HashSet<TSPL_SPP_PRODUCTION_ENTRY_DETAIL>();
        }
    
        public string BOM_CODE { get; set; }
        public string DESCRIPTION { get; set; }
        public System.DateTime BOM_DATE { get; set; }
        public string REVISION_NO { get; set; }
        public Nullable<System.DateTime> START_DATE { get; set; }
        public Nullable<System.DateTime> END_DATE { get; set; }
        public string STATUS { get; set; }
        public bool IS_DEFAULT { get; set; }
        public byte[] ATTACHED_DOC { get; set; }
        public string ATTACHED_DOC_PATH { get; set; }
        public string PROD_ITEM_CODE { get; set; }
        public decimal PROD_QUANTITY { get; set; }
        public string PROD_ITEM_UNIT_CODE { get; set; }
        public decimal MIN_BATCH_SIZE { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public bool POSTED { get; set; }
        public Nullable<System.DateTime> POSTING_DATE { get; set; }
        public string comp_code { get; set; }
        public string Trans_Type { get; set; }
        public Nullable<double> Processing_Charge { get; set; }
        public Nullable<double> Admin_Charge { get; set; }
        public string PROD_Drawing_No { get; set; }
        public string LOCATION_CODE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CATALOG_MASTER> TSPL_CATALOG_MASTER { get; set; }
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_BOM_DETAIL_PP> TSPL_BOM_DETAIL_PP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MF_BOM_DETAIL> TSPL_MF_BOM_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MF_BOM_OPERATIONS> TSPL_MF_BOM_OPERATIONS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MF_BOM_RESOURCES> TSPL_MF_BOM_RESOURCES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MF_BOM_TOOLTYPES> TSPL_MF_BOM_TOOLTYPES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MF_BOM_COSTING> TSPL_MF_BOM_COSTING { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MF_BATCH_PP_DETAIL> TSPL_MF_BATCH_PP_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MF_BATCH_ORDER_DETAIL> TSPL_MF_BATCH_ORDER_DETAIL { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MF_ISSUE_DETAIL> TSPL_MF_ISSUE_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MF_MANUFACTURING_ORDER> TSPL_MF_MANUFACTURING_ORDER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MF_MO_COSTING> TSPL_MF_MO_COSTING { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MF_PROD_PLAN_DETAIL> TSPL_MF_PROD_PLAN_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MF_REQ_DETAIL> TSPL_MF_REQ_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MF_RETURN_DETAIL> TSPL_MF_RETURN_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MF_RECEIPT_DETAIL> TSPL_MF_RECEIPT_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MRP_HEAD> TSPL_MRP_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PJC_ASSEMBLIES> TSPL_PJC_ASSEMBLIES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PJC_ASSEMBLIES_ITEM_DETAIL> TSPL_PJC_ASSEMBLIES_ITEM_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SPP_PRODUCTION_ENTRY_DETAIL> TSPL_SPP_PRODUCTION_ENTRY_DETAIL { get; set; }
    }
}