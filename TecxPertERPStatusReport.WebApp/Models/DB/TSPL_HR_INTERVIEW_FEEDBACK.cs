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
    
    public partial class TSPL_HR_INTERVIEW_FEEDBACK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_HR_INTERVIEW_FEEDBACK()
        {
            this.TSPL_HR_INTERVIEW_FEEDBACK_DETAIL = new HashSet<TSPL_HR_INTERVIEW_FEEDBACK_DETAIL>();
        }
    
        public string Feedback_Code { get; set; }
        public string APPLICANT_CODE { get; set; }
        public string Round_Code { get; set; }
        public string Final_Action { get; set; }
        public int Posted { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string Posted_By { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string Comp_Code { get; set; }
    
        public virtual TSPL_HR_APPLICANT_ENTRY TSPL_HR_APPLICANT_ENTRY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HR_INTERVIEW_FEEDBACK_DETAIL> TSPL_HR_INTERVIEW_FEEDBACK_DETAIL { get; set; }
        public virtual TSPL_HR_ROUND_MASTER TSPL_HR_ROUND_MASTER { get; set; }
    }
}