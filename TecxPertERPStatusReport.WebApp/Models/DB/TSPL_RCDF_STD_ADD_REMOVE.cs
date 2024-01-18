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
    
    public partial class TSPL_RCDF_STD_ADD_REMOVE
    {
        public int PK_ID { get; set; }
        public string Doc_Code { get; set; }
        public string ADD_REMOVE_TYPE { get; set; }
        public string Location_Code { get; set; }
        public string Item_Code { get; set; }
        public string Unit_Code { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> FAT { get; set; }
        public Nullable<decimal> FAT_KG { get; set; }
        public Nullable<decimal> SNF { get; set; }
        public Nullable<decimal> SNF_KG { get; set; }
        public string Remarks { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_RCDF_STD TSPL_RCDF_STD { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
    }
}
