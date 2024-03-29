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
    
    public partial class TSPL_BOOKING_MATSER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_BOOKING_MATSER()
        {
            this.TSPL_BOOKING_DETAIL = new HashSet<TSPL_BOOKING_DETAIL>();
            this.TSPL_BOOKING_PAYMENT_MODE_DETAIL = new HashSet<TSPL_BOOKING_PAYMENT_MODE_DETAIL>();
            this.TSPL_DELIVERY_NOTE_MASTER_FRESHSALE = new HashSet<TSPL_DELIVERY_NOTE_MASTER_FRESHSALE>();
            this.TSPL_DELIVERY_NOTE_DETAIL_FRESHSALE = new HashSet<TSPL_DELIVERY_NOTE_DETAIL_FRESHSALE>();
            this.TSPL_DISPATCH_MASTER_FRESHSALE = new HashSet<TSPL_DISPATCH_MASTER_FRESHSALE>();
            this.TSPL_DISPATCH_DISTRIBUTOR = new HashSet<TSPL_DISPATCH_DISTRIBUTOR>();
            this.TSPL_GATEPASS_TRANSFER_HEAD = new HashSet<TSPL_GATEPASS_TRANSFER_HEAD>();
            this.TSPL_GATEPASS_MASTER_DAIRYSALE = new HashSet<TSPL_GATEPASS_MASTER_DAIRYSALE>();
            this.TSPL_GATEPASS_DETAIL_DAIRYSALE = new HashSet<TSPL_GATEPASS_DETAIL_DAIRYSALE>();
            this.TSPL_MCC_SALE_FARMER_HEAD = new HashSet<TSPL_MCC_SALE_FARMER_HEAD>();
            this.TSPL_MOBILE_APP_PAYMENT_DETAIL = new HashSet<TSPL_MOBILE_APP_PAYMENT_DETAIL>();
            this.TSPL_SD_SALE_INVOICE_HEAD = new HashSet<TSPL_SD_SALE_INVOICE_HEAD>();
            this.TSPL_SD_SHIPMENT_HEAD = new HashSet<TSPL_SD_SHIPMENT_HEAD>();
        }
    
        public string Document_No { get; set; }
        public System.DateTime Document_Date { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string Comp_Code { get; set; }
        public int Posted { get; set; }
        public int CreateDO_Automatic { get; set; }
        public string location_code { get; set; }
        public string BookingThrough { get; set; }
        public double Amount_After_Commission { get; set; }
        public string Total_Crates { get; set; }
        public string OTP_No { get; set; }
        public string OTP_Confirm { get; set; }
        public string IsDispatched { get; set; }
        public string Distributor_Code { get; set; }
        public string Main_Booking_No { get; set; }
        public string Cust_Group_Code { get; set; }
        public int Is_Taxable { get; set; }
        public string TRANSACTION_TYPE { get; set; }
        public string ManualVehicle { get; set; }
        public Nullable<System.DateTime> Ex_Factory_Date { get; set; }
        public string From_Screen_Code { get; set; }
        public string CustPO_No { get; set; }
        public Nullable<System.DateTime> custpo_date { get; set; }
        public string SalesmanCode { get; set; }
        public Nullable<decimal> Total_CAN { get; set; }
        public Nullable<decimal> Total_Box { get; set; }
        public Nullable<decimal> Total_CRATE { get; set; }
        public int User_Lock_For_Edit { get; set; }
        public string LockedBy_UserCode { get; set; }
        public int IsSampling { get; set; }
        public int Is_Cancelled { get; set; }
        public string Booking_Type { get; set; }
        public string Card_SALE_No { get; set; }
        public Nullable<System.DateTime> CardSale_FROM_DATE { get; set; }
        public Nullable<System.DateTime> CardSale_TO_DATE { get; set; }
        public string Payment_Mode { get; set; }
        public string Reference_No { get; set; }
        public string Counter_No { get; set; }
        public string Against_Booking_No { get; set; }
        public string Against_Receipt_No { get; set; }
        public double AdvanceAmount { get; set; }
        public int TruckSheetGenerate { get; set; }
        public int AgainstGatePass { get; set; }
        public Nullable<decimal> Credit_Limit { get; set; }
        public Nullable<decimal> Advance_Security { get; set; }
        public Nullable<decimal> Revese_Adv_Security { get; set; }
        public Nullable<decimal> AR_Credit_Security { get; set; }
        public Nullable<decimal> Pending_Posted_DO { get; set; }
        public Nullable<decimal> UnPostedDispatch { get; set; }
        public Nullable<decimal> Ledger_Outstansing { get; set; }
        public Nullable<decimal> Refund_Security { get; set; }
        public Nullable<decimal> Reverse_Refund_Sec { get; set; }
        public Nullable<decimal> Total_Outstanding { get; set; }
        public Nullable<System.DateTime> Uploading_date { get; set; }
        public string Ship_To_Location { get; set; }
        public int isBookingCreatedForNextDay { get; set; }
        public Nullable<int> Is_CustomerChanged { get; set; }
        public string GatePass_Type { get; set; }
        public string Against_DemandBooking_No { get; set; }
        public string Login_User_Zone_Code { get; set; }
        public Nullable<int> Is_DCS { get; set; }
        public Nullable<int> Is_BPL { get; set; }
        public string BPL_Coupon_Code { get; set; }
        public string BPL_Name { get; set; }
        public string BPL_Remark { get; set; }
        public Nullable<System.DateTime> BPL_Coupon_Date { get; set; }
        public Nullable<int> Is_Distributor { get; set; }
        public string BPL_Category { get; set; }
        public Nullable<decimal> TCSAmount { get; set; }
        public string Is_Credit_Customer { get; set; }
        public Nullable<System.DateTime> LastCollectionDate { get; set; }
    
        public virtual TSPL_RECEIPT_HEADER TSPL_RECEIPT_HEADER { get; set; }
        public virtual TSPL_DEMAND_BOOKING_MASTER TSPL_DEMAND_BOOKING_MASTER { get; set; }
        public virtual TSPL_CARD_SALE TSPL_CARD_SALE { get; set; }
        public virtual TSPL_SECONDARY_CUSTOMER_MASTER TSPL_SECONDARY_CUSTOMER_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_BOOKING_DETAIL> TSPL_BOOKING_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_BOOKING_PAYMENT_MODE_DETAIL> TSPL_BOOKING_PAYMENT_MODE_DETAIL { get; set; }
        public virtual TSPL_ZONE_MASTER TSPL_ZONE_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DELIVERY_NOTE_MASTER_FRESHSALE> TSPL_DELIVERY_NOTE_MASTER_FRESHSALE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DELIVERY_NOTE_DETAIL_FRESHSALE> TSPL_DELIVERY_NOTE_DETAIL_FRESHSALE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DISPATCH_MASTER_FRESHSALE> TSPL_DISPATCH_MASTER_FRESHSALE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DISPATCH_DISTRIBUTOR> TSPL_DISPATCH_DISTRIBUTOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_GATEPASS_TRANSFER_HEAD> TSPL_GATEPASS_TRANSFER_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_GATEPASS_MASTER_DAIRYSALE> TSPL_GATEPASS_MASTER_DAIRYSALE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_GATEPASS_DETAIL_DAIRYSALE> TSPL_GATEPASS_DETAIL_DAIRYSALE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MCC_SALE_FARMER_HEAD> TSPL_MCC_SALE_FARMER_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MOBILE_APP_PAYMENT_DETAIL> TSPL_MOBILE_APP_PAYMENT_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SD_SALE_INVOICE_HEAD> TSPL_SD_SALE_INVOICE_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SD_SHIPMENT_HEAD> TSPL_SD_SHIPMENT_HEAD { get; set; }
    }
}
