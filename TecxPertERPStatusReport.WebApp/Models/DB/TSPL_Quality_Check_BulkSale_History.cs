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
    
    public partial class TSPL_Quality_Check_BulkSale_History
    {
        public string QC_No { get; set; }
        public System.DateTime QC_Date { get; set; }
        public string Weighment_No { get; set; }
        public string LoadingTanker_No { get; set; }
        public string GateEntry_Document_No { get; set; }
        public string Customer_Code { get; set; }
        public string Tanker_No { get; set; }
        public string Location_Code { get; set; }
        public string Silo_No { get; set; }
        public double Correction_Factor { get; set; }
        public string Item_Code { get; set; }
        public string Unit_code { get; set; }
        public double Qty { get; set; }
        public double Fat { get; set; }
        public double CLR { get; set; }
        public double SNF { get; set; }
        public string Remarks { get; set; }
        public int Posted { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string Comp_Code { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string SalesOrder_Code { get; set; }
        public string ApprovalRequired { get; set; }
        public string Approved { get; set; }
    }
}
