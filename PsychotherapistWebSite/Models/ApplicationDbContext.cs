using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using PsychotherapistWebSite.Core.Models;

namespace PsychotherapistWebSite.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Info> Info { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> BlogTexts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Verification> Verifications { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Motto> Mottoes { get; set; }
        public DbSet<Image> Images{ get; set; }
        

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}