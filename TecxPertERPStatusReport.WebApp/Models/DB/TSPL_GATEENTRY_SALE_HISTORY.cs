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
    
    public partial class TSPL_GATEENTRY_SALE_HISTORY
    {
        public string Document_No { get; set; }
        public System.DateTime Document_Date { get; set; }
        public string Tanker_No { get; set; }
        public string Location_Code { get; set; }
        public string Tanker_Transporter_Code { get; set; }
        public string Customer_Code { get; set; }
        public string Dispatch_No { get; set; }
        public string IsSaleReturn { get; set; }
        public string SaleReturnAgaintGEN { get; set; }
        public int Posted { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string Comp_Code { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string SalesOrder_Code { get; set; }
        public string Bulk_SO_No { get; set; }
    }
}