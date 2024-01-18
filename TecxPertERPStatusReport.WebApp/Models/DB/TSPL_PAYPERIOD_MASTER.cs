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
    
    public partial class TSPL_PAYPERIOD_MASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_PAYPERIOD_MASTER()
        {
            this.TSPL_ADJUSTMENT_VOUCHER = new HashSet<TSPL_ADJUSTMENT_VOUCHER>();
            this.TSPL_ALLOWANCE = new HashSet<TSPL_ALLOWANCE>();
            this.TSPL_ARREAR_CALCULATION = new HashSet<TSPL_ARREAR_CALCULATION>();
            this.TSPL_ATTENDANCE_SUMMARY = new HashSet<TSPL_ATTENDANCE_SUMMARY>();
            this.TSPL_CONVEYANCE_CLAIM = new HashSet<TSPL_CONVEYANCE_CLAIM>();
            this.TSPL_DAILY_ATTENDANCE = new HashSet<TSPL_DAILY_ATTENDANCE>();
            this.TSPL_DEDUCTION = new HashSet<TSPL_DEDUCTION>();
            this.TSPL_EMP_REIMBURSEMENT = new HashSet<TSPL_EMP_REIMBURSEMENT>();
            this.TSPL_EMPLOYEE_BONUS = new HashSet<TSPL_EMPLOYEE_BONUS>();
            this.TSPL_EMPLOYEE_BONUS1 = new HashSet<TSPL_EMPLOYEE_BONUS>();
            this.TSPL_EMPLOYEE_BONUS2 = new HashSet<TSPL_EMPLOYEE_BONUS>();
            this.TSPL_FF_SETTLEMENT_HEAD = new HashSet<TSPL_FF_SETTLEMENT_HEAD>();
            this.TSPL_FF_SETTLEMENT_HEAD1 = new HashSet<TSPL_FF_SETTLEMENT_HEAD>();
            this.TSPL_GENERATE_SALARY = new HashSet<TSPL_GENERATE_SALARY>();
            this.TSPL_GRATUITY = new HashSet<TSPL_GRATUITY>();
            this.TSPL_HOURLY_ATTENDANCE = new HashSet<TSPL_HOURLY_ATTENDANCE>();
            this.TSPL_HOUSE_RENT_DECLARATION = new HashSet<TSPL_HOUSE_RENT_DECLARATION>();
            this.TSPL_HR_DAMAGE_DETAIL = new HashSet<TSPL_HR_DAMAGE_DETAIL>();
            this.TSPL_INCREMENT = new HashSet<TSPL_INCREMENT>();
            this.TSPL_LEAVE_ADJUSTMENT = new HashSet<TSPL_LEAVE_ADJUSTMENT>();
            this.TSPL_LEAVE_ALLOTMENT = new HashSet<TSPL_LEAVE_ALLOTMENT>();
            this.TSPL_LEAVE_APPLICATION = new HashSet<TSPL_LEAVE_APPLICATION>();
            this.TSPL_LEAVE_OPENINGBAL = new HashSet<TSPL_LEAVE_OPENINGBAL>();
            this.TSPL_LEAVES_REGISTER = new HashSet<TSPL_LEAVES_REGISTER>();
            this.TSPL_LOAN_ADJUSTMENT = new HashSet<TSPL_LOAN_ADJUSTMENT>();
            this.TSPL_LOAN_GENERATION = new HashSet<TSPL_LOAN_GENERATION>();
            this.TSPL_LTA_Claim_Head = new HashSet<TSPL_LTA_Claim_Head>();
            this.TSPL_MEDICLAIM_HEAD = new HashSet<TSPL_MEDICLAIM_HEAD>();
            this.TSPL_MONTHLY_ATTENDANCE = new HashSet<TSPL_MONTHLY_ATTENDANCE>();
            this.TSPL_OD_SHEET = new HashSet<TSPL_OD_SHEET>();
            this.TSPL_OT_SHEET = new HashSet<TSPL_OT_SHEET>();
            this.TSPL_OUTDUTY_SHEET = new HashSet<TSPL_OUTDUTY_SHEET>();
            this.TSPL_BONUS_GENERATION_DETAIL = new HashSet<TSPL_BONUS_GENERATION_DETAIL>();
            this.TSPL_LOANGENERATION_DETAIL = new HashSet<TSPL_LOANGENERATION_DETAIL>();
            this.TSPL_SALARY_CALCULATION = new HashSet<TSPL_SALARY_CALCULATION>();
            this.TSPL_SENT_MAIL_SLIP = new HashSet<TSPL_SENT_MAIL_SLIP>();
        }
    
        public string PAY_PERIOD_CODE { get; set; }
        public string PAY_PERIOD_NAME { get; set; }
        public System.DateTime DATE_FROM { get; set; }
        public System.DateTime DATE_TO { get; set; }
        public string DESCRIPTION { get; set; }
        public bool POSTED { get; set; }
        public bool FREEZED { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ADJUSTMENT_VOUCHER> TSPL_ADJUSTMENT_VOUCHER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ALLOWANCE> TSPL_ALLOWANCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ARREAR_CALCULATION> TSPL_ARREAR_CALCULATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ATTENDANCE_SUMMARY> TSPL_ATTENDANCE_SUMMARY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CONVEYANCE_CLAIM> TSPL_CONVEYANCE_CLAIM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DAILY_ATTENDANCE> TSPL_DAILY_ATTENDANCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DEDUCTION> TSPL_DEDUCTION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EMP_REIMBURSEMENT> TSPL_EMP_REIMBURSEMENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EMPLOYEE_BONUS> TSPL_EMPLOYEE_BONUS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EMPLOYEE_BONUS> TSPL_EMPLOYEE_BONUS1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EMPLOYEE_BONUS> TSPL_EMPLOYEE_BONUS2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_FF_SETTLEMENT_HEAD> TSPL_FF_SETTLEMENT_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_FF_SETTLEMENT_HEAD> TSPL_FF_SETTLEMENT_HEAD1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_GENERATE_SALARY> TSPL_GENERATE_SALARY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_GRATUITY> TSPL_GRATUITY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HOURLY_ATTENDANCE> TSPL_HOURLY_ATTENDANCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HOUSE_RENT_DECLARATION> TSPL_HOUSE_RENT_DECLARATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HR_DAMAGE_DETAIL> TSPL_HR_DAMAGE_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_INCREMENT> TSPL_INCREMENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_LEAVE_ADJUSTMENT> TSPL_LEAVE_ADJUSTMENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_LEAVE_ALLOTMENT> TSPL_LEAVE_ALLOTMENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_LEAVE_APPLICATION> TSPL_LEAVE_APPLICATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_LEAVE_OPENINGBAL> TSPL_LEAVE_OPENINGBAL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_LEAVES_REGISTER> TSPL_LEAVES_REGISTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_LOAN_ADJUSTMENT> TSPL_LOAN_ADJUSTMENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_LOAN_GENERATION> TSPL_LOAN_GENERATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_LTA_Claim_Head> TSPL_LTA_Claim_Head { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MEDICLAIM_HEAD> TSPL_MEDICLAIM_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MONTHLY_ATTENDANCE> TSPL_MONTHLY_ATTENDANCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_OD_SHEET> TSPL_OD_SHEET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_OT_SHEET> TSPL_OT_SHEET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_OUTDUTY_SHEET> TSPL_OUTDUTY_SHEET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_BONUS_GENERATION_DETAIL> TSPL_BONUS_GENERATION_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_LOANGENERATION_DETAIL> TSPL_LOANGENERATION_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SALARY_CALCULATION> TSPL_SALARY_CALCULATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SENT_MAIL_SLIP> TSPL_SENT_MAIL_SLIP { get; set; }
    }
}
