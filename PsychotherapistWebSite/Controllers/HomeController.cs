using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using PsychotherapistWebSite.Core.Repositories;
using PsychotherapistWebSite.Core.ViewModels;

namespace PsychotherapistWebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: Home
        public ActionResult Index()
        {
            var services = _unitOfWork.Service.GetServices().Take(3).Select(Mapper.Map<ServiceViewModel>).ToArray();
            var slides = _unitOfWork.Slide.GetSlides();
            var welcomeText = _unitOfWork.WelcomeText.GetWelcomeText();
            var viewModel = new HomeViewModel()
            {
                Services = services,
                Slides =  slides,
                WelcomeText = welcomeText
            };
            return View(viewModel);
        }
    }
}