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
    
    public partial class TSPL_SECTION_STAGE_MAPPING_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_SECTION_STAGE_MAPPING_HEAD()
        {
            this.TSPL_PE_FINALQC_HEAD = new HashSet<TSPL_PE_FINALQC_HEAD>();
            this.TSPL_PP_PRODUCTION_ENTRY = new HashSet<TSPL_PP_PRODUCTION_ENTRY>();
            this.TSPL_PP_STAGE_PROCESS_HEAD = new HashSet<TSPL_PP_STAGE_PROCESS_HEAD>();
            this.TSPL_PP_STANDARDIZATION_HEAD = new HashSet<TSPL_PP_STANDARDIZATION_HEAD>();
            this.TSPL_PP_STD_FINALQC_HEAD = new HashSet<TSPL_PP_STD_FINALQC_HEAD>();
            this.TSPL_SPP_PRODUCTION_ENTRY = new HashSet<TSPL_SPP_PRODUCTION_ENTRY>();
        }
    
        public string Section_Code { get; set; }
        public string Structure_Code { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modified_By { get; set; }
        public string Modified_Date { get; set; }
        public string Doc_Code { get; set; }
        public Nullable<System.DateTime> Doc_Date { get; set; }
        public string Comp_Code { get; set; }
    
        public virtual TSPL_COMPANY_MASTER TSPL_COMPANY_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PE_FINALQC_HEAD> TSPL_PE_FINALQC_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PP_PRODUCTION_ENTRY> TSPL_PP_PRODUCTION_ENTRY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PP_STAGE_PROCESS_HEAD> TSPL_PP_STAGE_PROCESS_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PP_STANDARDIZATION_HEAD> TSPL_PP_STANDARDIZATION_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PP_STD_FINALQC_HEAD> TSPL_PP_STD_FINALQC_HEAD { get; set; }
        public virtual TSPL_SECTION_MASTER TSPL_SECTION_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SPP_PRODUCTION_ENTRY> TSPL_SPP_PRODUCTION_ENTRY { get; set; }
    }
}
