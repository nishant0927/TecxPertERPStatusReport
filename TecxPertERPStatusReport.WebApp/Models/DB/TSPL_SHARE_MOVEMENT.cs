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
    
    public partial class TSPL_SHARE_MOVEMENT
    {
        public int PK_Id { get; set; }
        public string Source_Code { get; set; }
        public System.DateTime Source_Date { get; set; }
        public string Source_Type { get; set; }
        public string Share_Code { get; set; }
        public string Certificate_No { get; set; }
        public int RI { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
    
        public virtual TSPL_SHARE_MASTER TSPL_SHARE_MASTER { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER { get; set; }
    }
}
