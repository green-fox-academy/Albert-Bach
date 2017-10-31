using ListingTodos.Entities;
using ListingTodos.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace ListingTodos.Controllers
{
    [Route("/todo")]
    public class TodoController : Controller
    {
        TodoRepository TodoRepository;

        public TodoController(TodoRepository todoRepository)
        {
            TodoRepository = todoRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("/")]
        [Route("/list")]
        public IActionResult List()
        {
            string words = "This is my first todo";
            return View((object)words);
        }
    }   
}
