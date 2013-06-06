using System.Web.Mvc;

namespace MsBuild.Controllers
{
    public class FileDownloadController : Controller
    {
        //
        // GET: /FileDownload/

        public ActionResult Index()
        {
            return new FilePathResult("~/App_Data/Test.xlsx", "application/txt") { FileDownloadName = "Test.xlsx" };
        }

    }
}
