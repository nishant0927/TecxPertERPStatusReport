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
    
    public partial class TSPL_MRP_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_MRP_HEAD()
        {
            this.TSPL_MRP_PO_DETAIL = new HashSet<TSPL_MRP_PO_DETAIL>();
            this.TSPL_MRP_SRN_DETAIL = new HashSet<TSPL_MRP_SRN_DETAIL>();
            this.TSPL_MRP_DETAIL = new HashSet<TSPL_MRP_DETAIL>();
        }
    
        public string MRP_CODE { get; set; }
        public string MRP_DESCRIPTION { get; set; }
        public System.DateTime MRP_DATE { get; set; }
        public System.DateTime MRP_FROM { get; set; }
        public System.DateTime MRP_TO { get; set; }
        public string Item_Code { get; set; }
        public string BOM_CODE { get; set; }
        public int MRP_DAYS { get; set; }
        public double MRP_QTY { get; set; }
        public string MRP_ITEM_UNIT_CODE { get; set; }
        public string MRP_REMARKS { get; set; }
        public string MRP_Location { get; set; }
        public double PACK_SIZE { get; set; }
        public decimal Posted { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string Comp_Code { get; set; }
        public string REQUISITION_ID { get; set; }
        public string PROD_PLAN_CODE { get; set; }
        public int Include_Stock { get; set; }
        public int Include_Pending_PO { get; set; }
        public int Include_Pending_QC { get; set; }
        public int Include_Item_Level { get; set; }
        public int Auto_Indent { get; set; }
        public int Auto_PO { get; set; }
        public string Trans_Id { get; set; }
        public Nullable<int> Consider_Open_PO { get; set; }
        public Nullable<int> Auto_Schedule_Open_PO { get; set; }
    
        public virtual TSPL_COMPANY_MASTER TSPL_COMPANY_MASTER { get; set; }
        public virtual TSPL_ITEM_MASTER TSPL_ITEM_MASTER { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_MF_BOM_HEAD TSPL_MF_BOM_HEAD { get; set; }
        public virtual TSPL_MF_PRODUCTION_PLAN_HEAD TSPL_MF_PRODUCTION_PLAN_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MRP_PO_DETAIL> TSPL_MRP_PO_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MRP_SRN_DETAIL> TSPL_MRP_SRN_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MRP_DETAIL> TSPL_MRP_DETAIL { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
        public virtual TSPL_REQUISITION_HEAD TSPL_REQUISITION_HEAD { get; set; }
    }
}
