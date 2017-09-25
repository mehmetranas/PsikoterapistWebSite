using PsychotherapistWebSite.Core.Repositories;
using PsychotherapistWebSite.Core.ViewModels;
using PsychotherapistWebSite.Models;
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

        public ActionResult Create()
        {
            var mottoes = _unitOfWork.Motto.GetMottoes();
            var images = _unitOfWork.Image.GetImages();

            var viewModel = new SlideViewModel()
            {
                Slide = null,
                Mottoes = mottoes,
                Images = images
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SlideViewModel viewModel)
        {
            var slide = viewModel.Slide;
            _unitOfWork.Slide.Add(slide);
            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var slide = _unitOfWork.Slide.GetSlide(id);
            var mottoes = _unitOfWork.Motto.GetMottoes();
            var images = _unitOfWork.Image.GetImages();

            var viewModel = new SlideViewModel()
            {
                Slide = slide,
                Mottoes = mottoes,
                Images = images
            };

            if (slide == null) return HttpNotFound();
                                                                                                                                                                   return View(viewModel);
        }

        [HttpPost, ValidateAntiForgeryToken]
        [ActionName("Edit")]
        public ActionResult EditSlide(SlideViewModel slideViewModel)
        {
            var slideDb = _unitOfWork.Slide.GetSlide(slideViewModel.Slide.Id);
            if (slideDb == null) return HttpNotFound();
            slideDb.ImageId = slideViewModel.Slide.ImageId;
            slideDb.MottoId = slideViewModel.Slide.MottoId;
            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var slide = _unitOfWork.Slide.GetSlide(id);
             if(slide == null) return HttpNotFound();

            return View(slide);
        }

        [HttpPost, ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            _unitOfWork.Slide.Delete(id);
            _unitOfWork.Complete();
            return RedirectToAction("Index");
        }
    }
}