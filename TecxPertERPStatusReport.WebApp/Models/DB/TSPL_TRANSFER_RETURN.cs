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
    
    public partial class TSPL_TRANSFER_RETURN
    {
        public string Document_No { get; set; }
        public System.DateTime Document_Date { get; set; }
        public string Transfer_No { get; set; }
        public string Remarks { get; set; }
        public string DOcument_Type { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Gate_ReturnNo { get; set; }
    
        public virtual TSPL_TRANSFER_ORDER_HEAD TSPL_TRANSFER_ORDER_HEAD { get; set; }
    }
}
