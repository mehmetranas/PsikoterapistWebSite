using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PsychotherapistWebSite.Core.Models;
using PsychotherapistWebSite.Core.Repositories;
using PsychotherapistWebSite.Models;

namespace PsychotherapistWebSite.Areas.User.Controllers
{
    public class AdressesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public AdressesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: User/Adresses
        public ActionResult Index()
        {
            return View(_unitOfWork.Adress.GetAdresses());
        }

        // GET: User/Adresses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adress adress = _unitOfWork.Adress.GetAdress(id);
            if (adress == null)
            {
                return HttpNotFound();
            }
            return View(adress);
        }

        // GET: User/Adresses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Adresses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Place,Street,Number,Town,City, Latitude, LongiTude")] Adress adress)
        {
            if (!ModelState.IsValid) return View(adress);
            _unitOfWork.Adress.Add(adress);
            _unitOfWork.Complete();
            return RedirectToAction("Index");
        }

        // GET: User/Adresses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var adress = _unitOfWork.Adress.GetAdress(id);
            if (adress == null)
            {
                return HttpNotFound();
            }
            return View(adress);
        }

        // POST: User/Adresses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Place,Street,Number,Town,City,Latitude,LongiTude")] Adress adress)
        {
            if (!ModelState.IsValid) return View(adress);
            _unitOfWork.Adress.Put(adress);
            _unitOfWork.Complete();
            return RedirectToAction("Index");
        }

        // GET: User/Adresses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adress adress = _unitOfWork.Adress.GetAdress(id);
            if (adress == null)
            {
                return HttpNotFound();
            }
            return View(adress);
        }

        // POST: User/Adresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _unitOfWork.Adress.Delete(id);
            _unitOfWork.Complete();
            return RedirectToAction("Index");
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
