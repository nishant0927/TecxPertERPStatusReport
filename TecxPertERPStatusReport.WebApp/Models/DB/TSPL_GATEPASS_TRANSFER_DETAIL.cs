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
    
    public partial class TSPL_GATEPASS_TRANSFER_DETAIL
    {
        public string Document_No { get; set; }
        public string Item_Code { get; set; }
        public string Unit_code { get; set; }
        public double Qty { get; set; }
        public string Remarks { get; set; }
    
        public virtual TSPL_GATEPASS_TRANSFER_HEAD TSPL_GATEPASS_TRANSFER_HEAD { get; set; }
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
    }
}
