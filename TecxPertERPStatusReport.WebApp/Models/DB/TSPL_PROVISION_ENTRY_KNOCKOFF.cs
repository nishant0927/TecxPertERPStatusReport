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
    
    public partial class TSPL_PROVISION_ENTRY_KNOCKOFF
    {
        public string Document_No { get; set; }
        public string AP_Invoice_No { get; set; }
        public string Provision_No { get; set; }
        public Nullable<decimal> Balance_Amount { get; set; }
        public Nullable<decimal> Knockoff_Amount { get; set; }
        public string Invoice_No { get; set; }
    
        public virtual TSPL_PROVISION_ENTRY TSPL_PROVISION_ENTRY { get; set; }
        public virtual TSPL_VENDOR_INVOICE_HEAD TSPL_VENDOR_INVOICE_HEAD { get; set; }
    }
}