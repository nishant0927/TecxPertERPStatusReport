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
    
    public partial class TSPL_ACCOUNT_GROUPS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_ACCOUNT_GROUPS()
        {
            this.TSPL_ACCOUNT_SUB_GROUPS = new HashSet<TSPL_ACCOUNT_SUB_GROUPS>();
        }
    
        public string Account_Group_Code { get; set; }
        public string Account_Group_Desc { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modify_By { get; set; }
        public string Modify_Date { get; set; }
        public string Comp_Code { get; set; }
        public int Print_Order { get; set; }
        public string GROUP_TYPE { get; set; }
        public string Account_Main_Group_Code { get; set; }
    
        public virtual TSPL_ACCOUNT_MAIN_GROUPS TSPL_ACCOUNT_MAIN_GROUPS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_ACCOUNT_SUB_GROUPS> TSPL_ACCOUNT_SUB_GROUPS { get; set; }
    }
}