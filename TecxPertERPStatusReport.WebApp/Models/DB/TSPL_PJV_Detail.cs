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
    
    public partial class TSPL_PJV_Detail
    {
        public string PJV_No { get; set; }
        public int Line_No { get; set; }
        public string GL_Account_Code { get; set; }
        public string GL_Account_Desc { get; set; }
        public Nullable<decimal> PJV_Amount { get; set; }
    
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS { get; set; }
        public virtual TSPL_PJV_HEAD TSPL_PJV_HEAD { get; set; }
    }
}