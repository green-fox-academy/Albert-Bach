using ListingTodos.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace ListingTodos.Controllers
{
    public class TodoController : Controller
    {
        TodoRepository TodoRepository;

        public TodoController(TodoRepository todoRepository)
        {
            TodoRepository = todoRepository;
        }

        [Route("/todo")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/")]
        [Route("/list")]
        public IActionResult List()
        {
            return View(TodoRepository.GetList());
        }

        [Route("/todo/add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [Route("/todo/add")]
        [HttpPost]
        public IActionResult Add(string title)
        {
            TodoRepository.AddTodo(title);
            return RedirectToAction("List");
        }

    }
}