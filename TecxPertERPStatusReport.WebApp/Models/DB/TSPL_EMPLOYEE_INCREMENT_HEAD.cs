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
    
    public partial class TSPL_EMPLOYEE_INCREMENT_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_EMPLOYEE_INCREMENT_HEAD()
        {
            this.TSPL_EMPLOYEE_INCREMENT_DETAIL = new HashSet<TSPL_EMPLOYEE_INCREMENT_DETAIL>();
        }
    
        public string INCREMENT_CODE { get; set; }
        public System.DateTime INCREMENT_DATE { get; set; }
        public string EMP_SAL_CODE { get; set; }
        public int REVISION_NO { get; set; }
        public string EMP_CODE { get; set; }
        public System.DateTime APPLICABLE_FROM { get; set; }
        public string SALARY_STRUCTURE_CODE { get; set; }
        public bool POSTED { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string location_Code { get; set; }
        public string Location_Desc { get; set; }
        public string DEVISION_CODE { get; set; }
        public string Devision_Name { get; set; }
        public string EMP_SAL_CODE_NEW { get; set; }
        public Nullable<System.DateTime> ARREAR_FROM { get; set; }
    
        public virtual TSPL_DEVISION_MASTER TSPL_DEVISION_MASTER { get; set; }
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER { get; set; }
        public virtual TSPL_EMPLOYEE_SALARY TSPL_EMPLOYEE_SALARY { get; set; }
        public virtual TSPL_EMPLOYEE_SALARY TSPL_EMPLOYEE_SALARY1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EMPLOYEE_INCREMENT_DETAIL> TSPL_EMPLOYEE_INCREMENT_DETAIL { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_SALARY_STRUCTURE TSPL_SALARY_STRUCTURE { get; set; }
    }
}
