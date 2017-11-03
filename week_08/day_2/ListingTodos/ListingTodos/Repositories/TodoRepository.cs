using ListingTodos.Entities;
using ListingTodos.Models;
using System.Collections.Generic;
using System.Linq;

namespace ListingTodos.Repositories
{
    public class TodoRepository
    {
        TodoContext TodoContext;

        public TodoRepository(TodoContext todoContext)
        {
            TodoContext = todoContext;
        }

        public List<Todo> GetList()
        {
            return TodoContext.Todos.ToList();
        }
        public List<Todo> NotDoneList()
        {
            var notDone = from title in TodoContext.Todos
                          where title.IsDone == false
                          select title;
            return notDone.ToList();
        }


        public void AddTodo(string title)
        {
            var todo = new Todo()
            {
                Title = title,
                IsDone = false,
                IsUrgent = false
            };

            TodoContext.Todos.Add(todo);
            TodoContext.SaveChanges();
        }

        public void DeleteTodo(int id)
        {
            Todo deleteTodo = TodoContext.Todos.FirstOrDefault(x => x.Id == id);
            TodoContext.Todos.Remove(deleteTodo);
            TodoContext.SaveChanges();
        }

        public Todo Updating(int id)
        {
            return TodoContext.Todos.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateTodo(Todo todo)
        {
            TodoContext.Todos.Update(todo);
            TodoContext.SaveChanges();
        }
    }
}