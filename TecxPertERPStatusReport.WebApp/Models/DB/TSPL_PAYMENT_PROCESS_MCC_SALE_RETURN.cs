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
    
    public partial class TSPL_PAYMENT_PROCESS_MCC_SALE_RETURN
    {
        public string Doc_No { get; set; }
        public string SLNO { get; set; }
        public string Return_Doc_No { get; set; }
        public string Return_Doc_Type { get; set; }
        public string Return_Doc_Date { get; set; }
        public string Shipment_Doc_No { get; set; }
        public string Shipment_Doc_Date { get; set; }
        public string Sale_Doc_No { get; set; }
        public string Sale_Doc_Date { get; set; }
        public string AR_Invoice_No { get; set; }
        public string AR_Invoice_Date { get; set; }
        public string Customer_CODE { get; set; }
        public string Customer_NAME { get; set; }
        public string Item_Code { get; set; }
        public string Item_Desc { get; set; }
        public double Amount { get; set; }
        public double Reduce_Deduc_Amt { get; set; }
    }
}