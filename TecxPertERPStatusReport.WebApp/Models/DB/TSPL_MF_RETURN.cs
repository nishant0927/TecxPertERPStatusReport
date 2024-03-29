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
    
    public partial class TSPL_MF_RETURN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_MF_RETURN()
        {
            this.TSPL_MF_RETURN_DETAIL = new HashSet<TSPL_MF_RETURN_DETAIL>();
        }
    
        public string RETURN_CODE { get; set; }
        public string DESCRIPTION { get; set; }
        public System.DateTime RETURN_DATE { get; set; }
        public System.DateTime EXP_DATE { get; set; }
        public string RETURNED_BY { get; set; }
        public string RETURNED_TO { get; set; }
        public string LOCATION_CODE { get; set; }
        public string LOCATION_CODE_FROM { get; set; }
        public string COMMENTS { get; set; }
        public bool POSTED { get; set; }
        public Nullable<System.DateTime> POSTING_DATE { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string TR_TYPE { get; set; }
        public string comp_code { get; set; }
    
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER { get; set; }
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER1 { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MF_RETURN_DETAIL> TSPL_MF_RETURN_DETAIL { get; set; }
    }
}
