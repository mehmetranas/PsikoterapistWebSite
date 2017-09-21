using PsychotherapistWebSite.Core.Repositories;
using System.Web.Mvc;

namespace PsychotherapistWebSite.Areas.User.Controllers
{
    public class SlideController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public SlideController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: User/Slide
        public ActionResult Index()
        {
            var viewModel = _unitOfWork.Slide.GetSlides();
            return View(viewModel);
        }
    }
}