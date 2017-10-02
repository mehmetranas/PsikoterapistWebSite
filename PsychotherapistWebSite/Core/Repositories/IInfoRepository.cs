using PsychotherapistWebSite.Core.Models;

namespace PsychotherapistWebSite.Core.Repositories
{
    public interface IInfoRepository
    {
        Info GetInfo();
        void Add(Info info);
        void Delete();
        void Put(Info info);
        string AboutMe();
    }
}