using AutoMapper;
using PsychotherapistWebSite.Core.Dtos;
using PsychotherapistWebSite.Core.Models;
using PsychotherapistWebSite.Core.ViewModels;
using PsychotherapistWebSite.Models;

namespace PsychotherapistWebSite.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Service, ServiceDto>();
            CreateMap<Service, ServiceViewModel>();
            CreateMap<ServiceViewModel, Service>();
            CreateMap<ServiceDto, Service>();
            CreateMap<Motto, Motto>();
            CreateMap<Service, Service>();
        }
    }
}