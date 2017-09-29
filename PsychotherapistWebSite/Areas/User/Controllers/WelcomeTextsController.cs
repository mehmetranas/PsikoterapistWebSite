using PsychotherapistWebSite.Core.Models;
using PsychotherapistWebSite.Core.Repositories;
using System.Net;
using System.Web.Mvc;

namespace PsychotherapistWebSite.Areas.User.Controllers
{
    public class WelcomeTextsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public WelcomeTextsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: User/WelcomeTexts
        public ActionResult Index()
        {
            var viewModel = _unitOfWork.WelcomeText.GetWelcomeText();
            return viewModel != null ? View(viewModel) : View();
        }

        // GET: User/WelcomeTexts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var welcomeText = _unitOfWork.WelcomeText.GetWelcomeText();
            if (welcomeText == null)
            {
                return HttpNotFound();
            }
            return View(welcomeText);
        }

        // GET: User/WelcomeTexts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/WelcomeTexts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Content,IsActive")] WelcomeText welcomeText)
        {
            if (!ModelState.IsValid)
                return View(welcomeText);

            _unitOfWork.WelcomeText.Create(welcomeText);
            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }

        // GET: User/WelcomeTexts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var welcomeText = _unitOfWork.WelcomeText.GetWelcomeText();
            if (welcomeText == null)
            {
                return HttpNotFound();
            }
            return View(welcomeText);
        }

        // POST: User/WelcomeTexts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Content,IsActive")] WelcomeText welcomeText)
        {
            if (!ModelState.IsValid) return View(welcomeText);

            _unitOfWork.WelcomeText.PutWelcomeText(welcomeText);
            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }

        // GET: User/WelcomeTexts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var welcomeText = _unitOfWork.WelcomeText.GetWelcomeText();
            if (welcomeText == null)
            {
                return HttpNotFound();
            }
            return View(welcomeText);
        }

        // POST: User/WelcomeTexts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _unitOfWork.WelcomeText.Delete(id);
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
