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
    
    public partial class TSPL_BATCH_ITEM_NEW
    {
        public string Code { get; set; }
        public Nullable<int> Parent_Line_No { get; set; }
        public Nullable<int> Line_No { get; set; }
        public string Batch_No { get; set; }
        public string Item_Code { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public string UOM { get; set; }
        public string Document_Code { get; set; }
        public Nullable<System.DateTime> Document_Date { get; set; }
        public string Document_Type { get; set; }
        public string In_Out_Type { get; set; }
        public Nullable<int> Against_Inv_Movement_New_Trans_Id { get; set; }
        public string Location_Code { get; set; }
    
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
    }
}
