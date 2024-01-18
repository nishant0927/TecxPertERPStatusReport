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
    
    public partial class TSPL_VSP_DEDUCTION_MASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_VSP_DEDUCTION_MASTER()
        {
            this.TSPL_VSP_MAPPING = new HashSet<TSPL_VSP_MAPPING>();
        }
    
        public string Deduction_Code { get; set; }
        public string Deduction_Name { get; set; }
        public Nullable<int> Deduction_On { get; set; }
        public Nullable<decimal> Deduction_Rate { get; set; }
        public Nullable<decimal> Deduction_Minimum_FAT_Per { get; set; }
        public Nullable<decimal> Deduction_Minimum_SNF_Per { get; set; }
        public Nullable<int> Deduction_No_Of_Payment_Cycle_For_New_VSP { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_VSP_MAPPING> TSPL_VSP_MAPPING { get; set; }
    }
}