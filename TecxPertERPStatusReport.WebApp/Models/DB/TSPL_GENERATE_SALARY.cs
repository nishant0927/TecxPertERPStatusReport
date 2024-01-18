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
    
    public partial class TSPL_GENERATE_SALARY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_GENERATE_SALARY()
        {
            this.TSPL_ATTENDANCE_SUMMARY = new HashSet<TSPL_ATTENDANCE_SUMMARY>();
            this.TSPL_FF_SETTLEMENT_HEAD = new HashSet<TSPL_FF_SETTLEMENT_HEAD>();
            this.TSPL_GENERATE_SALARY_ATTENDANCE = new HashSet<TSPL_GENERATE_SALARY_ATTENDANCE>();
            this.TSPL_GENERATE_SALARY_PAYHEADS = new HashSet<TSPL_GENERATE_SALARY_PAYHEADS>();
            this.TSPL_PAYMENT_HEADER = new HashSet<TSPL_PAYMENT_HEADER>();
            this.TSPL_VENDOR_INVOICE_HEAD = new HashSet<TSPL_VENDOR_INVOICE_HEAD>();
        }
    
        public string SALARY_GENERATION_CODE { get; set; }
        public string PAY_PERIOD_CODE { get; set; }
        public int PAYPERIOD_DAYS { get; set; }
        public System.DateTime GENERATE_DATE { get; set; }
        public string GENERATED_BY { get; set; }
        public string GENERATE_REMARKS { get; set; }
        public bool POSTED { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string GL_SALARY_PAYABLE { get; set; }
        public string BANK_CODE { get; set; }
        public string BANKACC { get; set; }
        public string SAL_ACCOUNT_SET { get; set; }
        public string SOURCE_CODE { get; set; }
        public string CHEQUE_NO { get; set; }
        public Nullable<System.DateTime> CHEQUE_DATED { get; set; }
        public string LOCATION_CODE { get; set; }
        public string DEVISION_CODE { get; set; }
        public string GL_Employer_PF_PAYABLE { get; set; }
        public string GL_Employer_ESI_PAYABLE { get; set; }
        public string GL_EMPLOYER_OTHERS_PAYABLE { get; set; }
        public Nullable<bool> CREATE_FE { get; set; }
        public string LEAVEALLOTMENT_CODE { get; set; }
        public Nullable<decimal> GL_SALARY_PAYABLE_AMOUNT { get; set; }
        public Nullable<System.DateTime> Payment_Date { get; set; }
        public string Payment_Bank_Code { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ATTENDANCE_SUMMARY> TSPL_ATTENDANCE_SUMMARY { get; set; }
        public virtual TSPL_BANK_MASTER TSPL_BANK_MASTER { get; set; }
        public virtual TSPL_BANK_MASTER TSPL_BANK_MASTER1 { get; set; }
        public virtual TSPL_DEVISION_MASTER TSPL_DEVISION_MASTER { get; set; }
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_FF_SETTLEMENT_HEAD> TSPL_FF_SETTLEMENT_HEAD { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS1 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS2 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS3 { get; set; }
        public virtual TSPL_LEAVE_ALLOTMENT TSPL_LEAVE_ALLOTMENT { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_PAYPERIOD_MASTER TSPL_PAYPERIOD_MASTER { get; set; }
        public virtual TSPL_PAYROLL_ACCOUNTSETS TSPL_PAYROLL_ACCOUNTSETS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_GENERATE_SALARY_ATTENDANCE> TSPL_GENERATE_SALARY_ATTENDANCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_GENERATE_SALARY_PAYHEADS> TSPL_GENERATE_SALARY_PAYHEADS { get; set; }
        public virtual TSPL_GENERATE_SALARY_FE_ACCOUNTS TSPL_GENERATE_SALARY_FE_ACCOUNTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PAYMENT_HEADER> TSPL_PAYMENT_HEADER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_VENDOR_INVOICE_HEAD> TSPL_VENDOR_INVOICE_HEAD { get; set; }
    }
}
