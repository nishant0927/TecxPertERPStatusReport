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
    
    public partial class TSPL_VSP_INCENTIVE_MULTI_DETAIL
    {
        public string Doc_Code { get; set; }
        public string INCENTIVE_CODE { get; set; }
    
        public virtual TSPL_INCENTIVE_MASTER_HEAD TSPL_INCENTIVE_MASTER_HEAD { get; set; }
    }
}
