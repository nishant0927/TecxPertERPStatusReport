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
    
    public partial class TSPL_VENDORREGISTRATION_MACHINERY_DETAILS
    {
        public string Registration_No { get; set; }
        public string Machine_Description { get; set; }
        public string MakeandModel { get; set; }
        public string NoofInst { get; set; }
        public string YearofPurchase { get; set; }
        public string Type { get; set; }
    
        public virtual TSPL_VENDORREGISTRATION_MASTER TSPL_VENDORREGISTRATION_MASTER { get; set; }
    }
}