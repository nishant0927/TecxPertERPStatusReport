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
    
    public partial class TSPL_MCC_DISPATCH_CHALAN_RETURN_PARAMETER_DETAIL_HISTORY
    {
        public string Return_No { get; set; }
        public string Param_Field_Code { get; set; }
        public string Param_Field_Desc { get; set; }
        public string Param_Field_Value { get; set; }
        public string Param_Type { get; set; }
        public int SNO { get; set; }
    
        public virtual TSPL_MCC_TANKER_DISPATCH_RETURN_HEAD TSPL_MCC_TANKER_DISPATCH_RETURN_HEAD { get; set; }
    }
}
