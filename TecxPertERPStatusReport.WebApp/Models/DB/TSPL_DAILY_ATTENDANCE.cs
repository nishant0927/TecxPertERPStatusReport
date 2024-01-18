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
    
    public partial class TSPL_DAILY_ATTENDANCE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_DAILY_ATTENDANCE()
        {
            this.TSPL_LEAVE_ALLOTMENT = new HashSet<TSPL_LEAVE_ALLOTMENT>();
        }
    
        public string DLA_CODE { get; set; }
        public string PAY_PERIOD_CODE { get; set; }
        public string REGISTER_TYPE { get; set; }
        public string ENTEREDBY_EMP_CODE { get; set; }
        public string DESCRIPTION { get; set; }
        public bool POSTED { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public Nullable<System.DateTime> Att_Date { get; set; }
        public string Location_Code { get; set; }
    
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_PAYPERIOD_MASTER TSPL_PAYPERIOD_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_LEAVE_ALLOTMENT> TSPL_LEAVE_ALLOTMENT { get; set; }
    }
}
