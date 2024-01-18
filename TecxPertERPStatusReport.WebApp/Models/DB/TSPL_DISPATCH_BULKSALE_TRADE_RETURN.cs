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
    
    public partial class TSPL_DISPATCH_BULKSALE_TRADE_RETURN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_DISPATCH_BULKSALE_TRADE_RETURN()
        {
            this.TSPL_DISPATCH_DETAIL_BULKSALE_TRADE_RETURN = new HashSet<TSPL_DISPATCH_DETAIL_BULKSALE_TRADE_RETURN>();
        }
    
        public string Document_No { get; set; }
        public System.DateTime Document_Date { get; set; }
        public string Against_SRN_No_Return { get; set; }
        public string Against_SRN_No { get; set; }
        public string DispatchTrade_No { get; set; }
        public string Customer_Code { get; set; }
        public string Location_Code { get; set; }
        public string Price_Code { get; set; }
        public string Tanker_No { get; set; }
        public decimal Total_Amt { get; set; }
        public int Is_Create_Auto_Invoice { get; set; }
        public int Posted { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string Comp_Code { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string EWayBillNo { get; set; }
        public Nullable<System.DateTime> EWayBillDate { get; set; }
    
        public virtual TSPL_BulkSalePrice_MASTER TSPL_BulkSalePrice_MASTER { get; set; }
        public virtual TSPL_CUSTOMER_MASTER TSPL_CUSTOMER_MASTER { get; set; }
        public virtual TSPL_Dispatch_BulkSale_Trade TSPL_Dispatch_BulkSale_Trade { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DISPATCH_DETAIL_BULKSALE_TRADE_RETURN> TSPL_DISPATCH_DETAIL_BULKSALE_TRADE_RETURN { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
    }
}
