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
    
    public partial class TSPL_GLSETTING
    {
        public string Functional_currency { get; set; }
        public string Multicurrency { get; set; }
        public string Default_Ratetype { get; set; }
        public string Account_Group { get; set; }
        public string Closing_Account { get; set; }
        public string Post_Previousyear { get; set; }
        public string Provisional_Posting { get; set; }
        public string Source_Code { get; set; }
        public Nullable<int> Account_Segment { get; set; }
        public string Structure_Code { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modify_By { get; set; }
        public string Modify_Date { get; set; }
        public string Comp_Code { get; set; }
        public int AutoGenerated_GLCode_From_SubAccount { get; set; }
        public string Clearing_Account { get; set; }
    
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS { get; set; }
    }
}
