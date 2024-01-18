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
    
    public partial class TSPL_PJC_PROJECT_JOB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_PJC_PROJECT_JOB()
        {
            this.TSPL_PJC_PROJECT_TASK = new HashSet<TSPL_PJC_PROJECT_TASK>();
        }
    
        public string Job_ID { get; set; }
        public int S_No { get; set; }
        public string JOB_CODE { get; set; }
        public string PROJECT_CODE { get; set; }
        public string Job_Type { get; set; }
        public string Accounting_Method { get; set; }
        public string Billing_Type { get; set; }
        public int Close_To_Bill { get; set; }
        public int Close_To_Cost { get; set; }
        public Nullable<System.DateTime> Start_Date { get; set; }
        public Nullable<System.DateTime> End_Date { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> Status_Date { get; set; }
        public Nullable<System.DateTime> Status_Date_Open { get; set; }
        public Nullable<System.DateTime> Status_Date_WIP { get; set; }
        public Nullable<System.DateTime> Status_Date_Complete { get; set; }
        public Nullable<System.DateTime> Status_Date_Hold { get; set; }
    
        public virtual TSPL_PJC_JOB TSPL_PJC_JOB { get; set; }
        public virtual TSPL_PJC_PROJECT TSPL_PJC_PROJECT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PJC_PROJECT_TASK> TSPL_PJC_PROJECT_TASK { get; set; }
    }
}
