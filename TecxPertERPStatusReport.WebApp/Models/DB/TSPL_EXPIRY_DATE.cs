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
    
    public partial class TSPL_EXPIRY_DATE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_EXPIRY_DATE()
        {
            this.TSPL_HISTORY_EXPIRY_DATE = new HashSet<TSPL_HISTORY_EXPIRY_DATE>();
        }
    
        public string Screen_Name { get; set; }
        public string Program_Code { get; set; }
        public string Document_No { get; set; }
        public Nullable<System.DateTime> Doc_Date { get; set; }
        public Nullable<System.DateTime> Expiry_Date { get; set; }
        public Nullable<System.DateTime> New_Expiry_Date { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modified_By { get; set; }
        public string Modified_Date { get; set; }
        public string Comp_Code { get; set; }
    
        public virtual TSPL_PROGRAM_MASTER TSPL_PROGRAM_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HISTORY_EXPIRY_DATE> TSPL_HISTORY_EXPIRY_DATE { get; set; }
    }
}
