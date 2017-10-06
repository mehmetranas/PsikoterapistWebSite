namespace PsychotherapistWebSite.Areas.User.Dtos
{
    public class MessageDto
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Title { get; set; }
        public string Context { get; set; }
        public bool IsRead { get; set; }
    }
}