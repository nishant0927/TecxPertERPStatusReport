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
    
    public partial class TSPL_WS_ERROR_CODE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_WS_ERROR_CODE()
        {
            this.TSPL_WS_CS_RECORD_MASTER = new HashSet<TSPL_WS_CS_RECORD_MASTER>();
            this.TSPL_WS_DATA = new HashSet<TSPL_WS_DATA>();
        }
    
        public string Err_Code { get; set; }
        public string Err_desc { get; set; }
        public string Err_Exception { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_WS_CS_RECORD_MASTER> TSPL_WS_CS_RECORD_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_WS_DATA> TSPL_WS_DATA { get; set; }
    }
}
