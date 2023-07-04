using FAQ_App.Models.DomainModels;
using Microsoft.EntityFrameworkCore;


namespace FAQ_App.Models.DataLayer
{
    public class FAQContext : DbContext
    {
        public FAQContext(DbContextOptions<FAQContext> options) : base(options)
        {
        }

        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed topics
            modelBuilder.Entity<Topic>().HasData(SeedData.SeedTopics.GetTopics());

            // Seed categories
            modelBuilder.Entity<Category>().HasData(SeedData.SeedCategories.GetCategories());

            // Seed FAQs
            modelBuilder.Entity<FAQ>().HasData(SeedData.SeedFAQs.GetFAQs());

        }
    }
}
