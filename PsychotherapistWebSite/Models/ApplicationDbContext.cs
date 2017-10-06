using Microsoft.AspNet.Identity.EntityFramework;
using PsychotherapistWebSite.Core.Models;
using System.Data.Entity;

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
        public DbSet<WelcomeText> WelcomeTexts{ get; set; }
        public DbSet<Message> Messages { get; set; }
        

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Slide>()
                .HasRequired(s => s.Image);
            modelBuilder.Entity<Slide>()
                .HasRequired(s => s.Motto);

            modelBuilder.Entity<Service>()
                .HasMany(s => s.Images)
                .WithMany();

            modelBuilder.Entity<Info>()
                .HasMany(i => i.Images)
                .WithMany();


            base.OnModelCreating(modelBuilder);
        }
    }
}