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
    
    public partial class TSPL_FAT_SNF_UPLOADER_Chart_Detail
    {
        public string Charge_CODE { get; set; }
        public decimal Rate { get; set; }
        public string Price_CODE { get; set; }
    
        public virtual TSPL_Charge_Category TSPL_Charge_Category { get; set; }
    }
}
