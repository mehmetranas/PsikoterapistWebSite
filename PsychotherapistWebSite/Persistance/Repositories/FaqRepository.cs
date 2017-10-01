using PsychotherapistWebSite.Core.Models;
using PsychotherapistWebSite.Core.Repositories;
using PsychotherapistWebSite.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace PsychotherapistWebSite.Persistance.Repositories
{
    public class FaqRepository: IFaqRepository
    {
        private readonly ApplicationDbContext _context;

        public FaqRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Create(Faq faq)
        {
            if(faq != null)
            _context.Faqs.Add(faq);
        }

        public void Delete(int? id)
        {
            var faq = _context.Faqs.FirstOrDefault(f => f.Id == id);
            if (faq != null)
                _context.Faqs.Remove(faq);
        }

        public void PutFaq(Faq faq)
        {
            if(faq == null) return;

            var faqDb = _context.Faqs.FirstOrDefault(f => f.Id == faq.Id);
            if (faqDb != null)
            {
                _context.Entry(faq).State = EntityState.Modified;
            }
        }

        public Faq GetFaq(int? id)
        {
            return _context.Faqs.FirstOrDefault(f => f.Id ==id);
        }

        public IEnumerable<Faq> GetFaqs()
        {
            return _context.Faqs.ToList();
        }

        public IEnumerable<Faq> GetFaqsForHomePag()
        {
            return _context.Faqs.Where(f => f.IsDisplayOnHomePage).ToList();

        }

        public int CountAsSign()
        {
            return _context.Faqs.Count(f => f.IsDisplayOnHomePage);
        }
    }
}