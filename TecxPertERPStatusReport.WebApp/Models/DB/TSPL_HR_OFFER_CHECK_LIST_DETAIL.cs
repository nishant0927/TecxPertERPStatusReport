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
    
    public partial class TSPL_HR_OFFER_CHECK_LIST_DETAIL
    {
        public string APPLICANT_CODE { get; set; }
        public string Chk_Code { get; set; }
        public string Remarks { get; set; }
        public int Received { get; set; }
        public string Attachment { get; set; }
        public int OfferMandatory { get; set; }
    
        public virtual TSPL_HR_Check_List TSPL_HR_Check_List { get; set; }
        public virtual TSPL_HR_OFFER_CHECK_LIST_HEAD TSPL_HR_OFFER_CHECK_LIST_HEAD { get; set; }
    }
}
