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
    
    public partial class TSPL_CURRENCY_MASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_CURRENCY_MASTER()
        {
            this.TSPL_BOOKING_MASTER_PRODUCTSALE = new HashSet<TSPL_BOOKING_MASTER_PRODUCTSALE>();
            this.TSPL_COMPANY_MASTER = new HashSet<TSPL_COMPANY_MASTER>();
            this.TSPL_CSA_TRANSFER_HEAD = new HashSet<TSPL_CSA_TRANSFER_HEAD>();
            this.TSPL_CURRENCY_CONVERSION_RATE = new HashSet<TSPL_CURRENCY_CONVERSION_RATE>();
            this.TSPL_CURRENCY_CONVERSION_RATE1 = new HashSet<TSPL_CURRENCY_CONVERSION_RATE>();
            this.TSPL_CUSTOMER_ACCOUNT_SET = new HashSet<TSPL_CUSTOMER_ACCOUNT_SET>();
            this.TSPL_Customer_Invoice_Head = new HashSet<TSPL_Customer_Invoice_Head>();
            this.TSPL_CUSTOMER_INVOICE_HEAD_FARMER = new HashSet<TSPL_CUSTOMER_INVOICE_HEAD_FARMER>();
            this.TSPL_CUSTOMER_MASTER = new HashSet<TSPL_CUSTOMER_MASTER>();
            this.TSPL_CUSTOMER_OUTSTANDING_DETAIL = new HashSet<TSPL_CUSTOMER_OUTSTANDING_DETAIL>();
            this.TSPL_DAIRY_PROFORMA_INVOICE_HEAD = new HashSet<TSPL_DAIRY_PROFORMA_INVOICE_HEAD>();
            this.TSPL_DELIVERY_ORDER_HEAD_PRODUCTSALE = new HashSet<TSPL_DELIVERY_ORDER_HEAD_PRODUCTSALE>();
            this.TSPL_DISPATCH_ADVICE_HEAD_PRODUCTSALE = new HashSet<TSPL_DISPATCH_ADVICE_HEAD_PRODUCTSALE>();
            this.TSPL_DOCUMENT_ACCEPTANCE_DETAIL_MT = new HashSet<TSPL_DOCUMENT_ACCEPTANCE_DETAIL_MT>();
            this.TSPL_EX_COMMERCIAL_INVOICE_HEAD = new HashSet<TSPL_EX_COMMERCIAL_INVOICE_HEAD>();
            this.TSPL_EX_PI_HEAD = new HashSet<TSPL_EX_PI_HEAD>();
            this.TSPL_EX_PI_HEAD_HISTORY = new HashSet<TSPL_EX_PI_HEAD_HISTORY>();
            this.TSPL_EX_SALE_INVOICE_HEAD = new HashSet<TSPL_EX_SALE_INVOICE_HEAD>();
            this.TSPL_GRN_HEAD = new HashSet<TSPL_GRN_HEAD>();
            this.TSPL_JOURNAL_MASTER = new HashSet<TSPL_JOURNAL_MASTER>();
            this.TSPL_JOURNAL_MASTER_OP = new HashSet<TSPL_JOURNAL_MASTER_OP>();
            this.TSPL_JOURNAL_MASTER_SYNC = new HashSet<TSPL_JOURNAL_MASTER_SYNC>();
            this.TSPL_LC_CREATION_MT = new HashSet<TSPL_LC_CREATION_MT>();
            this.TSPL_LC_REQUEST_MT = new HashSet<TSPL_LC_REQUEST_MT>();
            this.TSPL_MCC_SALE_FARMER_HEAD = new HashSet<TSPL_MCC_SALE_FARMER_HEAD>();
            this.TSPL_MCC_SALE_RETURN_HEAD_FARMER = new HashSet<TSPL_MCC_SALE_RETURN_HEAD_FARMER>();
            this.TSPL_Mcc_Milk_Transport_Invoice_HEAD = new HashSet<TSPL_Mcc_Milk_Transport_Invoice_HEAD>();
            this.TSPL_MP_PAY_HEAD = new HashSet<TSPL_MP_PAY_HEAD>();
            this.TSPL_MP_PAY_HEAD1 = new HashSet<TSPL_MP_PAY_HEAD>();
            this.TSPL_MRN_HEAD = new HashSet<TSPL_MRN_HEAD>();
            this.TSPL_MRN_HEAD_HISTORY = new HashSet<TSPL_MRN_HEAD_HISTORY>();
            this.TSPL_PAYMENT_HEADER = new HashSet<TSPL_PAYMENT_HEADER>();
            this.TSPL_PAYMENT_HEADER1 = new HashSet<TSPL_PAYMENT_HEADER>();
            this.TSPL_PI_HEAD = new HashSet<TSPL_PI_HEAD>();
            this.TSPL_PR_HEAD = new HashSet<TSPL_PR_HEAD>();
            this.TSPL_PROSPECT_HEAD = new HashSet<TSPL_PROSPECT_HEAD>();
            this.TSPL_PURCHASE_ORDER_HEAD = new HashSet<TSPL_PURCHASE_ORDER_HEAD>();
            this.TSPL_RECEIPT_HEADER = new HashSet<TSPL_RECEIPT_HEADER>();
            this.TSPL_RECEIPT_HEADER1 = new HashSet<TSPL_RECEIPT_HEADER>();
            this.TSPL_Recurring_Payable_INVOICE_HEAD = new HashSet<TSPL_Recurring_Payable_INVOICE_HEAD>();
            this.TSPL_REVALUATION_HEAD = new HashSet<TSPL_REVALUATION_HEAD>();
            this.TSPL_Reverse_JOURNAL_MASTER = new HashSet<TSPL_Reverse_JOURNAL_MASTER>();
            this.TSPL_SALES_ORDER_HEAD_PRODUCTSALE = new HashSet<TSPL_SALES_ORDER_HEAD_PRODUCTSALE>();
            this.TSPL_SD_QUOTATION_HEAD = new HashSet<TSPL_SD_QUOTATION_HEAD>();
            this.TSPL_SD_SHIPMENT_HEAD = new HashSet<TSPL_SD_SHIPMENT_HEAD>();
            this.TSPL_SD_SALE_INVOICE_HEAD = new HashSet<TSPL_SD_SALE_INVOICE_HEAD>();
            this.TSPL_SD_SALE_RETURN_HEAD = new HashSet<TSPL_SD_SALE_RETURN_HEAD>();
            this.TSPL_SD_SALES_ORDER_HEAD = new HashSet<TSPL_SD_SALES_ORDER_HEAD>();
            this.TSPL_SD_SALES_Quotation_HEAD = new HashSet<TSPL_SD_SALES_Quotation_HEAD>();
            this.TSPL_SRN_HEAD = new HashSet<TSPL_SRN_HEAD>();
            this.TSPL_TAX_GROUP_DETAILS = new HashSet<TSPL_TAX_GROUP_DETAILS>();
            this.TSPL_TAX_GROUP_MASTER = new HashSet<TSPL_TAX_GROUP_MASTER>();
            this.TSPL_TAX_MASTER = new HashSet<TSPL_TAX_MASTER>();
            this.TSPL_TENDER_SHORT_PENALTY = new HashSet<TSPL_TENDER_SHORT_PENALTY>();
            this.TSPL_TRANSFER_ORDER_HEAD = new HashSet<TSPL_TRANSFER_ORDER_HEAD>();
            this.TSPL_VENDOR_MASTER = new HashSet<TSPL_VENDOR_MASTER>();
            this.TSPL_VENDOR_ACCOUNT_SET = new HashSet<TSPL_VENDOR_ACCOUNT_SET>();
            this.TSPL_VENDOR_INVOICE_HEAD = new HashSet<TSPL_VENDOR_INVOICE_HEAD>();
        }
    
        public string CURRENCY_CODE { get; set; }
        public string CURRENCY_NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string CURRENCY_SIGN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_BOOKING_MASTER_PRODUCTSALE> TSPL_BOOKING_MASTER_PRODUCTSALE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_COMPANY_MASTER> TSPL_COMPANY_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CSA_TRANSFER_HEAD> TSPL_CSA_TRANSFER_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CURRENCY_CONVERSION_RATE> TSPL_CURRENCY_CONVERSION_RATE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CURRENCY_CONVERSION_RATE> TSPL_CURRENCY_CONVERSION_RATE1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CUSTOMER_ACCOUNT_SET> TSPL_CUSTOMER_ACCOUNT_SET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_Customer_Invoice_Head> TSPL_Customer_Invoice_Head { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CUSTOMER_INVOICE_HEAD_FARMER> TSPL_CUSTOMER_INVOICE_HEAD_FARMER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CUSTOMER_MASTER> TSPL_CUSTOMER_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CUSTOMER_OUTSTANDING_DETAIL> TSPL_CUSTOMER_OUTSTANDING_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DAIRY_PROFORMA_INVOICE_HEAD> TSPL_DAIRY_PROFORMA_INVOICE_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DELIVERY_ORDER_HEAD_PRODUCTSALE> TSPL_DELIVERY_ORDER_HEAD_PRODUCTSALE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DISPATCH_ADVICE_HEAD_PRODUCTSALE> TSPL_DISPATCH_ADVICE_HEAD_PRODUCTSALE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DOCUMENT_ACCEPTANCE_DETAIL_MT> TSPL_DOCUMENT_ACCEPTANCE_DETAIL_MT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EX_COMMERCIAL_INVOICE_HEAD> TSPL_EX_COMMERCIAL_INVOICE_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EX_PI_HEAD> TSPL_EX_PI_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EX_PI_HEAD_HISTORY> TSPL_EX_PI_HEAD_HISTORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EX_SALE_INVOICE_HEAD> TSPL_EX_SALE_INVOICE_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_GRN_HEAD> TSPL_GRN_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_JOURNAL_MASTER> TSPL_JOURNAL_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_JOURNAL_MASTER_OP> TSPL_JOURNAL_MASTER_OP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_JOURNAL_MASTER_SYNC> TSPL_JOURNAL_MASTER_SYNC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_LC_CREATION_MT> TSPL_LC_CREATION_MT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_LC_REQUEST_MT> TSPL_LC_REQUEST_MT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MCC_SALE_FARMER_HEAD> TSPL_MCC_SALE_FARMER_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MCC_SALE_RETURN_HEAD_FARMER> TSPL_MCC_SALE_RETURN_HEAD_FARMER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_Mcc_Milk_Transport_Invoice_HEAD> TSPL_Mcc_Milk_Transport_Invoice_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MP_PAY_HEAD> TSPL_MP_PAY_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MP_PAY_HEAD> TSPL_MP_PAY_HEAD1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MRN_HEAD> TSPL_MRN_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MRN_HEAD_HISTORY> TSPL_MRN_HEAD_HISTORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PAYMENT_HEADER> TSPL_PAYMENT_HEADER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PAYMENT_HEADER> TSPL_PAYMENT_HEADER1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PI_HEAD> TSPL_PI_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PR_HEAD> TSPL_PR_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PROSPECT_HEAD> TSPL_PROSPECT_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PURCHASE_ORDER_HEAD> TSPL_PURCHASE_ORDER_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_RECEIPT_HEADER> TSPL_RECEIPT_HEADER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_RECEIPT_HEADER> TSPL_RECEIPT_HEADER1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_Recurring_Payable_INVOICE_HEAD> TSPL_Recurring_Payable_INVOICE_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_REVALUATION_HEAD> TSPL_REVALUATION_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_Reverse_JOURNAL_MASTER> TSPL_Reverse_JOURNAL_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SALES_ORDER_HEAD_PRODUCTSALE> TSPL_SALES_ORDER_HEAD_PRODUCTSALE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SD_QUOTATION_HEAD> TSPL_SD_QUOTATION_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SD_SHIPMENT_HEAD> TSPL_SD_SHIPMENT_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SD_SALE_INVOICE_HEAD> TSPL_SD_SALE_INVOICE_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SD_SALE_RETURN_HEAD> TSPL_SD_SALE_RETURN_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SD_SALES_ORDER_HEAD> TSPL_SD_SALES_ORDER_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SD_SALES_Quotation_HEAD> TSPL_SD_SALES_Quotation_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SRN_HEAD> TSPL_SRN_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_TAX_GROUP_DETAILS> TSPL_TAX_GROUP_DETAILS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_TAX_GROUP_MASTER> TSPL_TAX_GROUP_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_TAX_MASTER> TSPL_TAX_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_TENDER_SHORT_PENALTY> TSPL_TENDER_SHORT_PENALTY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_TRANSFER_ORDER_HEAD> TSPL_TRANSFER_ORDER_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_VENDOR_MASTER> TSPL_VENDOR_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_VENDOR_ACCOUNT_SET> TSPL_VENDOR_ACCOUNT_SET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_VENDOR_INVOICE_HEAD> TSPL_VENDOR_INVOICE_HEAD { get; set; }
    }
}
