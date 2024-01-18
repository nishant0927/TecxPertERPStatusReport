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
    
    public partial class TSPL_STRUCTURE_MASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_STRUCTURE_MASTER()
        {
            this.TSPL_CUSTOMER_INCENTIVE_INVOICE_WISE = new HashSet<TSPL_CUSTOMER_INCENTIVE_INVOICE_WISE>();
            this.TSPL_CUSTOMER_INCENTIVE_ITEM_CUSTOMER_WISE = new HashSet<TSPL_CUSTOMER_INCENTIVE_ITEM_CUSTOMER_WISE>();
            this.TSPL_CUSTOMER_INCENTIVE_STRUCTURE_CUSTOMER_WISE = new HashSet<TSPL_CUSTOMER_INCENTIVE_STRUCTURE_CUSTOMER_WISE>();
            this.TSPL_JW_ESTIMATE_HEAD = new HashSet<TSPL_JW_ESTIMATE_HEAD>();
            this.TSPL_JW_FORMULA = new HashSet<TSPL_JW_FORMULA>();
            this.TSPL_JWI_ESTIMATION_HEAD = new HashSet<TSPL_JWI_ESTIMATION_HEAD>();
            this.TSPL_JWI_ESTIMATION_HEAD1 = new HashSet<TSPL_JWI_ESTIMATION_HEAD>();
            this.TSPL_JWO_ESTIMATION_HEAD = new HashSet<TSPL_JWO_ESTIMATION_HEAD>();
            this.TSPL_JWO_ESTIMATION_HEAD1 = new HashSet<TSPL_JWO_ESTIMATION_HEAD>();
            this.TSPL_JWO_FORMULA = new HashSet<TSPL_JWO_FORMULA>();
            this.TSPL_SALES_INCENTIVE_ITEM_STRUCTURE_MAPPING = new HashSet<TSPL_SALES_INCENTIVE_ITEM_STRUCTURE_MAPPING>();
            this.TSPL_SCHEME_MASTER_NEW = new HashSet<TSPL_SCHEME_MASTER_NEW>();
            this.TSPL_SCHEME_MASTER_NEW1 = new HashSet<TSPL_SCHEME_MASTER_NEW>();
        }
    
        public string Structure_Code { get; set; }
        public string Structure_Descq { get; set; }
        public string Item_Structure { get; set; }
        public Nullable<int> Total_Length { get; set; }
        public string Default_Struct { get; set; }
        public string Created_By { get; set; }
        public string Create_Date { get; set; }
        public string Modify_By { get; set; }
        public string Modify_Date { get; set; }
        public string Comp_Code { get; set; }
        public string Structure_Group_Code { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CUSTOMER_INCENTIVE_INVOICE_WISE> TSPL_CUSTOMER_INCENTIVE_INVOICE_WISE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CUSTOMER_INCENTIVE_ITEM_CUSTOMER_WISE> TSPL_CUSTOMER_INCENTIVE_ITEM_CUSTOMER_WISE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CUSTOMER_INCENTIVE_STRUCTURE_CUSTOMER_WISE> TSPL_CUSTOMER_INCENTIVE_STRUCTURE_CUSTOMER_WISE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_JW_ESTIMATE_HEAD> TSPL_JW_ESTIMATE_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_JW_FORMULA> TSPL_JW_FORMULA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_JWI_ESTIMATION_HEAD> TSPL_JWI_ESTIMATION_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_JWI_ESTIMATION_HEAD> TSPL_JWI_ESTIMATION_HEAD1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_JWO_ESTIMATION_HEAD> TSPL_JWO_ESTIMATION_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_JWO_ESTIMATION_HEAD> TSPL_JWO_ESTIMATION_HEAD1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_JWO_FORMULA> TSPL_JWO_FORMULA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SALES_INCENTIVE_ITEM_STRUCTURE_MAPPING> TSPL_SALES_INCENTIVE_ITEM_STRUCTURE_MAPPING { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SCHEME_MASTER_NEW> TSPL_SCHEME_MASTER_NEW { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SCHEME_MASTER_NEW> TSPL_SCHEME_MASTER_NEW1 { get; set; }
    }
}
