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
    
    public partial class TSPL_ITEM_WISE_TAX_AUTHORITY
    {
        public string DDCODE { get; set; }
        public Nullable<int> SNO { get; set; }
        public string DCODE { get; set; }
        public string HCODE { get; set; }
        public string Tax_Authority { get; set; }
        public Nullable<decimal> TAX_Rate { get; set; }
    
        public virtual TSPL_ITEM_WISE_TAX TSPL_ITEM_WISE_TAX { get; set; }
        public virtual TSPL_ITEM_WISE_TAX_GROUP TSPL_ITEM_WISE_TAX_GROUP { get; set; }
    }
}