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
    
    public partial class TSPL_MILK_WEIGHMENT_DETAIL_HISTORY
    {
        public string Weighment_No { get; set; }
        public System.DateTime Weighment_date { get; set; }
        public string Gate_Entry_No { get; set; }
        public string Doc_Type { get; set; }
        public System.DateTime Date_And_Time { get; set; }
        public string Challan_No { get; set; }
        public System.DateTime Challan_Date { get; set; }
        public string Tanker_No { get; set; }
        public int isPosted { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string Dispatched_From_Mcc { get; set; }
        public string UOM { get; set; }
        public string location_Code { get; set; }
        public string Location_Desc { get; set; }
        public string Vendor_Code { get; set; }
        public string Vendor_Desc { get; set; }
        public string Item_Code { get; set; }
        public string Item_Desc { get; set; }
        public double Qty_In_Kg { get; set; }
        public double snf_Per { get; set; }
        public double fat_per { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modify_By { get; set; }
        public string Modify_Date { get; set; }
        public string comp_code { get; set; }
        public double Gross_Weight { get; set; }
        public double Dip_Value { get; set; }
        public double Tare_Weight { get; set; }
        public double Net_Weight { get; set; }
        public int status { get; set; }
        public string Sent_to_QC_By { get; set; }
        public Nullable<System.DateTime> Sent_To_QC_Date { get; set; }
        public string QC_Done_By { get; set; }
        public Nullable<System.DateTime> QC_Done_Date { get; set; }
        public string Weighment_Slip_No { get; set; }
        public Nullable<System.DateTime> Tare_Weight_date { get; set; }
    }
}
