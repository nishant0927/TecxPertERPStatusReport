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
    
    public partial class TSPL_EX_PI_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_EX_PI_HEAD()
        {
            this.TSPL_DOCUMENT_ACCEPTANCE_MT = new HashSet<TSPL_DOCUMENT_ACCEPTANCE_MT>();
            this.TSPL_EX_COMMERCIAL_INVOICE_HEAD = new HashSet<TSPL_EX_COMMERCIAL_INVOICE_HEAD>();
            this.TSPL_DOCUMENT_ACCEPTANCE_DETAIL_MT = new HashSet<TSPL_DOCUMENT_ACCEPTANCE_DETAIL_MT>();
            this.TSPL_EX_COMMERCIAL_INVOICE_DETAIL = new HashSet<TSPL_EX_COMMERCIAL_INVOICE_DETAIL>();
            this.TSPL_EX_NOTIFY_PARTY_DETAIL = new HashSet<TSPL_EX_NOTIFY_PARTY_DETAIL>();
            this.TSPL_EX_PI_DETAIL = new HashSet<TSPL_EX_PI_DETAIL>();
            this.TSPL_EX_SALE_INVOICE_HEAD = new HashSet<TSPL_EX_SALE_INVOICE_HEAD>();
            this.TSPL_EX_SALE_INVOICE_DETAIL = new HashSet<TSPL_EX_SALE_INVOICE_DETAIL>();
            this.TSPL_LC_CREATION_MT = new HashSet<TSPL_LC_CREATION_MT>();
            this.TSPL_LC_REQUEST_DETAIL_MT = new HashSet<TSPL_LC_REQUEST_DETAIL_MT>();
            this.TSPL_LC_REQUEST_MT = new HashSet<TSPL_LC_REQUEST_MT>();
            this.TSPL_SD_SALE_INVOICE_HEAD = new HashSet<TSPL_SD_SALE_INVOICE_HEAD>();
            this.TSPL_SD_SALE_INVOICE_DETAIL = new HashSet<TSPL_SD_SALE_INVOICE_DETAIL>();
        }
    
        public string Document_Code { get; set; }
        public System.DateTime Document_Date { get; set; }
        public string Customer_Code { get; set; }
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
        public Nullable<decimal> Total_Amt { get; set; }
        public string Comments { get; set; }
        public string Comp_Code { get; set; }
        public string Terms_Code { get; set; }
        public Nullable<System.DateTime> Due_Date { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modify_By { get; set; }
        public System.DateTime Modify_Date { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string Carrier { get; set; }
        public string Vehicle_Code { get; set; }
        public string VehicleNo { get; set; }
        public string Import_Export_No { get; set; }
        public string GENo { get; set; }
        public Nullable<System.DateTime> GEDate { get; set; }
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
        public string Dept { get; set; }
        public string Dept_Desc { get; set; }
        public string Item_Type { get; set; }
        public string Challan_No { get; set; }
        public Nullable<System.DateTime> Challan_Date { get; set; }
        public string Inv_No { get; set; }
        public Nullable<System.DateTime> Inv_Date { get; set; }
        public string Against_SO_No { get; set; }
        public int Tax_Calculation_Type { get; set; }
        public int Is_Internal { get; set; }
        public int Is_Create_Auto_Receipt { get; set; }
        public string Salesman_Code { get; set; }
        public string Salesman_Name { get; set; }
        public string CURRENCY_CODE { get; set; }
        public decimal ConvRate { get; set; }
        public Nullable<System.DateTime> ApplicableFrom { get; set; }
        public int Against_C_Form { get; set; }
        public int CFormRecd { get; set; }
        public int CFormApplied { get; set; }
        public string PROJECT_ID { get; set; }
        public string Price_code { get; set; }
        public string Route_No { get; set; }
        public string Route_Desc { get; set; }
        public Nullable<decimal> HeadDisc_Per { get; set; }
        public Nullable<decimal> HeadDisc_PerAmt { get; set; }
        public Nullable<decimal> HeadDisc_Amt { get; set; }
        public Nullable<decimal> TotCashDiscAmt { get; set; }
        public string Invoice_Type { get; set; }
        public string Price_Group_Code { get; set; }
        public string VEHICLE_IN { get; set; }
        public string RECEIPT_IN { get; set; }
        public string TRANSFER_HO { get; set; }
        public string Cust_PO_No { get; set; }
        public string Form_38_No { get; set; }
        public Nullable<System.DateTime> Cust_PO_Date { get; set; }
        public string Approval_Level { get; set; }
        public string Level1_User { get; set; }
        public string Level2_User { get; set; }
        public string Level3_User { get; set; }
        public int Is_Approved { get; set; }
        public Nullable<int> Is_Delivered { get; set; }
        public string Trans_Type { get; set; }
        public string Payment_Terms { get; set; }
        public string Level1_Code { get; set; }
        public string Level2_Code { get; set; }
        public string Level3_Code { get; set; }
        public string Level4_Code { get; set; }
        public Nullable<System.DateTime> GR_Date { get; set; }
        public Nullable<System.DateTime> RoadPermit_Date { get; set; }
        public string Exporter_Ref_No { get; set; }
        public string Pre_Carriage_By { get; set; }
        public string Discharge_Port { get; set; }
        public string Final_Destination { get; set; }
        public string Stuffing_Status { get; set; }
        public string Origin_Country { get; set; }
        public string Final_Destination_Country { get; set; }
        public string Commission_Paid { get; set; }
        public Nullable<double> Commission_Amount { get; set; }
        public string Comm_Amt_Type { get; set; }
        public string Commission_Payee_Code { get; set; }
        public string Commission_Instruction { get; set; }
        public string EX_Term_Code { get; set; }
        public Nullable<double> Advance_Percentage { get; set; }
        public string BANK_CODE { get; set; }
        public string BRANCH_CODE { get; set; }
        public string is_Accepted { get; set; }
        public Nullable<System.DateTime> Accepted_Date { get; set; }
        public string is_Partshipment { get; set; }
        public string is_Transshipment { get; set; }
        public string Document_Type { get; set; }
        public string MT_Payment_Terms_Group_Code { get; set; }
        public string MT_Payment_Terms_Group_Desc { get; set; }
        public int MT_Is_AmountinRs { get; set; }
        public double MT_LC { get; set; }
        public double MT_CAD { get; set; }
        public double MT_RETAINED { get; set; }
        public double MT_Balance_Payment { get; set; }
        public double MT_On_Account { get; set; }
        public double MT_Advance { get; set; }
        public double MT_CIF { get; set; }
        public string MT_Beneficiary_Code { get; set; }
        public string MT_Beneficiary_Name { get; set; }
        public string MT_INCOTERMS { get; set; }
        public string MT_HS_Classification_No { get; set; }
        public string MT_Against_PO { get; set; }
        public Nullable<System.DateTime> MT_Against_PO_Date { get; set; }
        public Nullable<double> Gross_Wt { get; set; }
        public double Final_Gross_Wt { get; set; }
        public string Airway_Line { get; set; }
        public int Is_Taxable { get; set; }
        public string Loading_Port { get; set; }
    
        public virtual TSPL_BANK_MASTER TSPL_BANK_MASTER { get; set; }
        public virtual TSPL_CURRENCY_MASTER TSPL_CURRENCY_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DOCUMENT_ACCEPTANCE_MT> TSPL_DOCUMENT_ACCEPTANCE_MT { get; set; }
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EX_COMMERCIAL_INVOICE_HEAD> TSPL_EX_COMMERCIAL_INVOICE_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DOCUMENT_ACCEPTANCE_DETAIL_MT> TSPL_DOCUMENT_ACCEPTANCE_DETAIL_MT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EX_COMMERCIAL_INVOICE_DETAIL> TSPL_EX_COMMERCIAL_INVOICE_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EX_NOTIFY_PARTY_DETAIL> TSPL_EX_NOTIFY_PARTY_DETAIL { get; set; }
        public virtual TSPL_SD_SALES_ORDER_HEAD TSPL_SD_SALES_ORDER_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EX_PI_DETAIL> TSPL_EX_PI_DETAIL { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER1 { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER2 { get; set; }
        public virtual TSPL_PURCHASE_ORDER_HEAD TSPL_PURCHASE_ORDER_HEAD { get; set; }
        public virtual TSPL_PAYMENT_TERMS_GROUP_MASTER_MT TSPL_PAYMENT_TERMS_GROUP_MASTER_MT { get; set; }
        public virtual TSPL_PJC_PROJECT TSPL_PJC_PROJECT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EX_SALE_INVOICE_HEAD> TSPL_EX_SALE_INVOICE_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EX_SALE_INVOICE_DETAIL> TSPL_EX_SALE_INVOICE_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_LC_CREATION_MT> TSPL_LC_CREATION_MT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_LC_REQUEST_DETAIL_MT> TSPL_LC_REQUEST_DETAIL_MT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_LC_REQUEST_MT> TSPL_LC_REQUEST_MT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SD_SALE_INVOICE_HEAD> TSPL_SD_SALE_INVOICE_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SD_SALE_INVOICE_DETAIL> TSPL_SD_SALE_INVOICE_DETAIL { get; set; }
    }
}
