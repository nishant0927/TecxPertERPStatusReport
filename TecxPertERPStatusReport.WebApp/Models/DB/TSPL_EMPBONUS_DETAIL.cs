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
    
    public partial class TSPL_EMPBONUS_DETAIL
    {
        public string EMP_BONUS_CODE { get; set; }
        public string EMP_CODE { get; set; }
        public string BONUS_CODE { get; set; }
        public decimal BONUS_AMOUNT { get; set; }
    
        public virtual TSPL_BONUS_MASTER TSPL_BONUS_MASTER { get; set; }
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER { get; set; }
    }
}
