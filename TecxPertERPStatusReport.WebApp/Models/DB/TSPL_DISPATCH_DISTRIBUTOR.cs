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
    
    public partial class TSPL_DISPATCH_DISTRIBUTOR
    {
        public string Document_No { get; set; }
        public Nullable<System.DateTime> Document_Date { get; set; }
        public string CNF_Code { get; set; }
        public string Distributor_Code { get; set; }
        public string Booking_No { get; set; }
        public string OTP_No { get; set; }
        public string OTP_Confirm { get; set; }
        public string Vehicle_Code { get; set; }
        public string Driver_Code { get; set; }
        public string Driver_name { get; set; }
        public string InOut { get; set; }
        public string Document_Type { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public string Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_Date { get; set; }
    
        public virtual TSPL_BOOKING_MATSER TSPL_BOOKING_MATSER { get; set; }
        public virtual TSPL_CUSTOMER_MASTER TSPL_CUSTOMER_MASTER { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER { get; set; }
        public virtual TSPL_SECONDARY_CUSTOMER_MASTER TSPL_SECONDARY_CUSTOMER_MASTER { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER1 { get; set; }
    }
}
