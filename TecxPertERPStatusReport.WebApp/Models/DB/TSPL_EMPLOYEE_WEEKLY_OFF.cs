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
    
    public partial class TSPL_EMPLOYEE_WEEKLY_OFF
    {
        public string WEEK_OFF_CODE { get; set; }
        public string EMP_STATUS_CODE { get; set; }
        public string EMP_CODE { get; set; }
        public string WKHOLIDAY_CODE { get; set; }
    
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER { get; set; }
        public virtual TSPL_EMPLOYEE_STATUS TSPL_EMPLOYEE_STATUS { get; set; }
        public virtual TSPL_WEEKLY_HOLIDAYS TSPL_WEEKLY_HOLIDAYS { get; set; }
    }
}