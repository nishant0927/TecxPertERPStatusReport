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
    
    public partial class TSPL_PJC_EXPENSE_HEADER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_PJC_EXPENSE_HEADER()
        {
            this.TSPL_MP_PAY_HEAD = new HashSet<TSPL_MP_PAY_HEAD>();
            this.TSPL_PAYMENT_HEADER = new HashSet<TSPL_PAYMENT_HEADER>();
            this.TSPL_PJC_EXPENSE_DETAIL = new HashSet<TSPL_PJC_EXPENSE_DETAIL>();
        }
    
        public string Document_No { get; set; }
        public Nullable<System.DateTime> Document_Date { get; set; }
        public string EMP_CODE { get; set; }
        public string PROJECT_CODE { get; set; }
        public string Job_Code { get; set; }
        public string Task_Code { get; set; }
        public string Reference { get; set; }
        public string Description { get; set; }
        public string Posted { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public Nullable<decimal> TotalCost { get; set; }
        public Nullable<decimal> TotPaymentCost { get; set; }
        public string Comp_Code { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public string Modify_By { get; set; }
        public Nullable<System.DateTime> Modify_Date { get; set; }
        public string Payment_No { get; set; }
    
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MP_PAY_HEAD> TSPL_MP_PAY_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PAYMENT_HEADER> TSPL_PAYMENT_HEADER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PJC_EXPENSE_DETAIL> TSPL_PJC_EXPENSE_DETAIL { get; set; }
        public virtual TSPL_PJC_JOB TSPL_PJC_JOB { get; set; }
        public virtual TSPL_PJC_PROJECT TSPL_PJC_PROJECT { get; set; }
        public virtual TSPL_PJC_TASK TSPL_PJC_TASK { get; set; }
    }
}
