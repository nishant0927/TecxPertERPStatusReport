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
    
    public partial class TSPL_EMPLOYEE_ASSETS
    {
        public string EMP_CODE { get; set; }
        public int LINE_NO { get; set; }
        public string ASSET_CODE { get; set; }
        public string ASSET_NAME { get; set; }
        public Nullable<System.DateTime> ALLOCATE_DATE { get; set; }
        public string DESCRIPTION { get; set; }
        public string RETURNED { get; set; }
    
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER { get; set; }
    }
}
