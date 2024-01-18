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
    
    public partial class TSPL_LEAVE_SETTING
    {
        public string LEAVE_CODE { get; set; }
        public int LEAVE_ALLOT_TYPE { get; set; }
        public Nullable<int> ALLOT_AFTER_MONTHS { get; set; }
        public Nullable<int> ALLOT_AFTER_DAYS { get; set; }
        public int LEAVE_AVAIL_TYPE { get; set; }
        public Nullable<int> AVAIL_AFTER_MONTHS { get; set; }
        public Nullable<int> AVAIL_AFTER_DAYS { get; set; }
        public string BAL_ROUND_OFF_TYPE { get; set; }
        public Nullable<bool> LEAVE_ENCASHED { get; set; }
        public Nullable<decimal> MIN_BAL { get; set; }
        public Nullable<bool> CARRY_OVER { get; set; }
        public Nullable<decimal> CARRY_LOWER_LIM { get; set; }
        public Nullable<decimal> CARRY_UPPER_LIM { get; set; }
        public Nullable<bool> LAPSE_UNAVAILED { get; set; }
        public string LAPSE_MONTH { get; set; }
        public Nullable<bool> LAPSE_NEGATIVE { get; set; }
        public Nullable<decimal> LAPSE_EXCEEDING { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public Nullable<int> LAPSE_AFTER_DAYS { get; set; }
        public string Allot_Periodicity { get; set; }
        public string Allot_Type { get; set; }
        public Nullable<decimal> Alloted_Days { get; set; }
        public Nullable<decimal> PerPresentDays { get; set; }
        public Nullable<bool> AutoAllotDuringSalaryGen { get; set; }
        public string Location_Code { get; set; }
    
        public virtual TSPL_LEAVE_MASTER TSPL_LEAVE_MASTER { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
    }
}