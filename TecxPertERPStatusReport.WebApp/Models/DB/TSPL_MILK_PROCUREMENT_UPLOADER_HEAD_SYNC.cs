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
    
    public partial class TSPL_MILK_PROCUREMENT_UPLOADER_HEAD_SYNC
    {
        public string Document_No { get; set; }
        public System.DateTime Document_Date { get; set; }
        public string MCC_Code { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public Nullable<System.DateTime> Posted_Date { get; set; }
        public string Posted_By { get; set; }
        public Nullable<int> SYNC_STATUS { get; set; }
        public string Dock_code { get; set; }
        public Nullable<int> Reject { get; set; }
        public Nullable<System.DateTime> Approve_Date { get; set; }
        public string Approve_By { get; set; }
        public Nullable<int> Source_API { get; set; }
    
        public virtual TSPL_MCC_MASTER TSPL_MCC_MASTER { get; set; }
    }
}