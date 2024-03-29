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
    
    public partial class TSPL_SCHEME_MASTER_NEW
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_SCHEME_MASTER_NEW()
        {
            this.TSPL_SCHEME_MASTER_CASHDISVOLUME_SLAB = new HashSet<TSPL_SCHEME_MASTER_CASHDISVOLUME_SLAB>();
            this.TSPL_STRUCTURE_MASTER = new HashSet<TSPL_STRUCTURE_MASTER>();
            this.TSPL_STRUCTURE_MASTER1 = new HashSet<TSPL_STRUCTURE_MASTER>();
        }
    
        public string Scheme_Code { get; set; }
        public string Scheme_Desc { get; set; }
        public Nullable<System.DateTime> Start_Date { get; set; }
        public Nullable<System.DateTime> End_Date { get; set; }
        public string Scheme_Type { get; set; }
        public string Item_Code { get; set; }
        public string Unit_Code { get; set; }
        public decimal Item_Qty { get; set; }
        public Nullable<decimal> MRP { get; set; }
        public Nullable<decimal> Basic_Price { get; set; }
        public Nullable<decimal> Percentage { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string Status { get; set; }
        public string Criteria { get; set; }
        public string Criteria_Code { get; set; }
        public string Comments { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modify_By { get; set; }
        public System.DateTime Modify_Date { get; set; }
        public string Comp_Code { get; set; }
        public Nullable<System.DateTime> MaxlimitStart_Date { get; set; }
        public Nullable<System.DateTime> MaxlimitEnd_Date { get; set; }
        public string Target_Sub_Type { get; set; }
        public int Apply_Slab { get; set; }
        public int Quantative_Scheme_In_Slab { get; set; }
        public int Quantum { get; set; }
        public string Structure_Code { get; set; }
        public string Structure_Unit { get; set; }
        public int Quantitive_Type { get; set; }
        public Nullable<decimal> Quantitive_Type_Structure_Main_Qty { get; set; }
        public string Quantitive_Type_Structure_Main_UOM { get; set; }
        public string Quantitive_Type_Structure_Free_Item { get; set; }
        public Nullable<decimal> Quantitive_Type_Structure_Free_Qty { get; set; }
        public string Quantitive_Type_Structure_Free_UOM { get; set; }
        public string CASHDISVOL_RANGE_UOM { get; set; }
        public string CASHDISVOL_UOM { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER1 { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER2 { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER3 { get; set; }
        public virtual TSPL_SCHEME_MASTER_NEW_QUANTATIVE_SLAB TSPL_SCHEME_MASTER_NEW_QUANTATIVE_SLAB { get; set; }
        public virtual TSPL_SCHEME_MASTER_NEW_SLAB TSPL_SCHEME_MASTER_NEW_SLAB { get; set; }
        public virtual TSPL_SCHEME_MASTER_VOLUME_SLAB TSPL_SCHEME_MASTER_VOLUME_SLAB { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SCHEME_MASTER_CASHDISVOLUME_SLAB> TSPL_SCHEME_MASTER_CASHDISVOLUME_SLAB { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_STRUCTURE_MASTER> TSPL_STRUCTURE_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_STRUCTURE_MASTER> TSPL_STRUCTURE_MASTER1 { get; set; }
    }
}
