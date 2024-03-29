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
    
    public partial class TSPL_RICE_MIXING_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_RICE_MIXING_HEAD()
        {
            this.TSPL_RICE_MIXING_DETAIL = new HashSet<TSPL_RICE_MIXING_DETAIL>();
            this.TSPL_RICE_MIXING_FINISH_DETAIL = new HashSet<TSPL_RICE_MIXING_FINISH_DETAIL>();
        }
    
        public string Doc_No { get; set; }
        public Nullable<System.DateTime> Doc_Date { get; set; }
        public string Description { get; set; }
        public string From_Location { get; set; }
        public string To_Location { get; set; }
        public Nullable<double> Mixing_Charge { get; set; }
        public string Mixing_Unit { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modified_By { get; set; }
        public string Modified_Date { get; set; }
        public string Comp_Code { get; set; }
        public Nullable<int> Status { get; set; }
    
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_RICE_MIXING_DETAIL> TSPL_RICE_MIXING_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_RICE_MIXING_FINISH_DETAIL> TSPL_RICE_MIXING_FINISH_DETAIL { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
    }
}
