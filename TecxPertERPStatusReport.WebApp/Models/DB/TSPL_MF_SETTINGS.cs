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
    
    public partial class TSPL_MF_SETTINGS
    {
        public bool ALLOW_AUTO_CLOSE_MO_DURING_RECEIPT { get; set; }
        public decimal AUTO_CLOSE_TOLERANCE { get; set; }
        public bool ACTIVATE_MO_SERIES { get; set; }
        public bool ALLOW_6DEC_STD_UNIT_COST { get; set; }
        public bool ALLOW_RECEIVE_WITHOUT_ISSUANCE { get; set; }
        public string EXCEED_ISSUE_TOLRC { get; set; }
        public decimal ISSUE_TOLRC { get; set; }
        public string EXCEED_REC_TOLRC { get; set; }
        public decimal REC_TOLRC { get; set; }
        public string AREA_CODE { get; set; }
        public string LOCATION_CODE { get; set; }
        public string IC_COST_ITEMS_DURING { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
        public Nullable<double> Mixing_Charge { get; set; }
    
        public virtual TSPL_LOCATION_MASTER TSPL_LOCATION_MASTER { get; set; }
        public virtual TSPL_MF_PRODUCTION_AREA TSPL_MF_PRODUCTION_AREA { get; set; }
    }
}
