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
    
    public partial class TSPL_CUSTOMER_CATEGORY_MASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_CUSTOMER_CATEGORY_MASTER()
        {
            this.TSPL_SECONDARY_CUSTOMER_MASTER = new HashSet<TSPL_SECONDARY_CUSTOMER_MASTER>();
            this.TSPL_CUSTOMER_MASTER = new HashSet<TSPL_CUSTOMER_MASTER>();
        }
    
        public string CUST_CATEGORY_CODE { get; set; }
        public string CUST_CATEGORY_DESC { get; set; }
        public string Price_Code { get; set; }
        public string Price_Code_Desc { get; set; }
        public string Route_No { get; set; }
        public string Route_Desc { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modify_By { get; set; }
        public string Modify_Date { get; set; }
        public string Comp_Code { get; set; }
        public string Shelf_Life { get; set; }
        public string price_CodeNon { get; set; }
        public string Price_Code_DescNon { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SECONDARY_CUSTOMER_MASTER> TSPL_SECONDARY_CUSTOMER_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CUSTOMER_MASTER> TSPL_CUSTOMER_MASTER { get; set; }
    }
}