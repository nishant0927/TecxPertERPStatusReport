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
    
    public partial class TSPL_WS_CS_RECORD_MASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_WS_CS_RECORD_MASTER()
        {
            this.TSPL_WS_CS_RECORD_DETAIL = new HashSet<TSPL_WS_CS_RECORD_DETAIL>();
        }
    
        public string Document_No { get; set; }
        public Nullable<System.DateTime> Document_Date { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public string Cust_Code { get; set; }
        public string location_code { get; set; }
        public Nullable<int> IsSampling { get; set; }
        public string Booking_Type { get; set; }
        public string Card_SALE_No { get; set; }
        public Nullable<System.DateTime> CardSale_FROM_DATE { get; set; }
        public Nullable<System.DateTime> CardSale_TO_DATE { get; set; }
        public string Payment_Mode { get; set; }
        public Nullable<double> AdvanceAmount { get; set; }
        public string Created_By { get; set; }
        public string Transaction_ID { get; set; }
        public string Err_Code { get; set; }
        public string Err_desc { get; set; }
        public string Request_Type { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_WS_CS_RECORD_DETAIL> TSPL_WS_CS_RECORD_DETAIL { get; set; }
        public virtual TSPL_WS_ERROR_CODE TSPL_WS_ERROR_CODE { get; set; }
    }
}
