using PsychotherapistWebSite.Core.Repositories;
using System.Linq;
using System.Web.Mvc;

namespace PsychotherapistWebSite.Areas.User.Controllers
{
    public class HomeFaqController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomeFaqController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: User/HomeSSS
        public ActionResult Index()
        {
            var faqs = _unitOfWork.Faq.GetFaqs().OrderBy(faq => faq.IsDisplayOnHomePage == false);
            return View(faqs);
        }
    }
}