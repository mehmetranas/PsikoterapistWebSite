using System.Collections.Generic;
using PsychotherapistWebSite.Core.Models;

namespace PsychotherapistWebSite.Core.Repositories
{
    public interface IFaqRepository
    {
        void Create(Faq faq);
        void Delete(int? id);
        void PutFaq(Faq faq);
        Faq GetFaq(int? id);
        IEnumerable<Faq> GetFaqs();
        IEnumerable<Faq> GetFaqsForHomePag();
        int CountAsSign();
    }
}
