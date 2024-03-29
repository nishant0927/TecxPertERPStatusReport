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
    
    public partial class TSPL_MILK_PURCHASE_INVOICE_OWN_BMC_REJECT
    {
        public int PK_Id { get; set; }
        public string InvoiceNo { get; set; }
        public System.DateTime Doc_Date { get; set; }
        public int Against_Milk_Collection_MCC_Detail { get; set; }
        public string Milk_Type { get; set; }
        public Nullable<int> Applicable_On { get; set; }
        public Nullable<decimal> Avg_FAT { get; set; }
        public Nullable<decimal> Avg_SNF { get; set; }
        public string Price_Code { get; set; }
        public Nullable<decimal> Base_Value { get; set; }
        public Nullable<decimal> Base_Rate { get; set; }
        public Nullable<decimal> Amount { get; set; }
    
        public virtual TSPL_MILK_COLLECTION_MCC_DETAIL TSPL_MILK_COLLECTION_MCC_DETAIL { get; set; }
        public virtual TSPL_MILK_PURCHASE_INVOICE_HEAD TSPL_MILK_PURCHASE_INVOICE_HEAD { get; set; }
        public virtual TSPL_MILK_REJECT_TYPE TSPL_MILK_REJECT_TYPE { get; set; }
    }
}
