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
    
    public partial class TSPL_RCDF_STD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_RCDF_STD()
        {
            this.TSPL_RCDF_STD_PRODUCE = new HashSet<TSPL_RCDF_STD_PRODUCE>();
            this.TSPL_RCDF_STD_ISSUE = new HashSet<TSPL_RCDF_STD_ISSUE>();
            this.TSPL_RCDF_STD_ADD_REMOVE = new HashSet<TSPL_RCDF_STD_ADD_REMOVE>();
        }
    
        public string Doc_Code { get; set; }
        public System.DateTime Doc_Date { get; set; }
        public string Location_Code { get; set; }
        public string Batch_No { get; set; }
        public string Comment { get; set; }
        public string Remarks { get; set; }
        public Nullable<decimal> Tot_Produce_Qty { get; set; }
        public Nullable<decimal> Tot_Produce_FATKG { get; set; }
        public Nullable<decimal> Tot_Produce_SNFKG { get; set; }
        public Nullable<decimal> Tot_Issue_Qty { get; set; }
        public Nullable<decimal> Tot_Issue_FATKG { get; set; }
        public Nullable<decimal> Tot_Issue_SNFKG { get; set; }
        public Nullable<decimal> Tot_Difference_Qty { get; set; }
        public Nullable<decimal> Tot_Difference_FATKG { get; set; }
        public Nullable<decimal> Tot_Difference_SNFKG { get; set; }
        public Nullable<decimal> Tot_Added_Qty { get; set; }
        public Nullable<decimal> Tot_Added_FATKG { get; set; }
        public Nullable<decimal> Tot_Added_SNFKG { get; set; }
        public Nullable<decimal> Tot_Removed_Qty { get; set; }
        public Nullable<decimal> Tot_Removed_FATKG { get; set; }
        public Nullable<decimal> Tot_Removed_SNFKG { get; set; }
        public Nullable<decimal> Tot_AddRemove_Qty { get; set; }
        public Nullable<decimal> Tot_AddRemove_FATKG { get; set; }
        public Nullable<decimal> Tot_AddRemove_SNFKG { get; set; }
        public Nullable<decimal> Tot_Net_Qty { get; set; }
        public Nullable<decimal> Tot_Net_FATKG { get; set; }
        public Nullable<decimal> Tot_Net_SNFKG { get; set; }
        public Nullable<int> Status { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string Posted_By { get; set; }
        public Nullable<System.DateTime> Posted_Date { get; set; }
    
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_RCDF_STD_PRODUCE> TSPL_RCDF_STD_PRODUCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_RCDF_STD_ISSUE> TSPL_RCDF_STD_ISSUE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_RCDF_STD_ADD_REMOVE> TSPL_RCDF_STD_ADD_REMOVE { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER1 { get; set; }
        public virtual TSPL_USER_MASTER TSPL_USER_MASTER2 { get; set; }
    }
}
