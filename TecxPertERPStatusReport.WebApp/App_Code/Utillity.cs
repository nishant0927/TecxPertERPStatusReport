using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TecxPertERPStatusReport.WebApp.Models.DB;
using TecxPertERPStatusReport.WebApp.Models.ViewModel;

namespace TecxPertERPStatusReport.WebApp
{
    public class Utillity
    {
        private static readonly RCDFEntities db= new RCDFEntities();

        public static List<CattelFeedViewModel> GetCattelFeeds()
        {
            List<CattelFeedViewModel> lstCattelFeedViewModel= (from location in db.TSPL_LOCATION_MASTER
                                                               join grn in db.TSPL_GRN_HEAD on location.Location_Code equals grn.Bill_To_Location into grnGroup
                                                               join weighment in db.TSPL_PO_WEIGHTMENT_HEAD on new { LocationCode = location.Location_Code, Type = "IN" } equals new { LocationCode = weighment.Location_Code, Type = weighment.Type } into weighmentGroup
                                                               join qcchk in db.TSPL_QC_CHECK_HEAD on location.Location_Code equals qcchk.Bill_To_location into qccheckHead
                                                               join srn in db.TSPL_SRN_HEAD on location.Location_Code equals srn.Bill_To_Location into srnHead
                                                               join pi in  db.TSPL_PI_HEAD on location.Location_Code equals pi.Bill_To_Location into piHead
                                                               join rec in  db.TSPL_RECEIPT_HEADER on location.Loc_Segment_Code equals rec.Location_GL_Code into recepitHeader
                                                               join ship in db.TSPL_SD_SHIPMENT_HEAD on location.Location_Code equals ship.Bill_To_Location into shipmentHeader
                                                               join inv in  db.TSPL_SD_SALE_INVOICE_HEAD on location.Location_Code equals inv.Bill_To_Location into saleInvHead
                                                               join prod in  db.TSPL_SPP_PRODUCTION_ENTRY on location.Location_Code equals prod.LOCATION_CODE into productionEntry
                                                               where location.IsMainPlant ==0
                                                              select new CattelFeedViewModel
                                                              {                                                                  
                                                                  LocationCode = location.Location_Code,
                                                                  LocationName = location.Location_Desc,
                                                                  Location = location.Loc_Short_Name,
                                                                  LastGateInDate =grnGroup.Max(grn => grn.GRN_Date),
                                                                  LastWeighmentDate =weighmentGroup.Max(weighment => weighment.Weighment_Date),
                                                                  LastQCDate =qccheckHead.Max(qc => qc.Document_Date),
                                                                  LastSRNDate =srnHead.Max(srn => srn.SRN_Date),
                                                                  LastPurchaseInvoiceDate =piHead.Max(pi => pi.PI_Date),
                                                                  LastAdvanceReceiptDate =recepitHeader.Max(receipt => receipt.Receipt_Date),
                                                                  LastDispatchDate =shipmentHeader.Max(shipment => shipment.Document_Date),
                                                                  LastSaleBillDate =saleInvHead.Max(saleInvoice => saleInvoice.Document_Date),
                                                                  LastProductionEntryDate =productionEntry.Max(production => production.PROD_DATE)
                                                              }).ToList();
            return lstCattelFeedViewModel;
        }
    }
}