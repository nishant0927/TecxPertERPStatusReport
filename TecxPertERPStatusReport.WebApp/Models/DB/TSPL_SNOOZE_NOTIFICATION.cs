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
    
    public partial class TSPL_SNOOZE_NOTIFICATION
    {
        public string Code { get; set; }
        public string NotifyText { get; set; }
        public string NotifyCaption { get; set; }
        public int SnoozeTime { get; set; }
        public System.DateTime LastReminderTime { get; set; }
        public System.DateTime NextReminderTime { get; set; }
        public string UserCode { get; set; }
        public string DocumentNo { get; set; }
        public int DntShow_Flag { get; set; }
    
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER { get; set; }
    }
}
