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
    
    public partial class TSPL_OPEN_MCC_SHIFT
    {
        public string MCC_SHIFT_CODE { get; set; }
        public string MCC_CODE { get; set; }
        public string SHIFT { get; set; }
        public System.DateTime MCC_SHIFT_DATE { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modified_By { get; set; }
        public string Modified_Date { get; set; }
        public string Comp_Code { get; set; }
        public string Status { get; set; }
        public decimal Actual_Stock { get; set; }
        public decimal Actual_FAT { get; set; }
        public decimal Actual_SNF { get; set; }
        public decimal Manual_Stock { get; set; }
        public decimal Manual_FAT { get; set; }
        public decimal Manual_SNF { get; set; }
        public decimal Actual_FAT_Per { get; set; }
        public decimal Actual_SNF_Per { get; set; }
        public decimal Manual_FAT_Per { get; set; }
        public decimal Manual_SNF_Per { get; set; }
        public string Is_Allow_Manual_Entry { get; set; }
        public string Is_Milk_Holiday { get; set; }
        public string Is_Allow_Manual_Entry_Weighment { get; set; }
        public int Is_Regular { get; set; }
        public string Irregular_Mcc_Code { get; set; }
        public string Is_Allow_Manual_Gate_Entry_Weighment { get; set; }
        public string Remarks { get; set; }
        public decimal System_Stock { get; set; }
        public decimal System_FAT_Per { get; set; }
        public decimal System_SNF_Per { get; set; }
        public Nullable<int> SYNC_STATUS { get; set; }
        public decimal CLR { get; set; }
    
        public virtual TSPL_MCC_MASTER TSPL_MCC_MASTER { get; set; }
    }
}
