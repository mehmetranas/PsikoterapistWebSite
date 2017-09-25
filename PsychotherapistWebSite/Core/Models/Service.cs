using PsychotherapistWebSite.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PsychotherapistWebSite.Core.Models
{
    public class Service
    {
        public Service()
        {
            Images = new HashSet<Image>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Alan Adý")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Açýklama")]
        [StringLength(1000)]
        public string Content { get; set; }

        public ICollection<Image> Images { get; set; }
    }
}