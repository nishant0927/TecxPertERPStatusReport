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
    
    public partial class TSPL_VENDOR_FORMULA_MAPPING
    {
        public string DocCode { get; set; }
        public System.DateTime DocDate { get; set; }
        public string VendorCode { get; set; }
        public string FormulaCode { get; set; }
        public int Posted { get; set; }
        public string Posted_By { get; set; }
        public Nullable<System.DateTime> Posted_Date { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
    }
}