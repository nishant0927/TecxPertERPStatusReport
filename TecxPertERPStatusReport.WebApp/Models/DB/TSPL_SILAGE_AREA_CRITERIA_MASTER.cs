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
    
    public partial class TSPL_SILAGE_AREA_CRITERIA_MASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_SILAGE_AREA_CRITERIA_MASTER()
        {
            this.TSPL_SILAGE_AREA_CRITERIA_DETAIL = new HashSet<TSPL_SILAGE_AREA_CRITERIA_DETAIL>();
            this.TSPL_SILAGE_CRITERIA_APPLICATION_DETAIL = new HashSet<TSPL_SILAGE_CRITERIA_APPLICATION_DETAIL>();
            this.TSPL_SILAGE_CRITERIA_APPLICATION_MASTER = new HashSet<TSPL_SILAGE_CRITERIA_APPLICATION_MASTER>();
            this.TSPL_SILAGE_CRITERIA_ENTREPRENEUR_DETAIL = new HashSet<TSPL_SILAGE_CRITERIA_ENTREPRENEUR_DETAIL>();
            this.TSPL_SILAGE_CRITERIA_ENTREPRENEUR_MASTER = new HashSet<TSPL_SILAGE_CRITERIA_ENTREPRENEUR_MASTER>();
            this.TSPL_SILAGE_CRITERIA_FARMER_DETAIL = new HashSet<TSPL_SILAGE_CRITERIA_FARMER_DETAIL>();
            this.TSPL_SILAGE_CRITERIA_FARMER_MASTER = new HashSet<TSPL_SILAGE_CRITERIA_FARMER_MASTER>();
            this.TSPL_SILAGE_ENTREPRENEUR_DOCUMENT_MASTER = new HashSet<TSPL_SILAGE_ENTREPRENEUR_DOCUMENT_MASTER>();
        }
    
        public string Area_Code { get; set; }
        public string Area_Name { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modified_By { get; set; }
        public string Modified_Date { get; set; }
        public Nullable<int> Current_Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SILAGE_AREA_CRITERIA_DETAIL> TSPL_SILAGE_AREA_CRITERIA_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SILAGE_CRITERIA_APPLICATION_DETAIL> TSPL_SILAGE_CRITERIA_APPLICATION_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SILAGE_CRITERIA_APPLICATION_MASTER> TSPL_SILAGE_CRITERIA_APPLICATION_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SILAGE_CRITERIA_ENTREPRENEUR_DETAIL> TSPL_SILAGE_CRITERIA_ENTREPRENEUR_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SILAGE_CRITERIA_ENTREPRENEUR_MASTER> TSPL_SILAGE_CRITERIA_ENTREPRENEUR_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SILAGE_CRITERIA_FARMER_DETAIL> TSPL_SILAGE_CRITERIA_FARMER_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SILAGE_CRITERIA_FARMER_MASTER> TSPL_SILAGE_CRITERIA_FARMER_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SILAGE_ENTREPRENEUR_DOCUMENT_MASTER> TSPL_SILAGE_ENTREPRENEUR_DOCUMENT_MASTER { get; set; }
    }
}