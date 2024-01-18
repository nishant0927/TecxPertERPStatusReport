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
    
    public partial class TSPL_ACQUISITION_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_ACQUISITION_HEAD()
        {
            this.TSPL_ACQUISITION_DETAIL = new HashSet<TSPL_ACQUISITION_DETAIL>();
            this.TSPL_ASSET_ASSEMBLE_DETAIL = new HashSet<TSPL_ASSET_ASSEMBLE_DETAIL>();
            this.TSPL_ASSET_ACCOUNT_CHANGE_HEAD = new HashSet<TSPL_ASSET_ACCOUNT_CHANGE_HEAD>();
        }
    
        public string Acquisition_Code { get; set; }
        public System.DateTime Acquisition_Date { get; set; }
        public string PO_No { get; set; }
        public string Vendor_Code { get; set; }
        public string Description { get; set; }
        public string Remarks { get; set; }
        public int Status { get; set; }
        public int On_Hold { get; set; }
        public string Tax_Group { get; set; }
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
        public Nullable<decimal> Total_Amt { get; set; }
        public Nullable<decimal> Total_Tax_Amt { get; set; }
        public Nullable<decimal> Net_Amt { get; set; }
        public Nullable<System.DateTime> Post_Date { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modify_By { get; set; }
        public System.DateTime Modify_Date { get; set; }
        public string Loc_Code { get; set; }
        public int Is_Visi_Type { get; set; }
        public string SRN_No { get; set; }
        public string comp_code { get; set; }
        public string Vendor_Invoice_No { get; set; }
        public string Status_New_Old { get; set; }
        public string Templete_Code { get; set; }
        public int IS_Assemble { get; set; }
        public string Acquisition_Type { get; set; }
        public Nullable<decimal> TDS_Base_Actual_Amount { get; set; }
        public Nullable<decimal> TDS_Base_Calculated_Amount { get; set; }
        public Nullable<decimal> TDS_Percentage { get; set; }
        public Nullable<decimal> TDS_Actual_Amount { get; set; }
        public Nullable<decimal> TDS_Calculated_Amount { get; set; }
        public string Nature_of_deduction { get; set; }
        public string Branch_Code { get; set; }
        public string Section_Code { get; set; }
        public Nullable<decimal> Balance_Amt { get; set; }
        public string PI_No { get; set; }
        public string CapexSub_Code { get; set; }
        public string Capex_Code { get; set; }
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
        public Nullable<double> Tax_Recoverable { get; set; }
        public Nullable<double> Tax_Non_Recoverable { get; set; }
        public string ASSEMBLE_CODE { get; set; }
        public Nullable<bool> Opening_Assemble { get; set; }
        public Nullable<decimal> Opening_Assemble_Amt { get; set; }
        public Nullable<bool> Opening_Direct { get; set; }
    
        public virtual TSPL_ACQUISITION_ASSET_MERGE_DETAIL TSPL_ACQUISITION_ASSET_MERGE_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ACQUISITION_DETAIL> TSPL_ACQUISITION_DETAIL { get; set; }
        public virtual TSPL_PI_HEAD TSPL_PI_HEAD { get; set; }
        public virtual TSPL_PURCHASE_ORDER_HEAD TSPL_PURCHASE_ORDER_HEAD { get; set; }
        public virtual TSPL_SRN_HEAD TSPL_SRN_HEAD { get; set; }
        public virtual TSPL_FA_TEMPLATE_MASTER TSPL_FA_TEMPLATE_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ASSET_ASSEMBLE_DETAIL> TSPL_ASSET_ASSEMBLE_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ASSET_ACCOUNT_CHANGE_HEAD> TSPL_ASSET_ACCOUNT_CHANGE_HEAD { get; set; }
    }
}