using FAQ_App.Models.DomainModels;

namespace FAQ_App.Models.DataLayer.SeedData
{
    public class SeedFAQs
    {
        public static List<FAQ> GetFAQs()
        {
            return new List<FAQ>
            {
                new FAQ { FAQId = 1, Question = "Who invented JavaScript?", Answer = "JavaScript was created by Brendan Eich.", CategoryId = 1, TopicId = 1 },
                new FAQ { FAQId = 2, Question = "What is Bootstrap?", Answer = "Bootstrap is a popular CSS framework that helps you build responsive and mobile-first websites.", CategoryId = 2, TopicId = 2 },
                new FAQ { FAQId = 3, Question = "What is JavaScript?", Answer = "JavaScript is a programming language that allows you to add interactivity and dynamic content to websites.", CategoryId = 2, TopicId = 1 }
            };
        }
    }
}
