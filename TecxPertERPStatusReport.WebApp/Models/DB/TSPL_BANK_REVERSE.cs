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
    
    public partial class TSPL_BANK_REVERSE
    {
        public string Reverse_Code { get; set; }
        public System.DateTime Reversal_Date { get; set; }
        public string Bank_Code { get; set; }
        public string Back_Acc_No { get; set; }
        public string Source_Type { get; set; }
        public string Reverse_Document { get; set; }
        public string Reason { get; set; }
        public string Vendor_Code { get; set; }
        public string Vendor_Name { get; set; }
        public string Cust_Code { get; set; }
        public string Cust_Name { get; set; }
        public string Cheque_No { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime Pay_Rec_Date { get; set; }
        public string Post { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modify_By { get; set; }
        public string Modify_Date { get; set; }
        public string Comp_Code { get; set; }
        public string Document_No { get; set; }
        public string IsChequeBounce { get; set; }
        public decimal Reverse_TDS_Amount { get; set; }
    
        public virtual TSPL_BANK_MASTER TSPL_BANK_MASTER { get; set; }
    }
}
