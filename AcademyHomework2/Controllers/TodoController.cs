using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcademyHomework2.Services;
using Microsoft.AspNetCore.Mvc;

namespace AcademyHomework2.Controllers
{
    public class TodoController : Controller
    {
        UserService userService;

        public TodoController()
        {
            userService = new UserService();
        }
        //GET: todo/GetTodo/{id}
        public IActionResult GetTodo(int id)
        {
            var todo = userService.GetTodoById(id);
            if (todo == null)
            {
                return new NotFoundResult();
            }
            else
            {
                ViewBag.User = userService.GetUserById(todo.UserId);
                return View(todo);
            }
        }
    }
}
