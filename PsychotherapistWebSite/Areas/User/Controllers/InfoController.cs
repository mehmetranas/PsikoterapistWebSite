using PsychotherapistWebSite.Core.Models;
using PsychotherapistWebSite.Core.Repositories;
using System.Web.Mvc;

namespace PsychotherapistWebSite.Areas.User.Controllers
{
    public class InfoController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public InfoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: User/PersonalInfo
        public ActionResult Index()
        {
            var viewModel = _unitOfWork.Info.GetInfo();
            return View(viewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Info info)
        {
            if (!ModelState.IsValid) return View(info);

            _unitOfWork.Info.Add(info);
            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }

        
    }
}