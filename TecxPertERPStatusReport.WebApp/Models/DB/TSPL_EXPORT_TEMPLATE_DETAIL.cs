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
    
    public partial class TSPL_EXPORT_TEMPLATE_DETAIL
    {
        public string Export_Code { get; set; }
        public int Seq_No { get; set; }
        public string Column_Name { get; set; }
        public string Column_Header { get; set; }
        public Nullable<int> Column_Mandatory { get; set; }
    
        public virtual TSPL_EXPORT_TEMPLATE_HEAD TSPL_EXPORT_TEMPLATE_HEAD { get; set; }
    }
}
