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
    
    public partial class TSPL_MILK_SHIFT_UPLOADER_DETAIL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_MILK_SHIFT_UPLOADER_DETAIL()
        {
            this.TSPL_MILK_RECEIPT_DETAIL = new HashSet<TSPL_MILK_RECEIPT_DETAIL>();
            this.TSPL_MILK_RECEIPT_DETAIL_SYNC = new HashSet<TSPL_MILK_RECEIPT_DETAIL_SYNC>();
            this.TSPL_MILK_REJECT_DETAIL = new HashSet<TSPL_MILK_REJECT_DETAIL>();
            this.TSPL_MILK_SHIFT_UPLOADER_QC_PARAMETER_DETAIL = new HashSet<TSPL_MILK_SHIFT_UPLOADER_QC_PARAMETER_DETAIL>();
        }
    
        public string TR_No { get; set; }
        public string Document_No { get; set; }
        public Nullable<int> SNo { get; set; }
        public string VLC_Code { get; set; }
        public Nullable<int> No_Of_Cans { get; set; }
        public Nullable<decimal> Milk_Weight { get; set; }
        public Nullable<decimal> FAT { get; set; }
        public Nullable<decimal> SNF { get; set; }
        public string Dock_Collection_Milk_Type { get; set; }
        public string Reject_Defaulter { get; set; }
        public string Reject_Type { get; set; }
        public int PageNo { get; set; }
        public Nullable<int> Against_Milk_Collection_DCS_Detail { get; set; }
        public string BULK_ROUTE_NO { get; set; }
        public Nullable<int> QAT { get; set; }
    
        public virtual TSPL_BULK_ROUTE_MASTER TSPL_BULK_ROUTE_MASTER { get; set; }
        public virtual TSPL_MILK_COLLECTION_DCS_DETAIL TSPL_MILK_COLLECTION_DCS_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_RECEIPT_DETAIL> TSPL_MILK_RECEIPT_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_RECEIPT_DETAIL_SYNC> TSPL_MILK_RECEIPT_DETAIL_SYNC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_REJECT_DETAIL> TSPL_MILK_REJECT_DETAIL { get; set; }
        public virtual TSPL_MILK_REJECT_TYPE TSPL_MILK_REJECT_TYPE { get; set; }
        public virtual TSPL_MILK_SHIFT_UPLOADER_HEAD TSPL_MILK_SHIFT_UPLOADER_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_SHIFT_UPLOADER_QC_PARAMETER_DETAIL> TSPL_MILK_SHIFT_UPLOADER_QC_PARAMETER_DETAIL { get; set; }
        public virtual TSPL_VLC_MASTER_HEAD TSPL_VLC_MASTER_HEAD { get; set; }
    }
}