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
    
    public partial class TEMP_PR_CHANGE_PARY_DATE_AMOUNT
    {
        public int SNo { get; set; }
        public string DocumentNo { get; set; }
        public string DocumentType { get; set; }
        public System.DateTime DocumentDate { get; set; }
        public decimal Amount { get; set; }
        public string ACode { get; set; }
        public string AName { get; set; }
        public Nullable<int> Status { get; set; }
        public string NewDocumentNo { get; set; }
        public string ERROR { get; set; }
    }
}
