using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TecxPertERPStatusReport.WebApp.Models.ViewModel
{
    public class CattelFeedViewModel
    {
        public string LocationCode {  get; set; }
        public string LocationName {  get; set; }
        public string Location { get; set; }
        public DateTime? LastGateInDate { get; set; }
        public DateTime? LastWeighmentDate {  get; set; }
        public DateTime? LastQCDate {  get; set; }
        public DateTime? LastSRNDate {  get; set; }
        public DateTime? LastPurchaseInvoiceDate {  get; set; }
        public DateTime? LastAdvanceReceiptDate {  get; set; }
        public DateTime? LastProductionEntryDate {  get; set; }
        public DateTime? LastDispatchDate {  get; set; }
        public DateTime? LastSaleBillDate {  get; set; }
        public List<CattelFeedViewModel> lstCattelFeedViewModel { get; set; }
    }
}