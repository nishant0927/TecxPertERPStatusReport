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
    
    public partial class TSPL_SILAGE_CRITERIA_APPLICATION_MASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_SILAGE_CRITERIA_APPLICATION_MASTER()
        {
            this.TSPL_SILAGE_CRITERIA_APPLICATION_DETAIL = new HashSet<TSPL_SILAGE_CRITERIA_APPLICATION_DETAIL>();
            this.TSPL_SILAGE_CRITERIA_ENTREPRENEUR_DETAIL = new HashSet<TSPL_SILAGE_CRITERIA_ENTREPRENEUR_DETAIL>();
            this.TSPL_SILAGE_CRITERIA_ENTREPRENEUR_MASTER = new HashSet<TSPL_SILAGE_CRITERIA_ENTREPRENEUR_MASTER>();
        }
    
        public string App_No { get; set; }
        public string App_Type { get; set; }
        public string Add1 { get; set; }
        public string Add2 { get; set; }
        public string Add3 { get; set; }
        public string Country_Code { get; set; }
        public string State_Code { get; set; }
        public string City_Code { get; set; }
        public string Zip_Code { get; set; }
        public string Person { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string Entr_Type { get; set; }
        public string Area_Code { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modified_By { get; set; }
        public string Modified_Date { get; set; }
    
        public virtual TSPL_SILAGE_AREA_CRITERIA_MASTER TSPL_SILAGE_AREA_CRITERIA_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SILAGE_CRITERIA_APPLICATION_DETAIL> TSPL_SILAGE_CRITERIA_APPLICATION_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SILAGE_CRITERIA_ENTREPRENEUR_DETAIL> TSPL_SILAGE_CRITERIA_ENTREPRENEUR_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SILAGE_CRITERIA_ENTREPRENEUR_MASTER> TSPL_SILAGE_CRITERIA_ENTREPRENEUR_MASTER { get; set; }
    }
}
