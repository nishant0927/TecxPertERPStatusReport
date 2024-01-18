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
    
    public partial class TSPL_CRATE_RECEIVED_DETAIL_FRESHSALE
    {
        public string Document_No { get; set; }
        public int Line_No { get; set; }
        public string Customer_Code { get; set; }
        public string Sale_Invoice_No { get; set; }
        public System.DateTime Sale_Invoice_Date { get; set; }
        public string Salesman_Code { get; set; }
        public string Salesman_Name { get; set; }
        public string Vehicle_Code { get; set; }
        public string VehicleNo { get; set; }
        public Nullable<decimal> CrateQtyRecd { get; set; }
        public string Remarks { get; set; }
        public Nullable<decimal> CrateQty { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public Nullable<decimal> OutQty { get; set; }
        public Nullable<decimal> Adjustment { get; set; }
        public Nullable<decimal> jaali { get; set; }
        public Nullable<decimal> box { get; set; }
        public Nullable<decimal> CrateQtyManual { get; set; }
        public Nullable<decimal> JaaliQtyRecd { get; set; }
        public Nullable<decimal> BoxQtyRecd { get; set; }
        public Nullable<decimal> jaaliOutQty { get; set; }
        public Nullable<decimal> boxOutQty { get; set; }
        public Nullable<decimal> jaaliAdjustment { get; set; }
        public Nullable<decimal> boxAdjustment { get; set; }
        public decimal LinerQty { get; set; }
        public Nullable<decimal> CANQty { get; set; }
        public Nullable<decimal> CANQtyRec { get; set; }
        public Nullable<decimal> CANOutQty { get; set; }
        public Nullable<decimal> CANAdjustment { get; set; }
        public string Route_code { get; set; }
        public decimal CrateQtyPreviousDay { get; set; }
        public Nullable<int> DamageCrateQtyRecd { get; set; }
    
        public virtual TSPL_CRATE_RECEIVED_HEAD_FRESHSALE TSPL_CRATE_RECEIVED_HEAD_FRESHSALE { get; set; }
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER { get; set; }
        public virtual TSPL_SD_SALE_INVOICE_HEAD TSPL_SD_SALE_INVOICE_HEAD { get; set; }
    }
}