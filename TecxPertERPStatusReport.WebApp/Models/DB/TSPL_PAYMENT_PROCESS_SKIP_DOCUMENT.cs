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
    
    public partial class TSPL_PAYMENT_PROCESS_SKIP_DOCUMENT
    {
        public string Doc_No { get; set; }
        public string Vendor_Code { get; set; }
        public string Source_Doc_No { get; set; }
        public string Source_Doc_Type { get; set; }
        public Nullable<decimal> Balance_Amount { get; set; }
    
        public virtual TSPL_PAYMENT_PROCESS_HEAD TSPL_PAYMENT_PROCESS_HEAD { get; set; }
    }
}
