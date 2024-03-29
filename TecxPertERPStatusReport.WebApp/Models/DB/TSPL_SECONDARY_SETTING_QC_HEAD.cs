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
    
    public partial class TSPL_SECONDARY_SETTING_QC_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_SECONDARY_SETTING_QC_HEAD()
        {
            this.TSPL_SECONDARY_SETTING_QC_DETAIL = new HashSet<TSPL_SECONDARY_SETTING_QC_DETAIL>();
        }
    
        public string Document_No { get; set; }
        public System.DateTime Document_Date { get; set; }
        public string QC_No { get; set; }
        public string Tanker_No { get; set; }
        public System.DateTime QC_In_Date_Time { get; set; }
        public System.DateTime QC_Out_Date_Time { get; set; }
        public string Gate_Entry_No { get; set; }
        public System.DateTime Gate_Entry_Date_And_Time { get; set; }
        public string Challan_No { get; set; }
        public System.DateTime Challan_Date { get; set; }
        public double Dip_Value { get; set; }
        public double DeductionAmount { get; set; }
        public string Weighment_No { get; set; }
        public System.DateTime Weighment_Date { get; set; }
        public string location_Code { get; set; }
        public string Location_Desc { get; set; }
        public string Vendor_Code { get; set; }
        public string Vendor_Desc { get; set; }
        public double Receipt_Control_FAT { get; set; }
        public double Receipt_Control_SNF { get; set; }
        public double Dispatch_Control_FAT { get; set; }
        public double Dispatch_Control_SNF { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modify_By { get; set; }
        public string Modify_Date { get; set; }
        public string comp_code { get; set; }
        public int Posted { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
    
        public virtual TSPL_QUALITY_CHECK TSPL_QUALITY_CHECK { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SECONDARY_SETTING_QC_DETAIL> TSPL_SECONDARY_SETTING_QC_DETAIL { get; set; }
    }
}
