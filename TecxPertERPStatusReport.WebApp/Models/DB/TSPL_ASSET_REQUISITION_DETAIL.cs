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
    
    public partial class TSPL_ASSET_REQUISITION_DETAIL
    {
        public string ASSET_REQ_CODE { get; set; }
        public string Asset_Code { get; set; }
        public string ASSET_DESC { get; set; }
        public decimal QUANTITY { get; set; }
        public string ASSET_SIZE { get; set; }
        public string OUTLET_STATUS { get; set; }
    
        public virtual TSPL_ASSET_REQUISITION TSPL_ASSET_REQUISITION { get; set; }
    }
}