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
    
    public partial class TSPL_TDS_SECTION_MASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_TDS_SECTION_MASTER()
        {
            this.TSPL_TDS_PAYMENT_HEADER = new HashSet<TSPL_TDS_PAYMENT_HEADER>();
        }
    
        public string TDS_Group { get; set; }
        public string Description { get; set; }
        public string Report_Section { get; set; }
        public string Cumulative_Cutoff { get; set; }
        public string Include_Tax { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modify_By { get; set; }
        public string Modify_Date { get; set; }
        public string Comp_Code { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_TDS_PAYMENT_HEADER> TSPL_TDS_PAYMENT_HEADER { get; set; }
    }
}
