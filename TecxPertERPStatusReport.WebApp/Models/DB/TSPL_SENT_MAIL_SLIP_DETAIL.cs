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
    
    public partial class TSPL_SENT_MAIL_SLIP_DETAIL
    {
        public string MailCode { get; set; }
        public string EMP_CODE { get; set; }
        public string Email_Id { get; set; }
        public string Status { get; set; }
        public string Error_Log { get; set; }
    
        public virtual TSPL_EMPLOYEE_MASTER TSPL_EMPLOYEE_MASTER { get; set; }
        public virtual TSPL_SENT_MAIL_SLIP TSPL_SENT_MAIL_SLIP { get; set; }
    }
}