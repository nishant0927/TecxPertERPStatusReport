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
    
    public partial class TSPL_TRAGET_MASTER_Detail
    {
        public string Traget_Code { get; set; }
        public int LINE_NO { get; set; }
        public string Item_Code { get; set; }
        public string Unit_Code { get; set; }
        public double Qty { get; set; }
        public double Scheme_Qty { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_TRAGET_MASTER_HEAD TSPL_TRAGET_MASTER_HEAD { get; set; }
    }
}