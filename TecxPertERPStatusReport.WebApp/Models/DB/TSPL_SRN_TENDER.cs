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
    
    public partial class TSPL_SRN_TENDER
    {
        public int PK_Id { get; set; }
        public string Against_TenderNo { get; set; }
        public Nullable<int> Against_Tender_Schedule_PK_Id { get; set; }
        public string SRN_No { get; set; }
        public string Item_Code { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<int> Against_Tender_Schedule_Penalty_PK_Id { get; set; }
        public Nullable<decimal> Penalty { get; set; }
        public string Against_PO { get; set; }
        public Nullable<int> Against_Tender_Schedule_PK_Id_PO { get; set; }
        public Nullable<int> Against_Tender_Schedule_Penalty_PK_Id_PO { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_PURCHASE_ORDER_HEAD TSPL_PURCHASE_ORDER_HEAD { get; set; }
        public virtual TSPL_SRN_HEAD TSPL_SRN_HEAD { get; set; }
        public virtual TSPL_TENDER_SCHEDULE_PENALTY_PO TSPL_TENDER_SCHEDULE_PENALTY_PO { get; set; }
        public virtual TSPL_TENDER_HEADER TSPL_TENDER_HEADER { get; set; }
        public virtual TSPL_TENDER_SCHEDULE TSPL_TENDER_SCHEDULE { get; set; }
        public virtual TSPL_TENDER_SCHEDULE_PENALTY TSPL_TENDER_SCHEDULE_PENALTY { get; set; }
        public virtual TSPL_TENDER_SCHEDULE_PO TSPL_TENDER_SCHEDULE_PO { get; set; }
    }
}