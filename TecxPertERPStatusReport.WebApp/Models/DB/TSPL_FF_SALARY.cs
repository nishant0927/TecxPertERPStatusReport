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
    
    public partial class TSPL_FF_SALARY
    {
        public string EMP_CODE { get; set; }
        public int LINE_NO { get; set; }
        public string PAY_HEAD_CODE { get; set; }
        public string PAY_HEAD_DESC { get; set; }
        public string PAYHEAD_FORMULA { get; set; }
        public decimal RATE_AMOUNT { get; set; }
        public decimal PAYHEAD_AMOUNT { get; set; }
        public decimal ACTUAL_AMOUNT { get; set; }
        public string REMARKS { get; set; }
        public bool IS_OTHR_EARNING { get; set; }
        public bool IS_DEDUCTION { get; set; }
    
        public virtual TSPL_FF_SETTLEMENT_HEAD TSPL_FF_SETTLEMENT_HEAD { get; set; }
        public virtual TSPL_PAYHEAD_MASTER TSPL_PAYHEAD_MASTER { get; set; }
    }
}
