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
    
    public partial class TSPL_BANK_TRANSFER_MCC
    {
        public string TR_Code { get; set; }
        public string Transfer_No { get; set; }
        public string MCC_Code { get; set; }
    
        public virtual TSPL_BANK_TRANSFER TSPL_BANK_TRANSFER { get; set; }
        public virtual TSPL_MCC_MASTER TSPL_MCC_MASTER { get; set; }
    }
}
