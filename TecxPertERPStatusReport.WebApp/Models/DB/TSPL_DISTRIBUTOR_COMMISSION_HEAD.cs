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
    
    public partial class TSPL_DISTRIBUTOR_COMMISSION_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_DISTRIBUTOR_COMMISSION_HEAD()
        {
            this.TSPL_DISTRIBUTOR_COMMISSION_DETAIL = new HashSet<TSPL_DISTRIBUTOR_COMMISSION_DETAIL>();
            this.TSPL_DISTRIBUTOR_COMMISSION_ITEMS = new HashSet<TSPL_DISTRIBUTOR_COMMISSION_ITEMS>();
        }
    
        public string Doc_No { get; set; }
        public System.DateTime Document_Date { get; set; }
        public Nullable<System.DateTime> Applicable_Date { get; set; }
        public string Commision_UOM { get; set; }
        public int IsPosted { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string Posted_By { get; set; }
        public Nullable<System.DateTime> Posted_Date { get; set; }
        public string Distributor_Tagging_Code { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DISTRIBUTOR_COMMISSION_DETAIL> TSPL_DISTRIBUTOR_COMMISSION_DETAIL { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
        public virtual TSPL_DISTRIBUTOR_ROUTE TSPL_DISTRIBUTOR_ROUTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DISTRIBUTOR_COMMISSION_ITEMS> TSPL_DISTRIBUTOR_COMMISSION_ITEMS { get; set; }
    }
}