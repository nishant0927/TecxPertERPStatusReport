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
    
    public partial class TSPL_HR_REIMBURSEMENT_TYPE_MASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_HR_REIMBURSEMENT_TYPE_MASTER()
        {
            this.TSPL_HR_TRAVEL_REIMBURSEMENT_EXPENSE_DETAIL = new HashSet<TSPL_HR_TRAVEL_REIMBURSEMENT_EXPENSE_DETAIL>();
        }
    
        public string Reimbursement_Code { get; set; }
        public string Description { get; set; }
        public string Reimbursement_Type { get; set; }
        public string Travel_Type { get; set; }
        public string Comp_Code { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HR_TRAVEL_REIMBURSEMENT_EXPENSE_DETAIL> TSPL_HR_TRAVEL_REIMBURSEMENT_EXPENSE_DETAIL { get; set; }
    }
}