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
    
    public partial class TSPL_SILAGE_CRITERIA_APPLICATION_DETAIL
    {
        public string App_No { get; set; }
        public string Area_Code { get; set; }
        public string Criteria_Code { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
    
        public virtual TSPL_SILAGE_AREA_CRITERIA_MASTER TSPL_SILAGE_AREA_CRITERIA_MASTER { get; set; }
        public virtual TSPL_SILAGE_CRITERIA_APPLICATION_MASTER TSPL_SILAGE_CRITERIA_APPLICATION_MASTER { get; set; }
        public virtual TSPL_SILAGE_CRITERIA_MASTER TSPL_SILAGE_CRITERIA_MASTER { get; set; }
    }
}
