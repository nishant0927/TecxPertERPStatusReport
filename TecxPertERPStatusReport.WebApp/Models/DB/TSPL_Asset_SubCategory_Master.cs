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
    
    public partial class TSPL_Asset_SubCategory_Master
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_Asset_SubCategory_Master()
        {
            this.TSPL_Asset_Details = new HashSet<TSPL_Asset_Details>();
            this.TSPL_Asset_SubCategory_Master1 = new HashSet<TSPL_Asset_SubCategory_Master>();
        }
    
        public string Code { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string CreateUser { get; set; }
        public string ModUser { get; set; }
        public Nullable<System.DateTime> LastMod { get; set; }
        public string CompCode { get; set; }
        public string Asset_Sub_Category { get; set; }
        public string Company { get; set; }
        public string FileName { get; set; }
        public byte[] Attachment { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_Asset_Details> TSPL_Asset_Details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_Asset_SubCategory_Master> TSPL_Asset_SubCategory_Master1 { get; set; }
        public virtual TSPL_Asset_SubCategory_Master TSPL_Asset_SubCategory_Master2 { get; set; }
        public virtual TSPL_Asset_Type_Master TSPL_Asset_Type_Master { get; set; }
    }
}
