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
    
    public partial class TSPL_INV_PARAMETERS
    {
        public string Allow_Negative_Inv { get; set; }
        public string Allow_Non_Stock { get; set; }
        public string Default_Item_Structure { get; set; }
        public string Created_By { get; set; }
        public string Create_Date { get; set; }
        public string Modify_By { get; set; }
        public string Modify_Date { get; set; }
        public string Comp_Code { get; set; }
        public int IsMRNQtyEdiatableOnSRN { get; set; }
        public int IsCreateJEForProductionEntry { get; set; }
        public int IsCreateJEForStoreAdj { get; set; }
        public int IsAutoCreateGRNAndMRN { get; set; }
        public int isSetAmountZero_InItemLocDetail { get; set; }
        public int IsCreateJEForSRN { get; set; }
        public int IsNLevelCatForItem { get; set; }
        public int IsRateBackCalculation { get; set; }
        public int IsMRPwithAbatement { get; set; }
        public int Auto_Scheme { get; set; }
        public int Allow_Change_InvoiceType { get; set; }
        public int IsBatchNo_MFD_EXD_Mandatory { get; set; }
        public int IsTermsEditableOnPurchase { get; set; }
        public int IsTermsEditableOnSales { get; set; }
        public int IsTermsEditableOnInv { get; set; }
        public int IsPriceGrpCodeOnCstMst { get; set; }
        public int IsThirdPartyLocationOnERP { get; set; }
        public int IsBOMFromProcessProduction { get; set; }
        public int Is_SRN_Mandatory { get; set; }
    }
}
