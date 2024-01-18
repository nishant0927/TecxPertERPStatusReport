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
    
    public partial class TSPL_VENDOR_ACCOUNT_SET
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_VENDOR_ACCOUNT_SET()
        {
            this.TSPL_MP_MASTER = new HashSet<TSPL_MP_MASTER>();
        }
    
        public string Acct_Set_Code { get; set; }
        public string Acct_Set_Desc { get; set; }
        public string Payable_Account { get; set; }
        public string Discount_Account { get; set; }
        public string Advance_Account { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modify_By { get; set; }
        public string Modify_Date { get; set; }
        public string Comp_Code { get; set; }
        public string CURRENCY_CODE { get; set; }
        public string EXCHANGE_LOSS_ACCOUNT { get; set; }
        public string EXCHANGE_GAIN_ACCOUNT { get; set; }
        public string Commission_ACCOUNT { get; set; }
        public string Incentive_ACCOUNT { get; set; }
        public string SECURITY_ACCOUNT { get; set; }
        public string Head_Load_ACCOUNT { get; set; }
        public string Own_Asset_ACCOUNT { get; set; }
        public string Deduction_ACCOUNT { get; set; }
        public string Advance_Against_Salary { get; set; }
        public string Employee_Salary { get; set; }
        public string Advance_Against_Travelling { get; set; }
        public string Advance_Against_Imprest { get; set; }
        public string Freight_Provision { get; set; }
        public string Handling_Charges { get; set; }
        public string Round_Off { get; set; }
        public string Short_Excess { get; set; }
        public string Opening_Clearing { get; set; }
        public string Security_Opening_Clearing { get; set; }
        public string Monthly_Rent_Account { get; set; }
        public string Profit_Loss_Account { get; set; }
        public string PRO_DATA_ACCOUNT { get; set; }
        public int IsFarmer { get; set; }
        public string Arrear_Account { get; set; }
        public string RETENTION_ACCOUNT { get; set; }
    
        public virtual TSPL_CURRENCY_MASTER TSPL_CURRENCY_MASTER { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS1 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS2 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS3 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS4 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS5 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS6 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS7 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS8 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS9 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS10 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS11 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS12 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS13 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS14 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS15 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS16 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS17 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS18 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS19 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS20 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS21 { get; set; }
        public virtual TSPL_GL_ACCOUNTS TSPL_GL_ACCOUNTS22 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_MP_MASTER> TSPL_MP_MASTER { get; set; }
    }
}
