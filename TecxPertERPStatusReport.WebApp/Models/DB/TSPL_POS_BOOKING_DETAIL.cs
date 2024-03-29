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
    
    public partial class TSPL_POS_BOOKING_DETAIL
    {
        public string Document_No { get; set; }
        public int Line_No { get; set; }
        public string Cust_Code { get; set; }
        public string Loc_Code { get; set; }
        public string Item_Code { get; set; }
        public string Short_Description { get; set; }
        public Nullable<decimal> Booking_Qty { get; set; }
        public string Unit_code { get; set; }
        public string Delivery_No { get; set; }
        public Nullable<decimal> Cust_Outstanding { get; set; }
        public Nullable<decimal> DocumentAmount { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public Nullable<int> DO_Posted { get; set; }
        public Nullable<decimal> DO_Qty { get; set; }
        public string Vehicle_Code { get; set; }
        public Nullable<decimal> Item_Rate { get; set; }
        public Nullable<decimal> Total_Qty { get; set; }
        public Nullable<int> Sampling { get; set; }
        public Nullable<int> Is_CustomerChanged { get; set; }
        public string location_code { get; set; }
        public string Disc_Scheme_Code { get; set; }
        public string Disc_Scheme_Type { get; set; }
        public Nullable<double> Disc_Scheme_Pers { get; set; }
        public Nullable<double> Disc_Scheme_Amount { get; set; }
        public Nullable<double> OrgRate { get; set; }
        public Nullable<int> Posted { get; set; }
        public string CreditApproval_Reqd { get; set; }
        public Nullable<int> Booking_Status { get; set; }
        public string Performance_Invoice_no { get; set; }
        public string Scheme_Type { get; set; }
        public string Scheme_Item_Code { get; set; }
        public Nullable<double> Scheme_Qty { get; set; }
        public string Scheme_Item_UOM { get; set; }
        public string Scheme_Item { get; set; }
        public Nullable<int> FOC_Item { get; set; }
        public Nullable<double> Item_Selling_Price { get; set; }
        public string Scheme_Code { get; set; }
        public string Main_Booking_No { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_POS_BOOKING_MATSER TSPL_POS_BOOKING_MATSER { get; set; }
        public virtual TSPL_SECONDARY_CUSTOMER_MASTER TSPL_SECONDARY_CUSTOMER_MASTER { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
    }
}
