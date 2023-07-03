namespace FAQ_App.Models
{
    public class FAQ
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

        public string TopicId { get; set; }
        public string CategoryId { get; set; }
        public virtual Topic Topic { get; set; }
        public virtual Category Category { get; set; }
    }
}
