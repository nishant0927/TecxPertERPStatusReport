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
    
    public partial class TSPL_NOTIFY_PARTY_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_NOTIFY_PARTY_HEAD()
        {
            this.TSPL_NOTIFY_PARTY_SHIP_DETAIL = new HashSet<TSPL_NOTIFY_PARTY_SHIP_DETAIL>();
            this.TSPL_NOTIFY_PARTY_DETAIL = new HashSet<TSPL_NOTIFY_PARTY_DETAIL>();
        }
    
        public string Comp_Code { get; set; }
        public string Doc_No { get; set; }
        public string Description { get; set; }
        public string Cust_Code { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modified_By { get; set; }
        public string Modified_Date { get; set; }
    
        public virtual TSPL_CUSTOMER_MASTER TSPL_CUSTOMER_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_NOTIFY_PARTY_SHIP_DETAIL> TSPL_NOTIFY_PARTY_SHIP_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_NOTIFY_PARTY_DETAIL> TSPL_NOTIFY_PARTY_DETAIL { get; set; }
    }
}
