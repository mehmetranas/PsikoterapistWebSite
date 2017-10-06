using System.Collections.Generic;
using PsychotherapistWebSite.Core.Models;

namespace PsychotherapistWebSite.Core.Repositories
{
    public interface IAdressRepository
    {
        void Add(Adress adress);
        void Delete(int? id);
        IEnumerable<Adress> GetAdresses();
        Adress GetAdress(int? id);
        void Put(Adress adress);
    }
}