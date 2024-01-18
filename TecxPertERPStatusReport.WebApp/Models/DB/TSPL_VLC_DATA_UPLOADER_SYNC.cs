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
    
    public partial class TSPL_VLC_DATA_UPLOADER_SYNC
    {
        public string Doc_No { get; set; }
        public System.DateTime Doc_Date { get; set; }
        public string MCC_Code { get; set; }
        public System.DateTime File_Date { get; set; }
        public string shift { get; set; }
        public string VLC_CODE { get; set; }
        public string Route_No { get; set; }
        public string MP_CODE { get; set; }
        public string Milk_Type { get; set; }
        public double qty { get; set; }
        public double fat { get; set; }
        public double snf { get; set; }
        public double Rate { get; set; }
        public double fat_KG { get; set; }
        public double snf_KG { get; set; }
        public double Amount { get; set; }
        public double water { get; set; }
        public string Uom_Code { get; set; }
        public string Comp_Code { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modified_By { get; set; }
        public string Modified_Date { get; set; }
        public int PK_Id { get; set; }
        public Nullable<int> SYNC_STATUS { get; set; }
        public string Incentive_TRCode { get; set; }
        public Nullable<decimal> Incentive_Amt { get; set; }
        public string Entry_Source { get; set; }
    
        public virtual TSPL_MP_INCETIVE_DETAIL TSPL_MP_INCETIVE_DETAIL { get; set; }
    }
}