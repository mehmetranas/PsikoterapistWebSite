using PsychotherapistWebSite.Core.Repositories;
using System.Net;
using System.Web.Mvc;

namespace PsychotherapistWebSite.Areas.User.Controllers
{
    public class MessagesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public MessagesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: User/Messages
        public ActionResult Index()
        {
            return View(_unitOfWork.Message.GetMessages());
        }

        // GET: User/Messages/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var messages = _unitOfWork.Message.GetMessage(id);
            if (messages == null)
            {
                return HttpNotFound();
            }
            return View(messages);
        }

        public ActionResult Delete(int id)
        {
            _unitOfWork.Message.Delete(id);
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
