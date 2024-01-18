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
    
    public partial class TSPL_ITEM_WISE_TAX
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_ITEM_WISE_TAX()
        {
            this.TSPL_ITEM_PRICE_MASTER = new HashSet<TSPL_ITEM_PRICE_MASTER>();
            this.TSPL_ITEM_PRICE_PLAN_DETAIL = new HashSet<TSPL_ITEM_PRICE_PLAN_DETAIL>();
            this.TSPL_GRN_DETAIL = new HashSet<TSPL_GRN_DETAIL>();
            this.TSPL_ITEM_WISE_TAX_AUTHORITY = new HashSet<TSPL_ITEM_WISE_TAX_AUTHORITY>();
            this.TSPL_ITEM_WISE_TAX_GROUP = new HashSet<TSPL_ITEM_WISE_TAX_GROUP>();
            this.TSPL_MRN_DETAIL = new HashSet<TSPL_MRN_DETAIL>();
            this.TSPL_PI_DETAIL = new HashSet<TSPL_PI_DETAIL>();
            this.TSPL_PR_DETAIL = new HashSet<TSPL_PR_DETAIL>();
            this.TSPL_PURCHASE_ORDER_DETAIL = new HashSet<TSPL_PURCHASE_ORDER_DETAIL>();
            this.TSPL_SRN_DETAIL = new HashSet<TSPL_SRN_DETAIL>();
        }
    
        public string HCODE { get; set; }
        public System.DateTime DOC_DATE { get; set; }
        public string Type { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modify_By { get; set; }
        public System.DateTime Modify_Date { get; set; }
        public string Posted_By { get; set; }
        public Nullable<System.DateTime> Posted_Date { get; set; }
        public string Comp_code { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ITEM_PRICE_MASTER> TSPL_ITEM_PRICE_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ITEM_PRICE_PLAN_DETAIL> TSPL_ITEM_PRICE_PLAN_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_GRN_DETAIL> TSPL_GRN_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ITEM_WISE_TAX_AUTHORITY> TSPL_ITEM_WISE_TAX_AUTHORITY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ITEM_WISE_TAX_GROUP> TSPL_ITEM_WISE_TAX_GROUP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MRN_DETAIL> TSPL_MRN_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PI_DETAIL> TSPL_PI_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PR_DETAIL> TSPL_PR_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PURCHASE_ORDER_DETAIL> TSPL_PURCHASE_ORDER_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SRN_DETAIL> TSPL_SRN_DETAIL { get; set; }
    }
}