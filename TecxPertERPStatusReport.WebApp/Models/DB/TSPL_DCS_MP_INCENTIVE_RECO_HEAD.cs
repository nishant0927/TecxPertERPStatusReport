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
    
    public partial class TSPL_DCS_MP_INCENTIVE_RECO_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_DCS_MP_INCENTIVE_RECO_HEAD()
        {
            this.TSPL_DCS_MP_INCENTIVE_RECO_DETAIL = new HashSet<TSPL_DCS_MP_INCENTIVE_RECO_DETAIL>();
            this.TSPL_DCS_MP_INCENTIVE_RECO_DETAIL_INVALID = new HashSet<TSPL_DCS_MP_INCENTIVE_RECO_DETAIL_INVALID>();
        }
    
        public string Document_Code { get; set; }
        public System.DateTime Document_Date { get; set; }
        public System.DateTime Reco_Date { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string Posted_By { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.DateTime> Reco_Date_To { get; set; }
        public string Zone_Code { get; set; }
        public Nullable<decimal> Apply_FAT_Above { get; set; }
        public Nullable<decimal> Apply_SNF_Above { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DCS_MP_INCENTIVE_RECO_DETAIL> TSPL_DCS_MP_INCENTIVE_RECO_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DCS_MP_INCENTIVE_RECO_DETAIL_INVALID> TSPL_DCS_MP_INCENTIVE_RECO_DETAIL_INVALID { get; set; }
        public virtual TSPL_ZONE_MASTER TSPL_ZONE_MASTER { get; set; }
    }
}