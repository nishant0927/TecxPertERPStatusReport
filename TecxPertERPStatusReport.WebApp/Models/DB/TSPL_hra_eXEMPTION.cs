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
    
    public partial class TSPL_hra_eXEMPTION
    {
        public string Document_Code { get; set; }
        public System.DateTime Document_Date { get; set; }
        public string Asset_Code { get; set; }
        public string Dep_Method_Code { get; set; }
        public string Dep_Period_Code { get; set; }
        public Nullable<decimal> Value_Before_Depreciation { get; set; }
        public Nullable<decimal> Asset_value { get; set; }
        public Nullable<decimal> Dep_Amount { get; set; }
        public string Dep_Method_Tax_Code { get; set; }
        public Nullable<decimal> Value_Before_Depreciation_Tax { get; set; }
        public Nullable<decimal> Asset_value_Tax { get; set; }
        public Nullable<decimal> Dep_Amount_Tax { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string HRA_CODE { get; set; }
        public string Particulars { get; set; }
        public string Location_City { get; set; }
        public string SALARY_STRUCTURE_CODE { get; set; }
        public string HRA_FORMULA { get; set; }
        public string Comp_Code { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
    
        public virtual TSPL_SALARY_STRUCTURE TSPL_SALARY_STRUCTURE { get; set; }
    }
}