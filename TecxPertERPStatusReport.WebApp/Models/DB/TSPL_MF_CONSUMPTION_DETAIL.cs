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
    
    public partial class TSPL_MF_CONSUMPTION_DETAIL
    {
        public int CONSM_CODE { get; set; }
        public string RECEIPT_CODE { get; set; }
        public string PRODUCTION_LINE_CODE { get; set; }
        public string CONSM_ITEM_CODE { get; set; }
        public decimal CONSM_QTY { get; set; }
        public string LOCATION_CODE { get; set; }
        public string UNIT_CODE { get; set; }
        public decimal FIFO_Cost { get; set; }
        public decimal LIFO_Cost { get; set; }
        public decimal Avg_Cost { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_MF_PRODUCTION_LINES TSPL_MF_PRODUCTION_LINES { get; set; }
        public virtual TSPL_MF_RECEIPT TSPL_MF_RECEIPT { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
    }
}
