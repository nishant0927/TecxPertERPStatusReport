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
    
    public partial class TSPL_CREATE_BI_FILTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_CREATE_BI_FILTER()
        {
            this.TSPL_CREATE_BI_REPORT_FILTERS = new HashSet<TSPL_CREATE_BI_REPORT_FILTERS>();
            this.TSPL_CREATE_BI_REPORT_FILTERS_INNER = new HashSet<TSPL_CREATE_BI_REPORT_FILTERS_INNER>();
            this.TSPL_CREATE_BI_REPORT = new HashSet<TSPL_CREATE_BI_REPORT>();
            this.TSPL_CREATE_BI_FILTER_DETAIL = new HashSet<TSPL_CREATE_BI_FILTER_DETAIL>();
        }
    
        public string Code { get; set; }
        public string Description { get; set; }
        public string Qry { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public string Modify_By { get; set; }
        public Nullable<System.DateTime> Modify_Date { get; set; }
        public string Comp_Code { get; set; }
        public int Is_Create_By_Developer { get; set; }
        public string Filter_Type { get; set; }
        public int Tree_Level { get; set; }
        public int Is_Security_Location { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CREATE_BI_REPORT_FILTERS> TSPL_CREATE_BI_REPORT_FILTERS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CREATE_BI_REPORT_FILTERS_INNER> TSPL_CREATE_BI_REPORT_FILTERS_INNER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CREATE_BI_REPORT> TSPL_CREATE_BI_REPORT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CREATE_BI_FILTER_DETAIL> TSPL_CREATE_BI_FILTER_DETAIL { get; set; }
    }
}
