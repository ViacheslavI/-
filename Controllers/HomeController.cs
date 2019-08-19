using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LDForum.Models;
using LDForum.Models.Home;
using LDForum.Data;
using LDForum.Models.Post;
using LDForum.Data.Models;
using LDForum.Models.Forum;

namespace LDForum.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPost _postService;
       public HomeController(IPost postService)
        {
            _postService = postService;
        }

        public IActionResult Index()
        {
            var model = BuildHomeIndexModel();
            return View(model);
        }

        private HomeIndexModel BuildHomeIndexModel()
        {
            var latestPosts = _postService.GetLatestPosts(10);
            var posts = latestPosts.Select(post => new PostListingModel
            {
                Id = post.Id,
                Title = post.Title,
                AuthorName = post.User.UserName,
                AuthorId = post.User.Id,
                AuthorRating = post.User.Rating,
                DatePosted = post.Created.ToString(),
                RepliesCount = post.Replies.Count(),
                Forum = GetForumListingForPost(post)
            });
            return new HomeIndexModel
            {
                LatestPosts= posts,
                SearchQuery=""
            };
        }

        private ForumListingModel GetForumListingForPost(Post post)
        {
            var forum = post.Forum;
            return new ForumListingModel
                {
                Id=forum.Id,
                Name=forum.Title,
                ImageUrl=forum.ImagesUrl
            
            };
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
