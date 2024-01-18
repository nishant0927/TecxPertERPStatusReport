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
    
    public partial class TSPL_MP_MASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_MP_MASTER()
        {
            this.TSPL_ANDROID_MCC_SALE_REQUEST = new HashSet<TSPL_ANDROID_MCC_SALE_REQUEST>();
            this.TSPL_ANDROID_MP_SALE = new HashSet<TSPL_ANDROID_MP_SALE>();
            this.TSPL_ANDROID_SERVICE_REQUEST = new HashSet<TSPL_ANDROID_SERVICE_REQUEST>();
            this.TSPL_CUSTOMER_INVOICE_HEAD_FARMER = new HashSet<TSPL_CUSTOMER_INVOICE_HEAD_FARMER>();
            this.TSPL_MCC_SALE_FARMER_HEAD = new HashSet<TSPL_MCC_SALE_FARMER_HEAD>();
            this.TSPL_MP_INCENTIVE = new HashSet<TSPL_MP_INCENTIVE>();
            this.TSPL_MP_INCENTIVE_ENTRY_DETAIL = new HashSet<TSPL_MP_INCENTIVE_ENTRY_DETAIL>();
            this.tspl_Animal_Details = new HashSet<tspl_Animal_Details>();
            this.tspl_Buffaloes_Details = new HashSet<tspl_Buffaloes_Details>();
            this.tspl_Cow_Details = new HashSet<tspl_Cow_Details>();
            this.TSPL_MP_PAY_HEAD = new HashSet<TSPL_MP_PAY_HEAD>();
            this.TSPL_MP_PAY_PROCESS_DETAIL = new HashSet<TSPL_MP_PAY_PROCESS_DETAIL>();
            this.TSPL_MP_PAY_ADJ_HEAD = new HashSet<TSPL_MP_PAY_ADJ_HEAD>();
            this.TSPL_PAYMENT_PROCESS_ADJ_DETAIL = new HashSet<TSPL_PAYMENT_PROCESS_ADJ_DETAIL>();
            this.TSPL_PAYMENT_PROCESS_FARMER_MP_ADVANCE = new HashSet<TSPL_PAYMENT_PROCESS_FARMER_MP_ADVANCE>();
            this.TSPL_PAYMENT_HEADER = new HashSet<TSPL_PAYMENT_HEADER>();
            this.TSPL_USER_MASTER = new HashSet<TSPL_USER_MASTER>();
            this.TSPL_VENDOR_MASTER = new HashSet<TSPL_VENDOR_MASTER>();
            this.TSPL_VLC_DATA_UPLOADER_DETAIL = new HashSet<TSPL_VLC_DATA_UPLOADER_DETAIL>();
            this.TSPL_VLC_DATA_UPLOADER_DETAIL_SYNC = new HashSet<TSPL_VLC_DATA_UPLOADER_DETAIL_SYNC>();
            this.TSPL_Vlc_Target_Detail = new HashSet<TSPL_Vlc_Target_Detail>();
            this.TSPL_VLC_UPLOADER_MASTER = new HashSet<TSPL_VLC_UPLOADER_MASTER>();
        }
    
        public string MP_Code { get; set; }
        public string MP_Name { get; set; }
        public string VLC_Code { get; set; }
        public string Village_Code { get; set; }
        public string Father_Name { get; set; }
        public string Add1 { get; set; }
        public string Add2 { get; set; }
        public string Zila { get; set; }
        public string Tehsil { get; set; }
        public string City_code { get; set; }
        public string State_Code { get; set; }
        public string Country_code { get; set; }
        public string Pin_code { get; set; }
        public string Telphone { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Education { get; set; }
        public double Land_Holding { get; set; }
        public Nullable<int> No_Of_Buffaloes { get; set; }
        public Nullable<int> No_Of_Cows { get; set; }
        public Nullable<int> No_Of_breedable_milk_animal { get; set; }
        public Nullable<double> Milk_production { get; set; }
        public Nullable<double> Milk_Home_consumption { get; set; }
        public Nullable<double> Milk_For_sale { get; set; }
        public string PayeeName { get; set; }
        public string BankName { get; set; }
        public string BankBranch { get; set; }
        public string BankCityCode { get; set; }
        public string BankStateCode { get; set; }
        public string IFCICode { get; set; }
        public string AccountNO { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string Comp_Code { get; set; }
        public string MP_Code_VLC_Uploader { get; set; }
        public Nullable<int> No_Of_Animal { get; set; }
        public Nullable<int> No_Of_Children_member { get; set; }
        public Nullable<int> No_Of_Adult_member { get; set; }
        public Nullable<int> No_Of_Total_Dependent_member { get; set; }
        public string Account_Type { get; set; }
        public int Is_VSP { get; set; }
        public int Active { get; set; }
        public string Type_Of_Former { get; set; }
        public string Gender { get; set; }
        public string Marital_Status { get; set; }
        public byte[] MP_Picture { get; set; }
        public Nullable<double> Milk_Avalb_Lean_Season { get; set; }
        public Nullable<double> Milk_Avalb_flush_Season { get; set; }
        public int MP_Farmer_Billing { get; set; }
        public string Cust_Account { get; set; }
        public string Acct_Set_Code { get; set; }
        public Nullable<bool> Farmer_Payment_Applied { get; set; }
        public string Jan_Aadhar_No { get; set; }
        public Nullable<decimal> TOLERANCE { get; set; }
        public string Incentive_Account { get; set; }
        public string MP_Name_Hindi { get; set; }
        public string CAST_CATEGORY_CODE { get; set; }
        public string DISTRICT_Code { get; set; }
        public string Zone_Code { get; set; }
        public string BLOCK_CODE { get; set; }
        public string REVENUE_VILLAGE_CODE { get; set; }
        public string GRAMPANCHAYAT_CODE { get; set; }
        public string PANCHAYAT_SAMITI_CODE { get; set; }
        public string VIDHAN_SABHA_CODE { get; set; }
        public Nullable<int> Jan_Aadhar_No_Verified { get; set; }
        public string JA_enrId { get; set; }
        public string JA_janaadhaarId { get; set; }
        public string JA_nameEng { get; set; }
        public string JA_nameHnd { get; set; }
        public string JA_gender { get; set; }
        public string JA_fnameEng { get; set; }
        public string JA_fnameHnd { get; set; }
        public string JA_mnameEng { get; set; }
        public string JA_mnameHnd { get; set; }
        public string JA_snameEng { get; set; }
        public string JA_snameHnd { get; set; }
        public string JA_dob { get; set; }
        public string JA_age { get; set; }
        public string JA_maritalStatus { get; set; }
        public string JA_jan_mid { get; set; }
        public string JA_aadhar { get; set; }
        public string JA_eid { get; set; }
        public string JA_mobile { get; set; }
        public string JA_acc { get; set; }
        public string JA_bankName { get; set; }
        public string JA_ifsc { get; set; }
        public string JA_bankBranch { get; set; }
        public string JA_micr { get; set; }
        public string JA_voterId { get; set; }
        public string JA_panNo { get; set; }
        public string JA_passport { get; set; }
        public string JA_dlNo { get; set; }
        public string JA_email { get; set; }
        public string JA_qualification { get; set; }
        public string JA_relationTyp { get; set; }
        public string JA_disability { get; set; }
        public string JA_income { get; set; }
        public string JA_occupation { get; set; }
        public string JA_isorphan { get; set; }
        public string JA_isStateGovtEmp { get; set; }
        public string JA_rghs_no { get; set; }
        public string JA_disabilityPercentage { get; set; }
        public string JA_disabilityType { get; set; }
        public string JA_categoryDescEng { get; set; }
        public string JA_caste { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ANDROID_MCC_SALE_REQUEST> TSPL_ANDROID_MCC_SALE_REQUEST { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ANDROID_MP_SALE> TSPL_ANDROID_MP_SALE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ANDROID_SERVICE_REQUEST> TSPL_ANDROID_SERVICE_REQUEST { get; set; }
        public virtual TSPL_BLOCK_MASTER TSPL_BLOCK_MASTER { get; set; }
        public virtual TSPL_CAST_CATEGORY_MASTER TSPL_CAST_CATEGORY_MASTER { get; set; }
        public virtual TSPL_CITY_MASTER TSPL_CITY_MASTER { get; set; }
        public virtual TSPL_CUSTOMER_ACCOUNT_SET TSPL_CUSTOMER_ACCOUNT_SET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CUSTOMER_INVOICE_HEAD_FARMER> TSPL_CUSTOMER_INVOICE_HEAD_FARMER { get; set; }
        public virtual TSPL_DISTRICT_MASTER TSPL_DISTRICT_MASTER { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS { get; set; }
        public virtual TSPL_GRAMPANCHAYAT_MASTER TSPL_GRAMPANCHAYAT_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MCC_SALE_FARMER_HEAD> TSPL_MCC_SALE_FARMER_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MP_INCENTIVE> TSPL_MP_INCENTIVE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MP_INCENTIVE_ENTRY_DETAIL> TSPL_MP_INCENTIVE_ENTRY_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tspl_Animal_Details> tspl_Animal_Details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tspl_Buffaloes_Details> tspl_Buffaloes_Details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tspl_Cow_Details> tspl_Cow_Details { get; set; }
        public virtual TSPL_VENDOR_ACCOUNT_SET TSPL_VENDOR_ACCOUNT_SET { get; set; }
        public virtual TSPL_PANCHAYAT_SAMITI_MASTER TSPL_PANCHAYAT_SAMITI_MASTER { get; set; }
        public virtual TSPL_REVENUE_VILLAGE_MASTER TSPL_REVENUE_VILLAGE_MASTER { get; set; }
        public virtual TSPL_STATE_MASTER TSPL_STATE_MASTER { get; set; }
        public virtual TSPL_VIDHAN_SABHA_MASTER TSPL_VIDHAN_SABHA_MASTER { get; set; }
        public virtual TSPL_VLC_MASTER_HEAD TSPL_VLC_MASTER_HEAD { get; set; }
        public virtual TSPL_ZONE_MASTER TSPL_ZONE_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MP_PAY_HEAD> TSPL_MP_PAY_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MP_PAY_PROCESS_DETAIL> TSPL_MP_PAY_PROCESS_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MP_PAY_ADJ_HEAD> TSPL_MP_PAY_ADJ_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PAYMENT_PROCESS_ADJ_DETAIL> TSPL_PAYMENT_PROCESS_ADJ_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PAYMENT_PROCESS_FARMER_MP_ADVANCE> TSPL_PAYMENT_PROCESS_FARMER_MP_ADVANCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PAYMENT_HEADER> TSPL_PAYMENT_HEADER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_USER_MASTER> TSPL_USER_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_VENDOR_MASTER> TSPL_VENDOR_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_VLC_DATA_UPLOADER_DETAIL> TSPL_VLC_DATA_UPLOADER_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_VLC_DATA_UPLOADER_DETAIL_SYNC> TSPL_VLC_DATA_UPLOADER_DETAIL_SYNC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_Vlc_Target_Detail> TSPL_Vlc_Target_Detail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_VLC_UPLOADER_MASTER> TSPL_VLC_UPLOADER_MASTER { get; set; }
    }
}