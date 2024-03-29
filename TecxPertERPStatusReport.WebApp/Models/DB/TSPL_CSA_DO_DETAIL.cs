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
    
    public partial class TSPL_CSA_DO_DETAIL
    {
        public string Doc_No { get; set; }
        public Nullable<int> Line_no { get; set; }
        public string Item_Code { get; set; }
        public string UOM { get; set; }
        public double Qty { get; set; }
        public double Unit_Rate { get; set; }
        public string Including_Tax { get; set; }
        public double Total_Amt { get; set; }
        public string Remarks { get; set; }
        public string CSA_Request_No { get; set; }
        public Nullable<double> Bal_Qty { get; set; }
        public Nullable<double> Req_Qty { get; set; }
        public bool Scheme_Applicable { get; set; }
        public bool FOC { get; set; }
        public string Scheme_Code { get; set; }
        public string Scheme_Type { get; set; }
        public string Scheme_Item_Code { get; set; }
        public Nullable<double> Scheme_Qty { get; set; }
        public string Scheme_Item_UOM { get; set; }
        public string Cash_Scheme_Code { get; set; }
        public string Cash_Scheme_Type { get; set; }
        public Nullable<double> Cash_Scheme_Pers { get; set; }
        public Nullable<double> Cash_Scheme_Amount { get; set; }
    
        public virtual TSPL_CSA_BOOKING_HEAD TSPL_CSA_BOOKING_HEAD { get; set; }
        public virtual TSPL_CSA_DO_HEAD TSPL_CSA_DO_HEAD { get; set; }
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
    }
}
