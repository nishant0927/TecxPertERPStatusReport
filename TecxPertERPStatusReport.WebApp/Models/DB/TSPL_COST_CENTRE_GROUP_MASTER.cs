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
    
    public partial class TSPL_COST_CENTRE_GROUP_MASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_COST_CENTRE_GROUP_MASTER()
        {
            this.TSPL_COST_CENTRE_FINANCIAL = new HashSet<TSPL_COST_CENTRE_FINANCIAL>();
            this.TSPL_CostCenter_MASTER = new HashSet<TSPL_CostCenter_MASTER>();
        }
    
        public string CostCenter_Code { get; set; }
        public string Description { get; set; }
        public string Comp_Code { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_COST_CENTRE_FINANCIAL> TSPL_COST_CENTRE_FINANCIAL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CostCenter_MASTER> TSPL_CostCenter_MASTER { get; set; }
    }
}