using ListingTodos.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ListingTodos.Controllers
{
    public class TodoController : Controller
    {
        TodoRepository TodoRepository;

        public TodoController(TodoRepository todoRepository)
        {
            TodoRepository = todoRepository;
        }

        [Route("/")]
        [HttpGet]
        public IActionResult List(bool IsActive)
        {
            if (IsActive)
            {
                return View(TodoRepository.NotDoneList());
            }
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

        [Route("/{id}/delete")]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            TodoRepository.DeleteTodo(id);
            return RedirectToAction("List");
        }

        [Route("/{id}/update")]
        [HttpPost]
        public IActionResult Update(int id)
        {
            var todo = TodoRepository.Updating(id);
            return View(todo);
        }

        [Route("/{id}/edit")]
        [HttpPost]
        public IActionResult Edit(ListingTodos.Models.Todo todo)
        {
            TodoRepository.UpdateTodo(todo);
            return RedirectToAction("List");
        }
    }
}