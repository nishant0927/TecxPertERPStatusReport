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
    
    public partial class TSPL_CUSTOMER_INCENTIVE_ENTRY_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_CUSTOMER_INCENTIVE_ENTRY_HEAD()
        {
            this.TSPL_CUSTOMER_INCENTIVE_CUSTOMER_INCENTIVE_WISE = new HashSet<TSPL_CUSTOMER_INCENTIVE_CUSTOMER_INCENTIVE_WISE>();
            this.TSPL_CUSTOMER_INCENTIVE_DETAIL = new HashSet<TSPL_CUSTOMER_INCENTIVE_DETAIL>();
            this.TSPL_CUSTOMER_INCENTIVE_STRUCTURE_CUSTOMER_WISE = new HashSet<TSPL_CUSTOMER_INCENTIVE_STRUCTURE_CUSTOMER_WISE>();
            this.TSPL_CUSTOMER_INCENTIVE_ITEM_CUSTOMER_WISE = new HashSet<TSPL_CUSTOMER_INCENTIVE_ITEM_CUSTOMER_WISE>();
            this.TSPL_CUSTOMER_INCENTIVE_INVOICE_WISE = new HashSet<TSPL_CUSTOMER_INCENTIVE_INVOICE_WISE>();
        }
    
        public string Doc_Code { get; set; }
        public System.DateTime Doc_Date { get; set; }
        public string Location_Code { get; set; }
        public System.DateTime Filter_Month { get; set; }
        public Nullable<System.DateTime> Filter_Month_From { get; set; }
        public Nullable<System.DateTime> Filter_Month_To { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_Date { get; set; }
        public string Posted_By { get; set; }
        public Nullable<System.DateTime> Posted_Date { get; set; }
        public int Posted { get; set; }
        public Nullable<decimal> Additional_Security { get; set; }
        public Nullable<decimal> Security_Part { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CUSTOMER_INCENTIVE_CUSTOMER_INCENTIVE_WISE> TSPL_CUSTOMER_INCENTIVE_CUSTOMER_INCENTIVE_WISE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CUSTOMER_INCENTIVE_DETAIL> TSPL_CUSTOMER_INCENTIVE_DETAIL { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CUSTOMER_INCENTIVE_STRUCTURE_CUSTOMER_WISE> TSPL_CUSTOMER_INCENTIVE_STRUCTURE_CUSTOMER_WISE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CUSTOMER_INCENTIVE_ITEM_CUSTOMER_WISE> TSPL_CUSTOMER_INCENTIVE_ITEM_CUSTOMER_WISE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CUSTOMER_INCENTIVE_INVOICE_WISE> TSPL_CUSTOMER_INCENTIVE_INVOICE_WISE { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER1 { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER2 { get; set; }
    }
}
