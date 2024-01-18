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
    
    public partial class TSPL_Recurring_Payable_INVOICE_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_Recurring_Payable_INVOICE_HEAD()
        {
            this.tspl_Recurring_payable_invoice_detail = new HashSet<tspl_Recurring_payable_invoice_detail>();
        }
    
        public string Document_No { get; set; }
        public string Vendor_Control_AC { get; set; }
        public string Discount_GL_AC { get; set; }
        public string TAX1_GLAC { get; set; }
        public string TAX2_GLAC { get; set; }
        public string TAX3_GLAC { get; set; }
        public string TAX4_GLAC { get; set; }
        public string TAX5_GLAC { get; set; }
        public string TAX6_GLAC { get; set; }
        public string TAX7_GLAC { get; set; }
        public string TAX8_GLAC { get; set; }
        public string TAX9_GLAC { get; set; }
        public string TAX10_GLAC { get; set; }
        public string RefDocType { get; set; }
        public string RefDocNo { get; set; }
        public string Against_POInvoice_No { get; set; }
        public string Against_PurchaseReturn_No { get; set; }
        public string Against_Acquisition { get; set; }
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
        public decimal FIFO_Balance { get; set; }
        public string FIFO_KnockOff { get; set; }
        public Nullable<decimal> TAX1_GLAC_Amt { get; set; }
        public string TAX1_GLAC2 { get; set; }
        public Nullable<decimal> TAX1_GLAC2_Amt { get; set; }
        public string TAX1_GLAC3 { get; set; }
        public Nullable<decimal> TAX1_GLAC3_Amt { get; set; }
        public string TAX1_GLAC4 { get; set; }
        public Nullable<decimal> TAX1_GLAC4_Amt { get; set; }
        public string TAX1_GLAC5 { get; set; }
        public Nullable<decimal> TAX1_GLAC5_Amt { get; set; }
        public Nullable<decimal> TAX2_GLAC_Amt { get; set; }
        public string TAX2_GLAC2 { get; set; }
        public Nullable<decimal> TAX2_GLAC2_Amt { get; set; }
        public string TAX2_GLAC3 { get; set; }
        public Nullable<decimal> TAX2_GLAC3_Amt { get; set; }
        public string TAX2_GLAC4 { get; set; }
        public Nullable<decimal> TAX2_GLAC4_Amt { get; set; }
        public string TAX2_GLAC5 { get; set; }
        public Nullable<decimal> TAX2_GLAC5_Amt { get; set; }
        public Nullable<decimal> TAX3_GLAC_Amt { get; set; }
        public string TAX3_GLAC2 { get; set; }
        public Nullable<decimal> TAX3_GLAC2_Amt { get; set; }
        public string TAX3_GLAC3 { get; set; }
        public Nullable<decimal> TAX3_GLAC3_Amt { get; set; }
        public string TAX3_GLAC4 { get; set; }
        public Nullable<decimal> TAX3_GLAC4_Amt { get; set; }
        public string TAX3_GLAC5 { get; set; }
        public Nullable<decimal> TAX3_GLAC5_Amt { get; set; }
        public Nullable<decimal> TAX4_GLAC_Amt { get; set; }
        public string TAX4_GLAC2 { get; set; }
        public Nullable<decimal> TAX4_GLAC2_Amt { get; set; }
        public string TAX4_GLAC3 { get; set; }
        public Nullable<decimal> TAX4_GLAC3_Amt { get; set; }
        public string TAX4_GLAC4 { get; set; }
        public Nullable<decimal> TAX4_GLAC4_Amt { get; set; }
        public string TAX4_GLAC5 { get; set; }
        public Nullable<decimal> TAX4_GLAC5_Amt { get; set; }
        public Nullable<decimal> TAX5_GLAC_Amt { get; set; }
        public string TAX5_GLAC2 { get; set; }
        public Nullable<decimal> TAX5_GLAC2_Amt { get; set; }
        public string TAX5_GLAC3 { get; set; }
        public Nullable<decimal> TAX5_GLAC3_Amt { get; set; }
        public string TAX5_GLAC4 { get; set; }
        public Nullable<decimal> TAX5_GLAC4_Amt { get; set; }
        public string TAX5_GLAC5 { get; set; }
        public Nullable<decimal> TAX5_GLAC5_Amt { get; set; }
        public Nullable<decimal> TAX6_GLAC_Amt { get; set; }
        public string TAX6_GLAC2 { get; set; }
        public Nullable<decimal> TAX6_GLAC2_Amt { get; set; }
        public string TAX6_GLAC3 { get; set; }
        public Nullable<decimal> TAX6_GLAC3_Amt { get; set; }
        public string TAX6_GLAC4 { get; set; }
        public Nullable<decimal> TAX6_GLAC4_Amt { get; set; }
        public string TAX6_GLAC5 { get; set; }
        public Nullable<decimal> TAX6_GLAC5_Amt { get; set; }
        public Nullable<decimal> TAX7_GLAC_Amt { get; set; }
        public string TAX7_GLAC2 { get; set; }
        public Nullable<decimal> TAX7_GLAC2_Amt { get; set; }
        public string TAX7_GLAC3 { get; set; }
        public Nullable<decimal> TAX7_GLAC3_Amt { get; set; }
        public string TAX7_GLAC4 { get; set; }
        public Nullable<decimal> TAX7_GLAC4_Amt { get; set; }
        public string TAX7_GLAC5 { get; set; }
        public Nullable<decimal> TAX7_GLAC5_Amt { get; set; }
        public Nullable<decimal> TAX8_GLAC_Amt { get; set; }
        public string TAX8_GLAC2 { get; set; }
        public Nullable<decimal> TAX8_GLAC2_Amt { get; set; }
        public string TAX8_GLAC3 { get; set; }
        public Nullable<decimal> TAX8_GLAC3_Amt { get; set; }
        public string TAX8_GLAC4 { get; set; }
        public Nullable<decimal> TAX8_GLAC4_Amt { get; set; }
        public string TAX8_GLAC5 { get; set; }
        public Nullable<decimal> TAX8_GLAC5_Amt { get; set; }
        public Nullable<decimal> TAX9_GLAC_Amt { get; set; }
        public string TAX9_GLAC2 { get; set; }
        public Nullable<decimal> TAX9_GLAC2_Amt { get; set; }
        public string TAX9_GLAC3 { get; set; }
        public Nullable<decimal> TAX9_GLAC3_Amt { get; set; }
        public string TAX9_GLAC4 { get; set; }
        public Nullable<decimal> TAX9_GLAC4_Amt { get; set; }
        public string TAX9_GLAC5 { get; set; }
        public Nullable<decimal> TAX9_GLAC5_Amt { get; set; }
        public Nullable<decimal> TAX10_GLAC_Amt { get; set; }
        public string TAX10_GLAC2 { get; set; }
        public Nullable<decimal> TAX10_GLAC2_Amt { get; set; }
        public string TAX10_GLAC3 { get; set; }
        public Nullable<decimal> TAX10_GLAC3_Amt { get; set; }
        public string TAX10_GLAC4 { get; set; }
        public Nullable<decimal> TAX10_GLAC4_Amt { get; set; }
        public string TAX10_GLAC5 { get; set; }
        public Nullable<decimal> TAX10_GLAC5_Amt { get; set; }
        public string Loc_Code { get; set; }
        public Nullable<decimal> Empty_Amount { get; set; }
        public string Empty_Account { get; set; }
        public Nullable<decimal> Total_Landed_Amt { get; set; }
        public int is_For_TDS { get; set; }
        public string CURRENCY_CODE { get; set; }
        public decimal ConvRate { get; set; }
        public Nullable<System.DateTime> ApplicableFrom { get; set; }
        public string PROJECT_ID { get; set; }
        public string Approval_Level { get; set; }
        public string Level1_User { get; set; }
        public string Level2_User { get; set; }
        public string Level3_User { get; set; }
        public string Invoice_Type { get; set; }
        public string entry_Type { get; set; }
        public string Against_MillkPurchaseInvoice_No { get; set; }
        public string Against_BulkMillkPurchaseInvoice_No { get; set; }
        public string Against_VSPItemIssue_No { get; set; }
        public decimal RoundOffAmount { get; set; }
        public int Is_Security { get; set; }
        public int is_For_Provision { get; set; }
        public Nullable<System.DateTime> Prov_From_Date { get; set; }
        public Nullable<System.DateTime> Prov_To_Date { get; set; }
        public double Prov_Amt { get; set; }
        public int isDeduction { get; set; }
        public string Deduction_Code { get; set; }
        public string Deduction_Desc { get; set; }
        public string Irregular_Loc_Code { get; set; }
        public string Is_ProRated { get; set; }
        public string Vendor_Code { get; set; }
        public string Vendor_Name { get; set; }
        public string Vendor_Invoice_No { get; set; }
        public string Vendor_Invoice_Date { get; set; }
        public string Invoice_Entry_Date { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string Account_Set { get; set; }
        public string Document_Type { get; set; }
        public string PO_Number { get; set; }
        public string Order_No { get; set; }
        public decimal Document_Total { get; set; }
        public string On_Hold { get; set; }
        public string Remarks { get; set; }
        public string Description { get; set; }
        public string Tax_Group { get; set; }
        public string TAX1 { get; set; }
        public Nullable<decimal> TAX1_Rate { get; set; }
        public Nullable<decimal> TAX1_Amt { get; set; }
        public string TAX2 { get; set; }
        public Nullable<decimal> TAX2_Rate { get; set; }
        public Nullable<decimal> TAX2_Amt { get; set; }
        public string TAX3 { get; set; }
        public Nullable<decimal> TAX3_Rate { get; set; }
        public Nullable<decimal> TAX3_Amt { get; set; }
        public string TAX4 { get; set; }
        public Nullable<decimal> TAX4_Rate { get; set; }
        public Nullable<decimal> TAX4_Amt { get; set; }
        public string TAX5 { get; set; }
        public Nullable<decimal> TAX5_Rate { get; set; }
        public Nullable<decimal> TAX5_Amt { get; set; }
        public string TAX6 { get; set; }
        public Nullable<decimal> TAX6_Rate { get; set; }
        public Nullable<decimal> TAX6_Amt { get; set; }
        public string TAX7 { get; set; }
        public Nullable<decimal> TAX7_Rate { get; set; }
        public Nullable<decimal> TAX7_Amt { get; set; }
        public string TAX8 { get; set; }
        public Nullable<decimal> TAX8_Rate { get; set; }
        public Nullable<decimal> TAX8_Amt { get; set; }
        public string TAX9 { get; set; }
        public Nullable<decimal> TAX9_Rate { get; set; }
        public Nullable<decimal> TAX9_Amt { get; set; }
        public string TAX10 { get; set; }
        public Nullable<decimal> TAX10_Rate { get; set; }
        public Nullable<decimal> TAX10_Amt { get; set; }
        public Nullable<decimal> Total_Tax { get; set; }
        public Nullable<decimal> Tax1_BAmount { get; set; }
        public Nullable<decimal> Tax2_BAmount { get; set; }
        public Nullable<decimal> Tax3_BAmount { get; set; }
        public Nullable<decimal> Tax4_BAmount { get; set; }
        public Nullable<decimal> Tax5_BAmount { get; set; }
        public Nullable<decimal> Tax6_BAmount { get; set; }
        public Nullable<decimal> Tax7_BAmount { get; set; }
        public Nullable<decimal> Tax8_BAmount { get; set; }
        public Nullable<decimal> Tax9_BAmount { get; set; }
        public Nullable<decimal> Tax10_BAmount { get; set; }
        public Nullable<decimal> Balance_Amt { get; set; }
        public string Terms_Code { get; set; }
        public string Terms_Description { get; set; }
        public string Due_Date { get; set; }
        public Nullable<decimal> Discount_Percentage { get; set; }
        public Nullable<decimal> Discount_Base { get; set; }
        public Nullable<decimal> Discount_Amount { get; set; }
        public Nullable<decimal> Amount_Less_Discount { get; set; }
        public Nullable<decimal> TDS_Base_Actual_Amount { get; set; }
        public Nullable<decimal> TDS_Base_Calculated_Amount { get; set; }
        public Nullable<decimal> TDS_Percentage { get; set; }
        public Nullable<decimal> TDS_Actual_Amount { get; set; }
        public Nullable<decimal> TDS_Calculated_Amount { get; set; }
        public string Nature_of_deduction { get; set; }
        public string Branch_Code { get; set; }
        public string Section_Code { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modify_By { get; set; }
        public string Modify_Date { get; set; }
        public string Comp_Code { get; set; }
        public string RemitanceBranch_GL_AC { get; set; }
        public string Expiration_Date { get; set; }
        public string Expiration_Type { get; set; }
        public Nullable<decimal> Expiration_Amount { get; set; }
        public string Scheduler_Code { get; set; }
        public string Is_Cancelled { get; set; }
        public string Last_Invoice_Date { get; set; }
    
        public virtual TSPL_CURRENCY_MASTER TSPL_CURRENCY_MASTER { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS1 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS2 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS3 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS4 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS5 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS6 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS7 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS8 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS9 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS10 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS11 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS12 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS13 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS14 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS15 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS16 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS17 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS18 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS19 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS20 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS21 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS22 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS23 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS24 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS25 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS26 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS27 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS28 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS29 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS30 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS31 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS32 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS33 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS34 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS35 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS36 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS37 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS38 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS39 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS40 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS41 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS42 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS43 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS44 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS45 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS46 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS47 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS48 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS49 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS50 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS51 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS52 { get; set; }
        public virtual TSPL_PJC_PROJECT TSPL_PJC_PROJECT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tspl_Recurring_payable_invoice_detail> tspl_Recurring_payable_invoice_detail { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER1 { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER2 { get; set; }
        public virtual Tspl_Recurring_Scheduler_Head Tspl_Recurring_Scheduler_Head { get; set; }
    }
}