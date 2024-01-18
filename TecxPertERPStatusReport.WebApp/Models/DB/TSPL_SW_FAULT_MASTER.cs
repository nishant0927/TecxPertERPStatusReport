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
    
    public partial class TSPL_SW_FAULT_MASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_SW_FAULT_MASTER()
        {
            this.TSPL_SW_SERVICE_ENQUIRY_CHILD_ITEM = new HashSet<TSPL_SW_SERVICE_ENQUIRY_CHILD_ITEM>();
            this.TSPL_SW_SERVICE_ENQUIRY_MAIN_ITEM = new HashSet<TSPL_SW_SERVICE_ENQUIRY_MAIN_ITEM>();
            this.TSPL_SW_SERVICE_CALL = new HashSet<TSPL_SW_SERVICE_CALL>();
            this.TSPL_SW_SERVICE_ENQUIRY = new HashSet<TSPL_SW_SERVICE_ENQUIRY>();
        }
    
        public string Fault_Master_Code { get; set; }
        public string Fault_Master_Name { get; set; }
        public string Fault_Category_Code { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string Comp_Code { get; set; }
    
        public virtual TSPL_COMPANY_MASTER TSPL_COMPANY_MASTER { get; set; }
        public virtual TSPL_SW_FAULT_CATEGORY_MASTER TSPL_SW_FAULT_CATEGORY_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SW_SERVICE_ENQUIRY_CHILD_ITEM> TSPL_SW_SERVICE_ENQUIRY_CHILD_ITEM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SW_SERVICE_ENQUIRY_MAIN_ITEM> TSPL_SW_SERVICE_ENQUIRY_MAIN_ITEM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SW_SERVICE_CALL> TSPL_SW_SERVICE_CALL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SW_SERVICE_ENQUIRY> TSPL_SW_SERVICE_ENQUIRY { get; set; }
    }
}
