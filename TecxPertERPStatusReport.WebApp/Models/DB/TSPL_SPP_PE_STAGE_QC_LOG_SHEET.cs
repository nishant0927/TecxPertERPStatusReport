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
    
    public partial class TSPL_SPP_PE_STAGE_QC_LOG_SHEET
    {
        public string PROD_ENTRY_CODE { get; set; }
        public string Log_Sheet_No { get; set; }
        public string Stage_Code { get; set; }
        public int SNO { get; set; }
        public string Time_Value { get; set; }
        public string Parameter_Code { get; set; }
        public string QCLM_CODE { get; set; }
        public string Parameter_STD_Value { get; set; }
        public string Parameter_ACT_Value { get; set; }
        public string Comp_Code { get; set; }
        public Nullable<System.DateTime> Fill_Date { get; set; }
        public string Batch_Code { get; set; }
    
        public virtual TSPL_COMPANY_MASTER TSPL_COMPANY_MASTER { get; set; }
        public virtual TSPL_PARAMETER_MASTER TSPL_PARAMETER_MASTER { get; set; }
        public virtual TSPL_PP_BATCH_ORDER_HEAD TSPL_PP_BATCH_ORDER_HEAD { get; set; }
        public virtual TSPL_PP_LOG_SHEET_HEAD TSPL_PP_LOG_SHEET_HEAD { get; set; }
        public virtual TSPL_QC_LOG_SHEET_MASTER TSPL_QC_LOG_SHEET_MASTER { get; set; }
        public virtual TSPL_SPP_PRODUCTION_ENTRY TSPL_SPP_PRODUCTION_ENTRY { get; set; }
        public virtual TSPL_STAGE_MASTER TSPL_STAGE_MASTER { get; set; }
    }
}
