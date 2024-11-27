namespace My_Website.Models
{
    public class Comment
    {
        public int id { get; set; }
        public string subject { get; set; }
        public string commentText { get; set; }
        public string commentWriter { get; set; }
        public DateTime commentDate { get; set; }
        public int postId { get; set; } //foreign key from BlogPost
        public BlogPost BlogPost { get; set; } // for navigation
        public string email { get; set; }
        public string phoneNumber { get; set; }

    }
}
