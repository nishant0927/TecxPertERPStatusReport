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
    
    public partial class TSPL_MILK_Shift_End_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_MILK_Shift_End_HEAD()
        {
            this.TSPL_MILK_Shift_End_DETAIL = new HashSet<TSPL_MILK_Shift_End_DETAIL>();
            this.TSPL_MILK_Shift_End_Route_DETAIL = new HashSet<TSPL_MILK_Shift_End_Route_DETAIL>();
        }
    
        public string DOC_CODE { get; set; }
        public string MCC_CODE { get; set; }
        public System.DateTime DOC_DATE { get; set; }
        public string SHIFT { get; set; }
        public decimal Posted { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string Comp_Code { get; set; }
        public System.DateTime MCC_DATE { get; set; }
        public decimal Actual_Stock { get; set; }
        public decimal Actual_FAT { get; set; }
        public decimal Actual_SNF { get; set; }
        public decimal Manual_Stock { get; set; }
        public decimal Manual_FAT { get; set; }
        public decimal Manual_SNF { get; set; }
        public decimal Actual_FAT_Per { get; set; }
        public decimal Actual_SNF_Per { get; set; }
        public decimal Manual_FAT_Per { get; set; }
        public decimal Manual_SNF_Per { get; set; }
        public decimal Provision_Amount { get; set; }
        public Nullable<int> SYNC_STATUS { get; set; }
        public decimal CLR { get; set; }
        public Nullable<int> Is_Flushing_Created { get; set; }
        public string AutoIn_Location { get; set; }
        public string SILOIn_Location { get; set; }
        public Nullable<int> AskSiloatShiftEnd { get; set; }
        public Nullable<int> Mix_Milk { get; set; }
    
        public virtual TSPL_COMPANY_MASTER TSPL_COMPANY_MASTER { get; set; }
        public virtual TSPL_MCC_MASTER TSPL_MCC_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_Shift_End_DETAIL> TSPL_MILK_Shift_End_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_Shift_End_Route_DETAIL> TSPL_MILK_Shift_End_Route_DETAIL { get; set; }
    }
}
