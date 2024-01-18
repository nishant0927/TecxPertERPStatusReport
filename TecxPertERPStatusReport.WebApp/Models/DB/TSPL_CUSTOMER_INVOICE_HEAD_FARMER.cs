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
    
    public partial class TSPL_CUSTOMER_INVOICE_HEAD_FARMER
    {
        public string Document_No { get; set; }
        public System.DateTime Document_Date { get; set; }
        public string Document_Type { get; set; }
        public Nullable<decimal> Document_Total { get; set; }
        public string Farmer_Code { get; set; }
        public string Farmer_Name { get; set; }
        public string Loc_Code { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string Account_Set { get; set; }
        public string Order_No { get; set; }
        public int On_Hold { get; set; }
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
        public Nullable<System.DateTime> Due_Date { get; set; }
        public Nullable<decimal> Discount_Percentage { get; set; }
        public Nullable<decimal> Discount_Base { get; set; }
        public Nullable<decimal> Discount_Amount { get; set; }
        public Nullable<decimal> Amount_Less_Discount { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modify_By { get; set; }
        public System.DateTime Modify_Date { get; set; }
        public string Comp_Code { get; set; }
        public string Customer_Control_AC { get; set; }
        public string TAX1_GLAC { get; set; }
        public string TAX2_GLAC { get; set; }
        public string TAX3_GLAC { get; set; }
        public string TAX4_GLAC { get; set; }
        public string TAX5_GLAC { get; set; }
        public string TAX6_GLAC { get; set; }
        public string TAX7_GLAC { get; set; }
        public decimal TAX1_ExciseFOCAmt { get; set; }
        public decimal TAX2_ExciseFOCAmt { get; set; }
        public decimal TAX3_ExciseFOCAmt { get; set; }
        public decimal TAX4_ExciseFOCAmt { get; set; }
        public string TAX8_GLAC { get; set; }
        public string TAX9_GLAC { get; set; }
        public string TAX10_GLAC { get; set; }
        public string Discount_GL_AC { get; set; }
        public string RefDocType { get; set; }
        public string RefDocNo { get; set; }
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
        public int Status { get; set; }
        public string AgainstScrap { get; set; }
        public string Against_Sale_No { get; set; }
        public decimal FIFO_Balance { get; set; }
        public string FIFO_KnockOff { get; set; }
        public string Against_Sale_Return_No { get; set; }
        public string CURRENCY_CODE { get; set; }
        public decimal ConvRate { get; set; }
        public Nullable<System.DateTime> ApplicableFrom { get; set; }
        public string PROJECT_ID { get; set; }
        public string Approval_Level { get; set; }
        public string Level1_User { get; set; }
        public string Level2_User { get; set; }
        public string Level3_User { get; set; }
        public string Return_Type { get; set; }
        public string Trans_Type { get; set; }
        public Nullable<decimal> RoundOffAmount { get; set; }
        public string Against_MCC_Material_Sale_Return { get; set; }
        public string Against_VCGL { get; set; }
        public string SecurityDeposit { get; set; }
        public string SecurityDepositType { get; set; }
        public string Against_Service_Visit_Code { get; set; }
        public string Against_Asset_Disposal { get; set; }
    
        public virtual TSPL_CURRENCY_MASTER TSPL_CURRENCY_MASTER { get; set; }
        public virtual TSPL_MP_MASTER TSPL_MP_MASTER { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER1 { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER2 { get; set; }
        public virtual TSPL_PJC_PROJECT TSPL_PJC_PROJECT { get; set; }
    }
}
