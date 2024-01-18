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
    
    public partial class TSPL_MF_TOOL_MASTER
    {
        public string TOOL_CODE { get; set; }
        public string DESCRIPTION { get; set; }
        public string STATUS { get; set; }
        public System.DateTime INACTIVE_DATE { get; set; }
        public string TOOL_TYPE_CODE { get; set; }
        public Nullable<System.DateTime> RECEIPT_DATE { get; set; }
        public string RECEIVED_BY { get; set; }
        public string SUPPLIER { get; set; }
        public string RECEIPT_NUMBER { get; set; }
        public string PO_NUMBER { get; set; }
        public string SERIAL_NUMBER { get; set; }
        public string CUSTODIAN { get; set; }
        public Nullable<System.DateTime> REPLACEMENT_DATE { get; set; }
        public string COMMENTS { get; set; }
        public double COST_PER_UNIT { get; set; }
        public double ORIGINAL_QUANTITY { get; set; }
        public double CONSUMED { get; set; }
        public double ON_HAND_QUANTITY { get; set; }
        public double ON_HAND_COST { get; set; }
        public string UNIT_CODE { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string MAINTAINED_BY { get; set; }
        public string comp_code { get; set; }
    
        public virtual TSPL_MF_TOOL_TYPE TSPL_MF_TOOL_TYPE { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
    }
}
