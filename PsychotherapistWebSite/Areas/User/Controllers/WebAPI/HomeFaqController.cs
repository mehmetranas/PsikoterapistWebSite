using PsychotherapistWebSite.Core.Repositories;
using System.Web.Http;

namespace PsychotherapistWebSite.Areas.User.Controllers.WebAPI
{
    public class HomeFaqController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomeFaqController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public IHttpActionResult Add(int? id)
        {
            if (id == null) return BadRequest();

            var faqDb = _unitOfWork.Faq.GetFaq(id);
            var countSignFaq = _unitOfWork.Faq.CountAsSign();
            if (faqDb == null || countSignFaq >= 2) return BadRequest();
            faqDb.IsDisplayOnHomePage = true;
            _unitOfWork.Complete();

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int? id)
        {
            if (id == null) return BadRequest();

            var faqDb = _unitOfWork.Faq.GetFaq(id);
            faqDb.IsDisplayOnHomePage = false;
            _unitOfWork.Complete();

            return Ok();
        }
    }
}
