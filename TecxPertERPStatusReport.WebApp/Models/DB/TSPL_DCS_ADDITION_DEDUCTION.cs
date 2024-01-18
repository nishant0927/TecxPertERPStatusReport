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
    
    public partial class TSPL_DCS_ADDITION_DEDUCTION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_DCS_ADDITION_DEDUCTION()
        {
            this.TSPL_MILK_PURCHASE_INVOICE_DCS_ADD_DED = new HashSet<TSPL_MILK_PURCHASE_INVOICE_DCS_ADD_DED>();
            this.TSPL_VENDOR_INVOICE_DETAIL = new HashSet<TSPL_VENDOR_INVOICE_DETAIL>();
        }
    
        public string Code { get; set; }
        public string Description { get; set; }
        public System.DateTime Start_Date { get; set; }
        public Nullable<System.DateTime> End_Date { get; set; }
        public string End_Date_Created_By { get; set; }
        public Nullable<System.DateTime> End_Date_Created_Date { get; set; }
        public Nullable<int> Inactive { get; set; }
        public string Inactive_By { get; set; }
        public Nullable<System.DateTime> Inactive_Date { get; set; }
        public Nullable<int> Saving { get; set; }
        public Nullable<int> SNo { get; set; }
        public Nullable<int> Applicable_DCS_Type { get; set; }
        public Nullable<int> Nature_Type { get; set; }
        public Nullable<int> Applicable_On { get; set; }
        public Nullable<int> Applicable_Type { get; set; }
        public decimal Applicable_Value { get; set; }
        public string GL_Account { get; set; }
        public int Posted { get; set; }
        public string Posted_By { get; set; }
        public Nullable<System.DateTime> Posted_Date { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string MappingCode { get; set; }
        public string Mapping_Matching { get; set; }
        public int RO_Decimal_Places { get; set; }
        public int RO_Increase_After { get; set; }
        public int Qty_UOM { get; set; }
        public string Milk_Type { get; set; }
        public Nullable<int> Apply_TDS { get; set; }
        public Nullable<int> Include_Shortage_Own_BMC { get; set; }
        public Nullable<int> Subtract { get; set; }
        public Nullable<int> Check_Saving_AC { get; set; }
    
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MILK_PURCHASE_INVOICE_DCS_ADD_DED> TSPL_MILK_PURCHASE_INVOICE_DCS_ADD_DED { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_VENDOR_INVOICE_DETAIL> TSPL_VENDOR_INVOICE_DETAIL { get; set; }
    }
}
