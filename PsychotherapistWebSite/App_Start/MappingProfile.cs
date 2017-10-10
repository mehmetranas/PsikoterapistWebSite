using AutoMapper;
using PsychotherapistWebSite.Areas.User.Dtos;
using PsychotherapistWebSite.Core.Dtos;
using PsychotherapistWebSite.Core.Models;
using PsychotherapistWebSite.Core.ViewModels;

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
            CreateMap<Faq, Faq>();
            CreateMap<Faq, FaqViewModel>();
            CreateMap<FaqViewModel, Faq>();
            CreateMap<Info, Info>();
            CreateMap<Adress, Adress>();
            CreateMap<InfoDto, Info>();
            CreateMap<MessageDto, Messages>();
            CreateMap<Messages, MessageDto>();
        }
    }
}