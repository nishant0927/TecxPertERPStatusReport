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
    
    public partial class TSPL_CUSTOM_FIELD_CONDITIONS
    {
        public string Custom_Field_Code { get; set; }
        public Nullable<int> SNo { get; set; }
        public string LogicalOperator { get; set; }
        public int ConditionalOperator { get; set; }
        public string ConditionValue { get; set; }
    
        public virtual TSPL_CUSTOM_FIELD_HEAD TSPL_CUSTOM_FIELD_HEAD { get; set; }
    }
}
