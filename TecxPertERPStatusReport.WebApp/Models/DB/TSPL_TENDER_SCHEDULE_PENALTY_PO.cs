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
    
    public partial class TSPL_TENDER_SCHEDULE_PENALTY_PO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_TENDER_SCHEDULE_PENALTY_PO()
        {
            this.TSPL_SRN_TENDER = new HashSet<TSPL_SRN_TENDER>();
        }
    
        public string DocumentCode { get; set; }
        public int PK_Id { get; set; }
        public int Against_Tender_Schedule_PK_Id { get; set; }
        public Nullable<System.DateTime> Penalty_Date { get; set; }
        public Nullable<decimal> Penalty { get; set; }
    
        public virtual TSPL_PURCHASE_ORDER_HEAD TSPL_PURCHASE_ORDER_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SRN_TENDER> TSPL_SRN_TENDER { get; set; }
        public virtual TSPL_TENDER_SCHEDULE_PO TSPL_TENDER_SCHEDULE_PO { get; set; }
    }
}