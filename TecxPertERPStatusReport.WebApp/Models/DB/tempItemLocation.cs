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
    
    public partial class tempItemLocation
    {
        public string Item_Code { get; set; }
        public string Item_Desc { get; set; }
        public string Location_Code { get; set; }
        public string Location_Desc { get; set; }
        public Nullable<decimal> Item_Qty { get; set; }
        public int Amount { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modify_By { get; set; }
        public string Modify_Date { get; set; }
        public string Comp_code { get; set; }
        public decimal MRP { get; set; }
        public Nullable<System.DateTime> MFG_Date { get; set; }
        public string Batch_No { get; set; }
        public Nullable<System.DateTime> Expiry_Date { get; set; }
        public string ItemType { get; set; }
    }
}
