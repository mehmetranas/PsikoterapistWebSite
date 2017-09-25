using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PsychotherapistWebSite.Models;

namespace PsychotherapistWebSite.Core.ViewModels
{
    public class ServiceViewModel
    {
       public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Alan Adı")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Açıklama")]
        [StringLength(1000)]
        public string Content { get; set; }

        public Image Image1 { get; set; }
        public Image Image2 { get; set; }

        public IEnumerable<Image> Images { get; set; }
    }
}