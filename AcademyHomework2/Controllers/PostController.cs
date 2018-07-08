using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcademyHomework2.Services;
using Microsoft.AspNetCore.Mvc;

namespace AcademyHomework2.Controllers
{
    public class PostController : Controller
    {
        private UserService userService;

        public PostController()
        {
            userService = new UserService();
        }

        //GET: Post/index/{id}
        public IActionResult GetPost(int id)
        {
            var post = userService.GetPostById(id);
            if (post == null)
            {
                return new NotFoundResult();
            }
            else
            {
                ViewBag.User = userService.GetUserById(post.UserId);
                ViewBag.GetUserByCommentIdDict = userService.GetUserByCommentIdDict();
                return View(post);
            }
        }
    }
}