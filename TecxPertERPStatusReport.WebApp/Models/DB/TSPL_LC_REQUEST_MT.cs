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
    
    public partial class TSPL_LC_REQUEST_MT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_LC_REQUEST_MT()
        {
            this.TSPL_FIXED_DEPOSIT_MASTER_MT = new HashSet<TSPL_FIXED_DEPOSIT_MASTER_MT>();
            this.TSPL_LC_CREATION_MT = new HashSet<TSPL_LC_CREATION_MT>();
            this.TSPL_DOCUMENT_ACCEPTANCE_DETAIL_MT = new HashSet<TSPL_DOCUMENT_ACCEPTANCE_DETAIL_MT>();
            this.TSPL_LC_ISSUINGAPPLICATION_DETAIL_MT = new HashSet<TSPL_LC_ISSUINGAPPLICATION_DETAIL_MT>();
            this.TSPL_LC_REQUEST_DETAIL_MT = new HashSet<TSPL_LC_REQUEST_DETAIL_MT>();
        }
    
        public string LCRequestNo { get; set; }
        public System.DateTime LCRequest_Date { get; set; }
        public string Bank_Code { get; set; }
        public string PurchaseOrder_No { get; set; }
        public string VendorCode { get; set; }
        public decimal LCAmount { get; set; }
        public decimal FDPer { get; set; }
        public int Posted { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string Comp_Code { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string Bank_Name { get; set; }
        public double LCPeriod { get; set; }
        public string LCPeriodType { get; set; }
        public double FDPeriod { get; set; }
        public string FDPeriodType { get; set; }
        public Nullable<System.DateTime> LCExpiryDate { get; set; }
        public string Drawee_Bank_Code { get; set; }
        public string Drawee_Bank_Name { get; set; }
        public string Location_Code { get; set; }
        public string Location_Desc { get; set; }
        public string CURRENCY_CODE { get; set; }
        public double ConvRate { get; set; }
        public string SGS_Waiver_Ref_no { get; set; }
        public string SGS_Waiver_Context { get; set; }
        public string Merchant_Dec_Ref_no { get; set; }
        public string Merchant_Dec_Context { get; set; }
        public string AD_Code_No { get; set; }
        public string Form_No { get; set; }
        public string Serial_No { get; set; }
        public string Purpose_Group_Name { get; set; }
        public string Purpose_Code { get; set; }
        public string MixedPaymentDetails { get; set; }
        public string DeferredPaymentDetails { get; set; }
        public string PartialShipment { get; set; }
        public string TransShipment { get; set; }
        public string AvailableBy { get; set; }
        public string Place { get; set; }
        public double DraftsNoofDays { get; set; }
        public string DraftsFrom { get; set; }
        public string DraftsRemarks { get; set; }
        public string DescriptionofGoods { get; set; }
        public string PurchaseInvoice_No { get; set; }
        public string Against { get; set; }
        public double LCExtendPeriod { get; set; }
        public string LCExtendPeriodType { get; set; }
        public string LCType { get; set; }
    
        public virtual TSPL_BANK_MASTER TSPL_BANK_MASTER { get; set; }
        public virtual TSPL_BANK_MASTER TSPL_BANK_MASTER1 { get; set; }
        public virtual TSPL_CURRENCY_MASTER TSPL_CURRENCY_MASTER { get; set; }
        public virtual TSPL_EX_PI_HEAD TSPL_EX_PI_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_FIXED_DEPOSIT_MASTER_MT> TSPL_FIXED_DEPOSIT_MASTER_MT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_LC_CREATION_MT> TSPL_LC_CREATION_MT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DOCUMENT_ACCEPTANCE_DETAIL_MT> TSPL_DOCUMENT_ACCEPTANCE_DETAIL_MT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_LC_ISSUINGAPPLICATION_DETAIL_MT> TSPL_LC_ISSUINGAPPLICATION_DETAIL_MT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_LC_REQUEST_DETAIL_MT> TSPL_LC_REQUEST_DETAIL_MT { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_PURCHASE_ORDER_HEAD TSPL_PURCHASE_ORDER_HEAD { get; set; }
        public virtual TSPL_VENDOR_MASTER TSPL_VENDOR_MASTER { get; set; }
    }
}