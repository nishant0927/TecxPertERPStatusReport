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
    
    public partial class TSPL_MCC_VSP_ChargeCategory_MAPPING
    {
        public string VSP_CODE { get; set; }
        public string Charge_CODE { get; set; }
        public decimal Rate { get; set; }
        public Nullable<System.DateTime> Updated_Date { get; set; }
    
        public virtual TSPL_Charge_Category TSPL_Charge_Category { get; set; }
        public virtual TSPL_VENDOR_MASTER TSPL_VENDOR_MASTER { get; set; }
    }
}
