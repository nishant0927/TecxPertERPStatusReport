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
    
    public partial class TSPL_RGP_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_RGP_HEAD()
        {
            this.TSPL_GRN_HEAD = new HashSet<TSPL_GRN_HEAD>();
            this.TSPL_MRN_HEAD = new HashSet<TSPL_MRN_HEAD>();
            this.TSPL_PURCHASE_ORDER_HEAD = new HashSet<TSPL_PURCHASE_ORDER_HEAD>();
            this.TSPL_GRN_DETAIL = new HashSet<TSPL_GRN_DETAIL>();
            this.TSPL_GRN_RGP_CONVERSION_DETAIL = new HashSet<TSPL_GRN_RGP_CONVERSION_DETAIL>();
            this.TSPL_RGP_JOB_WORK_DETAIL = new HashSet<TSPL_RGP_JOB_WORK_DETAIL>();
            this.TSPL_RGP_DETAIL = new HashSet<TSPL_RGP_DETAIL>();
            this.TSPL_SRN_HEAD1 = new HashSet<TSPL_SRN_HEAD>();
            this.TSPL_SRN_DETAIL = new HashSet<TSPL_SRN_DETAIL>();
        }
    
        public string RGP_No { get; set; }
        public System.DateTime RGP_Date { get; set; }
        public string Doc_Type { get; set; }
        public string Vendor_Code { get; set; }
        public string Vendor_Name { get; set; }
        public string VehicleNo { get; set; }
        public string GPNo { get; set; }
        public Nullable<System.DateTime> GPDate { get; set; }
        public string Reason { get; set; }
        public string Remarks { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modify_By { get; set; }
        public string Modify_Date { get; set; }
        public int Status { get; set; }
        public int On_Hold { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string comp_code { get; set; }
        public Nullable<decimal> Document_Amount { get; set; }
        public string Location { get; set; }
        public string Delivered_By { get; set; }
        public string Department { get; set; }
        public string Billing { get; set; }
        public Nullable<int> Against_Sale { get; set; }
        public Nullable<int> Is_Non_Inventory { get; set; }
        public string Mode_Of_Transport { get; set; }
        public string CostCentre { get; set; }
        public string CostCentreDesc { get; set; }
        public string Cash_Memo_Detail { get; set; }
        public Nullable<int> Against_Customer { get; set; }
        public string IsThirdParty { get; set; }
        public string SRN_Location_Code { get; set; }
        public string InvoiceNo { get; set; }
        public string PartyName { get; set; }
        public string PartyAddress { get; set; }
        public Nullable<System.DateTime> DispatchDate { get; set; }
        public int Against_JobWork { get; set; }
        public string Against_NRGP { get; set; }
        public int Is_Rejected { get; set; }
        public string SRN_No { get; set; }
        public string Item_Conversion_Type { get; set; }
        public string PO_Id { get; set; }
        public string Against_Schedule_Code { get; set; }
        public string GRNo { get; set; }
        public Nullable<System.DateTime> GR_Date { get; set; }
        public string Road_Permit_No { get; set; }
        public Nullable<System.DateTime> RoadPermit_Date { get; set; }
        public int Against_BOM { get; set; }
        public int Against_As_It_Is { get; set; }
        public int JVDisplayType { get; set; }
        public string Against_RGP { get; set; }
        public string AMC_Ref_No { get; set; }
        public string Man_Po_No { get; set; }
        public Nullable<System.DateTime> Man_PO_Date { get; set; }
        public Nullable<int> Is_Repair { get; set; }
        public Nullable<int> Is_Against_CC_Transfer { get; set; }
        public string To_Location_Code { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_GRN_HEAD> TSPL_GRN_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MRN_HEAD> TSPL_MRN_HEAD { get; set; }
        public virtual TSPL_PO_SCH_HEAD TSPL_PO_SCH_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PURCHASE_ORDER_HEAD> TSPL_PURCHASE_ORDER_HEAD { get; set; }
        public virtual TSPL_PURCHASE_ORDER_HEAD TSPL_PURCHASE_ORDER_HEAD1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_GRN_DETAIL> TSPL_GRN_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_GRN_RGP_CONVERSION_DETAIL> TSPL_GRN_RGP_CONVERSION_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_RGP_JOB_WORK_DETAIL> TSPL_RGP_JOB_WORK_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_RGP_DETAIL> TSPL_RGP_DETAIL { get; set; }
        public virtual TSPL_SRN_HEAD TSPL_SRN_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SRN_HEAD> TSPL_SRN_HEAD1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SRN_DETAIL> TSPL_SRN_DETAIL { get; set; }
    }
}
