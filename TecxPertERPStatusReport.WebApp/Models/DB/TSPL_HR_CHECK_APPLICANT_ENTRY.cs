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
    
    public partial class TSPL_HR_CHECK_APPLICANT_ENTRY
    {
        public string APPLICANT_CODE { get; set; }
        public string Chk_Code { get; set; }
        public int Is_Manadatory { get; set; }
    
        public virtual TSPL_HR_APPLICANT_ENTRY TSPL_HR_APPLICANT_ENTRY { get; set; }
        public virtual TSPL_HR_Check_List TSPL_HR_Check_List { get; set; }
    }
}