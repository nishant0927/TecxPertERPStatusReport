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
    
    public partial class TSPL_LEAVE_SETTING_SALARY_SLAB_ALLOTED_LEAVE
    {
        public string LEAVE_CODE { get; set; }
        public int LINE_NO { get; set; }
        public Nullable<double> SALARY_FROM { get; set; }
        public Nullable<double> SALARY_TO { get; set; }
        public Nullable<double> ALLOTED_LEAVE { get; set; }
    
        public virtual TSPL_LEAVE_MASTER TSPL_LEAVE_MASTER { get; set; }
    }
}
