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
    
    public partial class TSPL_LOCATION_WISE_TAX_MASTER
    {
        public string Location_Code { get; set; }
        public string Tax_Group_Code { get; set; }
        public string Tax_Code { get; set; }
        public Nullable<double> TAX_Rate { get; set; }
        public int Is_Default_Tax { get; set; }
        public int Is_Default_Tax_Group { get; set; }
        public string Tax_Type { get; set; }
        public string Tax_Category { get; set; }
        public int Is_Default_Tax_Group_GST { get; set; }
    }
}
