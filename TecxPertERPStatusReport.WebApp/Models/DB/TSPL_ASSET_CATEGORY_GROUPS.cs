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
    
    public partial class TSPL_ASSET_CATEGORY_GROUPS
    {
        public string Category_Code { get; set; }
        public int SNO { get; set; }
        public string Group_Code { get; set; }
    
        public virtual TSPL_ASSET_CATEGORY TSPL_ASSET_CATEGORY { get; set; }
        public virtual TSPL_ASSET_GROUP TSPL_ASSET_GROUP { get; set; }
    }
}
