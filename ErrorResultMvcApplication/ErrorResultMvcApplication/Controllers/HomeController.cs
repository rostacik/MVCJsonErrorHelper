using System.Web.Mvc;
using MvcHelpers.Extensions;

namespace ErrorResultMvcApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RequestTest(int? id)
        {
            if (id != null)
            {
                return Json(new { responseText = "you entered : " + id });
            }
            else
            {
                return this.JsonError(new { responseText = "error orrucured, sry" });
            }
        }
    }
}