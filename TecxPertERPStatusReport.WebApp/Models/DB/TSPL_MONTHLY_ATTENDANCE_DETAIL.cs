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
    
    public partial class TSPL_MONTHLY_ATTENDANCE_DETAIL
    {
        public string MTA_CODE { get; set; }
        public string EMP_CODE { get; set; }
        public decimal PRESENT_DAYS { get; set; }
        public decimal ABSENT_DAYS { get; set; }
        public decimal HOLIDAYS_DAYS { get; set; }
        public decimal LEAVE_DAYS { get; set; }
        public decimal TOTAL_DAYS { get; set; }
        public decimal PAYABLE_DAYS { get; set; }
        public decimal LOP_DAYS { get; set; }
        public string ATTENDANCE_CODE { get; set; }
        public decimal WEEKLY_OFF_DAYS { get; set; }
        public decimal Earned_Leave { get; set; }
        public decimal Casual_Leave { get; set; }
        public decimal Maternity_Leave { get; set; }
        public decimal Medical_Leave { get; set; }
        public decimal Other_Leave { get; set; }
        public decimal Coff { get; set; }
    
        public virtual TSPL_ATTENDANCE_MASTER TSPL_ATTENDANCE_MASTER { get; set; }
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER { get; set; }
    }
}
