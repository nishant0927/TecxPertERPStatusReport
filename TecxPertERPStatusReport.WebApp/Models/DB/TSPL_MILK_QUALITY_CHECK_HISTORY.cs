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
    
    public partial class TSPL_MILK_QUALITY_CHECK_HISTORY
    {
        public string QC_No { get; set; }
        public System.DateTime QC_In_Date_Time { get; set; }
        public System.DateTime QC_Out_Date_Time { get; set; }
        public string Gate_Entry_No { get; set; }
        public string Doc_Type { get; set; }
        public System.DateTime Gate_Entry_Date_And_Time { get; set; }
        public string Challan_No { get; set; }
        public System.DateTime Challan_Date { get; set; }
        public string Tanker_No { get; set; }
        public int isPosted { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string Dispatched_From_Mcc_Code { get; set; }
        public string Dispatched_From_Mcc_Desc { get; set; }
        public string location_Code { get; set; }
        public string Location_Desc { get; set; }
        public string Vendor_Code { get; set; }
        public string Vendor_Desc { get; set; }
        public string Item_Code { get; set; }
        public string Item_Desc { get; set; }
        public string UOM { get; set; }
        public double Qty_In_Kg { get; set; }
        public double snf_Per { get; set; }
        public double fat_per { get; set; }
        public double fat_KG { get; set; }
        public double SNF_KG { get; set; }
        public double Dip_Value { get; set; }
        public double DeductionAmount { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modify_By { get; set; }
        public string Modify_Date { get; set; }
        public string comp_code { get; set; }
        public string Weighment_No { get; set; }
        public int is_Param_Accepted { get; set; }
        public Nullable<System.DateTime> Weighment_Date { get; set; }
        public string Remarks { get; set; }
        public double Receipt_Control_FAT { get; set; }
        public double Receipt_Control_SNF { get; set; }
    }
}
