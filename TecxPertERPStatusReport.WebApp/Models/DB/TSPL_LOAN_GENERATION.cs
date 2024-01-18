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
    
    public partial class TSPL_LOAN_GENERATION
    {
        public string LOAN_GENERATION_CODE { get; set; }
        public System.DateTime GENERATION_DATE { get; set; }
        public string PAY_PERIOD_CODE { get; set; }
        public string GENERATE_REMARKS { get; set; }
        public string GENERATED_BY { get; set; }
        public bool POSTED { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string LOCATION_CODE { get; set; }
        public string DEVISION_CODE { get; set; }
    
        public virtual TSPL_DEVISION_MASTER TSPL_DEVISION_MASTER { get; set; }
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_PAYPERIOD_MASTER TSPL_PAYPERIOD_MASTER { get; set; }
    }
}
