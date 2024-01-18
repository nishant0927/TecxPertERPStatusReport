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
    
    public partial class TSPL_INVESTMENT_DECLARATION_PAYROLL
    {
        public string CODE { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string FINANCIAL_YEAR_CODE { get; set; }
        public string Investment_Type_Code { get; set; }
        public string EMP_CODE { get; set; }
        public decimal PROVISIONAL_AMOUNT { get; set; }
        public decimal Actual_Amount { get; set; }
        public int Is_Post { get; set; }
        public Nullable<System.DateTime> Post_Date { get; set; }
        public string Comp_Code { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
    
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER { get; set; }
        public virtual TSPL_INVESTMENT_TYPE TSPL_INVESTMENT_TYPE { get; set; }
    }
}
