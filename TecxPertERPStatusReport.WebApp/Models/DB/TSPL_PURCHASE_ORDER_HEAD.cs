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
    
    public partial class TSPL_PURCHASE_ORDER_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_PURCHASE_ORDER_HEAD()
        {
            this.TSPL_ACQUISITION_HEAD = new HashSet<TSPL_ACQUISITION_HEAD>();
            this.TSPL_DOCUMENT_ACCEPTANCE_MT = new HashSet<TSPL_DOCUMENT_ACCEPTANCE_MT>();
            this.TSPL_EMAIL_HEAD = new HashSet<TSPL_EMAIL_HEAD>();
            this.TSPL_EX_COMMERCIAL_INVOICE_HEAD = new HashSet<TSPL_EX_COMMERCIAL_INVOICE_HEAD>();
            this.TSPL_EX_PI_HEAD = new HashSet<TSPL_EX_PI_HEAD>();
            this.TSPL_GRN_HEAD = new HashSet<TSPL_GRN_HEAD>();
            this.TSPL_LC_CREATION_MT = new HashSet<TSPL_LC_CREATION_MT>();
            this.TSPL_LC_REQUEST_MT = new HashSet<TSPL_LC_REQUEST_MT>();
            this.TSPL_Mcc_Milk_Transport_Invoice_HEAD = new HashSet<TSPL_Mcc_Milk_Transport_Invoice_HEAD>();
            this.TSPL_MCC_SALE_RETURN_HEAD_FARMER = new HashSet<TSPL_MCC_SALE_RETURN_HEAD_FARMER>();
            this.TSPL_MILK_RGP_HEAD = new HashSet<TSPL_MILK_RGP_HEAD>();
            this.TSPL_MP_PAY_HEAD = new HashSet<TSPL_MP_PAY_HEAD>();
            this.TSPL_MRN_HEAD = new HashSet<TSPL_MRN_HEAD>();
            this.TSPL_PAYMENT_HEADER = new HashSet<TSPL_PAYMENT_HEADER>();
            this.TSPL_PAYMENT_HEADER1 = new HashSet<TSPL_PAYMENT_HEADER>();
            this.TSPL_PI_HEAD = new HashSet<TSPL_PI_HEAD>();
            this.TSPL_PJV_HEAD = new HashSet<TSPL_PJV_HEAD>();
            this.TSPL_PO_SCH_HEAD = new HashSet<TSPL_PO_SCH_HEAD>();
            this.TSPL_PR_HEAD = new HashSet<TSPL_PR_HEAD>();
            this.TSPL_PURCHASE_ORDER_ADDITION_CHARGE_INSURANCE = new HashSet<TSPL_PURCHASE_ORDER_ADDITION_CHARGE_INSURANCE>();
            this.TSPL_DOCUMENT_ACCEPTANCE_DETAIL_MT = new HashSet<TSPL_DOCUMENT_ACCEPTANCE_DETAIL_MT>();
            this.TSPL_EMAIL_HEAD_SYNC = new HashSet<TSPL_EMAIL_HEAD_SYNC>();
            this.TSPL_EX_COMMERCIAL_INVOICE_DETAIL = new HashSet<TSPL_EX_COMMERCIAL_INVOICE_DETAIL>();
            this.TSPL_EX_PI_HEAD_HISTORY = new HashSet<TSPL_EX_PI_HEAD_HISTORY>();
            this.TSPL_GRN_DETAIL = new HashSet<TSPL_GRN_DETAIL>();
            this.TSPL_GRN_RGP_CONVERSION_DETAIL = new HashSet<TSPL_GRN_RGP_CONVERSION_DETAIL>();
            this.TSPL_LC_REQUEST_DETAIL_MT = new HashSet<TSPL_LC_REQUEST_DETAIL_MT>();
            this.TSPL_MILK_RGP_DETAIL = new HashSet<TSPL_MILK_RGP_DETAIL>();
            this.TSPL_MRN_DETAIL = new HashSet<TSPL_MRN_DETAIL>();
            this.TSPL_MRP_PO_DETAIL = new HashSet<TSPL_MRP_PO_DETAIL>();
            this.TSPL_PI_DETAIL = new HashSet<TSPL_PI_DETAIL>();
            this.TSPL_PO_ADVANCE_ADJUSTMENT_KNOCKOFF = new HashSet<TSPL_PO_ADVANCE_ADJUSTMENT_KNOCKOFF>();
            this.TSPL_PO_SCH_DETAIL = new HashSet<TSPL_PO_SCH_DETAIL>();
            this.TSPL_PO_VENDOR_SCH_DETAIL = new HashSet<TSPL_PO_VENDOR_SCH_DETAIL>();
            this.TSPL_PR_DETAIL = new HashSet<TSPL_PR_DETAIL>();
            this.TSPL_PURCHASE_ORDER_DETAIL = new HashSet<TSPL_PURCHASE_ORDER_DETAIL>();
            this.TSPL_QC_CHECK_DETAIL = new HashSet<TSPL_QC_CHECK_DETAIL>();
            this.TSPL_QC_CHECK_SRN_DETAIL = new HashSet<TSPL_QC_CHECK_SRN_DETAIL>();
            this.TSPL_RGP_HEAD1 = new HashSet<TSPL_RGP_HEAD>();
            this.TSPL_RGP_JOB_WORK_DETAIL = new HashSet<TSPL_RGP_JOB_WORK_DETAIL>();
            this.TSPL_RGP_DETAIL = new HashSet<TSPL_RGP_DETAIL>();
            this.TSPL_SD_SALE_INVOICE_HEAD = new HashSet<TSPL_SD_SALE_INVOICE_HEAD>();
            this.TSPL_SD_SALE_RETURN_HEAD = new HashSet<TSPL_SD_SALE_RETURN_HEAD>();
            this.TSPL_SET_PO_SCHEDULE = new HashSet<TSPL_SET_PO_SCHEDULE>();
            this.TSPL_SRN_HEAD1 = new HashSet<TSPL_SRN_HEAD>();
            this.TSPL_SRN_TENDER = new HashSet<TSPL_SRN_TENDER>();
            this.TSPL_SRN_DETAIL = new HashSet<TSPL_SRN_DETAIL>();
            this.TSPL_TENDER_SCHEDULE_PO = new HashSet<TSPL_TENDER_SCHEDULE_PO>();
            this.TSPL_TENDER_SCHEDULE_PENALTY_PO = new HashSet<TSPL_TENDER_SCHEDULE_PENALTY_PO>();
        }
    
        public string PurchaseOrder_No { get; set; }
        public System.DateTime PurchaseOrder_Date { get; set; }
        public string PurchaseOrder_Type { get; set; }
        public string Vendor_Code { get; set; }
        public string Vendor_Name { get; set; }
        public int Status { get; set; }
        public int On_Hold { get; set; }
        public string Ref_No { get; set; }
        public string Description { get; set; }
        public string Remarks { get; set; }
        public string Tax_Group { get; set; }
        public string Bill_To_Location { get; set; }
        public string Ship_To_Location { get; set; }
        public string TAX1 { get; set; }
        public Nullable<decimal> TAX1_Rate { get; set; }
        public Nullable<decimal> TAX1_Amt { get; set; }
        public Nullable<decimal> TAX1_Base_Amt { get; set; }
        public string TAX2 { get; set; }
        public Nullable<decimal> TAX2_Rate { get; set; }
        public Nullable<decimal> TAX2_Amt { get; set; }
        public Nullable<decimal> TAX2_Base_Amt { get; set; }
        public string TAX3 { get; set; }
        public Nullable<decimal> TAX3_Rate { get; set; }
        public Nullable<decimal> TAX3_Amt { get; set; }
        public Nullable<decimal> TAX3_Base_Amt { get; set; }
        public string TAX4 { get; set; }
        public Nullable<decimal> TAX4_Rate { get; set; }
        public Nullable<decimal> TAX4_Amt { get; set; }
        public Nullable<decimal> TAX4_Base_Amt { get; set; }
        public string TAX5 { get; set; }
        public Nullable<decimal> TAX5_Rate { get; set; }
        public Nullable<decimal> TAX5_Amt { get; set; }
        public Nullable<decimal> TAX5_Base_Amt { get; set; }
        public string TAX6 { get; set; }
        public Nullable<decimal> TAX6_Rate { get; set; }
        public Nullable<decimal> TAX6_Amt { get; set; }
        public Nullable<decimal> TAX6_Base_Amt { get; set; }
        public string TAX7 { get; set; }
        public Nullable<decimal> TAX7_Rate { get; set; }
        public Nullable<decimal> TAX7_Amt { get; set; }
        public Nullable<decimal> TAX7_Base_Amt { get; set; }
        public string TAX8 { get; set; }
        public Nullable<decimal> TAX8_Rate { get; set; }
        public Nullable<decimal> TAX8_Amt { get; set; }
        public Nullable<decimal> TAX8_Base_Amt { get; set; }
        public string TAX9 { get; set; }
        public Nullable<decimal> TAX9_Rate { get; set; }
        public Nullable<decimal> TAX9_Amt { get; set; }
        public Nullable<decimal> TAX9_Base_Amt { get; set; }
        public string TAX10 { get; set; }
        public Nullable<decimal> TAX10_Rate { get; set; }
        public Nullable<decimal> TAX10_Amt { get; set; }
        public Nullable<decimal> TAX10_Base_Amt { get; set; }
        public Nullable<decimal> Discount_Base { get; set; }
        public Nullable<decimal> Discount_Amt { get; set; }
        public Nullable<decimal> Amount_Less_Discount { get; set; }
        public Nullable<decimal> Total_Tax_Amt { get; set; }
        public Nullable<decimal> PO_Total_Amt { get; set; }
        public string Comments { get; set; }
        public string Comp_Code { get; set; }
        public string Terms_Code { get; set; }
        public string Due_Date { get; set; }
        public string Mode_Of_Transport { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modify_By { get; set; }
        public string Modify_Date { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string Delivery_date { get; set; }
        public string Dept { get; set; }
        public string Dept_Desc { get; set; }
        public string Item_Type { get; set; }
        public int Abandonment_No { get; set; }
        public string Against_Requisition { get; set; }
        public string Add_Charge_Code1 { get; set; }
        public string Add_Charge_Name1 { get; set; }
        public Nullable<decimal> Add_Charge_Amt1 { get; set; }
        public string Add_Charge_Code2 { get; set; }
        public string Add_Charge_Name2 { get; set; }
        public Nullable<decimal> Add_Charge_Amt2 { get; set; }
        public string Add_Charge_Code3 { get; set; }
        public string Add_Charge_Name3 { get; set; }
        public Nullable<decimal> Add_Charge_Amt3 { get; set; }
        public string Add_Charge_Code4 { get; set; }
        public string Add_Charge_Name4 { get; set; }
        public Nullable<decimal> Add_Charge_Amt4 { get; set; }
        public string Add_Charge_Code5 { get; set; }
        public string Add_Charge_Name5 { get; set; }
        public Nullable<decimal> Add_Charge_Amt5 { get; set; }
        public string Add_Charge_Code6 { get; set; }
        public string Add_Charge_Name6 { get; set; }
        public Nullable<decimal> Add_Charge_Amt6 { get; set; }
        public string Add_Charge_Code7 { get; set; }
        public string Add_Charge_Name7 { get; set; }
        public Nullable<decimal> Add_Charge_Amt7 { get; set; }
        public string Add_Charge_Code8 { get; set; }
        public string Add_Charge_Name8 { get; set; }
        public Nullable<decimal> Add_Charge_Amt8 { get; set; }
        public string Add_Charge_Code9 { get; set; }
        public string Add_Charge_Name9 { get; set; }
        public Nullable<decimal> Add_Charge_Amt9 { get; set; }
        public string Add_Charge_Code10 { get; set; }
        public string Add_Charge_Name10 { get; set; }
        public Nullable<decimal> Add_Charge_Amt10 { get; set; }
        public Nullable<decimal> Total_Add_Charge { get; set; }
        public Nullable<int> Against_RGP { get; set; }
        public int Tax_Calculation_Type { get; set; }
        public string Against_RGP_NO { get; set; }
        public string Quotation_No { get; set; }
        public Nullable<System.DateTime> Quotation_Date { get; set; }
        public int is_Excise_On_Qty { get; set; }
        public Nullable<decimal> AssessableAmt { get; set; }
        public string Against_Vendor_Quotation { get; set; }
        public string Terms_Remark { get; set; }
        public string CURRENCY_CODE { get; set; }
        public decimal ConvRate { get; set; }
        public Nullable<System.DateTime> ApplicableFrom { get; set; }
        public int Against_C_Form { get; set; }
        public int CFormRecd { get; set; }
        public int CFormApplied { get; set; }
        public string Delivery_Duration { get; set; }
        public string PROJECT_ID { get; set; }
        public string close_yn { get; set; }
        public int IsAbatementPO { get; set; }
        public string Bin_No { get; set; }
        public Nullable<System.DateTime> Expiry_Date { get; set; }
        public string Approval_Level { get; set; }
        public string Level1_User { get; set; }
        public string Level2_User { get; set; }
        public string Level3_User { get; set; }
        public int MCC_Purchase { get; set; }
        public string State_Code { get; set; }
        public decimal PO_AMOUNT { get; set; }
        public int isBlanket { get; set; }
        public string Auto_Purchase { get; set; }
        public string Issue_Road_Permit { get; set; }
        public string Issue_C_Form { get; set; }
        public int Is_Approved { get; set; }
        public string SaleInvoiceNo { get; set; }
        public string SaleInvoice_Type { get; set; }
        public int MT_Is_Merchant_Trade { get; set; }
        public string MT_PI_No { get; set; }
        public string MT_PI_Status { get; set; }
        public Nullable<System.DateTime> MT_PI_Status_Date { get; set; }
        public string MT_Payment_Terms_Group_Code { get; set; }
        public int MT_Is_AmountinRs { get; set; }
        public double MT_LC { get; set; }
        public double MT_CAD { get; set; }
        public double MT_RETAINED { get; set; }
        public double MT_Balance_Payment { get; set; }
        public double MT_On_Account { get; set; }
        public double MT_Advance { get; set; }
        public string MT_Beneficiary_Code { get; set; }
        public string MT_INCOTERMS { get; set; }
        public double Is_Open_PO { get; set; }
        public string Against_PO { get; set; }
        public Nullable<System.DateTime> Renewal_Date { get; set; }
        public string Payment_Terms { get; set; }
        public string Insurance_Terms { get; set; }
        public string Delivery_Terms_Code { get; set; }
        public int Auto_Calculate { get; set; }
        public string Subject { get; set; }
        public string Content_Subject { get; set; }
        public string Kind_Attentation { get; set; }
        public string MT_HS_Classification_No { get; set; }
        public int IsPO { get; set; }
        public int IsContent { get; set; }
        public string MT_Pre_Carriage_By { get; set; }
        public string MT_Carrier { get; set; }
        public string MT_Discharge_Port { get; set; }
        public string MT_Final_Destination { get; set; }
        public string MT_Origin_Country { get; set; }
        public string MT_Final_Destination_Country { get; set; }
        public string MT_CreditTerms_Code { get; set; }
        public Nullable<System.DateTime> MT_PI_Due_Date { get; set; }
        public string MT_Stuffing_Status { get; set; }
        public string MT_Payment_Terms { get; set; }
        public string MT_EX_Term_Code { get; set; }
        public string MT_is_Accepted { get; set; }
        public Nullable<System.DateTime> MT_Accepted_Date { get; set; }
        public string MT_is_Partshipment { get; set; }
        public string MT_is_Transshipment { get; set; }
        public string MT_CreditTermsName { get; set; }
        public double MT_CIF { get; set; }
        public string MT_Advance_Type { get; set; }
        public double MT_PT_Advance_Amount { get; set; }
        public string MT_is_Partpayment { get; set; }
        public string MT_Buyer_PO_No { get; set; }
        public Nullable<System.DateTime> MT_Buyer_PO_Date { get; set; }
        public string Capex_Code { get; set; }
        public string Capex_SubCode { get; set; }
        public int IsCancel { get; set; }
        public string Category { get; set; }
        public string Capacity { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public Nullable<decimal> Amt_After_Tax { get; set; }
        public string Add_Charge_Apply_On1 { get; set; }
        public Nullable<decimal> Add_Charge_Per1 { get; set; }
        public string Add_Charge_Apply_On2 { get; set; }
        public Nullable<decimal> Add_Charge_Per2 { get; set; }
        public string Add_Charge_Apply_On3 { get; set; }
        public Nullable<decimal> Add_Charge_Per3 { get; set; }
        public string Add_Charge_Apply_On4 { get; set; }
        public Nullable<decimal> Add_Charge_Per4 { get; set; }
        public string Add_Charge_Apply_On5 { get; set; }
        public Nullable<decimal> Add_Charge_Per5 { get; set; }
        public string Add_Charge_Apply_On6 { get; set; }
        public Nullable<decimal> Add_Charge_Per6 { get; set; }
        public string Add_Charge_Apply_On7 { get; set; }
        public Nullable<decimal> Add_Charge_Per7 { get; set; }
        public string Add_Charge_Apply_On8 { get; set; }
        public Nullable<decimal> Add_Charge_Per8 { get; set; }
        public string Add_Charge_Apply_On9 { get; set; }
        public Nullable<decimal> Add_Charge_Per9 { get; set; }
        public string Add_Charge_Apply_On10 { get; set; }
        public Nullable<decimal> Add_Charge_Per10 { get; set; }
        public int Emergency { get; set; }
        public int Apply_Receive_Control { get; set; }
        public int Delivery_days { get; set; }
        public Nullable<int> Is_Auto_Weighment_Type { get; set; }
        public string Amendment_Code { get; set; }
        public string Amendment_By { get; set; }
        public Nullable<System.DateTime> Amendment_Date { get; set; }
        public string ServiceBill_No { get; set; }
        public Nullable<System.DateTime> ServiceBill_Date { get; set; }
        public string Closed_By { get; set; }
        public Nullable<System.DateTime> Closed_Date { get; set; }
        public string Posted_By { get; set; }
        public string Bank_Code { get; set; }
        public string Payment_Code { get; set; }
        public int GSTRegistered { get; set; }
        public string Sublocation_Code { get; set; }
        public int isJobWorkOutward { get; set; }
        public Nullable<decimal> Total_Taxable_Amount { get; set; }
        public string WorkOrder_Vendor { get; set; }
        public string WorkOrder_Vendor_Phn { get; set; }
        public string WorkOrder_Vendor_Add { get; set; }
        public string close_remarks { get; set; }
        public Nullable<int> Is_Repair { get; set; }
        public string Freight { get; set; }
        public string Packing_Forward { get; set; }
        public string Insurance { get; set; }
        public Nullable<decimal> Header_Discount_Amount { get; set; }
        public string ReferencePO { get; set; }
        public string Against_Tender { get; set; }
        public string RefTendorNo { get; set; }
        public string Confirmatory_PO_SRN_No { get; set; }
        public string Against_WorkEstimation_Id { get; set; }
        public string From_Screen_Code { get; set; }
        public Nullable<decimal> Total_Add_Charge_Insurance { get; set; }
        public Nullable<decimal> Total_Item_Insurance_Amt { get; set; }
        public Nullable<decimal> Retention { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ACQUISITION_HEAD> TSPL_ACQUISITION_HEAD { get; set; }
        public virtual TSPL_BANK_MASTER TSPL_BANK_MASTER { get; set; }
        public virtual TSPL_CAPEX_BUDGET_MASTER TSPL_CAPEX_BUDGET_MASTER { get; set; }
        public virtual TSPL_CAPEX_MASTER TSPL_CAPEX_MASTER { get; set; }
        public virtual TSPL_CURRENCY_MASTER TSPL_CURRENCY_MASTER { get; set; }
        public virtual TSPL_DELIVERY_TERMS_MASTER TSPL_DELIVERY_TERMS_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DOCUMENT_ACCEPTANCE_MT> TSPL_DOCUMENT_ACCEPTANCE_MT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EMAIL_HEAD> TSPL_EMAIL_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EX_COMMERCIAL_INVOICE_HEAD> TSPL_EX_COMMERCIAL_INVOICE_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EX_PI_HEAD> TSPL_EX_PI_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_GRN_HEAD> TSPL_GRN_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_LC_CREATION_MT> TSPL_LC_CREATION_MT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_LC_REQUEST_MT> TSPL_LC_REQUEST_MT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_Mcc_Milk_Transport_Invoice_HEAD> TSPL_Mcc_Milk_Transport_Invoice_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MCC_SALE_RETURN_HEAD_FARMER> TSPL_MCC_SALE_RETURN_HEAD_FARMER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_RGP_HEAD> TSPL_MILK_RGP_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MP_PAY_HEAD> TSPL_MP_PAY_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MRN_HEAD> TSPL_MRN_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PAYMENT_HEADER> TSPL_PAYMENT_HEADER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PAYMENT_HEADER> TSPL_PAYMENT_HEADER1 { get; set; }
        public virtual TSPL_PAYMENT_TERMS_GROUP_MASTER_MT TSPL_PAYMENT_TERMS_GROUP_MASTER_MT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PI_HEAD> TSPL_PI_HEAD { get; set; }
        public virtual TSPL_PJC_PROJECT TSPL_PJC_PROJECT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PJV_HEAD> TSPL_PJV_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PO_SCH_HEAD> TSPL_PO_SCH_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PR_HEAD> TSPL_PR_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PURCHASE_ORDER_ADDITION_CHARGE_INSURANCE> TSPL_PURCHASE_ORDER_ADDITION_CHARGE_INSURANCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DOCUMENT_ACCEPTANCE_DETAIL_MT> TSPL_DOCUMENT_ACCEPTANCE_DETAIL_MT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EMAIL_HEAD_SYNC> TSPL_EMAIL_HEAD_SYNC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EX_COMMERCIAL_INVOICE_DETAIL> TSPL_EX_COMMERCIAL_INVOICE_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EX_PI_HEAD_HISTORY> TSPL_EX_PI_HEAD_HISTORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_GRN_DETAIL> TSPL_GRN_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_GRN_RGP_CONVERSION_DETAIL> TSPL_GRN_RGP_CONVERSION_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_LC_REQUEST_DETAIL_MT> TSPL_LC_REQUEST_DETAIL_MT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_RGP_DETAIL> TSPL_MILK_RGP_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MRN_DETAIL> TSPL_MRN_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MRP_PO_DETAIL> TSPL_MRP_PO_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PI_DETAIL> TSPL_PI_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PO_ADVANCE_ADJUSTMENT_KNOCKOFF> TSPL_PO_ADVANCE_ADJUSTMENT_KNOCKOFF { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PO_SCH_DETAIL> TSPL_PO_SCH_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PO_VENDOR_SCH_DETAIL> TSPL_PO_VENDOR_SCH_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PR_DETAIL> TSPL_PR_DETAIL { get; set; }
        public virtual TSPL_REQUISITION_HEAD TSPL_REQUISITION_HEAD { get; set; }
        public virtual TSPL_VENDOR_QUOTATION_HEAD TSPL_VENDOR_QUOTATION_HEAD { get; set; }
        public virtual TSPL_WORK_ESTIMATION_HEAD TSPL_WORK_ESTIMATION_HEAD { get; set; }
        public virtual TSPL_RGP_HEAD TSPL_RGP_HEAD { get; set; }
        public virtual TSPL_SRN_HEAD TSPL_SRN_HEAD { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER1 { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PURCHASE_ORDER_DETAIL> TSPL_PURCHASE_ORDER_DETAIL { get; set; }
        public virtual TSPL_PURCHASE_ORDER_WORK_ORDER TSPL_PURCHASE_ORDER_WORK_ORDER { get; set; }
        public virtual TSPL_PURCHASE_ORDER_WORK_ORDER_TERMS TSPL_PURCHASE_ORDER_WORK_ORDER_TERMS { get; set; }
        public virtual TSPL_STATE_MASTER TSPL_STATE_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_QC_CHECK_DETAIL> TSPL_QC_CHECK_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_QC_CHECK_SRN_DETAIL> TSPL_QC_CHECK_SRN_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_RGP_HEAD> TSPL_RGP_HEAD1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_RGP_JOB_WORK_DETAIL> TSPL_RGP_JOB_WORK_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_RGP_DETAIL> TSPL_RGP_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SD_SALE_INVOICE_HEAD> TSPL_SD_SALE_INVOICE_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SD_SALE_RETURN_HEAD> TSPL_SD_SALE_RETURN_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SET_PO_SCHEDULE> TSPL_SET_PO_SCHEDULE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SRN_HEAD> TSPL_SRN_HEAD1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SRN_TENDER> TSPL_SRN_TENDER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SRN_DETAIL> TSPL_SRN_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_TENDER_SCHEDULE_PO> TSPL_TENDER_SCHEDULE_PO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_TENDER_SCHEDULE_PENALTY_PO> TSPL_TENDER_SCHEDULE_PENALTY_PO { get; set; }
    }
}