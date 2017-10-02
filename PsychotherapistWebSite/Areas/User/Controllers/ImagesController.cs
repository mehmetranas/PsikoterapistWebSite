using PsychotherapistWebSite.Core.Models;
using PsychotherapistWebSite.Core.Repositories;
using PsychotherapistWebSite.Core.ViewModels;
using System;
using System.IO;
using System.Net;
using System.Web.Mvc;

namespace PsychotherapistWebSite.Areas.User.Controllers
{
    public class ImagesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ImagesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: User/Images
        public ActionResult Index()
        {
            return View(_unitOfWork.Image.GetImages());
        }

      // GET: User/Images/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Images/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ImageViewModel viewModel)
        {
            if (!ModelState.IsValid) return View(viewModel);

            if (viewModel.File == null) return RedirectToAction("Index");

            var extension = Path.GetExtension(viewModel.File.FileName);
            var guidNumber = Guid.NewGuid().ToString();
            var fileName = guidNumber + extension;
            viewModel.File.SaveAs(HttpContext.Server.MapPath("~/Images/Slide/")
                                  +fileName);
            viewModel.Image.Url = fileName;
            _unitOfWork.Image.Add(viewModel.Image);
            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }

        // GET: User/Images/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Image image = _unitOfWork.Image.GetImage(id);
            if (image == null)
            {
                return HttpNotFound();
            }
            return View(image);
        }

        // POST: User/Images/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _unitOfWork.Image.Delete(id);
            _unitOfWork.Complete();
            
            return RedirectToAction("Index");
        }

        // GET: User/Images/Detail/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var image = _unitOfWork.Image.GetImage(id);
            if (image == null)
            {
                return HttpNotFound();
            }
            return View(image);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
