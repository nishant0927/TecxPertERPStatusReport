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
    
    public partial class TSPL_SD_SALE_INVOICE_DETAIL
    {
        public string DOCUMENT_CODE { get; set; }
        public int Line_No { get; set; }
        public string Row_Type { get; set; }
        public string Item_Code { get; set; }
        public Nullable<double> Qty { get; set; }
        public Nullable<decimal> Balance_Qty { get; set; }
        public string Shipment_Code { get; set; }
        public string Unit_code { get; set; }
        public string Location { get; set; }
        public Nullable<double> Item_Cost { get; set; }
        public string TAX1 { get; set; }
        public Nullable<decimal> TAX1_Base_Amt { get; set; }
        public Nullable<decimal> TAX1_Rate { get; set; }
        public Nullable<decimal> TAX1_Amt { get; set; }
        public string TAX2 { get; set; }
        public Nullable<decimal> TAX2_Base_Amt { get; set; }
        public Nullable<decimal> TAX2_Rate { get; set; }
        public Nullable<decimal> TAX2_Amt { get; set; }
        public string TAX3 { get; set; }
        public Nullable<decimal> TAX3_Base_Amt { get; set; }
        public Nullable<decimal> TAX3_Rate { get; set; }
        public Nullable<decimal> TAX3_Amt { get; set; }
        public string TAX4 { get; set; }
        public Nullable<decimal> TAX4_Base_Amt { get; set; }
        public Nullable<decimal> TAX4_Rate { get; set; }
        public Nullable<decimal> TAX4_Amt { get; set; }
        public string TAX5 { get; set; }
        public Nullable<decimal> TAX5_Base_Amt { get; set; }
        public Nullable<decimal> TAX5_Rate { get; set; }
        public Nullable<decimal> TAX5_Amt { get; set; }
        public string TAX6 { get; set; }
        public Nullable<decimal> TAX6_Base_Amt { get; set; }
        public Nullable<decimal> TAX6_Rate { get; set; }
        public Nullable<decimal> TAX6_Amt { get; set; }
        public string TAX7 { get; set; }
        public Nullable<decimal> TAX7_Base_Amt { get; set; }
        public Nullable<decimal> TAX7_Rate { get; set; }
        public Nullable<decimal> TAX7_Amt { get; set; }
        public string TAX8 { get; set; }
        public Nullable<decimal> TAX8_Base_Amt { get; set; }
        public Nullable<decimal> TAX8_Rate { get; set; }
        public Nullable<decimal> TAX8_Amt { get; set; }
        public string TAX9 { get; set; }
        public Nullable<decimal> TAX9_Base_Amt { get; set; }
        public Nullable<decimal> TAX9_Rate { get; set; }
        public Nullable<decimal> TAX9_Amt { get; set; }
        public string TAX10 { get; set; }
        public Nullable<decimal> TAX10_Base_Amt { get; set; }
        public Nullable<decimal> TAX10_Rate { get; set; }
        public Nullable<decimal> TAX10_Amt { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> Disc_Per { get; set; }
        public Nullable<decimal> Disc_Amt { get; set; }
        public Nullable<decimal> Amt_Less_Discount { get; set; }
        public Nullable<decimal> Total_Tax_Amt { get; set; }
        public Nullable<decimal> Item_Net_Amt { get; set; }
        public int Status { get; set; }
        public Nullable<decimal> MRP { get; set; }
        public string Batch_No { get; set; }
        public Nullable<System.DateTime> MFG_Date { get; set; }
        public Nullable<System.DateTime> Expiry_Date { get; set; }
        public Nullable<decimal> Free_Qty { get; set; }
        public string Specification { get; set; }
        public string Remarks { get; set; }
        public Nullable<decimal> Assessable { get; set; }
        public Nullable<decimal> AssessableAmt { get; set; }
        public int Is_Mannual_Amt { get; set; }
        public string Price_code { get; set; }
        public Nullable<System.DateTime> Price_Date { get; set; }
        public Nullable<decimal> Abatement_Per { get; set; }
        public Nullable<decimal> Abatement_Amt { get; set; }
        public string Scheme_Code { get; set; }
        public string Scheme_Applicable { get; set; }
        public string Scheme_Item { get; set; }
        public int FOC_Item { get; set; }
        public Nullable<decimal> Item_Tax { get; set; }
        public Nullable<decimal> Total_MRP_Amt { get; set; }
        public Nullable<decimal> Total_Basic_Amt { get; set; }
        public Nullable<decimal> Total_Disc_Amt { get; set; }
        public Nullable<decimal> Cust_DiscountQty { get; set; }
        public Nullable<decimal> Cust_Discount { get; set; }
        public Nullable<decimal> Total_Cust_Discount { get; set; }
        public Nullable<decimal> Price_Amount1 { get; set; }
        public Nullable<decimal> Price_Amount2 { get; set; }
        public Nullable<decimal> Price_Amount3 { get; set; }
        public Nullable<decimal> Price_Amount4 { get; set; }
        public Nullable<decimal> Price_Amount5 { get; set; }
        public Nullable<decimal> Price_Amount6 { get; set; }
        public Nullable<decimal> Price_Amount7 { get; set; }
        public Nullable<decimal> Price_Amount8 { get; set; }
        public Nullable<decimal> Price_Amount9 { get; set; }
        public Nullable<decimal> Price_Amount10 { get; set; }
        public Nullable<decimal> ActualRate { get; set; }
        public Nullable<decimal> Item_Weight { get; set; }
        public Nullable<decimal> Conv_Factor { get; set; }
        public Nullable<decimal> TotalItem_Weight { get; set; }
        public string Markup_On { get; set; }
        public Nullable<decimal> Markup_Percent { get; set; }
        public Nullable<decimal> Landing_Cost { get; set; }
        public Nullable<decimal> HeadDiscAmt { get; set; }
        public Nullable<decimal> CustDiscPer { get; set; }
        public string CasdDiscScheme_Code { get; set; }
        public Nullable<decimal> Purchase_Cost { get; set; }
        public decimal OrgRate { get; set; }
        public string Bin_No { get; set; }
        public string PrincipleCode { get; set; }
        public string PrincipleDesc { get; set; }
        public string vendor_code { get; set; }
        public string vendor_desc { get; set; }
        public string Weight_UOM { get; set; }
        public Nullable<decimal> HeadDiscPer { get; set; }
        public Nullable<decimal> HeadDiscPerAmt { get; set; }
        public Nullable<decimal> ShipmentQty { get; set; }
        public string Dispatch_Code { get; set; }
        public Nullable<decimal> Commission_Rate { get; set; }
        public string Commission_Party { get; set; }
        public Nullable<decimal> Commission_Amt { get; set; }
        public Nullable<decimal> Amt_Less_Commission { get; set; }
        public string CSA_Booking_no { get; set; }
        public string CSA_Booking_Type { get; set; }
        public string Alt_UOM { get; set; }
        public Nullable<double> Alt_Qty { get; set; }
        public Nullable<System.DateTime> CSA_Booking_Date { get; set; }
        public Nullable<double> CSA_Booking_Rate { get; set; }
        public string CSA_Including_Tax { get; set; }
        public Nullable<double> CSA_Stock_Transfer_Rate { get; set; }
        public Nullable<double> CSA_Stock_Transfer_Amt { get; set; }
        public string CSA_Tax_Basis { get; set; }
        public Nullable<double> CSA_Gain_Loss { get; set; }
        public Nullable<double> CSA_Commision_Rate { get; set; }
        public Nullable<double> CSA_Other_Chrage { get; set; }
        public Nullable<double> CSA_Item_Pack_Size { get; set; }
        public string OrgUnit_code { get; set; }
        public Nullable<double> CSA_Commision_Amount { get; set; }
        public Nullable<double> CSA_Item_Master_Pack_Size { get; set; }
        public string Item_Group { get; set; }
        public string BOOK_QTY_UOM { get; set; }
        public double BOOK_Rate { get; set; }
        public string BOOK_RATE_UOM { get; set; }
        public string TAX_PAID { get; set; }
        public string Alternate_UOM { get; set; }
        public string RATE_UOM { get; set; }
        public string Scheme_Type { get; set; }
        public string Scheme_Item_Code { get; set; }
        public Nullable<double> Scheme_Qty { get; set; }
        public string Scheme_Item_UOM { get; set; }
        public string Cash_Scheme_Code { get; set; }
        public string Cash_Scheme_Type { get; set; }
        public Nullable<double> Cash_Scheme_Pers { get; set; }
        public Nullable<double> Cash_Scheme_Amount { get; set; }
        public Nullable<int> Scheme_Item_Line_No { get; set; }
        public string CSA_Commission_RS_PERS { get; set; }
        public Nullable<decimal> Alter_UnitQty { get; set; }
        public int Sampling { get; set; }
        public string Shipping_Mark { get; set; }
        public string Packing_Inst { get; set; }
        public string Container_No { get; set; }
        public string Packing_Instruction { get; set; }
        public string No_Kind_Package { get; set; }
        public string PI_Code { get; set; }
        public string Commercial_Inv_No { get; set; }
        public Nullable<double> Crate { get; set; }
        public string Delivery_Code { get; set; }
        public string Freight_Type { get; set; }
        public Nullable<double> Freight_Rate { get; set; }
        public Nullable<double> Freight_Amt { get; set; }
        public Nullable<double> AlternateRate { get; set; }
        public int SetTransferQtytoZero { get; set; }
        public string ItemwiseTaxCode { get; set; }
        public string Structure_Code { get; set; }
        public Nullable<double> CAN { get; set; }
        public Nullable<int> ManualCan { get; set; }
        public Nullable<decimal> ItemLeakageAmount { get; set; }
        public string VS_CashSchemeCode { get; set; }
        public Nullable<double> VS_Cash_Amt { get; set; }
        public Nullable<double> VS_ltrInCrate { get; set; }
    
        public virtual TSPL_DISPATCH_MASTER_FRESHSALE TSPL_DISPATCH_MASTER_FRESHSALE { get; set; }
        public virtual TSPL_EX_COMMERCIAL_INVOICE_HEAD TSPL_EX_COMMERCIAL_INVOICE_HEAD { get; set; }
        public virtual TSPL_EX_PI_HEAD TSPL_EX_PI_HEAD { get; set; }
        public virtual TSPL_SD_SALE_INVOICE_HEAD TSPL_SD_SALE_INVOICE_HEAD { get; set; }
        public virtual TSPL_SD_SHIPMENT_HEAD TSPL_SD_SHIPMENT_HEAD { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER1 { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER2 { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER3 { get; set; }
    }
}
