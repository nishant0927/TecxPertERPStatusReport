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
    
    public partial class TSPL_DISTRIBUTOR_ROUTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_DISTRIBUTOR_ROUTE()
        {
            this.TSPL_DISTRIBUTOR_COMMISSION_HEAD = new HashSet<TSPL_DISTRIBUTOR_COMMISSION_HEAD>();
            this.TSPL_DISTRIBUTOR_ROUTE_CUSTOMER = new HashSet<TSPL_DISTRIBUTOR_ROUTE_CUSTOMER>();
        }
    
        public string Code { get; set; }
        public System.DateTime Start_Date { get; set; }
        public Nullable<System.DateTime> End_Date { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> Status { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string Post_By { get; set; }
        public Nullable<System.DateTime> Post_Date { get; set; }
        public int IS_Transpoter { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DISTRIBUTOR_COMMISSION_HEAD> TSPL_DISTRIBUTOR_COMMISSION_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DISTRIBUTOR_ROUTE_CUSTOMER> TSPL_DISTRIBUTOR_ROUTE_CUSTOMER { get; set; }
    }
}
