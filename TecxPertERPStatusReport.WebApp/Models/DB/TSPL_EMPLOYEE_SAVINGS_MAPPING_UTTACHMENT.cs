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
    
    public partial class TSPL_EMPLOYEE_SAVINGS_MAPPING_UTTACHMENT
    {
        public string TR_CODE { get; set; }
        public string DOCUMENT_CODE { get; set; }
        public string FileName { get; set; }
        public byte[] FileData { get; set; }
    
        public virtual TSPL_EMPLOYEE_SAVINGS_MAPPING_MASTER TSPL_EMPLOYEE_SAVINGS_MAPPING_MASTER { get; set; }
    }
}