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
    
    public partial class TSPL_CSA_PRICE_OTHER_ITEM_DETAIL
    {
        public string Doc_No { get; set; }
        public string Item_Code { get; set; }
        public string UOM { get; set; }
        public Nullable<double> Unit_Rate { get; set; }
        public Nullable<double> MRP { get; set; }
    
        public virtual TSPL_CSA_PRICE_HEAD TSPL_CSA_PRICE_HEAD { get; set; }
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
    }
}
