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
    
    public partial class TSPL_ASSET_ACCOUNT_CHANGE_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_ASSET_ACCOUNT_CHANGE_HEAD()
        {
            this.TSPL_ASSET_ACCOUNT_CHANGE_DETAIL = new HashSet<TSPL_ASSET_ACCOUNT_CHANGE_DETAIL>();
        }
    
        public string Doc_Code { get; set; }
        public System.DateTime Doc_Date { get; set; }
        public string Acquisition_Code { get; set; }
        public string Loc_Code { get; set; }
        public int Status { get; set; }
        public Nullable<System.DateTime> Post_Date { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modify_By { get; set; }
        public System.DateTime Modify_Date { get; set; }
        public string comp_code { get; set; }
    
        public virtual TSPL_ACQUISITION_HEAD TSPL_ACQUISITION_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ASSET_ACCOUNT_CHANGE_DETAIL> TSPL_ASSET_ACCOUNT_CHANGE_DETAIL { get; set; }
    }
}
