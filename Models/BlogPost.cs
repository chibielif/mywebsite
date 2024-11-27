namespace My_Website.Models
{
    public class BlogPost
    {
        public int id { get; set; }
        public string title { get; set; }
        public string text { get; set; }
        public string writer { get; set; }
        public DateTime date { get; set; }
        public string image { get; set; }
        public string tag { get; set; }
        public string description { get; set; }
    }
}
