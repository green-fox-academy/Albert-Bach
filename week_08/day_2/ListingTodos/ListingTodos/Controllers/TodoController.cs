using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace ListingTodos.Controllers
{
    [Route("/todo")]
    public class TodoController : Controller
    {
        //public TodoController(StudentRepository studentRepository)
        //{
        //    StudentRepository = studentRepository;
        //}

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
