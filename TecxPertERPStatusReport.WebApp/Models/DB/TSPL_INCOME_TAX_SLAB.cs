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
    
    public partial class TSPL_INCOME_TAX_SLAB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_INCOME_TAX_SLAB()
        {
            this.TSPL_INCOME_TAX_SLAB_DETAIL = new HashSet<TSPL_INCOME_TAX_SLAB_DETAIL>();
        }
    
        public string IT_CODE { get; set; }
        public string Description { get; set; }
        public string Applied_For { get; set; }
        public string Comp_Code { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_INCOME_TAX_SLAB_DETAIL> TSPL_INCOME_TAX_SLAB_DETAIL { get; set; }
    }
}
