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
    
    public partial class TSPL_ACCOUNT_MAIN_GL_ACCOUNT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_ACCOUNT_MAIN_GL_ACCOUNT()
        {
            this.TSPL_BALANCE_SHEET_PERFORMA_GL_MAIN = new HashSet<TSPL_BALANCE_SHEET_PERFORMA_GL_MAIN>();
            this.TSPL_BALANCE_SHEET_PERFORMA_FORMULA_GL_MAIN = new HashSet<TSPL_BALANCE_SHEET_PERFORMA_FORMULA_GL_MAIN>();
            this.TSPL_CASH_FLOW_PERFORMA_GL_MAIN = new HashSet<TSPL_CASH_FLOW_PERFORMA_GL_MAIN>();
            this.TSPL_GL_ACCOUNTS = new HashSet<TSPL_GL_ACCOUNTS>();
            this.TSPL_PROFIT_AND_LOSS_PERFORMA_GL_MAIN = new HashSet<TSPL_PROFIT_AND_LOSS_PERFORMA_GL_MAIN>();
        }
    
        public string Main_GL_Account { get; set; }
        public string Main_GL_Account_Desc { get; set; }
        public string Sub_Group_Code { get; set; }
        public string Comp_Code { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modify_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public int IsControlAcct { get; set; }
    
        public virtual TSPL_ACCOUNT_SUB_GROUPS TSPL_ACCOUNT_SUB_GROUPS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_BALANCE_SHEET_PERFORMA_GL_MAIN> TSPL_BALANCE_SHEET_PERFORMA_GL_MAIN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_BALANCE_SHEET_PERFORMA_FORMULA_GL_MAIN> TSPL_BALANCE_SHEET_PERFORMA_FORMULA_GL_MAIN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_CASH_FLOW_PERFORMA_GL_MAIN> TSPL_CASH_FLOW_PERFORMA_GL_MAIN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_GL_ACCOUNTS> TSPL_GL_ACCOUNTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_PROFIT_AND_LOSS_PERFORMA_GL_MAIN> TSPL_PROFIT_AND_LOSS_PERFORMA_GL_MAIN { get; set; }
    }
}
