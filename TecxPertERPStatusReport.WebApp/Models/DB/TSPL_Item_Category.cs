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
    
    public partial class TSPL_Item_Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_Item_Category()
        {
            this.TSPL_ITEM_SUB_CATEGORY = new HashSet<TSPL_ITEM_SUB_CATEGORY>();
            this.TSPL_ITEM_SUB_CATEGORY1 = new HashSet<TSPL_ITEM_SUB_CATEGORY>();
            this.TSPL_ITEM_MASTER = new HashSet<TSPL_ITEM_MASTER>();
        }
    
        public string Category_Code { get; set; }
        public string Category_Name { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modify_By { get; set; }
        public string Modify_Date { get; set; }
        public string comp_code { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ITEM_SUB_CATEGORY> TSPL_ITEM_SUB_CATEGORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ITEM_SUB_CATEGORY> TSPL_ITEM_SUB_CATEGORY1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ITEM_MASTER> TSPL_ITEM_MASTER { get; set; }
    }
}
