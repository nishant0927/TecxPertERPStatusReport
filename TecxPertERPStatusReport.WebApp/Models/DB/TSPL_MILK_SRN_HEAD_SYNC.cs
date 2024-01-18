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
    
    public partial class TSPL_MILK_SRN_HEAD_SYNC
    {
        public string DOC_CODE { get; set; }
        public string MCC_CODE { get; set; }
        public System.DateTime DOC_DATE { get; set; }
        public string SHIFT { get; set; }
        public string COMM_PORT { get; set; }
        public string VLC_DOC_CODE { get; set; }
        public string MILK_SAMPLE_CODE { get; set; }
        public int SAMPLE_NO { get; set; }
        public string VLC_CODE { get; set; }
        public string ROUTE_CODE { get; set; }
        public string VSP_CODE { get; set; }
        public string VEHICLE_CODE { get; set; }
        public string Transporter { get; set; }
        public decimal Posted { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public string Comp_Code { get; set; }
        public string Is_Incentive_Created { get; set; }
        public string Against_Reject_No { get; set; }
        public string Dock_Collection_Milk_Type { get; set; }
        public Nullable<int> SYNC_STATUS { get; set; }
        public Nullable<int> Failed_Sample_Status { get; set; }
        public string Failed_Sample_Approve_By { get; set; }
        public Nullable<System.DateTime> Failed_Sample_Approve_Date { get; set; }
        public string Purchase_Order_No { get; set; }
        public Nullable<int> Capping_Apply { get; set; }
        public Nullable<int> Retesting { get; set; }
    
        public virtual TSPL_COMPANY_MASTER TSPL_COMPANY_MASTER { get; set; }
        public virtual TSPL_MCC_MASTER TSPL_MCC_MASTER { get; set; }
        public virtual TSPL_MILK_REJECT_HEAD TSPL_MILK_REJECT_HEAD { get; set; }
        public virtual TSPL_VENDOR_MASTER TSPL_VENDOR_MASTER { get; set; }
        public virtual TSPL_VLC_MASTER_HEAD TSPL_VLC_MASTER_HEAD { get; set; }
        public virtual TSPL_VENDOR_MASTER TSPL_VENDOR_MASTER1 { get; set; }
    }
}