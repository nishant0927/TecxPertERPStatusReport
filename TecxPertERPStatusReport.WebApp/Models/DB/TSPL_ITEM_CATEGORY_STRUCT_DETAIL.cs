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
    
    public partial class TSPL_ITEM_CATEGORY_STRUCT_DETAIL
    {
        public string ITEM_CATEGORY_STRUCT_CODE { get; set; }
        public string ITEM_CATEGORY_CODE { get; set; }
        public int CATEGORY_LEVEL { get; set; }
        public string Form_Type { get; set; }
        public Nullable<int> Line_No { get; set; }
    
        public virtual TSPL_ITEM_CATEGORY_LEVEL TSPL_ITEM_CATEGORY_LEVEL { get; set; }
        public virtual TSPL_ITEM_CATEGORY_STRUCTURE TSPL_ITEM_CATEGORY_STRUCTURE { get; set; }
    }
}
