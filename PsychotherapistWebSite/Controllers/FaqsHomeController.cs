using System.Web.Mvc;
using PsychotherapistWebSite.Core.Repositories;
using PsychotherapistWebSite.Core.ViewModels;

namespace PsychotherapistWebSite.Controllers
{
    public class FaqsHomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public FaqsHomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Faqs
        public ActionResult Index()
        {
            var faqs = _unitOfWork.Faq.GetFaqs();
            var viewModel = new FaqsHomeViewModel(faqs);
            return View(viewModel);
        }
    }
}