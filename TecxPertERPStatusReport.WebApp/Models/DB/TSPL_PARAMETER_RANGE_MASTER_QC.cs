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
    
    public partial class TSPL_PARAMETER_RANGE_MASTER_QC
    {
        public string Code { get; set; }
        public double Lower_range { get; set; }
        public double Upper_range { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modified_By { get; set; }
        public string Modified_Date { get; set; }
        public Nullable<System.DateTime> Effective_Date { get; set; }
        public string Status { get; set; }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        public string comp_code { get; set; }
        public string Qc_Status { get; set; }
        public string QC_Param_Code { get; set; }
        public string Trans_Id { get; set; }
        public string Show_in_Analyzer { get; set; }
        public string Text_in_Analyzer { get; set; }
        public Nullable<int> ANalyzer_Index { get; set; }
        public double Deduction_Per { get; set; }
        public double Deduction_lower_range { get; set; }
        public double Deduction_upper_range { get; set; }
        public double Deduction_Ratio { get; set; }
        public Nullable<int> Deduction_Method { get; set; }
        public double Deduction_lower_range2 { get; set; }
        public double Deduction_upper_range2 { get; set; }
        public double Deduction_Ratio2 { get; set; }
        public double Deduction_lower_range3 { get; set; }
        public double Deduction_upper_range3 { get; set; }
        public double Deduction_Ratio3 { get; set; }
    
        public virtual TSPL_PARAMETER_MASTER TSPL_PARAMETER_MASTER { get; set; }
        public virtual TSPL_QC_LOG_SHEET_MASTER TSPL_QC_LOG_SHEET_MASTER { get; set; }
    }
}
