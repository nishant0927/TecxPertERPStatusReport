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
    
    public partial class TSPL_MF_BOM_OPERATIONS
    {
        public string BOM_CODE { get; set; }
        public int LINE_NO { get; set; }
        public string OPERATION_CODE { get; set; }
        public string WORK_CENTER_CODE { get; set; }
        public int SETUP_TIME_MINUTES { get; set; }
        public int RUN_TIME_MINUTES { get; set; }
        public int CLEAN_TIME_MINUTES { get; set; }
        public int WAIT_TIME_MINUTES { get; set; }
        public decimal OVERLAP_PER { get; set; }
        public string REMARKS { get; set; }
    
        public virtual TSPL_MF_BOM_HEAD TSPL_MF_BOM_HEAD { get; set; }
        public virtual TSPL_MF_OPERATION TSPL_MF_OPERATION { get; set; }
        public virtual TSPL_MF_WORK_CENTER TSPL_MF_WORK_CENTER { get; set; }
    }
}