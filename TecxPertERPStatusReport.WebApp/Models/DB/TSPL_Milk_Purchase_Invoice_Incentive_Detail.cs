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
    
    public partial class TSPL_Milk_Purchase_Invoice_Incentive_Detail
    {
        public string AP_Invoice_Code { get; set; }
        public string Milk_Purchase_Invoice_CODE { get; set; }
        public int PK_Id { get; set; }
    
        public virtual TSPL_MILK_PURCHASE_INVOICE_HEAD TSPL_MILK_PURCHASE_INVOICE_HEAD { get; set; }
        public virtual TSPL_VENDOR_INVOICE_HEAD TSPL_VENDOR_INVOICE_HEAD { get; set; }
    }
}