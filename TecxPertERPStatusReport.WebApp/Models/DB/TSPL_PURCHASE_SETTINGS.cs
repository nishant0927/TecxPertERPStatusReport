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
    
    public partial class TSPL_PURCHASE_SETTINGS
    {
        public bool CREATE_ABATEMENT_BASED_PO { get; set; }
        public decimal CREATE_PO_WITH_REQ { get; set; }
        public bool ENABLE_POPUP_REORDERLEVEL { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public bool MANDATE_BATCHNO_RM { get; set; }
        public bool MANDATE_BATCHNO_FG { get; set; }
        public bool MANDATE_BATCHNO_ASSET { get; set; }
        public bool MANDATE_BATCHNO_OTHERS { get; set; }
        public bool MANDATE_MFG_RM { get; set; }
        public bool MANDATE_MFG_FG { get; set; }
        public bool MANDATE_MFG_ASSET { get; set; }
        public bool MANDATE_MFG_OTHERS { get; set; }
        public bool MANDATE_EXP_RM { get; set; }
        public bool MANDATE_EXP_FG { get; set; }
        public bool MANDATE_EXP_ASSET { get; set; }
        public bool MANDATE_EXP_OTHERS { get; set; }
        public bool REQUIRED_SECURITY_AMOUNT { get; set; }
        public bool REQUIRED_FOC { get; set; }
        public bool Return_without_Invoice { get; set; }
        public bool PurchaseOrderAutomaticallyItemQtyBelowReorderLevel { get; set; }
        public bool SRN_Rejected_Store { get; set; }
        public string Job_Work_Account { get; set; }
        public Nullable<double> SRN_Limit { get; set; }
        public Nullable<double> GRN_Limit { get; set; }
    
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS { get; set; }
    }
}
