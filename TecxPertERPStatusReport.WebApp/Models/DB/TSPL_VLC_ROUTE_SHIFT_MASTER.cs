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
    
    public partial class TSPL_VLC_ROUTE_SHIFT_MASTER
    {
        public string Doc_No { get; set; }
        public string Description { get; set; }
        public System.DateTime Doc_Date { get; set; }
        public string Status { get; set; }
        public Nullable<int> SNO { get; set; }
        public string VLC_Code { get; set; }
        public string Existing_Route_Code { get; set; }
        public string Route_Status { get; set; }
        public Nullable<System.DateTime> Effective_Date { get; set; }
        public string New_Route_Code { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modified_By { get; set; }
        public string Modified_Date { get; set; }
        public string comp_code { get; set; }
        public string Route_Code { get; set; }
    
        public virtual TSPL_VLC_MASTER_HEAD TSPL_VLC_MASTER_HEAD { get; set; }
    }
}
