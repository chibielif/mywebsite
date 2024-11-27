using Dapper;
using My_Website.Models;

namespace My_Website.Infrastructure
{
    public class CommentRepository
    {
        private readonly Database _context;

        public CommentRepository(Database context)
        {
            _context = context;
        }

        public List<Comment> GetAllComments()
        {
            List<Comment> comments = new List<Comment>();
            using (var conn = _context.CreateConnection())
            {
                comments = conn.Query<Comment>("SELECT * FROM blog.comment;").ToList();
            }
            return comments;
        }

        public List<Comment> GetComments(int postId)
        {
            List<Comment> comments = new List<Comment>();
            using (var conn = _context.CreateConnection())
            {
                comments = conn.Query<Comment>($"SELECT * FROM blog.comment WHERE postId = {postId};").ToList();
                return comments;
            }
        }

        public void AddComment(Comment comment) {
            using (var conn = _context.CreateConnection())
            {
                conn.Query<Comment>($"INSERT INTO blog.comment ({nameof(Comment.postId)},) VALUES ({comment.postId},)");
            }
        }
    }
}
