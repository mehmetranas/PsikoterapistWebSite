using System.Web.Mvc;

namespace PsychotherapistWebSite.Areas.User.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
    }
}