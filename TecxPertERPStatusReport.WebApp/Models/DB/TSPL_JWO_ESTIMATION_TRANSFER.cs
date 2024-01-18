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
    
    public partial class TSPL_JWO_ESTIMATION_TRANSFER
    {
        public string TR_Code { get; set; }
        public string Document_NO { get; set; }
        public Nullable<int> SNo { get; set; }
        public Nullable<int> Parent_SNo { get; set; }
        public string Transfer_Code { get; set; }
        public System.DateTime Transfer_Date { get; set; }
        public string Item_Code { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public string UOM { get; set; }
        public Nullable<decimal> FAT_PER { get; set; }
        public Nullable<decimal> SNF_PER { get; set; }
        public Nullable<decimal> FAT_KG { get; set; }
        public Nullable<decimal> SNF_KG { get; set; }
        public Nullable<decimal> Estimated_FAT_KG { get; set; }
        public Nullable<decimal> Estimated_SNF_KG { get; set; }
        public Nullable<decimal> CLR { get; set; }
        public Nullable<decimal> Correction_Factor { get; set; }
        public Nullable<decimal> GE_FAT_PER { get; set; }
        public Nullable<decimal> GE_SNF_PER { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_JWO_ESTIMATION_HEAD TSPL_JWO_ESTIMATION_HEAD { get; set; }
        public virtual TSPL_MILK_JOBWORK_TRANSFER_HEAD TSPL_MILK_JOBWORK_TRANSFER_HEAD { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
    }
}
