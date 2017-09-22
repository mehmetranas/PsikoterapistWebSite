using PsychotherapistWebSite.Core.Repositories;
using PsychotherapistWebSite.Models;
using System.Web.Mvc;

namespace PsychotherapistWebSite.Areas.User.Controllers
{
    public class MottoController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public MottoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: User/Motto
        public ActionResult Index()
        {
            var mottoes = _unitOfWork.Motto.GetMottoes();
            return View(mottoes);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Motto motto)
        {
            if (!ModelState.IsValid)
                return View("Create", motto);

            if (motto != null)
            {
                _unitOfWork.Motto.Add(motto);
                _unitOfWork.Complete();
            }

            return RedirectToAction("Index");
        }
    }
}