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
    
    public partial class TSPL_HR_PERFORMANCE_CATEGORY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_HR_PERFORMANCE_CATEGORY()
        {
            this.TSPL_HR_PERFORMANCE_GROUP = new HashSet<TSPL_HR_PERFORMANCE_GROUP>();
            this.TSPL_HR_Performance_Master = new HashSet<TSPL_HR_Performance_Master>();
        }
    
        public string Code { get; set; }
        public string Description { get; set; }
        public bool IsKRA { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Created_By { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string Comp_Code { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HR_PERFORMANCE_GROUP> TSPL_HR_PERFORMANCE_GROUP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HR_Performance_Master> TSPL_HR_Performance_Master { get; set; }
    }
}