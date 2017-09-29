using PsychotherapistWebSite.Core.Models;
using PsychotherapistWebSite.Core.Repositories;
using System.Net;
using System.Web.Mvc;

namespace PsychotherapistWebSite.Areas.User.Controllers
{
    public class FaqsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public FaqsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: User/Faqs
        public ActionResult Index()
        {
            return View(_unitOfWork.Faq.GetFaqs());
        }

        // GET: User/Faqs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
           
            var faq = _unitOfWork.Faq.GetFaq(id);
            if (faq == null)
            {
                return HttpNotFound();
            }
            return View(faq);
        }

        // GET: User/Faqs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Faqs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Text")] Faq faq)
        {
            if (!ModelState.IsValid) return View(faq);
            _unitOfWork.Faq.Create(faq);
            _unitOfWork.Complete();
            return RedirectToAction("Index");
        }

        // GET: User/Faqs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var faq = _unitOfWork.Faq.GetFaq(id);
            if (faq == null)
            {
                return HttpNotFound();
            }
            return View(faq);
        }

        // POST: User/Faqs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Text")] Faq faq)
        {
            if (!ModelState.IsValid) return View(faq);
            _unitOfWork.Complete();
            return RedirectToAction("Index");
        }

        // GET: User/Faqs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Faq faq = _unitOfWork.Faq.GetFaq(id);
            if (faq == null)
            {
                return HttpNotFound();
            }
            return View(faq);
        }

        // POST: User/Faqs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _unitOfWork.Faq.Delete(id);
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
