using Microsoft.AspNetCore.Mvc;
using My_Website.Infrastructure;
using My_Website.Models;
using Mysqlx.Crud;
using System.Diagnostics;

namespace My_Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BlogPostRepository _blogPostRepository;
        private readonly CommentRepository _commentRepository;

        public HomeController(ILogger<HomeController> logger, BlogPostRepository blogPostRepository, CommentRepository commentRepository)
        {
            _logger = logger;
            _blogPostRepository = blogPostRepository;
            _commentRepository = commentRepository;
        }

        public IActionResult Index()
        {
            IndexViewModel vm = new IndexViewModel();
            vm.Posts = _blogPostRepository.GetAllPosts();
            return View(vm);
        }

        public IActionResult BlogPostDark(int id)
        {
            BlogPostViewModel vm = new BlogPostViewModel();
            vm.Post = _blogPostRepository.GetPost(id);
            vm.Comments = _commentRepository.GetComments(id);
            return View("BlogPostDark",vm);
        }

        //public IActionResult AddComment(Comment comment)
        //{
        //    //Insert et
        //    //Blogpost sayfas?na yönlendir.
        //    Response.Redirect("");
        //}



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
