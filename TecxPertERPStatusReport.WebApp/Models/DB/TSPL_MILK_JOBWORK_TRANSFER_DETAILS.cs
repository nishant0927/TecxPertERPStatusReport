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
    
    public partial class TSPL_MILK_JOBWORK_TRANSFER_DETAILS
    {
        public string Document_Code { get; set; }
        public int Line_No { get; set; }
        public string Item_Code { get; set; }
        public string UOM { get; set; }
        public string Chamber_Desc { get; set; }
        public double Chamber_Qty { get; set; }
        public double Gross_Weight { get; set; }
        public double Tare_Weight { get; set; }
        public double Net_Weight { get; set; }
        public double snf_Per { get; set; }
        public double fat_per { get; set; }
        public double fat_KG { get; set; }
        public double SNF_KG { get; set; }
        public double fat_Rate { get; set; }
        public double SNF_Rate { get; set; }
        public double Amount { get; set; }
        public double Deduction { get; set; }
        public double SpecialDeduction { get; set; }
        public double Actual_Amount { get; set; }
        public double Incentive { get; set; }
        public double IncenRate { get; set; }
        public double DeducRate { get; set; }
        public double BasicRate { get; set; }
        public double StandardRate { get; set; }
        public double NetRate { get; set; }
        public double FatAmt { get; set; }
        public double SnfAmt { get; set; }
        public double FinalMilkRate { get; set; }
        public string Price_Code { get; set; }
        public string MIKL_TYPE_CODE { get; set; }
        public string MILK_GRADE_CODE { get; set; }
        public string Sub_Location { get; set; }
    
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_MILK_GRADE_MASTER TSPL_MILK_GRADE_MASTER { get; set; }
        public virtual TSPL_MILK_JOBWORK_TRANSFER_HEAD TSPL_MILK_JOBWORK_TRANSFER_HEAD { get; set; }
        public virtual TSPL_MILK_TYPE_MASTER TSPL_MILK_TYPE_MASTER { get; set; }
    }
}
