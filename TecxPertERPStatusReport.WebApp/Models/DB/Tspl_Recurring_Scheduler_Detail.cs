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
    
    public partial class Tspl_Recurring_Scheduler_Detail
    {
        public string DOC_CODE { get; set; }
        public string Checked_Value_Name { get; set; }
        public string Day_Name { get; set; }
        public string Day_index { get; set; }
    
        public virtual Tspl_Recurring_Scheduler_Head Tspl_Recurring_Scheduler_Head { get; set; }
    }
}
