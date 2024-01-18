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
    
    public partial class TSPL_Item_Stock_Conversion_Detail
    {
        public string Doc_No { get; set; }
        public string UOM_Code { get; set; }
        public string UOM_DESC { get; set; }
        public double Conversion_factor { get; set; }
        public string Stocking_Unit { get; set; }
        public double Stock_In_Hand { get; set; }
        public string Required_UOM_Code { get; set; }
        public string Required_UOM_Desc { get; set; }
        public double Required_Qty { get; set; }
        public double Input_From_Qty { get; set; }
        public double Output_To_Qty { get; set; }
        public double Output_Stock_Qty { get; set; }
        public string Remarks { get; set; }
        public double Input_From_MRP { get; set; }
        public double Output_To_MRP { get; set; }
        public double Output_Stock_MRP { get; set; }
    
        public virtual TSPL_Item_Stock_Conversion_Head TSPL_Item_Stock_Conversion_Head { get; set; }
    }
}