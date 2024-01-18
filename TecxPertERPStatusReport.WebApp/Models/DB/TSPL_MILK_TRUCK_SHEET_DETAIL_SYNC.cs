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
    
    public partial class TSPL_MILK_TRUCK_SHEET_DETAIL_SYNC
    {
        public string DOC_CODE { get; set; }
        public string VLC_DOC_CODE { get; set; }
        public string VLC_CODE { get; set; }
        public int SAMPLE_NO { get; set; }
        public Nullable<int> NO_OF_CANS { get; set; }
        public decimal Vlc_Qty { get; set; }
        public decimal Vlc_FAT { get; set; }
        public decimal Vlc_SNF { get; set; }
        public decimal Mcc_Qty { get; set; }
        public decimal Mcc_FAT { get; set; }
        public decimal Mcc_SNF { get; set; }
        public string MCC_CODE { get; set; }
        public System.DateTime DOC_DATE { get; set; }
        public string SHIFT { get; set; }
        public string Milk_Receipt_Code { get; set; }
        public string Remarks { get; set; }
        public string Created_By { get; set; }
        public int PK_Id { get; set; }
    
        public virtual TSPL_MCC_MASTER TSPL_MCC_MASTER { get; set; }
        public virtual TSPL_VLC_MASTER_HEAD TSPL_VLC_MASTER_HEAD { get; set; }
    }
}
