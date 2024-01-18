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
    
    public partial class TSPL_QC_LOG_SHEET_MASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_QC_LOG_SHEET_MASTER()
        {
            this.TSPL_ITEM_MASTER_PURCHASE_QC_PARAMETER = new HashSet<TSPL_ITEM_MASTER_PURCHASE_QC_PARAMETER>();
            this.TSPL_PARAMETER_RANGE_MASTER_QC = new HashSet<TSPL_PARAMETER_RANGE_MASTER_QC>();
            this.TSPL_PARAMETER_RANGE_MASTER_QC_HISTORY = new HashSet<TSPL_PARAMETER_RANGE_MASTER_QC_HISTORY>();
            this.TSPL_PP_PE_STAGE_QC_LOG_SHEET = new HashSet<TSPL_PP_PE_STAGE_QC_LOG_SHEET>();
            this.TSPL_PP_STAGE_PROCESS_QC_LOG_SHEET = new HashSet<TSPL_PP_STAGE_PROCESS_QC_LOG_SHEET>();
            this.TSPL_PP_STD_QC_LOG_SHEET = new HashSet<TSPL_PP_STD_QC_LOG_SHEET>();
            this.TSPL_QC_CHECK_SRN_DETAIL = new HashSet<TSPL_QC_CHECK_SRN_DETAIL>();
            this.TSPL_QC_VENDOR_ITEM_MAPPING_DETAIL = new HashSet<TSPL_QC_VENDOR_ITEM_MAPPING_DETAIL>();
            this.TSPL_SPP_PE_STAGE_QC_LOG_SHEET = new HashSet<TSPL_SPP_PE_STAGE_QC_LOG_SHEET>();
            this.TSPL_QC_LOG_SHEET_MASTER1 = new HashSet<TSPL_QC_LOG_SHEET_MASTER>();
            this.TSPL_QC_LOG_SHEET_MASTER2 = new HashSet<TSPL_QC_LOG_SHEET_MASTER>();
        }
    
        public string Comp_Code { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Nature { get; set; }
        public int IsMandatory { get; set; }
        public int IsRequired_InParameter_Master { get; set; }
        public string Department_Code { get; set; }
        public string Parameter_Code { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modified_By { get; set; }
        public string Modified_Date { get; set; }
        public int Pick_Batch_No { get; set; }
        public string Trans_Id { get; set; }
        public string AliasName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ITEM_MASTER_PURCHASE_QC_PARAMETER> TSPL_ITEM_MASTER_PURCHASE_QC_PARAMETER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PARAMETER_RANGE_MASTER_QC> TSPL_PARAMETER_RANGE_MASTER_QC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PARAMETER_RANGE_MASTER_QC_HISTORY> TSPL_PARAMETER_RANGE_MASTER_QC_HISTORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PP_PE_STAGE_QC_LOG_SHEET> TSPL_PP_PE_STAGE_QC_LOG_SHEET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PP_STAGE_PROCESS_QC_LOG_SHEET> TSPL_PP_STAGE_PROCESS_QC_LOG_SHEET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PP_STD_QC_LOG_SHEET> TSPL_PP_STD_QC_LOG_SHEET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_QC_CHECK_SRN_DETAIL> TSPL_QC_CHECK_SRN_DETAIL { get; set; }
        public virtual TSPL_QC_LOG_SHEET_USER_MASTER TSPL_QC_LOG_SHEET_USER_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_QC_VENDOR_ITEM_MAPPING_DETAIL> TSPL_QC_VENDOR_ITEM_MAPPING_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SPP_PE_STAGE_QC_LOG_SHEET> TSPL_SPP_PE_STAGE_QC_LOG_SHEET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_QC_LOG_SHEET_MASTER> TSPL_QC_LOG_SHEET_MASTER1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_QC_LOG_SHEET_MASTER> TSPL_QC_LOG_SHEET_MASTER2 { get; set; }
    }
}