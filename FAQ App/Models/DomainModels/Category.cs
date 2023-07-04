using System.ComponentModel.DataAnnotations;

namespace FAQ_App.Models.DomainModels
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<FAQ> FAQs { get; set; }
    }
}
