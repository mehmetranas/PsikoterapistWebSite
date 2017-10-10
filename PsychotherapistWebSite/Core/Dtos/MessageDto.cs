using System;

namespace PsychotherapistWebSite.Core.Dtos
{
    public class MessageDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string MessageText { get; set; }
        public bool IsRead { get; set; }
        public DateTime DateTime { get; set; }
    }
}