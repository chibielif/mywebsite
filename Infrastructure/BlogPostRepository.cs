using Dapper;
using My_Website.Models;

namespace My_Website.Infrastructure
{
    public class BlogPostRepository
    {
        private readonly Database _context;

        public BlogPostRepository(Database context) {
            _context = context;
        }
        public List<Models.BlogPost> GetAllPosts()
        {
            List<Models.BlogPost> posts = new List<Models.BlogPost>();
            using (var conn = _context.CreateConnection())
            {
                posts = conn.Query<Models.BlogPost>("SELECT * FROM blog.blog_post;").ToList();
            }
            
            return posts;
        }

        public BlogPost GetPost(int id)
        {
            using (var conn = _context.CreateConnection())
            {
                var query = $"SELECT * FROM blog.blog_post WHERE id = {id};";
                var post = conn.QuerySingleOrDefault<Models.BlogPost>(query);
                return post;
            }
        }

    }
}
