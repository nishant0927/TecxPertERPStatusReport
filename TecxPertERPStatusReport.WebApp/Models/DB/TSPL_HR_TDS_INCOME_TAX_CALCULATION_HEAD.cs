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
    
    public partial class TSPL_HR_TDS_INCOME_TAX_CALCULATION_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_HR_TDS_INCOME_TAX_CALCULATION_HEAD()
        {
            this.TSPL_HR_TDS_INCOME_TAX_CALCULATION_DETAIL = new HashSet<TSPL_HR_TDS_INCOME_TAX_CALCULATION_DETAIL>();
            this.TSPL_HR_TDS_INCOME_TAX_CALCULATION_EMP = new HashSet<TSPL_HR_TDS_INCOME_TAX_CALCULATION_EMP>();
            this.TSPL_HR_TDS_INCOME_TAX_CALCULATION_TAX = new HashSet<TSPL_HR_TDS_INCOME_TAX_CALCULATION_TAX>();
        }
    
        public string Code { get; set; }
        public System.DateTime Doc_Date { get; set; }
        public string Description { get; set; }
        public string Fiscal_Code { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public int Status { get; set; }
        public string Post_By { get; set; }
        public Nullable<System.DateTime> Post_Date { get; set; }
    
        public virtual TSPL_Fiscal_Year_Master TSPL_Fiscal_Year_Master { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HR_TDS_INCOME_TAX_CALCULATION_DETAIL> TSPL_HR_TDS_INCOME_TAX_CALCULATION_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HR_TDS_INCOME_TAX_CALCULATION_EMP> TSPL_HR_TDS_INCOME_TAX_CALCULATION_EMP { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER1 { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HR_TDS_INCOME_TAX_CALCULATION_TAX> TSPL_HR_TDS_INCOME_TAX_CALCULATION_TAX { get; set; }
    }
}
