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
    
    public partial class TSPL_MF_WORK_CENTER_SHIFT_DETAIL
    {
        public string WORK_CENTER_CODE { get; set; }
        public int SHIFT { get; set; }
        public decimal REGULAR_HOURS { get; set; }
        public decimal OVERTIME_HOURS { get; set; }
        public int STATIONS_IN_USE { get; set; }
    
        public virtual TSPL_MF_WORK_CENTER TSPL_MF_WORK_CENTER { get; set; }
    }
}
