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
    
    public partial class TSPL_MILK_SRN_DETAIL_History
    {
        public string DOC_CODE { get; set; }
        public string Item_Code { get; set; }
        public decimal Qty { get; set; }
        public string UOM_Code { get; set; }
        public decimal ACC_Qty { get; set; }
        public decimal FAT_PER { get; set; }
        public decimal SNF_PER { get; set; }
        public decimal FAT_KG { get; set; }
        public decimal SNF_KG { get; set; }
        public string MCC_CODE { get; set; }
        public string COMM_PORT { get; set; }
        public decimal Correction_Factor { get; set; }
        public decimal RATE { get; set; }
        public decimal AMOUNT { get; set; }
        public string Service_Charge_Type { get; set; }
        public decimal Commission_Pers { get; set; }
        public decimal EMP_Pers { get; set; }
        public decimal Commission_Amount { get; set; }
        public decimal EMP_Amount { get; set; }
        public decimal NET_AMOUNT { get; set; }
        public decimal Head_Load_Rate { get; set; }
        public decimal Head_Load_Amount { get; set; }
        public string Head_Load_Type { get; set; }
        public decimal Own_Asset_Rate { get; set; }
        public decimal Own_Asset_Amount { get; set; }
        public string Own_Asset_Type { get; set; }
        public string Price_Code { get; set; }
        public int PK_Id { get; set; }
        public string History_By { get; set; }
        public string History_Date { get; set; }
        public string Cancel_Remark { get; set; }
        public Nullable<decimal> Round_Off { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_MCC_MASTER TSPL_MCC_MASTER { get; set; }
    }
}
