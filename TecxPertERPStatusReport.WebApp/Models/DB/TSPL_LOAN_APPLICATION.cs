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
    
    public partial class TSPL_LOAN_APPLICATION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_LOAN_APPLICATION()
        {
            this.TSPL_LOAN_ADJUSTMENT = new HashSet<TSPL_LOAN_ADJUSTMENT>();
            this.TSPL_MP_PAY_HEAD = new HashSet<TSPL_MP_PAY_HEAD>();
            this.TSPL_PAYMENT_HEADER = new HashSet<TSPL_PAYMENT_HEADER>();
        }
    
        public string LOAN_CODE { get; set; }
        public System.DateTime LOAN_DATE { get; set; }
        public string LOAN_BY { get; set; }
        public string EMP_CODE { get; set; }
        public string LOAN_TYPE { get; set; }
        public decimal LOAN_AMOUNT { get; set; }
        public int PERIOD_MONTH { get; set; }
        public int PERIOD_DAY { get; set; }
        public Nullable<System.DateTime> PAYMENT_STARTDATE { get; set; }
        public int NO_OF_EMI { get; set; }
        public bool INTEREST_APPLIED { get; set; }
        public string INTEREST_TYPE { get; set; }
        public string INTEREST_PERIODICITY { get; set; }
        public decimal INTEREST_RATE { get; set; }
        public decimal INTEREST_AMOUNT { get; set; }
        public decimal TOTALPAYABLE_AMOUNT { get; set; }
        public string LOAN_DESCRIPTION { get; set; }
        public bool POSTED { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public bool PAID { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string Location { get; set; }
        public string Division { get; set; }
        public Nullable<System.DateTime> Payment_EndDate { get; set; }
        public Nullable<int> Gross_Salary { get; set; }
        public string Loan_Status { get; set; }
    
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER { get; set; }
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_LOAN_ADJUSTMENT> TSPL_LOAN_ADJUSTMENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MP_PAY_HEAD> TSPL_MP_PAY_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PAYMENT_HEADER> TSPL_PAYMENT_HEADER { get; set; }
    }
}
