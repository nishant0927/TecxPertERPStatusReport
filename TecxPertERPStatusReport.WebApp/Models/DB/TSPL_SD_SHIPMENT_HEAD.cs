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
    
    public partial class TSPL_SD_SHIPMENT_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_SD_SHIPMENT_HEAD()
        {
            this.TSPL_PRODUCT_DISPATCH_GATE_OUT = new HashSet<TSPL_PRODUCT_DISPATCH_GATE_OUT>();
            this.TSPL_SD_SALE_INVOICE_HEAD = new HashSet<TSPL_SD_SALE_INVOICE_HEAD>();
            this.TSPL_SD_SHIPMENT_DCS_ITEM_DETAIL = new HashSet<TSPL_SD_SHIPMENT_DCS_ITEM_DETAIL>();
            this.TSPL_SD_SHIPMENT_BOOKING_DETAIL = new HashSet<TSPL_SD_SHIPMENT_BOOKING_DETAIL>();
            this.TSPL_SD_SHIPMENT_DETAIL = new HashSet<TSPL_SD_SHIPMENT_DETAIL>();
            this.TSPL_SD_SALE_INVOICE_DETAIL = new HashSet<TSPL_SD_SALE_INVOICE_DETAIL>();
            this.TSPL_VENDOR_INVOICE_HEAD = new HashSet<TSPL_VENDOR_INVOICE_HEAD>();
            this.TSPL_PO_WEIGHTMENT_HEAD1 = new HashSet<TSPL_PO_WEIGHTMENT_HEAD>();
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
        public string VehicleNo { get; set; }
        public string GRNo { get; set; }
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
        public string Against_Sales_Order { get; set; }
        public int Tax_Calculation_Type { get; set; }
        public int Is_Internal { get; set; }
        public int Is_Create_Auto_Invoice { get; set; }
        public string Sale_Invoice_No { get; set; }
        public int Is_Create_Auto_Receipt { get; set; }
        public string Against_POS { get; set; }
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
        public string Invoice_Type { get; set; }
        public string Price_Group_Code { get; set; }
        public string Vehicle_Code { get; set; }
        public Nullable<int> Mannual_Invoice_No { get; set; }
        public string Cust_PO_No { get; set; }
        public string Form_38_No { get; set; }
        public string Bin_No { get; set; }
        public Nullable<System.DateTime> cust_po_date { get; set; }
        public string Approval_Level { get; set; }
        public string Level1_User { get; set; }
        public string Level2_User { get; set; }
        public string Level3_User { get; set; }
        public Nullable<decimal> HeadDisc_PerAmt { get; set; }
        public string Mannual_Invoice_No_StringType { get; set; }
        public string Booking_No { get; set; }
        public Nullable<System.DateTime> Booking_Date { get; set; }
        public string DeliveryStatus { get; set; }
        public Nullable<double> Vehicle_Capacity { get; set; }
        public string Lorry_No { get; set; }
        public string Road_Permit_No { get; set; }
        public string Transporter_Name { get; set; }
        public string Freight { get; set; }
        public double Freight_Amount { get; set; }
        public double CrateQty { get; set; }
        public string Against_Delivery_Code { get; set; }
        public Nullable<int> Is_Delivered { get; set; }
        public int SO_Validity { get; set; }
        public int Commission_Apply { get; set; }
        public Nullable<System.DateTime> Dispatch_date { get; set; }
        public string Dispatch_Terms { get; set; }
        public string Payment_Terms { get; set; }
        public int Dispatch_Period { get; set; }
        public string Trans_Type { get; set; }
        public string WayBillNo { get; set; }
        public Nullable<System.DateTime> WayBillDate { get; set; }
        public int Direct_Dispatch { get; set; }
        public Nullable<decimal> Total_Comm_Amt { get; set; }
        public string Delivery_Code_PS { get; set; }
        public int Itemwise { get; set; }
        public Nullable<decimal> Advance_Percentage { get; set; }
        public string Level1_Code { get; set; }
        public string Level2_Code { get; set; }
        public string Level3_Code { get; set; }
        public string Level4_Code { get; set; }
        public Nullable<System.DateTime> Cust_PODate { get; set; }
        public double RT_Rate { get; set; }
        public Nullable<System.DateTime> GR_Date { get; set; }
        public Nullable<System.DateTime> RoadPermit_Date { get; set; }
        public Nullable<System.DateTime> Sale_Invoice_Date { get; set; }
        public Nullable<System.DateTime> Removal_Date { get; set; }
        public string Transport_Id { get; set; }
        public Nullable<decimal> Total_Item_Weight { get; set; }
        public Nullable<decimal> Total_Item_WeightMetric { get; set; }
        public Nullable<decimal> Freight_Charges { get; set; }
        public Nullable<int> Advance_Approval_Reqd { get; set; }
        public Nullable<int> Is_Advance_Approved { get; set; }
        public decimal RoundOffAmount { get; set; }
        public string Payment_Type { get; set; }
        public string Payment_Rate { get; set; }
        public string Charge_For { get; set; }
        public Nullable<double> Payment_Amount { get; set; }
        public string AlternateVehicle { get; set; }
        public string ManualVehicle { get; set; }
        public Nullable<double> Gross_Item_Wt { get; set; }
        public Nullable<int> Is_CustomerChanged { get; set; }
        public Nullable<int> Is_OwnVehicle { get; set; }
        public string GPCode { get; set; }
        public string Transporter_Name_Manual { get; set; }
        public string GatePass_No { get; set; }
        public Nullable<double> Crate { get; set; }
        public Nullable<double> jaali { get; set; }
        public Nullable<double> Box { get; set; }
        public string OTP_No { get; set; }
        public bool OTP_Confirm { get; set; }
        public string VAT_InvoiceNo { get; set; }
        public Nullable<decimal> Print_Discount_Amt { get; set; }
        public int Including_Insurance { get; set; }
        public string Freight_Type { get; set; }
        public double EmptyCharge { get; set; }
        public double FixedCharge { get; set; }
        public string Nine_NR_No { get; set; }
        public string VatInvoice_Type { get; set; }
        public string Vehicle_Manual_No { get; set; }
        public string Is_CashSale { get; set; }
        public string Manual_CustName { get; set; }
        public string Cash_Customer { get; set; }
        public string DO_Item_Type { get; set; }
        public string EWayBillNo { get; set; }
        public Nullable<System.DateTime> EWayBillDate { get; set; }
        public string Electronic_Ref_No { get; set; }
        public int Is_Taxable { get; set; }
        public string Ship_To_Party { get; set; }
        public string Ship_To_Party_Parent { get; set; }
        public Nullable<int> No_Of_Instalment { get; set; }
        public string Scheme_Tax_Group { get; set; }
        public int IsSameBillShipParty { get; set; }
        public string Screen_Type { get; set; }
        public int Liner { get; set; }
        public string Insurance { get; set; }
        public Nullable<decimal> OPKm { get; set; }
        public Nullable<decimal> CLKm { get; set; }
        public string Crate_Item { get; set; }
        public string Crate_ItemUnit { get; set; }
        public double Crate_ItemRate { get; set; }
        public string Can_Item { get; set; }
        public string Can_ItemUnit { get; set; }
        public double Can_ItemRate { get; set; }
        public Nullable<double> TotalCAN { get; set; }
        public Nullable<double> ShippedCAN { get; set; }
        public int IsSampling { get; set; }
        public Nullable<decimal> LeakageAmount { get; set; }
        public string Manual_Driver_Name { get; set; }
        public string Manual_Salesman_Name { get; set; }
        public int IsReplacement { get; set; }
        public string Invoice_No_ForReplacement { get; set; }
        public string Customer_Complaint_No { get; set; }
        public Nullable<double> ActualTCSBaseAmount { get; set; }
        public Nullable<double> ChangedTCSBaseAmount { get; set; }
        public string Sub_Location_code { get; set; }
        public int Freight_Distance { get; set; }
        public string ShippingThrough { get; set; }
        public string MCCM_sale_created_through { get; set; }
        public int isCardSale { get; set; }
        public Nullable<decimal> Credit_Limit { get; set; }
        public Nullable<decimal> Advance_Security { get; set; }
        public Nullable<decimal> Revese_Adv_Security { get; set; }
        public Nullable<decimal> AR_Credit_Security { get; set; }
        public Nullable<decimal> Pending_Posted_DO { get; set; }
        public Nullable<decimal> UnPostedDispatch { get; set; }
        public Nullable<decimal> Ledger_Outstansing { get; set; }
        public Nullable<decimal> Refund_Security { get; set; }
        public Nullable<decimal> Reverse_Refund_Sec { get; set; }
        public Nullable<decimal> Total_Outstanding { get; set; }
        public Nullable<decimal> UnPostedShipment { get; set; }
        public string Weighment_Code { get; set; }
        public string Beejak_No { get; set; }
        public string LR_GR_NO { get; set; }
        public Nullable<System.DateTime> LR_GR_Date { get; set; }
        public string SHIP_TO_DELIVERY_AT { get; set; }
        public Nullable<decimal> Order_Qty { get; set; }
        public Nullable<decimal> Distributor_Commission_TotalAmt { get; set; }
        public string Shift_Type { get; set; }
    
        public virtual TSPL_BOOKING_MATSER TSPL_BOOKING_MATSER { get; set; }
        public virtual TSPL_CURRENCY_MASTER TSPL_CURRENCY_MASTER { get; set; }
        public virtual TSPL_CUSTOMER_COMPLAINT_HEAD TSPL_CUSTOMER_COMPLAINT_HEAD { get; set; }
        public virtual TSPL_DELIVERY_NOTE_MASTER_FRESHSALE TSPL_DELIVERY_NOTE_MASTER_FRESHSALE { get; set; }
        public virtual TSPL_DELIVERY_ORDER_HEAD_PRODUCTSALE TSPL_DELIVERY_ORDER_HEAD_PRODUCTSALE { get; set; }
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER { get; set; }
        public virtual TSPL_GATEPASS_MASTER_DAIRYSALE TSPL_GATEPASS_MASTER_DAIRYSALE { get; set; }
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER1 { get; set; }
        public virtual TSPL_PJC_PROJECT TSPL_PJC_PROJECT { get; set; }
        public virtual TSPL_PO_WEIGHTMENT_HEAD TSPL_PO_WEIGHTMENT_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PRODUCT_DISPATCH_GATE_OUT> TSPL_PRODUCT_DISPATCH_GATE_OUT { get; set; }
        public virtual TSPL_SD_POS_HEAD TSPL_SD_POS_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SD_SALE_INVOICE_HEAD> TSPL_SD_SALE_INVOICE_HEAD { get; set; }
        public virtual TSPL_SD_SALES_ORDER_HEAD TSPL_SD_SALES_ORDER_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SD_SHIPMENT_DCS_ITEM_DETAIL> TSPL_SD_SHIPMENT_DCS_ITEM_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SD_SHIPMENT_BOOKING_DETAIL> TSPL_SD_SHIPMENT_BOOKING_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SD_SHIPMENT_DETAIL> TSPL_SD_SHIPMENT_DETAIL { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER1 { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SD_SALE_INVOICE_DETAIL> TSPL_SD_SALE_INVOICE_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_VENDOR_INVOICE_HEAD> TSPL_VENDOR_INVOICE_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PO_WEIGHTMENT_HEAD> TSPL_PO_WEIGHTMENT_HEAD1 { get; set; }
    }
}
