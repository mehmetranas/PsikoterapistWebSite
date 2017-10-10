using PsychotherapistWebSite.Core.Dtos;
using PsychotherapistWebSite.Core.Repositories;
using System.Web.Http;

namespace PsychotherapistWebSite.Areas.User.Controllers.WebAPI
{
    public class MessageController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public MessageController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public IHttpActionResult Create(MessageDto messageDto)
        {
            return Ok();
        }
    }
}
