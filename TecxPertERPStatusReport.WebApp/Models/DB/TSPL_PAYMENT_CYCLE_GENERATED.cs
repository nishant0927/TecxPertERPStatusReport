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
    
    public partial class TSPL_PAYMENT_CYCLE_GENERATED
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string MCC_Code { get; set; }
        public string Fiscal_Code { get; set; }
        public System.DateTime From_Date { get; set; }
        public System.DateTime To_Date { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
    
        public virtual TSPL_Fiscal_Year_Master TSPL_Fiscal_Year_Master { get; set; }
        public virtual TSPL_MCC_MASTER TSPL_MCC_MASTER { get; set; }
    }
}
