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
    
    public partial class TSPL_INVENTORY_MOVEMENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_INVENTORY_MOVEMENT()
        {
            this.TSPL_BATCH_ITEM = new HashSet<TSPL_BATCH_ITEM>();
            this.TSPL_BATCH_ITEM_INDIRECT = new HashSet<TSPL_BATCH_ITEM_INDIRECT>();
            this.TSPL_SERIAL_ITEM = new HashSet<TSPL_SERIAL_ITEM>();
        }
    
        public int Trans_Id { get; set; }
        public string Trans_Type { get; set; }
        public string InOut { get; set; }
        public string Location_Code { get; set; }
        public string Item_Code { get; set; }
        public string Item_Desc { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public string UOM { get; set; }
        public string Source_Doc_No { get; set; }
        public string Source_Doc_Date { get; set; }
        public string Entry_Date { get; set; }
        public Nullable<decimal> Basic_Cost { get; set; }
        public Nullable<decimal> Rec_Cost { get; set; }
        public Nullable<decimal> Add_Cost { get; set; }
        public Nullable<decimal> Net_Cost { get; set; }
        public string Created_By { get; set; }
        public string Comp_Code { get; set; }
        public string ItemType { get; set; }
        public Nullable<System.DateTime> Punching_Date { get; set; }
        public decimal MRP { get; set; }
        public string Batch_No { get; set; }
        public decimal FIFO_Cost { get; set; }
        public decimal LIFO_Cost { get; set; }
        public decimal Avg_Cost { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public decimal PI_Cost { get; set; }
        public string Stock_UOM { get; set; }
        public decimal Stock_Qty { get; set; }
        public Nullable<System.DateTime> MFG_Date { get; set; }
        public Nullable<System.DateTime> Expiry_Date { get; set; }
        public string Item_Status { get; set; }
        public string Assmbly_Status { get; set; }
        public int IS_CONSUMPTION { get; set; }
        public string Cust_Code { get; set; }
        public string Cust_Name { get; set; }
        public string Vendor_Code { get; set; }
        public string Vendor_Name { get; set; }
        public string Other_Location_Code { get; set; }
        public string Other_Location_Desc { get; set; }
        public double Fat_Per { get; set; }
        public double SNF_Per { get; set; }
        public double Fat_KG { get; set; }
        public double SNF_KG { get; set; }
        public double Fat_Rate { get; set; }
        public double SNF_Rate { get; set; }
        public double Fat_Amt { get; set; }
        public double SNF_Amt { get; set; }
        public string Inventory_DrAcc { get; set; }
        public string Inventory_CrAcc { get; set; }
        public string Is_Scheme_Item { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_BATCH_ITEM> TSPL_BATCH_ITEM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_BATCH_ITEM_INDIRECT> TSPL_BATCH_ITEM_INDIRECT { get; set; }
        public virtual TSPL_CUSTOMER_MASTER TSPL_CUSTOMER_MASTER { get; set; }
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_VENDOR_MASTER TSPL_VENDOR_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_SERIAL_ITEM> TSPL_SERIAL_ITEM { get; set; }
    }
}
