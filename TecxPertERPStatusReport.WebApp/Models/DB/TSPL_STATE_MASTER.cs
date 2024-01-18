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
    
    public partial class TSPL_STATE_MASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_STATE_MASTER()
        {
            this.TSPL_CSA_DO_HEAD = new HashSet<TSPL_CSA_DO_HEAD>();
            this.TSPL_CSA_TRANSFER_HEAD = new HashSet<TSPL_CSA_TRANSFER_HEAD>();
            this.TSPL_DISTRICT_MASTER = new HashSet<TSPL_DISTRICT_MASTER>();
            this.TSPL_EMPLOYEE_MASTER = new HashSet<TSPL_EMPLOYEE_MASTER>();
            this.TSPL_EMPLOYEE_MASTER1 = new HashSet<TSPL_EMPLOYEE_MASTER>();
            this.TSPL_HR_APPLICANT_ENTRY = new HashSet<TSPL_HR_APPLICANT_ENTRY>();
            this.TSPL_HR_TRAVEL_CITY_MASTER = new HashSet<TSPL_HR_TRAVEL_CITY_MASTER>();
            this.TSPL_MCC_MASTER = new HashSet<TSPL_MCC_MASTER>();
            this.TSPL_MP_MASTER = new HashSet<TSPL_MP_MASTER>();
            this.TSPL_PT_RULE_MASTER = new HashSet<TSPL_PT_RULE_MASTER>();
            this.TSPL_PURCHASE_ORDER_HEAD = new HashSet<TSPL_PURCHASE_ORDER_HEAD>();
            this.TSPL_CSA_PRICE_STATE_DETAIL = new HashSet<TSPL_CSA_PRICE_STATE_DETAIL>();
            this.Tspl_Trainer_Master = new HashSet<Tspl_Trainer_Master>();
        }
    
        public string STATE_CODE { get; set; }
        public string STATE_NAME { get; set; }
        public string COUNTRY_CODE { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public int Is_WayBill_Reqd { get; set; }
        public int Is_GST_UT { get; set; }
        public string GST_STATE_Code { get; set; }
        public bool IsDefault { get; set; }
    
        public virtual TSPL_COUNTRY_MASTER TSPL_COUNTRY_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CSA_DO_HEAD> TSPL_CSA_DO_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CSA_TRANSFER_HEAD> TSPL_CSA_TRANSFER_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DISTRICT_MASTER> TSPL_DISTRICT_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EMPLOYEE_MASTER> TSPL_EMPLOYEE_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EMPLOYEE_MASTER> TSPL_EMPLOYEE_MASTER1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HR_APPLICANT_ENTRY> TSPL_HR_APPLICANT_ENTRY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HR_TRAVEL_CITY_MASTER> TSPL_HR_TRAVEL_CITY_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MCC_MASTER> TSPL_MCC_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MP_MASTER> TSPL_MP_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PT_RULE_MASTER> TSPL_PT_RULE_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PURCHASE_ORDER_HEAD> TSPL_PURCHASE_ORDER_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CSA_PRICE_STATE_DETAIL> TSPL_CSA_PRICE_STATE_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tspl_Trainer_Master> Tspl_Trainer_Master { get; set; }
    }
}
