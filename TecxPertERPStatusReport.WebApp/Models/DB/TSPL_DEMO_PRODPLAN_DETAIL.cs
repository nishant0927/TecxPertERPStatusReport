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
    
    public partial class TSPL_DEMO_PRODPLAN_DETAIL
    {
        public string Document_No { get; set; }
        public Nullable<int> Document_Line_No { get; set; }
        public int Labour_Strenth { get; set; }
        public string Process_Code { get; set; }
        public string Item_Code { get; set; }
        public string Capacity { get; set; }
        public int Reqd { get; set; }
        public int Requirement { get; set; }
        public int Labour_Capacity { get; set; }
        public decimal Second_Piece { get; set; }
        public decimal Required_Time { get; set; }
    }
}
