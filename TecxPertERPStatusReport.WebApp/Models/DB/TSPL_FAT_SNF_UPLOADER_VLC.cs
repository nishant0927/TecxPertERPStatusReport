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
    
    public partial class TSPL_FAT_SNF_UPLOADER_VLC
    {
        public string Code { get; set; }
        public string VLC_Code { get; set; }
        public string Added_By { get; set; }
        public Nullable<System.DateTime> Added_On { get; set; }
    
        public virtual TSPL_VLC_MASTER_HEAD TSPL_VLC_MASTER_HEAD { get; set; }
    }
}
