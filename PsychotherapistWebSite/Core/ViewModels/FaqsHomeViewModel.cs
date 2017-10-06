using PsychotherapistWebSite.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace PsychotherapistWebSite.Core.ViewModels
{
    public class FaqsHomeViewModel
    {
        public FaqsHomeViewModel(IEnumerable<Faq> faqs)
        {
            Faqs = faqs;
        }

        private IEnumerable<Faq> Faqs { get; }
        public IEnumerable<Faq> Part1 => Faqs.Take(Faqs.Count() - Faqs.Count() / 2);
        public IEnumerable<Faq> Part2 => Faqs.Take(Faqs.Count() / 2);
    }
}