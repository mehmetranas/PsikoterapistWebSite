using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using PsychotherapistWebSite.Areas.User.Dtos;
using PsychotherapistWebSite.Core.Dtos;
using PsychotherapistWebSite.Core.Models;
using PsychotherapistWebSite.Core.Repositories;

namespace PsychotherapistWebSite.Controllers.Web_API
{
    public class HomeInfoController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomeInfoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public HomeInfoDto GetInfo()
        {
            var info = _unitOfWork.Info.GetHomeInfo();

            return info;
        }
    }
}
