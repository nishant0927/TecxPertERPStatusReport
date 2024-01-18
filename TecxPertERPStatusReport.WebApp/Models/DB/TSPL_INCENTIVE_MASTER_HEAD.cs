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
    
    public partial class TSPL_INCENTIVE_MASTER_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_INCENTIVE_MASTER_HEAD()
        {
            this.TSPL_INCENTIVE_DETAIL = new HashSet<TSPL_INCENTIVE_DETAIL>();
            this.TSPL_INCENTIVE_ENTRY_BY_SRN_DETAIL = new HashSet<TSPL_INCENTIVE_ENTRY_BY_SRN_DETAIL>();
            this.TSPL_Milk_Purchase_Invoice_VSP_INCENTIVE_Detail = new HashSet<TSPL_Milk_Purchase_Invoice_VSP_INCENTIVE_Detail>();
            this.TSPL_MILK_PURCHASE_INVOICE_INCENTIVEDETAIL = new HashSet<TSPL_MILK_PURCHASE_INVOICE_INCENTIVEDETAIL>();
            this.TSPL_MILK_PURCHASE_INVOICE_PROVISON_INCENTIVEDETAIL = new HashSet<TSPL_MILK_PURCHASE_INVOICE_PROVISON_INCENTIVEDETAIL>();
            this.TSPL_VSP_INCENTIVE_Detail = new HashSet<TSPL_VSP_INCENTIVE_Detail>();
            this.TSPL_VSP_INCENTIVE_MULTI_DETAIL = new HashSet<TSPL_VSP_INCENTIVE_MULTI_DETAIL>();
        }
    
        public string INCENTIVE_CODE { get; set; }
        public string DESCRIPTION { get; set; }
        public System.DateTime INCENTIVE_DATE { get; set; }
        public Nullable<System.DateTime> START_DATE { get; set; }
        public Nullable<System.DateTime> END_DATE { get; set; }
        public string INCENTIVE_TYPE { get; set; }
        public string SCHEME_FOR { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string comp_code { get; set; }
        public string Calc_Type { get; set; }
        public string Rate_Type { get; set; }
        public string Starting_Shift { get; set; }
        public string Ending_Shift { get; set; }
        public string Qty_Type { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_INCENTIVE_DETAIL> TSPL_INCENTIVE_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_INCENTIVE_ENTRY_BY_SRN_DETAIL> TSPL_INCENTIVE_ENTRY_BY_SRN_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_Milk_Purchase_Invoice_VSP_INCENTIVE_Detail> TSPL_Milk_Purchase_Invoice_VSP_INCENTIVE_Detail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_PURCHASE_INVOICE_INCENTIVEDETAIL> TSPL_MILK_PURCHASE_INVOICE_INCENTIVEDETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_PURCHASE_INVOICE_PROVISON_INCENTIVEDETAIL> TSPL_MILK_PURCHASE_INVOICE_PROVISON_INCENTIVEDETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_VSP_INCENTIVE_Detail> TSPL_VSP_INCENTIVE_Detail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_VSP_INCENTIVE_MULTI_DETAIL> TSPL_VSP_INCENTIVE_MULTI_DETAIL { get; set; }
    }
}