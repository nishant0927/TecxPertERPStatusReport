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
    
    public partial class TSPL_VLC_MASTER_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_VLC_MASTER_HEAD()
        {
            this.TSPL_ANDROID_MCC_SALE_REQUEST = new HashSet<TSPL_ANDROID_MCC_SALE_REQUEST>();
            this.TSPL_ANDROID_MP_SALE = new HashSet<TSPL_ANDROID_MP_SALE>();
            this.TSPL_ANDROID_SERVICE_REQUEST = new HashSet<TSPL_ANDROID_SERVICE_REQUEST>();
            this.TSPL_DCS_FINANCIAL_ENTRY = new HashSet<TSPL_DCS_FINANCIAL_ENTRY>();
            this.TSPL_DCS_MP_INCENTIVE_RECO_DETAIL = new HashSet<TSPL_DCS_MP_INCENTIVE_RECO_DETAIL>();
            this.TSPL_DCS_MP_INCENTIVE_RECO_DETAIL_INVALID = new HashSet<TSPL_DCS_MP_INCENTIVE_RECO_DETAIL_INVALID>();
            this.TSPL_FAT_SNF_UPLOADER_VLC = new HashSet<TSPL_FAT_SNF_UPLOADER_VLC>();
            this.TSPL_HEAD_LOAD_DCS = new HashSet<TSPL_HEAD_LOAD_DCS>();
            this.TSPL_MILK_COLLECTION_BMCDCS_DCS = new HashSet<TSPL_MILK_COLLECTION_BMCDCS_DCS>();
            this.TSPL_MILK_COLLECTION_DCS_DETAIL = new HashSet<TSPL_MILK_COLLECTION_DCS_DETAIL>();
            this.TSPL_MILK_COLLECTION_DCS_DETAIL_SERVICE = new HashSet<TSPL_MILK_COLLECTION_DCS_DETAIL_SERVICE>();
            this.TSPL_MILK_COLLECTION_DCS_MULTIPLE_DAYS_DETAIL = new HashSet<TSPL_MILK_COLLECTION_DCS_MULTIPLE_DAYS_DETAIL>();
            this.TSPL_MILK_PROCUREMENT_UPLOADER_DETAIL = new HashSet<TSPL_MILK_PROCUREMENT_UPLOADER_DETAIL>();
            this.TSPL_MILK_PROCUREMENT_UPLOADER_DETAIL_SYNC = new HashSet<TSPL_MILK_PROCUREMENT_UPLOADER_DETAIL_SYNC>();
            this.TSPL_MILK_RECEIPT_DETAIL = new HashSet<TSPL_MILK_RECEIPT_DETAIL>();
            this.TSPL_MILK_RECEIPT_DETAIL_SYNC = new HashSet<TSPL_MILK_RECEIPT_DETAIL_SYNC>();
            this.TSPL_MILK_REJECT_DETAIL = new HashSet<TSPL_MILK_REJECT_DETAIL>();
            this.TSPL_MILK_Shift_End_DETAIL = new HashSet<TSPL_MILK_Shift_End_DETAIL>();
            this.TSPL_MILK_SHIFT_END_DETAIL_SYNC = new HashSet<TSPL_MILK_SHIFT_END_DETAIL_SYNC>();
            this.TSPL_MILK_SHIFT_UPLOADER_DETAIL = new HashSet<TSPL_MILK_SHIFT_UPLOADER_DETAIL>();
            this.TSPL_MILK_SHIFT_UPLOADER_DETAIL_SYNC = new HashSet<TSPL_MILK_SHIFT_UPLOADER_DETAIL_SYNC>();
            this.TSPL_MILK_SRN_HEAD = new HashSet<TSPL_MILK_SRN_HEAD>();
            this.TSPL_MILK_SRN_HEAD_SYNC = new HashSet<TSPL_MILK_SRN_HEAD_SYNC>();
            this.Tspl_Milk_Truck_Sheet_Detail = new HashSet<Tspl_Milk_Truck_Sheet_Detail>();
            this.TSPL_MILK_TRUCK_SHEET_DETAIL_SYNC = new HashSet<TSPL_MILK_TRUCK_SHEET_DETAIL_SYNC>();
            this.TSPL_MP_INCENTIVE_ENTRY_DETAIL = new HashSet<TSPL_MP_INCENTIVE_ENTRY_DETAIL>();
            this.TSPL_MP_INCENTIVE_ENTRY_VLC_STATUS = new HashSet<TSPL_MP_INCENTIVE_ENTRY_VLC_STATUS>();
            this.TSPL_MP_MASTER = new HashSet<TSPL_MP_MASTER>();
            this.TSPL_VLC_DATA_UPLOADER_MASTER = new HashSet<TSPL_VLC_DATA_UPLOADER_MASTER>();
            this.TSPL_VLC_DATA_UPLOADER_MASTER_SYNC = new HashSet<TSPL_VLC_DATA_UPLOADER_MASTER_SYNC>();
            this.TSPL_ANDROID_TRUCK_SHEET = new HashSet<TSPL_ANDROID_TRUCK_SHEET>();
            this.TSPL_MCC_ROUTE_VLC_MAPPING = new HashSet<TSPL_MCC_ROUTE_VLC_MAPPING>();
            this.TSPL_MCC_ROUTE_VLC_MAPPING_ESD = new HashSet<TSPL_MCC_ROUTE_VLC_MAPPING_ESD>();
            this.TSPL_PRICE_CHART_PLANNING_VLC = new HashSet<TSPL_PRICE_CHART_PLANNING_VLC>();
            this.TSPL_VLC_ROUTE_SHIFT_MASTER = new HashSet<TSPL_VLC_ROUTE_SHIFT_MASTER>();
            this.TSPL_Vlc_Target_Detail = new HashSet<TSPL_Vlc_Target_Detail>();
            this.TSPL_VLC_SUPERVISOR_TAGGING = new HashSet<TSPL_VLC_SUPERVISOR_TAGGING>();
            this.TSPL_DEDUCTION_MAPPING_HEAD = new HashSet<TSPL_DEDUCTION_MAPPING_HEAD>();
            this.TSPL_MP_INCETIVE = new HashSet<TSPL_MP_INCETIVE>();
        }
    
        public string VLC_Code { get; set; }
        public string VLC_Name { get; set; }
        public string Vehical_Name { get; set; }
        public string VSP_Code { get; set; }
        public string MCC { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modified_By { get; set; }
        public string Modified_Date { get; set; }
        public string Village_Code { get; set; }
        public string Route_Code { get; set; }
        public string VLC_Code_VLC_Uploader { get; set; }
        public string comp_code { get; set; }
        public int Active { get; set; }
        public string Price_Code { get; set; }
        public string Milk_Receive_UOM { get; set; }
        public Nullable<int> Apply_Price_Chart_Uploader { get; set; }
        public string Short_Description { get; set; }
        public string VLC_Name_Hindi { get; set; }
        public Nullable<int> Auto_Fill_MP_Order { get; set; }
        public Nullable<int> Apply_Cow_Price { get; set; }
        public int IsSuspense { get; set; }
        public string Registered_PDCS_CLUSTER { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public int isOwnBMC { get; set; }
        public string MCCOwnBMC { get; set; }
        public string BankCode2 { get; set; }
        public string BankName2 { get; set; }
        public decimal Credit2 { get; set; }
        public string IFSCCode2 { get; set; }
        public string AccNo2 { get; set; }
        public string AccountType2 { get; set; }
        public string BankBranch2 { get; set; }
        public string SecurityCharges2 { get; set; }
        public string SupervisorOrRP { get; set; }
        public Nullable<System.DateTime> ApplyCowPriceDate { get; set; }
        public Nullable<decimal> Loyalty_Rate { get; set; }
        public Nullable<System.DateTime> OwnBMCDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ANDROID_MCC_SALE_REQUEST> TSPL_ANDROID_MCC_SALE_REQUEST { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ANDROID_MP_SALE> TSPL_ANDROID_MP_SALE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ANDROID_SERVICE_REQUEST> TSPL_ANDROID_SERVICE_REQUEST { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DCS_FINANCIAL_ENTRY> TSPL_DCS_FINANCIAL_ENTRY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DCS_MP_INCENTIVE_RECO_DETAIL> TSPL_DCS_MP_INCENTIVE_RECO_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DCS_MP_INCENTIVE_RECO_DETAIL_INVALID> TSPL_DCS_MP_INCENTIVE_RECO_DETAIL_INVALID { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_FAT_SNF_UPLOADER_VLC> TSPL_FAT_SNF_UPLOADER_VLC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HEAD_LOAD_DCS> TSPL_HEAD_LOAD_DCS { get; set; }
        public virtual TSPL_MCC_MASTER TSPL_MCC_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_COLLECTION_BMCDCS_DCS> TSPL_MILK_COLLECTION_BMCDCS_DCS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_COLLECTION_DCS_DETAIL> TSPL_MILK_COLLECTION_DCS_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_COLLECTION_DCS_DETAIL_SERVICE> TSPL_MILK_COLLECTION_DCS_DETAIL_SERVICE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_COLLECTION_DCS_MULTIPLE_DAYS_DETAIL> TSPL_MILK_COLLECTION_DCS_MULTIPLE_DAYS_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_PROCUREMENT_UPLOADER_DETAIL> TSPL_MILK_PROCUREMENT_UPLOADER_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_PROCUREMENT_UPLOADER_DETAIL_SYNC> TSPL_MILK_PROCUREMENT_UPLOADER_DETAIL_SYNC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_RECEIPT_DETAIL> TSPL_MILK_RECEIPT_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_RECEIPT_DETAIL_SYNC> TSPL_MILK_RECEIPT_DETAIL_SYNC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_REJECT_DETAIL> TSPL_MILK_REJECT_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_Shift_End_DETAIL> TSPL_MILK_Shift_End_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_SHIFT_END_DETAIL_SYNC> TSPL_MILK_SHIFT_END_DETAIL_SYNC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_SHIFT_UPLOADER_DETAIL> TSPL_MILK_SHIFT_UPLOADER_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_SHIFT_UPLOADER_DETAIL_SYNC> TSPL_MILK_SHIFT_UPLOADER_DETAIL_SYNC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_SRN_HEAD> TSPL_MILK_SRN_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_SRN_HEAD_SYNC> TSPL_MILK_SRN_HEAD_SYNC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tspl_Milk_Truck_Sheet_Detail> Tspl_Milk_Truck_Sheet_Detail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_TRUCK_SHEET_DETAIL_SYNC> TSPL_MILK_TRUCK_SHEET_DETAIL_SYNC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MP_INCENTIVE_ENTRY_DETAIL> TSPL_MP_INCENTIVE_ENTRY_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MP_INCENTIVE_ENTRY_VLC_STATUS> TSPL_MP_INCENTIVE_ENTRY_VLC_STATUS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MP_MASTER> TSPL_MP_MASTER { get; set; }
        public virtual TSPL_UNIT_MASTER TSPL_UNIT_MASTER { get; set; }
        public virtual TSPL_VENDOR_MASTER TSPL_VENDOR_MASTER { get; set; }
        public virtual TSPL_VENDOR_MASTER TSPL_VENDOR_MASTER1 { get; set; }
        public virtual TSPL_VENDOR_MASTER TSPL_VENDOR_MASTER2 { get; set; }
        public virtual TSPL_VILLAGE_MASTER TSPL_VILLAGE_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_VLC_DATA_UPLOADER_MASTER> TSPL_VLC_DATA_UPLOADER_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_VLC_DATA_UPLOADER_MASTER_SYNC> TSPL_VLC_DATA_UPLOADER_MASTER_SYNC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ANDROID_TRUCK_SHEET> TSPL_ANDROID_TRUCK_SHEET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MCC_ROUTE_VLC_MAPPING> TSPL_MCC_ROUTE_VLC_MAPPING { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MCC_ROUTE_VLC_MAPPING_ESD> TSPL_MCC_ROUTE_VLC_MAPPING_ESD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PRICE_CHART_PLANNING_VLC> TSPL_PRICE_CHART_PLANNING_VLC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_VLC_ROUTE_SHIFT_MASTER> TSPL_VLC_ROUTE_SHIFT_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_Vlc_Target_Detail> TSPL_Vlc_Target_Detail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_VLC_SUPERVISOR_TAGGING> TSPL_VLC_SUPERVISOR_TAGGING { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DEDUCTION_MAPPING_HEAD> TSPL_DEDUCTION_MAPPING_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MP_INCETIVE> TSPL_MP_INCETIVE { get; set; }
    }
}
