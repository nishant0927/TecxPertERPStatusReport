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
    
    public partial class TSPL_HR_DAMAGE_DETAIL
    {
        public string Damage_Detail_Code { get; set; }
        public string Damage_Detail_Description { get; set; }
        public string Damage_Code { get; set; }
        public Nullable<System.DateTime> Damage_Detail_Date { get; set; }
        public string Deduction_Imposed { get; set; }
        public string No_Of_Installment { get; set; }
        public Nullable<System.DateTime> Amt_Realised_Date { get; set; }
        public string Emp_Code { get; set; }
        public string Comp_Code { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public bool POSTED { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string PAY_PERIOD_CODE { get; set; }
    
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER { get; set; }
        public virtual TSPL_HR_DAMAGE_MASTER TSPL_HR_DAMAGE_MASTER { get; set; }
        public virtual TSPL_PAYPERIOD_MASTER TSPL_PAYPERIOD_MASTER { get; set; }
    }
}
