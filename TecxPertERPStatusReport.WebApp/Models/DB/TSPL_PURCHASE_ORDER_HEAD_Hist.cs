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
    
    public partial class TSPL_PURCHASE_ORDER_HEAD_Hist
    {
        public string PurchaseOrder_No { get; set; }
        public string PurchaseOrder_Date { get; set; }
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
        public string Posting_Date { get; set; }
        public string Delivery_date { get; set; }
        public string Dept { get; set; }
        public string Dept_Desc { get; set; }
        public string Item_Type { get; set; }
        public Nullable<int> Abandonment_No { get; set; }
        public string Abandonment_By { get; set; }
        public string Abandonment_Date { get; set; }
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
        public int Tax_Calculation_Type { get; set; }
        public string Quotation_No { get; set; }
        public Nullable<System.DateTime> Quotation_Date { get; set; }
        public string Against_Vendor_Quotation { get; set; }
        public int Is_Approved { get; set; }
        public double Is_Open_PO { get; set; }
        public string Against_PO { get; set; }
        public Nullable<System.DateTime> Renewal_Date { get; set; }
        public string Payment_Terms { get; set; }
        public string Insurance_Terms { get; set; }
        public string Delivery_Terms_Code { get; set; }
        public string ServiceBill_No { get; set; }
        public Nullable<System.DateTime> ServiceBill_Date { get; set; }
        public string Closed_By { get; set; }
        public Nullable<System.DateTime> Closed_Date { get; set; }
        public string Posted_By { get; set; }
        public string Bank_Code { get; set; }
        public string Payment_Code { get; set; }
        public Nullable<int> GSTRegistered { get; set; }
        public string Sublocation_Code { get; set; }
        public int isJobWorkOutward { get; set; }
        public string close_remarks { get; set; }
        public string Freight { get; set; }
        public string Packing_Forward { get; set; }
        public string Insurance { get; set; }
        public string Against_Tender { get; set; }
        public string RefTendorNo { get; set; }
        public string Against_WorkEstimation_Id { get; set; }
        public string From_Screen_Code { get; set; }
    
        public virtual TSPL_BANK_MASTER TSPL_BANK_MASTER { get; set; }
        public virtual TSPL_DELIVERY_TERMS_MASTER TSPL_DELIVERY_TERMS_MASTER { get; set; }
        public virtual TSPL_WORK_ESTIMATION_HEAD TSPL_WORK_ESTIMATION_HEAD { get; set; }
    }
}