namespace FAQ_App.Models
{
    public class Topic
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<FAQ> FAQs { get; set; }
    }
}
