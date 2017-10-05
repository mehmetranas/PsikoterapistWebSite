using AutoMapper;
using PsychotherapistWebSite.Areas.User.Dtos;
using PsychotherapistWebSite.Core.Repositories;
using System.Web.Http;
using PsychotherapistWebSite.Core.Models;
using WebGrease.Css.Extensions;

namespace PsychotherapistWebSite.Areas.User.Controllers.WebAPI
{
    public class InfoController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public InfoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        [HttpPost]
        public IHttpActionResult Edit(InfoDto infoDto)
        {
            var infoDb = _unitOfWork.Info.GetInfo();
            Mapper.Map(infoDto,infoDb);
            infoDb.Images.Clear();
            foreach (var i in infoDto.ImagesId)
            {
                var image = _unitOfWork.Image.GetImage(i);
                infoDb.Images.Add(image);
            }
            _unitOfWork.Complete();
            return Ok();
        }
    }
}
