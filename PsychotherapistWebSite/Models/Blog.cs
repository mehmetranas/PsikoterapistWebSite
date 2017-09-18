using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PsychotherapistWebSite.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public string Writter { get; set; }

        public DateTime DateTime => DateTime.Now;

        public Blog()
        {
            Categories = new List<Category>();
            Comments = new List<Comment>();
        }
    }
}