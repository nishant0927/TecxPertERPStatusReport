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
    
    public partial class TSPL_Schedule_Training_RESOURCE_DETAIL
    {
        public string DOC_DOCE { get; set; }
        public string Resource_Code { get; set; }
        public string DOC_CODE { get; set; }
    
        public virtual TSPL_Schedule_Training_Head TSPL_Schedule_Training_Head { get; set; }
        public virtual TSPL_Schedule_Training_Head TSPL_Schedule_Training_Head1 { get; set; }
        public virtual Tspl_Training_Resource_Master Tspl_Training_Resource_Master { get; set; }
    }
}
