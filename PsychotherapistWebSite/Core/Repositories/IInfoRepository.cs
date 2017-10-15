using PsychotherapistWebSite.Core.Dtos;
using PsychotherapistWebSite.Core.Models;

namespace PsychotherapistWebSite.Core.Repositories
{
    public interface IInfoRepository
    {
        Info GetInfo();
        HomeInfoDto GetHomeInfo();
        void Add(Info info, Image[] images);
        void Delete();
        void Put(Info info, int image1, int image2);
        string AboutMe();
    }
}