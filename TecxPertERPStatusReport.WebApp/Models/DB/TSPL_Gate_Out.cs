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
    
    public partial class TSPL_Gate_Out
    {
        public string Doc_No { get; set; }
        public System.DateTime Doc_Date { get; set; }
        public string Gate_Entry_No { get; set; }
        public string Weighment_No { get; set; }
        public string QC_No { get; set; }
        public string Tanker_No { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modify_By { get; set; }
        public string Modify_Date { get; set; }
        public string comp_code { get; set; }
        public Nullable<int> IsAgainstJobWork { get; set; }
        public string Joblocation_Code { get; set; }
        public string AllocateToMCC { get; set; }
        public string DriverName { get; set; }
        public int IsPosted { get; set; }
        public string AcknowEntryDocument_No { get; set; }
    
        public virtual TSPL_ACKNOWLEDGENT_ENTRY_HEADER TSPL_ACKNOWLEDGENT_ENTRY_HEADER { get; set; }
    }
}
