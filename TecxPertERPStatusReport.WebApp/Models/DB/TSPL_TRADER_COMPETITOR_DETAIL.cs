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
    
    public partial class TSPL_TRADER_COMPETITOR_DETAIL
    {
        public int Line_No { get; set; }
        public string Cust_Code { get; set; }
        public string Competitor_Code { get; set; }
        public Nullable<decimal> Milk { get; set; }
        public Nullable<decimal> Curd { get; set; }
        public Nullable<decimal> Others { get; set; }
    
        public virtual TSPL_COMPETITOR_MASTER TSPL_COMPETITOR_MASTER { get; set; }
        public virtual TSPL_SECONDARY_CUSTOMER_MASTER TSPL_SECONDARY_CUSTOMER_MASTER { get; set; }
    }
}
