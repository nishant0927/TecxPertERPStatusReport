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
    
    public partial class TSPL_PROMPT_MSG_PENDING_DETAIL
    {
        public string Prompt_code { get; set; }
        public string ProgramCode { get; set; }
        public string PENDING_DOC_CODE { get; set; }
        public string Last_Status { get; set; }
    
        public virtual TSPL_PROGRAM_MASTER TSPL_PROGRAM_MASTER { get; set; }
        public virtual TSPL_PROMPT_MSG_PENDING_HEAD TSPL_PROMPT_MSG_PENDING_HEAD { get; set; }
    }
}