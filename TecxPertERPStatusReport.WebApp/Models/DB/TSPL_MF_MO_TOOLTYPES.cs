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
    
    public partial class TSPL_MF_MO_TOOLTYPES
    {
        public string MO_CODE { get; set; }
        public string OPERATION_CODE { get; set; }
        public string WORK_CENTER_CODE { get; set; }
        public string TOOL_TYPE_CODE { get; set; }
        public decimal REQUIRED_QUANTITY { get; set; }
        public decimal USED_QUANTITY { get; set; }
        public decimal UNIT_COST { get; set; }
        public decimal STD_COST { get; set; }
        public decimal ACTUAL_COST { get; set; }
        public decimal QTY_VARIENCE_PER { get; set; }
        public decimal COST_VARIENCE_PER { get; set; }
        public string UNIT_COST_UOM { get; set; }
    
        public virtual TSPL_MF_MANUFACTURING_ORDER TSPL_MF_MANUFACTURING_ORDER { get; set; }
        public virtual TSPL_MF_OPERATION TSPL_MF_OPERATION { get; set; }
        public virtual TSPL_MF_TOOL_TYPE TSPL_MF_TOOL_TYPE { get; set; }
        public virtual TSPL_MF_WORK_CENTER TSPL_MF_WORK_CENTER { get; set; }
    }
}
