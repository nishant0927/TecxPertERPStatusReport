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
    
    public partial class TSPL_SW_SERVICE_ALLOCATION
    {
        public string Service_Allocation_Code { get; set; }
        public Nullable<System.DateTime> Service_Allocation_Date { get; set; }
        public string Service_Enquiry_Code { get; set; }
        public string Engineer_Code { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string Comp_Code { get; set; }
    
        public virtual TSPL_COMPANY_MASTER TSPL_COMPANY_MASTER { get; set; }
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER { get; set; }
        public virtual TSPL_SW_SERVICE_ENQUIRY TSPL_SW_SERVICE_ENQUIRY { get; set; }
    }
}
