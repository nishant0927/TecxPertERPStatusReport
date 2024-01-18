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
    
    public partial class TSPL_TRANSFER_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_TRANSFER_HEAD()
        {
            this.TSPL_TRANSFER_DETAIL = new HashSet<TSPL_TRANSFER_DETAIL>();
        }
    
        public string Transfer_No { get; set; }
        public System.DateTime Transfer_Date { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string Transfer_Type { get; set; }
        public string Load_Out_No { get; set; }
        public string From_Location { get; set; }
        public string To_Location { get; set; }
        public System.DateTime Price_Date { get; set; }
        public string Tax_Group { get; set; }
        public string Reference { get; set; }
        public string description { get; set; }
        public string Route_No { get; set; }
        public string Salesmancode { get; set; }
        public string Price_Code { get; set; }
        public string Vehicle_Code { get; set; }
        public string Vehicle_No { get; set; }
        public string Mode_Of_Transport { get; set; }
        public string Km_Reading { get; set; }
        public string TAX1 { get; set; }
        public Nullable<decimal> TAX1_Rate { get; set; }
        public Nullable<decimal> TAX1_Amt { get; set; }
        public Nullable<decimal> Tax1_Assessable_Amt { get; set; }
        public string TAX2 { get; set; }
        public Nullable<decimal> TAX2_Rate { get; set; }
        public Nullable<decimal> TAX2_Amt { get; set; }
        public Nullable<decimal> Tax2_Assessable_Amt { get; set; }
        public string TAX3 { get; set; }
        public Nullable<decimal> TAX3_Rate { get; set; }
        public Nullable<decimal> TAX3_Amt { get; set; }
        public Nullable<decimal> Tax3_Assessable_Amt { get; set; }
        public string TAX4 { get; set; }
        public Nullable<decimal> TAX4_Rate { get; set; }
        public Nullable<decimal> TAX4_Amt { get; set; }
        public Nullable<decimal> Tax4_Assessable_Amt { get; set; }
        public string TAX5 { get; set; }
        public Nullable<decimal> TAX5_Rate { get; set; }
        public Nullable<decimal> TAX5_Amt { get; set; }
        public Nullable<decimal> Tax5_Assessable_Amt { get; set; }
        public string TAX6 { get; set; }
        public Nullable<decimal> TAX6_Rate { get; set; }
        public Nullable<decimal> TAX6_Amt { get; set; }
        public Nullable<decimal> Tax6_Assessable_Amt { get; set; }
        public string TAX7 { get; set; }
        public Nullable<decimal> TAX7_Rate { get; set; }
        public Nullable<decimal> TAX7_Amt { get; set; }
        public Nullable<decimal> Tax7_Assessable_Amt { get; set; }
        public string TAX8 { get; set; }
        public Nullable<decimal> TAX8_Rate { get; set; }
        public Nullable<decimal> TAX8_Amt { get; set; }
        public Nullable<decimal> Tax8_Assessable_Amt { get; set; }
        public string TAX9 { get; set; }
        public Nullable<decimal> TAX9_Rate { get; set; }
        public Nullable<decimal> TAX9_Amt { get; set; }
        public Nullable<decimal> Tax9_Assessable_Amt { get; set; }
        public string TAX10 { get; set; }
        public Nullable<decimal> TAX10_Rate { get; set; }
        public Nullable<decimal> TAX10_Amt { get; set; }
        public Nullable<decimal> Tax10_Assessable_Amt { get; set; }
        public decimal Item_Amount { get; set; }
        public Nullable<decimal> Total_Tax_Amount { get; set; }
        public decimal Total_Item_Amount { get; set; }
        public string Post { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modify_By { get; set; }
        public System.DateTime Modify_Date { get; set; }
        public string Level1_User_code { get; set; }
        public string Level2_User_code { get; set; }
        public string Level3_User_code { get; set; }
        public string Level4_User_code { get; set; }
        public string Level5_User_code { get; set; }
        public string Comp_Code { get; set; }
        public Nullable<System.DateTime> Load_Out_Date { get; set; }
        public string Is_Shipped { get; set; }
        public string Trip_No { get; set; }
        public string Item_Type { get; set; }
        public Nullable<System.TimeSpan> Date_Time_Removal { get; set; }
        public string Is_Complete { get; set; }
        public string HOS { get; set; }
        public string TDM { get; set; }
        public string ADC { get; set; }
        public string CE { get; set; }
        public Nullable<System.DateTime> EntryDateTime { get; set; }
        public string FromLoc_Desc { get; set; }
        public string ToLoc_Desc { get; set; }
        public string Route_Desc { get; set; }
        public string Price_Desc { get; set; }
        public string Vehicle_Desc { get; set; }
        public string Printed { get; set; }
        public decimal Total_Transfer_Amount { get; set; }
        public Nullable<decimal> Total_Transfer_QtyInCase { get; set; }
        public string Quick_Settlement { get; set; }
        public int Sale_Invoice_Completed { get; set; }
        public int Is_AgainstFormF { get; set; }
        public string Location_Type { get; set; }
        public string Route_Type_Id { get; set; }
        public string Tax_Group_Type { get; set; }
        public string Trans_Type { get; set; }
        public string Reference_Doc_No { get; set; }
        public int is_Auto_Created_Trans { get; set; }
        public decimal Total_Basic_Amt { get; set; }
        public string Against_Indent_No { get; set; }
        public string Reference_Doc_No_DPL { get; set; }
        public string Secondary_Code { get; set; }
    
        public virtual TSPL_INDENT_HEAD TSPL_INDENT_HEAD { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_TRANSFER_DETAIL> TSPL_TRANSFER_DETAIL { get; set; }
    }
}
