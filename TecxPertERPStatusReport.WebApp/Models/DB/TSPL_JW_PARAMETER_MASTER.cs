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
    
    public partial class TSPL_JW_PARAMETER_MASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_JW_PARAMETER_MASTER()
        {
            this.TSPL_JW_FORMULA_DETAILS = new HashSet<TSPL_JW_FORMULA_DETAILS>();
            this.TSPL_JWO_FORMULA_DETAILS = new HashSet<TSPL_JWO_FORMULA_DETAILS>();
        }
    
        public string Code { get; set; }
        public string Description { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public string Modify_By { get; set; }
        public Nullable<System.DateTime> Modify_Date { get; set; }
        public string Type { get; set; }
        public bool IS_MOISTURE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_JW_FORMULA_DETAILS> TSPL_JW_FORMULA_DETAILS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_JWO_FORMULA_DETAILS> TSPL_JWO_FORMULA_DETAILS { get; set; }
    }
}
