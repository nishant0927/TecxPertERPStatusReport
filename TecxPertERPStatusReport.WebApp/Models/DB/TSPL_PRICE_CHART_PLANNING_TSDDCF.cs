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
    
    public partial class TSPL_PRICE_CHART_PLANNING_TSDDCF
    {
        public string Planning_Code { get; set; }
        public Nullable<int> SNo { get; set; }
        public Nullable<decimal> FAT_From { get; set; }
        public Nullable<decimal> FAT_To { get; set; }
        public Nullable<decimal> Apply_FAT { get; set; }
        public Nullable<decimal> SNF_From { get; set; }
        public Nullable<decimal> SNF_To { get; set; }
        public Nullable<decimal> Apply_SNF { get; set; }
        public Nullable<decimal> Rate_Per { get; set; }
        public Nullable<decimal> Fixed_Rate { get; set; }
        public Nullable<decimal> Below_SNF_Rate { get; set; }
        public Nullable<decimal> Deduction_Per { get; set; }
    
        public virtual TSPL_PRICE_CHART_PLANNING TSPL_PRICE_CHART_PLANNING { get; set; }
    }
}