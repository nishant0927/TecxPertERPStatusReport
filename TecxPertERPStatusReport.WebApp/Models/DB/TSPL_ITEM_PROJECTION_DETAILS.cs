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
    
    public partial class TSPL_ITEM_PROJECTION_DETAILS
    {
        public string Projection_Code { get; set; }
        public string Doc_Date { get; set; }
        public string Item_Code { get; set; }
        public decimal Item_Qty { get; set; }
        public int Is_Item_Free { get; set; }
        public decimal Average { get; set; }
        public decimal Projection_Average { get; set; }
        public decimal Tollence { get; set; }
        public decimal Actual_Projection { get; set; }
        public string UOM { get; set; }
        public string Item_Desc { get; set; }
    }
}
