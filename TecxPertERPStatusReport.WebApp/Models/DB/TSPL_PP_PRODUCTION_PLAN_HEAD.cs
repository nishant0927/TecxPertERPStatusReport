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
    
    public partial class TSPL_PP_PRODUCTION_PLAN_HEAD
    {
        public string Plan_Code { get; set; }
        public System.DateTime Plan_Date { get; set; }
        public string Status { get; set; }
        public string Is_Post { get; set; }
        public string Location_Code { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public string Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_Date { get; set; }
        public string Comp_Code { get; set; }
        public string Description { get; set; }
        public int Dispatch_Days { get; set; }
        public string Section_Code { get; set; }
        public string Structure_Code { get; set; }
        public string LINE_NO { get; set; }
        public string CostCenterCode { get; set; }
        public string ProfitCenterCode { get; set; }
        public string Uploader_TR_No { get; set; }
    
        public virtual TSPL_COMPANY_MASTER TSPL_COMPANY_MASTER { get; set; }
        public virtual TSPL_CostCenter_MASTER TSPL_CostCenter_MASTER { get; set; }
        public virtual TSPL_LINE_MASTER TSPL_LINE_MASTER { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_PROFIT_CENTER_MASTER TSPL_PROFIT_CENTER_MASTER { get; set; }
        public virtual TSPL_SECTION_MASTER TSPL_SECTION_MASTER { get; set; }
        public virtual TSPL_PRODUCTION_UPLOADER_DETAIL TSPL_PRODUCTION_UPLOADER_DETAIL { get; set; }
    }
}
