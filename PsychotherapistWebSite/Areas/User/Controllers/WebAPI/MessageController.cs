using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PsychotherapistWebSite.Areas.User.Dtos;
using PsychotherapistWebSite.Core.Repositories;

namespace PsychotherapistWebSite.Areas.User.Controllers.WebAPI
{
    public class MessageController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public MessageController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IHttpActionResult Add(MessageDto messageDto)
        {
            
        }

    }
}
