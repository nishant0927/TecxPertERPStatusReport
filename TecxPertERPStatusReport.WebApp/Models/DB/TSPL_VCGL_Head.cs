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
    
    public partial class TSPL_VCGL_Head
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_VCGL_Head()
        {
            this.TSPL_VCGL_Detail = new HashSet<TSPL_VCGL_Detail>();
        }
    
        public string Document_No { get; set; }
        public System.DateTime Document_Date { get; set; }
        public string Document_Type { get; set; }
        public string Location_Segment { get; set; }
        public string VC_Code { get; set; }
        public string VC_Name { get; set; }
        public string Remarks { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public Nullable<decimal> Tot_Dr_Amount { get; set; }
        public Nullable<decimal> Tot_Cr_Amount { get; set; }
        public string Amount_Type { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public int On_Hold { get; set; }
        public int Status { get; set; }
        public string GL_Account_Code { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modify_By { get; set; }
        public System.DateTime Modify_Date { get; set; }
        public string Comp_Code { get; set; }
        public string Description { get; set; }
        public int Is_Empty { get; set; }
        public Nullable<System.DateTime> DateAndTime { get; set; }
        public string TapalNo { get; set; }
        public string FarmerInVendor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_VCGL_Detail> TSPL_VCGL_Detail { get; set; }
    }
}
