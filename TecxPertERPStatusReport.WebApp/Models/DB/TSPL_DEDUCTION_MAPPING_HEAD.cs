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
    
    public partial class TSPL_DEDUCTION_MAPPING_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_DEDUCTION_MAPPING_HEAD()
        {
            this.TSPL_DEDUCTION_MAPPING_DETAIL = new HashSet<TSPL_DEDUCTION_MAPPING_DETAIL>();
            this.TSPL_MCC_MASTER = new HashSet<TSPL_MCC_MASTER>();
            this.TSPL_VLC_MASTER_HEAD = new HashSet<TSPL_VLC_MASTER_HEAD>();
        }
    
        public string Doc_Code { get; set; }
        public System.DateTime Doc_Date { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> Start_Date { get; set; }
        public Nullable<System.DateTime> End_Date { get; set; }
        public Nullable<int> Is_Round_Down { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modify_By { get; set; }
        public System.DateTime Modify_Date { get; set; }
        public int Post_Status { get; set; }
        public string Posted_By { get; set; }
        public Nullable<System.DateTime> Posted_Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DEDUCTION_MAPPING_DETAIL> TSPL_DEDUCTION_MAPPING_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MCC_MASTER> TSPL_MCC_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_VLC_MASTER_HEAD> TSPL_VLC_MASTER_HEAD { get; set; }
    }
}
