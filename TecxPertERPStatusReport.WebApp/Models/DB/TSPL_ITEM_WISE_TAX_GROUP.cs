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
    
    public partial class TSPL_ITEM_WISE_TAX_GROUP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_ITEM_WISE_TAX_GROUP()
        {
            this.TSPL_ITEM_WISE_TAX_AUTHORITY = new HashSet<TSPL_ITEM_WISE_TAX_AUTHORITY>();
        }
    
        public string DCODE { get; set; }
        public Nullable<int> SNO { get; set; }
        public string HCODE { get; set; }
        public string Item_Code { get; set; }
        public string Tax_Group_Code { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_ITEM_WISE_TAX TSPL_ITEM_WISE_TAX { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ITEM_WISE_TAX_AUTHORITY> TSPL_ITEM_WISE_TAX_AUTHORITY { get; set; }
    }
}