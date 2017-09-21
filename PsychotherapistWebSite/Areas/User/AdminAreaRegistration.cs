using System.Web.Mvc;

namespace PsychotherapistWebSite.Areas.User
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName => "User";

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "User/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}