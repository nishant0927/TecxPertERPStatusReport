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
    
    public partial class TSPL_BOOKING_DETAIL
    {
        public string Document_No { get; set; }
        public int Line_No { get; set; }
        public string Cust_Code { get; set; }
        public string Loc_Code { get; set; }
        public string Item_Code { get; set; }
        public Nullable<decimal> Booking_Qty { get; set; }
        public string Short_Description { get; set; }
        public string Unit_code { get; set; }
        public string Delivery_No { get; set; }
        public Nullable<decimal> Cust_Outstanding { get; set; }
        public Nullable<decimal> DocumentAmount { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public int DO_Posted { get; set; }
        public Nullable<decimal> DO_Qty { get; set; }
        public string Vehicle_Code { get; set; }
        public decimal Item_Rate { get; set; }
        public Nullable<decimal> Total_Qty { get; set; }
        public int Sampling { get; set; }
        public Nullable<int> Is_CustomerChanged { get; set; }
        public string location_code { get; set; }
        public string Disc_Scheme_Code { get; set; }
        public string Disc_Scheme_Type { get; set; }
        public Nullable<double> Disc_Scheme_Pers { get; set; }
        public Nullable<double> Disc_Scheme_Amount { get; set; }
        public Nullable<double> OrgRate { get; set; }
        public int Posted { get; set; }
        public string CreditApproval_Reqd { get; set; }
        public int Booking_Status { get; set; }
        public string Performance_Invoice_no { get; set; }
        public string Scheme_Type { get; set; }
        public string Scheme_Item_Code { get; set; }
        public Nullable<double> Scheme_Qty { get; set; }
        public string Scheme_Item_UOM { get; set; }
        public string Scheme_Item { get; set; }
        public int FOC_Item { get; set; }
        public double Item_Selling_Price { get; set; }
        public string Scheme_Code { get; set; }
        public string Main_Booking_No { get; set; }
        public int Item_Price_ID { get; set; }
        public Nullable<double> Tax_On_Amount { get; set; }
        public Nullable<double> Tax_Amount { get; set; }
        public int Tax_NonTax { get; set; }
        public string FreshAmbient { get; set; }
        public string Remarks { get; set; }
        public string route_no { get; set; }
        public Nullable<decimal> Price_with_Tax { get; set; }
        public Nullable<decimal> Amount_with_Tax { get; set; }
        public Nullable<decimal> PreviousBookingQty { get; set; }
        public Nullable<System.DateTime> Price_IdStartDate { get; set; }
        public string PricePlanNo { get; set; }
        public string Against_DemandBooking_No { get; set; }
        public string Against_DemandBooking_TR_Code { get; set; }
        public string IsKKFTax { get; set; }
        public string IsMNDTax { get; set; }
    
        public virtual TSPL_BOOKING_MATSER TSPL_BOOKING_MATSER { get; set; }
        public virtual TSPL_DEMAND_BOOKING_DETAIL TSPL_DEMAND_BOOKING_DETAIL { get; set; }
        public virtual TSPL_DEMAND_BOOKING_MASTER TSPL_DEMAND_BOOKING_MASTER { get; set; }
        public virtual TSPL_VEHICLE_MASTER TSPL_VEHICLE_MASTER { get; set; }
    }
}
