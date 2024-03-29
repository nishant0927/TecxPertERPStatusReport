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
    
    public partial class TSPL_Fiscal_Year_Master
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_Fiscal_Year_Master()
        {
            this.TSPL_DCS_FINANCIAL_ENTRY = new HashSet<TSPL_DCS_FINANCIAL_ENTRY>();
            this.TSPL_EMPLOYEE_SAVINGS_MAPPING_MASTER = new HashSet<TSPL_EMPLOYEE_SAVINGS_MAPPING_MASTER>();
            this.TSPL_HR_TDS_INCOME_TAX_SLAB = new HashSet<TSPL_HR_TDS_INCOME_TAX_SLAB>();
            this.TSPL_HR_TDS_INCOME_TAX_CALCULATION_HEAD = new HashSet<TSPL_HR_TDS_INCOME_TAX_CALCULATION_HEAD>();
            this.TSPL_PAYMENT_CYCLE_GENERATED = new HashSet<TSPL_PAYMENT_CYCLE_GENERATED>();
        }
    
        public string Fiscal_Code { get; set; }
        public string Fiscal_Name { get; set; }
        public System.DateTime Start_Date { get; set; }
        public System.DateTime End_Date { get; set; }
        public string Comp_Code { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public int Is_Current_Year { get; set; }
        public int is_End_Year_Proceed { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DCS_FINANCIAL_ENTRY> TSPL_DCS_FINANCIAL_ENTRY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_EMPLOYEE_SAVINGS_MAPPING_MASTER> TSPL_EMPLOYEE_SAVINGS_MAPPING_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HR_TDS_INCOME_TAX_SLAB> TSPL_HR_TDS_INCOME_TAX_SLAB { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_HR_TDS_INCOME_TAX_CALCULATION_HEAD> TSPL_HR_TDS_INCOME_TAX_CALCULATION_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PAYMENT_CYCLE_GENERATED> TSPL_PAYMENT_CYCLE_GENERATED { get; set; }
    }
}
