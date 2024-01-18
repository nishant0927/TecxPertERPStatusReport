using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TecxPertERPStatusReport.WebApp;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using iTextSharp.text.html.simpleparser;
namespace TecxPertERPStatusReport.WebApp.Controllers
{
    public class StatusReportController : Controller
    {
        // GET: StatusReport
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetCattelFeeds()
        {
            return Json(Utillity.GetCattelFeeds(), JsonRequestBehavior.AllowGet);
        }
        public FileResult GeneratePDF(string htmlContent)
        {

            using (MemoryStream stream = new System.IO.MemoryStream())
            {
                StringReader sr = new StringReader(htmlContent);
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                pdfDoc.Close();
                byte[] k= stream.ToArray();
                return File(stream.ToArray(), "application/pdf", "Grid.pdf");
            }
        }

    }
}