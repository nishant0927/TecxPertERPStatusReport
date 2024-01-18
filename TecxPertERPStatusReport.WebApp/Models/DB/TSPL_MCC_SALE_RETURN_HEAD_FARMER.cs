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
    
    public partial class TSPL_MCC_SALE_RETURN_HEAD_FARMER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_MCC_SALE_RETURN_HEAD_FARMER()
        {
            this.TSPL_MCC_SALE_RETURN_DETAIL_FARMER = new HashSet<TSPL_MCC_SALE_RETURN_DETAIL_FARMER>();
        }
    
        public string Document_Code { get; set; }
        public System.DateTime Document_Date { get; set; }
        public string Farmer_Code { get; set; }
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
        public string Against_Invoice_No { get; set; }
        public int Tax_Calculation_Type { get; set; }
        public int Is_Internal { get; set; }
        public string Salesman_Code { get; set; }
        public string Salesman_Name { get; set; }
        public string CURRENCY_CODE { get; set; }
        public decimal ConvRate { get; set; }
        public Nullable<System.DateTime> ApplicableFrom { get; set; }
        public string PROJECT_ID { get; set; }
        public string Price_code { get; set; }
        public string Price_Group_Code { get; set; }
        public string Route_No { get; set; }
        public string Route_Desc { get; set; }
        public Nullable<decimal> HeadDisc_Per { get; set; }
        public Nullable<decimal> HeadDisc_PerAmt { get; set; }
        public Nullable<decimal> HeadDisc_Amt { get; set; }
        public Nullable<decimal> TotCashDiscAmt { get; set; }
        public string Invoice_Type { get; set; }
        public string Return_Type { get; set; }
        public string Cust_PO_No { get; set; }
        public string Approval_Level { get; set; }
        public string Level1_User { get; set; }
        public string Level2_User { get; set; }
        public string Level3_User { get; set; }
        public int Is_Approved { get; set; }
        public double CrateQty { get; set; }
        public string Trans_Type { get; set; }
        public int SO_Validity { get; set; }
        public int Commission_Apply { get; set; }
        public Nullable<double> Vehicle_Capacity { get; set; }
        public string Dispatch_Terms { get; set; }
        public string Payment_Terms { get; set; }
        public int Dispatch_Period { get; set; }
        public decimal RoundOffAmount { get; set; }
        public string CSA_Loc_Code { get; set; }
        public string Document_Type { get; set; }
        public string Incentive_Declaration { get; set; }
        public Nullable<System.DateTime> Cust_PO_Date { get; set; }
        public string BANK_CODE { get; set; }
        public string BRANCH_CODE { get; set; }
        public string Import_Export_No { get; set; }
        public string Exporter_Ref_No { get; set; }
        public string Pre_Carriage_By { get; set; }
        public string Final_Destination { get; set; }
        public string Final_Destination_Country { get; set; }
        public string Origin_Country { get; set; }
        public string Discharge_Port { get; set; }
        public string Commission_Paid { get; set; }
        public Nullable<double> Commission_Amount { get; set; }
        public string Comm_Amt_Type { get; set; }
        public string Commission_Payee_Code { get; set; }
        public string Commission_Instruction { get; set; }
        public string EX_Term_Code { get; set; }
        public Nullable<double> Advance_Percentage { get; set; }
        public string Loading_Port { get; set; }
        public string Vessel_Flight_No { get; set; }
        public string CHA_Code { get; set; }
        public Nullable<double> CHA_Charge_Amount { get; set; }
        public Nullable<double> CHA_FOB_Amount { get; set; }
        public Nullable<double> CHA_Frieght_Kg_Amount { get; set; }
        public Nullable<double> CHA_Basic_Freight_Amount { get; set; }
        public string MT_Against_PO { get; set; }
        public Nullable<System.DateTime> MT_Against_PO_Date { get; set; }
        public string Bin_No { get; set; }
        public Nullable<double> CrateMan { get; set; }
        public Nullable<double> jaali { get; set; }
        public Nullable<double> Box { get; set; }
        public Nullable<decimal> Balance_Amt { get; set; }
    
        public virtual TSPL_BANK_MASTER TSPL_BANK_MASTER { get; set; }
        public virtual TSPL_CURRENCY_MASTER TSPL_CURRENCY_MASTER { get; set; }
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER { get; set; }
        public virtual TSPL_VENDOR_MASTER TSPL_VENDOR_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MCC_SALE_RETURN_DETAIL_FARMER> TSPL_MCC_SALE_RETURN_DETAIL_FARMER { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER1 { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER2 { get; set; }
        public virtual TSPL_PURCHASE_ORDER_HEAD TSPL_PURCHASE_ORDER_HEAD { get; set; }
        public virtual TSPL_PJC_PROJECT TSPL_PJC_PROJECT { get; set; }
    }
}
