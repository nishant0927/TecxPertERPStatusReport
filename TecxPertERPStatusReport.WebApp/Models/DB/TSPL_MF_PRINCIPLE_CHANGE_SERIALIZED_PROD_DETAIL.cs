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
    
    public partial class TSPL_MF_PRINCIPLE_CHANGE_SERIALIZED_PROD_DETAIL
    {
        public string Doc_No { get; set; }
        public int Sno { get; set; }
        public string Location_Code { get; set; }
        public string Main_Item_Code { get; set; }
        public string BOM_Code { get; set; }
        public string Unit_code { get; set; }
        public string Serial_No { get; set; }
        public string Remarks { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_MF_PRINCIPLE_CHANGE_SERIALIZED_HEAD TSPL_MF_PRINCIPLE_CHANGE_SERIALIZED_HEAD { get; set; }
    }
}
