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
    
    public partial class TSPL_Traget_Master_Scheme
    {
        public string Traget_Code { get; set; }
        public string Cust_Code { get; set; }
    
        public virtual TSPL_TRAGET_MASTER_HEAD TSPL_TRAGET_MASTER_HEAD { get; set; }
    }
}
