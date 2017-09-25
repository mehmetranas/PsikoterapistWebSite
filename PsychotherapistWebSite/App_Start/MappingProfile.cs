using AutoMapper;
using PsychotherapistWebSite.Core.Dtos;
using PsychotherapistWebSite.Core.Models;
using PsychotherapistWebSite.Models;

namespace PsychotherapistWebSite.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Service, ServiceDto>();
            CreateMap<ServiceDto, Service>();
            CreateMap<Motto, Motto>();
            CreateMap<Service, Service>();
        }
    }
}