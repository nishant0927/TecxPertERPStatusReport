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
    
    public partial class TSPL_WS_DATA
    {
        public int SNo { get; set; }
        public string Doc_From { get; set; }
        public Nullable<int> Appl_User_ID { get; set; }
        public string Req_ID { get; set; }
        public Nullable<System.DateTime> Req_Date { get; set; }
        public string Req_dtls { get; set; }
        public string txn_id { get; set; }
        public string Corp_code { get; set; }
        public Nullable<decimal> Txn_amnt { get; set; }
        public string pmode { get; set; }
        public Nullable<System.DateTime> Transaction_Date { get; set; }
        public string UTR_Number { get; set; }
        public string Cust_Code { get; set; }
        public string Err_Code { get; set; }
        public string Err_desc { get; set; }
        public string Request_Type { get; set; }
    
        public virtual TSPL_WS_ERROR_CODE TSPL_WS_ERROR_CODE { get; set; }
    }
}
