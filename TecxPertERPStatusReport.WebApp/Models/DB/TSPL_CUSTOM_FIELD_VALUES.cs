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
    
    public partial class TSPL_CUSTOM_FIELD_VALUES
    {
        public string Program_Code { get; set; }
        public string Transaction_Code { get; set; }
        public string Custom_Field_Code { get; set; }
        public string Value { get; set; }
        public int Line_N0_For_Detail { get; set; }
    
        public virtual TSPL_CUSTOM_FIELD_HEAD TSPL_CUSTOM_FIELD_HEAD { get; set; }
        public virtual TSPL_PROGRAM_MASTER TSPL_PROGRAM_MASTER { get; set; }
    }
}
