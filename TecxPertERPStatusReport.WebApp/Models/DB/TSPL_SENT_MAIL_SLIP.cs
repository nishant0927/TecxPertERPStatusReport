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
    
    public partial class TSPL_SENT_MAIL_SLIP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_SENT_MAIL_SLIP()
        {
            this.TSPL_SENT_MAIL_SLIP_DETAIL = new HashSet<TSPL_SENT_MAIL_SLIP_DETAIL>();
        }
    
        public string MailCode { get; set; }
        public string USER_CODE { get; set; }
        public string PAY_PERIOD_CODE { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
    
        public virtual TSPL_PAYPERIOD_MASTER TSPL_PAYPERIOD_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SENT_MAIL_SLIP_DETAIL> TSPL_SENT_MAIL_SLIP_DETAIL { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER { get; set; }
    }
}
