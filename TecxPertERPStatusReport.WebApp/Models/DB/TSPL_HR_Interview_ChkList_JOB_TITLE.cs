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
    
    public partial class TSPL_HR_Interview_ChkList_JOB_TITLE
    {
        public string Job_Title_Code { get; set; }
        public string Chk_Code { get; set; }
        public int mandatory { get; set; }
    
        public virtual TSPL_HR_JOB_TITLE TSPL_HR_JOB_TITLE { get; set; }
    }
}
