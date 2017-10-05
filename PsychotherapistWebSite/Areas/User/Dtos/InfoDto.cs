namespace PsychotherapistWebSite.Areas.User.Dtos
{
    public class InfoDto
    {
        public int[] ImagesId { get; set; }
        public string PersonName { get; set; }
        public string PersonTitle { get; set; }
        public string Phone { get; set; }
        public int AdressId { get; set; }
        public string FaceBookUrl { get; set; }
        public string YouTubeUrl { get; set; }
        public string TweeterUrl { get; set; }
        public string AboutMe { get; set; }
    }
}