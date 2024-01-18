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
    
    public partial class TSPL_CITY_MASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_CITY_MASTER()
        {
            this.TSPL_DEMAND_BOOKING_MASTER = new HashSet<TSPL_DEMAND_BOOKING_MASTER>();
            this.TSPL_EMPLOYEE_MASTER = new HashSet<TSPL_EMPLOYEE_MASTER>();
            this.TSPL_EMPLOYEE_MASTER1 = new HashSet<TSPL_EMPLOYEE_MASTER>();
            this.TSPL_EMPLOYEE_MASTER2 = new HashSet<TSPL_EMPLOYEE_MASTER>();
            this.TSPL_HR_APPLICANT_ENTRY = new HashSet<TSPL_HR_APPLICANT_ENTRY>();
            this.TSPL_HR_TRAVEL_CITY_MASTER = new HashSet<TSPL_HR_TRAVEL_CITY_MASTER>();
            this.TSPL_MCC_MASTER = new HashSet<TSPL_MCC_MASTER>();
            this.TSPL_MP_MASTER = new HashSet<TSPL_MP_MASTER>();
            this.TSPL_ROUTE_FREIGHT_DETAILS = new HashSet<TSPL_ROUTE_FREIGHT_DETAILS>();
            this.Tspl_Trainer_Master = new HashSet<Tspl_Trainer_Master>();
            this.Tspl_Trainer_Master_City = new HashSet<Tspl_Trainer_Master_City>();
            this.TSPL_ZONE_MASTER = new HashSet<TSPL_ZONE_MASTER>();
        }
    
        public string City_Code { get; set; }
        public string City_Name { get; set; }
        public string Created_By { get; set; }
        public string Modify_By { get; set; }
        public string Comp_Code { get; set; }
        public string STATE_CODE { get; set; }
        public string region_code { get; set; }
        public string DISTRICT_Code { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public Nullable<System.DateTime> Modify_Date { get; set; }
        public bool IsDefault { get; set; }
    
        public virtual TSPL_DISTRICT_MASTER TSPL_DISTRICT_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DEMAND_BOOKING_MASTER> TSPL_DEMAND_BOOKING_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EMPLOYEE_MASTER> TSPL_EMPLOYEE_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EMPLOYEE_MASTER> TSPL_EMPLOYEE_MASTER1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EMPLOYEE_MASTER> TSPL_EMPLOYEE_MASTER2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HR_APPLICANT_ENTRY> TSPL_HR_APPLICANT_ENTRY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HR_TRAVEL_CITY_MASTER> TSPL_HR_TRAVEL_CITY_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MCC_MASTER> TSPL_MCC_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MP_MASTER> TSPL_MP_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ROUTE_FREIGHT_DETAILS> TSPL_ROUTE_FREIGHT_DETAILS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tspl_Trainer_Master> Tspl_Trainer_Master { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tspl_Trainer_Master_City> Tspl_Trainer_Master_City { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ZONE_MASTER> TSPL_ZONE_MASTER { get; set; }
    }
}
