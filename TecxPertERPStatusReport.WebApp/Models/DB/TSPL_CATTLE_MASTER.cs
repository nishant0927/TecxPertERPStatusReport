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
    
    public partial class TSPL_CATTLE_MASTER
    {
        public string Registration_No { get; set; }
        public string Registration_Desc { get; set; }
        public Nullable<System.DateTime> Registration_Date { get; set; }
        public Nullable<decimal> Registration_Charge { get; set; }
        public string Tag_Id { get; set; }
        public string Cattle_Code { get; set; }
        public string Cattle_Status { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Cattle_In_Age { get; set; }
        public string Gender { get; set; }
        public string Type { get; set; }
        public string NDDB_Code { get; set; }
        public string Mother_Code { get; set; }
        public string Father_Code { get; set; }
        public string Farmer_Id { get; set; }
        public string Cattle_Color_Code { get; set; }
        public string Cattle_Type_Code { get; set; }
        public string Bred_Type_Code { get; set; }
        public string PMC_Code { get; set; }
        public string MCC_Code { get; set; }
        public string Head_Office { get; set; }
        public string Zone_Code { get; set; }
        public string Region_Code { get; set; }
        public string Area_Code { get; set; }
        public string Branch_Code { get; set; }
        public string Insurance_No { get; set; }
        public Nullable<System.DateTime> Insurance_Date_To { get; set; }
        public Nullable<System.DateTime> Insurance_Date_From { get; set; }
        public string Milk_Qty_Per_Day { get; set; }
        public string Milk_Fat_Percentage { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Modify_Date { get; set; }
        public string Modify_By { get; set; }
        public string Comp_Code { get; set; }
    
        public virtual TSPL_COMPANY_MASTER TSPL_COMPANY_MASTER { get; set; }
    }
}