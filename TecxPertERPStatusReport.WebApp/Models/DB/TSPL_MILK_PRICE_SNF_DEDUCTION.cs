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
    
    public partial class TSPL_MILK_PRICE_SNF_DEDUCTION
    {
        public string Price_Code { get; set; }
        public Nullable<decimal> Per { get; set; }
        public Nullable<decimal> Amount { get; set; }
    
        public virtual TSPL_MILK_PRICE_MASTER TSPL_MILK_PRICE_MASTER { get; set; }
    }
}