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
    
    public partial class tspl_BankReco_Detail
    {
        public string Reconciliation_Id { get; set; }
        public string Bank_Code { get; set; }
        public Nullable<System.DateTime> Cheque_Date { get; set; }
        public string Cheque_No { get; set; }
        public string Document_No { get; set; }
        public string Description { get; set; }
        public decimal Withdrawal { get; set; }
        public decimal Deposit { get; set; }
        public decimal Cleared_Amount { get; set; }
        public string Reconciliation_Status { get; set; }
        public Nullable<System.DateTime> Reconciliation_Date { get; set; }
        public string Reconciliation_Description { get; set; }
        public string Document_Type { get; set; }
        public Nullable<System.DateTime> Document_Date { get; set; }
        public string Entry_Type { get; set; }
        public string Customer_Name { get; set; }
        public string Payment_Code_reco { get; set; }
        public int is_Hide { get; set; }
        public Nullable<System.DateTime> ReconciliationDone_Date { get; set; }
        public string Remarks { get; set; }
        public string ReferenceDocNo { get; set; }
    
        public virtual tspl_BankReco_Head tspl_BankReco_Head { get; set; }
    }
}
