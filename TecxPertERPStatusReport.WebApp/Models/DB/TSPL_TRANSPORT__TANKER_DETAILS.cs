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
    
    public partial class TSPL_TRANSPORT__TANKER_DETAILS
    {
        public string Transpoter_Id { get; set; }
        public string Tanker_Id { get; set; }
        public string Transpoter_Name { get; set; }
    
        public virtual TSPL_VENDOR_MASTER TSPL_VENDOR_MASTER { get; set; }
    }
}
