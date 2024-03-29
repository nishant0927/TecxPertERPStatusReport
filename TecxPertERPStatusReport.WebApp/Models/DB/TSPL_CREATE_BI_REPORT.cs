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
    
    public partial class TSPL_CREATE_BI_REPORT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_CREATE_BI_REPORT()
        {
            this.TSPL_CREATE_BI_REPORT1 = new HashSet<TSPL_CREATE_BI_REPORT>();
            this.TSPL_CREATE_DASHBOARD_DETAIL = new HashSet<TSPL_CREATE_DASHBOARD_DETAIL>();
            this.TSPL_CREATE_BI_REPORT_FILTERS = new HashSet<TSPL_CREATE_BI_REPORT_FILTERS>();
            this.TSPL_CREATE_BI_REPORT_FILTERS_INNER = new HashSet<TSPL_CREATE_BI_REPORT_FILTERS_INNER>();
        }
    
        public string Code { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Qry { get; set; }
        public string Layout { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public string Modify_By { get; set; }
        public Nullable<System.DateTime> Modify_Date { get; set; }
        public string Comp_Code { get; set; }
        public string Report_Module { get; set; }
        public string Chart_Type { get; set; }
        public string Chart_Category_Member { get; set; }
        public string Chart_Series_Member { get; set; }
        public string Chart_Value_Member { get; set; }
        public int Is_Create_By_Developer { get; set; }
        public int is_For_Dashboard { get; set; }
        public string Chart_Combine_Mode { get; set; }
        public string Chart_Orientation { get; set; }
        public Nullable<int> Chart_Label_Rotation { get; set; }
        public Nullable<int> Chart_Show_Label { get; set; }
        public int Chart_Show_Scroll { get; set; }
        public int Drill_Down_Type { get; set; }
        public string Drill_Down_Filter { get; set; }
        public string Drill_Down_Column { get; set; }
        public string Drill_Down_Transaction_Type { get; set; }
        public string Drill_Down_Report { get; set; }
    
        public virtual TSPL_CREATE_BI_FILTER TSPL_CREATE_BI_FILTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CREATE_BI_REPORT> TSPL_CREATE_BI_REPORT1 { get; set; }
        public virtual TSPL_CREATE_BI_REPORT TSPL_CREATE_BI_REPORT2 { get; set; }
        public virtual TSPL_PROGRAM_MASTER TSPL_PROGRAM_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CREATE_DASHBOARD_DETAIL> TSPL_CREATE_DASHBOARD_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CREATE_BI_REPORT_FILTERS> TSPL_CREATE_BI_REPORT_FILTERS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CREATE_BI_REPORT_FILTERS_INNER> TSPL_CREATE_BI_REPORT_FILTERS_INNER { get; set; }
    }
}
