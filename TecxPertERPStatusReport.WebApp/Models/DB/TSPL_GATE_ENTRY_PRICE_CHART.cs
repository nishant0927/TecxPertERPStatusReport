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
    
    public partial class TSPL_GATE_ENTRY_PRICE_CHART
    {
        public string GE_Code { get; set; }
        public string Price_Code { get; set; }
        public string Milk_Grade_code { get; set; }
    
        public virtual Tspl_Gate_Entry_Details Tspl_Gate_Entry_Details { get; set; }
    }
}