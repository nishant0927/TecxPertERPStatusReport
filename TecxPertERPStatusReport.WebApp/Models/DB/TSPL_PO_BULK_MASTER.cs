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
    
    public partial class TSPL_PO_BULK_MASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_PO_BULK_MASTER()
        {
            this.Tspl_Gate_Entry_Details = new HashSet<Tspl_Gate_Entry_Details>();
            this.TSPL_PO_BULK_DETAIL = new HashSet<TSPL_PO_BULK_DETAIL>();
        }
    
        public string PO_No { get; set; }
        public System.DateTime Date_And_Time { get; set; }
        public string location_Code { get; set; }
        public string Vendor_Code { get; set; }
        public string MIKL_TYPE_CODE { get; set; }
        public string Gate_Entry_Type { get; set; }
        public string Price_Code { get; set; }
        public double Rate { get; set; }
        public double Qty { get; set; }
        public int isPosted { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modify_By { get; set; }
        public string Modify_Date { get; set; }
        public string comp_code { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tspl_Gate_Entry_Details> Tspl_Gate_Entry_Details { get; set; }
        public virtual TSPL_MILK_TYPE_MASTER TSPL_MILK_TYPE_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PO_BULK_DETAIL> TSPL_PO_BULK_DETAIL { get; set; }
    }
}
