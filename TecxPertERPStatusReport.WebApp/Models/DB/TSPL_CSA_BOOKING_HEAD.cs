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
    
    public partial class TSPL_CSA_BOOKING_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_CSA_BOOKING_HEAD()
        {
            this.TSPL_CSA_BOOKING_DETAIL = new HashSet<TSPL_CSA_BOOKING_DETAIL>();
            this.TSPL_CSA_DO_HEAD = new HashSet<TSPL_CSA_DO_HEAD>();
            this.TSPL_CSA_DO_DETAIL = new HashSet<TSPL_CSA_DO_DETAIL>();
        }
    
        public string BOOKING_NO { get; set; }
        public string DESCRIPTION { get; set; }
        public System.DateTime BOOKING_DATE { get; set; }
        public string CSA_CODE { get; set; }
        public int Posted { get; set; }
        public Nullable<System.DateTime> POSTING_DATE { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modified_By { get; set; }
        public string Modified_Date { get; set; }
        public string Comp_Code { get; set; }
        public string Booking_Type { get; set; }
        public string Trans_Type { get; set; }
        public string Request_Mode { get; set; }
        public string Location_Code { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CSA_BOOKING_DETAIL> TSPL_CSA_BOOKING_DETAIL { get; set; }
        public virtual TSPL_CUSTOMER_MASTER TSPL_CUSTOMER_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CSA_DO_HEAD> TSPL_CSA_DO_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CSA_DO_DETAIL> TSPL_CSA_DO_DETAIL { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
    }
}