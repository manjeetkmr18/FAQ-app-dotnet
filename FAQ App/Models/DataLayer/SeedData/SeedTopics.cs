using FAQ_App.Models.DomainModels;

namespace FAQ_App.Models.DataLayer.SeedData
{
    public class SeedTopics
    {
        public static List<Topic> GetTopics()
        {
            return new List<Topic>
            {
                new Topic { Id = 1, Name = "JavaScript" },
                new Topic { Id = 2,Name = "Bootstrap" }

            };
        }
    }
}
