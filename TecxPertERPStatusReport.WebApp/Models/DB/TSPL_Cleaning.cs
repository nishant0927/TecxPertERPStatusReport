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
    
    public partial class TSPL_Cleaning
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_Cleaning()
        {
            this.TSPL_IssueReturn_HEAD = new HashSet<TSPL_IssueReturn_HEAD>();
        }
    
        public string Doc_No { get; set; }
        public System.DateTime Start_Date_Time { get; set; }
        public System.DateTime End_Date_Time { get; set; }
        public string Gate_Entry_No { get; set; }
        public string Weighment_No { get; set; }
        public string QC_No { get; set; }
        public string Tanker_No { get; set; }
        public int isPosted { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string Done_by { get; set; }
        public string Checked_by { get; set; }
        public string Status { get; set; }
        public string Vehicle_No { get; set; }
        public string Source { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modify_By { get; set; }
        public string Modify_Date { get; set; }
        public string comp_code { get; set; }
        public string Remarks { get; set; }
        public Nullable<System.DateTime> InTime { get; set; }
        public Nullable<System.DateTime> OutTime { get; set; }
        public Nullable<int> IsAgainstJobWork { get; set; }
        public string Joblocation_Code { get; set; }
    
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER { get; set; }
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_IssueReturn_HEAD> TSPL_IssueReturn_HEAD { get; set; }
    }
}