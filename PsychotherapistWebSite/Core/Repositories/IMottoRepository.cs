using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PsychotherapistWebSite.Models;

namespace PsychotherapistWebSite.Core.Repositories
{
    public interface IMottoRepository
    {
        IEnumerable<Motto> GetMottoes();
        Motto GetMotto(int? id);
        void Add(Motto motto);
        void Delete(int? id);
    }
}