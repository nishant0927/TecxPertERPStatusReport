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
    
    public partial class TSPL_TANKER_MASTER_SALE_DETAIL
    {
        public string Tanker_Code { get; set; }
        public int Line_No { get; set; }
        public decimal Chamber_Capacity { get; set; }
        public string Capacity_Uom { get; set; }
        public string Chamber_Desc { get; set; }
    
        public virtual TSPL_TANKER_MASTER_SALE TSPL_TANKER_MASTER_SALE { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
    }
}
