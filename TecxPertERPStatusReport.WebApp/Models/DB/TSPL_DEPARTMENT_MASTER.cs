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
    
    public partial class TSPL_DEPARTMENT_MASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_DEPARTMENT_MASTER()
        {
            this.TSPL_COST_CENTER_TYPE_MASTER = new HashSet<TSPL_COST_CENTER_TYPE_MASTER>();
            this.TSPL_BONUS_GENERATION_DETAIL = new HashSet<TSPL_BONUS_GENERATION_DETAIL>();
            this.TSPL_EMPLOYEE_MASTER = new HashSet<TSPL_EMPLOYEE_MASTER>();
            this.TSPL_EMPLOYEE_STATUS = new HashSet<TSPL_EMPLOYEE_STATUS>();
            this.TSPL_EMPLOYEE_TRANSFER = new HashSet<TSPL_EMPLOYEE_TRANSFER>();
            this.TSPL_FF_SETTLEMENT_HEAD = new HashSet<TSPL_FF_SETTLEMENT_HEAD>();
            this.TSPL_HR_BUDGETING = new HashSet<TSPL_HR_BUDGETING>();
            this.Tspl_HR_EM_Exit_Interview_Head = new HashSet<Tspl_HR_EM_Exit_Interview_Head>();
            this.Tspl_HR_EM_Resignation_Letter = new HashSet<Tspl_HR_EM_Resignation_Letter>();
            this.Tspl_HR_EM_Termination_Letter = new HashSet<Tspl_HR_EM_Termination_Letter>();
            this.TSPL_HR_REQUISITION = new HashSet<TSPL_HR_REQUISITION>();
            this.TSPL_SUB_DEPARTMENT_MASTER = new HashSet<TSPL_SUB_DEPARTMENT_MASTER>();
        }
    
        public string DEPARTMENT_CODE { get; set; }
        public string DEPARTMENT_NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string Posted { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string comp_code { get; set; }
        public string DEPARTMENT_TYPE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_COST_CENTER_TYPE_MASTER> TSPL_COST_CENTER_TYPE_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_BONUS_GENERATION_DETAIL> TSPL_BONUS_GENERATION_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EMPLOYEE_MASTER> TSPL_EMPLOYEE_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EMPLOYEE_STATUS> TSPL_EMPLOYEE_STATUS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EMPLOYEE_TRANSFER> TSPL_EMPLOYEE_TRANSFER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_FF_SETTLEMENT_HEAD> TSPL_FF_SETTLEMENT_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HR_BUDGETING> TSPL_HR_BUDGETING { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tspl_HR_EM_Exit_Interview_Head> Tspl_HR_EM_Exit_Interview_Head { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tspl_HR_EM_Resignation_Letter> Tspl_HR_EM_Resignation_Letter { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tspl_HR_EM_Termination_Letter> Tspl_HR_EM_Termination_Letter { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HR_REQUISITION> TSPL_HR_REQUISITION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SUB_DEPARTMENT_MASTER> TSPL_SUB_DEPARTMENT_MASTER { get; set; }
    }
}