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
    
    public partial class TSPL_MEDICLAIM_HEAD
    {
        public string Comp_code { get; set; }
        public string DOCUMENT_CODE { get; set; }
        public string DATE { get; set; }
        public string DESCRIPTION { get; set; }
        public string EMP_CODE { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public Nullable<decimal> Total_Amount { get; set; }
        public string Status { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modified_By { get; set; }
        public string Modified_Date { get; set; }
        public string PAY_PERIOD_CODE { get; set; }
    
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER { get; set; }
        public virtual TSPL_PAYPERIOD_MASTER TSPL_PAYPERIOD_MASTER { get; set; }
    }
}