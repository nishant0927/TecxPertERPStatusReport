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
    
    public partial class TSPL_RFQ_DETAIL_ITEM
    {
        public string RFQ_NO { get; set; }
        public string Vendor_Code { get; set; }
        public string Item_Code { get; set; }
    
        public virtual TSPL_RFQ_HEAD TSPL_RFQ_HEAD { get; set; }
        public virtual TSPL_VENDOR_MASTER TSPL_VENDOR_MASTER { get; set; }
    }
}
