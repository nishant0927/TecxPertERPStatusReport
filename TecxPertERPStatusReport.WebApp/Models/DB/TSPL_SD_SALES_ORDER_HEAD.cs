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
    
    public partial class TSPL_SD_SALES_ORDER_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_SD_SALES_ORDER_HEAD()
        {
            this.TSPL_DELIVERY_ORDER_HEAD_PRODUCTSALE = new HashSet<TSPL_DELIVERY_ORDER_HEAD_PRODUCTSALE>();
            this.TSPL_DISPATCH_ADVICE_HEAD_PRODUCTSALE = new HashSet<TSPL_DISPATCH_ADVICE_HEAD_PRODUCTSALE>();
            this.TSPL_EX_PI_HEAD = new HashSet<TSPL_EX_PI_HEAD>();
            this.TSPL_MF_MANUFACTURING_ORDER = new HashSet<TSPL_MF_MANUFACTURING_ORDER>();
            this.TSPL_PJC_PROJECT = new HashSet<TSPL_PJC_PROJECT>();
            this.TSPL_RECEIPT_HEADER = new HashSet<TSPL_RECEIPT_HEADER>();
            this.TSPL_SD_POS_HEAD = new HashSet<TSPL_SD_POS_HEAD>();
            this.TSPL_DELIVERY_ORDER_DETAIL_PRODUCTSALE = new HashSet<TSPL_DELIVERY_ORDER_DETAIL_PRODUCTSALE>();
            this.TSPL_DISPATCH_ADVICE_DETAIL_PRODUCTSALE = new HashSet<TSPL_DISPATCH_ADVICE_DETAIL_PRODUCTSALE>();
            this.TSPL_EX_PI_HEAD_HISTORY = new HashSet<TSPL_EX_PI_HEAD_HISTORY>();
            this.TSPL_EX_PI_DETAIL_HISTORY = new HashSet<TSPL_EX_PI_DETAIL_HISTORY>();
            this.TSPL_EX_PI_DETAIL = new HashSet<TSPL_EX_PI_DETAIL>();
            this.TSPL_SD_POS_DETAIL = new HashSet<TSPL_SD_POS_DETAIL>();
            this.TSPL_SD_SHIPMENT_HEAD = new HashSet<TSPL_SD_SHIPMENT_HEAD>();
            this.TSPL_SD_SALES_ORDER_NOTIFY_PARTY_DETAIL = new HashSet<TSPL_SD_SALES_ORDER_NOTIFY_PARTY_DETAIL>();
            this.TSPL_SD_SALES_ORDER_DETAIL = new HashSet<TSPL_SD_SALES_ORDER_DETAIL>();
            this.TSPL_SD_SHIPMENT_DETAIL = new HashSet<TSPL_SD_SHIPMENT_DETAIL>();
        }
    
        public string Document_Code { get; set; }
        public System.DateTime Document_Date { get; set; }
        public string SalesOrder_Type { get; set; }
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
        public string Due_Date { get; set; }
        public string Mode_Of_Transport { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modify_By { get; set; }
        public System.DateTime Modify_Date { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public Nullable<System.DateTime> Delivery_date { get; set; }
        public string Dept { get; set; }
        public string Dept_Desc { get; set; }
        public string Item_Type { get; set; }
        public int Abandonment_No { get; set; }
        public string Against_Quotation_No { get; set; }
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
        public string Salesman_Code { get; set; }
        public string Salesman_Name { get; set; }
        public string CURRENCY_CODE { get; set; }
        public decimal ConvRate { get; set; }
        public Nullable<System.DateTime> ApplicableFrom { get; set; }
        public string PROJECT_ID { get; set; }
        public int Approvel_Required { get; set; }
        public Nullable<int> Is_Approved { get; set; }
        public Nullable<System.DateTime> Approved_Date { get; set; }
        public string Approved_By { get; set; }
        public string Price_code { get; set; }
        public string Route_No { get; set; }
        public string Route_Desc { get; set; }
        public Nullable<decimal> HeadDisc_Per { get; set; }
        public Nullable<decimal> HeadDisc_Amt { get; set; }
        public Nullable<decimal> TotCashDiscAmt { get; set; }
        public string Price_Group_Code { get; set; }
        public string Cust_PO_No { get; set; }
        public string Bin_No { get; set; }
        public string Close_YN { get; set; }
        public string Approval_Level { get; set; }
        public string Level1_User { get; set; }
        public string Level2_User { get; set; }
        public string Level3_User { get; set; }
        public Nullable<decimal> HeadDisc_PerAmt { get; set; }
        public string CloseRemarks { get; set; }
        public string Against_DeliveryNo { get; set; }
        public int SO_Validity { get; set; }
        public int Commission_Apply { get; set; }
        public Nullable<System.DateTime> Dispatch_date { get; set; }
        public string Vehicle_Code { get; set; }
        public string Vehicle_No { get; set; }
        public Nullable<double> Vehicle_Capacity { get; set; }
        public string Dispatch_Terms { get; set; }
        public string Payment_Terms { get; set; }
        public int Dispatch_Period { get; set; }
        public string Road_Permit_No { get; set; }
        public string Trans_Type { get; set; }
        public int Auto_SaleOrder { get; set; }
        public Nullable<decimal> Total_Comm_Amt { get; set; }
        public int Itemwise { get; set; }
        public Nullable<decimal> Advance_Percentage { get; set; }
        public string Level1_Code { get; set; }
        public string Level2_Code { get; set; }
        public string Level3_Code { get; set; }
        public string Level4_Code { get; set; }
        public Nullable<System.DateTime> Cust_PODate { get; set; }
        public double RT_Rate { get; set; }
        public string Against_Booking_No { get; set; }
        public string Commission_Paid { get; set; }
        public Nullable<double> Commission_Amount { get; set; }
        public string Comm_Amt_Type { get; set; }
        public string Commission_Payee_Code { get; set; }
        public string Commission_Instruction { get; set; }
        public string EX_Term_Code { get; set; }
        public string Cust_PO_Type { get; set; }
        public Nullable<int> Is_CustomerChanged { get; set; }
        public int Is_Taxable { get; set; }
        public int IsSameBillShipParty { get; set; }
        public Nullable<double> ActualTCSBaseAmount { get; set; }
        public Nullable<double> ChangedTCSBaseAmount { get; set; }
    
        public virtual TSPL_BOOKING_MASTER_PRODUCTSALE TSPL_BOOKING_MASTER_PRODUCTSALE { get; set; }
        public virtual TSPL_CURRENCY_MASTER TSPL_CURRENCY_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DELIVERY_ORDER_HEAD_PRODUCTSALE> TSPL_DELIVERY_ORDER_HEAD_PRODUCTSALE { get; set; }
        public virtual TSPL_DELIVERY_ORDER_HEAD_PRODUCTSALE TSPL_DELIVERY_ORDER_HEAD_PRODUCTSALE1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DISPATCH_ADVICE_HEAD_PRODUCTSALE> TSPL_DISPATCH_ADVICE_HEAD_PRODUCTSALE { get; set; }
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EX_PI_HEAD> TSPL_EX_PI_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MF_MANUFACTURING_ORDER> TSPL_MF_MANUFACTURING_ORDER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PJC_PROJECT> TSPL_PJC_PROJECT { get; set; }
        public virtual TSPL_PJC_PROJECT TSPL_PJC_PROJECT1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_RECEIPT_HEADER> TSPL_RECEIPT_HEADER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SD_POS_HEAD> TSPL_SD_POS_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DELIVERY_ORDER_DETAIL_PRODUCTSALE> TSPL_DELIVERY_ORDER_DETAIL_PRODUCTSALE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DISPATCH_ADVICE_DETAIL_PRODUCTSALE> TSPL_DISPATCH_ADVICE_DETAIL_PRODUCTSALE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EX_PI_HEAD_HISTORY> TSPL_EX_PI_HEAD_HISTORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EX_PI_DETAIL_HISTORY> TSPL_EX_PI_DETAIL_HISTORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EX_PI_DETAIL> TSPL_EX_PI_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SD_POS_DETAIL> TSPL_SD_POS_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SD_SHIPMENT_HEAD> TSPL_SD_SHIPMENT_HEAD { get; set; }
        public virtual TSPL_SD_SALES_Quotation_HEAD TSPL_SD_SALES_Quotation_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SD_SALES_ORDER_NOTIFY_PARTY_DETAIL> TSPL_SD_SALES_ORDER_NOTIFY_PARTY_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SD_SALES_ORDER_DETAIL> TSPL_SD_SALES_ORDER_DETAIL { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER1 { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SD_SHIPMENT_DETAIL> TSPL_SD_SHIPMENT_DETAIL { get; set; }
    }
}
