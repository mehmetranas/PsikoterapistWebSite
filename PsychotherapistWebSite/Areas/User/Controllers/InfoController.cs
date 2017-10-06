using PsychotherapistWebSite.Core.Repositories;
using PsychotherapistWebSite.Core.ViewModels;
using System.Linq;
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
            var allImages = _unitOfWork.Image.GetImages();
            var viewModel = new InfoViewModel()
            {
                Info = info,
                Adresses = adresses,
                AllImages = allImages
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(InfoViewModel viewModel)
        {
            _unitOfWork.Info.Add(viewModel.Info, viewModel.Images);
            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }


        public ActionResult Edit(int? id)
        {
            if (id == null) return HttpNotFound();

            var info = _unitOfWork.Info.GetInfo();
            var adresses = _unitOfWork.Adress.GetAdresses();
            var allImages = _unitOfWork.Image.GetImages();
            var viewModel = new InfoViewModel()
            {
                Info = info,
                Adresses = adresses,
                AllImages = allImages,
                Images = info.Images.ToArray()
                
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(InfoViewModel viewModel)
        {
            if (viewModel.Info == null) return RedirectToAction("Index");

           // _unitOfWork.Info.Put(viewModel.Info, viewModel.Image1.Id,viewModel.Image2.Id);
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