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
    
    public partial class TSPL_SERIAL_ITEM
    {
        public string Code { get; set; }
        public Nullable<int> Parent_Line_No { get; set; }
        public Nullable<int> Line_No { get; set; }
        public string Auto_Sr_No { get; set; }
        public string Item_Code { get; set; }
        public string Document_Code { get; set; }
        public Nullable<System.DateTime> Document_Date { get; set; }
        public string Document_Type { get; set; }
        public string In_Out_Type { get; set; }
        public Nullable<int> Against_Inv_Movement_Trans_Id { get; set; }
        public string Location_Code { get; set; }
        public string QC_Complete { get; set; }
        public string Auto_Bin_No { get; set; }
    
        public virtual TSPL_INVENTORY_MOVEMENT TSPL_INVENTORY_MOVEMENT { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
    }
}