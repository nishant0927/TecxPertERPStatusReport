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
    
    public partial class TSPL_ASSET_INSTALL_PULLOUT
    {
        public string Asset_Id { get; set; }
        public string Customer_Id { get; set; }
        public string Customer_name { get; set; }
        public string Location { get; set; }
        public string Route { get; set; }
        public string Trans_Type { get; set; }
        public string Asset_Type { get; set; }
        public System.DateTime Trans_Date { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string Comp_Code { get; set; }
        public string Asset_Make { get; set; }
        public Nullable<System.DateTime> Asset_Installation_Date { get; set; }
        public Nullable<System.DateTime> Asset_Pullout_Date { get; set; }
        public string Asset_Size { get; set; }
        public string Model { get; set; }
    }
}
