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
    
    public partial class TSPL_BANK_OPENING_RECO
    {
        public string Code { get; set; }
        public System.DateTime Reco_Date { get; set; }
        public string Type { get; set; }
        public string Vendor_Code { get; set; }
        public string Cust_Code { get; set; }
        public string Cheque_No { get; set; }
        public System.DateTime Cheque_Date { get; set; }
        public Nullable<decimal> Amt { get; set; }
        public string Description { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string Comp_Code { get; set; }
        public int Status { get; set; }
        public string Post_By { get; set; }
        public Nullable<System.DateTime> Post_Date { get; set; }
        public string Bank_Code { get; set; }
    
        public virtual TSPL_BANK_MASTER TSPL_BANK_MASTER { get; set; }
        public virtual TSPL_CUSTOMER_MASTER TSPL_CUSTOMER_MASTER { get; set; }
        public virtual TSPL_VENDOR_MASTER TSPL_VENDOR_MASTER { get; set; }
    }
}
