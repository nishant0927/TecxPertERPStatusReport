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
    
    public partial class TSPL_ITEM_CATEGORY_LEVEL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_ITEM_CATEGORY_LEVEL()
        {
            this.TSPL_CUSTOMER_CATEGORY_STRUCTURE_MASTER = new HashSet<TSPL_CUSTOMER_CATEGORY_STRUCTURE_MASTER>();
            this.TSPL_ITEM_MASTER_CATEGORY = new HashSet<TSPL_ITEM_MASTER_CATEGORY>();
            this.TSPL_ITEM_CATEGORY_LEVEL_VALUES = new HashSet<TSPL_ITEM_CATEGORY_LEVEL_VALUES>();
            this.TSPL_ITEM_CATEGORY_STRUCT_DETAIL = new HashSet<TSPL_ITEM_CATEGORY_STRUCT_DETAIL>();
            this.TSPL_LOCATION_CATEGORY_MASTER = new HashSet<TSPL_LOCATION_CATEGORY_MASTER>();
            this.TSPL_VENDOR_CATEGORY_MASTER = new HashSet<TSPL_VENDOR_CATEGORY_MASTER>();
        }
    
        public string ITEM_CATEGORY_CODE { get; set; }
        public string DESCRIPTION { get; set; }
        public int CATEGORY_LEVEL { get; set; }
        public string Comp_Code { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string Form_Type { get; set; }
        public int Master_Packing { get; set; }
        public int Bin_Mapping { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CUSTOMER_CATEGORY_STRUCTURE_MASTER> TSPL_CUSTOMER_CATEGORY_STRUCTURE_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ITEM_MASTER_CATEGORY> TSPL_ITEM_MASTER_CATEGORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ITEM_CATEGORY_LEVEL_VALUES> TSPL_ITEM_CATEGORY_LEVEL_VALUES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ITEM_CATEGORY_STRUCT_DETAIL> TSPL_ITEM_CATEGORY_STRUCT_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_LOCATION_CATEGORY_MASTER> TSPL_LOCATION_CATEGORY_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_VENDOR_CATEGORY_MASTER> TSPL_VENDOR_CATEGORY_MASTER { get; set; }
    }
}