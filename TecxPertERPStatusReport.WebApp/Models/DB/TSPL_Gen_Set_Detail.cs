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
    
    public partial class TSPL_Gen_Set_Detail
    {
        public string Prog_Code { get; set; }
        public string Trans_Code { get; set; }
        public int Line_No { get; set; }
        public string Gen_Set_Desc { get; set; }
        public string Gen_Set_Make { get; set; }
        public string Gen_Set_kva { get; set; }
        public string Gen_Set_Year { get; set; }
    
        public virtual TSPL_MCC_MASTER TSPL_MCC_MASTER { get; set; }
    }
}
