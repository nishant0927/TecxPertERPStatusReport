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
    
    public partial class TSPL_MILK_TYPE_MASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_MILK_TYPE_MASTER()
        {
            this.Tspl_Gate_Entry_Details = new HashSet<Tspl_Gate_Entry_Details>();
            this.TSPL_INTIMATION_MASTER = new HashSet<TSPL_INTIMATION_MASTER>();
            this.TSPL_MILK_GRADE_MASTER = new HashSet<TSPL_MILK_GRADE_MASTER>();
            this.TSPL_BULK_MILK_SRN_CHEMBER_DETAILS = new HashSet<TSPL_BULK_MILK_SRN_CHEMBER_DETAILS>();
            this.TSPL_GATE_ENTRY_CHEMBER_DETAILS = new HashSet<TSPL_GATE_ENTRY_CHEMBER_DETAILS>();
            this.Tspl_Gate_Entry_Details_History = new HashSet<Tspl_Gate_Entry_Details_History>();
            this.TSPL_MILK_JOBWORK_TRANSFER_DETAILS = new HashSet<TSPL_MILK_JOBWORK_TRANSFER_DETAILS>();
            this.TSPL_PARAMETER_RANGE_MASTER = new HashSet<TSPL_PARAMETER_RANGE_MASTER>();
            this.TSPL_PARAMETER_RANGE_MASTER_HISTORY = new HashSet<TSPL_PARAMETER_RANGE_MASTER_HISTORY>();
            this.TSPL_PO_BULK_MASTER = new HashSet<TSPL_PO_BULK_MASTER>();
            this.TSPL_QUALITY_CHEMBER_DETAILS = new HashSet<TSPL_QUALITY_CHEMBER_DETAILS>();
        }
    
        public string MILK_TYPE_CODE { get; set; }
        public string DESCRIPTION { get; set; }
        public string MILK_TYPE { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string comp_code { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tspl_Gate_Entry_Details> Tspl_Gate_Entry_Details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_INTIMATION_MASTER> TSPL_INTIMATION_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_GRADE_MASTER> TSPL_MILK_GRADE_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_BULK_MILK_SRN_CHEMBER_DETAILS> TSPL_BULK_MILK_SRN_CHEMBER_DETAILS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_GATE_ENTRY_CHEMBER_DETAILS> TSPL_GATE_ENTRY_CHEMBER_DETAILS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tspl_Gate_Entry_Details_History> Tspl_Gate_Entry_Details_History { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_JOBWORK_TRANSFER_DETAILS> TSPL_MILK_JOBWORK_TRANSFER_DETAILS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PARAMETER_RANGE_MASTER> TSPL_PARAMETER_RANGE_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PARAMETER_RANGE_MASTER_HISTORY> TSPL_PARAMETER_RANGE_MASTER_HISTORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PO_BULK_MASTER> TSPL_PO_BULK_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_QUALITY_CHEMBER_DETAILS> TSPL_QUALITY_CHEMBER_DETAILS { get; set; }
    }
}
