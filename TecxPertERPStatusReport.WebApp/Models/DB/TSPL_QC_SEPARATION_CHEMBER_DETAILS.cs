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
    
    public partial class TSPL_QC_SEPARATION_CHEMBER_DETAILS
    {
        public string Document_No { get; set; }
        public int Line_No { get; set; }
        public string Item_Code { get; set; }
        public string UOM { get; set; }
        public double Qty { get; set; }
    
        public virtual TSPL_QC_SEPARATION TSPL_QC_SEPARATION { get; set; }
    }
}
