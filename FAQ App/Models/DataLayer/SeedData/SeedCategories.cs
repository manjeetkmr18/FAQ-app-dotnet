using FAQ_App.Models.DomainModels;

namespace FAQ_App.Models.DataLayer.SeedData
{
    public class SeedCategories
    {
        public static List<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category { Id = 1, Name = "History" },
                new Category { Id = 2, Name = "General" }
                // Add more categories as needed
            };
        }
    }
}
