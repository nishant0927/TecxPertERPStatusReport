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
    
    public partial class TSPL_EMPLOYEE_FAMILIES
    {
        public string EMP_CODE { get; set; }
        public int LINE_NO { get; set; }
        public string MEMBER_NAME { get; set; }
        public string RELATION_WITH_EMP { get; set; }
        public Nullable<decimal> MEMBER_AGE { get; set; }
        public string MEMBER_SEX { get; set; }
        public string DESCRIPTION { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string IS_DEPENDENT { get; set; }
        public Nullable<System.DateTime> Member_DOB { get; set; }
        public string Member_Occupation { get; set; }
        public bool Dependent_Living_With_Emp { get; set; }
        public string CONTACT_NO { get; set; }
    
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER { get; set; }
    }
}
