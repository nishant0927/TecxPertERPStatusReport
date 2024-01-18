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
    
    public partial class TSPL_PP_PRODUCTION_RETURN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_PP_PRODUCTION_RETURN()
        {
            this.TSPL_PE_FINALQC_CONSUMPTION = new HashSet<TSPL_PE_FINALQC_CONSUMPTION>();
            this.TSPL_PP_PRODUCTION_CONSUMPTION_DETAIL = new HashSet<TSPL_PP_PRODUCTION_CONSUMPTION_DETAIL>();
            this.TSPL_SPP_PRODUCTION_CONSUMPTION_DETAIL = new HashSet<TSPL_SPP_PRODUCTION_CONSUMPTION_DETAIL>();
        }
    
        public string PROD_RETURN_CODE { get; set; }
        public string Transaction_Type { get; set; }
        public string PROD_ENTRY_CODE { get; set; }
        public string DESCRIPTION { get; set; }
        public System.DateTime RETURN_DATE { get; set; }
        public string Batch_Code { get; set; }
        public System.DateTime BATCH_DATE { get; set; }
        public System.DateTime Prod_Date { get; set; }
        public string LOCATION_CODE { get; set; }
        public string CONSM_LOCATION_CODE { get; set; }
        public string CONSM_SECTION_CODE { get; set; }
        public string COMMENTS { get; set; }
        public bool POSTED { get; set; }
        public Nullable<System.DateTime> POSTING_DATE { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string comp_code { get; set; }
        public string ManualBatchNo { get; set; }
        public string LINE_NO { get; set; }
        public string CostCenterCode { get; set; }
        public string ProfitCenterCode { get; set; }
    
        public virtual TSPL_CostCenter_MASTER TSPL_CostCenter_MASTER { get; set; }
        public virtual TSPL_LINE_MASTER TSPL_LINE_MASTER { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PE_FINALQC_CONSUMPTION> TSPL_PE_FINALQC_CONSUMPTION { get; set; }
        public virtual TSPL_PP_BATCH_ORDER_HEAD TSPL_PP_BATCH_ORDER_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PP_PRODUCTION_CONSUMPTION_DETAIL> TSPL_PP_PRODUCTION_CONSUMPTION_DETAIL { get; set; }
        public virtual TSPL_SECTION_MASTER TSPL_SECTION_MASTER { get; set; }
        public virtual TSPL_PROFIT_CENTER_MASTER TSPL_PROFIT_CENTER_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SPP_PRODUCTION_CONSUMPTION_DETAIL> TSPL_SPP_PRODUCTION_CONSUMPTION_DETAIL { get; set; }
    }
}
