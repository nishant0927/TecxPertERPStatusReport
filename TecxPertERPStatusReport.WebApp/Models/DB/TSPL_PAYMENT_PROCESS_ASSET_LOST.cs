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
    
    public partial class TSPL_PAYMENT_PROCESS_ASSET_LOST
    {
        public string Doc_No { get; set; }
        public Nullable<int> SNo { get; set; }
        public string Payment_No { get; set; }
        public string Vendor_Code { get; set; }
        public Nullable<decimal> Payment_Amount { get; set; }
    
        public virtual TSPL_PAYMENT_HEADER TSPL_PAYMENT_HEADER { get; set; }
        public virtual TSPL_PAYMENT_PROCESS_HEAD TSPL_PAYMENT_PROCESS_HEAD { get; set; }
        public virtual TSPL_VENDOR_MASTER TSPL_VENDOR_MASTER { get; set; }
    }
}
