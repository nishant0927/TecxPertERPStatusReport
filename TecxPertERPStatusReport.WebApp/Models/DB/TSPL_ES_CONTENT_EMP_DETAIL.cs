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
    
    public partial class TSPL_ES_CONTENT_EMP_DETAIL
    {
        public string Form_Id { get; set; }
        public string EMP_CODE { get; set; }
        public Nullable<int> Alert_Type { get; set; }
    
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER { get; set; }
        public virtual TSPL_ES_CONTENT TSPL_ES_CONTENT { get; set; }
    }
}
