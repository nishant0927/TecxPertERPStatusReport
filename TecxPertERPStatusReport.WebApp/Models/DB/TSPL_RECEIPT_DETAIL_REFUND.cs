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
    
    public partial class TSPL_RECEIPT_DETAIL_REFUND
    {
        public string Receipt_No { get; set; }
        public int Receipt_Line_No { get; set; }
        public string TagType { get; set; }
        public string Posted { get; set; }
        public Nullable<System.DateTime> Document_Date { get; set; }
        public decimal ConvRateOld { get; set; }
        public string Child_Cust_Code { get; set; }
        public string Apply { get; set; }
        public string Receipt_Type { get; set; }
        public string Document_No { get; set; }
        public Nullable<decimal> Original_Amt { get; set; }
        public Nullable<decimal> Pending_Balance { get; set; }
        public decimal Applied_Amount { get; set; }
        public string Account_Code { get; set; }
        public string Description { get; set; }
        public string Remarks { get; set; }
        public string Comment { get; set; }
        public string Shipment_No { get; set; }
        public string Adjustment_Account { get; set; }
        public Nullable<decimal> Adjustment_Cost { get; set; }
        public string Adjustment_No { get; set; }
        public int AutoId { get; set; }
        public string Hirerachy_Level_Code { get; set; }
        public string Cost_Center_Fin_Code { get; set; }
    
        public virtual TSPL_COST_CENTRE_FINANCIAL TSPL_COST_CENTRE_FINANCIAL { get; set; }
        public virtual TSPL_CUSTOMER_MASTER TSPL_CUSTOMER_MASTER { get; set; }
        public virtual TSPL_HIRERACHY_LEVEL_MASTER TSPL_HIRERACHY_LEVEL_MASTER { get; set; }
        public virtual TSPL_RECEIPT_HEADER TSPL_RECEIPT_HEADER { get; set; }
    }
}
