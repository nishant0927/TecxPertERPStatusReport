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
    
    public partial class TSPL_PRICE_COMPONENT_MAPPING
    {
        public int Price_Component_Map_Code { get; set; }
        public string Price_Code { get; set; }
        public string Price_Code_Desc { get; set; }
        public string Remarks { get; set; }
        public string Price_Comp_Code { get; set; }
        public string Price_Comp_Desc { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> Discount_Percent { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modify_By { get; set; }
        public System.DateTime Modify_Date { get; set; }
        public string Comp_Code { get; set; }
        public string Price_Calculation_Method { get; set; }
        public string vendor_code { get; set; }
        public Nullable<int> Transfer { get; set; }
    
        public virtual TSPL_PRICE_COMPONENT_MASTER TSPL_PRICE_COMPONENT_MASTER { get; set; }
    }
}