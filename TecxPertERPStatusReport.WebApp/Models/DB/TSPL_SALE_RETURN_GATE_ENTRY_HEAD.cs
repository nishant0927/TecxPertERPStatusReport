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
    
    public partial class TSPL_SALE_RETURN_GATE_ENTRY_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_SALE_RETURN_GATE_ENTRY_HEAD()
        {
            this.TSPL_SALE_RETURN_GATE_ENTRY_DETAIL = new HashSet<TSPL_SALE_RETURN_GATE_ENTRY_DETAIL>();
        }
    
        public string Gate_Entry_No { get; set; }
        public Nullable<System.DateTime> Gate_Entry_Date { get; set; }
        public string Vehicle_Code { get; set; }
        public string Man_Vehicle_Code { get; set; }
        public string Location_Code { get; set; }
        public string Transport { get; set; }
        public string Man_Transport { get; set; }
        public string Doc_Type { get; set; }
        public string Customer_Code { get; set; }
        public string Remarks { get; set; }
        public string Comment { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public string Modify_By { get; set; }
        public Nullable<System.DateTime> Modify_Date { get; set; }
        public string Comp_Code { get; set; }
        public Nullable<int> POSTED { get; set; }
        public int isCancel { get; set; }
        public Nullable<System.DateTime> Cancel_Date { get; set; }
    
        public virtual TSPL_CUSTOMER_MASTER TSPL_CUSTOMER_MASTER { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_SALE_RETURN_GATE_ENTRY_INVOICE_WISE TSPL_SALE_RETURN_GATE_ENTRY_INVOICE_WISE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SALE_RETURN_GATE_ENTRY_DETAIL> TSPL_SALE_RETURN_GATE_ENTRY_DETAIL { get; set; }
    }
}
