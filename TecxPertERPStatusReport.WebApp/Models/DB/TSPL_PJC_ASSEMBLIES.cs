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
    
    public partial class TSPL_PJC_ASSEMBLIES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_PJC_ASSEMBLIES()
        {
            this.TSPL_PJC_ASSEMBLIES1 = new HashSet<TSPL_PJC_ASSEMBLIES>();
            this.TSPL_PJC_ASSEMBLIES_ITEM_DETAIL = new HashSet<TSPL_PJC_ASSEMBLIES_ITEM_DETAIL>();
        }
    
        public string CODE { get; set; }
        public System.DateTime ASSEMBLY_DATE { get; set; }
        public string TRANSACTION_TYPE { get; set; }
        public string DISASSEMBLY_TYPE { get; set; }
        public string ASSEMBLY_CODE { get; set; }
        public string DESCRIPTION { get; set; }
        public string COMMENTS { get; set; }
        public string Main_Item_Code { get; set; }
        public string BOM_CODE { get; set; }
        public string COMP_ASSEMBL_METHOD { get; set; }
        public string LOCATION_CODE { get; set; }
        public decimal BUILD_QUANTITY { get; set; }
        public decimal QUANTITY { get; set; }
        public decimal DISASSEMBLY_COST { get; set; }
        public string BUILD_ITEM_UNIT_CODE { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public bool POSTED { get; set; }
        public Nullable<System.DateTime> POSTING_DATE { get; set; }
        public string Comp_Code { get; set; }
        public string MainItem_Type { get; set; }
        public string Serial_No { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_MF_BOM_HEAD TSPL_MF_BOM_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PJC_ASSEMBLIES> TSPL_PJC_ASSEMBLIES1 { get; set; }
        public virtual TSPL_PJC_ASSEMBLIES TSPL_PJC_ASSEMBLIES2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PJC_ASSEMBLIES_ITEM_DETAIL> TSPL_PJC_ASSEMBLIES_ITEM_DETAIL { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
    }
}
