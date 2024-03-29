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
    
    public partial class TSPL_JWO_SRN_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_JWO_SRN_HEAD()
        {
            this.TSPL_JWO_SRN_DETAIL = new HashSet<TSPL_JWO_SRN_DETAIL>();
            this.TSPL_JWO_SRN_RETURN = new HashSet<TSPL_JWO_SRN_RETURN>();
        }
    
        public string Document_No { get; set; }
        public System.DateTime Document_Date { get; set; }
        public string Document_Type { get; set; }
        public string Loc_Code { get; set; }
        public string Job_Loc_Code { get; set; }
        public string Vendor_Code { get; set; }
        public string Challan_No { get; set; }
        public Nullable<System.DateTime> Challan_Date { get; set; }
        public string Tanker_No { get; set; }
        public string Gate_Entry_No { get; set; }
        public Nullable<System.DateTime> Gate_Entry_Date { get; set; }
        public int Posted { get; set; }
        public Nullable<System.DateTime> Posted_Date { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public Nullable<decimal> Document_Amt { get; set; }
        public string Unloading_No { get; set; }
        public string Against_Gate_Entry_No { get; set; }
        public Nullable<decimal> Total_Job_Amt { get; set; }
        public string Against_Estimate { get; set; }
        public Nullable<decimal> TransferFATKG { get; set; }
        public Nullable<decimal> TransferFATRate { get; set; }
        public Nullable<decimal> TransferFATAmt { get; set; }
        public Nullable<decimal> TransferSNFKG { get; set; }
        public Nullable<decimal> TransferSNFRate { get; set; }
        public Nullable<decimal> TransferSNFAmt { get; set; }
    
        public virtual TSPL_JWO_ESTIMATION_HEAD TSPL_JWO_ESTIMATION_HEAD { get; set; }
        public virtual TSPL_JWO_GATE_ENTRY TSPL_JWO_GATE_ENTRY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_JWO_SRN_DETAIL> TSPL_JWO_SRN_DETAIL { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_JWO_SRN_RETURN> TSPL_JWO_SRN_RETURN { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER1 { get; set; }
        public virtual TSPL_JWO_UNLOADING TSPL_JWO_UNLOADING { get; set; }
        public virtual TSPL_VENDOR_MASTER TSPL_VENDOR_MASTER { get; set; }
    }
}
