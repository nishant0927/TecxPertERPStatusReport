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
    
    public partial class TSPL_SRN_RETURN
    {
        public string Document_No { get; set; }
        public System.DateTime Document_Date { get; set; }
        public string SRN_No { get; set; }
        public string Remarks { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
    
        public virtual TSPL_SRN_HEAD TSPL_SRN_HEAD { get; set; }
    }
}
