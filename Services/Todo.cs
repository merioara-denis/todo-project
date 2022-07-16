namespace Services
{
    public class Todo : ITodo
    {
        private Database.ITableTodo _tableTodo;

        public Todo(Database.ITableTodo tableTodo)
        {
            _tableTodo = tableTodo;
        }

        public Domains.Todo Create(Domains.Inctance inctance)
        {
            Domains.Todo todo = new Domains.Todo(inctance.Title);
            _tableTodo.Insert(todo);
            return todo;
        }

        public Domains.Todo Read(Guid id)
        {
            Domains.Filter filter = new Domains.Filter();
            filter.Ids = new List<Guid>() { id };

            return _tableTodo.Select(filter).First();
        }

        public IEnumerable<Domains.Todo> Read()
        {
            return _tableTodo.Select();
        }

        public Domains.Todo Update(Guid id, Domains.Inctance inctance)
        {
            Domains.Todo todo = new Domains.Todo(inctance.Title);
            todo.IsActual = inctance.IsActual;
            todo.Id = id;
            bool result = _tableTodo.Update(todo);

            if (result == false) return null;

            return todo;
        }

        public bool Delete(Guid id)
        {
            return _tableTodo.Delete(id);
        }
    }
}