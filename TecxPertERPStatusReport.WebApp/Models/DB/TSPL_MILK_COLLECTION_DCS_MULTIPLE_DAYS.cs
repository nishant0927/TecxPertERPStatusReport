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
    
    public partial class TSPL_MILK_COLLECTION_DCS_MULTIPLE_DAYS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_MILK_COLLECTION_DCS_MULTIPLE_DAYS()
        {
            this.TSPL_MILK_COLLECTION_MCC = new HashSet<TSPL_MILK_COLLECTION_MCC>();
            this.TSPL_MILK_COLLECTION_DCS_MULTIPLE_DAYS_DETAIL = new HashSet<TSPL_MILK_COLLECTION_DCS_MULTIPLE_DAYS_DETAIL>();
        }
    
        public string Document_No { get; set; }
        public System.DateTime Document_Date { get; set; }
        public string Route_Code { get; set; }
        public string Tanker_No { get; set; }
        public string Vehicle_No { get; set; }
        public string MCC_Code { get; set; }
        public Nullable<decimal> Entered_Qty { get; set; }
        public Nullable<decimal> Entered_FATKg { get; set; }
        public Nullable<decimal> Entered_SNFKg { get; set; }
        public string Description { get; set; }
        public Nullable<int> FAT_SNF_Type { get; set; }
        public int Status { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public Nullable<System.DateTime> Posted_Date { get; set; }
        public string Posted_By { get; set; }
    
        public virtual TSPL_BULK_ROUTE_MASTER TSPL_BULK_ROUTE_MASTER { get; set; }
        public virtual TSPL_MCC_MASTER TSPL_MCC_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_COLLECTION_MCC> TSPL_MILK_COLLECTION_MCC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_COLLECTION_DCS_MULTIPLE_DAYS_DETAIL> TSPL_MILK_COLLECTION_DCS_MULTIPLE_DAYS_DETAIL { get; set; }
        public virtual TSPL_TANKER_MASTER TSPL_TANKER_MASTER { get; set; }
    }
}