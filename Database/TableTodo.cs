using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{    
    public class TableTodo : ITableTodo
    {
        private List<Domains.Todo> collection = new List<Domains.Todo>();

        public List<Domains.Todo> Select(Domains.Filter filter) 
        { 
            if (filter?.Ids == null) return collection;

            return (List<Domains.Todo>)collection.Select(x => filter.Ids.Contains(x.Id));
        }

        public List<Domains.Todo> Select()
        {
            return collection;
        }

        public bool Insert(Domains.Todo todo) 
        {
            var record = GetRecord(todo.Id);
            
            if (record != null) return false;

            collection.Add(todo);
            return true;
        }

        public bool Update(Domains.Todo todo)
        {
            var record = GetRecord(todo.Id);

            if (record == null) return false;

            record.Title = todo.Title;
            record.IsActual = todo.IsActual;
            return true;
        }

        public bool Delete(Guid id) 
        {
            var record = GetRecord(id);

            if (record == null) return false;

            collection.Remove(record);

            return true;
        }

        private Domains.Todo? GetRecord(Guid id)
        {
            return collection.Find(x => x.Id == id);
        }
    }
}
