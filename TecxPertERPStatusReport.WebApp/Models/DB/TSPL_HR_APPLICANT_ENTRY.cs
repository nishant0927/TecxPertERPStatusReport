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
    
    public partial class TSPL_HR_APPLICANT_ENTRY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_HR_APPLICANT_ENTRY()
        {
            this.TSPL_EMPLOYEE_MASTER = new HashSet<TSPL_EMPLOYEE_MASTER>();
            this.TSPL_HR_APPOINTMENT_LETTER = new HashSet<TSPL_HR_APPOINTMENT_LETTER>();
            this.TSPL_HR_CHECK_APPLICANT_ENTRY = new HashSet<TSPL_HR_CHECK_APPLICANT_ENTRY>();
            this.TSPL_HR_EMP_HISTORY_APPLICANT_ENTRY = new HashSet<TSPL_HR_EMP_HISTORY_APPLICANT_ENTRY>();
            this.TSPL_HR_HIRE_EMPLOYEE = new HashSet<TSPL_HR_HIRE_EMPLOYEE>();
            this.TSPL_HR_INTERVIEW_SCHEDULE = new HashSet<TSPL_HR_INTERVIEW_SCHEDULE>();
            this.TSPL_HR_INTERVIEW_FEEDBACK = new HashSet<TSPL_HR_INTERVIEW_FEEDBACK>();
            this.TSPL_HR_INTERVIEW_FEEDBACK_DETAIL = new HashSet<TSPL_HR_INTERVIEW_FEEDBACK_DETAIL>();
            this.TSPL_HR_OFFER_LETTER = new HashSet<TSPL_HR_OFFER_LETTER>();
            this.TSPL_HR_QUALIFICATION_APPLICANT_ENTRY = new HashSet<TSPL_HR_QUALIFICATION_APPLICANT_ENTRY>();
            this.TSPL_HR_REFERENCE_CHECK = new HashSet<TSPL_HR_REFERENCE_CHECK>();
            this.TSPL_HR_SALARY_FITMENT = new HashSet<TSPL_HR_SALARY_FITMENT>();
            this.TSPL_PAYHEAD_MASTER = new HashSet<TSPL_PAYHEAD_MASTER>();
        }
    
        public string APPLICANT_CODE { get; set; }
        public string Applicant_Description { get; set; }
        public Nullable<System.DateTime> Applicant_Date { get; set; }
        public string Requisition_Code { get; set; }
        public Nullable<System.DateTime> Date_Of_Interview { get; set; }
        public string Gender { get; set; }
        public string Salutation { get; set; }
        public string First_Name { get; set; }
        public string Middle_Name { get; set; }
        public string Last_Name { get; set; }
        public Nullable<System.DateTime> Applicant_Date_Of_Birth { get; set; }
        public string Maritial_Status { get; set; }
        public string Pan_No { get; set; }
        public byte[] Applicant_Photo { get; set; }
        public string Add1 { get; set; }
        public string Add2 { get; set; }
        public string Add3 { get; set; }
        public string Add4 { get; set; }
        public byte[] DOCUMENT_FILE { get; set; }
        public string DocName { get; set; }
        public string COUNTRY_CODE { get; set; }
        public string City_code { get; set; }
        public string State_Code { get; set; }
        public string Pin_Code { get; set; }
        public string Email { get; set; }
        public string TELEPHONE_NO { get; set; }
        public int Emp_Refrence { get; set; }
        public int Agency_Refrence { get; set; }
        public string Emp_Code { get; set; }
        public string Relation_Code { get; set; }
        public string Agency_Code { get; set; }
        public string Source_Type_Code { get; set; }
        public string Source_Type_Detail_Code { get; set; }
        public string Handicaped_Detail { get; set; }
        public string Blood_Group { get; set; }
        public string Bank_Code { get; set; }
        public string Branch_Code { get; set; }
        public string Account_No { get; set; }
        public string From_Location_Code { get; set; }
        public string To_location_Code { get; set; }
        public string Location_Code { get; set; }
        public string Preferred_Location_Code { get; set; }
        public double Current_Gross_Salary { get; set; }
        public double Total_CTC { get; set; }
        public string Performance_By { get; set; }
        public int Is_Fresher { get; set; }
        public int Is_Handicaped { get; set; }
        public int Relocation { get; set; }
        public int Short { get; set; }
        public Nullable<System.DateTime> Short_Date { get; set; }
        public string Short_By { get; set; }
        public int Rejected { get; set; }
        public Nullable<System.DateTime> Rejected_Date { get; set; }
        public string Rejected_By { get; set; }
        public int Posted { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string Posted_By { get; set; }
        public string Comp_Code { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
    
        public virtual TSPL_BANK_MASTER TSPL_BANK_MASTER { get; set; }
        public virtual TSPL_BRANCH_MASTER TSPL_BRANCH_MASTER { get; set; }
        public virtual TSPL_CITY_MASTER TSPL_CITY_MASTER { get; set; }
        public virtual TSPL_COUNTRY_MASTER TSPL_COUNTRY_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EMPLOYEE_MASTER> TSPL_EMPLOYEE_MASTER { get; set; }
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER1 { get; set; }
        public virtual Tspl_HR_Agency_Master Tspl_HR_Agency_Master { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HR_APPOINTMENT_LETTER> TSPL_HR_APPOINTMENT_LETTER { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER1 { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER2 { get; set; }
        public virtual TSPL_HR_RELATION_MASTER TSPL_HR_RELATION_MASTER { get; set; }
        public virtual TSPL_HR_REQUISITION TSPL_HR_REQUISITION { get; set; }
        public virtual TSPL_HR_SOURCE_TYPE TSPL_HR_SOURCE_TYPE { get; set; }
        public virtual TSPL_HR_SOURCE_TYPE_DETAIL TSPL_HR_SOURCE_TYPE_DETAIL { get; set; }
        public virtual TSPL_STATE_MASTER TSPL_STATE_MASTER { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HR_CHECK_APPLICANT_ENTRY> TSPL_HR_CHECK_APPLICANT_ENTRY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HR_EMP_HISTORY_APPLICANT_ENTRY> TSPL_HR_EMP_HISTORY_APPLICANT_ENTRY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HR_HIRE_EMPLOYEE> TSPL_HR_HIRE_EMPLOYEE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HR_INTERVIEW_SCHEDULE> TSPL_HR_INTERVIEW_SCHEDULE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HR_INTERVIEW_FEEDBACK> TSPL_HR_INTERVIEW_FEEDBACK { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HR_INTERVIEW_FEEDBACK_DETAIL> TSPL_HR_INTERVIEW_FEEDBACK_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HR_OFFER_LETTER> TSPL_HR_OFFER_LETTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HR_QUALIFICATION_APPLICANT_ENTRY> TSPL_HR_QUALIFICATION_APPLICANT_ENTRY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HR_REFERENCE_CHECK> TSPL_HR_REFERENCE_CHECK { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HR_SALARY_FITMENT> TSPL_HR_SALARY_FITMENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PAYHEAD_MASTER> TSPL_PAYHEAD_MASTER { get; set; }
    }
}
