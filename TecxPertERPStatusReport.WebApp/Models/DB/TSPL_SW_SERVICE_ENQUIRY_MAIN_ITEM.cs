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
    
    public partial class TSPL_SW_SERVICE_ENQUIRY_MAIN_ITEM
    {
        public string Service_Enquiry_Code { get; set; }
        public string Main_Item_Code { get; set; }
        public string Serial_No { get; set; }
        public string Issued_Code { get; set; }
        public string Warranty_Status { get; set; }
        public string Charge_Status { get; set; }
        public string BOM_Revision_No { get; set; }
        public string Item_Code { get; set; }
        public string Main_Serial_No { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER1 { get; set; }
        public virtual TSPL_SW_FAULT_MASTER TSPL_SW_FAULT_MASTER { get; set; }
        public virtual TSPL_SW_SERVICE_ENQUIRY TSPL_SW_SERVICE_ENQUIRY { get; set; }
    }
}
