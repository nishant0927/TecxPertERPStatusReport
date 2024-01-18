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
    
    public partial class TSPL_LTA_Claim_Head
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_LTA_Claim_Head()
        {
            this.TSPL_LTA_Claim_Detail = new HashSet<TSPL_LTA_Claim_Detail>();
        }
    
        public string LTA_CODE { get; set; }
        public string EMP_CODE { get; set; }
        public System.DateTime Claim_From_Date { get; set; }
        public System.DateTime Claim_To_Date { get; set; }
        public decimal Claim_Amount { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public decimal Posted { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string Comp_Code { get; set; }
        public string PAY_PERIOD_CODE { get; set; }
    
        public virtual TSPL_COMPANY_MASTER TSPL_COMPANY_MASTER { get; set; }
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_LTA_Claim_Detail> TSPL_LTA_Claim_Detail { get; set; }
        public virtual TSPL_PAYPERIOD_MASTER TSPL_PAYPERIOD_MASTER { get; set; }
    }
}
