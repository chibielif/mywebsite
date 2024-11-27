namespace My_Website.Models
{
    public class BlogPostViewModel
    {
        public BlogPost? Post { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
