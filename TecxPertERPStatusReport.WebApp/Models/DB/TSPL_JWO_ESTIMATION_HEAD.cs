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
    
    public partial class TSPL_JWO_ESTIMATION_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_JWO_ESTIMATION_HEAD()
        {
            this.TSPL_JWO_ESTIMATION_FAT_PRODUCTION = new HashSet<TSPL_JWO_ESTIMATION_FAT_PRODUCTION>();
            this.TSPL_JWO_SRN_HEAD = new HashSet<TSPL_JWO_SRN_HEAD>();
            this.TSPL_JWO_ESTIMATION_TRANSFER = new HashSet<TSPL_JWO_ESTIMATION_TRANSFER>();
            this.TSPL_JWO_ESTIMATION_FAT_PRODUCTION_QC_PARAMETER = new HashSet<TSPL_JWO_ESTIMATION_FAT_PRODUCTION_QC_PARAMETER>();
            this.TSPL_JWO_ESTIMATION_SNF_PRODUCTION = new HashSet<TSPL_JWO_ESTIMATION_SNF_PRODUCTION>();
            this.TSPL_JWO_ESTIMATION_SNF_PRODUCTION_QC_PARAMETER = new HashSet<TSPL_JWO_ESTIMATION_SNF_PRODUCTION_QC_PARAMETER>();
            this.TSPL_JWO_ESTIMATION_RAW_ITEM = new HashSet<TSPL_JWO_ESTIMATION_RAW_ITEM>();
        }
    
        public string Document_NO { get; set; }
        public System.DateTime Document_Date { get; set; }
        public string Location_Code { get; set; }
        public string Vendor_Code { get; set; }
        public string Item_Structure_FAT { get; set; }
        public string Formula_code_FAT { get; set; }
        public Nullable<System.DateTime> Formula_Date_FAT { get; set; }
        public string Formula_FAT { get; set; }
        public string Item_Structure_SNF { get; set; }
        public string Formula_code_SNF { get; set; }
        public Nullable<System.DateTime> Formula_Date_SNF { get; set; }
        public string Formula_SNF { get; set; }
        public Nullable<decimal> Qty_Weighment { get; set; }
        public Nullable<decimal> FAT_KG_Weighment { get; set; }
        public Nullable<decimal> SNF_KG_Weighment { get; set; }
        public Nullable<decimal> Estimated_FAT_KG_Weighment { get; set; }
        public Nullable<decimal> Estimated_SNF_KG_Weighment { get; set; }
        public Nullable<decimal> FAT_KG_Raw_Item { get; set; }
        public Nullable<decimal> SNF_KG_Raw_Item { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public int Status { get; set; }
        public string Post_By { get; set; }
        public Nullable<System.DateTime> Post_Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_JWO_ESTIMATION_FAT_PRODUCTION> TSPL_JWO_ESTIMATION_FAT_PRODUCTION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_JWO_SRN_HEAD> TSPL_JWO_SRN_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_JWO_ESTIMATION_TRANSFER> TSPL_JWO_ESTIMATION_TRANSFER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_JWO_ESTIMATION_FAT_PRODUCTION_QC_PARAMETER> TSPL_JWO_ESTIMATION_FAT_PRODUCTION_QC_PARAMETER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_JWO_ESTIMATION_SNF_PRODUCTION> TSPL_JWO_ESTIMATION_SNF_PRODUCTION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_JWO_ESTIMATION_SNF_PRODUCTION_QC_PARAMETER> TSPL_JWO_ESTIMATION_SNF_PRODUCTION_QC_PARAMETER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_JWO_ESTIMATION_RAW_ITEM> TSPL_JWO_ESTIMATION_RAW_ITEM { get; set; }
        public virtual TSPL_STRUCTURE_MASTER TSPL_STRUCTURE_MASTER { get; set; }
        public virtual TSPL_STRUCTURE_MASTER TSPL_STRUCTURE_MASTER1 { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_VENDOR_MASTER TSPL_VENDOR_MASTER { get; set; }
    }
}
