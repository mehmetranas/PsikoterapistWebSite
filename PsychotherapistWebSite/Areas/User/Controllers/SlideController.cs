using PsychotherapistWebSite.Core.Repositories;
using System.Web.Mvc;
using PsychotherapistWebSite.Core.ViewModels;

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

        public ActionResult Create()
        {
            var mottoes = _unitOfWork.Motto.GetMottoes();

            var viewModel = new SlideViewModel()
            {
                Slide = null,
                Mottoes = mottoes
            };

            return View(viewModel);
        }
    }
}