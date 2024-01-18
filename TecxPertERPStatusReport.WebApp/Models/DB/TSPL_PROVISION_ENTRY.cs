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
    
    public partial class TSPL_PROVISION_ENTRY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_PROVISION_ENTRY()
        {
            this.TSPL_PROVISION_ENTRY_KNOCKOFF = new HashSet<TSPL_PROVISION_ENTRY_KNOCKOFF>();
        }
    
        public string Doc_No { get; set; }
        public System.DateTime Doc_Date { get; set; }
        public string Vendor_Code { get; set; }
        public string Vendor_Desc { get; set; }
        public string Vendor_Type { get; set; }
        public string Status { get; set; }
        public string Ref_Doc_No { get; set; }
        public string Prov_type { get; set; }
        public double Amount { get; set; }
        public string Prog_Code { get; set; }
        public string Prov_Month { get; set; }
        public int Prov_Year { get; set; }
        public string Comp_Code { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public int isPosted { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string Loc_Code { get; set; }
        public string Loc_Desc { get; set; }
        public string Status_Update_Doc_No { get; set; }
        public string Route_Code { get; set; }
        public string Freight_Type { get; set; }
        public double EmptyCharge { get; set; }
        public double FixedCharge { get; set; }
        public Nullable<int> SYNC_STATUS { get; set; }
        public double Toll_Amt { get; set; }
        public string GL_Location_Seg { get; set; }
        public Nullable<decimal> FixedAmount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PROVISION_ENTRY_KNOCKOFF> TSPL_PROVISION_ENTRY_KNOCKOFF { get; set; }
        public virtual TSPL_VENDOR_MASTER TSPL_VENDOR_MASTER { get; set; }
    }
}
