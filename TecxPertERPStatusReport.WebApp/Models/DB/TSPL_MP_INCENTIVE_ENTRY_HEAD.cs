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
    
    public partial class TSPL_MP_INCENTIVE_ENTRY_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_MP_INCENTIVE_ENTRY_HEAD()
        {
            this.TSPL_MP_INCENTIVE_ENTRY_DETAIL = new HashSet<TSPL_MP_INCENTIVE_ENTRY_DETAIL>();
            this.TSPL_MP_INCENTIVE_ENTRY_VLC_STATUS = new HashSet<TSPL_MP_INCENTIVE_ENTRY_VLC_STATUS>();
        }
    
        public string Document_Code { get; set; }
        public System.DateTime Document_Date { get; set; }
        public string MCC_Code { get; set; }
        public System.DateTime From_Date { get; set; }
        public System.DateTime To_Date { get; set; }
        public Nullable<decimal> Incetive_Rate { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string Posted_By { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> FATSNFPer { get; set; }
    
        public virtual TSPL_MCC_MASTER TSPL_MCC_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MP_INCENTIVE_ENTRY_DETAIL> TSPL_MP_INCENTIVE_ENTRY_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MP_INCENTIVE_ENTRY_VLC_STATUS> TSPL_MP_INCENTIVE_ENTRY_VLC_STATUS { get; set; }
    }
}
