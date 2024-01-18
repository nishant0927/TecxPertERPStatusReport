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
    
    public partial class TSPL_SALES_INCENTIVE_HEADER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_SALES_INCENTIVE_HEADER()
        {
            this.TSPL_CUSTOMER_INCENTIVE_CUSTOMER_INCENTIVE_WISE = new HashSet<TSPL_CUSTOMER_INCENTIVE_CUSTOMER_INCENTIVE_WISE>();
            this.TSPL_CUSTOMER_INCENTIVE_STRUCTURE_CUSTOMER_WISE = new HashSet<TSPL_CUSTOMER_INCENTIVE_STRUCTURE_CUSTOMER_WISE>();
            this.TSPL_SALES_INCENTIVE_CUSTOMER_MAPPING = new HashSet<TSPL_SALES_INCENTIVE_CUSTOMER_MAPPING>();
            this.TSPL_SALES_INCENTIVE_SLAB = new HashSet<TSPL_SALES_INCENTIVE_SLAB>();
            this.TSPL_SALES_INCENTIVE_ITEM_STRUCTURE_MAPPING = new HashSet<TSPL_SALES_INCENTIVE_ITEM_STRUCTURE_MAPPING>();
        }
    
        public string INCENTIVE_CODE { get; set; }
        public System.DateTime INCENTIVE_DATE { get; set; }
        public string DESCRIPTION { get; set; }
        public System.DateTime FROM_DATE { get; set; }
        public System.DateTime TO_DATE { get; set; }
        public string RANGE_UOM { get; set; }
        public string INCENTIVE_UOM { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public int Status { get; set; }
        public string Post_By { get; set; }
        public Nullable<System.DateTime> Post_Date { get; set; }
        public string Comp_Code { get; set; }
        public string GL_Code { get; set; }
        public int In_Active { get; set; }
        public string In_Active_By { get; set; }
        public Nullable<System.DateTime> In_Active_Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CUSTOMER_INCENTIVE_CUSTOMER_INCENTIVE_WISE> TSPL_CUSTOMER_INCENTIVE_CUSTOMER_INCENTIVE_WISE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CUSTOMER_INCENTIVE_STRUCTURE_CUSTOMER_WISE> TSPL_CUSTOMER_INCENTIVE_STRUCTURE_CUSTOMER_WISE { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SALES_INCENTIVE_CUSTOMER_MAPPING> TSPL_SALES_INCENTIVE_CUSTOMER_MAPPING { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER1 { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SALES_INCENTIVE_SLAB> TSPL_SALES_INCENTIVE_SLAB { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SALES_INCENTIVE_ITEM_STRUCTURE_MAPPING> TSPL_SALES_INCENTIVE_ITEM_STRUCTURE_MAPPING { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER2 { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER3 { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER1 { get; set; }
    }
}