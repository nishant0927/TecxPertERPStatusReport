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
    
    public partial class TSPL_BANK_GUARANTEE_MASTER
    {
        public string Comp_Code { get; set; }
        public string DocNo { get; set; }
        public string Date { get; set; }
        public string description { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public string extended_date { get; set; }
        public string bank_code { get; set; }
        public string bank_desc { get; set; }
        public string vendor_code { get; set; }
        public string vendor_name { get; set; }
        public Nullable<decimal> amount { get; set; }
        public Nullable<decimal> reminder_days { get; set; }
        public string remarks { get; set; }
        public string created_by { get; set; }
        public string created_date { get; set; }
        public string modify_by { get; set; }
        public string modify_date { get; set; }
        public string status { get; set; }
        public Nullable<decimal> Extnd_Reminder_Days { get; set; }
        public string Type { get; set; }
        public string Bank_Guarantee_Type { get; set; }
        public string Receiving_code { get; set; }
    }
}
