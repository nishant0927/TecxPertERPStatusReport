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
    
    public partial class TSPL_REQUISITION_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_REQUISITION_HEAD()
        {
            this.TSPL_GRN_HEAD = new HashSet<TSPL_GRN_HEAD>();
            this.TSPL_Mcc_Milk_Transport_Invoice_HEAD = new HashSet<TSPL_Mcc_Milk_Transport_Invoice_HEAD>();
            this.TSPL_MRN_HEAD = new HashSet<TSPL_MRN_HEAD>();
            this.TSPL_MRP_HEAD = new HashSet<TSPL_MRP_HEAD>();
            this.TSPL_PI_HEAD = new HashSet<TSPL_PI_HEAD>();
            this.TSPL_PR_HEAD = new HashSet<TSPL_PR_HEAD>();
            this.TSPL_PURCHASE_ORDER_HEAD = new HashSet<TSPL_PURCHASE_ORDER_HEAD>();
            this.TSPL_GRN_DETAIL = new HashSet<TSPL_GRN_DETAIL>();
            this.TSPL_GRN_DETAIL_HISTORY = new HashSet<TSPL_GRN_DETAIL_HISTORY>();
            this.TSPL_MRN_DETAIL = new HashSet<TSPL_MRN_DETAIL>();
            this.TSPL_MRN_DETAIL_HISTORY = new HashSet<TSPL_MRN_DETAIL_HISTORY>();
            this.TSPL_MRP_DETAIL = new HashSet<TSPL_MRP_DETAIL>();
            this.TSPL_PURCHASE_ORDER_DETAIL = new HashSet<TSPL_PURCHASE_ORDER_DETAIL>();
            this.TSPL_REQUISITION_DETAIL = new HashSet<TSPL_REQUISITION_DETAIL>();
            this.TSPL_RFQ_HEAD = new HashSet<TSPL_RFQ_HEAD>();
            this.TSPL_RM_DEMAND_APPROVAL_INDENT = new HashSet<TSPL_RM_DEMAND_APPROVAL_INDENT>();
            this.TSPL_SRN_HEAD = new HashSet<TSPL_SRN_HEAD>();
            this.TSPL_SRN_DETAIL = new HashSet<TSPL_SRN_DETAIL>();
            this.TSPL_TRANSFER_ORDER_HEAD = new HashSet<TSPL_TRANSFER_ORDER_HEAD>();
            this.TSPL_VENDOR_QUOTATION_HEAD = new HashSet<TSPL_VENDOR_QUOTATION_HEAD>();
        }
    
        public string Requisition_Id { get; set; }
        public System.DateTime Requisition_Date { get; set; }
        public string Cust_OrderNo { get; set; }
        public string Expire_Date { get; set; }
        public string Require_Date { get; set; }
        public int Status { get; set; }
        public int On_Hold { get; set; }
        public int Manual_Complete { get; set; }
        public string Ref_No { get; set; }
        public string Description { get; set; }
        public string Remarks { get; set; }
        public string Location { get; set; }
        public Nullable<decimal> RQ_Detail_Total_Amt { get; set; }
        public Nullable<decimal> Total_RQ_Amt { get; set; }
        public string Mode_Of_Transport { get; set; }
        public string Comments { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modify_By { get; set; }
        public string Modify_Date { get; set; }
        public string Comp_Code { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string Dept { get; set; }
        public string Dept_Desc { get; set; }
        public string Item_Type { get; set; }
        public string Request_By { get; set; }
        public string Is_Internal { get; set; }
        public string Requisition_Type { get; set; }
        public int Level1_Approval_Status { get; set; }
        public string Level1_Approval_By { get; set; }
        public Nullable<System.DateTime> Level1_Approval_On { get; set; }
        public int Level2_Approval_Status { get; set; }
        public string Level2_Approval_By { get; set; }
        public Nullable<System.DateTime> Level2_Approval_On { get; set; }
        public int Level3_Approval_Status { get; set; }
        public string Level3_Approval_By { get; set; }
        public Nullable<System.DateTime> Level3_Approval_On { get; set; }
        public int Level4_Approval_Status { get; set; }
        public string Level4_Approval_By { get; set; }
        public Nullable<System.DateTime> Level4_Approval_On { get; set; }
        public int Level5_Approval_Status { get; set; }
        public string Level5_Approval_By { get; set; }
        public Nullable<System.DateTime> Level5_Approval_On { get; set; }
        public Nullable<int> Is_Approved { get; set; }
        public int Approvel_Level_Required { get; set; }
        public int CatalogueType { get; set; }
        public string Vendor_Code { get; set; }
        public string SubRequest { get; set; }
        public int Request_Type { get; set; }
        public string PROJECT_ID { get; set; }
        public string close_yn { get; set; }
        public string Category { get; set; }
        public string Capex_Code { get; set; }
        public string Capex_SubCode { get; set; }
        public string Capacity { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Emergency { get; set; }
        public string Cost_Center_Unit { get; set; }
        public string Cost_Center_Type { get; set; }
        public decimal SubCapex_Amount { get; set; }
        public decimal SubCapex_AmountWithTol { get; set; }
        public decimal SubCapex_BalAmount { get; set; }
        public decimal SubCapex_BalAmountWithTol { get; set; }
        public string Is_Tender { get; set; }
        public string EMailID { get; set; }
        public string From_Screen_Code { get; set; }
        public string WO_To { get; set; }
        public string WO_Subject { get; set; }
        public string WO_Content { get; set; }
        public string WO_CopySubmittedTo { get; set; }
    
        public virtual TSPL_CAPEX_BUDGET_MASTER TSPL_CAPEX_BUDGET_MASTER { get; set; }
        public virtual TSPL_CAPEX_MASTER TSPL_CAPEX_MASTER { get; set; }
        public virtual TSPL_COST_CENTER_TYPE_MASTER TSPL_COST_CENTER_TYPE_MASTER { get; set; }
        public virtual TSPL_COST_CENTER_UNIT_MASTER TSPL_COST_CENTER_UNIT_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_GRN_HEAD> TSPL_GRN_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_Mcc_Milk_Transport_Invoice_HEAD> TSPL_Mcc_Milk_Transport_Invoice_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MRN_HEAD> TSPL_MRN_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MRP_HEAD> TSPL_MRP_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PI_HEAD> TSPL_PI_HEAD { get; set; }
        public virtual TSPL_PJC_PROJECT TSPL_PJC_PROJECT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PR_HEAD> TSPL_PR_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PURCHASE_ORDER_HEAD> TSPL_PURCHASE_ORDER_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_GRN_DETAIL> TSPL_GRN_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_GRN_DETAIL_HISTORY> TSPL_GRN_DETAIL_HISTORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MRN_DETAIL> TSPL_MRN_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MRN_DETAIL_HISTORY> TSPL_MRN_DETAIL_HISTORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MRP_DETAIL> TSPL_MRP_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PURCHASE_ORDER_DETAIL> TSPL_PURCHASE_ORDER_DETAIL { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER1 { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER2 { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER3 { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_REQUISITION_DETAIL> TSPL_REQUISITION_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_RFQ_HEAD> TSPL_RFQ_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_RM_DEMAND_APPROVAL_INDENT> TSPL_RM_DEMAND_APPROVAL_INDENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SRN_HEAD> TSPL_SRN_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SRN_DETAIL> TSPL_SRN_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_TRANSFER_ORDER_HEAD> TSPL_TRANSFER_ORDER_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_VENDOR_QUOTATION_HEAD> TSPL_VENDOR_QUOTATION_HEAD { get; set; }
    }
}
