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
    
    public partial class TSPL_MilkCollectionCenter
    {
        public string COLLECTION_CENTER_CODE { get; set; }
        public string DESCRIPTION { get; set; }
        public string LEVEL_CODE { get; set; }
        public string EMAIL_ADDRESS { get; set; }
        public string City { get; set; }
        public string State_Code { get; set; }
        public string State_Name { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Telphone { get; set; }
        public string ADDRESS1 { get; set; }
        public string ADDRESS2 { get; set; }
        public string ADDRESS3 { get; set; }
        public string ADDRESS4 { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string Comp_Code { get; set; }
    
        public virtual TSPL_MilkCollectionLevels TSPL_MilkCollectionLevels { get; set; }
    }
}
