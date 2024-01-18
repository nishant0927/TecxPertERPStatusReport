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
    
    public partial class TSPL_LINE_MASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_LINE_MASTER()
        {
            this.TSPL_PE_FINALQC_HEAD = new HashSet<TSPL_PE_FINALQC_HEAD>();
            this.TSPL_PP_BATCH_ORDER_HEAD = new HashSet<TSPL_PP_BATCH_ORDER_HEAD>();
            this.TSPL_PP_ISSUE_HEAD = new HashSet<TSPL_PP_ISSUE_HEAD>();
            this.TSPL_PP_PRODUCTION_ENTRY = new HashSet<TSPL_PP_PRODUCTION_ENTRY>();
            this.TSPL_PP_PRODUCTION_RETURN = new HashSet<TSPL_PP_PRODUCTION_RETURN>();
            this.TSPL_PP_PRODUCTION_PLAN_HEAD = new HashSet<TSPL_PP_PRODUCTION_PLAN_HEAD>();
            this.TSPL_PP_STANDARDIZATION_HEAD = new HashSet<TSPL_PP_STANDARDIZATION_HEAD>();
            this.TSPL_PP_STD_FINALQC_HEAD = new HashSet<TSPL_PP_STD_FINALQC_HEAD>();
            this.TSPL_PP_STAGE_PROCESS_HEAD = new HashSet<TSPL_PP_STAGE_PROCESS_HEAD>();
            this.TSPL_SPP_PRODUCTION_ENTRY = new HashSet<TSPL_SPP_PRODUCTION_ENTRY>();
        }
    
        public string LINE_NO { get; set; }
        public string MACHINE_NAME { get; set; }
        public string MACHINE_RATED { get; set; }
        public string CAPACITY { get; set; }
        public string TIME_FRAME { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modify_By { get; set; }
        public System.DateTime Modify_Date { get; set; }
        public string Comp_code { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PE_FINALQC_HEAD> TSPL_PE_FINALQC_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PP_BATCH_ORDER_HEAD> TSPL_PP_BATCH_ORDER_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PP_ISSUE_HEAD> TSPL_PP_ISSUE_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PP_PRODUCTION_ENTRY> TSPL_PP_PRODUCTION_ENTRY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PP_PRODUCTION_RETURN> TSPL_PP_PRODUCTION_RETURN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PP_PRODUCTION_PLAN_HEAD> TSPL_PP_PRODUCTION_PLAN_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PP_STANDARDIZATION_HEAD> TSPL_PP_STANDARDIZATION_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PP_STD_FINALQC_HEAD> TSPL_PP_STD_FINALQC_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PP_STAGE_PROCESS_HEAD> TSPL_PP_STAGE_PROCESS_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SPP_PRODUCTION_ENTRY> TSPL_SPP_PRODUCTION_ENTRY { get; set; }
    }
}
