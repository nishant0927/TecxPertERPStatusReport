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
    
    public partial class TSPL_COMPLAINT_ITEMS_DETAIL
    {
        public string comp_id { get; set; }
        public string Item_Code { get; set; }
        public string Item_desc { get; set; }
        public double Unit_Cost { get; set; }
        public double Qty { get; set; }
    
        public virtual TSPL_COMPLAINT_DETAIL TSPL_COMPLAINT_DETAIL { get; set; }
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
    }
}
