using ListingTodos.Entities;
using ListingTodos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public void AddTodo()
        {
            var todo = new Todo()
            {
                Title = "Feed the monkey",
                IsDone = true,
                IsUrgent = true
            };

            TodoContext.Todos.Add(todo);
            TodoContext.SaveChanges();
        }

        public Todo GetLastTodo()
        {
            return TodoContext.Todos.Last();
        }

    }
}