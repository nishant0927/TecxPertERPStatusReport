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
    
    public partial class TSPL_SPP_PRODUCTION_ENTRY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_SPP_PRODUCTION_ENTRY()
        {
            this.TSPL_SPP_PRODUCTION_CONSUMPTION_DETAIL = new HashSet<TSPL_SPP_PRODUCTION_CONSUMPTION_DETAIL>();
            this.TSPL_SPP_PE_SCRAP_DETAIL = new HashSet<TSPL_SPP_PE_SCRAP_DETAIL>();
            this.TSPL_SPP_PE_QC_DETAIL = new HashSet<TSPL_SPP_PE_QC_DETAIL>();
            this.TSPL_SPP_PE_WRECKAGE_FLASHING = new HashSet<TSPL_SPP_PE_WRECKAGE_FLASHING>();
            this.TSPL_SPP_PE_STAGE_QC_LOG_SHEET = new HashSet<TSPL_SPP_PE_STAGE_QC_LOG_SHEET>();
            this.TSPL_SPP_PE_STAGE_DETAIL = new HashSet<TSPL_SPP_PE_STAGE_DETAIL>();
            this.TSPL_SPP_PE_ISSUE_ITEM_DETAIL = new HashSet<TSPL_SPP_PE_ISSUE_ITEM_DETAIL>();
            this.TSPL_SPP_COST_WITHOUT_BATCH = new HashSet<TSPL_SPP_COST_WITHOUT_BATCH>();
            this.TSPL_SPP_CONSUMPTION_WITHOUT_BATCH = new HashSet<TSPL_SPP_CONSUMPTION_WITHOUT_BATCH>();
            this.TSPL_SPP_PRODUCTION_ENTRY_DETAIL = new HashSet<TSPL_SPP_PRODUCTION_ENTRY_DETAIL>();
        }
    
        public string PROD_ENTRY_CODE { get; set; }
        public string DESCRIPTION { get; set; }
        public System.DateTime PROD_DATE { get; set; }
        public string Batch_Code { get; set; }
        public System.DateTime BATCH_DATE { get; set; }
        public string RECEIVED_BY { get; set; }
        public string LOCATION_CODE { get; set; }
        public string COMMENTS { get; set; }
        public bool POSTED { get; set; }
        public Nullable<System.DateTime> POSTING_DATE { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string comp_code { get; set; }
        public string Section_Stage_Map_Code { get; set; }
        public string CONSM_LOCATION_CODE { get; set; }
        public string CONSM_SECTION_CODE { get; set; }
        public string Structure_Code { get; set; }
        public string Batch_Code_Manual { get; set; }
        public string CONSM_LOCATION_CODE_Other { get; set; }
        public string ManualBatchNo { get; set; }
        public string LINE_NO { get; set; }
        public string CostCenterCode { get; set; }
        public string ProfitCenterCode { get; set; }
        public Nullable<int> Is_Job_Work_Inward { get; set; }
        public string Shift_Code { get; set; }
    
        public virtual TSPL_CostCenter_MASTER TSPL_CostCenter_MASTER { get; set; }
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER { get; set; }
        public virtual TSPL_LINE_MASTER TSPL_LINE_MASTER { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER1 { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER2 { get; set; }
        public virtual TSPL_PP_BATCH_ORDER_HEAD TSPL_PP_BATCH_ORDER_HEAD { get; set; }
        public virtual TSPL_PROFIT_CENTER_MASTER TSPL_PROFIT_CENTER_MASTER { get; set; }
        public virtual TSPL_SECTION_MASTER TSPL_SECTION_MASTER { get; set; }
        public virtual TSPL_SECTION_STAGE_MAPPING_HEAD TSPL_SECTION_STAGE_MAPPING_HEAD { get; set; }
        public virtual TSPL_SHIFT_MASTER TSPL_SHIFT_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SPP_PRODUCTION_CONSUMPTION_DETAIL> TSPL_SPP_PRODUCTION_CONSUMPTION_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SPP_PE_SCRAP_DETAIL> TSPL_SPP_PE_SCRAP_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SPP_PE_QC_DETAIL> TSPL_SPP_PE_QC_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SPP_PE_WRECKAGE_FLASHING> TSPL_SPP_PE_WRECKAGE_FLASHING { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SPP_PE_STAGE_QC_LOG_SHEET> TSPL_SPP_PE_STAGE_QC_LOG_SHEET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SPP_PE_STAGE_DETAIL> TSPL_SPP_PE_STAGE_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SPP_PE_ISSUE_ITEM_DETAIL> TSPL_SPP_PE_ISSUE_ITEM_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SPP_COST_WITHOUT_BATCH> TSPL_SPP_COST_WITHOUT_BATCH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SPP_CONSUMPTION_WITHOUT_BATCH> TSPL_SPP_CONSUMPTION_WITHOUT_BATCH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SPP_PRODUCTION_ENTRY_DETAIL> TSPL_SPP_PRODUCTION_ENTRY_DETAIL { get; set; }
    }
}
