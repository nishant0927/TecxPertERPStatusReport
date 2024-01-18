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
    
    public partial class TSPL_PP_STD_ADD_REMOVE_ITEM_DETAIL
    {
        public string Standardization_Code { get; set; }
        public int SNO { get; set; }
        public string Item_Code { get; set; }
        public string Unit_Code { get; set; }
        public Nullable<double> ADD_REMOVE_QTY { get; set; }
        public string ADD_REMOVE_TYPE { get; set; }
        public string Loaction_Code { get; set; }
        public string Remarks { get; set; }
        public string Comp_Code { get; set; }
        public Nullable<double> AR_FAT_Per { get; set; }
        public Nullable<double> AR_SNF_Per { get; set; }
        public Nullable<double> AR_FAT_KG { get; set; }
        public Nullable<double> AR_SNF_KG { get; set; }
        public double Fat_Rate { get; set; }
        public double SNF_Rate { get; set; }
        public double Fat_Amt { get; set; }
        public double SNF_Amt { get; set; }
        public Nullable<int> Total_Amount { get; set; }
    
        public virtual TSPL_COMPANY_MASTER TSPL_COMPANY_MASTER { get; set; }
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_PP_STANDARDIZATION_HEAD TSPL_PP_STANDARDIZATION_HEAD { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
    }
}