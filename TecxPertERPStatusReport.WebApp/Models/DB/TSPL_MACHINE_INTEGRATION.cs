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
    
    public partial class TSPL_MACHINE_INTEGRATION
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public int isContinuousDataReading { get; set; }
        public string DataSample { get; set; }
        public string StartStopCharacter { get; set; }
        public int IntFromPos { get; set; }
        public int IntNoOfChar { get; set; }
        public int FracFromPos { get; set; }
        public int FracNoOfChar { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string comp_code { get; set; }
        public string Input_String { get; set; }
        public int Check_For_Zero { get; set; }
    }
}
