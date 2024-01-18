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
    
    public partial class TSPL_JWI_ESTIMATION_FAT_PRODUCTION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_JWI_ESTIMATION_FAT_PRODUCTION()
        {
            this.TSPL_JWI_ESTIMATION_FAT_PRODUCTION_QC_PARAMETER = new HashSet<TSPL_JWI_ESTIMATION_FAT_PRODUCTION_QC_PARAMETER>();
        }
    
        public string TR_Code { get; set; }
        public System.DateTime TR_Date { get; set; }
        public string Document_NO { get; set; }
        public Nullable<int> SNo { get; set; }
        public string Batch_No { get; set; }
        public string Item_Code { get; set; }
        public string BOM_CODE { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public string UOM { get; set; }
        public Nullable<decimal> FAT_Per { get; set; }
        public Nullable<decimal> FAT_KG { get; set; }
        public Nullable<decimal> Estimated_Qty { get; set; }
        public Nullable<decimal> Estimated_FAT_KG { get; set; }
    
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_PP_BOM_HEAD TSPL_PP_BOM_HEAD { get; set; }
        public virtual TSPL_JWI_ESTIMATION_HEAD TSPL_JWI_ESTIMATION_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_JWI_ESTIMATION_FAT_PRODUCTION_QC_PARAMETER> TSPL_JWI_ESTIMATION_FAT_PRODUCTION_QC_PARAMETER { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
    }
}