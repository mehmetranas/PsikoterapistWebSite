using AutoMapper;
using PsychotherapistWebSite.Core.Dtos;
using PsychotherapistWebSite.Core.Models;

namespace PsychotherapistWebSite.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Service, ServiceDto>();
            CreateMap<ServiceDto, Service>();
        }
    }
}