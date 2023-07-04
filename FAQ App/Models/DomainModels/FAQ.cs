using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FAQ_App.Models.DomainModels
{
    public class FAQ
    {
        [Key]
        public int FAQId { get; set; }

        public string Question { get; set; }

        public string Answer { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        [ForeignKey("Topic")]
        public int TopicId { get; set; }

        public Category Category { get; set; }

        public Topic Topic { get; set; }
    }
}
