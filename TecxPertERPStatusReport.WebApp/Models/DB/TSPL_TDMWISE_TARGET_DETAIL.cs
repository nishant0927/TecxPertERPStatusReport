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
    
    public partial class TSPL_TDMWISE_TARGET_DETAIL
    {
        public string TDMID { get; set; }
        public string Employee_Code { get; set; }
        public string Employee_desc { get; set; }
        public string Flavour { get; set; }
        public string Flavour_desc { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> TargetQty { get; set; }
        public string Flavourwise { get; set; }
        public Nullable<System.DateTime> TARGET_DATE { get; set; }
    }
}