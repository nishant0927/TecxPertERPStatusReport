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
    
    public partial class TSPL_BANK_BOOK
    {
        public int Id { get; set; }
        public string SOURCEDOC_NO { get; set; }
        public Nullable<System.DateTime> SOURCEDOC_DATE { get; set; }
        public string SOURCE_CODE { get; set; }
        public string SOURCE_NAME { get; set; }
        public string BANK_CODE { get; set; }
        public string BANK_NAME { get; set; }
        public string LOC_CODE { get; set; }
        public string LOC_NAME { get; set; }
        public string BANKGL_Account_Code { get; set; }
        public string BANKGL_Account_Name { get; set; }
        public string GL_Account_Code { get; set; }
        public string GL_Account_Name { get; set; }
        public string CHEQUE_NO { get; set; }
        public string CHEQUE_DATE { get; set; }
        public string NARR_MASTER { get; set; }
        public string NARR_DETAIL { get; set; }
        public decimal Debit_Amount { get; set; }
        public decimal Credit_Amount { get; set; }
        public string DocType { get; set; }
        public string TransactionType { get; set; }
        public Nullable<int> line_No { get; set; }
        public string Currency { get; set; }
        public string Base_Currency { get; set; }
        public Nullable<double> Conversion_Rate { get; set; }
        public string Remarks { get; set; }
        public Nullable<decimal> Bank_charges { get; set; }
    }
}
