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
    
    public partial class TSPL_REMITTANCE_ENTRY
    {
        public string Remittance_Code { get; set; }
        public System.DateTime Remittance_Date { get; set; }
        public string Remit_TDS { get; set; }
        public string Bank_Code { get; set; }
        public Nullable<decimal> Amt_To_Remit { get; set; }
        public string Remit_To { get; set; }
        public System.DateTime AP_Posting_Date { get; set; }
        public System.DateTime AP_Payment_Date { get; set; }
        public string Payment_Code { get; set; }
        public string Cheque_No { get; set; }
        public Nullable<System.DateTime> Cheque_Date { get; set; }
        public string BSR_Code { get; set; }
        public string BSR_Name { get; set; }
        public string Challan_No { get; set; }
        public Nullable<System.DateTime> Challan_Date { get; set; }
        public string Posted { get; set; }
        public string Section_Code { get; set; }
        public string Section_Description { get; set; }
        public string Branch_Code { get; set; }
        public string Select_By { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modify_By { get; set; }
        public System.DateTime Modify_Date { get; set; }
        public string report_status { get; set; }
        public Nullable<decimal> Tax_Amount { get; set; }
        public string Description { get; set; }
        public string Comp_Code { get; set; }
    }
}
