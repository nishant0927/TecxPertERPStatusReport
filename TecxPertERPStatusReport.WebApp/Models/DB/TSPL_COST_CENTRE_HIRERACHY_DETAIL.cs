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
    
    public partial class TSPL_COST_CENTRE_HIRERACHY_DETAIL
    {
        public string COST_CENTRE_HIRERACHY_CODE { get; set; }
        public string HIRERACHY_LEVEL_CODE1 { get; set; }
        public string HIRERACHY_LEVEL_CODE2 { get; set; }
        public string HIRERACHY_LEVEL_CODE3 { get; set; }
        public string HIRERACHY_LEVEL { get; set; }
        public bool FLAG { get; set; }
    
        public virtual TSPL_COST_CENTRE_FINANCIAL TSPL_COST_CENTRE_FINANCIAL { get; set; }
    }
}