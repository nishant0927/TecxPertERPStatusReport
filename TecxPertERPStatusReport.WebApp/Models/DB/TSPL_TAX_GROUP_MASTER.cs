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
    
    public partial class TSPL_TAX_GROUP_MASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_TAX_GROUP_MASTER()
        {
            this.TSPL_SHIPMENT_MASTER = new HashSet<TSPL_SHIPMENT_MASTER>();
            this.TSPL_TAX_GROUP_DETAILS = new HashSet<TSPL_TAX_GROUP_DETAILS>();
        }
    
        public string Tax_Group_Code { get; set; }
        public string Tax_Group_Desc { get; set; }
        public string Tax_Group_Type { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modify_By { get; set; }
        public string Modify_Date { get; set; }
        public string Comp_Code { get; set; }
        public string Excisable { get; set; }
        public string VAT { get; set; }
        public string STax { get; set; }
        public string Tax_Group_Code_InterState { get; set; }
        public string Tax_Group_Description_InterState { get; set; }
        public int Is_Transfer { get; set; }
        public string CURRENCY_CODE { get; set; }
        public int Is_Tax_Exempted { get; set; }
        public int Active { get; set; }
    
        public virtual TSPL_CURRENCY_MASTER TSPL_CURRENCY_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SHIPMENT_MASTER> TSPL_SHIPMENT_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_TAX_GROUP_DETAILS> TSPL_TAX_GROUP_DETAILS { get; set; }
    }
}
