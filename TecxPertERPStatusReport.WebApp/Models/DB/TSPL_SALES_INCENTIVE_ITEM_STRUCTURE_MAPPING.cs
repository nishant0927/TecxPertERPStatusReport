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
    
    public partial class TSPL_SALES_INCENTIVE_ITEM_STRUCTURE_MAPPING
    {
        public string TR_CODE { get; set; }
        public string INCENTIVE_CODE { get; set; }
        public string Structure_Code { get; set; }
    
        public virtual TSPL_SALES_INCENTIVE_HEADER TSPL_SALES_INCENTIVE_HEADER { get; set; }
        public virtual TSPL_STRUCTURE_MASTER TSPL_STRUCTURE_MASTER { get; set; }
    }
}
