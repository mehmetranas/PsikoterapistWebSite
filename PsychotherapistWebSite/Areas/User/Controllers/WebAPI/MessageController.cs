using System.Linq;
using AutoMapper;
using PsychotherapistWebSite.Core.Dtos;
using PsychotherapistWebSite.Core.Models;
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
            var message = Mapper.Map<MessageDto, Messages>(messageDto);
            _unitOfWork.Message.Add(message);
            _unitOfWork.Complete();
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            _unitOfWork.Message.Delete(id);
            _unitOfWork.Complete();
            return Ok();
        }

        [HttpPost]
        public IHttpActionResult Read(int id)
        {
            var message = _unitOfWork.Message.GetMessage(id);
            message.Read();
            _unitOfWork.Complete();

            return Ok();
        }

        [HttpGet]
        public int GetUnreadMessageCount()
        {
            var result = _unitOfWork.Message.UnReadMessage().Count();
            return result;
        }
    }
}
