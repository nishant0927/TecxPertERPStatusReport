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
    
    public partial class TSPL_SECTION_STAGE_MAPPING
    {
        public string Doc_Code { get; set; }
        public string Section_Code { get; set; }
        public Nullable<int> SNO { get; set; }
        public string Stage_Code { get; set; }
        public string Department_Code { get; set; }
        public string Log_Sheet_No { get; set; }
        public int Sequence_No { get; set; }
        public string Comp_Code { get; set; }
        public Nullable<int> No_of_Department { get; set; }
    
        public virtual TSPL_COMPANY_MASTER TSPL_COMPANY_MASTER { get; set; }
        public virtual TSPL_PP_LOG_SHEET_HEAD TSPL_PP_LOG_SHEET_HEAD { get; set; }
        public virtual TSPL_SECTION_MASTER TSPL_SECTION_MASTER { get; set; }
        public virtual TSPL_STAGE_MASTER TSPL_STAGE_MASTER { get; set; }
    }
}
