using PsychotherapistWebSite.Core.Repositories;
using PsychotherapistWebSite.Core.ViewModels;
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
            var info = _unitOfWork.Info.GetInfo();
            var adresses = _unitOfWork.Adress.GetAdresses();
            var viewModel = new InfoViewModel
            {
                Info = info,
                Adresses = adresses
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(InfoViewModel viewModel)
        {
           // if (!ModelState.IsValid) return View(viewModel);

            _unitOfWork.Info.Add(viewModel.Info);
            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }


        public ActionResult Edit(int? id)
        {
            if (id == null) return HttpNotFound();

            var info = _unitOfWork.Info.GetInfo();
            var adresses = _unitOfWork.Adress.GetAdresses();
            var viewModel = new InfoViewModel
            {
                Info = info,
                Adresses = adresses
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(InfoViewModel viewModel)
        {
            if (viewModel.Info == null) return RedirectToAction("Index");

            _unitOfWork.Info.Put(viewModel.Info);
            _unitOfWork.Complete();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int? id)
        {
            if (id == null) return HttpNotFound();

            var viewModel = _unitOfWork.Info.GetInfo();
           
            return View(viewModel);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null) return HttpNotFound();

            var viewModel = _unitOfWork.Info.GetInfo();

            return View(viewModel);
        }

        [HttpPost, ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            if (id == null) return HttpNotFound();
            _unitOfWork.Info.Delete();
            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }
    }
}