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
    
    public partial class TSPL_BULK_MILK_PURCHASE_RETURN_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_BULK_MILK_PURCHASE_RETURN_HEAD()
        {
            this.TSPL_BULK_MILK_PURCHASE_RETURN_DETAIL = new HashSet<TSPL_BULK_MILK_PURCHASE_RETURN_DETAIL>();
        }
    
        public string Pur_Return_No { get; set; }
        public System.DateTime Pur_Return_Date { get; set; }
        public string Invoice_No { get; set; }
        public System.DateTime Invoice_Date { get; set; }
        public string vendor_code { get; set; }
        public string loc_code { get; set; }
        public Nullable<System.DateTime> SRN_From_Date { get; set; }
        public Nullable<System.DateTime> SRN_TO_Date { get; set; }
        public double Total_FAT_KG { get; set; }
        public double Total_SNF_KG { get; set; }
        public double Total_QTY { get; set; }
        public double Total_AMT { get; set; }
        public int isPosted { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modified_By { get; set; }
        public string Modified_Date { get; set; }
        public string Comp_Code { get; set; }
        public string Vendor_Invoice_No { get; set; }
        public decimal RoundOffAmount { get; set; }
        public int isSRNTradeInvoice { get; set; }
        public int Is_Update_Vendor_AfterPost { get; set; }
        public Nullable<int> IsAgainstJobWork { get; set; }
        public string Joblocation_Code { get; set; }
    
        public virtual tspl_Bulk_milk_purchase_Invoice_head tspl_Bulk_milk_purchase_Invoice_head { get; set; }
        public virtual TSPL_COMPANY_MASTER TSPL_COMPANY_MASTER { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_BULK_MILK_PURCHASE_RETURN_DETAIL> TSPL_BULK_MILK_PURCHASE_RETURN_DETAIL { get; set; }
        public virtual TSPL_VENDOR_MASTER TSPL_VENDOR_MASTER { get; set; }
    }
}