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
    
    public partial class TSPL_SCRAPINVOICE_HEAD
    {
        public string invoice_No { get; set; }
        public string shipment_No { get; set; }
        public int Status { get; set; }
        public string Po_No { get; set; }
        public string cust_Code { get; set; }
        public string cust_Name { get; set; }
        public Nullable<System.DateTime> shipment_Date { get; set; }
        public Nullable<System.DateTime> posting_Date { get; set; }
        public Nullable<System.DateTime> expship_Date { get; set; }
        public string Loc_Code { get; set; }
        public string Loc_Name { get; set; }
        public string ToLoc_Code { get; set; }
        public int CreateInvoice { get; set; }
        public string Description { get; set; }
        public string Reff { get; set; }
        public string Tax_Group { get; set; }
        public string Tax_Desc { get; set; }
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
        public Nullable<decimal> Add_Amt { get; set; }
        public Nullable<decimal> Before_Add_Amt { get; set; }
        public Nullable<decimal> Discount_Base { get; set; }
        public Nullable<decimal> Discount_Amt { get; set; }
        public Nullable<decimal> Amount_Less_Discount { get; set; }
        public Nullable<decimal> Total_Tax_Amt { get; set; }
        public Nullable<decimal> ship_Total_Amt { get; set; }
        public Nullable<decimal> Doc_Amt { get; set; }
        public string Comp_Code { get; set; }
        public string Terms_Code { get; set; }
        public string Due_Date { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modify_By { get; set; }
        public string Modify_Date { get; set; }
        public int ispost { get; set; }
        public string AddCode1 { get; set; }
        public string AddDesc1 { get; set; }
        public Nullable<decimal> AddAmt1 { get; set; }
        public string AddCode2 { get; set; }
        public string AddDesc2 { get; set; }
        public Nullable<decimal> AddAmt2 { get; set; }
        public string AddCode3 { get; set; }
        public string AddDesc3 { get; set; }
        public Nullable<decimal> AddAmt3 { get; set; }
        public string AddCode4 { get; set; }
        public string AddDesc4 { get; set; }
        public Nullable<decimal> AddAmt4 { get; set; }
        public string AddCode5 { get; set; }
        public string AddDesc5 { get; set; }
        public Nullable<decimal> AddAmt5 { get; set; }
        public string AddCode6 { get; set; }
        public string AddDesc6 { get; set; }
        public Nullable<decimal> AddAmt6 { get; set; }
        public string AddCode7 { get; set; }
        public string AddDesc7 { get; set; }
        public Nullable<decimal> AddAmt7 { get; set; }
        public string AddCode8 { get; set; }
        public string AddDesc8 { get; set; }
        public Nullable<decimal> AddAmt8 { get; set; }
        public string AddCode9 { get; set; }
        public string AddDesc9 { get; set; }
        public Nullable<decimal> AddAmt9 { get; set; }
        public string AddCode10 { get; set; }
        public string AddDesc10 { get; set; }
        public Nullable<decimal> AddAmt10 { get; set; }
        public Nullable<decimal> Balance_Amt { get; set; }
        public string NRG_No { get; set; }
        public int Inter_Branch { get; set; }
        public string Invoice_Type { get; set; }
        public int is_Asset_Type { get; set; }
        public string Transporter_Name_Manual { get; set; }
        public string VAT_InvoiceNo { get; set; }
        public string VatInvoice_Type { get; set; }
        public Nullable<decimal> Total_Gross_Weight { get; set; }
        public Nullable<decimal> Total_Net_Weight { get; set; }
        public string Doc_Type { get; set; }
        public Nullable<decimal> RoundOffAmount { get; set; }
        public int Is_Taxable { get; set; }
        public string EWayBillNo { get; set; }
        public Nullable<System.DateTime> EWayBillDate { get; set; }
        public string EInvoice_Type { get; set; }
        public string IRN_No { get; set; }
        public string QR_Code { get; set; }
        public string Ack_No { get; set; }
        public Nullable<System.DateTime> Ack_Date { get; set; }
        public byte[] BarCode_Img { get; set; }
        public Nullable<System.DateTime> EInvoice_Posting_Date { get; set; }
        public string EWayBillRemarks { get; set; }
        public Nullable<System.DateTime> EWayBillValidDate { get; set; }
        public int Freight_Distance { get; set; }
        public string Transport_code { get; set; }
        public string Vehicle_Id { get; set; }
        public string Vehicle_code { get; set; }
        public Nullable<double> ActualTCSBaseAmount { get; set; }
        public Nullable<double> ChangedTCSBaseAmount { get; set; }
    }
}