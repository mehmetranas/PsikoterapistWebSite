using AutoMapper;
using PsychotherapistWebSite.Core.Dtos;
using PsychotherapistWebSite.Core.Models;
using PsychotherapistWebSite.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace PsychotherapistWebSite.Areas.User.Controllers.WebAPI
{
    public class ServiceController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public ServiceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public IHttpActionResult Create(ServiceDto serviceDto)
        {
            var service = Mapper.Map<Service>(serviceDto);
            service.Images = _unitOfWork.Image.GetImages()
                .Where(i => i.Id == serviceDto.ImageId1 || i.Id == serviceDto.ImageId2)
                .ToList();
        
            _unitOfWork.Service.AddService(service);
            _unitOfWork.Complete(); 

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete([FromBody]int id)
        {
            _unitOfWork.Service.DeleteService(id);
            _unitOfWork.Complete();
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Edit(ServiceDto serviceDto)
        {
            var service = Mapper.Map<Service>(serviceDto);
            service.Images = _unitOfWork.Image.GetImages()
                .Where(i => i.Id == serviceDto.ImageId1 || i.Id == serviceDto.ImageId2)
                .ToList();
          
            _unitOfWork.Service.PutService(service);
            _unitOfWork.Complete();

            return Ok();

        }
       
    }
}
