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
    
    public partial class TSPL_MCC_SCRAP_GATEPASS_DETAIL
    {
        public string GPCode { get; set; }
        public string Item_Code { get; set; }
        public string Unit_Code { get; set; }
        public double Qty { get; set; }
        public string HSN_Code { get; set; }
    
        public virtual TSPL_MCC_SCRAP_GATEPASS_MASTER TSPL_MCC_SCRAP_GATEPASS_MASTER { get; set; }
    }
}
