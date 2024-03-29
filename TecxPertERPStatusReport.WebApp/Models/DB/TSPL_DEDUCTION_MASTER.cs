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
    
    public partial class TSPL_DEDUCTION_MASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_DEDUCTION_MASTER()
        {
            this.TSPL_AP_INVOICE_SECONDARY_TRANSPORTER_DEDUTION_DETAIL = new HashSet<TSPL_AP_INVOICE_SECONDARY_TRANSPORTER_DEDUTION_DETAIL>();
            this.TSPL_DEDUCTION_MAPPING_DETAIL = new HashSet<TSPL_DEDUCTION_MAPPING_DETAIL>();
        }
    
        public string Code { get; set; }
        public string Description { get; set; }
        public string Ded_Grp_Code { get; set; }
        public string GL_Account_Code { get; set; }
        public int Security { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string Comp_Code { get; set; }
        public int Is_Default_Company_Deduction { get; set; }
        public int Is_Default_VSP_Deduction { get; set; }
        public int Is_Default_Transporter_Deduction { get; set; }
        public int Is_Default_Security_Deduction { get; set; }
        public int Is_Default_Asset_Installment { get; set; }
        public int Is_Default_Advance_Interest { get; set; }
        public int Is_Default_TIP { get; set; }
        public int Is_Default_VSP_Quality_Deduction { get; set; }
        public Nullable<int> Show_FAT_SNF { get; set; }
        public int Is_Default_PRO_Data { get; set; }
        public int HO_TYPE { get; set; }
        public int VLC_TYPE { get; set; }
        public int OTHERS_TYPE { get; set; }
        public int Sequence_No { get; set; }
        public int Is_Default_Asset_Lost { get; set; }
        public int Is_Default_Std_Deduction { get; set; }
        public int Is_Default_Local_Sale { get; set; }
        public int Is_Default_Pashu_Vikash_Kos { get; set; }
        public int Is_MILK { get; set; }
        public int Is_FEED { get; set; }
        public int IS_GHEE { get; set; }
        public int Is_Addition { get; set; }
        public int Is_Own_BMC_Shortage { get; set; }
        public int Is_Own_BMC_Excess { get; set; }
        public string Own_BMC_Milk_Reject_Type { get; set; }
        public int Is_Negative_SRN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_AP_INVOICE_SECONDARY_TRANSPORTER_DEDUTION_DETAIL> TSPL_AP_INVOICE_SECONDARY_TRANSPORTER_DEDUTION_DETAIL { get; set; }
        public virtual TSPL_COMPANY_MASTER TSPL_COMPANY_MASTER { get; set; }
        public virtual TSPL_DEDUCTION_GROUP TSPL_DEDUCTION_GROUP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DEDUCTION_MAPPING_DETAIL> TSPL_DEDUCTION_MAPPING_DETAIL { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS { get; set; }
        public virtual TSPL_MILK_REJECT_TYPE TSPL_MILK_REJECT_TYPE { get; set; }
    }
}
