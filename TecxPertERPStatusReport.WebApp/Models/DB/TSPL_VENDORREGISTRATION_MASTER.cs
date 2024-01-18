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
    
    public partial class TSPL_VENDORREGISTRATION_MASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_VENDORREGISTRATION_MASTER()
        {
            this.TSPL_VENDOR_MASTER = new HashSet<TSPL_VENDOR_MASTER>();
        }
    
        public string Registration_No { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Name_Owners { get; set; }
        public string Organization_Type { get; set; }
        public string Sub_Contractor { get; set; }
        public string Phone_No { get; set; }
        public string Fax_No { get; set; }
        public string Turn_Over { get; set; }
        public string Contact_Person_Name { get; set; }
        public string Contact_Person_Phone_No { get; set; }
        public string Organization_Details { get; set; }
        public string Manufacturing_Facilities { get; set; }
        public string Captive_Power { get; set; }
        public string Captive_Power_Details { get; set; }
        public string Is_SeparateSection_Responsible { get; set; }
        public string WhoisAuthorised { get; set; }
        public string Is_full_doc_QS_Available { get; set; }
        public string Is_Std_drawing_Available { get; set; }
        public string Is_RM_Inspection_Available { get; set; }
        public string Is_Pro_Inspection_Available { get; set; }
        public string Is_Ins_despatch { get; set; }
        public string Is_Keep_Record { get; set; }
        public string Is_temp_perm_deviation_record { get; set; }
        public string Is_equip_calibrated_periodically { get; set; }
        public string Is_defined_QP { get; set; }
        public string Defined_QP_Details { get; set; }
        public string Is_Pro_Storage_Sys { get; set; }
        public string Is_RM_Identified { get; set; }
        public string Is_Facilities_Available { get; set; }
        public string Is_Packing_defined { get; set; }
        public string Packing_Def_Details { get; set; }
        public string NameAndAddress_Banker { get; set; }
        public string Salestax_No { get; set; }
        public string Central_Excise_No { get; set; }
        public string Payment_Terms { get; set; }
        public string Vendor_Name { get; set; }
        public byte[] Vendor_Sign { get; set; }
        public string Vendor_Desig { get; set; }
        public Nullable<System.DateTime> Vendor_Date { get; set; }
        public string Assessor_Name { get; set; }
        public byte[] Assessor_Sign { get; set; }
        public string Assessor_Desig { get; set; }
        public Nullable<System.DateTime> Assessor_Date { get; set; }
        public string Visited_By { get; set; }
        public string Suitablefor { get; set; }
        public string Suitablefor_Vendor { get; set; }
        public string Result_Approved { get; set; }
        public string Approved_Name { get; set; }
        public byte[] Approved_Sign { get; set; }
        public string Approved_Desig { get; set; }
        public Nullable<System.DateTime> Approved_Date { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public int Is_VendorRegApproved { get; set; }
    
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_VENDOR_MASTER> TSPL_VENDOR_MASTER { get; set; }
        public virtual TSPL_VENDORREGISTRATION_CUSTOMER_DETAILS TSPL_VENDORREGISTRATION_CUSTOMER_DETAILS { get; set; }
        public virtual TSPL_VENDORREGISTRATION_MACHINERY_DETAILS TSPL_VENDORREGISTRATION_MACHINERY_DETAILS { get; set; }
    }
}
