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
    
    public partial class TSPL_PP_BOM_HEAD_HISTORY
    {
        public string BOM_CODE { get; set; }
        public System.DateTime BOM_DATE { get; set; }
        public string STATUS { get; set; }
        public string ITEM_CATEGORY_CODE { get; set; }
        public string ITEM_CATEGORY_Values { get; set; }
        public string PROD_ITEM_CODE { get; set; }
        public string PROD_ITEM_UNIT_CODE { get; set; }
        public double PROD_QUANTITY { get; set; }
        public string Section_Code { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public string Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_Date { get; set; }
        public string Is_Post { get; set; }
        public string Revision_No { get; set; }
        public Nullable<System.DateTime> Valid_FROM_DATE { get; set; }
        public Nullable<System.DateTime> Valid_UPTO_DATE { get; set; }
        public string comp_code { get; set; }
        public string Description { get; set; }
        public string History_No { get; set; }
        public int Is_OSP { get; set; }
        public string Vendor_Code { get; set; }
    }
}
