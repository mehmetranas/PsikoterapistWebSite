using PsychotherapistWebSite.Core.Models;
using PsychotherapistWebSite.Core.Repositories;
using PsychotherapistWebSite.Core.ViewModels.PartialsViewModels;
using System.Linq;
using System.Web.Mvc;

namespace PsychotherapistWebSite.Controllers
{
    public class PartialsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly Info _info;
        private readonly WelcomeText _welcomeText;

        public PartialsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _info = unitOfWork.Info.GetInfo();
            _welcomeText = unitOfWork.WelcomeText.GetWelcomeText();
        }

        // GET: Partials
        [ChildActionOnly]
        public ActionResult TopBackground()
        {
            ViewBag.PersonName = $"{_info.PersonTitle} {_info.PersonName}";
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult Top()
        {
            var model = new TopViewModel()
            {
                Adress = _info.Adress,
                Phone = _info.Phone,
                RestDay = _welcomeText.NoteForClosedDay,
                WorkDay = _welcomeText.DaysHour
            };

            return PartialView(model);
        }

        [ChildActionOnly]
        public ActionResult About()
        {
            var model = new AboutViewModel()
            {
                Text = _info.TruncateContent,
                PictureUrl = _info.Images.FirstOrDefault()?.Url,
                PersonName = _info.PersonName,
                PersoneTitle = _info.PersonTitle
            };

            return PartialView(model);
        }
    }
}