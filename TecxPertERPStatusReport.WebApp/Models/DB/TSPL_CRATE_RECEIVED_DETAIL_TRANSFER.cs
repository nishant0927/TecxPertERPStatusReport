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
    
    public partial class TSPL_CRATE_RECEIVED_DETAIL_TRANSFER
    {
        public string Document_No { get; set; }
        public int Line_No { get; set; }
        public string Branch_Code { get; set; }
        public string Vehicle_Code { get; set; }
        public string VehicleNo { get; set; }
        public Nullable<decimal> CrateQty { get; set; }
        public Nullable<decimal> CrateQtyRecd { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public string Remarks { get; set; }
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
    
        public virtual TSPL_CRATE_RECEIVED_HEAD_TRANSFER TSPL_CRATE_RECEIVED_HEAD_TRANSFER { get; set; }
    }
}
