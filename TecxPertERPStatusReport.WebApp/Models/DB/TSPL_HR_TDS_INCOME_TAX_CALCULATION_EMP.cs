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
    
    public partial class TSPL_HR_TDS_INCOME_TAX_CALCULATION_EMP
    {
        public string TR_Code { get; set; }
        public string Code { get; set; }
        public int SNo { get; set; }
        public string Emp_Code { get; set; }
        public Nullable<decimal> Gross_Amt { get; set; }
        public Nullable<decimal> Allowance_Amt { get; set; }
        public Nullable<decimal> Section_Amt { get; set; }
        public Nullable<decimal> Taxable_Amt { get; set; }
        public string Tax_Group { get; set; }
        public Nullable<decimal> Total_TDS_Amt { get; set; }
    
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER { get; set; }
        public virtual TSPL_HR_TDS_INCOME_TAX_CALCULATION_HEAD TSPL_HR_TDS_INCOME_TAX_CALCULATION_HEAD { get; set; }
    }
}