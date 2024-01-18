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
    
    public partial class TSPL_MILK_PURCHASE_INVOICE_PROVISION_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_MILK_PURCHASE_INVOICE_PROVISION_HEAD()
        {
            this.TSPL_MILK_PURCHASE_INVOICE_PROVISION_DETAIL = new HashSet<TSPL_MILK_PURCHASE_INVOICE_PROVISION_DETAIL>();
            this.TSPL_MILK_PURCHASE_INVOICE_PROVISON_INCENTIVEDETAIL = new HashSet<TSPL_MILK_PURCHASE_INVOICE_PROVISON_INCENTIVEDETAIL>();
        }
    
        public string DOC_CODE { get; set; }
        public string MCC_CODE { get; set; }
        public string Irregular_MCC_CODE { get; set; }
        public System.DateTime DOC_DATE { get; set; }
        public string VENDOR_INVOICE_NO { get; set; }
        public Nullable<System.DateTime> VENDOR_INVOICE_DATE { get; set; }
        public string ROUTE_CODE { get; set; }
        public string Description { get; set; }
        public string Payment { get; set; }
        public string VSP_CODE { get; set; }
        public decimal TOTAL_AMOUNT { get; set; }
        public decimal TOTAL_COMMISSION { get; set; }
        public decimal TOTAL_AMOUNT_Acc { get; set; }
        public decimal TOTAL_PaymentCOMMISSION { get; set; }
        public decimal Posted { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string Comp_Code { get; set; }
        public decimal Incentive_Head { get; set; }
        public decimal IncentiveEMP_Head { get; set; }
        public decimal Total_Head_Load_AMOUNT { get; set; }
        public decimal Total_Own_Asset_AMOUNT { get; set; }
        public decimal Total_dEDUCTION_AMOUNT { get; set; }
        public decimal Total_Basic_AMOUNT { get; set; }
        public Nullable<decimal> MP_Amount { get; set; }
        public Nullable<decimal> MP_EMP { get; set; }
        public Nullable<decimal> MP_Incentive { get; set; }
        public Nullable<decimal> MP_IncentiveEMP { get; set; }
        public Nullable<System.DateTime> FROM_DATE { get; set; }
        public Nullable<System.DateTime> TO_DATE { get; set; }
        public string Program_Code { get; set; }
        public string Purchase_Tax_Invoice { get; set; }
        public string Purchase_Tax_Invoice_Type { get; set; }
        public int GSTRegistered { get; set; }
        public Nullable<decimal> Handling_Charges_Per { get; set; }
        public Nullable<decimal> Handling_Charges_Amount { get; set; }
        public Nullable<decimal> Handling_Charges_RO_Amount { get; set; }
        public Nullable<decimal> SRN_Net_Amount { get; set; }
        public Nullable<decimal> SRN_RO_Amount { get; set; }
        public Nullable<decimal> Total_Head_Load_RO_Amount { get; set; }
        public Nullable<decimal> RoundOffAmount { get; set; }
    
        public virtual TSPL_COMPANY_MASTER TSPL_COMPANY_MASTER { get; set; }
        public virtual TSPL_MCC_MASTER TSPL_MCC_MASTER { get; set; }
        public virtual TSPL_MCC_MASTER TSPL_MCC_MASTER1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_PURCHASE_INVOICE_PROVISION_DETAIL> TSPL_MILK_PURCHASE_INVOICE_PROVISION_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_PURCHASE_INVOICE_PROVISON_INCENTIVEDETAIL> TSPL_MILK_PURCHASE_INVOICE_PROVISON_INCENTIVEDETAIL { get; set; }
        public virtual TSPL_VENDOR_MASTER TSPL_VENDOR_MASTER { get; set; }
    }
}