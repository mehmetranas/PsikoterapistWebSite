using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PsychotherapistWebSite.Core.ViewModels
{
    public class FaqViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public bool IsDisplayOnHomePage { get; set; }
        public string TruncateText => Text.Length > 20 ? Text.Substring(0, 20) : Text;
    }
}