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
    
    public partial class TSPL_EMAIL_SMS_SCHEDULING
    {
        public string SCHEDULER_CODE { get; set; }
        public string DESCRIPTION { get; set; }
        public string SCREEN_ID { get; set; }
        public bool IS_EMAIL_EVERY_DAY { get; set; }
        public bool IS_EMAIL_WEEKLY { get; set; }
        public string EMAIL_WEEKLY_DAY { get; set; }
        public bool IS_EMAIL_MONTHLY { get; set; }
        public Nullable<System.DateTime> MONTHLY_EMAIL_DATE { get; set; }
        public bool IS_EMAIL_LAST_DAY_OF_MONTHLY { get; set; }
        public Nullable<System.DateTime> SCHEDULE_EMAIL_TIME { get; set; }
        public bool IS_SMS_EVERY_DAY { get; set; }
        public bool IS_SMS_WEEKLY { get; set; }
        public string SMS_WEEKLY_DAY { get; set; }
        public bool IS_SMS_MONTHLY { get; set; }
        public Nullable<System.DateTime> MONTHLY_SMS_DATE { get; set; }
        public bool IS_SMS_LAST_DAY_OF_MONTHLY { get; set; }
        public Nullable<System.DateTime> SCHEDULE_SMS_TIME { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string Comp_Code { get; set; }
    }
}
