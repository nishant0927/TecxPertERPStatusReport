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
    
    public partial class TSPL_DESIGNATION_MASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_DESIGNATION_MASTER()
        {
            this.TSPL_BONUS_GENERATION_DETAIL = new HashSet<TSPL_BONUS_GENERATION_DETAIL>();
            this.TSPL_DESIGNATION_MASTER_HIERARCHY = new HashSet<TSPL_DESIGNATION_MASTER_HIERARCHY>();
            this.TSPL_DESIGNATION_MASTER_HIERARCHY1 = new HashSet<TSPL_DESIGNATION_MASTER_HIERARCHY>();
            this.TSPL_EMPLOYEE_STATUS = new HashSet<TSPL_EMPLOYEE_STATUS>();
            this.TSPL_EMPLOYEE_EXPERIENCE = new HashSet<TSPL_EMPLOYEE_EXPERIENCE>();
            this.TSPL_EMPLOYEE_EXPERIENCE1 = new HashSet<TSPL_EMPLOYEE_EXPERIENCE>();
            this.TSPL_EMPLOYEE_TRANSFER = new HashSet<TSPL_EMPLOYEE_TRANSFER>();
            this.TSPL_FF_SETTLEMENT_HEAD = new HashSet<TSPL_FF_SETTLEMENT_HEAD>();
            this.Tspl_HR_EM_Exit_Interview_Head = new HashSet<Tspl_HR_EM_Exit_Interview_Head>();
            this.TSPL_HR_EMP_HISTORY_APPLICANT_ENTRY = new HashSet<TSPL_HR_EMP_HISTORY_APPLICANT_ENTRY>();
            this.TSPL_HR_REQUISITION = new HashSet<TSPL_HR_REQUISITION>();
        }
    
        public string Designation_id { get; set; }
        public string Designation_Desc { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modify_By { get; set; }
        public string Modify_Date { get; set; }
        public string Comp_Code { get; set; }
        public string Level_Code { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_BONUS_GENERATION_DETAIL> TSPL_BONUS_GENERATION_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DESIGNATION_MASTER_HIERARCHY> TSPL_DESIGNATION_MASTER_HIERARCHY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DESIGNATION_MASTER_HIERARCHY> TSPL_DESIGNATION_MASTER_HIERARCHY1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EMPLOYEE_STATUS> TSPL_EMPLOYEE_STATUS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EMPLOYEE_EXPERIENCE> TSPL_EMPLOYEE_EXPERIENCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EMPLOYEE_EXPERIENCE> TSPL_EMPLOYEE_EXPERIENCE1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EMPLOYEE_TRANSFER> TSPL_EMPLOYEE_TRANSFER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_FF_SETTLEMENT_HEAD> TSPL_FF_SETTLEMENT_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tspl_HR_EM_Exit_Interview_Head> Tspl_HR_EM_Exit_Interview_Head { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HR_EMP_HISTORY_APPLICANT_ENTRY> TSPL_HR_EMP_HISTORY_APPLICANT_ENTRY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HR_REQUISITION> TSPL_HR_REQUISITION { get; set; }
    }
}