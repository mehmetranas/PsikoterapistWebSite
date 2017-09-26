using PsychotherapistWebSite.Core.Repositories;
using PsychotherapistWebSite.Models;
using System.Net;
using System.Web.Mvc;
using AutoMapper;
using PsychotherapistWebSite.Core.Models;

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

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Motto motto = _unitOfWork.Motto.GetMotto(id);
            if (motto == null)
            {
                return HttpNotFound();
            }
            return View(motto);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult EditSave(Motto motto)
        {
            //should operate by method
            var mottoDb = _unitOfWork.Motto.GetMotto(motto.Id);
            mottoDb.Teller = motto.Teller;
            mottoDb.Text = motto.Text;
            mottoDb.Title = motto.Title;

            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }


        public ActionResult Delete(int? id)
        {
            var motto = _unitOfWork.Motto.GetMotto(id);
            return View(motto);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _unitOfWork.Motto.Delete(id);
            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }

    }
}