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
    
    public partial class TSPL_Dep_AccountSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_Dep_AccountSet()
        {
            this.TSPL_ASSET_CATEGORY = new HashSet<TSPL_ASSET_CATEGORY>();
            this.TSPL_ACQUISITION_DETAIL = new HashSet<TSPL_ACQUISITION_DETAIL>();
            this.TSPL_ASSET_ACCOUNT_CHANGE_DETAIL = new HashSet<TSPL_ASSET_ACCOUNT_CHANGE_DETAIL>();
            this.TSPL_FA_TEMPLATE_MASTER = new HashSet<TSPL_FA_TEMPLATE_MASTER>();
        }
    
        public string AcSet_Code { get; set; }
        public string AcSet_Desc { get; set; }
        public string Inactive { get; set; }
        public string Ac_Control { get; set; }
        public string Ac_Control_YearDisposal { get; set; }
        public string Ac_Control_YearAdj { get; set; }
        public string Ac_WIP { get; set; }
        public string Ac_Accum_Dep { get; set; }
        public string Ac_Accum_Dep_YearDisposal { get; set; }
        public string Ac_Accum_Dep_YearAdj { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string Comp_Code { get; set; }
        public string Ac_Dep_Account { get; set; }
        public string Disposal_Account { get; set; }
        public string Disposal_Proceed_Account { get; set; }
        public string Transfer_Clearing_Account { get; set; }
        public string Disposal_Cost_Account { get; set; }
        public string WIP_AC { get; set; }
        public string PROFIT_AC { get; set; }
        public string LOSS_AC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ASSET_CATEGORY> TSPL_ASSET_CATEGORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ACQUISITION_DETAIL> TSPL_ACQUISITION_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ASSET_ACCOUNT_CHANGE_DETAIL> TSPL_ASSET_ACCOUNT_CHANGE_DETAIL { get; set; }
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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_FA_TEMPLATE_MASTER> TSPL_FA_TEMPLATE_MASTER { get; set; }
    }
}
