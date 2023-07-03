namespace FAQ_App.Models
{
    public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<FAQ> FAQs { get; set; }
    }
}
