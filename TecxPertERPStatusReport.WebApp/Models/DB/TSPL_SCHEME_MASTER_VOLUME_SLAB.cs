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
    
    public partial class TSPL_SCHEME_MASTER_VOLUME_SLAB
    {
        public string Scheme_Code { get; set; }
        public Nullable<decimal> Min_Range { get; set; }
        public Nullable<decimal> Max_Range { get; set; }
        public string Item_Code { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public string Unit_Code { get; set; }
    
        public virtual TSPL_SCHEME_MASTER_NEW TSPL_SCHEME_MASTER_NEW { get; set; }
    }
}
