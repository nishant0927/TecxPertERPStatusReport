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
    
    public partial class TSPL_GAZE_READING_DETAIL
    {
        public int PK_ID { get; set; }
        public string Code { get; set; }
        public Nullable<int> MM { get; set; }
        public Nullable<int> Value { get; set; }
    
        public virtual TSPL_GAZE_READING TSPL_GAZE_READING { get; set; }
    }
}
