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
    
    public partial class TSPL_WS_CS_RECORD_DETAIL
    {
        public string Document_No { get; set; }
        public int Line_No { get; set; }
        public string Item_Code { get; set; }
        public Nullable<decimal> Booking_Qty { get; set; }
        public string Unit_code { get; set; }
        public int CardSale_NoOFDays { get; set; }
        public decimal Item_Rate { get; set; }
        public Nullable<decimal> Amount { get; set; }
    
        public virtual TSPL_WS_CS_RECORD_MASTER TSPL_WS_CS_RECORD_MASTER { get; set; }
    }
}
