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
    
    public partial class tspl_QuickSettleMent_Item_Detail
    {
        public string Quick_SettleMent_Id { get; set; }
        public string Transfer_Number { get; set; }
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public decimal MRP { get; set; }
        public decimal LoadOut_Qty { get; set; }
        public decimal LoadInFC_Qty { get; set; }
        public decimal LoadInFB_Qty { get; set; }
        public decimal Total_LoadInFC_Qty { get; set; }
        public decimal Provisional_SaleQty { get; set; }
        public decimal Retailer_Price { get; set; }
        public decimal Provisional_Sale_Amount { get; set; }
        public decimal FOC_FCQty { get; set; }
        public decimal FOC_FBQty { get; set; }
        public decimal Total_FOC_FCQty { get; set; }
        public decimal NetSale_Amount { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modified_By { get; set; }
        public string Modified_Date { get; set; }
        public string Comp_Code { get; set; }
        public decimal FOC_Amount { get; set; }
        public decimal NetLoad_Qty { get; set; }
    }
}
