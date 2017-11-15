using FoxManager.Entities;

namespace FoxManager.Repositories
{
    public class FoxManagerRepository
    {
        FoxManagerContext FoxManagerContext;

        public FoxManagerRepository(FoxManagerContext foxManagerContext)
        {
            FoxManagerContext = foxManagerContext;
        }

        public List<> GetList()
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

    }
}
