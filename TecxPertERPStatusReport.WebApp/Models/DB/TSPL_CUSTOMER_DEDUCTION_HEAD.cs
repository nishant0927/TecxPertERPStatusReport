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
    
    public partial class TSPL_CUSTOMER_DEDUCTION_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_CUSTOMER_DEDUCTION_HEAD()
        {
            this.TSPL_CUSTOMER_DEDUCTION_CUSTOMER = new HashSet<TSPL_CUSTOMER_DEDUCTION_CUSTOMER>();
            this.TSPL_CUSTOMER_INCENTIVE_DETAIL = new HashSet<TSPL_CUSTOMER_INCENTIVE_DETAIL>();
        }
    
        public string Deduction_Code { get; set; }
        public System.DateTime Deduction_Valid_Till { get; set; }
        public string Deduction_Name { get; set; }
        public Nullable<decimal> Deduction_Amount { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_Date { get; set; }
        public string Posted_By { get; set; }
        public Nullable<System.DateTime> Posted_Date { get; set; }
        public int Posted { get; set; }
        public int Inactive_Status { get; set; }
        public string Inactive_By { get; set; }
        public Nullable<System.DateTime> Inactive_Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CUSTOMER_DEDUCTION_CUSTOMER> TSPL_CUSTOMER_DEDUCTION_CUSTOMER { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CUSTOMER_INCENTIVE_DETAIL> TSPL_CUSTOMER_INCENTIVE_DETAIL { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER1 { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER2 { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER3 { get; set; }
    }
}