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
    
    public partial class TSPL_PP_PRODUCTION_PLAN_DETAIL
    {
        public string Plan_Code { get; set; }
        public Nullable<int> Sno { get; set; }
        public string Item_Code { get; set; }
        public string Unit_Code { get; set; }
        public Nullable<double> Delivery_Qty { get; set; }
        public Nullable<double> Sale_Qty { get; set; }
        public Nullable<double> Plan_Qty { get; set; }
        public Nullable<double> Final_Qty { get; set; }
        public string Remarks { get; set; }
        public string Comp_Code { get; set; }
        public Nullable<double> Avg_Sale_Qty { get; set; }
    
        public virtual TSPL_COMPANY_MASTER TSPL_COMPANY_MASTER { get; set; }
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
    }
}