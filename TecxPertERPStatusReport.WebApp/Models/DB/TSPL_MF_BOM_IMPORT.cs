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
    
    public partial class TSPL_MF_BOM_IMPORT
    {
        public int BOM_IMPORT_ID { get; set; }
        public System.DateTime IMPORT_DATE { get; set; }
        public string DESCRIPTION { get; set; }
        public string BOM_TR_TYPE { get; set; }
        public byte[] IMPORTED_DOC { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
    }
}
