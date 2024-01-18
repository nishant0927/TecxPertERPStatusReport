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
    
    public partial class TSPL_ANDROID_TRUCK_SHEET
    {
        public string Code { get; set; }
        public System.DateTime Trans_Date { get; set; }
        public string Trans_Type { get; set; }
        public int SNo { get; set; }
        public string MCC_Code { get; set; }
        public string Route_Code { get; set; }
        public string VLC_Code { get; set; }
        public string Vehicle_Code { get; set; }
        public string Trans_Shift { get; set; }
        public Nullable<System.DateTime> Time_Start { get; set; }
        public Nullable<System.DateTime> Time_End { get; set; }
        public Nullable<int> Time_Total_Seconds { get; set; }
        public string Latitude_ { get; set; }
        public string Longitude_ { get; set; }
        public string GPS_Address_ { get; set; }
    
        public virtual TSPL_MCC_MASTER TSPL_MCC_MASTER { get; set; }
        public virtual TSPL_ROUTE_MASTER TSPL_ROUTE_MASTER { get; set; }
        public virtual TSPL_VEHICLE_MASTER TSPL_VEHICLE_MASTER { get; set; }
        public virtual TSPL_VLC_MASTER_HEAD TSPL_VLC_MASTER_HEAD { get; set; }
    }
}
