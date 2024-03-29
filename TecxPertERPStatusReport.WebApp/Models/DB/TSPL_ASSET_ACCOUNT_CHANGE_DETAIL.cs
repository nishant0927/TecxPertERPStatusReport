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
    
    public partial class TSPL_ASSET_ACCOUNT_CHANGE_DETAIL
    {
        public string Doc_Code { get; set; }
        public int SNo { get; set; }
        public string Asset_Code { get; set; }
        public string Asset_Name { get; set; }
        public string Asset_Specification { get; set; }
        public string AcSet_Code { get; set; }
        public string AcSet_Code_Name { get; set; }
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public string Ac_Code { get; set; }
        public string Ac_Name { get; set; }
        public string ChangedAc_Code { get; set; }
        public string ChangedAc_Name { get; set; }
        public string Remarks { get; set; }
        public Nullable<decimal> Item_Net_Amt { get; set; }
        public string CostCenter_Code { get; set; }
        public string Hirerachy_Code { get; set; }
    
        public virtual TSPL_ASSET_ACCOUNT_CHANGE_HEAD TSPL_ASSET_ACCOUNT_CHANGE_HEAD { get; set; }
        public virtual TSPL_Dep_AccountSet TSPL_Dep_AccountSet { get; set; }
        public virtual TSPL_HIRERACHY_LEVEL_MASTER TSPL_HIRERACHY_LEVEL_MASTER { get; set; }
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
    }
}
