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
    
    public partial class TSPL_MULTIPLE_DEDUCTION_DETAIL
    {
        public string Document_No { get; set; }
        public int Line_No { get; set; }
        public string Vendor_Code { get; set; }
        public int GSTRegistered { get; set; }
        public string Vendor_Name { get; set; }
        public string Vendor_Control_AC { get; set; }
        public string Account_Set { get; set; }
        public string Terms_Code { get; set; }
        public string Terms_Description { get; set; }
        public string Due_Date { get; set; }
        public string DeductionCode { get; set; }
        public string Deduction_Desc { get; set; }
        public string GL_Account_Code { get; set; }
        public string GL_Account_Desc { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string Remarks { get; set; }
        public string Against_Deduction_DocNo { get; set; }
    
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS { get; set; }
        public virtual TSPL_MULTIPLE_DEDUCTION_HEAD TSPL_MULTIPLE_DEDUCTION_HEAD { get; set; }
        public virtual TSPL_VENDOR_INVOICE_HEAD TSPL_VENDOR_INVOICE_HEAD { get; set; }
    }
}
