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
    
    public partial class TSPL_EMPLOYEE_QUALIFICATION
    {
        public string EMP_CODE { get; set; }
        public int LINE_NO { get; set; }
        public string COURSE_CODE { get; set; }
        public Nullable<System.DateTime> JOINING_DATE { get; set; }
        public Nullable<System.DateTime> COMPLETION_DATE { get; set; }
        public string GRADE_PERCENTAGE { get; set; }
        public string COLLEGE_UNIVERSITY { get; set; }
        public string DESCRIPTION { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string VERIFICATION_DONE { get; set; }
        public string University_Address { get; set; }
        public string University_Website { get; set; }
    
        public virtual TSPL_COURSE_MASTER TSPL_COURSE_MASTER { get; set; }
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER { get; set; }
    }
}
