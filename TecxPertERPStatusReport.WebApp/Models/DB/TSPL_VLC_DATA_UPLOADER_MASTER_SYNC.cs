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
    
    public partial class TSPL_VLC_DATA_UPLOADER_MASTER_SYNC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_VLC_DATA_UPLOADER_MASTER_SYNC()
        {
            this.TSPL_VLC_DATA_UPLOADER_DETAIL_SYNC = new HashSet<TSPL_VLC_DATA_UPLOADER_DETAIL_SYNC>();
        }
    
        public string Document_Code { get; set; }
        public System.DateTime Document_Date { get; set; }
        public string VLC_Code { get; set; }
        public string Route_Code { get; set; }
        public string Shift { get; set; }
        public string Comp_Code { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public Nullable<int> SYNC_STATUS { get; set; }
        public string Dock_Collection_Milk_Type { get; set; }
    
        public virtual TSPL_MCC_ROUTE_MASTER TSPL_MCC_ROUTE_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_VLC_DATA_UPLOADER_DETAIL_SYNC> TSPL_VLC_DATA_UPLOADER_DETAIL_SYNC { get; set; }
        public virtual TSPL_VLC_MASTER_HEAD TSPL_VLC_MASTER_HEAD { get; set; }
    }
}
